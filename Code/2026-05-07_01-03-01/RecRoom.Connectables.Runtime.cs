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
		[Cpp2IlInjected.Address(RVA = "0x9748270", Offset = "0x9746C70", VA = "0x189748270", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x222F660", Offset = "0x222E060", VA = "0x18222F660", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x97539C0", Offset = "0x97523C0", VA = "0x1897539C0")]
		private void QLHWPSDGGQL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9753870", Offset = "0x9752270", VA = "0x189753870")]
		private void QLCPSLJIXFC(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9753B10", Offset = "0x9752510", VA = "0x189753B10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9753E20", Offset = "0x9752820", VA = "0x189753E20")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZUTXCLCUZTW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x97535C0", Offset = "0x9751FC0", VA = "0x1897535C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZUZDZRWSJFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9753630", Offset = "0x9752030", VA = "0x189753630")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1007340", Offset = "0x1005D40", VA = "0x181007340")]
			[DebuggerHidden]
			public NNRMKMQOLGP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x97484B0", Offset = "0x9746EB0", VA = "0x1897484B0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9748590", Offset = "0x9746F90", VA = "0x189748590", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9748910", Offset = "0x9747310", VA = "0x189748910")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x97488F0", Offset = "0x97472F0", VA = "0x1897488F0")]
			private void SMGDSKUDEQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9748930", Offset = "0x9747330", VA = "0x189748930", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9748400", Offset = "0x9746E00", VA = "0x189748400", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PRMDPODZYPJ> EQRWXNHQVMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9748400", Offset = "0x9746E00", VA = "0x189748400", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDBAB0", Offset = "0xCDA4B0", VA = "0x180CDBAB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2D0", Offset = "0xCD9CD0", VA = "0x180CDB2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool TNBNJETZKYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> CDKBFIFMLOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9749B10", Offset = "0x9748510", VA = "0x189749B10", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x974A6D0", Offset = "0x97490D0", VA = "0x18974A6D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> BPTGUABKDAU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9748E70", Offset = "0x9747870", VA = "0x189748E70", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9748CE0", Offset = "0x97476E0", VA = "0x189748CE0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ, PRMDPODZYPJ> OQFQERAMOHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x974AC40", Offset = "0x9749640", VA = "0x18974AC40", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x97493D0", Offset = "0x9747DD0", VA = "0x1897493D0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x974D4B0", Offset = "0x974BEB0", VA = "0x18974D4B0")]
		public OMConnectableManager(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x97497F0", Offset = "0x97481F0", VA = "0x1897497F0", Slot = "12")]
		public void Initialize(GameObject gameObject, FYZXZUHVIVL configData, MBDTJJXIPKK sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x974B920", Offset = "0x974A320", VA = "0x18974B920", Slot = "26")]
		public void RLHTICJYTWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x974CC10", Offset = "0x974B610", VA = "0x18974CC10", Slot = "22")]
		public bool VWALBJYTFDS(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x974CED0", Offset = "0x974B8D0", VA = "0x18974CED0")]
		private void XGKITLXHOUR(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9748AC0", Offset = "0x97474C0", VA = "0x189748AC0")]
		private void BJDGRQHROUX(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x974D0E0", Offset = "0x974BAE0", VA = "0x18974D0E0")]
		private void YOBVMQYYKKR(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x974A1D0", Offset = "0x9748BD0", VA = "0x18974A1D0")]
		private void LZPIJOOKDKO(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x974B600", Offset = "0x974A000", VA = "0x18974B600", Slot = "14")]
		public void QCIVJGOFOSZ(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "15")]
		public void JLFJVASZUFA(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x974C970", Offset = "0x974B370", VA = "0x18974C970", Slot = "17")]
		public void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x974CAD0", Offset = "0x974B4D0", VA = "0x18974CAD0")]
		public void UYLXRTJCTGR(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x974A640", Offset = "0x9749040", VA = "0x18974A640")]
		public void MBXKBQLQBUH(PRMDPODZYPJ a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9749D50", Offset = "0x9748750", VA = "0x189749D50", Slot = "18")]
		public void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9749A60", Offset = "0x9748460", VA = "0x189749A60")]
		private float JBGXIISQBLL(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9749EB0", Offset = "0x97488B0", VA = "0x189749EB0")]
		public void LCBOFLKLKKD(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x974A060", Offset = "0x9748A60", VA = "0x18974A060", Slot = "19")]
		public void LKGBKCTCCGH(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x974B400", Offset = "0x9749E00", VA = "0x18974B400", Slot = "16")]
		public void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "20")]
		public ConnectableGraphData VROMMHYETCS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "21")]
		public ConnectableGraphData IFBHFRSWOZI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9749FF0", Offset = "0x97489F0", VA = "0x189749FF0", Slot = "23")]
		public void LGIEHBRUTYL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9748E00", Offset = "0x9747800", VA = "0x189748E00", Slot = "24")]
		public void EOGDHVZDGCT(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x974B900", Offset = "0x974A300", VA = "0x18974B900", Slot = "25")]
		public void QUTUUOQJBMY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x974C3E0", Offset = "0x974ADE0", VA = "0x18974C3E0")]
		private void TEBJDGFBFPR(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x974BAF0", Offset = "0x974A4F0", VA = "0x18974BAF0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9748D90", Offset = "0x9747790", VA = "0x189748D90")]
		private void DGTGTUZGWQY(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9749760", Offset = "0x9748160", VA = "0x189749760")]
		[IteratorStateMachine(typeof(NNRMKMQOLGP))]
		public IEnumerable<PRMDPODZYPJ> HVRFFJSJNHL(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x974A780", Offset = "0x9749180", VA = "0x18974A780")]
		internal PRMDPODZYPJ MLIZUSEXGWO(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x974C7E0", Offset = "0x974B1E0", VA = "0x18974C7E0")]
		internal ObjectLocalId UNMVSDJRIPY(PRMDPODZYPJ a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x974AE80", Offset = "0x9749880", VA = "0x18974AE80")]
		private bool PEQGOGWRTLJ(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9748F60", Offset = "0x9747960", VA = "0x189748F60")]
		private bool FDAFBPAIZZR(MERFDKTLKAK a, [Out] PRMDPODZYPJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x974A8B0", Offset = "0x97492B0", VA = "0x18974A8B0")]
		private PRMDPODZYPJ MLIZUSEXGWO(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x974CD50", Offset = "0x974B750", VA = "0x18974CD50")]
		private PRMDPODZYPJ XFWOBSUEUJV(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9749590", Offset = "0x9747F90", VA = "0x189749590")]
		private PRMDPODZYPJ GFRREJCREGY(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9748F20", Offset = "0x9747920", VA = "0x189748F20")]
		private static Guid FBNEAAKWYYB(MERFDKTLKAK a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x974CC60", Offset = "0x974B660", VA = "0x18974CC60")]
		private string WRHBIXVFEWQ(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9749BC0", Offset = "0x97485C0", VA = "0x189749BC0")]
		private void KGKIBTFBHIX(PRMDPODZYPJ a, PRMDPODZYPJ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9748FC0", Offset = "0x97479C0", VA = "0x189748FC0")]
		private void FHVLHXFNPTT(PRMDPODZYPJ a, PRMDPODZYPJ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x974A5E0", Offset = "0x9748FE0", VA = "0x18974A5E0")]
		private void MBWSAWFKXLR(PRMDPODZYPJ a, PRMDPODZYPJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x974ACF0", Offset = "0x97496F0", VA = "0x18974ACF0")]
		private void PEPWTGEKQKK(PRMDPODZYPJ a, PRMDPODZYPJ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9749480", Offset = "0x9747E80", VA = "0x189749480")]
		private void GESUQTNLFPZ(ObjectLocalId a, PRMDPODZYPJ b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9749150", Offset = "0x9747B50", VA = "0x189749150")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9741120", Offset = "0x973FB20", VA = "0x189741120")]
			internal OMConnectableManager ZJCYWNENSVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9740F60", Offset = "0x973F960", VA = "0x189740F60")]
		public static void EWAMEUPAFYD(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x97410D0", Offset = "0x973FAD0", VA = "0x1897410D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330", Slot = "38")]
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
			[Cpp2IlInjected.Address(RVA = "0x974F0C0", Offset = "0x974DAC0", VA = "0x18974F0C0", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public PRMDPODZYPJ WNUIGSLTVVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x974EA60", Offset = "0x974D460", VA = "0x18974EA60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 HQULZJCFLDI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x974D550", Offset = "0x974BF50", VA = "0x18974D550", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion LDYUXZFQLAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x974DCD0", Offset = "0x974C6D0", VA = "0x18974DCD0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool YHONTLMRTBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x974EDE0", Offset = "0x974D7E0", VA = "0x18974EDE0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<PRMDPODZYPJ> OGVDPLCZWZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x974EB20", Offset = "0x974D520", VA = "0x18974EB20", Slot = "13")]
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
			[Cpp2IlInjected.Address(RVA = "0xD75C80", Offset = "0xD74680", VA = "0x180D75C80", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE68AE0", Offset = "0xE674E0", VA = "0x180E68AE0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x974F2C0", Offset = "0x974DCC0", VA = "0x18974F2C0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x974EFE0", Offset = "0x974D9E0", VA = "0x18974EFE0", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x974F000", Offset = "0x974DA00", VA = "0x18974F000", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x974F120", Offset = "0x974DB20", VA = "0x18974F120", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x974F200", Offset = "0x974DC00", VA = "0x18974F200", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool CYLTCGKDFUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x974E510", Offset = "0x974CF10", VA = "0x18974E510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler NGRHUGNRDIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x974DC80", Offset = "0x974C680", VA = "0x18974DC80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x974EBA0", Offset = "0x974D5A0", VA = "0x18974EBA0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler AYSIQTLKOPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x974EB50", Offset = "0x974D550", VA = "0x18974EB50", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x974E9C0", Offset = "0x974D3C0", VA = "0x18974E9C0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler OUWMLKJEVVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x974D960", Offset = "0x974C360", VA = "0x18974D960", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x974E8D0", Offset = "0x974D2D0", VA = "0x18974E8D0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler RDFZKJIEMYI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x974E920", Offset = "0x974D320", VA = "0x18974E920", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x974E560", Offset = "0x974CF60", VA = "0x18974E560", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x974EEE0", Offset = "0x974D8E0", VA = "0x18974EEE0")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, XLRLGIWMKRP connectableTool, VZSKLKVDAHJ[] connectionPoints, ZPKMYMCROID callbacks, NANHKTWOJXE connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x974D520", Offset = "0x974BF20", VA = "0x18974D520", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "21")]
		public void YATEBHWKNQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x974DE00", Offset = "0x974C800", VA = "0x18974DE00", Slot = "22")]
		public void NXAAPQFELCX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x974E830", Offset = "0x974D230", VA = "0x18974E830", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x974E600", Offset = "0x974D000", VA = "0x18974E600", Slot = "25")]
		public void RWAGQXFTONY(int a, PRMDPODZYPJ b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x974DD30", Offset = "0x974C730", VA = "0x18974DD30", Slot = "26")]
		public void LAEJMKRNPTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x974E230", Offset = "0x974CC30", VA = "0x18974E230", Slot = "27")]
		public void PRJJKIRYPUM(int a, PRMDPODZYPJ b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x974D9B0", Offset = "0x974C3B0", VA = "0x18974D9B0", Slot = "28")]
		public void FGFJBUXBGIK(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x974DE20", Offset = "0x974C820", VA = "0x18974DE20", Slot = "31")]
		public void OOLCSEHEGPB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x974D5B0", Offset = "0x974BFB0", VA = "0x18974D5B0", Slot = "29")]
		public void CBTCLGUIEAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x974EBF0", Offset = "0x974D5F0", VA = "0x18974EBF0", Slot = "30")]
		public void YLLQKJPPZPA(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x974DBB0", Offset = "0x974C5B0", VA = "0x18974DBB0", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x974DA80", Offset = "0x974C480", VA = "0x18974DA80", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD38CF0", Offset = "0xD376F0", VA = "0x180D38CF0", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x974D8C0", Offset = "0x974C2C0", VA = "0x18974D8C0", Slot = "43")]
		public bool CanConnectTo(int slotIndex, PRMDPODZYPJ otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "44")]
		public void ParentChanged(int slotIndex, PRMDPODZYPJ newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "45")]
		public void ChildAdded(int slotIndex, PRMDPODZYPJ newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "46")]
		public void ChildRemoved(int slotIndex, PRMDPODZYPJ removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "47")]
		public void ConnectionModified(int slotIndex, PRMDPODZYPJ parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x974E810", Offset = "0x974D210", VA = "0x18974E810", Slot = "48")]
		public void RootChanged(PRMDPODZYPJ previousRootConnectable, PRMDPODZYPJ newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x974E880", Offset = "0x974D280", VA = "0x18974E880", Slot = "23")]
		public void TEOESWTDIWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x974EA10", Offset = "0x974D410", VA = "0x18974EA10", Slot = "24")]
		public void WMNEXMDXLHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x974DA30", Offset = "0x974C430", VA = "0x18974DA30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0x97489C0", Offset = "0x97473C0", VA = "0x1897489C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9748970", Offset = "0x9747370", VA = "0x189748970", Slot = "5")]
		private void EZUYJSDOFYP(GZOGVDISCYD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF3F700", Offset = "0xF3E100", VA = "0x180F3F700", Slot = "6")]
		private void YIQUJNZVLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool TNBNJETZKYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> CDKBFIFMLOG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x973F2A0", Offset = "0x973DCA0", VA = "0x18973F2A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x973F350", Offset = "0x973DD50", VA = "0x18973F350", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> BPTGUABKDAU
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x973F140", Offset = "0x973DB40", VA = "0x18973F140", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x973F090", Offset = "0x973DA90", VA = "0x18973F090", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ, PRMDPODZYPJ> OQFQERAMOHG
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x973F400", Offset = "0x973DE00", VA = "0x18973F400", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x973F1F0", Offset = "0x973DBF0", VA = "0x18973F1F0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "26")]
		public void RLHTICJYTWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "12")]
		public void Initialize(GameObject gameObject, FYZXZUHVIVL configData, MBDTJJXIPKK rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "14")]
		public void QCIVJGOFOSZ(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "15")]
		public void JLFJVASZUFA(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "16")]
		public void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "17")]
		public void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "18")]
		public void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "19")]
		public void LKGBKCTCCGH(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "20")]
		public ConnectableGraphData VROMMHYETCS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "21")]
		public ConnectableGraphData IFBHFRSWOZI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "22")]
		public bool VWALBJYTFDS(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "23")]
		public void LGIEHBRUTYL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "24")]
		public void EOGDHVZDGCT(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "25")]
		public void QUTUUOQJBMY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0xE70C80", Offset = "0xE6F680", VA = "0x180E70C80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public MSFLIDTCQZE DNATBRWDQKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9740400", Offset = "0x973EE00", VA = "0x189740400")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x97404C0", Offset = "0x973EEC0", VA = "0x1897404C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9740AA0", Offset = "0x973F4A0", VA = "0x189740AA0")]
		public ConnectableLink(PRMDPODZYPJ connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9740A00", Offset = "0x973F400", VA = "0x189740A00")]
		public ConnectableLink(PRMDPODZYPJ connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9740970", Offset = "0x973F370", VA = "0x189740970")]
		public ConnectableLink(PRMDPODZYPJ connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9740510", Offset = "0x973EF10", VA = "0x189740510", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x97405C0", Offset = "0x973EFC0", VA = "0x1897405C0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9069D30", Offset = "0x9068730", VA = "0x189069D30", Slot = "4")]
		public void Initialize(Transform transform, MSFLIDTCQZE linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9741460", Offset = "0x973FE60", VA = "0x189741460", Slot = "5")]
		public MSFLIDTCQZE GMARJUZRGME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9741520", Offset = "0x973FF20", VA = "0x189741520", Slot = "6")]
		public void IIGQBENBMDE(MSFLIDTCQZE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public FOYCDAWRFGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x9740C40", Offset = "0x973F640", VA = "0x189740C40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9742E40", Offset = "0x9741840", VA = "0x189742E40")]
		public bool HUSHFQALGFN([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9741E60", Offset = "0x9740860", VA = "0x189741E60")]
		private bool ABVWBGTTJMK([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9745220", Offset = "0x9743C20", VA = "0x189745220")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9742EB0", Offset = "0x97418B0", VA = "0x189742EB0", Slot = "5")]
		public void Initialize(NANHKTWOJXE manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9742AD0", Offset = "0x97414D0", VA = "0x189742AD0", Slot = "17")]
		public void FLXAHZZZSTA(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x97439C0", Offset = "0x97423C0", VA = "0x1897439C0", Slot = "12")]
		public void NNYJMBXIQFH(Func<PRMDPODZYPJ, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9743890", Offset = "0x9742290", VA = "0x189743890")]
		private void NNYJMBXIQFH(TRYVDYQYBIG a, Func<PRMDPODZYPJ, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9742E20", Offset = "0x9741820", VA = "0x189742E20", Slot = "11")]
		public void HNRRBFPAQNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9744CB0", Offset = "0x97436B0", VA = "0x189744CB0", Slot = "8")]
		public bool WLVQCTXQGOW(PRMDPODZYPJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9744020", Offset = "0x9742A20", VA = "0x189744020")]
		private bool SBUZXWIWHAX(PRMDPODZYPJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9744CC0", Offset = "0x97436C0", VA = "0x189744CC0")]
		private static bool YTAIWTPKMAZ(PRMDPODZYPJ a, TRYVDYQYBIG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9744D70", Offset = "0x9743770", VA = "0x189744D70")]
		private void ZERFFIZRRMB(Transform a, TRYVDYQYBIG b, TRYVDYQYBIG[] c, PRMDPODZYPJ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9744920", Offset = "0x9743320", VA = "0x189744920")]
		private ConnectableLink UHOUSWUAPYQ(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x97431B0", Offset = "0x9741BB0", VA = "0x1897431B0")]
		private static bool KGPUBQJEHIX(TRYVDYQYBIG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9742E50", Offset = "0x9741850", VA = "0x189742E50", Slot = "9")]
		public bool IELLZXDPMTI(PRMDPODZYPJ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x97435E0", Offset = "0x9741FE0", VA = "0x1897435E0")]
		private bool MTJEUQJDCMT(PRMDPODZYPJ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9744AD0", Offset = "0x97434D0", VA = "0x189744AD0")]
		private static void VEEKPIMOTTA(PRMDPODZYPJ a, int b, int c, Vector3 d, Quaternion e, TRYVDYQYBIG f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9743090", Offset = "0x9741A90", VA = "0x189743090")]
		private void KGKIBTFBHIX(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9742CE0", Offset = "0x97416E0", VA = "0x189742CE0")]
		private void FLXZEDAAQMD(TRYVDYQYBIG a, PRMDPODZYPJ b, PRMDPODZYPJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9742C70", Offset = "0x9741670", VA = "0x189742C70")]
		private void FLXZEDAAQMD(PRMDPODZYPJ a, PRMDPODZYPJ b, PRMDPODZYPJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9742C00", Offset = "0x9741600", VA = "0x189742C00")]
		private void FLXVBBEPVAI(PRMDPODZYPJ a, PRMDPODZYPJ b, PRMDPODZYPJ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9742B00", Offset = "0x9741500", VA = "0x189742B00")]
		private void FLXVBBEPVAI(TRYVDYQYBIG a, PRMDPODZYPJ b, PRMDPODZYPJ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x97429B0", Offset = "0x97413B0", VA = "0x1897429B0")]
		private void FHVLHXFNPTT(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9743410", Offset = "0x9741E10", VA = "0x189743410")]
		private void MBWSAWFKXLR(CPBXSJSKLEB a, CPBXSJSKLEB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9743DB0", Offset = "0x97427B0", VA = "0x189743DB0", Slot = "18")]
		public PRMDPODZYPJ QKLPGAWJTQO(PRMDPODZYPJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9743A10", Offset = "0x9742410", VA = "0x189743A10", Slot = "13")]
		public void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x97446E0", Offset = "0x97430E0", VA = "0x1897446E0", Slot = "14")]
		public List<PRMDPODZYPJ> TUUFYVLNNCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9742D50", Offset = "0x9741750", VA = "0x189742D50")]
		protected CPBXSJSKLEB GWLJEITQKFE(CPBXSJSKLEB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9743370", Offset = "0x9741D70", VA = "0x189743370")]
		protected TRYVDYQYBIG[] KNERUTALYCX(TRYVDYQYBIG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9743F10", Offset = "0x9742910", VA = "0x189743F10")]
		protected bool QKOZEWIUHJY(PRMDPODZYPJ a, [Out] TRYVDYQYBIG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9742F60", Offset = "0x9741960", VA = "0x189742F60", Slot = "15")]
		public bool KAOLTMOYZAW(PRMDPODZYPJ a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x97439D0", Offset = "0x97423D0", VA = "0x1897439D0")]
		protected TRYVDYQYBIG OALOCSNGWYP(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9744A70", Offset = "0x9743470", VA = "0x189744A70", Slot = "10")]
		public bool URBLWLFLJIG(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9742420", Offset = "0x9740E20", VA = "0x189742420")]
		private bool BOWABRLNXVP(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9744610", Offset = "0x9743010", VA = "0x189744610")]
		private static bool SNZBGXRFNNV(TRYVDYQYBIG a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9742E40", Offset = "0x9741840", VA = "0x189742E40", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1E160", Offset = "0xD1CB60", VA = "0x180D1E160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD1DC70", Offset = "0xD1C670", VA = "0x180D1DC70")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool WJCYHWPRZIP
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1343720", Offset = "0x1342120", VA = "0x181343720", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x285C6D0", Offset = "0x285B0D0", VA = "0x18285C6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool TNBNJETZKYL
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> CDKBFIFMLOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x97460C0", Offset = "0x9744AC0", VA = "0x1897460C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x97464B0", Offset = "0x9744EB0", VA = "0x1897464B0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ> BPTGUABKDAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x97455F0", Offset = "0x9743FF0", VA = "0x1897455F0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x97454E0", Offset = "0x9743EE0", VA = "0x1897454E0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<PRMDPODZYPJ, PRMDPODZYPJ, PRMDPODZYPJ> OQFQERAMOHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x97466F0", Offset = "0x97450F0", VA = "0x1897466F0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9745650", Offset = "0x9744050", VA = "0x189745650", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9747050", Offset = "0x9745A50", VA = "0x189747050")]
		public LegacyConnectableManager(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9745AA0", Offset = "0x97444A0", VA = "0x189745AA0", Slot = "12")]
		public void Initialize(GameObject gameObject, FYZXZUHVIVL configData, MBDTJJXIPKK rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x97469D0", Offset = "0x97453D0", VA = "0x1897469D0", Slot = "26")]
		public void RLHTICJYTWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9746CB0", Offset = "0x97456B0", VA = "0x189746CB0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9746840", Offset = "0x9745240", VA = "0x189746840", Slot = "14")]
		public void QCIVJGOFOSZ(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9746060", Offset = "0x9744A60", VA = "0x189746060", Slot = "15")]
		public void JLFJVASZUFA(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9746EB0", Offset = "0x97458B0", VA = "0x189746EB0", Slot = "22")]
		public bool VWALBJYTFDS(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x97453D0", Offset = "0x9743DD0", VA = "0x1897453D0")]
		internal bool BOWABRLNXVP([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9746F00", Offset = "0x9745900", VA = "0x189746F00")]
		internal bool XGRFUEWZMRB([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9746510", Offset = "0x9744F10", VA = "0x189746510")]
		internal void MZRHRAEGKGD(PRMDPODZYPJ a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9746060", Offset = "0x9744A60", VA = "0x189746060")]
		internal bool UNHSIQAPRWL(PRMDPODZYPJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9746860", Offset = "0x9745260", VA = "0x189746860")]
		internal bool QEHJJABPEVD(PRMDPODZYPJ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9746750", Offset = "0x9745150", VA = "0x189746750", Slot = "16")]
		public void PKCXGHOLKWJ(PRMDPODZYPJ a, HashSet<PRMDPODZYPJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9746AA0", Offset = "0x97454A0", VA = "0x189746AA0", Slot = "17")]
		public void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9746120", Offset = "0x9744B20", VA = "0x189746120", Slot = "18")]
		public void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x97462F0", Offset = "0x9744CF0", VA = "0x1897462F0", Slot = "19")]
		public void LKGBKCTCCGH(PRMDPODZYPJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9745850", Offset = "0x9744250", VA = "0x189745850")]
		public void IKSEBLHXTUK([Optional] JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9746260", Offset = "0x9744C60", VA = "0x189746260", Slot = "23")]
		public void LGIEHBRUTYL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9746D30", Offset = "0x9745730", VA = "0x189746D30", Slot = "20")]
		public ConnectableGraphData VROMMHYETCS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x97456B0", Offset = "0x97440B0", VA = "0x1897456B0", Slot = "21")]
		public ConnectableGraphData IFBHFRSWOZI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9746990", Offset = "0x9745390", VA = "0x189746990", Slot = "25")]
		public void QUTUUOQJBMY(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9745540", Offset = "0x9743F40", VA = "0x189745540", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x9741360", Offset = "0x973FD60", VA = "0x189741360")]
		public LSNECTQGMUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x97412A0", Offset = "0x973FCA0", VA = "0x1897412A0")]
		public void LIKWRWYWZMC(PRMDPODZYPJ a, PRMDPODZYPJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9741300", Offset = "0x973FD00", VA = "0x189741300")]
		public void OFNLGCZDPJS(PRMDPODZYPJ a, PRMDPODZYPJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9741220", Offset = "0x973FC20", VA = "0x189741220")]
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
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public WHPBAUPZHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x97531E0", Offset = "0x9751BE0", VA = "0x1897531E0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x97531D0", Offset = "0x9751BD0", VA = "0x1897531D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9753380", Offset = "0x9751D80", VA = "0x189753380")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9753310", Offset = "0x9751D10", VA = "0x189753310")]
		private void OnMasterClientSwitched(JNIVCIZIPSX newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x97534C0", Offset = "0x9751EC0", VA = "0x1897534C0")]
		public void ZSPFJTWABNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x97533C0", Offset = "0x9751DC0", VA = "0x1897533C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JLJLQVTDNTM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x97411C0", Offset = "0x973FBC0", VA = "0x1897411C0")]
			internal LegacyConnectableManager ZJCYWNENSVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x973EE20", Offset = "0x973D820", VA = "0x18973EE20")]
		public static void EWAMEUPAFYD(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x973F010", Offset = "0x973DA10", VA = "0x18973F010")]
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
		[Cpp2IlInjected.Address(RVA = "0x97481A0", Offset = "0x9746BA0", VA = "0x1897481A0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9747750", Offset = "0x9746150", VA = "0x189747750", Slot = "7")]
		public void Initialize(AOVJYPZOHCS graph, VMIELKXWDTA creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9747C20", Offset = "0x9746620", VA = "0x189747C20", Slot = "5")]
		public void SYVEGQFGVFZ(CPBXSJSKLEB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x97479E0", Offset = "0x97463E0", VA = "0x1897479E0", Slot = "9")]
		public void PFPONXSHWCG(CPBXSJSKLEB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9747590", Offset = "0x9745F90", VA = "0x189747590", Slot = "8")]
		public void EFNEESQGBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9747790", Offset = "0x9746190", VA = "0x189747790", Slot = "10")]
		public void KDWUMUFRBPP(CPBXSJSKLEB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9747FF0", Offset = "0x97469F0", VA = "0x189747FF0", Slot = "11")]
		public void VSEVZWOWCSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x97473E0", Offset = "0x9745DE0", VA = "0x1897473E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x9751D50", Offset = "0x9750750", VA = "0x189751D50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x9752200", Offset = "0x9750C00", VA = "0x189752200")]
			public SerializeNodeInSubgraph(TRYVDYQYBIG currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] MERFDKTLKAK parentNodeData, [Optional] MERFDKTLKAK rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9751E60", Offset = "0x9750860", VA = "0x189751E60")]
			public MERFDKTLKAK XQIXCNAGDPI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9751B20", Offset = "0x9750520", VA = "0x189751B20")]
			private MERFDKTLKAK FZGIGPIPKIW([Out] MERFDKTLKAK a, [Out] MERFDKTLKAK b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9752000", Offset = "0x9750A00", VA = "0x189752000")]
			private MERFDKTLKAK XZZGYBHMWZA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9751BE0", Offset = "0x97505E0", VA = "0x189751BE0")]
			private void HFRLHWBLYNS(MERFDKTLKAK a, MERFDKTLKAK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9751960", Offset = "0x9750360", VA = "0x189751960")]
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
			[Cpp2IlInjected.Address(RVA = "0x974FFE0", Offset = "0x974E9E0", VA = "0x18974FFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool GOMXVEFGBFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x974F2E0", Offset = "0x974DCE0", VA = "0x18974F2E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x974FB00", Offset = "0x974E500", VA = "0x18974FB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x974FF50", Offset = "0x974E950", VA = "0x18974FF50")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9750EA0", Offset = "0x974F8A0", VA = "0x189750EA0")]
		public ConnectableGraphData VROMMHYETCS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x974FC90", Offset = "0x974E690", VA = "0x18974FC90")]
		public ConnectableGraphData IFBHFRSWOZI(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x97502E0", Offset = "0x974ECE0", VA = "0x1897502E0")]
		public void LGIEHBRUTYL(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x974FA60", Offset = "0x974E460", VA = "0x18974FA60")]
		public void EOGDHVZDGCT(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x97518C0", Offset = "0x97502C0", VA = "0x1897518C0")]
		public void ZIMDEDCFGNH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x974F300", Offset = "0x974DD00", VA = "0x18974F300")]
		private void AOOYUUGZSYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x974F980", Offset = "0x974E380", VA = "0x18974F980")]
		private MERFDKTLKAK EKGGOTWLTWM(TRYVDYQYBIG a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9750030", Offset = "0x974EA30", VA = "0x189750030")]
		private static void KIDAXUHXVNY(TRYVDYQYBIG a, bool b, MERFDKTLKAK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9751610", Offset = "0x9750010", VA = "0x189751610")]
		private void YBWOBCAKICZ(TRYVDYQYBIG a, bool b, MERFDKTLKAK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9751830", Offset = "0x9750230", VA = "0x189751830")]
		private MERFDKTLKAK YGJZTHLNCUQ(TRYVDYQYBIG a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9751390", Offset = "0x974FD90", VA = "0x189751390")]
		private bool XNBCRAALSXU(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9750840", Offset = "0x974F240", VA = "0x189750840")]
		private bool PEQGOGWRTLJ(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x974FFC0", Offset = "0x974E9C0", VA = "0x18974FFC0")]
		private bool JBTCWNCIGCB(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x974FE30", Offset = "0x974E830", VA = "0x18974FE30")]
		private static bool IOJZVSJDVQE(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9751010", Offset = "0x974FA10", VA = "0x189751010")]
		public static bool VWALBJYTFDS(MERFDKTLKAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9750370", Offset = "0x974ED70", VA = "0x189750370")]
		private PRMDPODZYPJ MLIZUSEXGWO(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x974FB20", Offset = "0x974E520", VA = "0x18974FB20")]
		private PRMDPODZYPJ GFRREJCREGY(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x97506B0", Offset = "0x974F0B0", VA = "0x1897506B0")]
		private PRMDPODZYPJ NXVXICFDFKL(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9748F20", Offset = "0x9747920", VA = "0x189748F20")]
		private static Guid FBNEAAKWYYB(MERFDKTLKAK a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x97512A0", Offset = "0x974FCA0", VA = "0x1897512A0")]
		private string WRHBIXVFEWQ(MERFDKTLKAK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x974F4E0", Offset = "0x974DEE0", VA = "0x18974F4E0")]
		private bool CPVHDYMWXOT(TRYVDYQYBIG a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x974F6D0", Offset = "0x974E0D0", VA = "0x18974F6D0")]
		private static void EBECMJQEESD(TRYVDYQYBIG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0x9740B00", Offset = "0x973F500", VA = "0x189740B00")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink JIRINOPRVMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9740BA0", Offset = "0x973F5A0", VA = "0x189740BA0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9740BD0", Offset = "0x973F5D0", VA = "0x189740BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public VEGDJQDXTAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9752FA0", Offset = "0x97519A0", VA = "0x189752FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x51A19C0", Offset = "0x51A03C0", VA = "0x1851A19C0", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x9752A40", Offset = "0x9751440", VA = "0x189752A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private TRYVDYQYBIG TSUTPHIUZAI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x97523C0", Offset = "0x9750DC0", VA = "0x1897523C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public CPBXSJSKLEB JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public PRMDPODZYPJ ZEZFKHXLJLU
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool JFFYDATVOWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x9752680", Offset = "0x9751080", VA = "0x189752680", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool HQLTJXLDZPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x9752610", Offset = "0x9751010", VA = "0x189752610", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected TRYVDYQYBIG XBKNLMWAWOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x9752660", Offset = "0x9751060", VA = "0x189752660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9752D00", Offset = "0x9751700", VA = "0x189752D00")]
		public TRYVDYQYBIG(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9752690", Offset = "0x9751090", VA = "0x189752690")]
		public TRYVDYQYBIG JTOEXZFXZXN(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x97528C0", Offset = "0x97512C0", VA = "0x1897528C0")]
		public TRYVDYQYBIG QCBXIDURAQD(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9752A70", Offset = "0x9751470", VA = "0x189752A70")]
		public TRYVDYQYBIG Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x9752270", Offset = "0x9750C70", VA = "0x189752270")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9752C50", Offset = "0x9751650", VA = "0x189752C50")]
		public TRYVDYQYBIG Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x97524A0", Offset = "0x9750EA0", VA = "0x1897524A0")]
		private static void FLXAHZZZSTA(TRYVDYQYBIG a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9752600", Offset = "0x9751000", VA = "0x189752600", Slot = "9")]
		public void FLXAHZZZSTA(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x97527D0", Offset = "0x97511D0", VA = "0x1897527D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9753140", Offset = "0x9751B40", VA = "0x189753140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object IWMDTGRRYAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x9753190", Offset = "0x9751B90", VA = "0x189753190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x97530E0", Offset = "0x9751AE0", VA = "0x1897530E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x973F620", Offset = "0x973E020", VA = "0x18973F620", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x9740030", Offset = "0x973EA30", VA = "0x189740030", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView NHIHHIWNUKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x9740110", Offset = "0x973EB10", VA = "0x189740110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> TLGJNCBUTJX
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x9740360", Offset = "0x973ED60", VA = "0x189740360", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x9740070", Offset = "0x973EA70", VA = "0x189740070", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<JNIVCIZIPSX> ABBOYDVOWWF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x973FF90", Offset = "0x973E990", VA = "0x18973FF90", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x973FEF0", Offset = "0x973E8F0", VA = "0x18973FEF0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x97402D0", Offset = "0x973ECD0", VA = "0x1897402D0", Slot = "10")]
		public void VQZGAVQPNPU(LegacyConnectableManager a, MBDTJJXIPKK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x973F4B0", Offset = "0x973DEB0", VA = "0x18973F4B0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x97401B0", Offset = "0x973EBB0", VA = "0x1897401B0", Slot = "11")]
		public void UYLXRTJCTGR(PRMDPODZYPJ a, PRMDPODZYPJ b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x973F680", Offset = "0x973E080", VA = "0x18973F680", Slot = "12")]
		public void LCBOFLKLKKD(PRMDPODZYPJ a, int b, PRMDPODZYPJ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x973F500", Offset = "0x973DF00", VA = "0x18973F500", Slot = "13")]
		public void JJYRCXLGICG(ConnectableGraphData a, [Optional] JNIVCIZIPSX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x973F9D0", Offset = "0x973E3D0", VA = "0x18973F9D0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(PRMDPODZYPJ objectToReparent, int objectToReparentSlotIndex, PRMDPODZYPJ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x973F7E0", Offset = "0x973E1E0", VA = "0x18973F7E0")]
		[RPCMethod]
		private void RpcMasterModifyNode(PRMDPODZYPJ connectableToModify, PRMDPODZYPJ expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x973FDC0", Offset = "0x973E7C0", VA = "0x18973FDC0")]
		[RPCMethod]
		private void RpcReparentNodes(PRMDPODZYPJ objectToReparent, int objectToReparentSlotIndex, PRMDPODZYPJ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x973FCD0", Offset = "0x973E6D0", VA = "0x18973FCD0")]
		[RPCMethod]
		private void RpcModifyNode(PRMDPODZYPJ connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x973F7A0", Offset = "0x973E1A0", VA = "0x18973F7A0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9741590", Offset = "0x973FF90", VA = "0x189741590", Slot = "4")]
		private void PCQCNGGRDVD(PRMDPODZYPJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x9741B30", Offset = "0x9740530", VA = "0x189741B30", Slot = "5")]
		private void WZNAMDWABSV(PRMDPODZYPJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9741900", Offset = "0x9740300", VA = "0x189741900", Slot = "6")]
		private void VJGXYFCLZAS(PRMDPODZYPJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9741710", Offset = "0x9740110", VA = "0x189741710", Slot = "7")]
		private void QEYGBUYACXI(PRMDPODZYPJ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9741DF0", Offset = "0x97407F0", VA = "0x189741DF0", Slot = "8")]
		private MSFLIDTCQZE ZEKUWUEGSUV(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9741D90", Offset = "0x9740790", VA = "0x189741D90", Slot = "9")]
		private void YAKNXVKJMXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class LQMROSSUVRG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C05490", Offset = "0x3C03E90", VA = "0x183C05490")]
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
