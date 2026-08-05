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
		[Cpp2IlInjected.Address(RVA = "0x97640B0", Offset = "0x9762AB0", VA = "0x1897640B0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		private int[] FEHXVDYRGKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] FENESKSOPWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GXKYIJVMEXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset GXFRLDBOVMM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x22397D0", Offset = "0x22381D0", VA = "0x1822397D0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x976FAB0", Offset = "0x976E4B0", VA = "0x18976FAB0")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x976F960", Offset = "0x976E360", VA = "0x18976F960")]
		private void GUZRVDHVFXS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x976FC00", Offset = "0x976E600", VA = "0x18976FC00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x976FF10", Offset = "0x976E910", VA = "0x18976FF10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public sealed class OMConnectableManager : BKQSAGTTXDY, EQFYRFRSSPD
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class AHOMGQIPSTG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OMConnectableManager DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public BWPYMSYLZBA NSQRQARKYUM;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public AHOMGQIPSTG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x975AED0", Offset = "0x97598D0", VA = "0x18975AED0")]
			internal object JPMRJWKZVTF(BWPYMSYLZBA a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class AHTTDXCNCEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public BWPYMSYLZBA VJELHHXYECC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public AHOMGQIPSTG FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public AHTTDXCNCEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x975AF40", Offset = "0x9759940", VA = "0x18975AF40")]
			internal object JPHKMPRCMHW((BWPYMSYLZBA child, BWPYMSYLZBA nodeData) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class YVNQHFOJUOH : IEnumerable<IVCTQHGKKFR>, IEnumerable, IEnumerator<IVCTQHGKKFR>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private IVCTQHGKKFR PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private ObjectLocalId BFLEQSZOLCW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ObjectLocalId AGQOISHVBVX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public OMConnectableManager DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private SOGEWMVZOFB TJARZNCRNOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NativeObjectLocalIdArray KBVHUYDPQOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NativeObjectLocalIdArray.Enumerator MOSUJKNDARU;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private IVCTQHGKKFR YNIVTKAZHIV
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public YVNQHFOJUOH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x976CC30", Offset = "0x976B630", VA = "0x18976CC30", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x976C8D0", Offset = "0x976B2D0", VA = "0x18976C8D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x976CD30", Offset = "0x976B730", VA = "0x18976CD30")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x976CD10", Offset = "0x976B710", VA = "0x18976CD10")]
			private void SXLZLZTDMZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x976C890", Offset = "0x976B290", VA = "0x18976C890", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x976C7E0", Offset = "0x976B1E0", VA = "0x18976C7E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IVCTQHGKKFR> PEHTPZADBLA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x976C7E0", Offset = "0x976B1E0", VA = "0x18976C7E0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly Log RBALLPXKZKH;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly Log WPFWSECWSXF;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log WCENYYXIMPJ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log VVMNDFAEYBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private VHNQEOVNDKG CGUMDWUXNIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OHXWWKOOZRX KXZKIDBFGVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private BDZTIYBTDBO PRYEJMZFMLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BFRTCVWPFWS KJXKMHFLTOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private EVTOWQLXIRU QKBHOUZSGCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private VNXQNHKAVHQ HCZRBALJAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly LZCFIZACNTF ZVTEVMWJRVS;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool OQIZMMIKYRN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4380", Offset = "0xCF2D80", VA = "0x180CF4380", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF2D60", VA = "0x180CF4360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9766F10", Offset = "0x9765910", VA = "0x189766F10", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x97675F0", Offset = "0x9765FF0", VA = "0x1897675F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9766320", Offset = "0x9764D20", VA = "0x189766320", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9766E00", Offset = "0x9765800", VA = "0x189766E00", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x97663D0", Offset = "0x9764DD0", VA = "0x1897663D0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9768590", Offset = "0x9766F90", VA = "0x189768590", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9768C30", Offset = "0x9767630", VA = "0x189768C30")]
		public OMConnectableManager(VIGMLMXVCUS container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9765CD0", Offset = "0x97646D0", VA = "0x189765CD0", Slot = "12")]
		public void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9764240", Offset = "0x9762C40", VA = "0x189764240", Slot = "26")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9765920", Offset = "0x9764320", VA = "0x189765920", Slot = "22")]
		public bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9764D50", Offset = "0x9763750", VA = "0x189764D50")]
		private void DNZXNPBRHBX(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97653E0", Offset = "0x9763DE0", VA = "0x1897653E0")]
		private void EUZADMYQGVB(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97660C0", Offset = "0x9764AC0", VA = "0x1897660C0")]
		private void JWWWPPFUKUZ(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9764940", Offset = "0x9763340", VA = "0x189764940")]
		private void DAKVQLDAWHM(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x97676E0", Offset = "0x97660E0", VA = "0x1897676E0", Slot = "14")]
		public void SIFQFAPRLAF(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "15")]
		public void WKECLZBLVZA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9764F60", Offset = "0x9763960", VA = "0x189764F60", Slot = "17")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x97650C0", Offset = "0x9763AC0", VA = "0x1897650C0")]
		public void DOLEIESYIWZ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9765350", Offset = "0x9763D50", VA = "0x189765350")]
		public void EMALDLCGAQH(IVCTQHGKKFR a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x97682D0", Offset = "0x9766CD0", VA = "0x1897682D0", Slot = "18")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9764480", Offset = "0x9762E80", VA = "0x189764480")]
		private float BSSWESYRKUB(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9768430", Offset = "0x9766E30", VA = "0x189768430")]
		public void TJRXAIJULLR(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9767480", Offset = "0x9765E80", VA = "0x189767480", Slot = "19")]
		public void OVQIOTEGCPR(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x97686B0", Offset = "0x97670B0", VA = "0x1897686B0", Slot = "16")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "20")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "21")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9768640", Offset = "0x9767040", VA = "0x189768640", Slot = "23")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9764410", Offset = "0x9762E10", VA = "0x189764410", Slot = "24")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9768570", Offset = "0x9766F70", VA = "0x189768570", Slot = "25")]
		public void UYBHEQBSJNC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9766480", Offset = "0x9764E80", VA = "0x189766480")]
		private void LMWSPUPWPVB(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x97679E0", Offset = "0x97663E0", VA = "0x1897679E0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9768940", Offset = "0x9767340", VA = "0x189768940")]
		private void ZLJMJHRCRII(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x97688B0", Offset = "0x97672B0", VA = "0x1897688B0")]
		[IteratorStateMachine(typeof(YVNQHFOJUOH))]
		public IEnumerable<IVCTQHGKKFR> ZHDKJQYDPPP(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9767350", Offset = "0x9765D50", VA = "0x189767350")]
		internal IVCTQHGKKFR NFLUGRYMCPY(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9765B40", Offset = "0x9764540", VA = "0x189765B40")]
		internal ObjectLocalId IETVAKWNWLM(IVCTQHGKKFR a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9766880", Offset = "0x9765280", VA = "0x189766880")]
		private bool MTHFIFJKAHB(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97652F0", Offset = "0x9763CF0", VA = "0x1897652F0")]
		private bool DZSKCNFPLHZ(BWPYMSYLZBA a, [Out] IVCTQHGKKFR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9766FC0", Offset = "0x97659C0", VA = "0x189766FC0")]
		private IVCTQHGKKFR NFLUGRYMCPY(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9765F40", Offset = "0x9764940", VA = "0x189765F40")]
		private IVCTQHGKKFR JAGMBGJUCZB(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9765970", Offset = "0x9764370", VA = "0x189765970")]
		private IVCTQHGKKFR HZZAUPLQXDW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x97676A0", Offset = "0x97660A0", VA = "0x1897676A0")]
		private static Guid RVPKEQKPORL(BWPYMSYLZBA a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9765200", Offset = "0x9763C00", VA = "0x189765200")]
		private string DYUIPQRHEVW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9765790", Offset = "0x9764190", VA = "0x189765790")]
		private void GFYGPZOLKLJ(IVCTQHGKKFR a, IVCTQHGKKFR b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9764530", Offset = "0x9762F30", VA = "0x189764530")]
		private void CMQOWXKMNWR(IVCTQHGKKFR a, IVCTQHGKKFR b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9766EB0", Offset = "0x97658B0", VA = "0x189766EB0")]
		private void MZSFPUNKXKX(IVCTQHGKKFR a, IVCTQHGKKFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9765600", Offset = "0x9764000", VA = "0x189765600")]
		private void GDRAWZXXNOK(IVCTQHGKKFR a, IVCTQHGKKFR b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x97689B0", Offset = "0x97673B0", VA = "0x1897689B0")]
		private void ZUQMXVEZTNJ(ObjectLocalId a, IVCTQHGKKFR b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x97646C0", Offset = "0x97630C0", VA = "0x1897646C0")]
		private void CZOYDYYAQTC(ObjectLocalId a, IVCTQHGKKFR b, IVCTQHGKKFR c, IVCTQHGKKFR d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class COHCQWUXAOF
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class UBYOUQYNJZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public VIGMLMXVCUS container;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x976B760", Offset = "0x976A160", VA = "0x18976B760")]
			internal OMConnectableManager CDXMHODZDVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x975B330", Offset = "0x9759D30", VA = "0x18975B330")]
		public static void RGRSDUGGYET(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x975B2E0", Offset = "0x9759CE0", VA = "0x18975B2E0")]
		public static void GZHHEPXXGPO(VIGMLMXVCUS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class OMConnectableToolImpl : WUJKKJBPVHF, JBFELHKRJXU
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly RigidbodyEx WGQNBVLMTNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly OMConnectableManager WFJTKXJMTIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly CPJPZUNDSEN MTHNWHNLFVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly RPUGEAJHKCL KJXKMHFLTOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly ZVVPWACYWAL[] SZFNILQPFCH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ObjectLocalId ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IVCTQHGKKFR ParentConnectable
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x976A840", Offset = "0x9769240", VA = "0x18976A840", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IVCTQHGKKFR OHKROXSXNIG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9768CA0", Offset = "0x97676A0", VA = "0x189768CA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 WLQRRRBQCNM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x97696F0", Offset = "0x97680F0", VA = "0x1897696F0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion WAHRDQABFSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9769D10", Offset = "0x9768710", VA = "0x189769D10", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MHISRSVFIZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9769B30", Offset = "0x9768530", VA = "0x189769B30", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<IVCTQHGKKFR> MJCBBFOUTJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9769C40", Offset = "0x9768640", VA = "0x189769C40", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[Obsolete]
		public bool ZPSQLALIPIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD94380", Offset = "0xD92D80", VA = "0x180D94380", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE76F00", Offset = "0xE75900", VA = "0x180E76F00", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x976AA40", Offset = "0x9769440", VA = "0x18976AA40", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x976A760", Offset = "0x9769160", VA = "0x18976A760", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x976A780", Offset = "0x9769180", VA = "0x18976A780", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x976A8A0", Offset = "0x97692A0", VA = "0x18976A8A0", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x976A980", Offset = "0x9769380", VA = "0x18976A980", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool YRLVANZTLCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9769E30", Offset = "0x9768830", VA = "0x189769E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler TIZQZOPZFKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9769DE0", Offset = "0x97687E0", VA = "0x189769DE0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x976A230", Offset = "0x9768C30", VA = "0x18976A230", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler YEXQUDTBWTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9768FF0", Offset = "0x97679F0", VA = "0x189768FF0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x97699C0", Offset = "0x97683C0", VA = "0x1897699C0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler OJOZQFVWWMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9769ED0", Offset = "0x97688D0", VA = "0x189769ED0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9769D70", Offset = "0x9768770", VA = "0x189769D70", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler WGSTAQSEYOI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9769C70", Offset = "0x9768670", VA = "0x189769C70", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9769BA0", Offset = "0x97685A0", VA = "0x189769BA0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x976A660", Offset = "0x9769060", VA = "0x18976A660")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, CPJPZUNDSEN connectableTool, ZVVPWACYWAL[] connectionPoints, RPUGEAJHKCL callbacks, BKQSAGTTXDY connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9768F70", Offset = "0x9767970", VA = "0x189768F70", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "21")]
		public void ZMBUWBZIMLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x976A5B0", Offset = "0x9768FB0", VA = "0x18976A5B0", Slot = "22")]
		public void ZZOWLOOJVJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9769E80", Offset = "0x9768880", VA = "0x189769E80", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9768D60", Offset = "0x9767760", VA = "0x189768D60", Slot = "25")]
		public void ASRMGYTVTMC(int a, IVCTQHGKKFR b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9769A60", Offset = "0x9768460", VA = "0x189769A60", Slot = "26")]
		public void MCTTWLRPXCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x976A2D0", Offset = "0x9768CD0", VA = "0x18976A2D0", Slot = "27")]
		public void ZCQPJWZNBSE(int a, IVCTQHGKKFR b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9769750", Offset = "0x9768150", VA = "0x189769750", Slot = "28")]
		public void IGVBXDHGUPA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9769040", Offset = "0x9767A40", VA = "0x189769040", Slot = "31")]
		public void CKFNOSAGQQD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9769F20", Offset = "0x9768920", VA = "0x189769F20", Slot = "29")]
		public void WGFOBRPSUUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x97697D0", Offset = "0x97681D0", VA = "0x1897697D0", Slot = "30")]
		public void IRCGDSQSAEG(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9769620", Offset = "0x9768020", VA = "0x189769620", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x97694F0", Offset = "0x9767EF0", VA = "0x1897694F0", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD56C30", Offset = "0xD55630", VA = "0x180D56C30", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9769450", Offset = "0x9767E50", VA = "0x189769450", Slot = "43")]
		public bool CanConnectTo(int slotIndex, IVCTQHGKKFR otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "44")]
		public void ParentChanged(int slotIndex, IVCTQHGKKFR newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "45")]
		public void ChildAdded(int slotIndex, IVCTQHGKKFR newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "46")]
		public void ChildRemoved(int slotIndex, IVCTQHGKKFR removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "47")]
		public void ConnectionModified(int slotIndex, IVCTQHGKKFR parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9769DC0", Offset = "0x97687C0", VA = "0x189769DC0", Slot = "48")]
		public void RootChanged(IVCTQHGKKFR previousRootConnectable, IVCTQHGKKFR newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x976A280", Offset = "0x9768C80", VA = "0x18976A280", Slot = "23")]
		public void ZCCCJXLXLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9769A10", Offset = "0x9768410", VA = "0x189769A10", Slot = "24")]
		public void LZULKHRJBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9768FA0", Offset = "0x97679A0", VA = "0x189768FA0")]
		private void CBJGESRWLQN(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(HLYXDPFKQHQ), new string[] { })]
	public class ANJFBOKAGCX : HLYXDPFKQHQ, CJJGAWHPXAL, KXJYMNDEBYH
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LZUZORPWDSO
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public LZUZORPWDSO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[DependsOn]
		private QCNGOEJVGHA PRVYSIDAWZL;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object WZYXCWGWADS
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x975B1E0", Offset = "0x9759BE0", VA = "0x18975B1E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x975B190", Offset = "0x9759B90", VA = "0x18975B190", Slot = "5")]
		private void MMZJSGUTRHN(PPCVAYWFABF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF4F380", Offset = "0xF4DD80", VA = "0x180F4F380", Slot = "6")]
		private void IKBYUUMLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public ANJFBOKAGCX()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RegisterService(typeof(BKQSAGTTXDY), new string[] { "Ignore", "Mock" })]
	public class YWSQBVSINLJ : BKQSAGTTXDY, EQFYRFRSSPD
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool OQIZMMIKYRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x976CF60", Offset = "0x976B960", VA = "0x18976CF60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x976D010", Offset = "0x976BA10", VA = "0x18976D010", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x976CD50", Offset = "0x976B750", VA = "0x18976CD50", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x976CEB0", Offset = "0x976B8B0", VA = "0x18976CEB0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x976CE00", Offset = "0x976B800", VA = "0x18976CE00", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x976D0C0", Offset = "0x976BAC0", VA = "0x18976D0C0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "26")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "12")]
		public void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "14")]
		public void SIFQFAPRLAF(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "15")]
		public void WKECLZBLVZA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "16")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "17")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "18")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "19")]
		public void OVQIOTEGCPR(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "20")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "21")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "22")]
		public bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "23")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "24")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "25")]
		public void UYBHEQBSJNC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public YWSQBVSINLJ()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IVCTQHGKKFR : JBFELHKRJXU, IEquatable<IVCTQHGKKFR>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface JBFELHKRJXU
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		IVCTQHGKKFR ParentConnectable
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
		bool CanConnectTo(int slotIndex, IVCTQHGKKFR otherConnectable, int otherSlotIndex);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ParentChanged(int slotIndex, IVCTQHGKKFR newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ChildAdded(int slotIndex, IVCTQHGKKFR newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ChildRemoved(int slotIndex, IVCTQHGKKFR removedChildConnectable, int removedChildSlot);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ConnectionModified(int slotIndex, IVCTQHGKKFR parentConnectable, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void RootChanged(IVCTQHGKKFR previousRootConnectable, IVCTQHGKKFR newRootConnectable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BKQSAGTTXDY : EQFYRFRSSPD
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool OQIZMMIKYRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA rpcService);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void Update();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void SIFQFAPRLAF(IVCTQHGKKFR a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void WKECLZBLVZA(IVCTQHGKKFR a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void OVQIOTEGCPR(IVCTQHGKKFR a);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ConnectableGraphData QRADGIJEELY(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool HVISVVVTCCU(BWPYMSYLZBA a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void WUOQFOHIUPV(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void BDTMIWRUWWH(ConnectableGraphData a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void UYBHEQBSJNC(ConnectableGraphData a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface BFRTCVWPFWS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IVCTQHGKKFR HZZAUPLQXDW(int a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IVCTQHGKKFR JAGMBGJUCZB(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GJGHRCSUBJV(IVCTQHGKKFR a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool WOTLOQQYWGJ();

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FVDTUJYOUGK(IVCTQHGKKFR a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface RPUGEAJHKCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YRLVANZTLCV(CPJPZUNDSEN a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UOBEBGIWVIY(CPJPZUNDSEN a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string NTRBADVAYCT(CPJPZUNDSEN a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid YGULXBNGTAK(CPJPZUNDSEN a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int XCTWGWADEXZ(CPJPZUNDSEN a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JQUVISJZROK(CPJPZUNDSEN a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void HierarchyChangeHandler(IVCTQHGKKFR childConnectable, int childConnectableSlot, IVCTQHGKKFR parentConnectable, int parentConnectableSlot, [Optional] Vector3? relativePosition, [Optional] Quaternion? relativeRotation);
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void RootChangeHandler(IVCTQHGKKFR previousRootConnectable, IVCTQHGKKFR newRootConnectable);
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface CPJPZUNDSEN : IVCTQHGKKFR, JBFELHKRJXU, IEquatable<IVCTQHGKKFR>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface WUJKKJBPVHF : JBFELHKRJXU
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		IVCTQHGKKFR OHKROXSXNIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		IEnumerable<IVCTQHGKKFR> MJCBBFOUTJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 WLQRRRBQCNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Quaternion WAHRDQABFSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool MHISRSVFIZX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool ZPSQLALIPIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event HierarchyChangeHandler TIZQZOPZFKU;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event HierarchyChangeHandler YEXQUDTBWTA;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HierarchyChangeHandler OJOZQFVWWMF;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event RootChangeHandler WGSTAQSEYOI;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ZMBUWBZIMLY();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void ZZOWLOOJVJV();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void ZCCCJXLXLIE();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void LZULKHRJBEL();

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ASRMGYTVTMC(int a, IVCTQHGKKFR b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void MCTTWLRPXCC();

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void ZCQPJWZNBSE(int a, IVCTQHGKKFR b, int c, [Optional] Vector3? d, [Optional] Quaternion? e);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void IGVBXDHGUPA(IVCTQHGKKFR a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void WGFOBRPSUUN();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void IRCGDSQSAEG(int a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void CKFNOSAGQQD(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ZVVPWACYWAL
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Vector3 KZBVCXZMSCS
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
	public interface EYQOTTHXFWR
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool BPLWJXKFVDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ZMQTUONOMHM YOAWDHXDACN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, EYQOTTHXFWR
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
		public bool BPLWJXKFVDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2830", VA = "0x180EA3E30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ZMQTUONOMHM YOAWDHXDACN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x975B4A0", Offset = "0x9759EA0", VA = "0x18975B4A0")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x975B560", Offset = "0x9759F60", VA = "0x18975B560")]
		public ConnectableConfigData(LegacyConnectableLinkVisual legacyLinkVisualPrefab, bool verboseLogging)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ConnectableLink : IEquatable<ConnectableLink>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public IVCTQHGKKFR connectable;

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
		[Cpp2IlInjected.Address(RVA = "0x975BB50", Offset = "0x975A550", VA = "0x18975BB50")]
		public ConnectableLink(IVCTQHGKKFR connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x975BA20", Offset = "0x975A420", VA = "0x18975BA20")]
		public ConnectableLink(IVCTQHGKKFR connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x975BAC0", Offset = "0x975A4C0", VA = "0x18975BAC0")]
		public ConnectableLink(IVCTQHGKKFR connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x975B5B0", Offset = "0x9759FB0", VA = "0x18975B5B0", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x975B660", Offset = "0x975A060", VA = "0x18975B660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyConnectableLinkVisualCreator : DILYMMXEGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform VVUQJWBKDSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ZMQTUONOMHM DLQXWQVVDAK;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9087380", Offset = "0x9085D80", VA = "0x189087380", Slot = "4")]
		public void Initialize(Transform transform, ZMQTUONOMHM linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x975D310", Offset = "0x975BD10", VA = "0x18975D310", Slot = "5")]
		public ZMQTUONOMHM VHWCEDIVCJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x975D2A0", Offset = "0x975BCA0", VA = "0x18975D2A0", Slot = "6")]
		public void CUHLKDLLLVQ(ZMQTUONOMHM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public LegacyConnectableLinkVisualCreator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal class LegacyConnectableManagerGraph : IDisposable, BJYYMNNMBFI
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class TBMIUWRZTOR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public IVCTQHGKKFR SESWEVWKOXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public IVCTQHGKKFR ESLKBQWUUQQ;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public TBMIUWRZTOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x976B370", Offset = "0x9769D70", VA = "0x18976B370")]
			internal bool XADXUNJFDYK(BYVLDONWUUJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly ULKEYLVDNYS LBALKAPOSES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private DZFDZASYQWF YNFJSXRVJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private WVPCFHTLVZN QFHXDKMMWEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool RBVOBYPOWLZ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Log DUSOWJWPRYZ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BYVLDONWUUJ OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x975F270", Offset = "0x975DC70", VA = "0x18975F270")]
		public bool MPQEBZRWRHJ([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9760600", Offset = "0x975F000", VA = "0x189760600")]
		private bool XLUQCRHXLFM([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9761070", Offset = "0x975FA70", VA = "0x189761070")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x975F010", Offset = "0x975DA10", VA = "0x18975F010", Slot = "5")]
		public void Initialize(BKQSAGTTXDY manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x97605D0", Offset = "0x975EFD0", VA = "0x1897605D0", Slot = "17")]
		public void XCKEUNCGKKW(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x975ED50", Offset = "0x975D750", VA = "0x18975ED50", Slot = "12")]
		public void ITRXDAAZGVD(Func<IVCTQHGKKFR, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x975EC20", Offset = "0x975D620", VA = "0x18975EC20")]
		private void ITRXDAAZGVD(ULKEYLVDNYS a, Func<IVCTQHGKKFR, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x975E1D0", Offset = "0x975CBD0", VA = "0x18975E1D0", Slot = "11")]
		public void DUAWUZFRUGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9760150", Offset = "0x975EB50", VA = "0x189760150", Slot = "8")]
		public bool VQFGGABWCDA(IVCTQHGKKFR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x975FAB0", Offset = "0x975E4B0", VA = "0x18975FAB0")]
		private bool ULHSVHEEURV(IVCTQHGKKFR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x97600A0", Offset = "0x975EAA0", VA = "0x1897600A0")]
		private static bool VQFFSLIYUAF(IVCTQHGKKFR a, ULKEYLVDNYS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9760BC0", Offset = "0x975F5C0", VA = "0x189760BC0")]
		private void YSECJMCVFZL(Transform a, ULKEYLVDNYS b, ULKEYLVDNYS[] c, IVCTQHGKKFR d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x975F960", Offset = "0x975E360", VA = "0x18975F960")]
		private ConnectableLink SHPKTQREXLG(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x975F630", Offset = "0x975E030", VA = "0x18975F630")]
		private static bool PJVPKVMPCDR(ULKEYLVDNYS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x975E1F0", Offset = "0x975CBF0", VA = "0x18975E1F0", Slot = "9")]
		public bool EXTJLETCNXQ(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x975ED60", Offset = "0x975D760", VA = "0x18975ED60")]
		private bool IZGGDVFVTCP(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x975F450", Offset = "0x975DE50", VA = "0x18975F450")]
		private static void OMZVMTIYVAC(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e, ULKEYLVDNYS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x975E7E0", Offset = "0x975D1E0", VA = "0x18975E7E0")]
		private void GFYGPZOLKLJ(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x975E900", Offset = "0x975D300", VA = "0x18975E900")]
		private void HUDGZVZVWHB(ULKEYLVDNYS a, IVCTQHGKKFR b, IVCTQHGKKFR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x975E970", Offset = "0x975D370", VA = "0x18975E970")]
		private void HUDGZVZVWHB(IVCTQHGKKFR a, IVCTQHGKKFR b, IVCTQHGKKFR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x975E160", Offset = "0x975CB60", VA = "0x18975E160")]
		private void CZOYDYYAQTC(IVCTQHGKKFR a, IVCTQHGKKFR b, IVCTQHGKKFR c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x975E060", Offset = "0x975CA60", VA = "0x18975E060")]
		private void CZOYDYYAQTC(ULKEYLVDNYS a, IVCTQHGKKFR b, IVCTQHGKKFR c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x975DF40", Offset = "0x975C940", VA = "0x18975DF40")]
		private void CMQOWXKMNWR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x975F280", Offset = "0x975DC80", VA = "0x18975F280")]
		private void MZSFPUNKXKX(BYVLDONWUUJ a, BYVLDONWUUJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x975DDE0", Offset = "0x975C7E0", VA = "0x18975DDE0", Slot = "18")]
		public IVCTQHGKKFR CCGBMACTIRE(IVCTQHGKKFR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9760230", Offset = "0x975EC30", VA = "0x189760230", Slot = "13")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x975E9E0", Offset = "0x975D3E0", VA = "0x18975E9E0", Slot = "14")]
		public List<IVCTQHGKKFR> IRBHZBUSROB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x975F1A0", Offset = "0x975DBA0", VA = "0x18975F1A0")]
		protected BYVLDONWUUJ KRQCTMXLWXM(BYVLDONWUUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x975F0C0", Offset = "0x975DAC0", VA = "0x18975F0C0")]
		protected ULKEYLVDNYS[] JNAFRJVMYXJ(ULKEYLVDNYS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x975F850", Offset = "0x975E250", VA = "0x18975F850")]
		protected bool QDBQFXIRUFI(IVCTQHGKKFR a, [Out] ULKEYLVDNYS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x975DCB0", Offset = "0x975C6B0", VA = "0x18975DCB0", Slot = "15")]
		public bool BVOBDABAYPY(IVCTQHGKKFR a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x975F160", Offset = "0x975DB60", VA = "0x18975F160")]
		protected ULKEYLVDNYS JNEZMWSHBXZ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x975F7F0", Offset = "0x975E1F0", VA = "0x18975F7F0", Slot = "10")]
		public bool PKQQCLBJPBI(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x975E250", Offset = "0x975CC50", VA = "0x18975E250")]
		private bool FICKYSESXOR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9760160", Offset = "0x975EB60", VA = "0x189760160")]
		private static bool WLVYHKELLZB(ULKEYLVDNYS a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x975F270", Offset = "0x975DC70", VA = "0x18975F270", Slot = "7")]
		private bool XTGWOWZVRDA([In] ConnectionOperationData data, bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableManager : BKQSAGTTXDY, EQFYRFRSSPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal readonly VIGMLMXVCUS container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal readonly WVPCFHTLVZN QFHXDKMMWEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal readonly HXDHDEPNCMI PWMDRONPWNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal readonly ZCHANNKELUO RABGXUEPKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal readonly BJYYMNNMBFI BIRRYAICSXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal AAIMPTETXWP KJXKMHFLTOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal BTURYRRQACA ZEPEQNJDATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal DZFDZASYQWF LGPEPHEOUBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal bool RBVOBYPOWLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool BEUXPVXWEEM;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CXJRYLAMYOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xD3C4C0", Offset = "0xD3AEC0", VA = "0x180D3C4C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD3C2F0", Offset = "0xD3ACF0", VA = "0x180D3C2F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OQIZMMIKYRN
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1328AB0", Offset = "0x13274B0", VA = "0x181328AB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x285D750", Offset = "0x285C150", VA = "0x18285D750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x9761FD0", Offset = "0x97609D0", VA = "0x189761FD0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x9762660", Offset = "0x9761060", VA = "0x189762660", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x9761EB0", Offset = "0x97608B0", VA = "0x189761EB0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9761F70", Offset = "0x9760970", VA = "0x189761F70", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9761F10", Offset = "0x9760910", VA = "0x189761F10", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9762A70", Offset = "0x9761470", VA = "0x189762A70", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9762E90", Offset = "0x9761890", VA = "0x189762E90")]
		public LegacyConnectableManager(VIGMLMXVCUS container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x97618F0", Offset = "0x97602F0", VA = "0x1897618F0", Slot = "12")]
		public void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9761220", Offset = "0x975FC20", VA = "0x189761220", Slot = "26")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9762860", Offset = "0x9761260", VA = "0x189762860", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x97626C0", Offset = "0x97610C0", VA = "0x1897626C0", Slot = "14")]
		public void SIFQFAPRLAF(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9762A10", Offset = "0x9761410", VA = "0x189762A10", Slot = "15")]
		public void WKECLZBLVZA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x97616C0", Offset = "0x97600C0", VA = "0x1897616C0", Slot = "22")]
		public bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x97615B0", Offset = "0x975FFB0", VA = "0x1897615B0")]
		internal bool FICKYSESXOR([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9762390", Offset = "0x9760D90", VA = "0x189762390")]
		internal bool PYJROHTAUFF([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9761710", Offset = "0x9760110", VA = "0x189761710")]
		internal void HVWWPDQUOKH(IVCTQHGKKFR a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9762A10", Offset = "0x9761410", VA = "0x189762A10")]
		internal bool XGRPLGGSFBJ(IVCTQHGKKFR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x97628E0", Offset = "0x97612E0", VA = "0x1897628E0")]
		internal bool VOUMPREDAWF(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9762B60", Offset = "0x9761560", VA = "0x189762B60", Slot = "16")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x97613A0", Offset = "0x975FDA0", VA = "0x1897613A0", Slot = "17")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x97626E0", Offset = "0x97610E0", VA = "0x1897626E0", Slot = "18")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x97621D0", Offset = "0x9760BD0", VA = "0x1897621D0", Slot = "19")]
		public void OVQIOTEGCPR(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9762C50", Offset = "0x9761650", VA = "0x189762C50")]
		public void ZVDCCPXOKKG([Optional] DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9762AD0", Offset = "0x97614D0", VA = "0x189762AD0", Slot = "23")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x97624E0", Offset = "0x9760EE0", VA = "0x1897624E0", Slot = "20")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9762030", Offset = "0x9760A30", VA = "0x189762030", Slot = "21")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9762820", Offset = "0x9761220", VA = "0x189762820", Slot = "25")]
		public void UYBHEQBSJNC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x97612F0", Offset = "0x975FCF0", VA = "0x1897612F0", Slot = "24")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class WVPCFHTLVZN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly DRHCHGPRUIY<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly DRHCHGPRUIY<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly DRMJENJPDUH<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x976C470", Offset = "0x976AE70", VA = "0x18976C470")]
		public WVPCFHTLVZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x976C410", Offset = "0x976AE10", VA = "0x18976C410")]
		public void SJIKRFQOCBQ(IVCTQHGKKFR a, IVCTQHGKKFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x976C330", Offset = "0x976AD30", VA = "0x18976C330")]
		public void FLHXORPIRFO(IVCTQHGKKFR a, IVCTQHGKKFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x976C390", Offset = "0x976AD90", VA = "0x18976C390")]
		public void RNZXLYTDVAU(IVCTQHGKKFR a, IVCTQHGKKFR b, IVCTQHGKKFR c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class HXDHDEPNCMI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LegacyConnectableManager KNEJFULKYYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private BTURYRRQACA ZEPEQNJDATU;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public HXDHDEPNCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x975BEF0", Offset = "0x975A8F0", VA = "0x18975BEF0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x975BEE0", Offset = "0x975A8E0", VA = "0x18975BEE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x975C090", Offset = "0x975AA90", VA = "0x18975C090")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x975C020", Offset = "0x975AA20", VA = "0x18975C020")]
		private void OnMasterClientSwitched(DDFOJMMWCEL newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x975C0D0", Offset = "0x975AAD0", VA = "0x18975C0D0")]
		public void PTXUJKQHVSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x975BDE0", Offset = "0x975A7E0", VA = "0x18975BDE0")]
		public void CEINZABFZYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class XHNTNIDKKMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class UBYOUQYNJZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public VIGMLMXVCUS container;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x976B700", Offset = "0x976A100", VA = "0x18976B700")]
			internal LegacyConnectableManager CDXMHODZDVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x976C5F0", Offset = "0x976AFF0", VA = "0x18976C5F0")]
		public static void RGRSDUGGYET(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x976C570", Offset = "0x976AF70", VA = "0x18976C570")]
		public static void GZHHEPXXGPO(VIGMLMXVCUS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[UnityEngine.Scripting.Preserve]
	internal class LegacyConnectableVisualManager : IDisposable, DZFDZASYQWF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<int, ZMQTUONOMHM> NYFGAVGNOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ConnectableHierarchyTraversalOperation RBCUVTDRCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private DILYMMXEGIG TZEXYAYEJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private BJYYMNNMBFI BIRRYAICSXW;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static ProfilerMarker TEGXKSCGBYO;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9763FE0", Offset = "0x97629E0", VA = "0x189763FE0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9763220", Offset = "0x9761C20", VA = "0x189763220", Slot = "7")]
		public void Initialize(BJYYMNNMBFI graph, DILYMMXEGIG creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9763260", Offset = "0x9761C60", VA = "0x189763260", Slot = "5")]
		public void MFFMVQWQFQH(BYVLDONWUUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9763630", Offset = "0x9762030", VA = "0x189763630", Slot = "9")]
		public void MMLCMDFERBI(BYVLDONWUUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9763B70", Offset = "0x9762570", VA = "0x189763B70", Slot = "8")]
		public void QFQXFKWCSNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9763D30", Offset = "0x9762730", VA = "0x189763D30", Slot = "10")]
		public void TDDZCSZQSEF(BYVLDONWUUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9763A20", Offset = "0x9762420", VA = "0x189763A20", Slot = "11")]
		public void ORJCSHVEPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9763870", Offset = "0x9762270", VA = "0x189763870")]
		private bool NGKYQPJPBRS(BYVLDONWUUJ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal class ZCHANNKELUO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		internal struct SerializeNodeInSubgraph
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private readonly ULKEYLVDNYS currentNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly HashSet<Guid> subgraphPersistenceViewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly BWPYMSYLZBA parentNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly BWPYMSYLZBA rootNodeData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly bool isForSave;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			private bool FVKBDWBBUKV
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x976B1F0", Offset = "0x9769BF0", VA = "0x18976B1F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x976B300", Offset = "0x9769D00", VA = "0x18976B300")]
			public SerializeNodeInSubgraph(ULKEYLVDNYS currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] BWPYMSYLZBA parentNodeData, [Optional] BWPYMSYLZBA rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x976AE20", Offset = "0x9769820", VA = "0x18976AE20")]
			public BWPYMSYLZBA GHRXOLGFAHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x976B130", Offset = "0x9769B30", VA = "0x18976B130")]
			private BWPYMSYLZBA VUJPJOIMMXM([Out] BWPYMSYLZBA a, [Out] BWPYMSYLZBA b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x976AC20", Offset = "0x9769620", VA = "0x18976AC20")]
			private BWPYMSYLZBA CKHAEPEOEAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x976AFC0", Offset = "0x97699C0", VA = "0x18976AFC0")]
			private void PJSUREEUGPC(BWPYMSYLZBA a, BWPYMSYLZBA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x976AA60", Offset = "0x9769460", VA = "0x18976AA60")]
			private void CEGCLKXJUGN(BWPYMSYLZBA a, BWPYMSYLZBA b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LegacyConnectableManager KNEJFULKYYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private BJYYMNNMBFI BIRRYAICSXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private DZFDZASYQWF YNFJSXRVJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private BTURYRRQACA ZEPEQNJDATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool MYTHJVCBCPC;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool RGHOUODUVVD
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x976D380", Offset = "0x976BD80", VA = "0x18976D380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool CXJRYLAMYOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x976F540", Offset = "0x976DF40", VA = "0x18976F540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x976D9D0", Offset = "0x976C3D0", VA = "0x18976D9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x976D960", Offset = "0x976C360", VA = "0x18976D960")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x976EE40", Offset = "0x976D840", VA = "0x18976EE40")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x976EB10", Offset = "0x976D510", VA = "0x18976EB10")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x976F560", Offset = "0x976DF60", VA = "0x18976F560")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x976D2E0", Offset = "0x976BCE0", VA = "0x18976D2E0")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x976D2B0", Offset = "0x976BCB0", VA = "0x18976D2B0")]
		public void AQCKLYSAAFD(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x976DCB0", Offset = "0x976C6B0", VA = "0x18976DCB0")]
		private void JLFTDNKUAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x976F5F0", Offset = "0x976DFF0", VA = "0x18976F5F0")]
		private BWPYMSYLZBA WWLEEYANNBS(ULKEYLVDNYS a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x976DE90", Offset = "0x976C890", VA = "0x18976DE90")]
		private static void LBVAOMTVOZI(ULKEYLVDNYS a, bool b, BWPYMSYLZBA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x976F6D0", Offset = "0x976E0D0", VA = "0x18976F6D0")]
		private void ZVRBNFDJXEN(ULKEYLVDNYS a, bool b, BWPYMSYLZBA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x976D4C0", Offset = "0x976BEC0", VA = "0x18976D4C0")]
		private BWPYMSYLZBA EUTKOIJYZIA(ULKEYLVDNYS a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x976F0D0", Offset = "0x976DAD0", VA = "0x18976F0D0")]
		private bool SPGAXXCTTTU(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x976E160", Offset = "0x976CB60", VA = "0x18976E160")]
		private bool MTHFIFJKAHB(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x976E140", Offset = "0x976CB40", VA = "0x18976E140")]
		private bool MQRIRVOROFH(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x976EFB0", Offset = "0x976D9B0", VA = "0x18976EFB0")]
		private static bool SBBEWRCUOTW(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x976D550", Offset = "0x976BF50", VA = "0x18976D550")]
		public static bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x976E7D0", Offset = "0x976D1D0", VA = "0x18976E7D0")]
		private IVCTQHGKKFR NFLUGRYMCPY(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x976D7E0", Offset = "0x976C1E0", VA = "0x18976D7E0")]
		private IVCTQHGKKFR HZZAUPLQXDW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x976ECB0", Offset = "0x976D6B0", VA = "0x18976ECB0")]
		private IVCTQHGKKFR OESXVEZKKBN(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x97676A0", Offset = "0x97660A0", VA = "0x1897676A0")]
		private static Guid RVPKEQKPORL(BWPYMSYLZBA a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x976D3D0", Offset = "0x976BDD0", VA = "0x18976D3D0")]
		private string DYUIPQRHEVW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x976F350", Offset = "0x976DD50", VA = "0x18976F350")]
		private bool TPXVFGYNQMX(ULKEYLVDNYS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x976D9F0", Offset = "0x976C3F0", VA = "0x18976D9F0")]
		private static void JGSNXASHNPJ(ULKEYLVDNYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public ZCHANNKELUO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct ConnectionOperationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public IVCTQHGKKFR child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public IVCTQHGKKFR parent;

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
		public ConnectableLink SBCOJMLUPSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x975BBE0", Offset = "0x975A5E0", VA = "0x18975BBE0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink HKTQKUVTINW
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x975BBB0", Offset = "0x975A5B0", VA = "0x18975BBB0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x975BC80", Offset = "0x975A680", VA = "0x18975BC80")]
		public ConnectionOperationData(IVCTQHGKKFR child, IVCTQHGKKFR parent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface BJYYMNNMBFI
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		BYVLDONWUUJ OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(BKQSAGTTXDY manager);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MPQEBZRWRHJ([In] ConnectionOperationData data, bool a = true);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool VQFGGABWCDA(IVCTQHGKKFR a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool EXTJLETCNXQ(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PKQQCLBJPBI(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DUAWUZFRUGN();

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ITRXDAAZGVD(Func<IVCTQHGKKFR, bool> a);

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		List<IVCTQHGKKFR> IRBHZBUSROB();

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool BVOBDABAYPY(IVCTQHGKKFR a, [Out] ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void XCKEUNCGKKW(ConnectableHierarchyTraversalOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal delegate bool ConnectableHierarchyTraversalOperation(BYVLDONWUUJ node);
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface BYVLDONWUUJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		IVCTQHGKKFR TWOBXHQTLOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		BYVLDONWUUJ LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		ConnectableLink CLGFFRLKYOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool ZKGCJSQAZZS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface ZMQTUONOMHM : RVCBGPDPPZM.XDACBPFNTXC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WNCQWZWPKZY(IVCTQHGKKFR a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QRLMHUTPQOG(IVCTQHGKKFR a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JWMRXHHDCIP(IVCTQHGKKFR a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MMLETAOGPQJ(IVCTQHGKKFR a, ConnectableLink b);

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZMQTUONOMHM KMIMLKLIAQA(Transform a);

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Destroy();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface DILYMMXEGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(Transform transform, ZMQTUONOMHM linkVisualPrefab);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ZMQTUONOMHM VHWCEDIVCJO();

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CUHLKDLLLVQ(ZMQTUONOMHM a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface AAIMPTETXWP : BFRTCVWPFWS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AIEISDWQVRP();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RLZUADQXWUM(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface DZFDZASYQWF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MFFMVQWQFQH(BYVLDONWUUJ a);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Initialize(BJYYMNNMBFI graph, DILYMMXEGIG linkVisualManager);

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QFQXFKWCSNW();

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MMLCMDFERBI(BYVLDONWUUJ a);

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TDDZCSZQSEF(BYVLDONWUUJ a);

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ORJCSHVEPKB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class ULKEYLVDNYS : BYVLDONWUUJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class ZAPEMMMEAEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ConnectableLink MSJBWWHVTGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public ULKEYLVDNYS BLIVJRBBTWA;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public ZAPEMMMEAEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x976D170", Offset = "0x976BB70", VA = "0x18976D170")]
			internal bool UWZWITHGYDN(BYVLDONWUUJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ConnectableLink QSZVLCFERWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LinkedList<ULKEYLVDNYS> HVTKKGTTFZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private ULKEYLVDNYS JZQIXMBHBGN;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ConnectableLink CLGFFRLKYOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5164B20", Offset = "0x5163520", VA = "0x185164B20", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x976BA90", Offset = "0x976A490", VA = "0x18976BA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private ULKEYLVDNYS PMPLOCZDTJC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2CE0", VA = "0x180CF42E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x976BC00", Offset = "0x976A600", VA = "0x18976BC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public BYVLDONWUUJ LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2CE0", VA = "0x180CF42E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IVCTQHGKKFR TWOBXHQTLOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool ZKGCJSQAZZS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x976C110", Offset = "0x976AB10", VA = "0x18976C110", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool XTOXVSUXOVW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x976BBB0", Offset = "0x976A5B0", VA = "0x18976BBB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected ULKEYLVDNYS CNBVPAWZDFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x976C0F0", Offset = "0x976AAF0", VA = "0x18976C0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x976C290", Offset = "0x976AC90", VA = "0x18976C290")]
		public ULKEYLVDNYS(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x976B800", Offset = "0x976A200", VA = "0x18976B800")]
		public ULKEYLVDNYS AZYZTCUIDGT(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x976BCE0", Offset = "0x976A6E0", VA = "0x18976BCE0")]
		public ULKEYLVDNYS RPBZZKLTJWP(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x976BE60", Offset = "0x976A860", VA = "0x18976BE60")]
		public ULKEYLVDNYS Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x976B940", Offset = "0x976A340", VA = "0x18976B940")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x976C040", Offset = "0x976AA40", VA = "0x18976C040")]
		public ULKEYLVDNYS Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x976C120", Offset = "0x976AB20", VA = "0x18976C120")]
		private static void XCKEUNCGKKW(ULKEYLVDNYS a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x976C280", Offset = "0x976AC80", VA = "0x18976C280", Slot = "9")]
		public void XCKEUNCGKKW(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x976BAC0", Offset = "0x976A4C0", VA = "0x18976BAC0")]
		public static ULKEYLVDNYS JNEZMWSHBXZ(ULKEYLVDNYS a, ConnectableLink b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface BTURYRRQACA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool RGHOUODUVVD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<PlayerId> ZGZXLVHLDWJ;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<DDFOJMMWCEL> PILAFUVGYHX;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WNCQWZWPKZY(LegacyConnectableManager a, FZKYYFPZNJA b);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, int c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LIZDWKDLMFE(ConnectableGraphData a, [Optional] DDFOJMMWCEL b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class GLLGYIJTYDU
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static Type XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x975BCF0", Offset = "0x975A6F0", VA = "0x18975BCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x975BDA0", Offset = "0x975A7A0", VA = "0x18975BDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x975BD40", Offset = "0x975A740", VA = "0x18975BD40")]
			[CompilerGenerated]
			internal set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal class IMHAEKMRBIV : BTURYRRQACA, IDisposable, YDKMAGKBVSW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private LegacyConnectableManager KNEJFULKYYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private FZKYYFPZNJA NOHBICHDSLY;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool RGHOUODUVVD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x975C360", Offset = "0x975AD60", VA = "0x18975C360", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x975C5D0", Offset = "0x975AFD0", VA = "0x18975C5D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView ACYDEJRGHCS
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x975D040", Offset = "0x975BA40", VA = "0x18975D040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> ZGZXLVHLDWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x975C730", Offset = "0x975B130", VA = "0x18975C730", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x975D200", Offset = "0x975BC00", VA = "0x18975D200", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<DDFOJMMWCEL> PILAFUVGYHX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x975D0D0", Offset = "0x975BAD0", VA = "0x18975D0D0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x975C530", Offset = "0x975AF30", VA = "0x18975C530", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x975D170", Offset = "0x975BB70", VA = "0x18975D170", Slot = "10")]
		public void WNCQWZWPKZY(LegacyConnectableManager a, FZKYYFPZNJA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x975C4E0", Offset = "0x975AEE0", VA = "0x18975C4E0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x975C3C0", Offset = "0x975ADC0", VA = "0x18975C3C0", Slot = "11")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x975CF20", Offset = "0x975B920", VA = "0x18975CF20", Slot = "12")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x975C610", Offset = "0x975B010", VA = "0x18975C610", Slot = "13")]
		public void LIZDWKDLMFE(ConnectableGraphData a, [Optional] DDFOJMMWCEL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x975CA00", Offset = "0x975B400", VA = "0x18975CA00")]
		[RPCMethod]
		private void RpcMasterReparentNodes(IVCTQHGKKFR objectToReparent, int objectToReparentSlotIndex, IVCTQHGKKFR newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x975C810", Offset = "0x975B210", VA = "0x18975C810")]
		[RPCMethod]
		private void RpcMasterModifyNode(IVCTQHGKKFR connectableToModify, IVCTQHGKKFR expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x975CDF0", Offset = "0x975B7F0", VA = "0x18975CDF0")]
		[RPCMethod]
		private void RpcReparentNodes(IVCTQHGKKFR objectToReparent, int objectToReparentSlotIndex, IVCTQHGKKFR newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x975CD00", Offset = "0x975B700", VA = "0x18975CD00")]
		[RPCMethod]
		private void RpcModifyNode(IVCTQHGKKFR connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x975C7D0", Offset = "0x975B1D0", VA = "0x18975C7D0")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public IMHAEKMRBIV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, ZMQTUONOMHM, RVCBGPDPPZM.XDACBPFNTXC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x975DB30", Offset = "0x975C530", VA = "0x18975DB30", Slot = "4")]
		private void YRBTAIFPPLD(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x975D6D0", Offset = "0x975C0D0", VA = "0x18975D6D0", Slot = "5")]
		private void PZGRNIQWQFP(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x975D3D0", Offset = "0x975BDD0", VA = "0x18975D3D0", Slot = "6")]
		private void MXRXBKLEUVA(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x975D940", Offset = "0x975C340", VA = "0x18975D940", Slot = "7")]
		private void WTGPSKZIUUS(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x975D660", Offset = "0x975C060", VA = "0x18975D660", Slot = "8")]
		private ZMQTUONOMHM PDUKXDRHTGJ(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x975D600", Offset = "0x975C000", VA = "0x18975D600", Slot = "9")]
		private void NHWQGRLEWCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class AOVIUZVZZPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3366AE0", Offset = "0x33654E0", VA = "0x183366AE0")]
		public static VTLLFLWHAYL<a> KKAQALFOHKC<a>(this VIGMLMXVCUS a)
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
