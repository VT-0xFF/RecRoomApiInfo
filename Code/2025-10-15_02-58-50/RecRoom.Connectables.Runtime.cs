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
		[Cpp2IlInjected.Address(RVA = "0x839C360", Offset = "0x839B160", VA = "0x18839C360", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		private int[] DAADMOFRSKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] CZUWPHLUIZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset RDSSOODTNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset RDXZLUXQWUR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x242C360", Offset = "0x242B160", VA = "0x18242C360", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83A7D70", Offset = "0x83A6B70", VA = "0x1883A7D70")]
		private void ZZHVSKGGGUO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83A7ED0", Offset = "0x83A6CD0", VA = "0x1883A7ED0")]
		private void ZZNCPRADQFX(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83A7A60", Offset = "0x83A6860", VA = "0x1883A7A60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83A8030", Offset = "0x83A6E30", VA = "0x1883A8030")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : YVWWJBXBUTR, BQLXQKHZRWO
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class WBGBFALKXVD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public BVCOGACJCKD RVQBCBBNFLN;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WBGBFALKXVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x83A74D0", Offset = "0x83A62D0", VA = "0x1883A74D0")]
			internal object UBYFSVSVFOI(BVCOGACJCKD a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class WBAUHTRNOJU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public BVCOGACJCKD BUFJLIMATNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public WBGBFALKXVD JOWOLGJKVOM;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WBAUHTRNOJU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x83A7290", Offset = "0x83A6090", VA = "0x1883A7290")]
			internal object UCDMQCMSOZR((BVCOGACJCKD child, BVCOGACJCKD nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JOOALSHLWHM : IEnumerable<FPCMEBGKSIQ>, IEnumerable, IEnumerator<FPCMEBGKSIQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private FPCMEBGKSIQ KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId BOHBSZBBQIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId WSHWRAVUJNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private CRGTHIQPIZW EWMFVVUWEQO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray LBPCSZOFONQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator RTBEGLBVNTX;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private FPCMEBGKSIQ ENFBPLVNVRA
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
			[DebuggerHidden]
			public JOOALSHLWHM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8394DC0", Offset = "0x8393BC0", VA = "0x188394DC0", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8394F90", Offset = "0x8393D90", VA = "0x188394F90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x83952F0", Offset = "0x83940F0", VA = "0x1883952F0")]
			private void XVTZRJOPNYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8395310", Offset = "0x8394110", VA = "0x188395310")]
			private void XWJUJDWHQGV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8394EA0", Offset = "0x8393CA0", VA = "0x188394EA0", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8394EE0", Offset = "0x8393CE0", VA = "0x188394EE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FPCMEBGKSIQ> MMGVZQDQMWJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8394EE0", Offset = "0x8393CE0", VA = "0x188394EE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log SDRXDIHRUNA;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log KHVTKPFWNDW;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log PQHJTUXGTJK;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log JJBPORMVGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TGHLMTOLBPJ QSUMUGNQITW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SUGSKZLTCTW DUTRZIKOGKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private UCXYUXXQFIN OWSCPMOKMOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private QGYZCYYJEAR OKJTSMVEIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private EFGGAWMRUMB PGFQXODIKHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private WNENAPLSDNB JUYCTZCYHYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly CERMPDGXYNS YAQZQWZJBFV;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ONCGHIYWMTS
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA20F0", Offset = "0xAA0EF0", VA = "0x180AA20F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA21F0", Offset = "0xAA0FF0", VA = "0x180AA21F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool TFVGRHRNULI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<FPCMEBGKSIQ, FPCMEBGKSIQ> AJJJFCJHBUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x83A14E0", Offset = "0x83A02E0", VA = "0x1883A14E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x83A1CA0", Offset = "0x83A0AA0", VA = "0x1883A1CA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<FPCMEBGKSIQ, FPCMEBGKSIQ> ZPPQZVASSMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83A40B0", Offset = "0x83A2EB0", VA = "0x1883A40B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x839FCD0", Offset = "0x839EAD0", VA = "0x18839FCD0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<FPCMEBGKSIQ, FPCMEBGKSIQ, FPCMEBGKSIQ> TTEYLUIRVAT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x83A28E0", Offset = "0x83A16E0", VA = "0x1883A28E0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x83A1590", Offset = "0x83A0390", VA = "0x1883A1590", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83A4550", Offset = "0x83A3350", VA = "0x1883A4550")]
		public OMConnectableManager(MQNVASDZCUX container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83A1270", Offset = "0x83A0070", VA = "0x1883A1270", Slot = "12")]
		public void Initialize(GameObject gameObject, QJGEPBBULES configData, DXWATESPAZD sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83A2710", Offset = "0x83A1510", VA = "0x1883A2710", Slot = "26")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83A00B0", Offset = "0x839EEB0", VA = "0x1883A00B0", Slot = "22")]
		public bool DRWBEIMOZLB(BVCOGACJCKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83A1E90", Offset = "0x83A0C90", VA = "0x1883A1E90")]
		private void NLDCGPGKAAE(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83A2B20", Offset = "0x83A1920", VA = "0x1883A2B20")]
		private void RRFHPMXFFWC(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83A2D40", Offset = "0x83A1B40", VA = "0x1883A2D40")]
		private void SFCYUSWCQSM(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83A06E0", Offset = "0x839F4E0", VA = "0x1883A06E0")]
		private void GUHYRYXGLZJ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83A0D70", Offset = "0x839FB70", VA = "0x1883A0D70", Slot = "14")]
		public void IPFDCTVTWHM(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "15")]
		public void VKYFMNNRBOB(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x839FD80", Offset = "0x839EB80", VA = "0x18839FD80", Slot = "17")]
		public void BWJBSIZWVOY(FPCMEBGKSIQ a, FPCMEBGKSIQ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x839FEE0", Offset = "0x839ECE0", VA = "0x18839FEE0")]
		public void BWJBSIZWVOY(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83A3890", Offset = "0x83A2690", VA = "0x1883A3890")]
		public void UGTLJPLNMMY(FPCMEBGKSIQ a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83A3A80", Offset = "0x83A2880", VA = "0x1883A3A80", Slot = "18")]
		public void XDLGDZZKBNK(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83A4000", Offset = "0x83A2E00", VA = "0x1883A4000")]
		private float YYNFCURIAEY(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83A3940", Offset = "0x83A2740", VA = "0x1883A3940")]
		public void XDLGDZZKBNK(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83A0AF0", Offset = "0x839F8F0", VA = "0x1883A0AF0", Slot = "19")]
		public void GUWOJGYXCSG(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83A41D0", Offset = "0x83A2FD0", VA = "0x1883A41D0", Slot = "16")]
		public void ZYADFDVXSGK(FPCMEBGKSIQ a, HashSet<FPCMEBGKSIQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "20")]
		public ConnectableGraphData KDDFQBIHRCH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "21")]
		public ConnectableGraphData AOQQTGOGZYZ(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83A1E20", Offset = "0x83A0C20", VA = "0x1883A1E20", Slot = "23")]
		public void MPGAEIVZACA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83A1DB0", Offset = "0x83A0BB0", VA = "0x1883A1DB0", Slot = "24")]
		public void MEDMCWDMVZE(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83A3920", Offset = "0x83A2720", VA = "0x1883A3920", Slot = "25")]
		public void VYTEYQLUGPF(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83A0100", Offset = "0x839EF00", VA = "0x1883A0100")]
		private void FOCAWRWJGOO(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83A2FA0", Offset = "0x83A1DA0", VA = "0x1883A2FA0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83A4160", Offset = "0x83A2F60", VA = "0x1883A4160")]
		private void ZWRDXBUGOEB(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83A0020", Offset = "0x839EE20", VA = "0x1883A0020")]
		[IteratorStateMachine(typeof(JOOALSHLWHM))]
		public IEnumerable<FPCMEBGKSIQ> DNKIKOCKTWC(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83A1B60", Offset = "0x83A0960", VA = "0x1883A1B60")]
		internal FPCMEBGKSIQ LFBKZTZAEIN(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83A3E60", Offset = "0x83A2C60", VA = "0x1883A3E60")]
		internal ObjectLocalId XVEYFPWIJZD(FPCMEBGKSIQ a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83A2190", Offset = "0x83A0F90", VA = "0x1883A2190")]
		private bool PYYEWHJLQPW(BVCOGACJCKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83A1D50", Offset = "0x83A0B50", VA = "0x1883A1D50")]
		private bool MBGFSZAIMFS(BVCOGACJCKD a, [Out] FPCMEBGKSIQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83A17D0", Offset = "0x83A05D0", VA = "0x1883A17D0")]
		private FPCMEBGKSIQ LFBKZTZAEIN(BVCOGACJCKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83A1640", Offset = "0x83A0440", VA = "0x1883A1640")]
		private FPCMEBGKSIQ KSVMBPHGTWW(BVCOGACJCKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83A0510", Offset = "0x839F310", VA = "0x1883A0510")]
		private FPCMEBGKSIQ GONRBMRSDED(BVCOGACJCKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x839E580", Offset = "0x839D380", VA = "0x18839E580")]
		private static Guid RLOPYFISBRC(BVCOGACJCKD a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83A20A0", Offset = "0x83A0EA0", VA = "0x1883A20A0")]
		private string OIKEQXTRODX(BVCOGACJCKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83A2990", Offset = "0x83A1790", VA = "0x1883A2990")]
		private void QMMCNQYMEDI(FPCMEBGKSIQ a, FPCMEBGKSIQ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x839FB40", Offset = "0x839E940", VA = "0x18839FB40")]
		private void BRSQTYSABGS(FPCMEBGKSIQ a, FPCMEBGKSIQ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83A1080", Offset = "0x839FE80", VA = "0x1883A1080")]
		private void IRRKOGAVBFG(FPCMEBGKSIQ a, FPCMEBGKSIQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83A10E0", Offset = "0x839FEE0", VA = "0x1883A10E0")]
		private void ITTKYFZKMAF(FPCMEBGKSIQ a, FPCMEBGKSIQ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83A0C60", Offset = "0x839FA60", VA = "0x1883A0C60")]
		private void IDJSGYZYKQM(ObjectLocalId a, FPCMEBGKSIQ b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83A3BE0", Offset = "0x83A29E0", VA = "0x1883A3BE0")]
		private void XUFUPHKDTXN(ObjectLocalId a, FPCMEBGKSIQ b, FPCMEBGKSIQ c, FPCMEBGKSIQ d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class HDYAYLTDTJE
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class WRYJXOISUHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public MQNVASDZCUX container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WRYJXOISUHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x83A7540", Offset = "0x83A6340", VA = "0x1883A7540")]
			internal OMConnectableManager PEBRWCNHKNC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8394AC0", Offset = "0x83938C0", VA = "0x188394AC0")]
		public static void QYWJTJFIHZC(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8394A70", Offset = "0x8393870", VA = "0x188394A70")]
		public static void LAIRQVXPGSX(MQNVASDZCUX a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : QPIGTMYNGXK, SPQRRUGRPAZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx NGBJXBUYCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager WQEVQWSLHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly YPKBJZDMDVE UFPPOHAMXXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly QHWEAZMFLEW OKJTSMVEIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly LFCMTNFDAIQ[] VMXKJZBIHDK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FPCMEBGKSIQ ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x83A6150", Offset = "0x83A4F50", VA = "0x1883A6150", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FPCMEBGKSIQ LVQKJTBKSJR
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x83A5D20", Offset = "0x83A4B20", VA = "0x1883A5D20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 FACELJYNWBT
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83A5450", Offset = "0x83A4250", VA = "0x1883A5450", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion AKSMHZFBQCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83A4FE0", Offset = "0x83A3DE0", VA = "0x1883A4FE0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CNTNHRHEWPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x83A4690", Offset = "0x83A3490", VA = "0x1883A4690", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<FPCMEBGKSIQ> LESUKUDITTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x83A47A0", Offset = "0x83A35A0", VA = "0x1883A47A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool HOJWDFKBQCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xE06390", Offset = "0xE05190", VA = "0x180E06390", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xEEA360", Offset = "0xEE9160", VA = "0x180EEA360", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x83A6360", Offset = "0x83A5160", VA = "0x1883A6360", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x83A6060", Offset = "0x83A4E60", VA = "0x1883A6060", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x83A6080", Offset = "0x83A4E80", VA = "0x1883A6080", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x83A61B0", Offset = "0x83A4FB0", VA = "0x1883A61B0", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x83A6290", Offset = "0x83A5090", VA = "0x1883A6290", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool RYOBENBYJUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x83A5CD0", Offset = "0x83A4AD0", VA = "0x1883A5CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler JQDANAPLEWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83A5E30", Offset = "0x83A4C30", VA = "0x1883A5E30", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83A5DE0", Offset = "0x83A4BE0", VA = "0x1883A5DE0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler YSENBZWKDFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x83A4F90", Offset = "0x83A3D90", VA = "0x1883A4F90", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x83A4640", Offset = "0x83A3440", VA = "0x1883A4640", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler IMLMTCJCVEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x83A5E80", Offset = "0x83A4C80", VA = "0x1883A5E80", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x83A56A0", Offset = "0x83A44A0", VA = "0x1883A56A0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler VBZWBTUHNUP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83A5A50", Offset = "0x83A4850", VA = "0x1883A5A50", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x83A5AF0", Offset = "0x83A48F0", VA = "0x1883A5AF0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83A5F60", Offset = "0x83A4D60", VA = "0x1883A5F60")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, YPKBJZDMDVE connectableTool, LFCMTNFDAIQ[] connectionPoints, QHWEAZMFLEW callbacks, YVWWJBXBUTR connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x83A4610", Offset = "0x83A3410", VA = "0x1883A4610", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "21")]
		public void RFDVXMCWQAZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x808F790", Offset = "0x808E590", VA = "0x18808F790", Slot = "22")]
		public void KMVYCKFMAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83A5C80", Offset = "0x83A4A80", VA = "0x1883A5C80", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x83A47D0", Offset = "0x83A35D0", VA = "0x1883A47D0", Slot = "25")]
		public void FQQQJJZODNN(int a, FPCMEBGKSIQ b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83A5BB0", Offset = "0x83A49B0", VA = "0x1883A5BB0", Slot = "26")]
		public void SBEXEIOSCPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83A49E0", Offset = "0x83A37E0", VA = "0x1883A49E0", Slot = "27")]
		public void GOECTUDOZPH(int a, FPCMEBGKSIQ b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83A4EC0", Offset = "0x83A3CC0", VA = "0x1883A4EC0", Slot = "28")]
		public void HNQWDDQXXYD(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83A5040", Offset = "0x83A3E40", VA = "0x1883A5040", Slot = "31")]
		public void KXGTXEHYSBC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83A5740", Offset = "0x83A4540", VA = "0x1883A5740", Slot = "29")]
		public void RBNTKCQQSVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83A54B0", Offset = "0x83A42B0", VA = "0x1883A54B0", Slot = "30")]
		public void OBNYMKANZVX(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x83A4DF0", Offset = "0x83A3BF0", VA = "0x1883A4DF0", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83A4CC0", Offset = "0x83A3AC0", VA = "0x1883A4CC0", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB635A0", Offset = "0xB623A0", VA = "0x180B635A0", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83A4700", Offset = "0x83A3500", VA = "0x1883A4700", Slot = "43")]
		public bool CanConnectTo(int slotIndex, FPCMEBGKSIQ otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "44")]
		public void ParentChanged(int slotIndex, FPCMEBGKSIQ newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "45")]
		public void ChildAdded(int slotIndex, FPCMEBGKSIQ newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "46")]
		public void ChildRemoved(int slotIndex, FPCMEBGKSIQ removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "47")]
		public void ConnectionModified(int slotIndex, FPCMEBGKSIQ parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83A5B90", Offset = "0x83A4990", VA = "0x1883A5B90", Slot = "48")]
		public void RootChanged(FPCMEBGKSIQ previousRootConnectable, FPCMEBGKSIQ newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83A4F40", Offset = "0x83A3D40", VA = "0x1883A4F40", Slot = "23")]
		public void IVABZJONHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83A56F0", Offset = "0x83A44F0", VA = "0x1883A56F0", Slot = "24")]
		public void RACHQWQNSXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83A45C0", Offset = "0x83A33C0", VA = "0x1883A45C0")]
		private void AIFXFPFSDZO(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(STDXAFQPJAJ), new string[] { })]
	public class BXXNYDHVDUW : STDXAFQPJAJ, OQVTAWVSILE, CKMVDEYKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OPUURPABOAR
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OPUURPABOAR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private TEACRQSWHNH CHVUAIGFBDA;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object FBECGMIFZFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8393220", Offset = "0x8392020", VA = "0x188393220", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83932B0", Offset = "0x83920B0", VA = "0x1883932B0", Slot = "5")]
		private void VROTAZPKECM(YKMTYEBAAOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xFCB1A0", Offset = "0xFC9FA0", VA = "0x180FCB1A0", Slot = "6")]
		private void WEWODNDDDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public BXXNYDHVDUW()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(YVWWJBXBUTR), new string[] { "Ignore", "Mock" })]
	public class ZNDZWZMUSJC : YVWWJBXBUTR, BQLXQKHZRWO
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ONCGHIYWMTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool TFVGRHRNULI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FPCMEBGKSIQ, FPCMEBGKSIQ> AJJJFCJHBUP
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x83A76F0", Offset = "0x83A64F0", VA = "0x1883A76F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x83A7850", Offset = "0x83A6650", VA = "0x1883A7850", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FPCMEBGKSIQ, FPCMEBGKSIQ> ZPPQZVASSMN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x83A79B0", Offset = "0x83A67B0", VA = "0x1883A79B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x83A7640", Offset = "0x83A6440", VA = "0x1883A7640", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FPCMEBGKSIQ, FPCMEBGKSIQ, FPCMEBGKSIQ> TTEYLUIRVAT
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x83A7900", Offset = "0x83A6700", VA = "0x1883A7900", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x83A77A0", Offset = "0x83A65A0", VA = "0x1883A77A0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "26")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "12")]
		public void Initialize(GameObject gameObject, QJGEPBBULES configData, DXWATESPAZD rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "14")]
		public void IPFDCTVTWHM(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "15")]
		public void VKYFMNNRBOB(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "16")]
		public void ZYADFDVXSGK(FPCMEBGKSIQ a, HashSet<FPCMEBGKSIQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "17")]
		public void BWJBSIZWVOY(FPCMEBGKSIQ a, FPCMEBGKSIQ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "18")]
		public void XDLGDZZKBNK(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "19")]
		public void GUWOJGYXCSG(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "20")]
		public ConnectableGraphData KDDFQBIHRCH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "21")]
		public ConnectableGraphData AOQQTGOGZYZ(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "22")]
		public bool DRWBEIMOZLB(BVCOGACJCKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "23")]
		public void MPGAEIVZACA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "24")]
		public void MEDMCWDMVZE(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "25")]
		public void VYTEYQLUGPF(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ZNDZWZMUSJC()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FPCMEBGKSIQ : SPQRRUGRPAZ, IEquatable<FPCMEBGKSIQ>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface SPQRRUGRPAZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		FPCMEBGKSIQ ParentConnectable
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
		bool CanConnectTo(int slotIndex, FPCMEBGKSIQ otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, FPCMEBGKSIQ newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, FPCMEBGKSIQ newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, FPCMEBGKSIQ removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, FPCMEBGKSIQ parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(FPCMEBGKSIQ previousRootConnectable, FPCMEBGKSIQ newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface YVWWJBXBUTR : BQLXQKHZRWO
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool ONCGHIYWMTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool TFVGRHRNULI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<FPCMEBGKSIQ, FPCMEBGKSIQ> AJJJFCJHBUP;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<FPCMEBGKSIQ, FPCMEBGKSIQ> ZPPQZVASSMN;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<FPCMEBGKSIQ, FPCMEBGKSIQ, FPCMEBGKSIQ> TTEYLUIRVAT;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, QJGEPBBULES configData, DXWATESPAZD rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void IPFDCTVTWHM(FPCMEBGKSIQ a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void VKYFMNNRBOB(FPCMEBGKSIQ a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ZYADFDVXSGK(FPCMEBGKSIQ a, HashSet<FPCMEBGKSIQ> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void BWJBSIZWVOY(FPCMEBGKSIQ a, FPCMEBGKSIQ b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void XDLGDZZKBNK(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GUWOJGYXCSG(FPCMEBGKSIQ a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData KDDFQBIHRCH(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData AOQQTGOGZYZ(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool DRWBEIMOZLB(BVCOGACJCKD a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void MPGAEIVZACA(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void MEDMCWDMVZE(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void VYTEYQLUGPF(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface QGYZCYYJEAR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FPCMEBGKSIQ GONRBMRSDED(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FPCMEBGKSIQ KSVMBPHGTWW(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool BOOKUNULTQK(FPCMEBGKSIQ a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool DEIRIGAIWXA();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VQKLUTELGER(FPCMEBGKSIQ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface QHWEAZMFLEW
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool RYOBENBYJUC(YPKBJZDMDVE a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PHGXMWWQBQH(YPKBJZDMDVE a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string BRGTAFAEAMK(YPKBJZDMDVE a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid EPCTNNFODIN(YPKBJZDMDVE a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int CTXQBPNHTJI(YPKBJZDMDVE a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PSJPMBLMQEV(YPKBJZDMDVE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(FPCMEBGKSIQ childConnectable, int childConnectableSlot, FPCMEBGKSIQ parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(FPCMEBGKSIQ previousRootConnectable, FPCMEBGKSIQ newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface YPKBJZDMDVE : FPCMEBGKSIQ, SPQRRUGRPAZ, IEquatable<FPCMEBGKSIQ>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface QPIGTMYNGXK : SPQRRUGRPAZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		FPCMEBGKSIQ LVQKJTBKSJR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<FPCMEBGKSIQ> LESUKUDITTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 FACELJYNWBT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion AKSMHZFBQCU
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool CNTNHRHEWPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool HOJWDFKBQCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler JQDANAPLEWF;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler YSENBZWKDFB;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler IMLMTCJCVEA;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler VBZWBTUHNUP;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void RFDVXMCWQAZ();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void KMVYCKFMAGC();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void IVABZJONHBF();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void RACHQWQNSXW();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void FQQQJJZODNN(int a, FPCMEBGKSIQ b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SBEXEIOSCPB();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void GOECTUDOZPH(int a, FPCMEBGKSIQ b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void HNQWDDQXXYD(FPCMEBGKSIQ a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void RBNTKCQQSVM();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void OBNYMKANZVX(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void KXGTXEHYSBC(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface LFCMTNFDAIQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 NLAVADJJSZV
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
	public interface QJGEPBBULES
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool BTVZUSOQUAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		URDEPFTEGWZ TIUWKZBALZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, QJGEPBBULES
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
		public bool BTVZUSOQUAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB869E0", VA = "0x180B87BE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public URDEPFTEGWZ TIUWKZBALZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83940F0", Offset = "0x8392EF0", VA = "0x1883940F0")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x83941B0", Offset = "0x8392FB0", VA = "0x1883941B0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FPCMEBGKSIQ connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x83946F0", Offset = "0x83934F0", VA = "0x1883946F0")]
		public ConnectableLink(FPCMEBGKSIQ connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8394750", Offset = "0x8393550", VA = "0x188394750")]
		public ConnectableLink(FPCMEBGKSIQ connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8394660", Offset = "0x8393460", VA = "0x188394660")]
		public ConnectableLink(FPCMEBGKSIQ connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8394200", Offset = "0x8393000", VA = "0x188394200", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x83942B0", Offset = "0x83930B0", VA = "0x1883942B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : SXVHLOHVRJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform QWGFNDFIQDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private URDEPFTEGWZ RASNJYENNCZ;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7D10070", Offset = "0x7D0EE70", VA = "0x187D10070", Slot = "4")]
		public void Initialize(Transform transform, URDEPFTEGWZ linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8395790", Offset = "0x8394590", VA = "0x188395790", Slot = "5")]
		public URDEPFTEGWZ SDXSVFIIQHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8395720", Offset = "0x8394520", VA = "0x188395720", Slot = "6")]
		public void RXKHFSAVHWD(URDEPFTEGWZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, DFWKLHPEOTJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class VLCVATRSNWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public FPCMEBGKSIQ ZSALQFPPRDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public FPCMEBGKSIQ HFOYLJSJKEL;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public VLCVATRSNWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83A71D0", Offset = "0x83A5FD0", VA = "0x1883A71D0")]
			internal bool WBLDANZBJBX(YDVUSFSKTAA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly CJHZMZIOAVL NUBWHKYCKNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private MGERSWCCDCQ ZLLPMBJIKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private RHAYXFHPOVO OLBRAKJUVZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool LNQNVGLJLJC;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log LZORISTEMRY;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public YDVUSFSKTAA RDIQMDZZHYP
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8397650", Offset = "0x8396450", VA = "0x188397650")]
		public bool PULHMPMTGBG([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8397E80", Offset = "0x8396C80", VA = "0x188397E80")]
		private bool VTDJKULXFEP([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8399430", Offset = "0x8398230", VA = "0x188399430")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8396CB0", Offset = "0x8395AB0", VA = "0x188396CB0", Slot = "5")]
		public void Initialize(YVWWJBXBUTR manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8396B20", Offset = "0x8395920", VA = "0x188396B20", Slot = "17")]
		public void IBGTHMAQCQF(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8397A10", Offset = "0x8396810", VA = "0x188397A10", Slot = "12")]
		public void TQXYTJSVSYQ(Func<FPCMEBGKSIQ, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8397A20", Offset = "0x8396820", VA = "0x188397A20")]
		private void TQXYTJSVSYQ(CJHZMZIOAVL a, Func<FPCMEBGKSIQ, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8397670", Offset = "0x8396470", VA = "0x188397670", Slot = "11")]
		public void NGPQTKJSSAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8397660", Offset = "0x8396460", VA = "0x188397660", Slot = "8")]
		public bool NDSVCZBEHTD(FPCMEBGKSIQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x83986E0", Offset = "0x83974E0", VA = "0x1883986E0")]
		private bool ZCLXKWXTJXE(FPCMEBGKSIQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8397730", Offset = "0x8396530", VA = "0x188397730")]
		private static bool PQBAPXFUMIA(FPCMEBGKSIQ a, CJHZMZIOAVL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x83961B0", Offset = "0x8394FB0", VA = "0x1883961B0")]
		private void ANAELKGWYRM(Transform a, CJHZMZIOAVL b, CJHZMZIOAVL[] c, FPCMEBGKSIQ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8396060", Offset = "0x8394E60", VA = "0x188396060")]
		private ConnectableLink ABMPIMWBYDF(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8396960", Offset = "0x8395760", VA = "0x188396960")]
		private static bool CCDEBRHDHTY(CJHZMZIOAVL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83975F0", Offset = "0x83963F0", VA = "0x1883975F0", Slot = "9")]
		public bool KUEBHGKBMDX(FPCMEBGKSIQ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8397B50", Offset = "0x8396950", VA = "0x188397B50")]
		private bool TUFLEVJOHBU(FPCMEBGKSIQ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8396D60", Offset = "0x8395B60", VA = "0x188396D60")]
		private static void JWRVTCKPLPH(FPCMEBGKSIQ a, int b, int c, Vector3 d, Quaternion e, CJHZMZIOAVL f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83977E0", Offset = "0x83965E0", VA = "0x1883977E0")]
		private void QMMCNQYMEDI(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8397DA0", Offset = "0x8396BA0", VA = "0x188397DA0")]
		private void VRPMODCDFKC(CJHZMZIOAVL a, FPCMEBGKSIQ b, FPCMEBGKSIQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8397E10", Offset = "0x8396C10", VA = "0x188397E10")]
		private void VRPMODCDFKC(FPCMEBGKSIQ a, FPCMEBGKSIQ b, FPCMEBGKSIQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8398670", Offset = "0x8397470", VA = "0x188398670")]
		private void XUFUPHKDTXN(FPCMEBGKSIQ a, FPCMEBGKSIQ b, FPCMEBGKSIQ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8398570", Offset = "0x8397370", VA = "0x188398570")]
		private void XUFUPHKDTXN(CJHZMZIOAVL a, FPCMEBGKSIQ b, FPCMEBGKSIQ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8396840", Offset = "0x8395640", VA = "0x188396840")]
		private void BRSQTYSABGS(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8396B50", Offset = "0x8395950", VA = "0x188396B50")]
		private void IRRKOGAVBFG(YDVUSFSKTAA a, YDVUSFSKTAA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8396EE0", Offset = "0x8395CE0", VA = "0x188396EE0", Slot = "18")]
		public FPCMEBGKSIQ JWVBVQLVRFX(FPCMEBGKSIQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8398FC0", Offset = "0x8397DC0", VA = "0x188398FC0", Slot = "13")]
		public void ZYADFDVXSGK(FPCMEBGKSIQ a, HashSet<FPCMEBGKSIQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8396600", Offset = "0x8395400", VA = "0x188396600", Slot = "14")]
		public List<FPCMEBGKSIQ> AYWBZFQSRMS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8398EF0", Offset = "0x8397CF0", VA = "0x188398EF0")]
		protected YDVUSFSKTAA ZGPUKTBMGVT(YDVUSFSKTAA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8397690", Offset = "0x8396490", VA = "0x188397690")]
		protected CJHZMZIOAVL[] NUMCUSDEATY(CJHZMZIOAVL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8398DE0", Offset = "0x8397BE0", VA = "0x188398DE0")]
		protected bool ZCZZACIAOML(FPCMEBGKSIQ a, [Out] CJHZMZIOAVL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8398440", Offset = "0x8397240", VA = "0x188398440", Slot = "15")]
		public bool XCPSPNJIZRB(FPCMEBGKSIQ a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8397900", Offset = "0x8396700", VA = "0x188397900")]
		protected CJHZMZIOAVL RQDLIYINNCA(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x83965A0", Offset = "0x83953A0", VA = "0x1883965A0", Slot = "10")]
		public bool AYIZDYLSJGT(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8397040", Offset = "0x8395E40", VA = "0x188397040")]
		private bool KKTQBNAGFFA(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8397940", Offset = "0x8396740", VA = "0x188397940")]
		private static bool SCLKVMVNIGM(CJHZMZIOAVL a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8397650", Offset = "0x8396450", VA = "0x188397650", Slot = "7")]
		private bool LFEIWYYOBJT([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : YVWWJBXBUTR, BQLXQKHZRWO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly MQNVASDZCUX container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly RHAYXFHPOVO OLBRAKJUVZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly KFOAEXDZAUV DUIJATOQKMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly MSXFXETRRHR WDHORCMUDUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly DFWKLHPEOTJ VTJVKXSEFWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal WAXCMMZEZYA OKJTSMVEIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal LBIDARLVLHJ STXRZHKCANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal MGERSWCCDCQ BIIMHLWLTXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool LNQNVGLJLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool OZZCFQUNFVX;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UXNLGHWOHOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAE9F40", Offset = "0xAE8D40", VA = "0x180AE9F40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAE99E0", Offset = "0xAE87E0", VA = "0x180AE99E0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ONCGHIYWMTS
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xB9FA10", Offset = "0xB9E810", VA = "0x180B9FA10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xB9FA50", Offset = "0xB9E850", VA = "0x180B9FA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool TFVGRHRNULI
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<FPCMEBGKSIQ, FPCMEBGKSIQ> AJJJFCJHBUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x839A430", Offset = "0x8399230", VA = "0x18839A430", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x839A780", Offset = "0x8399580", VA = "0x18839A780", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<FPCMEBGKSIQ, FPCMEBGKSIQ> ZPPQZVASSMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x839B140", Offset = "0x8399F40", VA = "0x18839B140", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x83997E0", Offset = "0x83985E0", VA = "0x1883997E0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<FPCMEBGKSIQ, FPCMEBGKSIQ, FPCMEBGKSIQ> TTEYLUIRVAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x839A9F0", Offset = "0x83997F0", VA = "0x18839A9F0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x839A490", Offset = "0x8399290", VA = "0x18839A490", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x839B2A0", Offset = "0x839A0A0", VA = "0x18839B2A0")]
		public LegacyConnectableManager(MQNVASDZCUX container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8399E70", Offset = "0x8398C70", VA = "0x188399E70", Slot = "12")]
		public void Initialize(GameObject gameObject, QJGEPBBULES configData, DXWATESPAZD rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x839A920", Offset = "0x8399720", VA = "0x18839A920", Slot = "26")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x839ABA0", Offset = "0x83999A0", VA = "0x18839ABA0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8399E50", Offset = "0x8398C50", VA = "0x188399E50", Slot = "14")]
		public void IPFDCTVTWHM(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x83995E0", Offset = "0x83983E0", VA = "0x1883995E0", Slot = "15")]
		public void VKYFMNNRBOB(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8399A50", Offset = "0x8398850", VA = "0x188399A50", Slot = "22")]
		public bool DRWBEIMOZLB(BVCOGACJCKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x839A670", Offset = "0x8399470", VA = "0x18839A670")]
		internal bool KKTQBNAGFFA([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x839AA50", Offset = "0x8399850", VA = "0x18839AA50")]
		internal bool SRPZVYHZPIU([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8399C70", Offset = "0x8398A70", VA = "0x188399C70")]
		internal void HQQMOETMQEM(FPCMEBGKSIQ a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x83995E0", Offset = "0x83983E0", VA = "0x1883995E0")]
		internal bool AKDBROFGSYO(FPCMEBGKSIQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x839ADA0", Offset = "0x8399BA0", VA = "0x18839ADA0")]
		internal bool XTGRHALKOPS(FPCMEBGKSIQ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x839B1A0", Offset = "0x8399FA0", VA = "0x18839B1A0", Slot = "16")]
		public void ZYADFDVXSGK(FPCMEBGKSIQ a, HashSet<FPCMEBGKSIQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8399840", Offset = "0x8398640", VA = "0x188399840", Slot = "17")]
		public void BWJBSIZWVOY(FPCMEBGKSIQ a, FPCMEBGKSIQ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x839AC60", Offset = "0x8399A60", VA = "0x18839AC60", Slot = "18")]
		public void XDLGDZZKBNK(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8399AA0", Offset = "0x83988A0", VA = "0x188399AA0", Slot = "19")]
		public void GUWOJGYXCSG(FPCMEBGKSIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x839AEE0", Offset = "0x8399CE0", VA = "0x18839AEE0")]
		public void YCABBAFENNV([Optional] LZEYQUPSRUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x839A890", Offset = "0x8399690", VA = "0x18839A890", Slot = "23")]
		public void MPGAEIVZACA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x839A4F0", Offset = "0x83992F0", VA = "0x18839A4F0", Slot = "20")]
		public ConnectableGraphData KDDFQBIHRCH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8399640", Offset = "0x8398440", VA = "0x188399640", Slot = "21")]
		public ConnectableGraphData AOQQTGOGZYZ(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x839AC20", Offset = "0x8399A20", VA = "0x18839AC20", Slot = "25")]
		public void VYTEYQLUGPF(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x839A7E0", Offset = "0x83995E0", VA = "0x18839A7E0", Slot = "24")]
		public void MEDMCWDMVZE(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class RHAYXFHPOVO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly YVUVPZTVRQB<FPCMEBGKSIQ, FPCMEBGKSIQ> AJJJFCJHBUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly YVUVPZTVRQB<FPCMEBGKSIQ, FPCMEBGKSIQ> ZPPQZVASSMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly YVPOSSZYIES<FPCMEBGKSIQ, FPCMEBGKSIQ, FPCMEBGKSIQ> TTEYLUIRVAT;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x83A64C0", Offset = "0x83A52C0", VA = "0x1883A64C0")]
		public RHAYXFHPOVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x83A63E0", Offset = "0x83A51E0", VA = "0x1883A63E0")]
		public void LXCBTYKWHHJ(FPCMEBGKSIQ a, FPCMEBGKSIQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x83A6380", Offset = "0x83A5180", VA = "0x1883A6380")]
		public void LEKJPLRYEVD(FPCMEBGKSIQ a, FPCMEBGKSIQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83A6440", Offset = "0x83A5240", VA = "0x1883A6440")]
		public void RVGHHXZTOCD(FPCMEBGKSIQ a, FPCMEBGKSIQ b, FPCMEBGKSIQ c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class KFOAEXDZAUV : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager OSORFJKYMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private LBIDARLVLHJ STXRZHKCANP;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KFOAEXDZAUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8395440", Offset = "0x8394240", VA = "0x188395440")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8395430", Offset = "0x8394230", VA = "0x188395430", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x83955E0", Offset = "0x83943E0", VA = "0x1883955E0")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8395570", Offset = "0x8394370", VA = "0x188395570")]
		private void OnMasterClientSwitched(LZEYQUPSRUQ newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8395620", Offset = "0x8394420", VA = "0x188395620")]
		public void WVSSGDIZVNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8395330", Offset = "0x8394130", VA = "0x188395330")]
		public void BBKAMSJVCIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class CDKXIOPTZVD
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WRYJXOISUHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public MQNVASDZCUX container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WRYJXOISUHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x83A75E0", Offset = "0x83A63E0", VA = "0x1883A75E0")]
			internal LegacyConnectableManager PEBRWCNHKNC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x83933F0", Offset = "0x83921F0", VA = "0x1883933F0")]
		public static void QYWJTJFIHZC(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8393370", Offset = "0x8392170", VA = "0x188393370")]
		public static void LAIRQVXPGSX(MQNVASDZCUX a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, MGERSWCCDCQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, URDEPFTEGWZ> BGHZJKLFJGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation WDCKODVHFZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SXVHLOHVRJJ TBDQUCDPOTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private DFWKLHPEOTJ VTJVKXSEFWN;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker KZNSXOVVQGT;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x839C290", Offset = "0x839B090", VA = "0x18839C290")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x839BAF0", Offset = "0x839A8F0", VA = "0x18839BAF0", Slot = "7")]
		public void Initialize(DFWKLHPEOTJ graph, SXVHLOHVRJJ creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x839BE30", Offset = "0x839AC30", VA = "0x18839BE30", Slot = "5")]
		public void WIJWOMREVHS(YDVUSFSKTAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x839B980", Offset = "0x839A780", VA = "0x18839B980", Slot = "9")]
		public void HCUPLBUEWYD(YDVUSFSKTAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x839C070", Offset = "0x839AE70", VA = "0x18839C070", Slot = "8")]
		public void ZGHMYWPKTWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x839B630", Offset = "0x839A430", VA = "0x18839B630", Slot = "10")]
		public void CHRMFZANXOY(YDVUSFSKTAA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x839BB30", Offset = "0x839A930", VA = "0x18839BB30", Slot = "11")]
		public void NIDPVCVWGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x839BC80", Offset = "0x839AA80", VA = "0x18839BC80")]
		private bool QIZBGUGBJTB(YDVUSFSKTAA a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class MSXFXETRRHR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly CJHZMZIOAVL currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly BVCOGACJCKD parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly BVCOGACJCKD rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool CHTSVTDYJVG
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x83A6E40", Offset = "0x83A5C40", VA = "0x1883A6E40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x83A6F60", Offset = "0x83A5D60", VA = "0x1883A6F60")]
			public SerializeNodeInSubgraph(CJHZMZIOAVL currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] BVCOGACJCKD parentNodeData, [Optional] BVCOGACJCKD rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x83A69E0", Offset = "0x83A57E0", VA = "0x1883A69E0")]
			public BVCOGACJCKD HPFTFJWMZQX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x83A6D80", Offset = "0x83A5B80", VA = "0x1883A6D80")]
			private BVCOGACJCKD UNMXJQRKGID([Out] BVCOGACJCKD a, [Out] BVCOGACJCKD b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x83A6B80", Offset = "0x83A5980", VA = "0x1883A6B80")]
			private BVCOGACJCKD RWPJZQFCGTX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x83A66B0", Offset = "0x83A54B0", VA = "0x1883A66B0")]
			private void CRBGMSBXSTB(BVCOGACJCKD a, BVCOGACJCKD b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x83A6820", Offset = "0x83A5620", VA = "0x1883A6820")]
			private void CVRGNNVCCTO(BVCOGACJCKD a, BVCOGACJCKD b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager OSORFJKYMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private DFWKLHPEOTJ VTJVKXSEFWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private MGERSWCCDCQ ZLLPMBJIKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private LBIDARLVLHJ STXRZHKCANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool PQGDVODTWXJ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool WMCUGOWMDKE
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x839E6E0", Offset = "0x839D4E0", VA = "0x18839E6E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool UXNLGHWOHOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x839D9C0", Offset = "0x839C7C0", VA = "0x18839D9C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x839E960", Offset = "0x839D760", VA = "0x18839E960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x839D310", Offset = "0x839C110", VA = "0x18839D310")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x839D380", Offset = "0x839C180", VA = "0x18839D380")]
		public ConnectableGraphData KDDFQBIHRCH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x839C4F0", Offset = "0x839B2F0", VA = "0x18839C4F0")]
		public ConnectableGraphData AOQQTGOGZYZ(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x839DA80", Offset = "0x839C880", VA = "0x18839DA80")]
		public void MPGAEIVZACA(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x839D9E0", Offset = "0x839C7E0", VA = "0x18839D9E0")]
		public void MEDMCWDMVZE(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x839D2E0", Offset = "0x839C0E0", VA = "0x18839D2E0")]
		public void IYAPMKFTNHK(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x839E9A0", Offset = "0x839D7A0", VA = "0x18839E9A0")]
		private void YRORAUTVEXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x839E730", Offset = "0x839D530", VA = "0x18839E730")]
		private BVCOGACJCKD TEJWTCWXLVF(CJHZMZIOAVL a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x839D090", Offset = "0x839BE90", VA = "0x18839D090")]
		private static void IDEEVMFJNDZ(CJHZMZIOAVL a, bool b, BVCOGACJCKD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x839CE70", Offset = "0x839BC70", VA = "0x18839CE70")]
		private void HWQYBSDJDKI(CJHZMZIOAVL a, bool b, BVCOGACJCKD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x839DC00", Offset = "0x839CA00", VA = "0x18839DC00")]
		private BVCOGACJCKD PTRFRKEXNVL(CJHZMZIOAVL a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x839E2F0", Offset = "0x839D0F0", VA = "0x18839E2F0")]
		private bool QYXYTDHZXWF(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x839DC90", Offset = "0x839CA90", VA = "0x18839DC90")]
		private bool PYYEWHJLQPW(BVCOGACJCKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x839E980", Offset = "0x839D780", VA = "0x18839E980")]
		private bool WGIBRNWDZXQ(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x839E5C0", Offset = "0x839D3C0", VA = "0x18839E5C0")]
		private static bool SIQCICQNALR(BVCOGACJCKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x839CA70", Offset = "0x839B870", VA = "0x18839CA70")]
		public static bool DRWBEIMOZLB(BVCOGACJCKD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x839D680", Offset = "0x839C480", VA = "0x18839D680")]
		private FPCMEBGKSIQ LFBKZTZAEIN(BVCOGACJCKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x839CD00", Offset = "0x839BB00", VA = "0x18839CD00")]
		private FPCMEBGKSIQ GONRBMRSDED(BVCOGACJCKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x839D4F0", Offset = "0x839C2F0", VA = "0x18839D4F0")]
		private FPCMEBGKSIQ KQDAJPFJWBM(BVCOGACJCKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x839E580", Offset = "0x839D380", VA = "0x18839E580")]
		private static Guid RLOPYFISBRC(BVCOGACJCKD a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x839DB10", Offset = "0x839C910", VA = "0x18839DB10")]
		private string OIKEQXTRODX(BVCOGACJCKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x839C690", Offset = "0x839B490", VA = "0x18839C690")]
		private bool CRHLRYGOSWE(CJHZMZIOAVL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x839C820", Offset = "0x839B620", VA = "0x18839C820")]
		private static void DEMBETCBQHA(CJHZMZIOAVL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public MSXFXETRRHR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public FPCMEBGKSIQ child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FPCMEBGKSIQ parent;

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
		public ConnectableLink QCZFMLJYJSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8394820", Offset = "0x8393620", VA = "0x188394820")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink MLHDVOMJSML
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x83947F0", Offset = "0x83935F0", VA = "0x1883947F0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x83948C0", Offset = "0x83936C0", VA = "0x1883948C0")]
		public ConnectionOperationData(FPCMEBGKSIQ child, FPCMEBGKSIQ parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface DFWKLHPEOTJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		YDVUSFSKTAA RDIQMDZZHYP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(YVWWJBXBUTR manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PULHMPMTGBG([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NDSVCZBEHTD(FPCMEBGKSIQ a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KUEBHGKBMDX(FPCMEBGKSIQ a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool AYIZDYLSJGT(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NGPQTKJSSAI();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void TQXYTJSVSYQ(Func<FPCMEBGKSIQ, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ZYADFDVXSGK(FPCMEBGKSIQ a, HashSet<FPCMEBGKSIQ> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<FPCMEBGKSIQ> AYWBZFQSRMS();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool XCPSPNJIZRB(FPCMEBGKSIQ a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void IBGTHMAQCQF(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(YDVUSFSKTAA node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface YDVUSFSKTAA
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		FPCMEBGKSIQ IHJXEWVFFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		YDVUSFSKTAA XDBWOZDWTUL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink LUODQOQUKTN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool GUKPFXGHQZN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface URDEPFTEGWZ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YXKPQQSUPQN(FPCMEBGKSIQ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FZFJMUKJSJD(FPCMEBGKSIQ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CSZXFQGCPAS(FPCMEBGKSIQ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VYSIMNOCOKK(FPCMEBGKSIQ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		URDEPFTEGWZ THNECBCXJEB(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface SXVHLOHVRJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, URDEPFTEGWZ linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		URDEPFTEGWZ SDXSVFIIQHF();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RXKHFSAVHWD(URDEPFTEGWZ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface WAXCMMZEZYA : QGYZCYYJEAR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZPSJLRZOQYK();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MZLOOSNLSWD(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface MGERSWCCDCQ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WIJWOMREVHS(YDVUSFSKTAA a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(DFWKLHPEOTJ graph, SXVHLOHVRJJ linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZGHMYWPKTWB();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HCUPLBUEWYD(YDVUSFSKTAA a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CHRMFZANXOY(YDVUSFSKTAA a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NIDPVCVWGHK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class CJHZMZIOAVL : YDVUSFSKTAA
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class GLBQGGTYYEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink ZPBMXVRYWVU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CJHZMZIOAVL BNCFYLRMDDP;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public GLBQGGTYYEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8394930", Offset = "0x8393730", VA = "0x188394930")]
			internal bool DDRQXRNTVQM(YDVUSFSKTAA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink POTIIZXUGZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<CJHZMZIOAVL> GMWEVQQOKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private CJHZMZIOAVL BGKBNVAPFBK;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink LUODQOQUKTN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x15BEBA0", Offset = "0x15BD9A0", VA = "0x1815BEBA0", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x15BDF00", Offset = "0x15BCD00", VA = "0x1815BDF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private CJHZMZIOAVL TNQRTSDCHDV
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8393DF0", Offset = "0x8392BF0", VA = "0x188393DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public YDVUSFSKTAA XDBWOZDWTUL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public FPCMEBGKSIQ IHJXEWVFFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool GUKPFXGHQZN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8393A40", Offset = "0x8392840", VA = "0x188393A40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool BQBISUENIBF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8393880", Offset = "0x8392680", VA = "0x188393880", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected CJHZMZIOAVL DSTQIKJKEHN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8393A50", Offset = "0x8392850", VA = "0x188393A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8394050", Offset = "0x8392E50", VA = "0x188394050")]
		public CJHZMZIOAVL(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x83935F0", Offset = "0x83923F0", VA = "0x1883935F0")]
		public CJHZMZIOAVL BPHNXWVYNEE(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8393ED0", Offset = "0x8392CD0", VA = "0x188393ED0")]
		public CJHZMZIOAVL ZJJICUABSEU(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8393B60", Offset = "0x8392960", VA = "0x188393B60")]
		public CJHZMZIOAVL Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8393730", Offset = "0x8392530", VA = "0x188393730")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8393D40", Offset = "0x8392B40", VA = "0x188393D40")]
		public CJHZMZIOAVL Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x83938D0", Offset = "0x83926D0", VA = "0x1883938D0")]
		private static void IBGTHMAQCQF(CJHZMZIOAVL a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8393A30", Offset = "0x8392830", VA = "0x188393A30", Slot = "9")]
		public void IBGTHMAQCQF(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8393A70", Offset = "0x8392870", VA = "0x188393A70")]
		public static CJHZMZIOAVL RQDLIYINNCA(CJHZMZIOAVL a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface LBIDARLVLHJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool WMCUGOWMDKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> CGOFWCUEYMM;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<LZEYQUPSRUQ> GVVOLKWYSVM;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void YXKPQQSUPQN(LegacyConnectableManager a, DXWATESPAZD b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void BWJBSIZWVOY(FPCMEBGKSIQ a, FPCMEBGKSIQ b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void XDLGDZZKBNK(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UGFQUUJKNMJ(ConnectableGraphData a, [Optional] LZEYQUPSRUQ b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class SIJFWJDVCWT
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x83A6600", Offset = "0x83A5400", VA = "0x1883A6600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x83A65C0", Offset = "0x83A53C0", VA = "0x1883A65C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x83A6650", Offset = "0x83A5450", VA = "0x1883A6650")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class NWWAGPZVWMQ : LBIDARLVLHJ, IDisposable, XGUODLQWBMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager OSORFJKYMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private DXWATESPAZD JHHJKDJHBXH;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool WMCUGOWMDKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x839F5F0", Offset = "0x839E3F0", VA = "0x18839F5F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x839F650", Offset = "0x839E450", VA = "0x18839F650", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView AFDCBUJWASD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x839F850", Offset = "0x839E650", VA = "0x18839F850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> CGOFWCUEYMM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x839ED60", Offset = "0x839DB60", VA = "0x18839ED60", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x839F7B0", Offset = "0x839E5B0", VA = "0x18839F7B0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<LZEYQUPSRUQ> GVVOLKWYSVM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x839F8F0", Offset = "0x839E6F0", VA = "0x18839F8F0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x839EE00", Offset = "0x839DC00", VA = "0x18839EE00", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x839FAB0", Offset = "0x839E8B0", VA = "0x18839FAB0", Slot = "10")]
		public void YXKPQQSUPQN(LegacyConnectableManager a, DXWATESPAZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x839ED10", Offset = "0x839DB10", VA = "0x18839ED10", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x839EBF0", Offset = "0x839D9F0", VA = "0x18839EBF0", Slot = "11")]
		public void BWJBSIZWVOY(FPCMEBGKSIQ a, FPCMEBGKSIQ b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x839F990", Offset = "0x839E790", VA = "0x18839F990", Slot = "12")]
		public void XDLGDZZKBNK(FPCMEBGKSIQ a, int b, FPCMEBGKSIQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x839F690", Offset = "0x839E490", VA = "0x18839F690", Slot = "13")]
		public void UGFQUUJKNMJ(ConnectableGraphData a, [Optional] LZEYQUPSRUQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x839F0D0", Offset = "0x839DED0", VA = "0x18839F0D0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(FPCMEBGKSIQ objectToReparent, int objectToReparentSlotIndex, FPCMEBGKSIQ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x839EEE0", Offset = "0x839DCE0", VA = "0x18839EEE0")]
		[RPCMethod]
		private void RpcMasterModifyNode(FPCMEBGKSIQ connectableToModify, FPCMEBGKSIQ expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x839F4C0", Offset = "0x839E2C0", VA = "0x18839F4C0")]
		[RPCMethod]
		private void RpcReparentNodes(FPCMEBGKSIQ objectToReparent, int objectToReparentSlotIndex, FPCMEBGKSIQ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x839F3D0", Offset = "0x839E1D0", VA = "0x18839F3D0")]
		[RPCMethod]
		private void RpcModifyNode(FPCMEBGKSIQ connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x839EEA0", Offset = "0x839DCA0", VA = "0x18839EEA0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public NWWAGPZVWMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, URDEPFTEGWZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x83959C0", Offset = "0x83947C0", VA = "0x1883959C0", Slot = "4")]
		private void AUOTDISRYMM(FPCMEBGKSIQ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8395E00", Offset = "0x8394C00", VA = "0x188395E00", Slot = "5")]
		private void UWMAEHTNRQA(FPCMEBGKSIQ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8395860", Offset = "0x8394660", VA = "0x188395860", Slot = "6")]
		private void AQSIWYWUNNX(FPCMEBGKSIQ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8395B40", Offset = "0x8394940", VA = "0x188395B40", Slot = "7")]
		private void HSNUVNMWVFB(FPCMEBGKSIQ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8395D90", Offset = "0x8394B90", VA = "0x188395D90", Slot = "8")]
		private URDEPFTEGWZ TKBKLQQJIZM(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8395D30", Offset = "0x8394B30", VA = "0x188395D30", Slot = "9")]
		private void SQXUOECJAUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class IMZPLVOOMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x395DFE0", Offset = "0x395CDE0", VA = "0x18395DFE0")]
		public static RMGRETGUCFY<a> KQZEOPINHHL<a>(this MQNVASDZCUX a)
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
