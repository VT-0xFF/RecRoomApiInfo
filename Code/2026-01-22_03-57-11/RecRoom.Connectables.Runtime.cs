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
		[Cpp2IlInjected.Address(RVA = "0x821A9B0", Offset = "0x82191B0", VA = "0x18821A9B0", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		private int[] GGRLHWHSZPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] GGMEKPNVQEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset ERVRXHKVDYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset ESAYUOESNKF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F61490", Offset = "0x1F5FC90", VA = "0x181F61490", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8226590", Offset = "0x8224D90", VA = "0x188226590")]
		private void LJCGTCDSEAS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82266E0", Offset = "0x8224EE0", VA = "0x1882266E0")]
		private void LJHNQIXPNMB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8226830", Offset = "0x8225030", VA = "0x188226830", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8226B40", Offset = "0x8225340", VA = "0x188226B40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : ZGGSCMHMZDR, LYHFQGWTPJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class VMYFGCBPLGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public KYSBUCYODST CJUKPNWZRCD;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VMYFGCBPLGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8223810", Offset = "0x8222010", VA = "0x188223810")]
			internal object MMSNTMJGLYQ(KYSBUCYODST a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class VMSYIVHSBVE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public KYSBUCYODST TZREBGJLJAX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public VMYFGCBPLGN GPYHOBUULHO;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VMSYIVHSBVE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x82235C0", Offset = "0x8221DC0", VA = "0x1882235C0")]
			internal object MMXUQTDDVJZ((KYSBUCYODST child, KYSBUCYODST nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DBEGONXCPUC : IEnumerable<JIMQUKYOEGQ>, IEnumerable, IEnumerator<JIMQUKYOEGQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private JIMQUKYOEGQ VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId ZZAPYEWPVHV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId HNGKAMXQCLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private XHGUSKZULBO GBXJERXSGWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray LJMRJHTCHNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator YLSLAXVKWGZ;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private JIMQUKYOEGQ ZMGDNCJMCDE
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
			[DebuggerHidden]
			public DBEGONXCPUC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8212BF0", Offset = "0x82113F0", VA = "0x188212BF0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8212890", Offset = "0x8211090", VA = "0x188212890", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8212CD0", Offset = "0x82114D0", VA = "0x188212CD0")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8212CF0", Offset = "0x82114F0", VA = "0x188212CF0")]
			private void YQUQFKFMWJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8212850", Offset = "0x8211050", VA = "0x188212850", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82127A0", Offset = "0x8210FA0", VA = "0x1882127A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JIMQUKYOEGQ> CPBDTDWCHPX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82127A0", Offset = "0x8210FA0", VA = "0x1882127A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log JXSFGOXIHCW;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log SULEUJVFKSQ;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log NGIGIXHPHRG;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log OXPHYIWTEVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NGWMKTCGJKH ZOLIITHTLQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FXQCVAPUBVC YPAOUVLYFVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private URAOZJJZFEB LHMDEJNLKQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BUKJFOVICGZ UBLEZUXYRFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private EKEKGMQSVJX CYMRASLKLDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TOTAHCEENDB YGJCCAJUSIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly RPZEWRQSMYA BDROIHDDEKL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ZMUGFMCKOPO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAB4110", Offset = "0xAB2910", VA = "0x180AB4110", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAB4150", Offset = "0xAB2950", VA = "0x180AB4150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool VSGHPAZZZDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<JIMQUKYOEGQ, JIMQUKYOEGQ> QIRHZDSVYRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x821BD40", Offset = "0x821A540", VA = "0x18821BD40", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x821E950", Offset = "0x821D150", VA = "0x18821E950", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<JIMQUKYOEGQ, JIMQUKYOEGQ> MYYHPKHNTYF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8220220", Offset = "0x821EA20", VA = "0x188220220", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x821BC90", Offset = "0x821A490", VA = "0x18821BC90", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<JIMQUKYOEGQ, JIMQUKYOEGQ, JIMQUKYOEGQ> DRIXOEJHKAT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x821DF10", Offset = "0x821C710", VA = "0x18821DF10", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x821EC00", Offset = "0x821D400", VA = "0x18821EC00", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8220420", Offset = "0x821EC20", VA = "0x188220420")]
		public OMConnectableManager(MUPQGBSCKZR container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x821D050", Offset = "0x821B850", VA = "0x18821D050", Slot = "12")]
		public void Initialize(GameObject gameObject, IWXRLXRLZSK configData, LHTRVBEPHKZ sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x821C720", Offset = "0x821AF20", VA = "0x18821C720", Slot = "26")]
		public void GGOPOLDMLPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x821F500", Offset = "0x821DD00", VA = "0x18821F500", Slot = "22")]
		public bool WUMYZMDJMKD(KYSBUCYODST a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x821EA00", Offset = "0x821D200", VA = "0x18821EA00")]
		private void VDDYSYXTBBK(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x821F960", Offset = "0x821E160", VA = "0x18821F960")]
		private void XLGZAOKMUIG(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x821DCB0", Offset = "0x821C4B0", VA = "0x18821DCB0")]
		private void QXQTDECLZCM(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x821FD80", Offset = "0x821E580", VA = "0x18821FD80")]
		private void ZESTOABRAZZ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x821D2C0", Offset = "0x821BAC0", VA = "0x18821D2C0", Slot = "14")]
		public void JPLRKQDWIBU(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "15")]
		public void EHINEMRFQHH(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x821DA10", Offset = "0x821C210", VA = "0x18821DA10", Slot = "17")]
		public void PWDDZAHCYNS(JIMQUKYOEGQ a, JIMQUKYOEGQ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x821DB70", Offset = "0x821C370", VA = "0x18821DB70")]
		public void PWDDZAHCYNS(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8220190", Offset = "0x821E990", VA = "0x188220190")]
		public void ZNAQMACWOQE(JIMQUKYOEGQ a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x821EDF0", Offset = "0x821D5F0", VA = "0x18821EDF0", Slot = "18")]
		public void VNTWQBHDOMM(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x821D8F0", Offset = "0x821C0F0", VA = "0x18821D8F0")]
		private float PDFMYAYHJKM(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x821ECB0", Offset = "0x821D4B0", VA = "0x18821ECB0")]
		public void VNTWQBHDOMM(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x821F200", Offset = "0x821DA00", VA = "0x18821F200", Slot = "19")]
		public void WQCNJLEAIFM(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x821BA60", Offset = "0x821A260", VA = "0x18821BA60", Slot = "16")]
		public void BBVNNUWFVXI(JIMQUKYOEGQ a, HashSet<JIMQUKYOEGQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "20")]
		public ConnectableGraphData NQJDYGYVOVJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "21")]
		public ConnectableGraphData RRIZMNRPWFH(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x821FB80", Offset = "0x821E380", VA = "0x18821FB80", Slot = "23")]
		public void YXGRVJCVLPW(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x821D9A0", Offset = "0x821C1A0", VA = "0x18821D9A0", Slot = "24")]
		public void PNWWTTYQBAS(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x821BC70", Offset = "0x821A470", VA = "0x18821BC70", Slot = "25")]
		public void BHKLQJNDBTV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x821F550", Offset = "0x821DD50", VA = "0x18821F550")]
		private void WWOREEHRUGC(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x821DFC0", Offset = "0x821C7C0", VA = "0x18821DFC0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x821BDF0", Offset = "0x821A5F0", VA = "0x18821BDF0")]
		private void DJFVSJUAMFL(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x821CE70", Offset = "0x821B670", VA = "0x18821CE70")]
		[IteratorStateMachine(typeof(DBEGONXCPUC))]
		public IEnumerable<JIMQUKYOEGQ> HVLSXNMJZIK(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x821C5F0", Offset = "0x821ADF0", VA = "0x18821C5F0")]
		internal JIMQUKYOEGQ FTNUTRISJDH(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x821C0E0", Offset = "0x821A8E0", VA = "0x18821C0E0")]
		internal ObjectLocalId FLHDOCCUOOR(JIMQUKYOEGQ a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x821C8F0", Offset = "0x821B0F0", VA = "0x18821C8F0")]
		private bool GRHXVXLPQHS(KYSBUCYODST a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x821E8F0", Offset = "0x821D0F0", VA = "0x18821E8F0")]
		private bool TRIMTOWKFPO(KYSBUCYODST a, [Out] JIMQUKYOEGQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x821C270", Offset = "0x821AA70", VA = "0x18821C270")]
		private JIMQUKYOEGQ FTNUTRISJDH(KYSBUCYODST a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x821D760", Offset = "0x821BF60", VA = "0x18821D760")]
		private JIMQUKYOEGQ NJHHRZRZXGS(KYSBUCYODST a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x821F040", Offset = "0x821D840", VA = "0x18821F040")]
		private JIMQUKYOEGQ WLXENODUICH(KYSBUCYODST a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x821CF00", Offset = "0x821B700", VA = "0x18821CF00")]
		private static Guid IDBAAFEOXKU(KYSBUCYODST a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x821EF50", Offset = "0x821D750", VA = "0x18821EF50")]
		private string WAODCXGZRCB(KYSBUCYODST a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x821FBF0", Offset = "0x821E3F0", VA = "0x18821FBF0")]
		private void YZSLQRDRWFQ(JIMQUKYOEGQ a, JIMQUKYOEGQ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x821D5D0", Offset = "0x821BDD0", VA = "0x18821D5D0")]
		private void LULPFAXYAEG(JIMQUKYOEGQ a, JIMQUKYOEGQ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x821E890", Offset = "0x821D090", VA = "0x18821E890")]
		private void TQZRKOUSVKI(JIMQUKYOEGQ a, JIMQUKYOEGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x821F370", Offset = "0x821DB70", VA = "0x18821F370")]
		private void WSHLRYUYSCN(JIMQUKYOEGQ a, JIMQUKYOEGQ b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x821CF40", Offset = "0x821B740", VA = "0x18821CF40")]
		private void IVXBVFXYVQU(ObjectLocalId a, JIMQUKYOEGQ b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x821BE60", Offset = "0x821A660", VA = "0x18821BE60")]
		private void DPHWPJGVUMT(ObjectLocalId a, JIMQUKYOEGQ b, JIMQUKYOEGQ c, JIMQUKYOEGQ d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class AZWNTDRCQNM
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class YMFUAEWSMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public MUPQGBSCKZR container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YMFUAEWSMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8226490", Offset = "0x8224C90", VA = "0x188226490")]
			internal OMConnectableManager EFHUOLYLAXK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8211DF0", Offset = "0x82105F0", VA = "0x188211DF0")]
		public static void UVOMICUKGTG(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8211DA0", Offset = "0x82105A0", VA = "0x188211DA0")]
		public static void RDPMUQUXGOD(MUPQGBSCKZR a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : YOLRCLYDTEI, LXGQPLPUVGZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx PWZFQDMMKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager XTBSRZXDWHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly OCYQKEPIFQS EXTZVYQPCCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly NBXRJFMLPKW UBLEZUXYRFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly TEIVTKWXQNK[] HPJCTDAZXLO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JIMQUKYOEGQ ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8222030", Offset = "0x8220830", VA = "0x188222030", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JIMQUKYOEGQ ATFKXGIANQD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8221A40", Offset = "0x8220240", VA = "0x188221A40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 VIVXUAHAJDX
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8221B00", Offset = "0x8220300", VA = "0x188221B00", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion SKEMZHAURAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8221580", Offset = "0x821FD80", VA = "0x188221580", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool YKDLLJXPLFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x82219D0", Offset = "0x82201D0", VA = "0x1882219D0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<JIMQUKYOEGQ> MAPBZOJRAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x82215E0", Offset = "0x821FDE0", VA = "0x1882215E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool AFPMHZXFAZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB9D590", Offset = "0xB9BD90", VA = "0x180B9D590", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xBF0AE0", Offset = "0xBEF2E0", VA = "0x180BF0AE0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8222240", Offset = "0x8220A40", VA = "0x188222240", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8221F40", Offset = "0x8220740", VA = "0x188221F40", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8221F60", Offset = "0x8220760", VA = "0x188221F60", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8222090", Offset = "0x8220890", VA = "0x188222090", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8222170", Offset = "0x8220970", VA = "0x188222170", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool OVOWUPSWSGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8221660", Offset = "0x821FE60", VA = "0x188221660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler FEBNZQNSJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8221610", Offset = "0x821FE10", VA = "0x188221610", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8220C50", Offset = "0x821F450", VA = "0x188220C50", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler CMQGRBAKDMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8220C00", Offset = "0x821F400", VA = "0x188220C00", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x82211D0", Offset = "0x821F9D0", VA = "0x1882211D0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler SNHGMRPNGZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8220F80", Offset = "0x821F780", VA = "0x188220F80", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8221530", Offset = "0x821FD30", VA = "0x188221530", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler RZBBWYMSMEX
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8221930", Offset = "0x8220130", VA = "0x188221930", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x82216B0", Offset = "0x821FEB0", VA = "0x1882216B0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8221E40", Offset = "0x8220640", VA = "0x188221E40")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, OCYQKEPIFQS connectableTool, TEIVTKWXQNK[] connectionPoints, NBXRJFMLPKW callbacks, ZGGSCMHMZDR connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82204E0", Offset = "0x821ECE0", VA = "0x1882204E0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "21")]
		public void GQKSDNWBZOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8221910", Offset = "0x8220110", VA = "0x188221910", Slot = "22")]
		public void TLMMOOVYXNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82218C0", Offset = "0x82200C0", VA = "0x1882218C0", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8221BB0", Offset = "0x82203B0", VA = "0x188221BB0", Slot = "25")]
		public void ZQZQVZOMGVF(int a, JIMQUKYOEGQ b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82217F0", Offset = "0x821FFF0", VA = "0x1882217F0", Slot = "26")]
		public void SCWNDLLXJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8220CA0", Offset = "0x821F4A0", VA = "0x188220CA0", Slot = "27")]
		public void EXVZITCVCAF(int a, JIMQUKYOEGQ b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8221750", Offset = "0x821FF50", VA = "0x188221750", Slot = "28")]
		public void RYMZENRZUQL(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8220750", Offset = "0x821EF50", VA = "0x188220750", Slot = "31")]
		public void CYLNCJWKOEY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8221220", Offset = "0x821FA20", VA = "0x188221220", Slot = "29")]
		public void HUBHGLYAGIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8220510", Offset = "0x821ED10", VA = "0x188220510", Slot = "30")]
		public void BXRRBEKNXPX(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8221100", Offset = "0x821F900", VA = "0x188221100", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8220FD0", Offset = "0x821F7D0", VA = "0x188220FD0", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB316C0", Offset = "0xB2FEC0", VA = "0x180B316C0", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8220B60", Offset = "0x821F360", VA = "0x188220B60", Slot = "43")]
		public bool CanConnectTo(int slotIndex, JIMQUKYOEGQ otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "44")]
		public void ParentChanged(int slotIndex, JIMQUKYOEGQ newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "45")]
		public void ChildAdded(int slotIndex, JIMQUKYOEGQ newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "46")]
		public void ChildRemoved(int slotIndex, JIMQUKYOEGQ removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "47")]
		public void ConnectionModified(int slotIndex, JIMQUKYOEGQ parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82217D0", Offset = "0x821FFD0", VA = "0x1882217D0", Slot = "48")]
		public void RootChanged(JIMQUKYOEGQ previousRootConnectable, JIMQUKYOEGQ newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8220490", Offset = "0x821EC90", VA = "0x188220490", Slot = "23")]
		public void AJKLETBUAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8221B60", Offset = "0x8220360", VA = "0x188221B60", Slot = "24")]
		public void ZGXKVCEWZMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8220700", Offset = "0x821EF00", VA = "0x188220700")]
		private void CKXUGDQTQYQ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(BMPJRQWHYSV), new string[] { })]
	public class WUETHCBOJRI : BMPJRQWHYSV, WVKCUFPJZYK, KKGEYMKPCBE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OVYXGTZWSNL
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OVYXGTZWSNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private EVZBZMJANDX AKEQLRUADZQ;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object OAMHNEYVYRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8223CC0", Offset = "0x82224C0", VA = "0x188223CC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8223C70", Offset = "0x8222470", VA = "0x188223C70", Slot = "5")]
		private void DFEIFKWLVLC(MZUBMRWQSAC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xCC4790", Offset = "0xCC2F90", VA = "0x180CC4790", Slot = "6")]
		private void WDBEGWLPSKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public WUETHCBOJRI()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(ZGGSCMHMZDR), new string[] { "Ignore", "Mock" })]
	public class POLBZYLLLWY : ZGGSCMHMZDR, LYHFQGWTPJE
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ZMUGFMCKOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool VSGHPAZZZDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<JIMQUKYOEGQ, JIMQUKYOEGQ> QIRHZDSVYRN
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8222310", Offset = "0x8220B10", VA = "0x188222310", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8222470", Offset = "0x8220C70", VA = "0x188222470", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<JIMQUKYOEGQ, JIMQUKYOEGQ> MYYHPKHNTYF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x82225D0", Offset = "0x8220DD0", VA = "0x1882225D0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8222260", Offset = "0x8220A60", VA = "0x188222260", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<JIMQUKYOEGQ, JIMQUKYOEGQ, JIMQUKYOEGQ> DRIXOEJHKAT
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x82223C0", Offset = "0x8220BC0", VA = "0x1882223C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8222520", Offset = "0x8220D20", VA = "0x188222520", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "26")]
		public void GGOPOLDMLPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "12")]
		public void Initialize(GameObject gameObject, IWXRLXRLZSK configData, LHTRVBEPHKZ rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "14")]
		public void JPLRKQDWIBU(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "15")]
		public void EHINEMRFQHH(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "16")]
		public void BBVNNUWFVXI(JIMQUKYOEGQ a, HashSet<JIMQUKYOEGQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "17")]
		public void PWDDZAHCYNS(JIMQUKYOEGQ a, JIMQUKYOEGQ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "18")]
		public void VNTWQBHDOMM(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "19")]
		public void WQCNJLEAIFM(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "20")]
		public ConnectableGraphData NQJDYGYVOVJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "21")]
		public ConnectableGraphData RRIZMNRPWFH(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "22")]
		public bool WUMYZMDJMKD(KYSBUCYODST a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "23")]
		public void YXGRVJCVLPW(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "24")]
		public void PNWWTTYQBAS(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "25")]
		public void BHKLQJNDBTV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public POLBZYLLLWY()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JIMQUKYOEGQ : LXGQPLPUVGZ, IEquatable<JIMQUKYOEGQ>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface LXGQPLPUVGZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		JIMQUKYOEGQ ParentConnectable
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
		bool CanConnectTo(int slotIndex, JIMQUKYOEGQ otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, JIMQUKYOEGQ newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, JIMQUKYOEGQ newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, JIMQUKYOEGQ removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, JIMQUKYOEGQ parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(JIMQUKYOEGQ previousRootConnectable, JIMQUKYOEGQ newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZGGSCMHMZDR : LYHFQGWTPJE
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool ZMUGFMCKOPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool VSGHPAZZZDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<JIMQUKYOEGQ, JIMQUKYOEGQ> QIRHZDSVYRN;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<JIMQUKYOEGQ, JIMQUKYOEGQ> MYYHPKHNTYF;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<JIMQUKYOEGQ, JIMQUKYOEGQ, JIMQUKYOEGQ> DRIXOEJHKAT;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, IWXRLXRLZSK configData, LHTRVBEPHKZ rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void JPLRKQDWIBU(JIMQUKYOEGQ a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void EHINEMRFQHH(JIMQUKYOEGQ a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void BBVNNUWFVXI(JIMQUKYOEGQ a, HashSet<JIMQUKYOEGQ> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void PWDDZAHCYNS(JIMQUKYOEGQ a, JIMQUKYOEGQ b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void VNTWQBHDOMM(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void WQCNJLEAIFM(JIMQUKYOEGQ a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData NQJDYGYVOVJ(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData RRIZMNRPWFH(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool WUMYZMDJMKD(KYSBUCYODST a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void YXGRVJCVLPW(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void PNWWTTYQBAS(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void BHKLQJNDBTV(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface BUKJFOVICGZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool JLRCNPTARZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JIMQUKYOEGQ WLXENODUICH(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		JIMQUKYOEGQ NJHHRZRZXGS(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PMBKAZUPCIS(JIMQUKYOEGQ a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool GPIYCJDFNWC();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GJHZFZAOAMN(JIMQUKYOEGQ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface NBXRJFMLPKW
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OVOWUPSWSGG(OCYQKEPIFQS a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool QKAPRMESZCH(OCYQKEPIFQS a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string MOUJMSLEHMC(OCYQKEPIFQS a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid PEMEPHUMJMR(OCYQKEPIFQS a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int MPYGRPNHIWW(OCYQKEPIFQS a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TNCMZMXGIXD(OCYQKEPIFQS a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(JIMQUKYOEGQ childConnectable, int childConnectableSlot, JIMQUKYOEGQ parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(JIMQUKYOEGQ previousRootConnectable, JIMQUKYOEGQ newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface OCYQKEPIFQS : JIMQUKYOEGQ, LXGQPLPUVGZ, IEquatable<JIMQUKYOEGQ>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface YOLRCLYDTEI : LXGQPLPUVGZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		JIMQUKYOEGQ ATFKXGIANQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<JIMQUKYOEGQ> MAPBZOJRAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 VIVXUAHAJDX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion SKEMZHAURAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool YKDLLJXPLFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool AFPMHZXFAZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler FEBNZQNSJLD;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler CMQGRBAKDMX;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler SNHGMRPNGZG;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler RZBBWYMSMEX;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void GQKSDNWBZOF();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void TLMMOOVYXNU();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void AJKLETBUAAP();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void ZGXKVCEWZMM();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ZQZQVZOMGVF(int a, JIMQUKYOEGQ b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SCWNDLLXJGD();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void EXVZITCVCAF(int a, JIMQUKYOEGQ b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void RYMZENRZUQL(JIMQUKYOEGQ a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void HUBHGLYAGIS();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void BXRRBEKNXPX(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void CYLNCJWKOEY(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface TEIVTKWXQNK
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 LFWEDSGIAXV
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
	public interface IWXRLXRLZSK
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool RBPDUNUPOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		VGRFCRFFWHL SARZSGGONBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, IWXRLXRLZSK
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
		public bool RBPDUNUPOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xC19AA0", Offset = "0xC182A0", VA = "0x180C19AA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public VGRFCRFFWHL SARZSGGONBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8211F60", Offset = "0x8210760", VA = "0x188211F60")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8212020", Offset = "0x8210820", VA = "0x188212020")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JIMQUKYOEGQ connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x8212580", Offset = "0x8210D80", VA = "0x188212580")]
		public ConnectableLink(JIMQUKYOEGQ connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x82124E0", Offset = "0x8210CE0", VA = "0x1882124E0")]
		public ConnectableLink(JIMQUKYOEGQ connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x82125E0", Offset = "0x8210DE0", VA = "0x1882125E0")]
		public ConnectableLink(JIMQUKYOEGQ connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8212070", Offset = "0x8210870", VA = "0x188212070", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8212120", Offset = "0x8210920", VA = "0x188212120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : PEUWCJDSMBZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform IBPLMINYERD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private VGRFCRFFWHL SIWMCOINIHP;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7B65A90", Offset = "0x7B64290", VA = "0x187B65A90", Slot = "4")]
		public void Initialize(Transform transform, VGRFCRFFWHL linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8213D50", Offset = "0x8212550", VA = "0x188213D50", Slot = "5")]
		public VGRFCRFFWHL GKANVXUTKNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8213E20", Offset = "0x8212620", VA = "0x188213E20", Slot = "6")]
		public void TPAHDCOJTVZ(VGRFCRFFWHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, MRINRARAHUX
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PTDBVDQQLVC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public JIMQUKYOEGQ RBYPHIWVURU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public JIMQUKYOEGQ RYQNBYJBBNZ;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public PTDBVDQQLVC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8222680", Offset = "0x8220E80", VA = "0x188222680")]
			internal bool FGPNXCNLCRP(HEYCAOKLTCA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly ETXDSBTDPYN MUGAKIOOPHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private FOFMUDUJISQ LKEKUVKSVJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private EIEQLNDMGEE HNJJLYVJSTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool RYJBNPROCAE;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log CJKAONEPIWK;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HEYCAOKLTCA PUSUXZYIEUP
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x82146A0", Offset = "0x8212EA0", VA = "0x1882146A0")]
		public bool EYBIGLMKGSI([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x82162E0", Offset = "0x8214AE0", VA = "0x1882162E0")]
		private bool TAGWTUDBPGX([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8217A40", Offset = "0x8216240", VA = "0x188217A40")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8215580", Offset = "0x8213D80", VA = "0x188215580", Slot = "5")]
		public void Initialize(ZGGSCMHMZDR manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8216A00", Offset = "0x8215200", VA = "0x188216A00", Slot = "17")]
		public void TEAGASEYFMV(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x82161A0", Offset = "0x82149A0", VA = "0x1882161A0", Slot = "12")]
		public void SPMHBJHTNKM(Func<JIMQUKYOEGQ, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x82161B0", Offset = "0x82149B0", VA = "0x1882161B0")]
		private void SPMHBJHTNKM(ETXDSBTDPYN a, Func<JIMQUKYOEGQ, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x82178B0", Offset = "0x82160B0", VA = "0x1882178B0", Slot = "11")]
		public void ZMXOFHUDMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8216060", Offset = "0x8214860", VA = "0x188216060", Slot = "8")]
		public bool QKMTCVPAVOJ(JIMQUKYOEGQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8215950", Offset = "0x8214150", VA = "0x188215950")]
		private bool PDRJFKFJNFU(JIMQUKYOEGQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x82178D0", Offset = "0x82160D0", VA = "0x1882178D0")]
		private static bool ZPMLXIVRJIQ(JIMQUKYOEGQ a, ETXDSBTDPYN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8216DD0", Offset = "0x82155D0", VA = "0x188216DD0")]
		private void WFKEYQQVUPE(Transform a, ETXDSBTDPYN b, ETXDSBTDPYN[] c, JIMQUKYOEGQ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8214AA0", Offset = "0x82132A0", VA = "0x188214AA0")]
		private ConnectableLink BYOXEGTVEVF(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8215790", Offset = "0x8213F90", VA = "0x188215790")]
		private static bool NUMNAIYXSKS(ETXDSBTDPYN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x82146B0", Offset = "0x8212EB0", VA = "0x1882146B0", Slot = "9")]
		public bool AQWZVEHJQTD(JIMQUKYOEGQ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x82174E0", Offset = "0x8215CE0", VA = "0x1882174E0")]
		private bool YZIEAXLDICK(JIMQUKYOEGQ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x82171B0", Offset = "0x82159B0", VA = "0x1882171B0")]
		private static void XJOPZRPIXBH(JIMQUKYOEGQ a, int b, int c, Vector3 d, Quaternion e, ETXDSBTDPYN f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8217790", Offset = "0x8215F90", VA = "0x188217790")]
		private void YZSLQRDRWFQ(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x82153D0", Offset = "0x8213BD0", VA = "0x1882153D0")]
		private void HORPSIAQERE(ETXDSBTDPYN a, JIMQUKYOEGQ b, JIMQUKYOEGQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8215440", Offset = "0x8213C40", VA = "0x188215440")]
		private void HORPSIAQERE(JIMQUKYOEGQ a, JIMQUKYOEGQ b, JIMQUKYOEGQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8215290", Offset = "0x8213A90", VA = "0x188215290")]
		private void DPHWPJGVUMT(JIMQUKYOEGQ a, JIMQUKYOEGQ b, JIMQUKYOEGQ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8215190", Offset = "0x8213990", VA = "0x188215190")]
		private void DPHWPJGVUMT(ETXDSBTDPYN a, JIMQUKYOEGQ b, JIMQUKYOEGQ c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8215670", Offset = "0x8213E70", VA = "0x188215670")]
		private void LULPFAXYAEG(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8216A30", Offset = "0x8215230", VA = "0x188216A30")]
		private void TQZRKOUSVKI(HEYCAOKLTCA a, HEYCAOKLTCA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x82168A0", Offset = "0x82150A0", VA = "0x1882168A0", Slot = "18")]
		public JIMQUKYOEGQ TBWFTJOTIVP(JIMQUKYOEGQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8214710", Offset = "0x8212F10", VA = "0x188214710", Slot = "13")]
		public void BBVNNUWFVXI(JIMQUKYOEGQ a, HashSet<JIMQUKYOEGQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8216B90", Offset = "0x8215390", VA = "0x188216B90", Slot = "14")]
		public List<JIMQUKYOEGQ> UKYBTEWBVSC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8215300", Offset = "0x8213B00", VA = "0x188215300")]
		protected HEYCAOKLTCA DSTUVTCHVXP(HEYCAOKLTCA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8217330", Offset = "0x8215B30", VA = "0x188217330")]
		protected ETXDSBTDPYN[] YBBJSAQFPLA(ETXDSBTDPYN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x82173D0", Offset = "0x8215BD0", VA = "0x1882173D0")]
		protected bool YHHUXYLNXTN(JIMQUKYOEGQ a, [Out] ETXDSBTDPYN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8216070", Offset = "0x8214870", VA = "0x188216070", Slot = "15")]
		public bool SMQYAXAZERR(JIMQUKYOEGQ a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8215630", Offset = "0x8213E30", VA = "0x188215630")]
		protected ETXDSBTDPYN JPEWWJFZJTK(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8217730", Offset = "0x8215F30", VA = "0x188217730", Slot = "10")]
		public bool YZRLLANZUOD(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8214BF0", Offset = "0x82133F0", VA = "0x188214BF0")]
		private bool CUDBUHGXFDA(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x82154B0", Offset = "0x8213CB0", VA = "0x1882154B0")]
		private static bool ILGIEGVYFOM(ETXDSBTDPYN a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x82146A0", Offset = "0x8212EA0", VA = "0x1882146A0", Slot = "7")]
		private bool AFOVTOSUJKF([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : ZGGSCMHMZDR, LYHFQGWTPJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly MUPQGBSCKZR container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly EIEQLNDMGEE HNJJLYVJSTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly WEWLSXFBWQZ TCJUMFZSCRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly YFLJXZHTBBZ MEXCXROMXEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly MRINRARAHUX SHWBNSWXDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal GYWNSRXIOAY UBLEZUXYRFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal DFBTCUJGDUD JWGJSJVTGSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal FOFMUDUJISQ MYWZQNDKIVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool RYJBNPROCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool SRREIAAJLHH;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool SCEEUKSADCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAF9820", Offset = "0xAF8020", VA = "0x180AF9820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAF94C0", Offset = "0xAF7CC0", VA = "0x180AF94C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ZMUGFMCKOPO
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x10A2B00", Offset = "0x10A1300", VA = "0x1810A2B00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2585600", Offset = "0x2583E00", VA = "0x182585600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool VSGHPAZZZDY
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<JIMQUKYOEGQ, JIMQUKYOEGQ> QIRHZDSVYRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8217F70", Offset = "0x8216770", VA = "0x188217F70", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8219300", Offset = "0x8217B00", VA = "0x188219300", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<JIMQUKYOEGQ, JIMQUKYOEGQ> MYYHPKHNTYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8219830", Offset = "0x8218030", VA = "0x188219830", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8217F10", Offset = "0x8216710", VA = "0x188217F10", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<JIMQUKYOEGQ, JIMQUKYOEGQ, JIMQUKYOEGQ> DRIXOEJHKAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8219100", Offset = "0x8217900", VA = "0x188219100", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x82193E0", Offset = "0x8217BE0", VA = "0x1882193E0", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8219890", Offset = "0x8218090", VA = "0x188219890")]
		public LegacyConnectableManager(MUPQGBSCKZR container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8218460", Offset = "0x8216C60", VA = "0x188218460", Slot = "12")]
		public void Initialize(GameObject gameObject, IWXRLXRLZSK configData, LHTRVBEPHKZ rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8218140", Offset = "0x8216940", VA = "0x188218140", Slot = "26")]
		public void GGOPOLDMLPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8219360", Offset = "0x8217B60", VA = "0x188219360", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8218B70", Offset = "0x8217370", VA = "0x188218B70", Slot = "14")]
		public void JPLRKQDWIBU(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x82180E0", Offset = "0x82168E0", VA = "0x1882180E0", Slot = "15")]
		public void EHINEMRFQHH(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8219750", Offset = "0x8217F50", VA = "0x188219750", Slot = "22")]
		public bool WUMYZMDJMKD(KYSBUCYODST a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8217FD0", Offset = "0x82167D0", VA = "0x188217FD0")]
		internal bool CUDBUHGXFDA([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8218A20", Offset = "0x8217220", VA = "0x188218A20")]
		internal bool JNQMYGIYMKI([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8217BF0", Offset = "0x82163F0", VA = "0x188217BF0")]
		internal void ABTCRFOJIRO(JIMQUKYOEGQ a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x82180E0", Offset = "0x82168E0", VA = "0x1882180E0")]
		internal bool RCWSHRDCPLQ(JIMQUKYOEGQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8218B90", Offset = "0x8217390", VA = "0x188218B90")]
		internal bool MEIWPNYKFJO(JIMQUKYOEGQ a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8217DD0", Offset = "0x82165D0", VA = "0x188217DD0", Slot = "16")]
		public void BBVNNUWFVXI(JIMQUKYOEGQ a, HashSet<JIMQUKYOEGQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8218EF0", Offset = "0x82176F0", VA = "0x188218EF0", Slot = "17")]
		public void PWDDZAHCYNS(JIMQUKYOEGQ a, JIMQUKYOEGQ b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8219440", Offset = "0x8217C40", VA = "0x188219440", Slot = "18")]
		public void VNTWQBHDOMM(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8219580", Offset = "0x8217D80", VA = "0x188219580", Slot = "19")]
		public void WQCNJLEAIFM(JIMQUKYOEGQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8218210", Offset = "0x8216A10", VA = "0x188218210")]
		public void ILQIJVVQMTZ([Optional] MNBQIABPYXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x82197A0", Offset = "0x8217FA0", VA = "0x1882197A0", Slot = "23")]
		public void YXGRVJCVLPW(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8218CC0", Offset = "0x82174C0", VA = "0x188218CC0", Slot = "20")]
		public ConnectableGraphData NQJDYGYVOVJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8219160", Offset = "0x8217960", VA = "0x188219160", Slot = "21")]
		public ConnectableGraphData RRIZMNRPWFH(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8217ED0", Offset = "0x82166D0", VA = "0x188217ED0", Slot = "25")]
		public void BHKLQJNDBTV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8218E40", Offset = "0x8217640", VA = "0x188218E40", Slot = "24")]
		public void PNWWTTYQBAS(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class EIEQLNDMGEE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly WYIFEYTRKDD<JIMQUKYOEGQ, JIMQUKYOEGQ> QIRHZDSVYRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly WYIFEYTRKDD<JIMQUKYOEGQ, JIMQUKYOEGQ> MYYHPKHNTYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly WYCYHRZUARU<JIMQUKYOEGQ, JIMQUKYOEGQ, JIMQUKYOEGQ> DRIXOEJHKAT;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8212E50", Offset = "0x8211650", VA = "0x188212E50")]
		public EIEQLNDMGEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8212D10", Offset = "0x8211510", VA = "0x188212D10")]
		public void GWNTDROTRAT(JIMQUKYOEGQ a, JIMQUKYOEGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8212D70", Offset = "0x8211570", VA = "0x188212D70")]
		public void LKTZLZNCFDX(JIMQUKYOEGQ a, JIMQUKYOEGQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8212DD0", Offset = "0x82115D0", VA = "0x188212DD0")]
		public void VWJJUNFLUQL(JIMQUKYOEGQ a, JIMQUKYOEGQ b, JIMQUKYOEGQ c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class WEWLSXFBWQZ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager XUASIQOBWVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private DFBTCUJGDUD JWGJSJVTGSR;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public WEWLSXFBWQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8223990", Offset = "0x8222190", VA = "0x188223990")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8223980", Offset = "0x8222180", VA = "0x188223980", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8223C30", Offset = "0x8222430", VA = "0x188223C30")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8223BC0", Offset = "0x82223C0", VA = "0x188223BC0")]
		private void OnMasterClientSwitched(MNBQIABPYXS newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8223AC0", Offset = "0x82222C0", VA = "0x188223AC0")]
		public void JLCNIAZMNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8223880", Offset = "0x8222080", VA = "0x188223880")]
		public void DLPBMAFJYMA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class UJOACEWDJBP
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class YMFUAEWSMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public MUPQGBSCKZR container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YMFUAEWSMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8226530", Offset = "0x8224D30", VA = "0x188226530")]
			internal LegacyConnectableManager EFHUOLYLAXK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x82233C0", Offset = "0x8221BC0", VA = "0x1882233C0")]
		public static void UVOMICUKGTG(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8223340", Offset = "0x8221B40", VA = "0x188223340")]
		public static void RDPMUQUXGOD(MUPQGBSCKZR a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, FOFMUDUJISQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, VGRFCRFFWHL> RAEUZJFECMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation YQFSIZWAFGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private PEUWCJDSMBZ FQRVIGMQBPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private MRINRARAHUX SHWBNSWXDOJ;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker QYLYUSFPJLR;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x821A8E0", Offset = "0x82190E0", VA = "0x18821A8E0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8219EE0", Offset = "0x82186E0", VA = "0x188219EE0", Slot = "7")]
		public void Initialize(MRINRARAHUX graph, PEUWCJDSMBZ creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x821A420", Offset = "0x8218C20", VA = "0x18821A420", Slot = "5")]
		public void TVFLJSWCDLO(HEYCAOKLTCA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8219C20", Offset = "0x8218420", VA = "0x188219C20", Slot = "9")]
		public void GVAQLONEEVV(HEYCAOKLTCA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x821A6C0", Offset = "0x8218EC0", VA = "0x18821A6C0", Slot = "8")]
		public void VUHVHVMDQIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8219F20", Offset = "0x8218720", VA = "0x188219F20", Slot = "10")]
		public void JKOUGQRDNKM(HEYCAOKLTCA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8219D90", Offset = "0x8218590", VA = "0x188219D90", Slot = "11")]
		public void ILPEZTKHFQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x821A270", Offset = "0x8218A70", VA = "0x18821A270")]
		private bool NJYJAFQBHFR(HEYCAOKLTCA a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class YFLJXZHTBBZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly ETXDSBTDPYN currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly KYSBUCYODST parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly KYSBUCYODST rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool IWDKOOWEPBC
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x82228B0", Offset = "0x82210B0", VA = "0x1882228B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8222FF0", Offset = "0x82217F0", VA = "0x188222FF0")]
			public SerializeNodeInSubgraph(ETXDSBTDPYN currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] KYSBUCYODST parentNodeData, [Optional] KYSBUCYODST rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8222E50", Offset = "0x8221650", VA = "0x188222E50")]
			public KYSBUCYODST VOPQGDPBGDJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8222BD0", Offset = "0x82213D0", VA = "0x188222BD0")]
			private KYSBUCYODST RDPQUXRTKTJ([Out] KYSBUCYODST a, [Out] KYSBUCYODST b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x82229D0", Offset = "0x82211D0", VA = "0x1882229D0")]
			private KYSBUCYODST HWEAHTWBWAB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8222740", Offset = "0x8220F40", VA = "0x188222740")]
			private void DFISXTJPAMD(KYSBUCYODST a, KYSBUCYODST b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8222C90", Offset = "0x8221490", VA = "0x188222C90")]
			private void VABBMQNIMXK(KYSBUCYODST a, KYSBUCYODST b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager XUASIQOBWVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private MRINRARAHUX SHWBNSWXDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private FOFMUDUJISQ LKEKUVKSVJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private DFBTCUJGDUD JWGJSJVTGSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool OQSRFQQSRMX;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool GJIDYDKFUBG
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x82262C0", Offset = "0x8224AC0", VA = "0x1882262C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool SCEEUKSADCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8224A20", Offset = "0x8223220", VA = "0x188224A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8225D60", Offset = "0x8224560", VA = "0x188225D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x82249B0", Offset = "0x82231B0", VA = "0x1882249B0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8224A40", Offset = "0x8223240", VA = "0x188224A40")]
		public ConnectableGraphData NQJDYGYVOVJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8224C80", Offset = "0x8223480", VA = "0x188224C80")]
		public ConnectableGraphData RRIZMNRPWFH(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8226230", Offset = "0x8224A30", VA = "0x188226230")]
		public void YXGRVJCVLPW(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8224BE0", Offset = "0x82233E0", VA = "0x188224BE0")]
		public void PNWWTTYQBAS(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8224BB0", Offset = "0x82233B0", VA = "0x188224BB0")]
		public void OQMBPCHXHIU(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8225B80", Offset = "0x8224380", VA = "0x188225B80")]
		private void XRDNOSMKVNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8223DC0", Offset = "0x82225C0", VA = "0x188223DC0")]
		private KYSBUCYODST DENJYXQPYGD(ETXDSBTDPYN a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8225430", Offset = "0x8223C30", VA = "0x188225430")]
		private static void VXDIKSRJXXF(ETXDSBTDPYN a, bool b, KYSBUCYODST c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8225D80", Offset = "0x8224580", VA = "0x188225D80")]
		private void YRSTZFJFLYY(ETXDSBTDPYN a, bool b, KYSBUCYODST c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8224FB0", Offset = "0x82237B0", VA = "0x188224FB0")]
		private KYSBUCYODST SNGQCEZMMUN(ETXDSBTDPYN a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8225FA0", Offset = "0x82247A0", VA = "0x188225FA0")]
		private bool YWIUUOOCHSR(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8224340", Offset = "0x8222B40", VA = "0x188224340")]
		private bool GRHXVXLPQHS(KYSBUCYODST a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8223FE0", Offset = "0x82227E0", VA = "0x188223FE0")]
		private bool DNHWSFGNWPY(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8226310", Offset = "0x8224B10", VA = "0x188226310")]
		private static bool ZZFTZLQRDJF(KYSBUCYODST a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x82258F0", Offset = "0x82240F0", VA = "0x1882258F0")]
		public static bool WUMYZMDJMKD(KYSBUCYODST a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8224000", Offset = "0x8222800", VA = "0x188224000")]
		private JIMQUKYOEGQ FTNUTRISJDH(KYSBUCYODST a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8225770", Offset = "0x8223F70", VA = "0x188225770")]
		private JIMQUKYOEGQ WLXENODUICH(KYSBUCYODST a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x82252A0", Offset = "0x8223AA0", VA = "0x1882252A0")]
		private JIMQUKYOEGQ UIKWUMZRFJU(KYSBUCYODST a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x821CF00", Offset = "0x821B700", VA = "0x18821CF00")]
		private static Guid IDBAAFEOXKU(KYSBUCYODST a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8225680", Offset = "0x8223E80", VA = "0x188225680")]
		private string WAODCXGZRCB(KYSBUCYODST a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8224E20", Offset = "0x8223620", VA = "0x188224E20")]
		private bool SDGHIVVQONK(ETXDSBTDPYN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8225040", Offset = "0x8223840", VA = "0x188225040")]
		private static void TIOKCNCKILU(ETXDSBTDPYN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public YFLJXZHTBBZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public JIMQUKYOEGQ child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public JIMQUKYOEGQ parent;

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
		public ConnectableLink ADVWFXETBLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8212660", Offset = "0x8210E60", VA = "0x188212660")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink TJEJRSRZRBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8212700", Offset = "0x8210F00", VA = "0x188212700")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8212730", Offset = "0x8210F30", VA = "0x188212730")]
		public ConnectionOperationData(JIMQUKYOEGQ child, JIMQUKYOEGQ parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface MRINRARAHUX
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		HEYCAOKLTCA PUSUXZYIEUP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(ZGGSCMHMZDR manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EYBIGLMKGSI([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool QKMTCVPAVOJ(JIMQUKYOEGQ a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool AQWZVEHJQTD(JIMQUKYOEGQ a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool YZRLLANZUOD(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZMXOFHUDMOA();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SPMHBJHTNKM(Func<JIMQUKYOEGQ, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BBVNNUWFVXI(JIMQUKYOEGQ a, HashSet<JIMQUKYOEGQ> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<JIMQUKYOEGQ> UKYBTEWBVSC();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool SMQYAXAZERR(JIMQUKYOEGQ a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void TEAGASEYFMV(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(HEYCAOKLTCA node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface HEYCAOKLTCA
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		JIMQUKYOEGQ ALAAIDOGXBF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		HEYCAOKLTCA LUZXDGFNRIX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink JBASXHEEAWT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool TWKFQPXFVCT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface VGRFCRFFWHL : TNDSPVUMABN.JIXYWQLJMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RUCBQSMBUXH(JIMQUKYOEGQ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CCHJESVOULD(JIMQUKYOEGQ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PKXEZOLGJJE(JIMQUKYOEGQ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZPFYXIHPBCK(JIMQUKYOEGQ a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		VGRFCRFFWHL CNNIBVDFLGJ(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface PEUWCJDSMBZ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, VGRFCRFFWHL linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		VGRFCRFFWHL GKANVXUTKNF();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TPAHDCOJTVZ(VGRFCRFFWHL a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface GYWNSRXIOAY : BUKJFOVICGZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BFOAXEESSXY();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UDNKYKZQNYP(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface FOFMUDUJISQ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TVFLJSWCDLO(HEYCAOKLTCA a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(MRINRARAHUX graph, PEUWCJDSMBZ linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VUHVHVMDQIN();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GVAQLONEEVV(HEYCAOKLTCA a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JKOUGQRDNKM(HEYCAOKLTCA a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ILPEZTKHFQA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class ETXDSBTDPYN : HEYCAOKLTCA
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class IGWWQJWGNEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink EGWMZRWRBRE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public ETXDSBTDPYN BIQLAUFSLMB;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public IGWWQJWGNEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8213C10", Offset = "0x8212410", VA = "0x188213C10")]
			internal bool LMCFJVBRMKQ(HEYCAOKLTCA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink ULTWAKWSGVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<ETXDSBTDPYN> TXPQWHWYDUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private ETXDSBTDPYN NJLINAUMJLS;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink JBASXHEEAWT
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x47A7BA0", Offset = "0x47A63A0", VA = "0x1847A7BA0", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8212F50", Offset = "0x8211750", VA = "0x188212F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private ETXDSBTDPYN PKLBYNGIDZN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x82134B0", Offset = "0x8211CB0", VA = "0x1882134B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public HEYCAOKLTCA LUZXDGFNRIX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public JIMQUKYOEGQ ALAAIDOGXBF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool TWKFQPXFVCT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x82133B0", Offset = "0x8211BB0", VA = "0x1882133B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool NFIHPLNMULN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8213990", Offset = "0x8212190", VA = "0x188213990", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected ETXDSBTDPYN GCIIEAQCVVB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8212F80", Offset = "0x8211780", VA = "0x188212F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x82139E0", Offset = "0x82121E0", VA = "0x1882139E0")]
		public ETXDSBTDPYN(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8213270", Offset = "0x8211A70", VA = "0x188213270")]
		public ETXDSBTDPYN FHTUHGKCEBC(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8212FA0", Offset = "0x82117A0", VA = "0x188212FA0")]
		public ETXDSBTDPYN CDCSNCWABXO(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8213590", Offset = "0x8211D90", VA = "0x188213590")]
		public ETXDSBTDPYN Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8213120", Offset = "0x8211920", VA = "0x188213120")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8213770", Offset = "0x8211F70", VA = "0x188213770")]
		public ETXDSBTDPYN Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8213820", Offset = "0x8212020", VA = "0x188213820")]
		private static void TEAGASEYFMV(ETXDSBTDPYN a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8213980", Offset = "0x8212180", VA = "0x188213980", Slot = "9")]
		public void TEAGASEYFMV(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x82133C0", Offset = "0x8211BC0", VA = "0x1882133C0")]
		public static ETXDSBTDPYN JPEWWJFZJTK(ETXDSBTDPYN a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface DFBTCUJGDUD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool GJIDYDKFUBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool JLRCNPTARZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> JMVCMDDJUYI;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<MNBQIABPYXS> IPPANTXFKZQ;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RUCBQSMBUXH(LegacyConnectableManager a, LHTRVBEPHKZ b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PWDDZAHCYNS(JIMQUKYOEGQ a, JIMQUKYOEGQ b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void VNTWQBHDOMM(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void INYLDMZTPKB(ConnectableGraphData a, [Optional] MNBQIABPYXS b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class UHOJYQYTXAP
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8223260", Offset = "0x8221A60", VA = "0x188223260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object QIBVUYLFYAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x82232B0", Offset = "0x8221AB0", VA = "0x1882232B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x82232F0", Offset = "0x8221AF0", VA = "0x1882232F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class NOKIASPZLTS : DFBTCUJGDUD, IDisposable, ZLSBYXQPOVB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager XUASIQOBWVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private LHTRVBEPHKZ CTBEEMDFUFD;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool GJIDYDKFUBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x821BA00", Offset = "0x821A200", VA = "0x18821BA00", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool JLRCNPTARZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x821AFA0", Offset = "0x82197A0", VA = "0x18821AFA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView KIQNKZXWCVR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x821B070", Offset = "0x8219870", VA = "0x18821B070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> JMVCMDDJUYI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x821B850", Offset = "0x821A050", VA = "0x18821B850", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x821ADF0", Offset = "0x82195F0", VA = "0x18821ADF0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<MNBQIABPYXS> IPPANTXFKZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x821AC30", Offset = "0x8219430", VA = "0x18821AC30", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x821AB90", Offset = "0x8219390", VA = "0x18821AB90", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x821AFE0", Offset = "0x82197E0", VA = "0x18821AFE0", Slot = "10")]
		public void RUCBQSMBUXH(LegacyConnectableManager a, LHTRVBEPHKZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x821AB40", Offset = "0x8219340", VA = "0x18821AB40", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x821AE80", Offset = "0x8219680", VA = "0x18821AE80", Slot = "11")]
		public void PWDDZAHCYNS(JIMQUKYOEGQ a, JIMQUKYOEGQ b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x821B8E0", Offset = "0x821A0E0", VA = "0x18821B8E0", Slot = "12")]
		public void VNTWQBHDOMM(JIMQUKYOEGQ a, int b, JIMQUKYOEGQ c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x821ACD0", Offset = "0x82194D0", VA = "0x18821ACD0", Slot = "13")]
		public void INYLDMZTPKB(ConnectableGraphData a, [Optional] MNBQIABPYXS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x821B330", Offset = "0x8219B30", VA = "0x18821B330")]
		[RPCMethod]
		private void RpcMasterReparentNodes(JIMQUKYOEGQ objectToReparent, int objectToReparentSlotIndex, JIMQUKYOEGQ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x821B140", Offset = "0x8219940", VA = "0x18821B140")]
		[RPCMethod]
		private void RpcMasterModifyNode(JIMQUKYOEGQ connectableToModify, JIMQUKYOEGQ expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x821B720", Offset = "0x8219F20", VA = "0x18821B720")]
		[RPCMethod]
		private void RpcReparentNodes(JIMQUKYOEGQ objectToReparent, int objectToReparentSlotIndex, JIMQUKYOEGQ newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x821B630", Offset = "0x8219E30", VA = "0x18821B630")]
		[RPCMethod]
		private void RpcModifyNode(JIMQUKYOEGQ connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x821B100", Offset = "0x8219900", VA = "0x18821B100")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public NOKIASPZLTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, VGRFCRFFWHL, TNDSPVUMABN.JIXYWQLJMDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8213E90", Offset = "0x8212690", VA = "0x188213E90", Slot = "4")]
		private void DXCTLRPZWHC(JIMQUKYOEGQ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8214010", Offset = "0x8212810", VA = "0x188214010", Slot = "5")]
		private void GHVGOYFBRYU(JIMQUKYOEGQ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8214280", Offset = "0x8212A80", VA = "0x188214280", Slot = "6")]
		private void LLFJUDZXLJT(JIMQUKYOEGQ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x82144B0", Offset = "0x8212CB0", VA = "0x1882144B0", Slot = "7")]
		private void UJENYALDETF(JIMQUKYOEGQ a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x82143E0", Offset = "0x8212BE0", VA = "0x1882143E0", Slot = "8")]
		private VGRFCRFFWHL NPRXWCWCBAO(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8214450", Offset = "0x8212C50", VA = "0x188214450", Slot = "9")]
		private void NXMKCCMADRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class JDEZPXZATUB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3768CE0", Offset = "0x37674E0", VA = "0x183768CE0")]
		public static WTVVDLLFOXQ<a> CHPKOHZEQEB<a>(this MUPQGBSCKZR a)
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
