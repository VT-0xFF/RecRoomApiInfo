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
		[Cpp2IlInjected.Address(RVA = "0x9765970", Offset = "0x9764570", VA = "0x189765970", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x223B070", Offset = "0x2239C70", VA = "0x18223B070", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9771370", Offset = "0x976FF70", VA = "0x189771370")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9771220", Offset = "0x976FE20", VA = "0x189771220")]
		private void GUZRVDHVFXS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97714C0", Offset = "0x97700C0", VA = "0x1897714C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97717D0", Offset = "0x97703D0", VA = "0x1897717D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public AHOMGQIPSTG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x975C790", Offset = "0x975B390", VA = "0x18975C790")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public AHTTDXCNCEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x975C800", Offset = "0x975B400", VA = "0x18975C800")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public YVNQHFOJUOH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x976E4F0", Offset = "0x976D0F0", VA = "0x18976E4F0", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x976E190", Offset = "0x976CD90", VA = "0x18976E190", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x976E5F0", Offset = "0x976D1F0", VA = "0x18976E5F0")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x976E5D0", Offset = "0x976D1D0", VA = "0x18976E5D0")]
			private void SXLZLZTDMZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x976E150", Offset = "0x976CD50", VA = "0x18976E150", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x976E0A0", Offset = "0x976CCA0", VA = "0x18976E0A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IVCTQHGKKFR> PEHTPZADBLA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x976E0A0", Offset = "0x976CCA0", VA = "0x18976E0A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4380", Offset = "0xCF2F80", VA = "0x180CF4380", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF2F60", VA = "0x180CF4360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x97687D0", Offset = "0x97673D0", VA = "0x1897687D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9768EB0", Offset = "0x9767AB0", VA = "0x189768EB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9767BE0", Offset = "0x97667E0", VA = "0x189767BE0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x97686C0", Offset = "0x97672C0", VA = "0x1897686C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9767C90", Offset = "0x9766890", VA = "0x189767C90", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9769E50", Offset = "0x9768A50", VA = "0x189769E50", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x976A4F0", Offset = "0x97690F0", VA = "0x18976A4F0")]
		public OMConnectableManager(VIGMLMXVCUS container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9767590", Offset = "0x9766190", VA = "0x189767590", Slot = "12")]
		public void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9765B00", Offset = "0x9764700", VA = "0x189765B00", Slot = "26")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x97671E0", Offset = "0x9765DE0", VA = "0x1897671E0", Slot = "22")]
		public bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9766610", Offset = "0x9765210", VA = "0x189766610")]
		private void DNZXNPBRHBX(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9766CA0", Offset = "0x97658A0", VA = "0x189766CA0")]
		private void EUZADMYQGVB(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9767980", Offset = "0x9766580", VA = "0x189767980")]
		private void JWWWPPFUKUZ(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9766200", Offset = "0x9764E00", VA = "0x189766200")]
		private void DAKVQLDAWHM(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9768FA0", Offset = "0x9767BA0", VA = "0x189768FA0", Slot = "14")]
		public void SIFQFAPRLAF(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "15")]
		public void WKECLZBLVZA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9766820", Offset = "0x9765420", VA = "0x189766820", Slot = "17")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9766980", Offset = "0x9765580", VA = "0x189766980")]
		public void DOLEIESYIWZ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9766C10", Offset = "0x9765810", VA = "0x189766C10")]
		public void EMALDLCGAQH(IVCTQHGKKFR a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9769B90", Offset = "0x9768790", VA = "0x189769B90", Slot = "18")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9765D40", Offset = "0x9764940", VA = "0x189765D40")]
		private float BSSWESYRKUB(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9769CF0", Offset = "0x97688F0", VA = "0x189769CF0")]
		public void TJRXAIJULLR(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9768D40", Offset = "0x9767940", VA = "0x189768D40", Slot = "19")]
		public void OVQIOTEGCPR(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9769F70", Offset = "0x9768B70", VA = "0x189769F70", Slot = "16")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "20")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "21")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9769F00", Offset = "0x9768B00", VA = "0x189769F00", Slot = "23")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9765CD0", Offset = "0x97648D0", VA = "0x189765CD0", Slot = "24")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9769E30", Offset = "0x9768A30", VA = "0x189769E30", Slot = "25")]
		public void UYBHEQBSJNC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9767D40", Offset = "0x9766940", VA = "0x189767D40")]
		private void LMWSPUPWPVB(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x97692A0", Offset = "0x9767EA0", VA = "0x1897692A0")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x976A200", Offset = "0x9768E00", VA = "0x18976A200")]
		private void ZLJMJHRCRII(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x976A170", Offset = "0x9768D70", VA = "0x18976A170")]
		[IteratorStateMachine(typeof(YVNQHFOJUOH))]
		public IEnumerable<IVCTQHGKKFR> ZHDKJQYDPPP(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9768C10", Offset = "0x9767810", VA = "0x189768C10")]
		internal IVCTQHGKKFR NFLUGRYMCPY(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9767400", Offset = "0x9766000", VA = "0x189767400")]
		internal ObjectLocalId IETVAKWNWLM(IVCTQHGKKFR a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9768140", Offset = "0x9766D40", VA = "0x189768140")]
		private bool MTHFIFJKAHB(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9766BB0", Offset = "0x97657B0", VA = "0x189766BB0")]
		private bool DZSKCNFPLHZ(BWPYMSYLZBA a, [Out] IVCTQHGKKFR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9768880", Offset = "0x9767480", VA = "0x189768880")]
		private IVCTQHGKKFR NFLUGRYMCPY(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9767800", Offset = "0x9766400", VA = "0x189767800")]
		private IVCTQHGKKFR JAGMBGJUCZB(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9767230", Offset = "0x9765E30", VA = "0x189767230")]
		private IVCTQHGKKFR HZZAUPLQXDW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9768F60", Offset = "0x9767B60", VA = "0x189768F60")]
		private static Guid RVPKEQKPORL(BWPYMSYLZBA a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9766AC0", Offset = "0x97656C0", VA = "0x189766AC0")]
		private string DYUIPQRHEVW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9767050", Offset = "0x9765C50", VA = "0x189767050")]
		private void GFYGPZOLKLJ(IVCTQHGKKFR a, IVCTQHGKKFR b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9765DF0", Offset = "0x97649F0", VA = "0x189765DF0")]
		private void CMQOWXKMNWR(IVCTQHGKKFR a, IVCTQHGKKFR b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9768770", Offset = "0x9767370", VA = "0x189768770")]
		private void MZSFPUNKXKX(IVCTQHGKKFR a, IVCTQHGKKFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9766EC0", Offset = "0x9765AC0", VA = "0x189766EC0")]
		private void GDRAWZXXNOK(IVCTQHGKKFR a, IVCTQHGKKFR b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x976A270", Offset = "0x9768E70", VA = "0x18976A270")]
		private void ZUQMXVEZTNJ(ObjectLocalId a, IVCTQHGKKFR b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9765F80", Offset = "0x9764B80", VA = "0x189765F80")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x976D020", Offset = "0x976BC20", VA = "0x18976D020")]
			internal OMConnectableManager CDXMHODZDVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x975CBF0", Offset = "0x975B7F0", VA = "0x18975CBF0")]
		public static void RGRSDUGGYET(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x975CBA0", Offset = "0x975B7A0", VA = "0x18975CBA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300", Slot = "38")]
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
			[Cpp2IlInjected.Address(RVA = "0x976C100", Offset = "0x976AD00", VA = "0x18976C100", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IVCTQHGKKFR OHKROXSXNIG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x976A560", Offset = "0x9769160", VA = "0x18976A560", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 WLQRRRBQCNM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x976AFB0", Offset = "0x9769BB0", VA = "0x18976AFB0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion WAHRDQABFSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x976B5D0", Offset = "0x976A1D0", VA = "0x18976B5D0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MHISRSVFIZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x976B3F0", Offset = "0x9769FF0", VA = "0x18976B3F0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<IVCTQHGKKFR> MJCBBFOUTJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x976B500", Offset = "0x976A100", VA = "0x18976B500", Slot = "13")]
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
			[Cpp2IlInjected.Address(RVA = "0xD94380", Offset = "0xD92F80", VA = "0x180D94380", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE76F00", Offset = "0xE75B00", VA = "0x180E76F00", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x976C300", Offset = "0x976AF00", VA = "0x18976C300", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x976C020", Offset = "0x976AC20", VA = "0x18976C020", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x976C040", Offset = "0x976AC40", VA = "0x18976C040", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x976C160", Offset = "0x976AD60", VA = "0x18976C160", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x976C240", Offset = "0x976AE40", VA = "0x18976C240", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool YRLVANZTLCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x976B6F0", Offset = "0x976A2F0", VA = "0x18976B6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler TIZQZOPZFKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x976B6A0", Offset = "0x976A2A0", VA = "0x18976B6A0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x976BAF0", Offset = "0x976A6F0", VA = "0x18976BAF0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler YEXQUDTBWTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x976A8B0", Offset = "0x97694B0", VA = "0x18976A8B0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x976B280", Offset = "0x9769E80", VA = "0x18976B280", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler OJOZQFVWWMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x976B790", Offset = "0x976A390", VA = "0x18976B790", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x976B630", Offset = "0x976A230", VA = "0x18976B630", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler WGSTAQSEYOI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x976B530", Offset = "0x976A130", VA = "0x18976B530", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x976B460", Offset = "0x976A060", VA = "0x18976B460", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x976BF20", Offset = "0x976AB20", VA = "0x18976BF20")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, CPJPZUNDSEN connectableTool, ZVVPWACYWAL[] connectionPoints, RPUGEAJHKCL callbacks, BKQSAGTTXDY connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x976A830", Offset = "0x9769430", VA = "0x18976A830", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "21")]
		public void ZMBUWBZIMLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x976BE70", Offset = "0x976AA70", VA = "0x18976BE70", Slot = "22")]
		public void ZZOWLOOJVJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x976B740", Offset = "0x976A340", VA = "0x18976B740", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x976A620", Offset = "0x9769220", VA = "0x18976A620", Slot = "25")]
		public void ASRMGYTVTMC(int a, IVCTQHGKKFR b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x976B320", Offset = "0x9769F20", VA = "0x18976B320", Slot = "26")]
		public void MCTTWLRPXCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x976BB90", Offset = "0x976A790", VA = "0x18976BB90", Slot = "27")]
		public void ZCQPJWZNBSE(int a, IVCTQHGKKFR b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x976B010", Offset = "0x9769C10", VA = "0x18976B010", Slot = "28")]
		public void IGVBXDHGUPA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x976A900", Offset = "0x9769500", VA = "0x18976A900", Slot = "31")]
		public void CKFNOSAGQQD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x976B7E0", Offset = "0x976A3E0", VA = "0x18976B7E0", Slot = "29")]
		public void WGFOBRPSUUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x976B090", Offset = "0x9769C90", VA = "0x18976B090", Slot = "30")]
		public void IRCGDSQSAEG(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x976AEE0", Offset = "0x9769AE0", VA = "0x18976AEE0", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x976ADB0", Offset = "0x97699B0", VA = "0x18976ADB0", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD56C30", Offset = "0xD55830", VA = "0x180D56C30", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x976AD10", Offset = "0x9769910", VA = "0x18976AD10", Slot = "43")]
		public bool CanConnectTo(int slotIndex, IVCTQHGKKFR otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "44")]
		public void ParentChanged(int slotIndex, IVCTQHGKKFR newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "45")]
		public void ChildAdded(int slotIndex, IVCTQHGKKFR newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "46")]
		public void ChildRemoved(int slotIndex, IVCTQHGKKFR removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "47")]
		public void ConnectionModified(int slotIndex, IVCTQHGKKFR parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x976B680", Offset = "0x976A280", VA = "0x18976B680", Slot = "48")]
		public void RootChanged(IVCTQHGKKFR previousRootConnectable, IVCTQHGKKFR newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x976BB40", Offset = "0x976A740", VA = "0x18976BB40", Slot = "23")]
		public void ZCCCJXLXLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x976B2D0", Offset = "0x9769ED0", VA = "0x18976B2D0", Slot = "24")]
		public void LZULKHRJBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x976A860", Offset = "0x9769460", VA = "0x18976A860")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0x975CAA0", Offset = "0x975B6A0", VA = "0x18975CAA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x975CA50", Offset = "0x975B650", VA = "0x18975CA50", Slot = "5")]
		private void MMZJSGUTRHN(PPCVAYWFABF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF4F380", Offset = "0xF4DF80", VA = "0x180F4F380", Slot = "6")]
		private void IKBYUUMLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x976E820", Offset = "0x976D420", VA = "0x18976E820", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x976E8D0", Offset = "0x976D4D0", VA = "0x18976E8D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x976E610", Offset = "0x976D210", VA = "0x18976E610", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x976E770", Offset = "0x976D370", VA = "0x18976E770", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x976E6C0", Offset = "0x976D2C0", VA = "0x18976E6C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x976E980", Offset = "0x976D580", VA = "0x18976E980", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "26")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "12")]
		public void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "14")]
		public void SIFQFAPRLAF(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "15")]
		public void WKECLZBLVZA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "16")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "17")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "18")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "19")]
		public void OVQIOTEGCPR(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "20")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "21")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "22")]
		public bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "23")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "24")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "25")]
		public void UYBHEQBSJNC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2A30", VA = "0x180EA3E30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ZMQTUONOMHM YOAWDHXDACN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x975CD60", Offset = "0x975B960", VA = "0x18975CD60")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x975CE20", Offset = "0x975BA20", VA = "0x18975CE20")]
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
		[Cpp2IlInjected.Address(RVA = "0x975D410", Offset = "0x975C010", VA = "0x18975D410")]
		public ConnectableLink(IVCTQHGKKFR connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x975D2E0", Offset = "0x975BEE0", VA = "0x18975D2E0")]
		public ConnectableLink(IVCTQHGKKFR connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x975D380", Offset = "0x975BF80", VA = "0x18975D380")]
		public ConnectableLink(IVCTQHGKKFR connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x975CE70", Offset = "0x975BA70", VA = "0x18975CE70", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x975CF20", Offset = "0x975BB20", VA = "0x18975CF20", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9088AF0", Offset = "0x90876F0", VA = "0x189088AF0", Slot = "4")]
		public void Initialize(Transform transform, ZMQTUONOMHM linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x975EBD0", Offset = "0x975D7D0", VA = "0x18975EBD0", Slot = "5")]
		public ZMQTUONOMHM VHWCEDIVCJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x975EB60", Offset = "0x975D760", VA = "0x18975EB60", Slot = "6")]
		public void CUHLKDLLLVQ(ZMQTUONOMHM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public TBMIUWRZTOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x976CC30", Offset = "0x976B830", VA = "0x18976CC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9760B30", Offset = "0x975F730", VA = "0x189760B30")]
		public bool MPQEBZRWRHJ([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9761EC0", Offset = "0x9760AC0", VA = "0x189761EC0")]
		private bool XLUQCRHXLFM([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9762930", Offset = "0x9761530", VA = "0x189762930")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x97608D0", Offset = "0x975F4D0", VA = "0x1897608D0", Slot = "5")]
		public void Initialize(BKQSAGTTXDY manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9761E90", Offset = "0x9760A90", VA = "0x189761E90", Slot = "17")]
		public void XCKEUNCGKKW(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9760610", Offset = "0x975F210", VA = "0x189760610", Slot = "12")]
		public void ITRXDAAZGVD(Func<IVCTQHGKKFR, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x97604E0", Offset = "0x975F0E0", VA = "0x1897604E0")]
		private void ITRXDAAZGVD(ULKEYLVDNYS a, Func<IVCTQHGKKFR, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x975FA90", Offset = "0x975E690", VA = "0x18975FA90", Slot = "11")]
		public void DUAWUZFRUGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9761A10", Offset = "0x9760610", VA = "0x189761A10", Slot = "8")]
		public bool VQFGGABWCDA(IVCTQHGKKFR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9761370", Offset = "0x975FF70", VA = "0x189761370")]
		private bool ULHSVHEEURV(IVCTQHGKKFR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9761960", Offset = "0x9760560", VA = "0x189761960")]
		private static bool VQFFSLIYUAF(IVCTQHGKKFR a, ULKEYLVDNYS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9762480", Offset = "0x9761080", VA = "0x189762480")]
		private void YSECJMCVFZL(Transform a, ULKEYLVDNYS b, ULKEYLVDNYS[] c, IVCTQHGKKFR d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9761220", Offset = "0x975FE20", VA = "0x189761220")]
		private ConnectableLink SHPKTQREXLG(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9760EF0", Offset = "0x975FAF0", VA = "0x189760EF0")]
		private static bool PJVPKVMPCDR(ULKEYLVDNYS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x975FAB0", Offset = "0x975E6B0", VA = "0x18975FAB0", Slot = "9")]
		public bool EXTJLETCNXQ(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9760620", Offset = "0x975F220", VA = "0x189760620")]
		private bool IZGGDVFVTCP(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9760D10", Offset = "0x975F910", VA = "0x189760D10")]
		private static void OMZVMTIYVAC(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e, ULKEYLVDNYS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x97600A0", Offset = "0x975ECA0", VA = "0x1897600A0")]
		private void GFYGPZOLKLJ(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x97601C0", Offset = "0x975EDC0", VA = "0x1897601C0")]
		private void HUDGZVZVWHB(ULKEYLVDNYS a, IVCTQHGKKFR b, IVCTQHGKKFR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9760230", Offset = "0x975EE30", VA = "0x189760230")]
		private void HUDGZVZVWHB(IVCTQHGKKFR a, IVCTQHGKKFR b, IVCTQHGKKFR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x975FA20", Offset = "0x975E620", VA = "0x18975FA20")]
		private void CZOYDYYAQTC(IVCTQHGKKFR a, IVCTQHGKKFR b, IVCTQHGKKFR c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x975F920", Offset = "0x975E520", VA = "0x18975F920")]
		private void CZOYDYYAQTC(ULKEYLVDNYS a, IVCTQHGKKFR b, IVCTQHGKKFR c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x975F800", Offset = "0x975E400", VA = "0x18975F800")]
		private void CMQOWXKMNWR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9760B40", Offset = "0x975F740", VA = "0x189760B40")]
		private void MZSFPUNKXKX(BYVLDONWUUJ a, BYVLDONWUUJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x975F6A0", Offset = "0x975E2A0", VA = "0x18975F6A0", Slot = "18")]
		public IVCTQHGKKFR CCGBMACTIRE(IVCTQHGKKFR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9761AF0", Offset = "0x97606F0", VA = "0x189761AF0", Slot = "13")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x97602A0", Offset = "0x975EEA0", VA = "0x1897602A0", Slot = "14")]
		public List<IVCTQHGKKFR> IRBHZBUSROB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9760A60", Offset = "0x975F660", VA = "0x189760A60")]
		protected BYVLDONWUUJ KRQCTMXLWXM(BYVLDONWUUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9760980", Offset = "0x975F580", VA = "0x189760980")]
		protected ULKEYLVDNYS[] JNAFRJVMYXJ(ULKEYLVDNYS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9761110", Offset = "0x975FD10", VA = "0x189761110")]
		protected bool QDBQFXIRUFI(IVCTQHGKKFR a, [Out] ULKEYLVDNYS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x975F570", Offset = "0x975E170", VA = "0x18975F570", Slot = "15")]
		public bool BVOBDABAYPY(IVCTQHGKKFR a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9760A20", Offset = "0x975F620", VA = "0x189760A20")]
		protected ULKEYLVDNYS JNEZMWSHBXZ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x97610B0", Offset = "0x975FCB0", VA = "0x1897610B0", Slot = "10")]
		public bool PKQQCLBJPBI(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x975FB10", Offset = "0x975E710", VA = "0x18975FB10")]
		private bool FICKYSESXOR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9761A20", Offset = "0x9760620", VA = "0x189761A20")]
		private static bool WLVYHKELLZB(ULKEYLVDNYS a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9760B30", Offset = "0x975F730", VA = "0x189760B30", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3C4C0", Offset = "0xD3B0C0", VA = "0x180D3C4C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD3C2F0", Offset = "0xD3AEF0", VA = "0x180D3C2F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OQIZMMIKYRN
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1328AB0", Offset = "0x13276B0", VA = "0x181328AB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x285E9E0", Offset = "0x285D5E0", VA = "0x18285E9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x9763890", Offset = "0x9762490", VA = "0x189763890", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x9763F20", Offset = "0x9762B20", VA = "0x189763F20", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x9763770", Offset = "0x9762370", VA = "0x189763770", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9763830", Offset = "0x9762430", VA = "0x189763830", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x97637D0", Offset = "0x97623D0", VA = "0x1897637D0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9764330", Offset = "0x9762F30", VA = "0x189764330", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9764750", Offset = "0x9763350", VA = "0x189764750")]
		public LegacyConnectableManager(VIGMLMXVCUS container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x97631B0", Offset = "0x9761DB0", VA = "0x1897631B0", Slot = "12")]
		public void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9762AE0", Offset = "0x97616E0", VA = "0x189762AE0", Slot = "26")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9764120", Offset = "0x9762D20", VA = "0x189764120", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9763F80", Offset = "0x9762B80", VA = "0x189763F80", Slot = "14")]
		public void SIFQFAPRLAF(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x97642D0", Offset = "0x9762ED0", VA = "0x1897642D0", Slot = "15")]
		public void WKECLZBLVZA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9762F80", Offset = "0x9761B80", VA = "0x189762F80", Slot = "22")]
		public bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9762E70", Offset = "0x9761A70", VA = "0x189762E70")]
		internal bool FICKYSESXOR([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9763C50", Offset = "0x9762850", VA = "0x189763C50")]
		internal bool PYJROHTAUFF([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9762FD0", Offset = "0x9761BD0", VA = "0x189762FD0")]
		internal void HVWWPDQUOKH(IVCTQHGKKFR a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x97642D0", Offset = "0x9762ED0", VA = "0x1897642D0")]
		internal bool XGRPLGGSFBJ(IVCTQHGKKFR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x97641A0", Offset = "0x9762DA0", VA = "0x1897641A0")]
		internal bool VOUMPREDAWF(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9764420", Offset = "0x9763020", VA = "0x189764420", Slot = "16")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9762C60", Offset = "0x9761860", VA = "0x189762C60", Slot = "17")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9763FA0", Offset = "0x9762BA0", VA = "0x189763FA0", Slot = "18")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9763A90", Offset = "0x9762690", VA = "0x189763A90", Slot = "19")]
		public void OVQIOTEGCPR(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9764510", Offset = "0x9763110", VA = "0x189764510")]
		public void ZVDCCPXOKKG([Optional] DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9764390", Offset = "0x9762F90", VA = "0x189764390", Slot = "23")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9763DA0", Offset = "0x97629A0", VA = "0x189763DA0", Slot = "20")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x97638F0", Offset = "0x97624F0", VA = "0x1897638F0", Slot = "21")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x97640E0", Offset = "0x9762CE0", VA = "0x1897640E0", Slot = "25")]
		public void UYBHEQBSJNC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9762BB0", Offset = "0x97617B0", VA = "0x189762BB0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x976DD30", Offset = "0x976C930", VA = "0x18976DD30")]
		public WVPCFHTLVZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x976DCD0", Offset = "0x976C8D0", VA = "0x18976DCD0")]
		public void SJIKRFQOCBQ(IVCTQHGKKFR a, IVCTQHGKKFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x976DBF0", Offset = "0x976C7F0", VA = "0x18976DBF0")]
		public void FLHXORPIRFO(IVCTQHGKKFR a, IVCTQHGKKFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x976DC50", Offset = "0x976C850", VA = "0x18976DC50")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public HXDHDEPNCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x975D7B0", Offset = "0x975C3B0", VA = "0x18975D7B0")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x975D7A0", Offset = "0x975C3A0", VA = "0x18975D7A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x975D950", Offset = "0x975C550", VA = "0x18975D950")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x975D8E0", Offset = "0x975C4E0", VA = "0x18975D8E0")]
		private void OnMasterClientSwitched(DDFOJMMWCEL newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x975D990", Offset = "0x975C590", VA = "0x18975D990")]
		public void PTXUJKQHVSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x975D6A0", Offset = "0x975C2A0", VA = "0x18975D6A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x976CFC0", Offset = "0x976BBC0", VA = "0x18976CFC0")]
			internal LegacyConnectableManager CDXMHODZDVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x976DEB0", Offset = "0x976CAB0", VA = "0x18976DEB0")]
		public static void RGRSDUGGYET(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x976DE30", Offset = "0x976CA30", VA = "0x18976DE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x97658A0", Offset = "0x97644A0", VA = "0x1897658A0")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9764AE0", Offset = "0x97636E0", VA = "0x189764AE0", Slot = "7")]
		public void Initialize(BJYYMNNMBFI graph, DILYMMXEGIG creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9764B20", Offset = "0x9763720", VA = "0x189764B20", Slot = "5")]
		public void MFFMVQWQFQH(BYVLDONWUUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9764EF0", Offset = "0x9763AF0", VA = "0x189764EF0", Slot = "9")]
		public void MMLCMDFERBI(BYVLDONWUUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9765430", Offset = "0x9764030", VA = "0x189765430", Slot = "8")]
		public void QFQXFKWCSNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x97655F0", Offset = "0x97641F0", VA = "0x1897655F0", Slot = "10")]
		public void TDDZCSZQSEF(BYVLDONWUUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x97652E0", Offset = "0x9763EE0", VA = "0x1897652E0", Slot = "11")]
		public void ORJCSHVEPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9765130", Offset = "0x9763D30", VA = "0x189765130")]
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
				[Cpp2IlInjected.Address(RVA = "0x976CAB0", Offset = "0x976B6B0", VA = "0x18976CAB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x976CBC0", Offset = "0x976B7C0", VA = "0x18976CBC0")]
			public SerializeNodeInSubgraph(ULKEYLVDNYS currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] BWPYMSYLZBA parentNodeData, [Optional] BWPYMSYLZBA rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x976C6E0", Offset = "0x976B2E0", VA = "0x18976C6E0")]
			public BWPYMSYLZBA GHRXOLGFAHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x976C9F0", Offset = "0x976B5F0", VA = "0x18976C9F0")]
			private BWPYMSYLZBA VUJPJOIMMXM([Out] BWPYMSYLZBA a, [Out] BWPYMSYLZBA b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x976C4E0", Offset = "0x976B0E0", VA = "0x18976C4E0")]
			private BWPYMSYLZBA CKHAEPEOEAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x976C880", Offset = "0x976B480", VA = "0x18976C880")]
			private void PJSUREEUGPC(BWPYMSYLZBA a, BWPYMSYLZBA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x976C320", Offset = "0x976AF20", VA = "0x18976C320")]
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
			[Cpp2IlInjected.Address(RVA = "0x976EC40", Offset = "0x976D840", VA = "0x18976EC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool CXJRYLAMYOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9770E00", Offset = "0x976FA00", VA = "0x189770E00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x976F290", Offset = "0x976DE90", VA = "0x18976F290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x976F220", Offset = "0x976DE20", VA = "0x18976F220")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9770700", Offset = "0x976F300", VA = "0x189770700")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x97703D0", Offset = "0x976EFD0", VA = "0x1897703D0")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9770E20", Offset = "0x976FA20", VA = "0x189770E20")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x976EBA0", Offset = "0x976D7A0", VA = "0x18976EBA0")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x976EB70", Offset = "0x976D770", VA = "0x18976EB70")]
		public void AQCKLYSAAFD(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x976F570", Offset = "0x976E170", VA = "0x18976F570")]
		private void JLFTDNKUAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9770EB0", Offset = "0x976FAB0", VA = "0x189770EB0")]
		private BWPYMSYLZBA WWLEEYANNBS(ULKEYLVDNYS a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x976F750", Offset = "0x976E350", VA = "0x18976F750")]
		private static void LBVAOMTVOZI(ULKEYLVDNYS a, bool b, BWPYMSYLZBA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9770F90", Offset = "0x976FB90", VA = "0x189770F90")]
		private void ZVRBNFDJXEN(ULKEYLVDNYS a, bool b, BWPYMSYLZBA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x976ED80", Offset = "0x976D980", VA = "0x18976ED80")]
		private BWPYMSYLZBA EUTKOIJYZIA(ULKEYLVDNYS a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9770990", Offset = "0x976F590", VA = "0x189770990")]
		private bool SPGAXXCTTTU(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x976FA20", Offset = "0x976E620", VA = "0x18976FA20")]
		private bool MTHFIFJKAHB(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x976FA00", Offset = "0x976E600", VA = "0x18976FA00")]
		private bool MQRIRVOROFH(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9770870", Offset = "0x976F470", VA = "0x189770870")]
		private static bool SBBEWRCUOTW(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x976EE10", Offset = "0x976DA10", VA = "0x18976EE10")]
		public static bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9770090", Offset = "0x976EC90", VA = "0x189770090")]
		private IVCTQHGKKFR NFLUGRYMCPY(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x976F0A0", Offset = "0x976DCA0", VA = "0x18976F0A0")]
		private IVCTQHGKKFR HZZAUPLQXDW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9770570", Offset = "0x976F170", VA = "0x189770570")]
		private IVCTQHGKKFR OESXVEZKKBN(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9768F60", Offset = "0x9767B60", VA = "0x189768F60")]
		private static Guid RVPKEQKPORL(BWPYMSYLZBA a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x976EC90", Offset = "0x976D890", VA = "0x18976EC90")]
		private string DYUIPQRHEVW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9770C10", Offset = "0x976F810", VA = "0x189770C10")]
		private bool TPXVFGYNQMX(ULKEYLVDNYS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x976F2B0", Offset = "0x976DEB0", VA = "0x18976F2B0")]
		private static void JGSNXASHNPJ(ULKEYLVDNYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0x975D4A0", Offset = "0x975C0A0", VA = "0x18975D4A0")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink HKTQKUVTINW
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x975D470", Offset = "0x975C070", VA = "0x18975D470")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x975D540", Offset = "0x975C140", VA = "0x18975D540")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ZAPEMMMEAEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x976EA30", Offset = "0x976D630", VA = "0x18976EA30")]
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
			[Cpp2IlInjected.Address(RVA = "0x51662A0", Offset = "0x5164EA0", VA = "0x1851662A0", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x976D350", Offset = "0x976BF50", VA = "0x18976D350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private ULKEYLVDNYS PMPLOCZDTJC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x976D4C0", Offset = "0x976C0C0", VA = "0x18976D4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public BYVLDONWUUJ LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IVCTQHGKKFR TWOBXHQTLOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool ZKGCJSQAZZS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x976D9D0", Offset = "0x976C5D0", VA = "0x18976D9D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool XTOXVSUXOVW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x976D470", Offset = "0x976C070", VA = "0x18976D470", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected ULKEYLVDNYS CNBVPAWZDFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x976D9B0", Offset = "0x976C5B0", VA = "0x18976D9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x976DB50", Offset = "0x976C750", VA = "0x18976DB50")]
		public ULKEYLVDNYS(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x976D0C0", Offset = "0x976BCC0", VA = "0x18976D0C0")]
		public ULKEYLVDNYS AZYZTCUIDGT(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x976D5A0", Offset = "0x976C1A0", VA = "0x18976D5A0")]
		public ULKEYLVDNYS RPBZZKLTJWP(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x976D720", Offset = "0x976C320", VA = "0x18976D720")]
		public ULKEYLVDNYS Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x976D200", Offset = "0x976BE00", VA = "0x18976D200")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x976D900", Offset = "0x976C500", VA = "0x18976D900")]
		public ULKEYLVDNYS Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x976D9E0", Offset = "0x976C5E0", VA = "0x18976D9E0")]
		private static void XCKEUNCGKKW(ULKEYLVDNYS a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x976DB40", Offset = "0x976C740", VA = "0x18976DB40", Slot = "9")]
		public void XCKEUNCGKKW(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x976D380", Offset = "0x976BF80", VA = "0x18976D380")]
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
			[Cpp2IlInjected.Address(RVA = "0x975D5B0", Offset = "0x975C1B0", VA = "0x18975D5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x975D660", Offset = "0x975C260", VA = "0x18975D660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x975D600", Offset = "0x975C200", VA = "0x18975D600")]
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
			[Cpp2IlInjected.Address(RVA = "0x975DC20", Offset = "0x975C820", VA = "0x18975DC20", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x975DE90", Offset = "0x975CA90", VA = "0x18975DE90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView ACYDEJRGHCS
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x975E900", Offset = "0x975D500", VA = "0x18975E900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> ZGZXLVHLDWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x975DFF0", Offset = "0x975CBF0", VA = "0x18975DFF0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x975EAC0", Offset = "0x975D6C0", VA = "0x18975EAC0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<DDFOJMMWCEL> PILAFUVGYHX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x975E990", Offset = "0x975D590", VA = "0x18975E990", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x975DDF0", Offset = "0x975C9F0", VA = "0x18975DDF0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x975EA30", Offset = "0x975D630", VA = "0x18975EA30", Slot = "10")]
		public void WNCQWZWPKZY(LegacyConnectableManager a, FZKYYFPZNJA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x975DDA0", Offset = "0x975C9A0", VA = "0x18975DDA0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x975DC80", Offset = "0x975C880", VA = "0x18975DC80", Slot = "11")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x975E7E0", Offset = "0x975D3E0", VA = "0x18975E7E0", Slot = "12")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x975DED0", Offset = "0x975CAD0", VA = "0x18975DED0", Slot = "13")]
		public void LIZDWKDLMFE(ConnectableGraphData a, [Optional] DDFOJMMWCEL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x975E2C0", Offset = "0x975CEC0", VA = "0x18975E2C0")]
		[RPCMethod]
		private void RpcMasterReparentNodes(IVCTQHGKKFR objectToReparent, int objectToReparentSlotIndex, IVCTQHGKKFR newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x975E0D0", Offset = "0x975CCD0", VA = "0x18975E0D0")]
		[RPCMethod]
		private void RpcMasterModifyNode(IVCTQHGKKFR connectableToModify, IVCTQHGKKFR expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x975E6B0", Offset = "0x975D2B0", VA = "0x18975E6B0")]
		[RPCMethod]
		private void RpcReparentNodes(IVCTQHGKKFR objectToReparent, int objectToReparentSlotIndex, IVCTQHGKKFR newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x975E5C0", Offset = "0x975D1C0", VA = "0x18975E5C0")]
		[RPCMethod]
		private void RpcModifyNode(IVCTQHGKKFR connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x975E090", Offset = "0x975CC90", VA = "0x18975E090")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x975F3F0", Offset = "0x975DFF0", VA = "0x18975F3F0", Slot = "4")]
		private void YRBTAIFPPLD(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x975EF90", Offset = "0x975DB90", VA = "0x18975EF90", Slot = "5")]
		private void PZGRNIQWQFP(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x975EC90", Offset = "0x975D890", VA = "0x18975EC90", Slot = "6")]
		private void MXRXBKLEUVA(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x975F200", Offset = "0x975DE00", VA = "0x18975F200", Slot = "7")]
		private void WTGPSKZIUUS(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x975EF20", Offset = "0x975DB20", VA = "0x18975EF20", Slot = "8")]
		private ZMQTUONOMHM PDUKXDRHTGJ(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x975EEC0", Offset = "0x975DAC0", VA = "0x18975EEC0", Slot = "9")]
		private void NHWQGRLEWCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class AOVIUZVZZPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3367D70", Offset = "0x3366970", VA = "0x183367D70")]
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
