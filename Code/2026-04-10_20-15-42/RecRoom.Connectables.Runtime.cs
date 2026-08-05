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
		[Cpp2IlInjected.Address(RVA = "0x9907150", Offset = "0x9906150", VA = "0x189907150", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2255D00", Offset = "0x2254D00", VA = "0x182255D00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9912B50", Offset = "0x9911B50", VA = "0x189912B50")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9912A00", Offset = "0x9911A00", VA = "0x189912A00")]
		private void GUZRVDHVFXS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9912CA0", Offset = "0x9911CA0", VA = "0x189912CA0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9912FB0", Offset = "0x9911FB0", VA = "0x189912FB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public AHOMGQIPSTG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x98FDF50", Offset = "0x98FCF50", VA = "0x1898FDF50")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public AHTTDXCNCEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x98FDFC0", Offset = "0x98FCFC0", VA = "0x1898FDFC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public YVNQHFOJUOH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x990FCD0", Offset = "0x990ECD0", VA = "0x18990FCD0", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x990F970", Offset = "0x990E970", VA = "0x18990F970", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x990FDD0", Offset = "0x990EDD0", VA = "0x18990FDD0")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x990FDB0", Offset = "0x990EDB0", VA = "0x18990FDB0")]
			private void SXLZLZTDMZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x990F930", Offset = "0x990E930", VA = "0x18990F930", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x990F880", Offset = "0x990E880", VA = "0x18990F880", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IVCTQHGKKFR> PEHTPZADBLA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x990F880", Offset = "0x990E880", VA = "0x18990F880", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F430", Offset = "0xD0E430", VA = "0x180D0F430", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD0F410", Offset = "0xD0E410", VA = "0x180D0F410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9909FB0", Offset = "0x9908FB0", VA = "0x189909FB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x990A690", Offset = "0x9909690", VA = "0x18990A690", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99093C0", Offset = "0x99083C0", VA = "0x1899093C0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9909EA0", Offset = "0x9908EA0", VA = "0x189909EA0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9909470", Offset = "0x9908470", VA = "0x189909470", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x990B630", Offset = "0x990A630", VA = "0x18990B630", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x990BCD0", Offset = "0x990ACD0", VA = "0x18990BCD0")]
		public OMConnectableManager(VIGMLMXVCUS container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9908D70", Offset = "0x9907D70", VA = "0x189908D70", Slot = "12")]
		public void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA sender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99072E0", Offset = "0x99062E0", VA = "0x1899072E0", Slot = "26")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99089C0", Offset = "0x99079C0", VA = "0x1899089C0", Slot = "22")]
		public bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9907DF0", Offset = "0x9906DF0", VA = "0x189907DF0")]
		private void DNZXNPBRHBX(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9908480", Offset = "0x9907480", VA = "0x189908480")]
		private void EUZADMYQGVB(ObjectLocalId a, ObjectLocalId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9909160", Offset = "0x9908160", VA = "0x189909160")]
		private void JWWWPPFUKUZ(ObjectLocalId a, ObjectLocalId b, ObjectLocalId c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99079E0", Offset = "0x99069E0", VA = "0x1899079E0")]
		private void DAKVQLDAWHM(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x990A780", Offset = "0x9909780", VA = "0x18990A780", Slot = "14")]
		public void SIFQFAPRLAF(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "15")]
		public void WKECLZBLVZA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9908000", Offset = "0x9907000", VA = "0x189908000", Slot = "17")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9908160", Offset = "0x9907160", VA = "0x189908160")]
		public void DOLEIESYIWZ(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99083F0", Offset = "0x99073F0", VA = "0x1899083F0")]
		public void EMALDLCGAQH(IVCTQHGKKFR a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x990B370", Offset = "0x990A370", VA = "0x18990B370", Slot = "18")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9907520", Offset = "0x9906520", VA = "0x189907520")]
		private float BSSWESYRKUB(ObjectLocalId a, ObjectLocalId b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x990B4D0", Offset = "0x990A4D0", VA = "0x18990B4D0")]
		public void TJRXAIJULLR(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, bool e = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x990A520", Offset = "0x9909520", VA = "0x18990A520", Slot = "19")]
		public void OVQIOTEGCPR(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x990B750", Offset = "0x990A750", VA = "0x18990B750", Slot = "16")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "20")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "21")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x990B6E0", Offset = "0x990A6E0", VA = "0x18990B6E0", Slot = "23")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99074B0", Offset = "0x99064B0", VA = "0x1899074B0", Slot = "24")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x990B610", Offset = "0x990A610", VA = "0x18990B610", Slot = "25")]
		public void UYBHEQBSJNC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9909520", Offset = "0x9908520", VA = "0x189909520")]
		private void LMWSPUPWPVB(ObjectLocalId a, ObjectLocalId b, Vector3 c, Quaternion d, float e, bool f = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x990AA80", Offset = "0x9909A80", VA = "0x18990AA80")]
		private void SetRbexParent(ObjectLocalId child, ObjectLocalId newParent, Vector3 localPosition, Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x990B9E0", Offset = "0x990A9E0", VA = "0x18990B9E0")]
		private void ZLJMJHRCRII(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x990B950", Offset = "0x990A950", VA = "0x18990B950")]
		[IteratorStateMachine(typeof(YVNQHFOJUOH))]
		public IEnumerable<IVCTQHGKKFR> ZHDKJQYDPPP(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x990A3F0", Offset = "0x99093F0", VA = "0x18990A3F0")]
		internal IVCTQHGKKFR NFLUGRYMCPY(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9908BE0", Offset = "0x9907BE0", VA = "0x189908BE0")]
		internal ObjectLocalId IETVAKWNWLM(IVCTQHGKKFR a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9909920", Offset = "0x9908920", VA = "0x189909920")]
		private bool MTHFIFJKAHB(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9908390", Offset = "0x9907390", VA = "0x189908390")]
		private bool DZSKCNFPLHZ(BWPYMSYLZBA a, [Out] IVCTQHGKKFR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x990A060", Offset = "0x9909060", VA = "0x18990A060")]
		private IVCTQHGKKFR NFLUGRYMCPY(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9908FE0", Offset = "0x9907FE0", VA = "0x189908FE0")]
		private IVCTQHGKKFR JAGMBGJUCZB(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9908A10", Offset = "0x9907A10", VA = "0x189908A10")]
		private IVCTQHGKKFR HZZAUPLQXDW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x990A740", Offset = "0x9909740", VA = "0x18990A740")]
		private static Guid RVPKEQKPORL(BWPYMSYLZBA a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99082A0", Offset = "0x99072A0", VA = "0x1899082A0")]
		private string DYUIPQRHEVW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9908830", Offset = "0x9907830", VA = "0x189908830")]
		private void GFYGPZOLKLJ(IVCTQHGKKFR a, IVCTQHGKKFR b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99075D0", Offset = "0x99065D0", VA = "0x1899075D0")]
		private void CMQOWXKMNWR(IVCTQHGKKFR a, IVCTQHGKKFR b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9909F50", Offset = "0x9908F50", VA = "0x189909F50")]
		private void MZSFPUNKXKX(IVCTQHGKKFR a, IVCTQHGKKFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99086A0", Offset = "0x99076A0", VA = "0x1899086A0")]
		private void GDRAWZXXNOK(IVCTQHGKKFR a, IVCTQHGKKFR b, RigidTransform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x990BA50", Offset = "0x990AA50", VA = "0x18990BA50")]
		private void ZUQMXVEZTNJ(ObjectLocalId a, IVCTQHGKKFR b, ObjectLocalId c, ObjectLocalId d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9907760", Offset = "0x9906760", VA = "0x189907760")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x990E800", Offset = "0x990D800", VA = "0x18990E800")]
			internal OMConnectableManager CDXMHODZDVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98FE3B0", Offset = "0x98FD3B0", VA = "0x1898FE3B0")]
		public static void RGRSDUGGYET(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98FE360", Offset = "0x98FD360", VA = "0x1898FE360")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0", Slot = "38")]
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
			[Cpp2IlInjected.Address(RVA = "0x990D8E0", Offset = "0x990C8E0", VA = "0x18990D8E0", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IVCTQHGKKFR OHKROXSXNIG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x990BD40", Offset = "0x990AD40", VA = "0x18990BD40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 WLQRRRBQCNM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x990C790", Offset = "0x990B790", VA = "0x18990C790", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Quaternion WAHRDQABFSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x990CDB0", Offset = "0x990BDB0", VA = "0x18990CDB0", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MHISRSVFIZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x990CBD0", Offset = "0x990BBD0", VA = "0x18990CBD0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<IVCTQHGKKFR> MJCBBFOUTJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x990CCE0", Offset = "0x990BCE0", VA = "0x18990CCE0", Slot = "13")]
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
			[Cpp2IlInjected.Address(RVA = "0xDAF8C0", Offset = "0xDAE8C0", VA = "0x180DAF8C0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE92670", Offset = "0xE91670", VA = "0x180E92670", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Transform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x990DAE0", Offset = "0x990CAE0", VA = "0x18990DAE0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x990D800", Offset = "0x990C800", VA = "0x18990D800", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x990D820", Offset = "0x990C820", VA = "0x18990D820", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid PersistenceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x990D940", Offset = "0x990C940", VA = "0x18990D940", Slot = "36")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int PhotonId
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x990DA20", Offset = "0x990CA20", VA = "0x18990DA20", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ShouldSerializeUnparented
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool YRLVANZTLCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x990CED0", Offset = "0x990BED0", VA = "0x18990CED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HierarchyChangeHandler TIZQZOPZFKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x990CE80", Offset = "0x990BE80", VA = "0x18990CE80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x990D2D0", Offset = "0x990C2D0", VA = "0x18990D2D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event HierarchyChangeHandler YEXQUDTBWTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x990C090", Offset = "0x990B090", VA = "0x18990C090", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x990CA60", Offset = "0x990BA60", VA = "0x18990CA60", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HierarchyChangeHandler OJOZQFVWWMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x990CF70", Offset = "0x990BF70", VA = "0x18990CF70", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x990CE10", Offset = "0x990BE10", VA = "0x18990CE10", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RootChangeHandler WGSTAQSEYOI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x990CD10", Offset = "0x990BD10", VA = "0x18990CD10", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x990CC40", Offset = "0x990BC40", VA = "0x18990CC40", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x990D700", Offset = "0x990C700", VA = "0x18990D700")]
		public OMConnectableToolImpl(ObjectLocalId objectId, RigidbodyEx rbex, CPJPZUNDSEN connectableTool, ZVVPWACYWAL[] connectionPoints, RPUGEAJHKCL callbacks, BKQSAGTTXDY connectableManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x990C010", Offset = "0x990B010", VA = "0x18990C010", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "21")]
		public void ZMBUWBZIMLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x990D650", Offset = "0x990C650", VA = "0x18990D650", Slot = "22")]
		public void ZZOWLOOJVJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x990CF20", Offset = "0x990BF20", VA = "0x18990CF20", Slot = "20")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x990BE00", Offset = "0x990AE00", VA = "0x18990BE00", Slot = "25")]
		public void ASRMGYTVTMC(int a, IVCTQHGKKFR b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x990CB00", Offset = "0x990BB00", VA = "0x18990CB00", Slot = "26")]
		public void MCTTWLRPXCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x990D370", Offset = "0x990C370", VA = "0x18990D370", Slot = "27")]
		public void ZCQPJWZNBSE(int a, IVCTQHGKKFR b, int c, [Optional] Vector3? d, [Optional] Quaternion? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x990C7F0", Offset = "0x990B7F0", VA = "0x18990C7F0", Slot = "28")]
		public void IGVBXDHGUPA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x990C0E0", Offset = "0x990B0E0", VA = "0x18990C0E0", Slot = "31")]
		public void CKFNOSAGQQD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x990CFC0", Offset = "0x990BFC0", VA = "0x18990CFC0", Slot = "29")]
		public void WGFOBRPSUUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x990C870", Offset = "0x990B870", VA = "0x18990C870", Slot = "30")]
		public void IRCGDSQSAEG(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x990C6C0", Offset = "0x990B6C0", VA = "0x18990C6C0", Slot = "41")]
		public Vector3 GetConnectionSlotPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x990C590", Offset = "0x990B590", VA = "0x18990C590", Slot = "40")]
		public Vector3 GetConnectionSlotLocalPosition(int slotIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD72050", Offset = "0xD71050", VA = "0x180D72050", Slot = "42")]
		public Color GetConnectionSlotColor(int slotIndex)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x990C4F0", Offset = "0x990B4F0", VA = "0x18990C4F0", Slot = "43")]
		public bool CanConnectTo(int slotIndex, IVCTQHGKKFR otherConnectable, int otherConnectableSlotIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "44")]
		public void ParentChanged(int slotIndex, IVCTQHGKKFR newParentConnectable, int newParentSlot, Vector3 newRelativePosition, Quaternion newRelativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "45")]
		public void ChildAdded(int slotIndex, IVCTQHGKKFR newChildConnectable, int newChildSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "46")]
		public void ChildRemoved(int slotIndex, IVCTQHGKKFR removedChildConnectable, int removedChildSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "47")]
		public void ConnectionModified(int slotIndex, IVCTQHGKKFR parentConnectable, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x990CE60", Offset = "0x990BE60", VA = "0x18990CE60", Slot = "48")]
		public void RootChanged(IVCTQHGKKFR previousRootConnectable, IVCTQHGKKFR newRootConnectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x990D320", Offset = "0x990C320", VA = "0x18990D320", Slot = "23")]
		public void ZCCCJXLXLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x990CAB0", Offset = "0x990BAB0", VA = "0x18990CAB0", Slot = "24")]
		public void LZULKHRJBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x990C040", Offset = "0x990B040", VA = "0x18990C040")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0x98FE260", Offset = "0x98FD260", VA = "0x1898FE260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x98FE210", Offset = "0x98FD210", VA = "0x1898FE210", Slot = "5")]
		private void MMZJSGUTRHN(PPCVAYWFABF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xF6ACF0", Offset = "0xF69CF0", VA = "0x180F6ACF0", Slot = "6")]
		private void IKBYUUMLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9910000", Offset = "0x990F000", VA = "0x189910000", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x99100B0", Offset = "0x990F0B0", VA = "0x1899100B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x990FDF0", Offset = "0x990EDF0", VA = "0x18990FDF0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x990FF50", Offset = "0x990EF50", VA = "0x18990FF50", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x990FEA0", Offset = "0x990EEA0", VA = "0x18990FEA0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9910160", Offset = "0x990F160", VA = "0x189910160", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "26")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "12")]
		public void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA rpcSender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "14")]
		public void SIFQFAPRLAF(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "15")]
		public void WKECLZBLVZA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "16")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "17")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "18")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "19")]
		public void OVQIOTEGCPR(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "20")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "21")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "22")]
		public bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "23")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "24")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "25")]
		public void UYBHEQBSJNC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBF620", Offset = "0xEBE620", VA = "0x180EBF620", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ZMQTUONOMHM YOAWDHXDACN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x98FE520", Offset = "0x98FD520", VA = "0x1898FE520")]
		public static ConnectableConfigData LoadResource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x98FE5E0", Offset = "0x98FD5E0", VA = "0x1898FE5E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FEBD0", Offset = "0x98FDBD0", VA = "0x1898FEBD0")]
		public ConnectableLink(IVCTQHGKKFR connectable, int slot, int parentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x98FEAA0", Offset = "0x98FDAA0", VA = "0x1898FEAA0")]
		public ConnectableLink(IVCTQHGKKFR connectable, int slot, int parentSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x98FEB40", Offset = "0x98FDB40", VA = "0x1898FEB40")]
		public ConnectableLink(IVCTQHGKKFR connectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x98FE630", Offset = "0x98FD630", VA = "0x1898FE630", Slot = "4")]
		public bool Equals(ConnectableLink other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x98FE6E0", Offset = "0x98FD6E0", VA = "0x1898FE6E0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9227CA0", Offset = "0x9226CA0", VA = "0x189227CA0", Slot = "4")]
		public void Initialize(Transform transform, ZMQTUONOMHM linkVisualPrefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x99003A0", Offset = "0x98FF3A0", VA = "0x1899003A0", Slot = "5")]
		public ZMQTUONOMHM VHWCEDIVCJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9900330", Offset = "0x98FF330", VA = "0x189900330", Slot = "6")]
		public void CUHLKDLLLVQ(ZMQTUONOMHM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public TBMIUWRZTOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x990E410", Offset = "0x990D410", VA = "0x18990E410")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9902300", Offset = "0x9901300", VA = "0x189902300")]
		public bool MPQEBZRWRHJ([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9903690", Offset = "0x9902690", VA = "0x189903690")]
		private bool XLUQCRHXLFM([In] ConnectionOperationData data, bool a = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9904100", Offset = "0x9903100", VA = "0x189904100")]
		public LegacyConnectableManagerGraph()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x99020A0", Offset = "0x99010A0", VA = "0x1899020A0", Slot = "5")]
		public void Initialize(BKQSAGTTXDY manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9903660", Offset = "0x9902660", VA = "0x189903660", Slot = "17")]
		public void XCKEUNCGKKW(ConnectableHierarchyTraversalOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9901DE0", Offset = "0x9900DE0", VA = "0x189901DE0", Slot = "12")]
		public void ITRXDAAZGVD(Func<IVCTQHGKKFR, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9901CB0", Offset = "0x9900CB0", VA = "0x189901CB0")]
		private void ITRXDAAZGVD(ULKEYLVDNYS a, Func<IVCTQHGKKFR, bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9901260", Offset = "0x9900260", VA = "0x189901260", Slot = "11")]
		public void DUAWUZFRUGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x99031E0", Offset = "0x99021E0", VA = "0x1899031E0", Slot = "8")]
		public bool VQFGGABWCDA(IVCTQHGKKFR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9902B40", Offset = "0x9901B40", VA = "0x189902B40")]
		private bool ULHSVHEEURV(IVCTQHGKKFR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9903130", Offset = "0x9902130", VA = "0x189903130")]
		private static bool VQFFSLIYUAF(IVCTQHGKKFR a, ULKEYLVDNYS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9903C50", Offset = "0x9902C50", VA = "0x189903C50")]
		private void YSECJMCVFZL(Transform a, ULKEYLVDNYS b, ULKEYLVDNYS[] c, IVCTQHGKKFR d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x99029F0", Offset = "0x99019F0", VA = "0x1899029F0")]
		private ConnectableLink SHPKTQREXLG(Transform a, ConnectableLink b)
		{
			return default(ConnectableLink);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x99026C0", Offset = "0x99016C0", VA = "0x1899026C0")]
		private static bool PJVPKVMPCDR(ULKEYLVDNYS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9901280", Offset = "0x9900280", VA = "0x189901280", Slot = "9")]
		public bool EXTJLETCNXQ(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9901DF0", Offset = "0x9900DF0", VA = "0x189901DF0")]
		private bool IZGGDVFVTCP(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x99024E0", Offset = "0x99014E0", VA = "0x1899024E0")]
		private static void OMZVMTIYVAC(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e, ULKEYLVDNYS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9901870", Offset = "0x9900870", VA = "0x189901870")]
		private void GFYGPZOLKLJ(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9901990", Offset = "0x9900990", VA = "0x189901990")]
		private void HUDGZVZVWHB(ULKEYLVDNYS a, IVCTQHGKKFR b, IVCTQHGKKFR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9901A00", Offset = "0x9900A00", VA = "0x189901A00")]
		private void HUDGZVZVWHB(IVCTQHGKKFR a, IVCTQHGKKFR b, IVCTQHGKKFR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x99011F0", Offset = "0x99001F0", VA = "0x1899011F0")]
		private void CZOYDYYAQTC(IVCTQHGKKFR a, IVCTQHGKKFR b, IVCTQHGKKFR c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x99010F0", Offset = "0x99000F0", VA = "0x1899010F0")]
		private void CZOYDYYAQTC(ULKEYLVDNYS a, IVCTQHGKKFR b, IVCTQHGKKFR c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9900FD0", Offset = "0x98FFFD0", VA = "0x189900FD0")]
		private void CMQOWXKMNWR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9902310", Offset = "0x9901310", VA = "0x189902310")]
		private void MZSFPUNKXKX(BYVLDONWUUJ a, BYVLDONWUUJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9900E70", Offset = "0x98FFE70", VA = "0x189900E70", Slot = "18")]
		public IVCTQHGKKFR CCGBMACTIRE(IVCTQHGKKFR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x99032C0", Offset = "0x99022C0", VA = "0x1899032C0", Slot = "13")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9901A70", Offset = "0x9900A70", VA = "0x189901A70", Slot = "14")]
		public List<IVCTQHGKKFR> IRBHZBUSROB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9902230", Offset = "0x9901230", VA = "0x189902230")]
		protected BYVLDONWUUJ KRQCTMXLWXM(BYVLDONWUUJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9902150", Offset = "0x9901150", VA = "0x189902150")]
		protected ULKEYLVDNYS[] JNAFRJVMYXJ(ULKEYLVDNYS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x99028E0", Offset = "0x99018E0", VA = "0x1899028E0")]
		protected bool QDBQFXIRUFI(IVCTQHGKKFR a, [Out] ULKEYLVDNYS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9900D40", Offset = "0x98FFD40", VA = "0x189900D40", Slot = "15")]
		public bool BVOBDABAYPY(IVCTQHGKKFR a, [Out] ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x99021F0", Offset = "0x99011F0", VA = "0x1899021F0")]
		protected ULKEYLVDNYS JNEZMWSHBXZ(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9902880", Offset = "0x9901880", VA = "0x189902880", Slot = "10")]
		public bool PKQQCLBJPBI(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x99012E0", Offset = "0x99002E0", VA = "0x1899012E0")]
		private bool FICKYSESXOR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x99031F0", Offset = "0x99021F0", VA = "0x1899031F0")]
		private static bool WLVYHKELLZB(ULKEYLVDNYS a, ConnectableLink b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9902300", Offset = "0x9901300", VA = "0x189902300", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD57800", Offset = "0xD56800", VA = "0x180D57800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD57630", Offset = "0xD56630", VA = "0x180D57630")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool OQIZMMIKYRN
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1344CE0", Offset = "0x1343CE0", VA = "0x181344CE0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2875300", Offset = "0x2874300", VA = "0x182875300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool QAZCZKTTUFF
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> PHSEMMXEWWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x9905060", Offset = "0x9904060", VA = "0x189905060", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x99056F0", Offset = "0x99046F0", VA = "0x1899056F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR> ESPFHNIVNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x9904F40", Offset = "0x9903F40", VA = "0x189904F40", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9905000", Offset = "0x9904000", VA = "0x189905000", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<IVCTQHGKKFR, IVCTQHGKKFR, IVCTQHGKKFR> YNVLNJEKCXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9904FA0", Offset = "0x9903FA0", VA = "0x189904FA0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9905B00", Offset = "0x9904B00", VA = "0x189905B00", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9905F30", Offset = "0x9904F30", VA = "0x189905F30")]
		public LegacyConnectableManager(VIGMLMXVCUS container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9904980", Offset = "0x9903980", VA = "0x189904980", Slot = "12")]
		public void Initialize(GameObject gameObject, EYQOTTHXFWR configData, FZKYYFPZNJA rpcService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x99042B0", Offset = "0x99032B0", VA = "0x1899042B0", Slot = "26")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x99058F0", Offset = "0x99048F0", VA = "0x1899058F0", Slot = "13")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9905750", Offset = "0x9904750", VA = "0x189905750", Slot = "14")]
		public void SIFQFAPRLAF(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9905AA0", Offset = "0x9904AA0", VA = "0x189905AA0", Slot = "15")]
		public void WKECLZBLVZA(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9904750", Offset = "0x9903750", VA = "0x189904750", Slot = "22")]
		public bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9904640", Offset = "0x9903640", VA = "0x189904640")]
		internal bool FICKYSESXOR([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9905420", Offset = "0x9904420", VA = "0x189905420")]
		internal bool PYJROHTAUFF([In] ConnectionOperationData data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x99047A0", Offset = "0x99037A0", VA = "0x1899047A0")]
		internal void HVWWPDQUOKH(IVCTQHGKKFR a, int b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9905AA0", Offset = "0x9904AA0", VA = "0x189905AA0")]
		internal bool XGRPLGGSFBJ(IVCTQHGKKFR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9905970", Offset = "0x9904970", VA = "0x189905970")]
		internal bool VOUMPREDAWF(IVCTQHGKKFR a, int b, int c, Vector3 d, Quaternion e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9905BF0", Offset = "0x9904BF0", VA = "0x189905BF0", Slot = "16")]
		public void XAZMFHSBBLP(IVCTQHGKKFR a, HashSet<IVCTQHGKKFR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9904430", Offset = "0x9903430", VA = "0x189904430", Slot = "17")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, Vector3 c, Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9905770", Offset = "0x9904770", VA = "0x189905770", Slot = "18")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9905260", Offset = "0x9904260", VA = "0x189905260", Slot = "19")]
		public void OVQIOTEGCPR(IVCTQHGKKFR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9905CE0", Offset = "0x9904CE0", VA = "0x189905CE0")]
		public void ZVDCCPXOKKG([Optional] DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9905B60", Offset = "0x9904B60", VA = "0x189905B60", Slot = "23")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9905570", Offset = "0x9904570", VA = "0x189905570", Slot = "20")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x99050C0", Offset = "0x99040C0", VA = "0x1899050C0", Slot = "21")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x99058B0", Offset = "0x99048B0", VA = "0x1899058B0", Slot = "25")]
		public void UYBHEQBSJNC(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9904380", Offset = "0x9903380", VA = "0x189904380", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x990F510", Offset = "0x990E510", VA = "0x18990F510")]
		public WVPCFHTLVZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x990F4B0", Offset = "0x990E4B0", VA = "0x18990F4B0")]
		public void SJIKRFQOCBQ(IVCTQHGKKFR a, IVCTQHGKKFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x990F3D0", Offset = "0x990E3D0", VA = "0x18990F3D0")]
		public void FLHXORPIRFO(IVCTQHGKKFR a, IVCTQHGKKFR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x990F430", Offset = "0x990E430", VA = "0x18990F430")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public HXDHDEPNCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x98FEF70", Offset = "0x98FDF70", VA = "0x1898FEF70")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x98FEF60", Offset = "0x98FDF60", VA = "0x1898FEF60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x98FF110", Offset = "0x98FE110", VA = "0x1898FF110")]
		private void OnPhotonPlayerConnected(PlayerId playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x98FF0A0", Offset = "0x98FE0A0", VA = "0x1898FF0A0")]
		private void OnMasterClientSwitched(DDFOJMMWCEL newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x98FF150", Offset = "0x98FE150", VA = "0x1898FF150")]
		public void PTXUJKQHVSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x98FEE60", Offset = "0x98FDE60", VA = "0x1898FEE60")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x990E7A0", Offset = "0x990D7A0", VA = "0x18990E7A0")]
			internal LegacyConnectableManager CDXMHODZDVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x990F690", Offset = "0x990E690", VA = "0x18990F690")]
		public static void RGRSDUGGYET(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x990F610", Offset = "0x990E610", VA = "0x18990F610")]
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
		[Cpp2IlInjected.Address(RVA = "0x9907080", Offset = "0x9906080", VA = "0x189907080")]
		public LegacyConnectableVisualManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x99062C0", Offset = "0x99052C0", VA = "0x1899062C0", Slot = "7")]
		public void Initialize(BJYYMNNMBFI graph, DILYMMXEGIG creator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9906300", Offset = "0x9905300", VA = "0x189906300", Slot = "5")]
		public void MFFMVQWQFQH(BYVLDONWUUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x99066D0", Offset = "0x99056D0", VA = "0x1899066D0", Slot = "9")]
		public void MMLCMDFERBI(BYVLDONWUUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9906C10", Offset = "0x9905C10", VA = "0x189906C10", Slot = "8")]
		public void QFQXFKWCSNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9906DD0", Offset = "0x9905DD0", VA = "0x189906DD0", Slot = "10")]
		public void TDDZCSZQSEF(BYVLDONWUUJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9906AC0", Offset = "0x9905AC0", VA = "0x189906AC0", Slot = "11")]
		public void ORJCSHVEPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9906910", Offset = "0x9905910", VA = "0x189906910")]
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
				[Cpp2IlInjected.Address(RVA = "0x990E290", Offset = "0x990D290", VA = "0x18990E290")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x990E3A0", Offset = "0x990D3A0", VA = "0x18990E3A0")]
			public SerializeNodeInSubgraph(ULKEYLVDNYS currentNode, HashSet<Guid> subgraphPersistenceViewIds, bool isForSave, [Optional] BWPYMSYLZBA parentNodeData, [Optional] BWPYMSYLZBA rootNodeData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x990DEC0", Offset = "0x990CEC0", VA = "0x18990DEC0")]
			public BWPYMSYLZBA GHRXOLGFAHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x990E1D0", Offset = "0x990D1D0", VA = "0x18990E1D0")]
			private BWPYMSYLZBA VUJPJOIMMXM([Out] BWPYMSYLZBA a, [Out] BWPYMSYLZBA b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x990DCC0", Offset = "0x990CCC0", VA = "0x18990DCC0")]
			private BWPYMSYLZBA CKHAEPEOEAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x990E060", Offset = "0x990D060", VA = "0x18990E060")]
			private void PJSUREEUGPC(BWPYMSYLZBA a, BWPYMSYLZBA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x990DB00", Offset = "0x990CB00", VA = "0x18990DB00")]
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
			[Cpp2IlInjected.Address(RVA = "0x9910420", Offset = "0x990F420", VA = "0x189910420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private bool CXJRYLAMYOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x99125E0", Offset = "0x99115E0", VA = "0x1899125E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x9910A70", Offset = "0x990FA70", VA = "0x189910A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9910A00", Offset = "0x990FA00", VA = "0x189910A00")]
		public void Initialize(LegacyConnectableManager manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9911EE0", Offset = "0x9910EE0", VA = "0x189911EE0")]
		public ConnectableGraphData QRADGIJEELY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9911BB0", Offset = "0x9910BB0", VA = "0x189911BB0")]
		public ConnectableGraphData NVULVMBBCNU(HashSet<Guid> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9912600", Offset = "0x9911600", VA = "0x189912600")]
		public void WUOQFOHIUPV(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9910380", Offset = "0x990F380", VA = "0x189910380")]
		public void BDTMIWRUWWH(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9910350", Offset = "0x990F350", VA = "0x189910350")]
		public void AQCKLYSAAFD(ConnectableGraphData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9910D50", Offset = "0x990FD50", VA = "0x189910D50")]
		private void JLFTDNKUAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9912690", Offset = "0x9911690", VA = "0x189912690")]
		private BWPYMSYLZBA WWLEEYANNBS(ULKEYLVDNYS a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9910F30", Offset = "0x990FF30", VA = "0x189910F30")]
		private static void LBVAOMTVOZI(ULKEYLVDNYS a, bool b, BWPYMSYLZBA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9912770", Offset = "0x9911770", VA = "0x189912770")]
		private void ZVRBNFDJXEN(ULKEYLVDNYS a, bool b, BWPYMSYLZBA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9910560", Offset = "0x990F560", VA = "0x189910560")]
		private BWPYMSYLZBA EUTKOIJYZIA(ULKEYLVDNYS a, HashSet<Guid> b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9912170", Offset = "0x9911170", VA = "0x189912170")]
		private bool SPGAXXCTTTU(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9911200", Offset = "0x9910200", VA = "0x189911200")]
		private bool MTHFIFJKAHB(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x99111E0", Offset = "0x99101E0", VA = "0x1899111E0")]
		private bool MQRIRVOROFH(ConnectableGraphData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9912050", Offset = "0x9911050", VA = "0x189912050")]
		private static bool SBBEWRCUOTW(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x99105F0", Offset = "0x990F5F0", VA = "0x1899105F0")]
		public static bool HVISVVVTCCU(BWPYMSYLZBA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9911870", Offset = "0x9910870", VA = "0x189911870")]
		private IVCTQHGKKFR NFLUGRYMCPY(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9910880", Offset = "0x990F880", VA = "0x189910880")]
		private IVCTQHGKKFR HZZAUPLQXDW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9911D50", Offset = "0x9910D50", VA = "0x189911D50")]
		private IVCTQHGKKFR OESXVEZKKBN(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x990A740", Offset = "0x9909740", VA = "0x18990A740")]
		private static Guid RVPKEQKPORL(BWPYMSYLZBA a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9910470", Offset = "0x990F470", VA = "0x189910470")]
		private string DYUIPQRHEVW(BWPYMSYLZBA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x99123F0", Offset = "0x99113F0", VA = "0x1899123F0")]
		private bool TPXVFGYNQMX(ULKEYLVDNYS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9910A90", Offset = "0x990FA90", VA = "0x189910A90")]
		private static void JGSNXASHNPJ(ULKEYLVDNYS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0x98FEC60", Offset = "0x98FDC60", VA = "0x1898FEC60")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ConnectableLink HKTQKUVTINW
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x98FEC30", Offset = "0x98FDC30", VA = "0x1898FEC30")]
			get
			{
				return default(ConnectableLink);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x98FED00", Offset = "0x98FDD00", VA = "0x1898FED00")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ZAPEMMMEAEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9910210", Offset = "0x990F210", VA = "0x189910210")]
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
			[Cpp2IlInjected.Address(RVA = "0x51BA910", Offset = "0x51B9910", VA = "0x1851BA910", Slot = "6")]
			get
			{
				return default(ConnectableLink);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x990EB30", Offset = "0x990DB30", VA = "0x18990EB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private ULKEYLVDNYS PMPLOCZDTJC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x990ECA0", Offset = "0x990DCA0", VA = "0x18990ECA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public BYVLDONWUUJ LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IVCTQHGKKFR TWOBXHQTLOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool ZKGCJSQAZZS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x990F1B0", Offset = "0x990E1B0", VA = "0x18990F1B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool XTOXVSUXOVW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x990EC50", Offset = "0x990DC50", VA = "0x18990EC50", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected ULKEYLVDNYS CNBVPAWZDFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x990F190", Offset = "0x990E190", VA = "0x18990F190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x990F330", Offset = "0x990E330", VA = "0x18990F330")]
		public ULKEYLVDNYS(ConnectableLink a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x990E8A0", Offset = "0x990D8A0", VA = "0x18990E8A0")]
		public ULKEYLVDNYS AZYZTCUIDGT(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x990ED80", Offset = "0x990DD80", VA = "0x18990ED80")]
		public ULKEYLVDNYS RPBZZKLTJWP(ConnectableLink a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x990EF00", Offset = "0x990DF00", VA = "0x18990EF00")]
		public ULKEYLVDNYS Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x990E9E0", Offset = "0x990D9E0", VA = "0x18990E9E0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x990F0E0", Offset = "0x990E0E0", VA = "0x18990F0E0")]
		public ULKEYLVDNYS Reparent(ConnectableLink newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x990F1C0", Offset = "0x990E1C0", VA = "0x18990F1C0")]
		private static void XCKEUNCGKKW(ULKEYLVDNYS a, ConnectableHierarchyTraversalOperation b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x990F320", Offset = "0x990E320", VA = "0x18990F320", Slot = "9")]
		public void XCKEUNCGKKW(ConnectableHierarchyTraversalOperation a, bool b = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x990EB60", Offset = "0x990DB60", VA = "0x18990EB60")]
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
			[Cpp2IlInjected.Address(RVA = "0x98FED70", Offset = "0x98FDD70", VA = "0x1898FED70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static object UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x98FEE20", Offset = "0x98FDE20", VA = "0x1898FEE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x98FEDC0", Offset = "0x98FDDC0", VA = "0x1898FEDC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x98FF3E0", Offset = "0x98FE3E0", VA = "0x1898FF3E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x98FF650", Offset = "0x98FE650", VA = "0x1898FF650", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private RRNetworkView ACYDEJRGHCS
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x99000C0", Offset = "0x98FF0C0", VA = "0x1899000C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PlayerId> ZGZXLVHLDWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x98FF7B0", Offset = "0x98FE7B0", VA = "0x1898FF7B0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x9900290", Offset = "0x98FF290", VA = "0x189900290", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<DDFOJMMWCEL> PILAFUVGYHX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x9900160", Offset = "0x98FF160", VA = "0x189900160", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x98FF5B0", Offset = "0x98FE5B0", VA = "0x1898FF5B0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9900200", Offset = "0x98FF200", VA = "0x189900200", Slot = "10")]
		public void WNCQWZWPKZY(LegacyConnectableManager a, FZKYYFPZNJA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x98FF560", Offset = "0x98FE560", VA = "0x1898FF560", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x98FF440", Offset = "0x98FE440", VA = "0x1898FF440", Slot = "11")]
		public void DOLEIESYIWZ(IVCTQHGKKFR a, IVCTQHGKKFR b, int c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x98FFFA0", Offset = "0x98FEFA0", VA = "0x1898FFFA0", Slot = "12")]
		public void TJRXAIJULLR(IVCTQHGKKFR a, int b, IVCTQHGKKFR c, int d, Vector3 e, Quaternion f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x98FF690", Offset = "0x98FE690", VA = "0x1898FF690", Slot = "13")]
		public void LIZDWKDLMFE(ConnectableGraphData a, [Optional] DDFOJMMWCEL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x98FFA80", Offset = "0x98FEA80", VA = "0x1898FFA80")]
		[RPCMethod]
		private void RpcMasterReparentNodes(IVCTQHGKKFR objectToReparent, int objectToReparentSlotIndex, IVCTQHGKKFR newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x98FF890", Offset = "0x98FE890", VA = "0x1898FF890")]
		[RPCMethod]
		private void RpcMasterModifyNode(IVCTQHGKKFR connectableToModify, IVCTQHGKKFR expectedParent, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x98FFE70", Offset = "0x98FEE70", VA = "0x1898FFE70")]
		[RPCMethod]
		private void RpcReparentNodes(IVCTQHGKKFR objectToReparent, int objectToReparentSlotIndex, IVCTQHGKKFR newParent, int newParentSlot, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x98FFD80", Offset = "0x98FED80", VA = "0x1898FFD80")]
		[RPCMethod]
		private void RpcModifyNode(IVCTQHGKKFR connectableToModify, int childSlotIndex, int parentSlotIndex, Vector3 relativePosition, Quaternion relativeRotation, RPCInfo messageInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x98FF850", Offset = "0x98FE850", VA = "0x1898FF850")]
		[RPCMethod]
		private void RpcDeserializeConnectableGraph(ConnectableGraphData graph)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0x9900BC0", Offset = "0x98FFBC0", VA = "0x189900BC0", Slot = "4")]
		private void YRBTAIFPPLD(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x9900760", Offset = "0x98FF760", VA = "0x189900760", Slot = "5")]
		private void PZGRNIQWQFP(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9900460", Offset = "0x98FF460", VA = "0x189900460", Slot = "6")]
		private void MXRXBKLEUVA(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x99009D0", Offset = "0x98FF9D0", VA = "0x1899009D0", Slot = "7")]
		private void WTGPSKZIUUS(IVCTQHGKKFR a, ConnectableLink b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x99006F0", Offset = "0x98FF6F0", VA = "0x1899006F0", Slot = "8")]
		private ZMQTUONOMHM PDUKXDRHTGJ(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9900690", Offset = "0x98FF690", VA = "0x189900690", Slot = "9")]
		private void NHWQGRLEWCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class AOVIUZVZZPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x337D5E0", Offset = "0x337C5E0", VA = "0x18337D5E0")]
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
