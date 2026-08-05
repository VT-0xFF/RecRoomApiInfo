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
		[Cpp2IlInjected.Address(RVA = "0x84A7860", Offset = "0x84A6660", VA = "0x1884A7860", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		private int[] RBTJYOZOMSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] RBODBIFRDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset MXKLQTZDJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset MXPSOATASPL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23AEDE0", Offset = "0x23ADBE0", VA = "0x1823AEDE0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84B41B0", Offset = "0x84B2FB0", VA = "0x1884B41B0")]
		private void GQKVENIQDUS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84B4310", Offset = "0x84B3110", VA = "0x1884B4310")]
		private void GQQCBUCNNGB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84B4470", Offset = "0x84B3270", VA = "0x1884B4470", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84B4780", Offset = "0x84B3580", VA = "0x1884B4780")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : QTNSDDNHNRZ, RPNCXIAYMUG
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JSNTQZNIZOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public GNBPGMVYAHJ JDVFJRFYTOX;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public JSNTQZNIZOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x84A0B10", Offset = "0x849F910", VA = "0x1884A0B10")]
			internal object HGKZKFEYGYQ(GNBPGMVYAHJ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JSIMTSTLQDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public GNBPGMVYAHJ STWWTVIKYZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JSNTQZNIZOJ YLNIYCOGBOE;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public JSIMTSTLQDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84A08C0", Offset = "0x849F6C0", VA = "0x1884A08C0")]
			internal object HGQGHLYVQJZ((GNBPGMVYAHJ child, GNBPGMVYAHJ nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class WBWFQYGEYMC : IEnumerable<NYDBEHLDYNW>, IEnumerable, IEnumerator<NYDBEHLDYNW>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private NYDBEHLDYNW QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId ZIXTKPKASCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId SXZJETBGLMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private IFXBBMDUCGM OGQDGCUCMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray SBGHQCWQDBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator ZQUFVKDWNVD;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private NYDBEHLDYNW QEVAZPIDMLI
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public WBWFQYGEYMC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x84B39B0", Offset = "0x84B27B0", VA = "0x1884B39B0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84B3AD0", Offset = "0x84B28D0", VA = "0x1884B3AD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84B3A90", Offset = "0x84B2890", VA = "0x1884B3A90")]
			private void LKISUJFCFYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x84B3AB0", Offset = "0x84B28B0", VA = "0x1884B3AB0")]
			private void LKYNMDMUIGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x84B38C0", Offset = "0x84B26C0", VA = "0x1884B38C0", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x84B3900", Offset = "0x84B2700", VA = "0x1884B3900", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NYDBEHLDYNW> HOMKYRFFBDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x84B3900", Offset = "0x84B2700", VA = "0x1884B3900", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log CAVQNFAQRLQ;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log NUGUSBLXRCQ;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log AVYJGSXKKBG;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log VRANGWYYZNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TSMXUIUWALV YNKDGFQXOBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BZGADCICSKQ IIJAVGMKBQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private EXAUPGCZURX VPXSYEQNFCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MFOSKOXIBSJ FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private QKTMHUGAQKV WEFKJMMKCCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private YHANXQPWHRR DNHLCWERPIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TOIOMFQGVOU SDAAIPSGEJB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool XYSPVSPMHUE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAC50F0", Offset = "0xAC3EF0", VA = "0x180AC50F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAC5100", Offset = "0xAC3F00", VA = "0x180AC5100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool MNZRXJBQTNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<NYDBEHLDYNW, NYDBEHLDYNW> TVDEDBHEKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84AA1F0", Offset = "0x84A8FF0", VA = "0x1884AA1F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84AD330", Offset = "0x84AC130", VA = "0x1884AD330", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<NYDBEHLDYNW, NYDBEHLDYNW> CZKPLFYCAWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84ACCC0", Offset = "0x84ABAC0", VA = "0x1884ACCC0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x84A8BA0", Offset = "0x84A79A0", VA = "0x1884A8BA0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<NYDBEHLDYNW, NYDBEHLDYNW, NYDBEHLDYNW> OIBUSGDDYYP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84ACBF0", Offset = "0x84AB9F0", VA = "0x1884ACBF0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84A9AF0", Offset = "0x84A88F0", VA = "0x1884A9AF0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84AD530", Offset = "0x84AC330", VA = "0x1884AD530")]
		public OMConnectableManager(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84AA2A0", Offset = "0x84A90A0", VA = "0x1884AA2A0", Slot = "12")]
		public void Initialize(GameObject gameObject, GKAFIFJWYIO configData, ILEKZBIOGUN sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84AB190", Offset = "0x84A9F90", VA = "0x1884AB190", Slot = "26")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84A8B50", Offset = "0x84A7950", VA = "0x1884A8B50", Slot = "22")]
		public bool AERDDQNFPAX(GNBPGMVYAHJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84A98E0", Offset = "0x84A86E0", VA = "0x1884A98E0")]
		private void FPBKCAYLSBS(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84AAF70", Offset = "0x84A9D70", VA = "0x1884AAF70")]
		private void NXXSRUPVGPM(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84AA980", Offset = "0x84A9780", VA = "0x1884AA980")]
		private void LTWDUJLJTLW(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84A8DE0", Offset = "0x84A7BE0", VA = "0x1884A8DE0")]
		private void DCQTUOKYKVN(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84AB460", Offset = "0x84AA260", VA = "0x1884AB460", Slot = "14")]
		public void PUOFOOQAOVA(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "15")]
		public void UICJQLYJDWB(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84A9DC0", Offset = "0x84A8BC0", VA = "0x1884A9DC0", Slot = "17")]
		public void GWSFLWUPZGI(NYDBEHLDYNW a, NYDBEHLDYNW b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84A9F20", Offset = "0x84A8D20", VA = "0x1884A9F20")]
		public void GWSFLWUPZGI(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84AB360", Offset = "0x84AA160", VA = "0x1884AB360")]
		public void PDOUWKJXJJK(NYDBEHLDYNW a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84AAE10", Offset = "0x84A9C10", VA = "0x1884AAE10", Slot = "18")]
		public void MXTPBRAKJJK(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84A9D10", Offset = "0x84A8B10", VA = "0x1884A9D10")]
		private float GVARCVHZXGY(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84AACD0", Offset = "0x84A9AD0", VA = "0x1884AACD0")]
		public void MXTPBRAKJJK(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84A9BA0", Offset = "0x84A89A0", VA = "0x1884A9BA0", Slot = "19")]
		public void GPTVANVBTUW(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84AD120", Offset = "0x84ABF20", VA = "0x1884AD120", Slot = "16")]
		public void YZXEZHSDEXA(NYDBEHLDYNW a, HashSet<NYDBEHLDYNW> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "20")]
		public ConnectableGraphData BMYFENJHZYT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "21")]
		public ConnectableGraphData YNDRFXBPQXX(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84AB770", Offset = "0x84AA570", VA = "0x1884AB770", Slot = "23")]
		public void QIFZGLMBWDG(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84AB3F0", Offset = "0x84AA1F0", VA = "0x1884AB3F0", Slot = "24")]
		public void POTVFKSNDSC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84ACCA0", Offset = "0x84ABAA0", VA = "0x1884ACCA0", Slot = "25")]
		public void WGUHFVUSFVV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84AA510", Offset = "0x84A9310", VA = "0x1884AA510")]
		private void KEIRIGLEXQG(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84ABBD0", Offset = "0x84AA9D0", VA = "0x1884ABBD0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84A93B0", Offset = "0x84A81B0", VA = "0x1884A93B0")]
		private void FEQHWCPUYVX(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84ACD70", Offset = "0x84ABB70", VA = "0x1884ACD70")]
		[IteratorStateMachine(typeof(WBWFQYGEYMC))]
		public IEnumerable<NYDBEHLDYNW> WNULSQQNKDU(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84A9420", Offset = "0x84A8220", VA = "0x1884A9420")]
		internal NYDBEHLDYNW FKDQTBYZAGB(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84AA060", Offset = "0x84A8E60", VA = "0x1884AA060")]
		internal ObjectLocalId HKHTFBTSQSF(NYDBEHLDYNW a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84AC630", Offset = "0x84AB430", VA = "0x1884AC630")]
		private bool UEZGELGHGYM(GNBPGMVYAHJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84AA920", Offset = "0x84A9720", VA = "0x1884AA920")]
		private bool LJMRFWFYKEM(GNBPGMVYAHJ a, [Out] NYDBEHLDYNW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84A9560", Offset = "0x84A8360", VA = "0x1884A9560")]
		private NYDBEHLDYNW FKDQTBYZAGB(GNBPGMVYAHJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84ACE00", Offset = "0x84ABC00", VA = "0x1884ACE00")]
		private NYDBEHLDYNW XSAYHGKUTGO(GNBPGMVYAHJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84A91F0", Offset = "0x84A7FF0", VA = "0x1884A91F0")]
		private NYDBEHLDYNW EZIDFEGIQMH(GNBPGMVYAHJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84ACBB0", Offset = "0x84AB9B0", VA = "0x1884ACBB0")]
		private static Guid UFZBAJZBTKQ(GNBPGMVYAHJ a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84AABE0", Offset = "0x84A99E0", VA = "0x1884AABE0")]
		private string MFXLTZFINPT(GNBPGMVYAHJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84A8C50", Offset = "0x84A7A50", VA = "0x1884A8C50")]
		private void CFHDZBHJFIS(NYDBEHLDYNW a, NYDBEHLDYNW b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84AC4A0", Offset = "0x84AB2A0", VA = "0x1884AC4A0")]
		private void TEHJIDSZJYO(NYDBEHLDYNW a, NYDBEHLDYNW b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84ABB70", Offset = "0x84AA970", VA = "0x1884ABB70")]
		private void RWDDUVBORMQ(NYDBEHLDYNW a, NYDBEHLDYNW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84ACF90", Offset = "0x84ABD90", VA = "0x1884ACF90")]
		private void YJSVSXGXIOZ(NYDBEHLDYNW a, NYDBEHLDYNW b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84AB7E0", Offset = "0x84AA5E0", VA = "0x1884AB7E0")]
		private void RJFFDHYPWQM(ObjectLocalId a, NYDBEHLDYNW b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84AB8F0", Offset = "0x84AA6F0", VA = "0x1884AB8F0")]
		private void RRNHBPGSNSX(ObjectLocalId a, NYDBEHLDYNW b, NYDBEHLDYNW c, NYDBEHLDYNW d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PTURPXRYWEK
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public FDTRVDFSBYT container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x84B3E90", Offset = "0x84B2C90", VA = "0x1884B3E90")]
			internal OMConnectableManager RLGEITLSHIQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A30", Offset = "0x84B0830", VA = "0x1884B1A30")]
		public static void SPRZIZAVPUE(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84B1BA0", Offset = "0x84B09A0", VA = "0x1884B1BA0")]
		public static void TRAOHEVYGWP(FDTRVDFSBYT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : NBWGYFGNBPG, INSNNNPZVNX
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx QVRTYDABTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager TPBUIKAKGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly BYQRMDVZYIC ZWBTWFPOGUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly XZKNMEOKGNA FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly ABWHLQONACU[] ACAUPQPKSKQ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NYDBEHLDYNW ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x84AF120", Offset = "0x84ADF20", VA = "0x1884AF120", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NYDBEHLDYNW CXGNUPRRZNN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x84AEC00", Offset = "0x84ADA00", VA = "0x1884AEC00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 QIPCRBSOSRT
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x84AE110", Offset = "0x84ACF10", VA = "0x1884AE110", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion TDUDBZHIEUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x84AE0B0", Offset = "0x84ACEB0", VA = "0x1884AE0B0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ZZLXIOHZMNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x84AEB40", Offset = "0x84AD940", VA = "0x1884AEB40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<NYDBEHLDYNW> AONVGGSQKNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x84AE170", Offset = "0x84ACF70", VA = "0x1884AE170", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool QAFHQVYBALJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xDAAA60", Offset = "0xDA9860", VA = "0x180DAAA60", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE9A850", Offset = "0xE99650", VA = "0x180E9A850", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x84AF330", Offset = "0x84AE130", VA = "0x1884AF330", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x84AF030", Offset = "0x84ADE30", VA = "0x1884AF030", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84AF050", Offset = "0x84ADE50", VA = "0x1884AF050", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x84AF180", Offset = "0x84ADF80", VA = "0x1884AF180", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x84AF260", Offset = "0x84AE060", VA = "0x1884AF260", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool PROXLXCNZXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x84AD670", Offset = "0x84AC470", VA = "0x1884AD670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler LPSTXGKFYBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x84AE1A0", Offset = "0x84ACFA0", VA = "0x1884AE1A0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x84AEBB0", Offset = "0x84AD9B0", VA = "0x1884AEBB0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler AJBUNLFWKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x84AE760", Offset = "0x84AD560", VA = "0x1884AE760", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x84AD620", Offset = "0x84AC420", VA = "0x1884AD620", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler YREQAIGWUNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x84AE1F0", Offset = "0x84ACFF0", VA = "0x1884AE1F0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x84ADB70", Offset = "0x84AC970", VA = "0x1884ADB70", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler BECLARDBZTR
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x84AD880", Offset = "0x84AC680", VA = "0x1884AD880", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x84AE6C0", Offset = "0x84AD4C0", VA = "0x1884AE6C0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84AEF30", Offset = "0x84ADD30", VA = "0x1884AEF30")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, BYQRMDVZYIC connectableTool, ABWHLQONACU[] connectionPoints, XZKNMEOKGNA callbacks, QTNSDDNHNRZ connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84AD5A0", Offset = "0x84AC3A0", VA = "0x1884AD5A0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "21")]
		public void VSEJZNQCCFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x81879A0", Offset = "0x81867A0", VA = "0x1881879A0", Slot = "22")]
		public void AIQVOITDKVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84AE670", Offset = "0x84AD470", VA = "0x1884AE670", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84ADBC0", Offset = "0x84AC9C0", VA = "0x1884ADBC0", Slot = "25")]
		public void LKOWPPKMHCT(int a, NYDBEHLDYNW b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84AD7B0", Offset = "0x84AC5B0", VA = "0x1884AD7B0", Slot = "26")]
		public void ELOXVAJOMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84ADDD0", Offset = "0x84ACBD0", VA = "0x1884ADDD0", Slot = "27")]
		public void MGIRFJWVVHX(int a, NYDBEHLDYNW b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84AEAC0", Offset = "0x84AD8C0", VA = "0x1884AEAC0", Slot = "28")]
		public void XHXWULNHPIL(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x84AE240", Offset = "0x84AD040", VA = "0x1884AE240", Slot = "31")]
		public void RXZDPKRFZOE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84AE7B0", Offset = "0x84AD5B0", VA = "0x1884AE7B0", Slot = "29")]
		public void XGRXLQNPRBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84AECC0", Offset = "0x84ADAC0", VA = "0x1884AECC0", Slot = "30")]
		public void ZUJNVDFBKPX(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84ADA50", Offset = "0x84AC850", VA = "0x1884ADA50", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84AD920", Offset = "0x84AC720", VA = "0x1884AD920", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB22400", Offset = "0xB21200", VA = "0x180B22400", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84AD6C0", Offset = "0x84AC4C0", VA = "0x1884AD6C0", Slot = "43")]
		public bool CanConnectTo(int slotIndex, NYDBEHLDYNW otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "44")]
		public void ParentChanged(int slotIndex, NYDBEHLDYNW newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "45")]
		public void ChildAdded(int slotIndex, NYDBEHLDYNW newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "46")]
		public void ChildRemoved(int slotIndex, NYDBEHLDYNW removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "47")]
		public void ConnectionModified(int slotIndex, NYDBEHLDYNW parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84AE650", Offset = "0x84AD450", VA = "0x1884AE650", Slot = "48")]
		public void RootChanged(NYDBEHLDYNW previousRootConnectable, NYDBEHLDYNW newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84ADB20", Offset = "0x84AC920", VA = "0x1884ADB20", Slot = "23")]
		public void HEDHFLKJJBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84AD760", Offset = "0x84AC560", VA = "0x1884AD760", Slot = "24")]
		public void EEMHIPGCWFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84AD5D0", Offset = "0x84AC3D0", VA = "0x1884AD5D0")]
		private void BXFWOOLOIVK(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(JRIVMXHNTMB), new string[] { })]
	public class QXMPPEASKYS : JRIVMXHNTMB, KSWDMDRTSDM, ZDJVRLQDMXE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EERSQRFLGMR
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EERSQRFLGMR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private HPVINTYYXZH XQDIIBKHXJU;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object ARBLXFXOOYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x84B1D30", Offset = "0x84B0B30", VA = "0x1884B1D30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x84B1DC0", Offset = "0x84B0BC0", VA = "0x1884B1DC0", Slot = "5")]
		private void ZZSCPZJHWHS(FCHQYTALOWK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x133C350", Offset = "0x133B150", VA = "0x18133C350", Slot = "6")]
		private void NNPEZXMTYDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public QXMPPEASKYS()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(QTNSDDNHNRZ), new string[] { "Ignore", "Mock" })]
	public class TUIBIQOREDG : QTNSDDNHNRZ, RPNCXIAYMUG
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool XYSPVSPMHUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool MNZRXJBQTNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<NYDBEHLDYNW, NYDBEHLDYNW> TVDEDBHEKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x84B3400", Offset = "0x84B2200", VA = "0x1884B3400", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x84B3610", Offset = "0x84B2410", VA = "0x1884B3610", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<NYDBEHLDYNW, NYDBEHLDYNW> CZKPLFYCAWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x84B3560", Offset = "0x84B2360", VA = "0x1884B3560", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x84B32A0", Offset = "0x84B20A0", VA = "0x1884B32A0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<NYDBEHLDYNW, NYDBEHLDYNW, NYDBEHLDYNW> OIBUSGDDYYP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x84B34B0", Offset = "0x84B22B0", VA = "0x1884B34B0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x84B3350", Offset = "0x84B2150", VA = "0x1884B3350", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "26")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "12")]
		public void Initialize(GameObject gameObject, GKAFIFJWYIO configData, ILEKZBIOGUN rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "14")]
		public void PUOFOOQAOVA(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "15")]
		public void UICJQLYJDWB(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "16")]
		public void YZXEZHSDEXA(NYDBEHLDYNW a, HashSet<NYDBEHLDYNW> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "17")]
		public void GWSFLWUPZGI(NYDBEHLDYNW a, NYDBEHLDYNW b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "18")]
		public void MXTPBRAKJJK(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "19")]
		public void GPTVANVBTUW(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "20")]
		public ConnectableGraphData BMYFENJHZYT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "21")]
		public ConnectableGraphData YNDRFXBPQXX(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "22")]
		public bool AERDDQNFPAX(GNBPGMVYAHJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "23")]
		public void QIFZGLMBWDG(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "24")]
		public void POTVFKSNDSC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "25")]
		public void WGUHFVUSFVV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TUIBIQOREDG()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NYDBEHLDYNW : INSNNNPZVNX, IEquatable<NYDBEHLDYNW>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface INSNNNPZVNX
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		NYDBEHLDYNW ParentConnectable
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
		bool CanConnectTo(int slotIndex, NYDBEHLDYNW otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, NYDBEHLDYNW newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, NYDBEHLDYNW newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, NYDBEHLDYNW removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, NYDBEHLDYNW parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(NYDBEHLDYNW previousRootConnectable, NYDBEHLDYNW newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface QTNSDDNHNRZ : RPNCXIAYMUG
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool XYSPVSPMHUE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool MNZRXJBQTNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<NYDBEHLDYNW, NYDBEHLDYNW> TVDEDBHEKRJ;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<NYDBEHLDYNW, NYDBEHLDYNW> CZKPLFYCAWJ;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<NYDBEHLDYNW, NYDBEHLDYNW, NYDBEHLDYNW> OIBUSGDDYYP;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, GKAFIFJWYIO configData, ILEKZBIOGUN rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void PUOFOOQAOVA(NYDBEHLDYNW a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void UICJQLYJDWB(NYDBEHLDYNW a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void YZXEZHSDEXA(NYDBEHLDYNW a, HashSet<NYDBEHLDYNW> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void GWSFLWUPZGI(NYDBEHLDYNW a, NYDBEHLDYNW b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void MXTPBRAKJJK(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GPTVANVBTUW(NYDBEHLDYNW a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData BMYFENJHZYT(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData YNDRFXBPQXX(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool AERDDQNFPAX(GNBPGMVYAHJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void QIFZGLMBWDG(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void POTVFKSNDSC(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void WGUHFVUSFVV(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface MFOSKOXIBSJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NYDBEHLDYNW EZIDFEGIQMH(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NYDBEHLDYNW XSAYHGKUTGO(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool QMOGELZJWTI(NYDBEHLDYNW a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool EJNULNMVPKO();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UOKIEADIBVL(NYDBEHLDYNW a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface XZKNMEOKGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PROXLXCNZXU(BYQRMDVZYIC a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DJNHHHCBTPJ(BYQRMDVZYIC a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string GCOHIZTKKUK(BYQRMDVZYIC a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid KYDLVLMBVSR(BYQRMDVZYIC a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int KZXUEQOORVY(BYQRMDVZYIC a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CAVLBWNDIXX(BYQRMDVZYIC a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(NYDBEHLDYNW childConnectable, int childConnectableSlot, NYDBEHLDYNW parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(NYDBEHLDYNW previousRootConnectable, NYDBEHLDYNW newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BYQRMDVZYIC : NYDBEHLDYNW, INSNNNPZVNX, IEquatable<NYDBEHLDYNW>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface NBWGYFGNBPG : INSNNNPZVNX
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		NYDBEHLDYNW CXGNUPRRZNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<NYDBEHLDYNW> AONVGGSQKNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 QIPCRBSOSRT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion TDUDBZHIEUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool ZZLXIOHZMNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool QAFHQVYBALJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler LPSTXGKFYBP;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler AJBUNLFWKDB;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler YREQAIGWUNS;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler BECLARDBZTR;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void VSEJZNQCCFX();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void AIQVOITDKVE();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void HEDHFLKJJBV();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void EEMHIPGCWFK();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void LKOWPPKMHCT(int a, NYDBEHLDYNW b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void ELOXVAJOMMP();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void MGIRFJWVVHX(int a, NYDBEHLDYNW b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void XHXWULNHPIL(NYDBEHLDYNW a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void XGRXLQNPRBY();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void ZUJNVDFBKPX(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void RXZDPKRFZOE(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ABWHLQONACU
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 HDCJFXPRMBF
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
	public interface GKAFIFJWYIO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool PJIEGCTGCXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		FAGROLLFFVH TLWJXBICADA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, GKAFIFJWYIO
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
		public bool PJIEGCTGCXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FAGROLLFFVH TLWJXBICADA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x849FE20", Offset = "0x849EC20", VA = "0x18849FE20")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x849FEE0", Offset = "0x849ECE0", VA = "0x18849FEE0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NYDBEHLDYNW connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x84A03A0", Offset = "0x849F1A0", VA = "0x1884A03A0")]
		public ConnectableLink(NYDBEHLDYNW connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84A0400", Offset = "0x849F200", VA = "0x1884A0400")]
		public ConnectableLink(NYDBEHLDYNW connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x84A04A0", Offset = "0x849F2A0", VA = "0x1884A04A0")]
		public ConnectableLink(NYDBEHLDYNW connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x849FF30", Offset = "0x849ED30", VA = "0x18849FF30", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x849FFE0", Offset = "0x849EDE0", VA = "0x18849FFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : KEEGRZOSWDR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform LUTJRPOGMJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private FAGROLLFFVH PZNCQYHEWEB;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A7B0", Offset = "0x7E295B0", VA = "0x187E2A7B0", Slot = "4")]
		public void Initialize(Transform transform, FAGROLLFFVH linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84A0CB0", Offset = "0x849FAB0", VA = "0x1884A0CB0", Slot = "5")]
		public FAGROLLFFVH RTMNNMWULPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84A0C40", Offset = "0x849FA40", VA = "0x1884A0C40", Slot = "6")]
		public void PNSTCGKZLCT(FAGROLLFFVH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, ALDFABQAYOL
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class LZXPMSDOCGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public NYDBEHLDYNW TMCNRUPHCXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public NYDBEHLDYNW KCKRCOLNEFR;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LZXPMSDOCGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x84A0B80", Offset = "0x849F980", VA = "0x1884A0B80")]
			internal bool CCUPKIOBUOR(XZHTUDCHVJO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly SWHXKNAYXKF IHGEZZTHWVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NQLIOGTPBPW UVIRRLQHRCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private OIIOVCQXYMY BVYAGWWSHNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool JENNDCBEZGY;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log CDBIHDZTHIG;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public XZHTUDCHVJO NKNEDPIWGGX
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84A2120", Offset = "0x84A0F20", VA = "0x1884A2120")]
		public bool JRVDXYPHPSQ([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x84A34B0", Offset = "0x84A22B0", VA = "0x1884A34B0")]
		private bool SXZSZWITGDN([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84A4940", Offset = "0x84A3740", VA = "0x1884A4940")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x84A2070", Offset = "0x84A0E70", VA = "0x1884A2070", Slot = "5")]
		public void Initialize(QTNSDDNHNRZ manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84A2130", Offset = "0x84A0F30", VA = "0x1884A2130", Slot = "17")]
		public void KXOHPGLODWN(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x84A2410", Offset = "0x84A1210", VA = "0x1884A2410", Slot = "12")]
		public void MAWMJMKKBLW(Func<NYDBEHLDYNW, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x84A22E0", Offset = "0x84A10E0", VA = "0x1884A22E0")]
		private void MAWMJMKKBLW(SWHXKNAYXKF a, Func<NYDBEHLDYNW, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x84A2160", Offset = "0x84A0F60", VA = "0x1884A2160", Slot = "11")]
		public void LFYKCIBWDKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84A2060", Offset = "0x84A0E60", VA = "0x1884A2060", Slot = "8")]
		public bool ILIXDOOZZER(NYDBEHLDYNW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x84A1590", Offset = "0x84A0390", VA = "0x1884A1590")]
		private bool BUSUFRSVXUC(NYDBEHLDYNW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x84A1DB0", Offset = "0x84A0BB0", VA = "0x1884A1DB0")]
		private static bool DIBVBRZCNQU(NYDBEHLDYNW a, SWHXKNAYXKF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x84A2BB0", Offset = "0x84A19B0", VA = "0x1884A2BB0")]
		private void QCKDJDBAVJA(Transform a, SWHXKNAYXKF b, SWHXKNAYXKF[] c, NYDBEHLDYNW d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x84A3E20", Offset = "0x84A2C20", VA = "0x1884A3E20")]
		private ConnectableLink WRMQUXGIFTR(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x84A4120", Offset = "0x84A2F20", VA = "0x1884A4120")]
		private static bool XWJSTPATLTA(SWHXKNAYXKF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x84A4820", Offset = "0x84A3620", VA = "0x1884A4820", Slot = "9")]
		public bool ZXIXTXWSMXP(NYDBEHLDYNW a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x84A3BD0", Offset = "0x84A29D0", VA = "0x1884A3BD0")]
		private bool VQCDQKZCLQG(NYDBEHLDYNW a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x84A2480", Offset = "0x84A1280", VA = "0x1884A2480")]
		private static void PCWYQGSQAXD(NYDBEHLDYNW a, int b, int c, Vector3 d, Quaternion e, SWHXKNAYXKF f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x84A1C90", Offset = "0x84A0A90", VA = "0x1884A1C90")]
		private void CFHDZBHJFIS(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x84A4040", Offset = "0x84A2E40", VA = "0x1884A4040")]
		private void XMVDIGQBIJI(SWHXKNAYXKF a, NYDBEHLDYNW b, NYDBEHLDYNW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x84A40B0", Offset = "0x84A2EB0", VA = "0x1884A40B0")]
		private void XMVDIGQBIJI(NYDBEHLDYNW a, NYDBEHLDYNW b, NYDBEHLDYNW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x84A2FA0", Offset = "0x84A1DA0", VA = "0x1884A2FA0")]
		private void RRNHBPGSNSX(NYDBEHLDYNW a, NYDBEHLDYNW b, NYDBEHLDYNW c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x84A3010", Offset = "0x84A1E10", VA = "0x1884A3010")]
		private void RRNHBPGSNSX(SWHXKNAYXKF a, NYDBEHLDYNW b, NYDBEHLDYNW c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x84A3A70", Offset = "0x84A2870", VA = "0x1884A3A70")]
		private void TEHJIDSZJYO(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x84A3110", Offset = "0x84A1F10", VA = "0x1884A3110")]
		private void RWDDUVBORMQ(XZHTUDCHVJO a, XZHTUDCHVJO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x84A2180", Offset = "0x84A0F80", VA = "0x1884A2180", Slot = "18")]
		public NYDBEHLDYNW LUGSRVRYEBD(NYDBEHLDYNW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x84A42E0", Offset = "0x84A30E0", VA = "0x1884A42E0", Slot = "13")]
		public void YZXEZHSDEXA(NYDBEHLDYNW a, HashSet<NYDBEHLDYNW> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x84A3270", Offset = "0x84A2070", VA = "0x1884A3270", Slot = "14")]
		public List<NYDBEHLDYNW> SVYMZOGDSQG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x84A3F70", Offset = "0x84A2D70", VA = "0x1884A3F70")]
		protected XZHTUDCHVJO XCJIAVUZNNX(XZHTUDCHVJO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x84A4670", Offset = "0x84A3470", VA = "0x1884A4670")]
		protected SWHXKNAYXKF[] ZBZAYLAINPE(SWHXKNAYXKF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x84A4710", Offset = "0x84A3510", VA = "0x1884A4710")]
		protected bool ZTFPGBKYCHF(NYDBEHLDYNW a, [Out] SWHXKNAYXKF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x84A1E60", Offset = "0x84A0C60", VA = "0x1884A1E60", Slot = "15")]
		public bool HWCCZMRCYLZ(NYDBEHLDYNW a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x84A3B90", Offset = "0x84A2990", VA = "0x1884A3B90")]
		protected SWHXKNAYXKF TRGPYEWMSLS(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x84A2420", Offset = "0x84A1220", VA = "0x1884A2420", Slot = "10")]
		public bool OBXRISAJIKP(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x84A2600", Offset = "0x84A1400", VA = "0x1884A2600")]
		private bool PZCDAUAXZUK(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x84A1F90", Offset = "0x84A0D90", VA = "0x1884A1F90")]
		private static bool HWWCVBOZPKA(SWHXKNAYXKF a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x84A2120", Offset = "0x84A0F20", VA = "0x1884A2120", Slot = "7")]
		private bool UPRATROTTEN([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : QTNSDDNHNRZ, RPNCXIAYMUG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly FDTRVDFSBYT container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly OIIOVCQXYMY BVYAGWWSHNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly BJYVVRILVBX TWZJSSJLAWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly OTLRLYVWXGT AJNTALXDOYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly ALDFABQAYOL ALOBIJDMKUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal ZOERAMPGWDG FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NPTFZEOOKRZ FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal NQLIOGTPBPW XPQMBUOCYMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool JENNDCBEZGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool UYEJBYZXILH;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool VEEAXHZWHQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB09E60", Offset = "0xB08C60", VA = "0x180B09E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xB09A20", Offset = "0xB08820", VA = "0x180B09A20")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool XYSPVSPMHUE
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xB45FB0", Offset = "0xB44DB0", VA = "0x180B45FB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xB46010", Offset = "0xB44E10", VA = "0x180B46010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MNZRXJBQTNY
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<NYDBEHLDYNW, NYDBEHLDYNW> TVDEDBHEKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x84A5300", Offset = "0x84A4100", VA = "0x1884A5300", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x84A6740", Offset = "0x84A5540", VA = "0x1884A6740", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<NYDBEHLDYNW, NYDBEHLDYNW> CZKPLFYCAWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x84A6440", Offset = "0x84A5240", VA = "0x1884A6440", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x84A4B40", Offset = "0x84A3940", VA = "0x1884A4B40", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<NYDBEHLDYNW, NYDBEHLDYNW, NYDBEHLDYNW> OIBUSGDDYYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x84A61C0", Offset = "0x84A4FC0", VA = "0x1884A61C0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x84A4EC0", Offset = "0x84A3CC0", VA = "0x1884A4EC0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x84A67A0", Offset = "0x84A55A0", VA = "0x1884A67A0")]
		public LegacyConnectableManager(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x84A5360", Offset = "0x84A4160", VA = "0x1884A5360", Slot = "12")]
		public void Initialize(GameObject gameObject, GKAFIFJWYIO configData, ILEKZBIOGUN rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x84A5A60", Offset = "0x84A4860", VA = "0x1884A5A60", Slot = "26")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x84A6140", Offset = "0x84A4F40", VA = "0x1884A6140", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x84A5BE0", Offset = "0x84A49E0", VA = "0x1884A5BE0", Slot = "14")]
		public void PUOFOOQAOVA(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x84A4BA0", Offset = "0x84A39A0", VA = "0x1884A4BA0", Slot = "15")]
		public void UICJQLYJDWB(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x84A4AF0", Offset = "0x84A38F0", VA = "0x1884A4AF0", Slot = "22")]
		public bool AERDDQNFPAX(GNBPGMVYAHJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x84A5C00", Offset = "0x84A4A00", VA = "0x1884A5C00")]
		internal bool PZCDAUAXZUK([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x84A5FF0", Offset = "0x84A4DF0", VA = "0x1884A5FF0")]
		internal bool SPFRGIOZYCE([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x84A6220", Offset = "0x84A5020", VA = "0x1884A6220")]
		internal void WDVOSIXOZGM(NYDBEHLDYNW a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x84A4BA0", Offset = "0x84A39A0", VA = "0x1884A4BA0")]
		internal bool BILMGRVBLKG(NYDBEHLDYNW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x84A4D80", Offset = "0x84A3B80", VA = "0x1884A4D80")]
		internal bool FBGTHNFBPSQ(NYDBEHLDYNW a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x84A6640", Offset = "0x84A5440", VA = "0x1884A6640", Slot = "16")]
		public void YZXEZHSDEXA(NYDBEHLDYNW a, HashSet<NYDBEHLDYNW> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x84A50F0", Offset = "0x84A3EF0", VA = "0x1884A50F0", Slot = "17")]
		public void GWSFLWUPZGI(NYDBEHLDYNW a, NYDBEHLDYNW b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x84A5920", Offset = "0x84A4720", VA = "0x1884A5920", Slot = "18")]
		public void MXTPBRAKJJK(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x84A4F20", Offset = "0x84A3D20", VA = "0x1884A4F20", Slot = "19")]
		public void GPTVANVBTUW(NYDBEHLDYNW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x84A5DA0", Offset = "0x84A4BA0", VA = "0x1884A5DA0")]
		public void QUYOHPRDHLR([Optional] XGOJTPBZDNO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x84A5D10", Offset = "0x84A4B10", VA = "0x1884A5D10", Slot = "23")]
		public void QIFZGLMBWDG(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x84A4C00", Offset = "0x84A3A00", VA = "0x1884A4C00", Slot = "20")]
		public ConnectableGraphData BMYFENJHZYT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x84A64A0", Offset = "0x84A52A0", VA = "0x1884A64A0", Slot = "21")]
		public ConnectableGraphData YNDRFXBPQXX(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x84A6400", Offset = "0x84A5200", VA = "0x1884A6400", Slot = "25")]
		public void WGUHFVUSFVV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x84A5B30", Offset = "0x84A4930", VA = "0x1884A5B30", Slot = "24")]
		public void POTVFKSNDSC(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class OIIOVCQXYMY : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly OZQTPLDUBEZ<NYDBEHLDYNW, NYDBEHLDYNW> TVDEDBHEKRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly OZQTPLDUBEZ<NYDBEHLDYNW, NYDBEHLDYNW> CZKPLFYCAWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly OZLMSEJWRTQ<NYDBEHLDYNW, NYDBEHLDYNW, NYDBEHLDYNW> OIBUSGDDYYP;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x84A8A50", Offset = "0x84A7850", VA = "0x1884A8A50")]
		public OIIOVCQXYMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x84A89F0", Offset = "0x84A77F0", VA = "0x1884A89F0")]
		public void UJKAKZJSBLB(NYDBEHLDYNW a, NYDBEHLDYNW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x84A8910", Offset = "0x84A7710", VA = "0x1884A8910")]
		public void HBLBAROCYQN(NYDBEHLDYNW a, NYDBEHLDYNW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x84A8970", Offset = "0x84A7770", VA = "0x1884A8970")]
		public void JNVQKUWSJXF(NYDBEHLDYNW a, NYDBEHLDYNW b, NYDBEHLDYNW c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class BJYVVRILVBX : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager OHUMEPMNHVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private NPTFZEOOKRZ FBPQEEAUUKV;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public BJYVVRILVBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x849FA40", Offset = "0x849E840", VA = "0x18849FA40")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x849FA30", Offset = "0x849E830", VA = "0x18849FA30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x849FBE0", Offset = "0x849E9E0", VA = "0x18849FBE0")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x849FB70", Offset = "0x849E970", VA = "0x18849FB70")]
		private void OnMasterClientSwitched(XGOJTPBZDNO newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x849FC20", Offset = "0x849EA20", VA = "0x18849FC20")]
		public void PVNIJJCCCSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x849FD20", Offset = "0x849EB20", VA = "0x18849FD20")]
		public void PWQZDEIVZGE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class ZMTRZCDQVRL
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public FDTRVDFSBYT container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x84B3E30", Offset = "0x84B2C30", VA = "0x1884B3E30")]
			internal LegacyConnectableManager RLGEITLSHIQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x84B3F30", Offset = "0x84B2D30", VA = "0x1884B3F30")]
		public static void SPRZIZAVPUE(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x84B4130", Offset = "0x84B2F30", VA = "0x1884B4130")]
		public static void TRAOHEVYGWP(FDTRVDFSBYT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, NQLIOGTPBPW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, FAGROLLFFVH> GEQQIBCCDIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation VQTWEGJPLMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private KEEGRZOSWDR DDESSPQGPTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private ALDFABQAYOL ALOBIJDMKUF;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker GVBRVMJTVYT;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x84A7790", Offset = "0x84A6590", VA = "0x1884A7790")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x84A6EC0", Offset = "0x84A5CC0", VA = "0x1884A6EC0", Slot = "7")]
		public void Initialize(ALDFABQAYOL graph, KEEGRZOSWDR creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x84A6C80", Offset = "0x84A5A80", VA = "0x1884A6C80", Slot = "5")]
		public void FPRYUVZBKJK(XZHTUDCHVJO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x84A6F00", Offset = "0x84A5D00", VA = "0x1884A6F00", Slot = "9")]
		public void OBAMDQNIUWH(XZHTUDCHVJO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x84A7070", Offset = "0x84A5E70", VA = "0x1884A7070", Slot = "8")]
		public void OUPTUZZETYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x84A73E0", Offset = "0x84A61E0", VA = "0x1884A73E0", Slot = "10")]
		public void UZIQZTBTXKY(XZHTUDCHVJO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x84A6B30", Offset = "0x84A5930", VA = "0x1884A6B30", Slot = "11")]
		public void ASKRZUXYDNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x84A7230", Offset = "0x84A6030", VA = "0x1884A7230")]
		private bool SXROXBAHPMX(XZHTUDCHVJO a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class OTLRLYVWXGT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly SWHXKNAYXKF currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly GNBPGMVYAHJ parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly GNBPGMVYAHJ rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool NEGBJMEELHS
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x84B2F70", Offset = "0x84B1D70", VA = "0x1884B2F70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x84B3230", Offset = "0x84B2030", VA = "0x1884B3230")]
			public SerializeNodeInSubgraph(SWHXKNAYXKF currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] GNBPGMVYAHJ parentNodeData, [Optional] GNBPGMVYAHJ rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x84B3090", Offset = "0x84B1E90", VA = "0x1884B3090")]
			public GNBPGMVYAHJ VVUFAYMMXPR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x84B2CF0", Offset = "0x84B1AF0", VA = "0x1884B2CF0")]
			private GNBPGMVYAHJ JXALFEJZYMT([Out] GNBPGMVYAHJ a, [Out] GNBPGMVYAHJ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x84B2AF0", Offset = "0x84B18F0", VA = "0x1884B2AF0")]
			private GNBPGMVYAHJ ECURWFOBDQR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x84B2980", Offset = "0x84B1780", VA = "0x1884B2980")]
			private void CGEAIMZNXJJ(GNBPGMVYAHJ a, GNBPGMVYAHJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x84B2DB0", Offset = "0x84B1BB0", VA = "0x1884B2DB0")]
			private void SYXKZEXOULO(GNBPGMVYAHJ a, GNBPGMVYAHJ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager OHUMEPMNHVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private ALDFABQAYOL ALOBIJDMKUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private NQLIOGTPBPW UVIRRLQHRCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private NPTFZEOOKRZ FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool PKTZALWTLZZ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool DUKOYGTMBTK
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x84AFA60", Offset = "0x84AE860", VA = "0x1884AFA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool VEEAXHZWHQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x84B0EC0", Offset = "0x84AFCC0", VA = "0x1884B0EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x84B1800", Offset = "0x84B0600", VA = "0x1884B1800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x84AFDF0", Offset = "0x84AEBF0", VA = "0x1884AFDF0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x84AF5E0", Offset = "0x84AE3E0", VA = "0x1884AF5E0")]
		public ConnectableGraphData BMYFENJHZYT(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x84B1820", Offset = "0x84B0620", VA = "0x1884B1820")]
		public ConnectableGraphData YNDRFXBPQXX(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x84B08F0", Offset = "0x84AF6F0", VA = "0x1884B08F0")]
		public void QIFZGLMBWDG(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x84B0850", Offset = "0x84AF650", VA = "0x1884B0850")]
		public void POTVFKSNDSC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84B0820", Offset = "0x84AF620", VA = "0x1884B0820")]
		public void PANLJFKWOZS(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x84B0980", Offset = "0x84AF780", VA = "0x1884B0980")]
		private void RJULCWAFRMS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x84B05F0", Offset = "0x84AF3F0", VA = "0x1884B05F0")]
		private GNBPGMVYAHJ OXBIUIQSRUX(SWHXKNAYXKF a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x84B0C70", Offset = "0x84AFA70", VA = "0x1884B0C70")]
		private static void RTXIXVLLVBV(SWHXKNAYXKF a, bool b, GNBPGMVYAHJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x84B15E0", Offset = "0x84B03E0", VA = "0x1884B15E0")]
		private void WBFIEABNFZC(SWHXKNAYXKF a, bool b, GNBPGMVYAHJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x84B1550", Offset = "0x84B0350", VA = "0x1884B1550")]
		private GNBPGMVYAHJ ULIBOSMFEMR(SWHXKNAYXKF a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x84B01D0", Offset = "0x84AEFD0", VA = "0x1884B01D0")]
		private bool OGNWPZUGJCV(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x84B0EE0", Offset = "0x84AFCE0", VA = "0x1884B0EE0")]
		private bool UEZGELGHGYM(GNBPGMVYAHJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x84AFE60", Offset = "0x84AEC60", VA = "0x1884AFE60")]
		private bool LORKPOLVLVU(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x84B0B60", Offset = "0x84AF960", VA = "0x1884B0B60")]
		private static bool RQGXXPTEOSD(GNBPGMVYAHJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x84AF350", Offset = "0x84AE150", VA = "0x1884AF350")]
		public static bool AERDDQNFPAX(GNBPGMVYAHJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x84AFAB0", Offset = "0x84AE8B0", VA = "0x1884AFAB0")]
		private NYDBEHLDYNW FKDQTBYZAGB(GNBPGMVYAHJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x84AF8E0", Offset = "0x84AE6E0", VA = "0x1884AF8E0")]
		private NYDBEHLDYNW EZIDFEGIQMH(GNBPGMVYAHJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x84B0460", Offset = "0x84AF260", VA = "0x1884B0460")]
		private NYDBEHLDYNW OIBSPKOUGSC(GNBPGMVYAHJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x84ACBB0", Offset = "0x84AB9B0", VA = "0x1884ACBB0")]
		private static Guid UFZBAJZBTKQ(GNBPGMVYAHJ a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84B00E0", Offset = "0x84AEEE0", VA = "0x1884B00E0")]
		private string MFXLTZFINPT(GNBPGMVYAHJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x84AF750", Offset = "0x84AE550", VA = "0x1884AF750")]
		private bool CIKYVYOMJPW(SWHXKNAYXKF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x84AFE80", Offset = "0x84AEC80", VA = "0x1884AFE80")]
		private static void LXZJQLQBOSC(SWHXKNAYXKF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public OTLRLYVWXGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NYDBEHLDYNW child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NYDBEHLDYNW parent;

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
		public ConnectableLink CCMAGZJGLBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x84A0550", Offset = "0x849F350", VA = "0x1884A0550")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink ZPMUQKVJUAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x84A0520", Offset = "0x849F320", VA = "0x1884A0520")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x84A05F0", Offset = "0x849F3F0", VA = "0x1884A05F0")]
		public ConnectionOperationData(NYDBEHLDYNW child, NYDBEHLDYNW parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface ALDFABQAYOL
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		XZHTUDCHVJO NKNEDPIWGGX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(QTNSDDNHNRZ manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool JRVDXYPHPSQ([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ILIXDOOZZER(NYDBEHLDYNW a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ZXIXTXWSMXP(NYDBEHLDYNW a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OBXRISAJIKP(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LFYKCIBWDKI();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void MAWMJMKKBLW(Func<NYDBEHLDYNW, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YZXEZHSDEXA(NYDBEHLDYNW a, HashSet<NYDBEHLDYNW> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<NYDBEHLDYNW> SVYMZOGDSQG();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HWCCZMRCYLZ(NYDBEHLDYNW a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void KXOHPGLODWN(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(XZHTUDCHVJO node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface XZHTUDCHVJO
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		NYDBEHLDYNW RAYLXWIVXZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		XZHTUDCHVJO IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink QLRKMYBFHLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool UMEGAFSDCAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface FAGROLLFFVH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RWFLESYWDGJ(NYDBEHLDYNW a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QPFWASZBWLX(NYDBEHLDYNW a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QXSEIILYJIC(NYDBEHLDYNW a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GVBZSNHUKPQ(NYDBEHLDYNW a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		FAGROLLFFVH CKGAWMQWAKJ(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface KEEGRZOSWDR
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, FAGROLLFFVH linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FAGROLLFFVH RTMNNMWULPR();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PNSTCGKZLCT(FAGROLLFFVH a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface ZOERAMPGWDG : MFOSKOXIBSJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OOIUTLIUCWO();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FEDNVKTNYAP(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface NQLIOGTPBPW
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FPRYUVZBKJK(XZHTUDCHVJO a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(ALDFABQAYOL graph, KEEGRZOSWDR linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OUPTUZZETYV();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OBAMDQNIUWH(XZHTUDCHVJO a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UZIQZTBTXKY(XZHTUDCHVJO a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ASKRZUXYDNC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class SWHXKNAYXKF : XZHTUDCHVJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class PVMZXNYXUAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink PEHNKBOTRYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public SWHXKNAYXKF BPDBTJPXEAZ;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public PVMZXNYXUAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x84B1BF0", Offset = "0x84B09F0", VA = "0x1884B1BF0")]
			internal bool QSORVVHIJJS(XZHTUDCHVJO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink ETLASIUZATV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<SWHXKNAYXKF> GYIVLHUMCMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private SWHXKNAYXKF VVTUVSEMTJS;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink QLRKMYBFHLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1561420", Offset = "0x1560220", VA = "0x181561420", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1561860", Offset = "0x1560660", VA = "0x181561860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private SWHXKNAYXKF HATHWVTRAGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x84B21C0", Offset = "0x84B0FC0", VA = "0x1884B21C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public XZHTUDCHVJO IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public NYDBEHLDYNW RAYLXWIVXZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool UMEGAFSDCAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x84B1FD0", Offset = "0x84B0DD0", VA = "0x1884B1FD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool SHMFVAXPXGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x84B2150", Offset = "0x84B0F50", VA = "0x1884B2150", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected SWHXKNAYXKF BSGUJACPZOT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x84B21A0", Offset = "0x84B0FA0", VA = "0x1884B21A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x84B28E0", Offset = "0x84B16E0", VA = "0x1884B28E0")]
		public SWHXKNAYXKF(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x84B2620", Offset = "0x84B1420", VA = "0x1884B2620")]
		public SWHXKNAYXKF UBMOPDDJDKA(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x84B2760", Offset = "0x84B1560", VA = "0x1884B2760")]
		public SWHXKNAYXKF XBWFKGRMRMI(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x84B22A0", Offset = "0x84B10A0", VA = "0x1884B22A0")]
		public SWHXKNAYXKF Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x84B1E80", Offset = "0x84B0C80", VA = "0x1884B1E80")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x84B2480", Offset = "0x84B1280", VA = "0x1884B2480")]
		public SWHXKNAYXKF Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x84B1FF0", Offset = "0x84B0DF0", VA = "0x1884B1FF0")]
		private static void KXOHPGLODWN(SWHXKNAYXKF a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x84B1FE0", Offset = "0x84B0DE0", VA = "0x1884B1FE0", Slot = "9")]
		public void KXOHPGLODWN(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x84B2530", Offset = "0x84B1330", VA = "0x1884B2530")]
		public static SWHXKNAYXKF TRGPYEWMSLS(SWHXKNAYXKF a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface NPTFZEOOKRZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool DUKOYGTMBTK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> MYYZQVRYHBG;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<XGOJTPBZDNO> FDYUBXVVHBQ;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RWFLESYWDGJ(LegacyConnectableManager a, ILEKZBIOGUN b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GWSFLWUPZGI(NYDBEHLDYNW a, NYDBEHLDYNW b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MXTPBRAKJJK(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void PLLETFGGLYB(ConnectableGraphData a, [Optional] XGOJTPBZDNO b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class EIMRQDDPIZF
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x84A06A0", Offset = "0x849F4A0", VA = "0x1884A06A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x84A0660", Offset = "0x849F460", VA = "0x1884A0660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x84A06F0", Offset = "0x849F4F0", VA = "0x1884A06F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class MZZNAJNLLUE : NPTFZEOOKRZ, IDisposable, IINKLCBDCVV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager OHUMEPMNHVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private ILEKZBIOGUN ABGGNHCKVWB;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool DUKOYGTMBTK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x84A7A40", Offset = "0x84A6840", VA = "0x1884A7A40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x84A7CF0", Offset = "0x84A6AF0", VA = "0x1884A7CF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView IIWGJFGQOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x84A7DD0", Offset = "0x84A6BD0", VA = "0x1884A7DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> MYYZQVRYHBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x84A80A0", Offset = "0x84A6EA0", VA = "0x1884A80A0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x84A7C60", Offset = "0x84A6A60", VA = "0x1884A7C60", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<XGOJTPBZDNO> FDYUBXVVHBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x84A7D30", Offset = "0x84A6B30", VA = "0x1884A7D30", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x84A7AA0", Offset = "0x84A68A0", VA = "0x1884A7AA0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x84A8130", Offset = "0x84A6F30", VA = "0x1884A8130", Slot = "10")]
		public void RWFLESYWDGJ(LegacyConnectableManager a, ILEKZBIOGUN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x84A79F0", Offset = "0x84A67F0", VA = "0x1884A79F0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x84A7B40", Offset = "0x84A6940", VA = "0x1884A7B40", Slot = "11")]
		public void GWSFLWUPZGI(NYDBEHLDYNW a, NYDBEHLDYNW b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x84A7E60", Offset = "0x84A6C60", VA = "0x1884A7E60", Slot = "12")]
		public void MXTPBRAKJJK(NYDBEHLDYNW a, int b, NYDBEHLDYNW c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x84A7F80", Offset = "0x84A6D80", VA = "0x1884A7F80", Slot = "13")]
		public void PLLETFGGLYB(ConnectableGraphData a, [Optional] XGOJTPBZDNO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x84A83F0", Offset = "0x84A71F0", VA = "0x1884A83F0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(NYDBEHLDYNW objectToReparent, int objectToReparentSlotIndex, NYDBEHLDYNW newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x84A8200", Offset = "0x84A7000", VA = "0x1884A8200")]
		[RPCMethod]
		private void RpcMasterModifyNode(NYDBEHLDYNW connectableToModify, NYDBEHLDYNW expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x84A87E0", Offset = "0x84A75E0", VA = "0x1884A87E0")]
		[RPCMethod]
		private void RpcReparentNodes(NYDBEHLDYNW objectToReparent, int objectToReparentSlotIndex, NYDBEHLDYNW newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x84A86F0", Offset = "0x84A74F0", VA = "0x1884A86F0")]
		[RPCMethod]
		private void RpcModifyNode(NYDBEHLDYNW connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x84A81C0", Offset = "0x84A6FC0", VA = "0x1884A81C0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public MZZNAJNLLUE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, FAGROLLFFVH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x84A1410", Offset = "0x84A0210", VA = "0x1884A1410", Slot = "4")]
		private void YGRXSNBCZFO(NYDBEHLDYNW a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x84A0EE0", Offset = "0x849FCE0", VA = "0x1884A0EE0", Slot = "5")]
		private void BGWGDFKJTJW(NYDBEHLDYNW a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x84A0D80", Offset = "0x849FB80", VA = "0x1884A0D80", Slot = "6")]
		private void BEMNEQTDBAJ(NYDBEHLDYNW a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x84A1150", Offset = "0x849FF50", VA = "0x1884A1150", Slot = "7")]
		private void CJYBEOOVCHJ(NYDBEHLDYNW a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x84A13A0", Offset = "0x84A01A0", VA = "0x1884A13A0", Slot = "8")]
		private FAGROLLFFVH HDZFQIJNEDQ(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x84A1340", Offset = "0x84A0140", VA = "0x1884A1340", Slot = "9")]
		private void CUMRSIIXLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class FSXUSXZQBBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x38EBF90", Offset = "0x38EAD90", VA = "0x1838EBF90")]
		public static DQAZSAETUGW<a> RFRPTXTZEXP<a>(this FDTRVDFSBYT a)
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
