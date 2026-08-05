using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
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
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x715E610", Offset = "0x715D810", VA = "0x18715E610", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71628E0", Offset = "0x7161AE0", VA = "0x1871628E0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71622D0", Offset = "0x71614D0", VA = "0x1871622D0")]
		private void GAEACHOPMAB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7162440", Offset = "0x7161640", VA = "0x187162440")]
		private void KHHBPMJNGGK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71625B0", Offset = "0x71617B0", VA = "0x1871625B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7162920", Offset = "0x7161B20", VA = "0x187162920")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class KOPHKAIBAFM : IHDKGDKFPCD, CIDGALBBDPG
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OBDPKEOBLDK : IEnumerable<JFPMNFAOBHB>, IEnumerable, IEnumerator<JFPMNFAOBHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private JFPMNFAOBHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private CIBKNFGEPGP localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CIBKNFGEPGP <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KOPHKAIBAFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private EKHABGHIANL <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private NDNBDIACCIO.MFGDDOHJPDD <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JFPMNFAOBHB System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC45340", Offset = "0xC44540", VA = "0x180C45340")]
		[DebuggerHidden]
		public OBDPKEOBLDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x715FC80", Offset = "0x715EE80", VA = "0x18715FC80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x715F7C0", Offset = "0x715E9C0", VA = "0x18715F7C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x715F7A0", Offset = "0x715E9A0", VA = "0x18715F7A0")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x715FC30", Offset = "0x715EE30", VA = "0x18715FC30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x715FB80", Offset = "0x715ED80", VA = "0x18715FB80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JFPMNFAOBHB> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x715FB80", Offset = "0x715ED80", VA = "0x18715FB80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BNLNGCPHDEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KOPHKAIBAFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AFIEKEBJKEP nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BNLNGCPHDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x714D220", Offset = "0x714C420", VA = "0x18714D220")]
		internal object KMBMCKDKBFH(AFIEKEBJKEP x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OAHICCIDDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AFIEKEBJKEP child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public BNLNGCPHDEP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public OAHICCIDDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x715F550", Offset = "0x715E750", VA = "0x18715F550")]
		internal object PEPPJNCNCKN((AFIEKEBJKEP child, AFIEKEBJKEP nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly KJMCEDJMPPA HHBJDPOOIIB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly KJMCEDJMPPA NOBBPEPBKAA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly KJMCEDJMPPA ILJJHFENJBN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly KJMCEDJMPPA EKBELDEKDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private DKGIONCBAMG NJLAGILPANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GGFBFEIEEOM FIBCOOGKMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private BGCIOADNHMO ONHOHGNAEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PGLBGKJHLLI CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CGADFIBDDDE BBPIJCGBGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HEKAFONNIOP CPBDPEKDPAB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HOKILEEDJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAA2740", Offset = "0xAA1940", VA = "0x180AA2740", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAA1A60", Offset = "0xAA0C60", VA = "0x180AA1A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GKALAAGIOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<JFPMNFAOBHB, JFPMNFAOBHB> HLPMCEJPPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x715A870", Offset = "0x7159A70", VA = "0x18715A870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7156E10", Offset = "0x7156010", VA = "0x187156E10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<JFPMNFAOBHB, JFPMNFAOBHB> BMAPPMGFBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7156D60", Offset = "0x7155F60", VA = "0x187156D60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71598C0", Offset = "0x7158AC0", VA = "0x1871598C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<JFPMNFAOBHB, JFPMNFAOBHB, JFPMNFAOBHB> LCPCGPHFOOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7156830", Offset = "0x7155A30", VA = "0x187156830", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71575C0", Offset = "0x71567C0", VA = "0x1871575C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x715AA90", Offset = "0x7159C90", VA = "0x18715AA90")]
	public KOPHKAIBAFM(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7156EC0", Offset = "0x71560C0", VA = "0x187156EC0", Slot = "12")]
	public void GGPOBANFNOP(GameObject GBMEGJCINPI, HHNJGBMFCBP IJOPOJOLDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71565C0", Offset = "0x71557C0", VA = "0x1871565C0", Slot = "26")]
	public void APIIJJHOIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7156260", Offset = "0x7155460", VA = "0x187156260", Slot = "22")]
	public bool AGGNHKPAEGN(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7157130", Offset = "0x7156330", VA = "0x187157130")]
	private void GNLNMBMLELD(CIBKNFGEPGP KONMIAGGOKA, CIBKNFGEPGP OPECBFEDDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7157C10", Offset = "0x7156E10", VA = "0x187157C10")]
	private void IBFGAIAINIJ(CIBKNFGEPGP KONMIAGGOKA, CIBKNFGEPGP GEIHGHJICHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7158150", Offset = "0x7157350", VA = "0x187158150")]
	private void JDEEACMIGOO(CIBKNFGEPGP KONMIAGGOKA, CIBKNFGEPGP GEIHGHJICHB, CIBKNFGEPGP OPECBFEDDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7159CA0", Offset = "0x7158EA0", VA = "0x187159CA0")]
	private void ODJPCNOBJIP(CIBKNFGEPGP KONMIAGGOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "13")]
	public void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7158590", Offset = "0x7157790", VA = "0x187158590", Slot = "14")]
	public void JMFBCAGPLCG(JFPMNFAOBHB MMPPGBNJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "15")]
	public void GLLHIOFIBAC(JFPMNFAOBHB MMPPGBNJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7159AB0", Offset = "0x7158CB0", VA = "0x187159AB0", Slot = "17")]
	public void NLNBIINCCOH(JFPMNFAOBHB MMPPGBNJMIM, JFPMNFAOBHB OMKHLJJKIFD, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7159970", Offset = "0x7158B70", VA = "0x187159970")]
	public void NLNBIINCCOH(CIBKNFGEPGP KGPDHHGDIDC, CIBKNFGEPGP OMKHLJJKIFD, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7159C10", Offset = "0x7158E10", VA = "0x187159C10")]
	public void NNLEFBGKLML(JFPMNFAOBHB MMPPGBNJMIM, float KCJANBMNMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7156460", Offset = "0x7155660", VA = "0x187156460", Slot = "18")]
	public void AKMNDGKOAJP(JFPMNFAOBHB OCGJCFGAENH, int EPMCAEJEBMC, JFPMNFAOBHB CCGMLHIOGLH, int FKAJKLLMEMD, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7159810", Offset = "0x7158A10", VA = "0x187159810")]
	private float MOJPBLILOGD(CIBKNFGEPGP KGPDHHGDIDC, CIBKNFGEPGP DBEHKFODEEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x71562B0", Offset = "0x71554B0", VA = "0x1871562B0")]
	public void AKMNDGKOAJP(CIBKNFGEPGP KGPDHHGDIDC, CIBKNFGEPGP DBEHKFODEEL, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO, bool GIMMJOMIACG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x71563F0", Offset = "0x71555F0", VA = "0x1871563F0")]
	public void AKMNDGKOAJP(CIBKNFGEPGP KGPDHHGDIDC, CIBKNFGEPGP DBEHKFODEEL, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO, float KCJANBMNMAB, bool GIMMJOMIACG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7157FE0", Offset = "0x71571E0", VA = "0x187157FE0", Slot = "19")]
	public void IHJIHEGNGLF(JFPMNFAOBHB MMPPGBNJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7155FD0", Offset = "0x71551D0", VA = "0x187155FD0")]
	public bool AAANLMOFNCM(CIBKNFGEPGP IMMLHGFCKGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x71569F0", Offset = "0x7155BF0", VA = "0x1871569F0", Slot = "16")]
	public void EJILHKFKNJA(JFPMNFAOBHB MMPPGBNJMIM, HashSet<JFPMNFAOBHB> DBHANFCIFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "20")]
	public OKPJMNODPLB ICELICMJFGG(bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "21")]
	public OKPJMNODPLB GFGNOHAICPL(HashSet<Guid> MLPOPLELKDE, bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7156BF0", Offset = "0x7155DF0", VA = "0x187156BF0", Slot = "23")]
	public void ENIPPDEKKNM(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7157E30", Offset = "0x7157030", VA = "0x187157E30", Slot = "24")]
	public void IBNGCAEFBIL(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7156810", Offset = "0x7155A10", VA = "0x187156810", Slot = "25")]
	public void CHMJHDGOCOJ(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x715A4B0", Offset = "0x71596B0", VA = "0x18715A4B0")]
	private void PLAFOPJFOBE(CIBKNFGEPGP KGPDHHGDIDC, CIBKNFGEPGP DBEHKFODEEL, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO, float KCJANBMNMAB, bool GIMMJOMIACG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7158890", Offset = "0x7157A90", VA = "0x187158890")]
	private void KAHEJHBEHJD(CIBKNFGEPGP KGPDHHGDIDC, CIBKNFGEPGP BCPOGOCDLFM, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7156C60", Offset = "0x7155E60", VA = "0x187156C60")]
	private void FLDDPLBPAEH(CIBKNFGEPGP KGPDHHGDIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7156CD0", Offset = "0x7155ED0", VA = "0x187156CD0")]
	[IteratorStateMachine(typeof(OBDPKEOBLDK))]
	public IEnumerable<JFPMNFAOBHB> GAKOEEDCEPN(CIBKNFGEPGP IMMLHGFCKGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x71596E0", Offset = "0x71588E0", VA = "0x1871596E0")]
	internal JFPMNFAOBHB MJECKFINAKN(CIBKNFGEPGP IMMLHGFCKGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7157EA0", Offset = "0x71570A0", VA = "0x187157EA0")]
	internal CIBKNFGEPGP ICINLELOAKG(JFPMNFAOBHB MMPPGBNJMIM)
	{
		return default(CIBKNFGEPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7157670", Offset = "0x7156870", VA = "0x187157670")]
	private bool HKICGHBDMCF(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x715A810", Offset = "0x7159A10", VA = "0x18715A810")]
	private bool PMMMONALFNB(AFIEKEBJKEP HLMPJHIDIOP, [Out] JFPMNFAOBHB DBEHKFODEEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7159340", Offset = "0x7158540", VA = "0x187159340")]
	private JFPMNFAOBHB MJECKFINAKN(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x715A330", Offset = "0x7159530", VA = "0x18715A330")]
	private JFPMNFAOBHB PJGLPCPALAM(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x71583B0", Offset = "0x71575B0", VA = "0x1871583B0")]
	private JFPMNFAOBHB JFAMNAHIECI(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7154E10", Offset = "0x7154010", VA = "0x187154E10")]
	private static Guid JEFPCKMPAGG(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x71574D0", Offset = "0x71566D0", VA = "0x1871574D0")]
	private string HALOMLFJKCL(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7157340", Offset = "0x7156540", VA = "0x187157340")]
	private void GPMNJDFOJPO(JFPMNFAOBHB KGPDHHGDIDC, JFPMNFAOBHB BCPOGOCDLFM, RigidTransform CDDDAJLNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7159020", Offset = "0x7158220", VA = "0x187159020")]
	private void LCIGICGMINM(JFPMNFAOBHB BCPOGOCDLFM, JFPMNFAOBHB KGPDHHGDIDC, RigidTransform CDDDAJLNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x71567B0", Offset = "0x71559B0", VA = "0x1871567B0")]
	private void BNJOPKCIODJ(JFPMNFAOBHB PBJPKNOEMPL, JFPMNFAOBHB KGPDHHGDIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x71591B0", Offset = "0x71583B0", VA = "0x1871591B0")]
	private void MELAKEIMLLN(JFPMNFAOBHB KGPDHHGDIDC, JFPMNFAOBHB DBEHKFODEEL, RigidTransform CDDDAJLNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x71568E0", Offset = "0x7155AE0", VA = "0x1871568E0")]
	private void CLFGNGMJIBD(CIBKNFGEPGP IMMLHGFCKGF, JFPMNFAOBHB MMPPGBNJMIM, CIBKNFGEPGP GEIHGHJICHB, CIBKNFGEPGP OPECBFEDDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x715A0B0", Offset = "0x71592B0", VA = "0x18715A0B0")]
	private void OFOBMDGNPKG(CIBKNFGEPGP IMMLHGFCKGF, JFPMNFAOBHB MMPPGBNJMIM, JFPMNFAOBHB MBKAHLGIFDH, JFPMNFAOBHB PMFJAKONNCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CEPIBMLJIEL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PBCBLFODGIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JBPONICDCIO container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PBCBLFODGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x715FCE0", Offset = "0x715EEE0", VA = "0x18715FCE0")]
		internal KOPHKAIBAFM BFCJOOKEHEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7150C00", Offset = "0x714FE00", VA = "0x187150C00")]
	public static void PFOGINCAPEF(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7150D80", Offset = "0x714FF80", VA = "0x187150D80")]
	public static void PHJGFDOCIEI(JBPONICDCIO CKNPDKKKGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JCKOCMHOKGN : GFNCCJJAKFG, INBOGNOIGIA
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx MNIAPDGOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly KOPHKAIBAFM PDPCFOAACJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly BPBPIDNAEEA JCCAOAFNGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly JODMEBBEKAM CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly NOMLBPALIHJ[] EFEJLCNBCFA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(CIBKNFGEPGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JFPMNFAOBHB HAMAEGCECOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7153140", Offset = "0x7152340", VA = "0x187153140", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JFPMNFAOBHB ELMICMCMCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7152860", Offset = "0x7151A60", VA = "0x187152860", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 DMIADLFPMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7152E70", Offset = "0x7152070", VA = "0x187152E70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion KEIEGJBBIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x71519F0", Offset = "0x7150BF0", VA = "0x1871519F0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KFGDMFKOFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7152550", Offset = "0x7151750", VA = "0x187152550", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<JFPMNFAOBHB> CBPLFIKHFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7151A50", Offset = "0x7150C50", VA = "0x187151A50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool FDFFOEAHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xABD790", Offset = "0xABC990", VA = "0x180ABD790", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAC3940", Offset = "0xAC2B40", VA = "0x180AC3940", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7153340", Offset = "0x7152540", VA = "0x187153340", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject EBDEMNLMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B397F0", Offset = "0x2B389F0", VA = "0x182B397F0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7153080", Offset = "0x7152280", VA = "0x187153080", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid EEGJKMJMJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x71531A0", Offset = "0x71523A0", VA = "0x1871531A0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AAABFMMDFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7153280", Offset = "0x7152480", VA = "0x187153280", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NHDPFFBLNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool BJEIDKMKKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7152810", Offset = "0x7151A10", VA = "0x187152810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event INAMNNJPDKF CHPCGAOEADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7151D80", Offset = "0x7150F80", VA = "0x187151D80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7151DE0", Offset = "0x7150FE0", VA = "0x187151DE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event INAMNNJPDKF CMEIMFKLHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7151F40", Offset = "0x7151140", VA = "0x187151F40", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7151E40", Offset = "0x7151040", VA = "0x187151E40", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event INAMNNJPDKF FHPGPCDJIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7151580", Offset = "0x7150780", VA = "0x187151580", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7152730", Offset = "0x7151930", VA = "0x187152730", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event DOFAEMAODGP IKDBIFICCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x71525C0", Offset = "0x71517C0", VA = "0x1871525C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7151EA0", Offset = "0x71510A0", VA = "0x187151EA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7152F80", Offset = "0x7152180", VA = "0x187152F80")]
	public JCKOCMHOKGN(CIBKNFGEPGP MMGDIFNEOOE, RigidbodyEx MNIAPDGOICH, BPBPIDNAEEA JCCAOAFNGPI, NOMLBPALIHJ[] EFEJLCNBCFA, JODMEBBEKAM CKNLAJJPLCN, IHDKGDKFPCD PDPCFOAACJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7152C50", Offset = "0x7151E50", VA = "0x187152C50", Slot = "19")]
	public void OPOIMAMNCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "21")]
	public void MHLKJENICII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DCC0", Offset = "0x6F4CEC0", VA = "0x186F4DCC0", Slot = "22")]
	public void OAJPBAHDKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7152500", Offset = "0x7151700", VA = "0x187152500", Slot = "20")]
	public void HFJDLLOGLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7151B70", Offset = "0x7150D70", VA = "0x187151B70", Slot = "25")]
	public void DHOHEBEBCLA(int EGJOLCEKGFE, JFPMNFAOBHB CCGMLHIOGLH, int GMONJLDKGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7152660", Offset = "0x7151860", VA = "0x187152660", Slot = "26")]
	public void LAHDGJHMOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7152920", Offset = "0x7151B20", VA = "0x187152920", Slot = "27")]
	public void NDBBKIHEPLP(int EGJOLCEKGFE, JFPMNFAOBHB OCGJCFGAENH, int IOKAOFLAFMC, [Optional] Vector3? FAJAPJLLOIA, [Optional] Quaternion? MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7152790", Offset = "0x7151990", VA = "0x187152790", Slot = "28")]
	public void MNCMCKDOHLL(JFPMNFAOBHB OCGJCFGAENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x71515E0", Offset = "0x71507E0", VA = "0x1871515E0", Slot = "31")]
	public void ALKBKFFIFIF(Vector3 MPLPJMOLPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x71521F0", Offset = "0x71513F0", VA = "0x1871521F0", Slot = "29")]
	public void HBBPMPGPPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7152C80", Offset = "0x7151E80", VA = "0x187152C80", Slot = "30")]
	public void PCGKGIHONKM(int CPLNODNGKGB, Vector3 DLAJPPBHBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7152120", Offset = "0x7151320", VA = "0x187152120", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int EGJOLCEKGFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7151FF0", Offset = "0x71511F0", VA = "0x187151FF0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int EGJOLCEKGFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA960D0", Offset = "0xA952D0", VA = "0x180A960D0", Slot = "42")]
	public Color GetConnectionSlotColor(int EGJOLCEKGFE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7151A80", Offset = "0x7150C80", VA = "0x187151A80", Slot = "43")]
	public bool CanConnectTo(int EGJOLCEKGFE, JFPMNFAOBHB BDALGDEDBBJ, int IFDHEKKDKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "44")]
	public void ParentChanged(int EGJOLCEKGFE, JFPMNFAOBHB FIHJHPIGINN, int FNGLKOIMEBA, Vector3 BALOHACICAN, Quaternion BODAMLEIAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "45")]
	public void ChildAdded(int EGJOLCEKGFE, JFPMNFAOBHB OFAPMNDALNB, int EKJDLNAJKCE, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "46")]
	public void ChildRemoved(int EGJOLCEKGFE, JFPMNFAOBHB CCGLPDHBLPE, int BPHOMOCBLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "47")]
	public void ConnectionModified(int EGJOLCEKGFE, JFPMNFAOBHB CCGMLHIOGLH, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7152ED0", Offset = "0x71520D0", VA = "0x187152ED0", Slot = "48")]
	public void RootChanged(JFPMNFAOBHB EFAHFPHPMKN, JFPMNFAOBHB EEDMNFEJGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7151FA0", Offset = "0x71511A0", VA = "0x187151FA0", Slot = "23")]
	public void GCJBENHENND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7152C00", Offset = "0x7151E00", VA = "0x187152C00", Slot = "24")]
	public void NMNDBMBAEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7151B20", Offset = "0x7150D20", VA = "0x187151B20")]
	private void DDBIPINGMMD(bool CIOJMJACCIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(PKMEKNGHOPI), new string[] { })]
public class PKLOMHOANNA : PKMEKNGHOPI, CDKIFFPDAFF, AGGHCDPFEAK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HKGFAPBOCCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PKLOMHOANNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public NDNBDIACCIO localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HKGFAPBOCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x71512D0", Offset = "0x71504D0", VA = "0x1871512D0")]
		internal void NELKAFCDOOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[DependsOn]
	private MOPGAAPEFGA DNIPNOKEENP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object DFNNCNOGOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7161E80", Offset = "0x7161080", VA = "0x187161E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7161F10", Offset = "0x7161110", VA = "0x187161F10", Slot = "5")]
	public void IKGHGCHDMGM(NDNBDIACCIO PPCLEJEKIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7162070", Offset = "0x7161270", VA = "0x187162070", Slot = "6")]
	private void MDGJKGBLCGG(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xF73BA0", Offset = "0xF72DA0", VA = "0x180F73BA0", Slot = "7")]
	private void DEIJODOHECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public PKLOMHOANNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(IHDKGDKFPCD), new string[] { "Ignore", "Mock" })]
public class KKAJFLJEJDL : IHDKGDKFPCD, CIDGALBBDPG
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HOKILEEDJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GKALAAGIOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<JFPMNFAOBHB, JFPMNFAOBHB> HLPMCEJPPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7155F20", Offset = "0x7155120", VA = "0x187155F20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7155D10", Offset = "0x7154F10", VA = "0x187155D10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<JFPMNFAOBHB, JFPMNFAOBHB> BMAPPMGFBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7155C60", Offset = "0x7154E60", VA = "0x187155C60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7155E70", Offset = "0x7155070", VA = "0x187155E70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<JFPMNFAOBHB, JFPMNFAOBHB, JFPMNFAOBHB> LCPCGPHFOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7155BB0", Offset = "0x7154DB0", VA = "0x187155BB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7155DC0", Offset = "0x7154FC0", VA = "0x187155DC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "26")]
	public void APIIJJHOIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "12")]
	public void GGPOBANFNOP(GameObject GBMEGJCINPI, HHNJGBMFCBP IJOPOJOLDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "13")]
	public void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "14")]
	public void JMFBCAGPLCG(JFPMNFAOBHB MMPPGBNJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "15")]
	public void GLLHIOFIBAC(JFPMNFAOBHB MMPPGBNJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "16")]
	public void EJILHKFKNJA(JFPMNFAOBHB MMPPGBNJMIM, HashSet<JFPMNFAOBHB> DBHANFCIFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "17")]
	public void NLNBIINCCOH(JFPMNFAOBHB MMPPGBNJMIM, JFPMNFAOBHB OMKHLJJKIFD, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "18")]
	public void AKMNDGKOAJP(JFPMNFAOBHB MMPPGBNJMIM, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "19")]
	public void IHJIHEGNGLF(JFPMNFAOBHB MMPPGBNJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "20")]
	public OKPJMNODPLB ICELICMJFGG(bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "21")]
	public OKPJMNODPLB GFGNOHAICPL(HashSet<Guid> MLPOPLELKDE, bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "22")]
	public bool AGGNHKPAEGN(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "23")]
	public void ENIPPDEKKNM(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "24")]
	public void IBNGCAEFBIL(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "25")]
	public void CHMJHDGOCOJ(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public KKAJFLJEJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JFPMNFAOBHB : INBOGNOIGIA, IEquatable<JFPMNFAOBHB>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface INBOGNOIGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JFPMNFAOBHB HAMAEGCECOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject EBDEMNLMABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid EEGJKMJMJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int AAABFMMDFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CIBKNFGEPGP FJPNJEFPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NHDPFFBLNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int EGJOLCEKGFE);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int EGJOLCEKGFE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int EGJOLCEKGFE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int EGJOLCEKGFE, JFPMNFAOBHB BDALGDEDBBJ, int BHOIPOKLLPH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int EGJOLCEKGFE, JFPMNFAOBHB FIHJHPIGINN, int FNGLKOIMEBA, Vector3 BALOHACICAN, Quaternion BODAMLEIAGB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int EGJOLCEKGFE, JFPMNFAOBHB OFAPMNDALNB, int EKJDLNAJKCE, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int EGJOLCEKGFE, JFPMNFAOBHB CCGLPDHBLPE, int BPHOMOCBLBD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int EGJOLCEKGFE, JFPMNFAOBHB CCGMLHIOGLH, int ANAIPGCGOGC, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(JFPMNFAOBHB EFAHFPHPMKN, JFPMNFAOBHB EEDMNFEJGIO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IHDKGDKFPCD : CIDGALBBDPG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HOKILEEDJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GKALAAGIOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<JFPMNFAOBHB, JFPMNFAOBHB> HLPMCEJPPAC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JFPMNFAOBHB, JFPMNFAOBHB> BMAPPMGFBPL;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JFPMNFAOBHB, JFPMNFAOBHB, JFPMNFAOBHB> LCPCGPHFOOF;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GGPOBANFNOP(GameObject GBMEGJCINPI, HHNJGBMFCBP IJOPOJOLDKM);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MEIPIBBEBLB();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JMFBCAGPLCG(JFPMNFAOBHB MMPPGBNJMIM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GLLHIOFIBAC(JFPMNFAOBHB MMPPGBNJMIM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EJILHKFKNJA(JFPMNFAOBHB MMPPGBNJMIM, HashSet<JFPMNFAOBHB> DBHANFCIFEC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NLNBIINCCOH(JFPMNFAOBHB MMPPGBNJMIM, JFPMNFAOBHB OMKHLJJKIFD, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKMNDGKOAJP(JFPMNFAOBHB MMPPGBNJMIM, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IHJIHEGNGLF(JFPMNFAOBHB MMPPGBNJMIM);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OKPJMNODPLB ICELICMJFGG(bool CACIOKGKEAM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	OKPJMNODPLB GFGNOHAICPL(HashSet<Guid> MLPOPLELKDE, bool CACIOKGKEAM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool AGGNHKPAEGN(AFIEKEBJKEP HLMPJHIDIOP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ENIPPDEKKNM(OKPJMNODPLB CEJADBPEGGM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IBNGCAEFBIL(OKPJMNODPLB CEJADBPEGGM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CHMJHDGOCOJ(OKPJMNODPLB CEJADBPEGGM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PGLBGKJHLLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OLFEDGGGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JFPMNFAOBHB JFAMNAHIECI(int MNNPDBAAOAM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JFPMNFAOBHB PJGLPCPALAM(Guid CNIJBEBMEEE);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KKCBACHKAPI(JFPMNFAOBHB MMPPGBNJMIM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KKODOPNLFAL();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void APCNPPDDPEI(JFPMNFAOBHB JCCAOAFNGPI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface JODMEBBEKAM
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJEIDKMKKIA(BPBPIDNAEEA JCCAOAFNGPI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBKLELCKENC(BPBPIDNAEEA JCCAOAFNGPI);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string CPMOAGNJNJD(BPBPIDNAEEA JCCAOAFNGPI);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid CCJAEHBPONA(BPBPIDNAEEA JCCAOAFNGPI);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NOFCICMHMIF(BPBPIDNAEEA JCCAOAFNGPI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNFGDOCIJBE(BPBPIDNAEEA JCCAOAFNGPI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void INAMNNJPDKF(JFPMNFAOBHB OCGJCFGAENH, int OIJKKPMCKNP, JFPMNFAOBHB CCGMLHIOGLH, int GBMGFDAMKMA, [Optional] Vector3? FAJAPJLLOIA, [Optional] Quaternion? MGLAJONKDHA);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void DOFAEMAODGP(JFPMNFAOBHB EFAHFPHPMKN, JFPMNFAOBHB EEDMNFEJGIO);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BPBPIDNAEEA : JFPMNFAOBHB, INBOGNOIGIA, IEquatable<JFPMNFAOBHB>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GFNCCJJAKFG : INBOGNOIGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JFPMNFAOBHB ELMICMCMCMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<JFPMNFAOBHB> CBPLFIKHFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 DMIADLFPMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion KEIEGJBBIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool KFGDMFKOFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FDFFOEAHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event INAMNNJPDKF CHPCGAOEADK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event INAMNNJPDKF CMEIMFKLHGD;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event INAMNNJPDKF FHPGPCDJIGP;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event DOFAEMAODGP IKDBIFICCBP;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OPOIMAMNCED();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HFJDLLOGLKA();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MHLKJENICII();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OAJPBAHDKEA();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GCJBENHENND();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NMNDBMBAEMD();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DHOHEBEBCLA(int EGJOLCEKGFE, JFPMNFAOBHB CCGMLHIOGLH, int GMONJLDKGPL);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LAHDGJHMOFH();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NDBBKIHEPLP(int EGJOLCEKGFE, JFPMNFAOBHB OCGJCFGAENH, int IOKAOFLAFMC, [Optional] Vector3? FAJAPJLLOIA, [Optional] Quaternion? MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MNCMCKDOHLL(JFPMNFAOBHB OCGJCFGAENH);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HBBPMPGPPAK();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PCGKGIHONKM(int CPLNODNGKGB, Vector3 DLAJPPBHBJG);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ALKBKFFIFIF(Vector3 MPLPJMOLPPB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NOMLBPALIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 COAPDLPHMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HHNJGBMFCBP
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool FKMBIHPLKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JMDJICOIHPM IFGKJGDBBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, HHNJGBMFCBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xBB5FE0", Offset = "0xBB51E0", VA = "0x180BB5FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JMDJICOIHPM LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7150F60", Offset = "0x7150160", VA = "0x187150F60")]
		public static ConnectableConfigData JJHHOOCHFJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7151020", Offset = "0x7150220", VA = "0x187151020")]
		public ConnectableConfigData(LegacyConnectableLinkVisual EPBFLMGMPCM, bool MAJBHALJHNJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BDAIGNBPFDD : IEquatable<BDAIGNBPFDD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JFPMNFAOBHB MMPPGBNJMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int PPBIBKDPFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int ANAIPGCGOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 FAJAPJLLOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion MGLAJONKDHA;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x714D120", Offset = "0x714C320", VA = "0x18714D120")]
	public BDAIGNBPFDD(JFPMNFAOBHB MMPPGBNJMIM, int PPBIBKDPFPJ, int ANAIPGCGOGC, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x714D180", Offset = "0x714C380", VA = "0x18714D180")]
	public BDAIGNBPFDD(JFPMNFAOBHB MMPPGBNJMIM, int PPBIBKDPFPJ, int ANAIPGCGOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x714D090", Offset = "0x714C290", VA = "0x18714D090")]
	public BDAIGNBPFDD(JFPMNFAOBHB MMPPGBNJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x714CC20", Offset = "0x714BE20", VA = "0x18714CC20", Slot = "4")]
	public bool Equals(BDAIGNBPFDD JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x714CCD0", Offset = "0x714BED0", VA = "0x18714CCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class MGHMMBHNPGH : MLPIHJPBDFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform MCPAEAAAAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private JMDJICOIHPM GCANOCOKGCG;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB180", Offset = "0x6BDA380", VA = "0x186BDB180", Slot = "4")]
	public void GGPOBANFNOP(Transform MCPAEAAAAAM, JMDJICOIHPM GCANOCOKGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x715F350", Offset = "0x715E550", VA = "0x18715F350", Slot = "5")]
	public JMDJICOIHPM OMPLPLCBCJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x715F2E0", Offset = "0x715E4E0", VA = "0x18715F2E0", Slot = "6")]
	public void GMCPCAFIKKI(JMDJICOIHPM BELFHIJFLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public MGHMMBHNPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class CDOCEMIFLGG : IDisposable, OLDHPBBOAIA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CJNKDAADLBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JFPMNFAOBHB oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JFPMNFAOBHB newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CJNKDAADLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7150DD0", Offset = "0x714FFD0", VA = "0x187150DD0")]
		internal bool MOCELGLMGMN(BACKDIOGIEB node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly MAENKGKFCOP OPKOMNDDEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private IPFLNBFKCKB PLJCEHOIAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private EOKCDFJKPPC LAMNNDKOJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool MAJBHALJHNJ;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly KJMCEDJMPPA ACFPPHJHIAE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public BACKDIOGIEB KMOBICEOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x714D6C0", Offset = "0x714C8C0", VA = "0x18714D6C0")]
	public bool IJNDHNBNBMH([In] JFANEGAIKFD LFDKFEEPNFP, bool AEGDCNCGCLB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x714EDE0", Offset = "0x714DFE0", VA = "0x18714EDE0")]
	private bool HIJDNOABCJI([In] JFANEGAIKFD LFDKFEEPNFP, bool AEGDCNCGCLB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7150A30", Offset = "0x714FC30", VA = "0x187150A30")]
	public CDOCEMIFLGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x714E3D0", Offset = "0x714D5D0", VA = "0x18714E3D0", Slot = "5")]
	public void GGPOBANFNOP(IHDKGDKFPCD ODPBGAGOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x714FE80", Offset = "0x714F080", VA = "0x18714FE80", Slot = "17")]
	public void KPLPFOKOCCI(FHFCAMFCBGM FOCHKIPOIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x714F650", Offset = "0x714E850", VA = "0x18714F650", Slot = "12")]
	public void INMJIPKJOOH(Func<JFPMNFAOBHB, bool> PKHGBGJDOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x714F660", Offset = "0x714E860", VA = "0x18714F660")]
	private void INMJIPKJOOH(MAENKGKFCOP NGCBLOEDNKL, Func<JFPMNFAOBHB, bool> PKHGBGJDOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7150630", Offset = "0x714F830", VA = "0x187150630", Slot = "11")]
	public void OILIDGMAAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x714EDD0", Offset = "0x714DFD0", VA = "0x18714EDD0", Slot = "8")]
	public bool HIGJMLLNGND(JFPMNFAOBHB CJENFMDLKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x714E7E0", Offset = "0x714D9E0", VA = "0x18714E7E0")]
	private bool HDLGHIHHLBA(JFPMNFAOBHB LOKAOBMBEND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x714DE90", Offset = "0x714D090", VA = "0x18714DE90")]
	private static bool CFOBOMAEGKH(JFPMNFAOBHB LOKAOBMBEND, MAENKGKFCOP CIBFPAHHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x714D8E0", Offset = "0x714CAE0", VA = "0x18714D8E0")]
	private void BLFCLFLFLAD(Transform BEKIFECBEEN, MAENKGKFCOP CLPDMHBIPPA, MAENKGKFCOP[] NLIJJOEPMIG, JFPMNFAOBHB AEPGKOFOFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7150650", Offset = "0x714F850", VA = "0x187150650")]
	private BDAIGNBPFDD PIKGJDOOCLH(Transform DOLIBLCAKGH, BDAIGNBPFDD JHKGLFOPEHG)
	{
		return default(BDAIGNBPFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x71507A0", Offset = "0x714F9A0", VA = "0x1871507A0")]
	private static bool PMEMNBABOBI(MAENKGKFCOP CIBFPAHHJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x71501B0", Offset = "0x714F3B0", VA = "0x1871501B0", Slot = "9")]
	public bool MMJDCLFJJCB(JFPMNFAOBHB BOCFEMFFHOE, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x714F3A0", Offset = "0x714E5A0", VA = "0x18714F3A0")]
	private bool IBMHBNHEOJN(JFPMNFAOBHB BOCFEMFFHOE, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x714FFD0", Offset = "0x714F1D0", VA = "0x18714FFD0")]
	private static void MJHPGNPILLP(JFPMNFAOBHB BOCFEMFFHOE, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA, MAENKGKFCOP KIEJFHMJPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x714E6C0", Offset = "0x714D8C0", VA = "0x18714E6C0")]
	private void GPMNJDFOJPO(JFPMNFAOBHB CEOKJFCLBMG, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x714D870", Offset = "0x714CA70", VA = "0x18714D870")]
	private void AODKGMHNNLN(MAENKGKFCOP NGCBLOEDNKL, JFPMNFAOBHB MBKAHLGIFDH, JFPMNFAOBHB PMFJAKONNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x714D800", Offset = "0x714CA00", VA = "0x18714D800")]
	private void AODKGMHNNLN(JFPMNFAOBHB MMPPGBNJMIM, JFPMNFAOBHB MBKAHLGIFDH, JFPMNFAOBHB PMFJAKONNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x71502E0", Offset = "0x714F4E0", VA = "0x1871502E0")]
	private void OFOBMDGNPKG(JFPMNFAOBHB MMPPGBNJMIM, JFPMNFAOBHB MBKAHLGIFDH, JFPMNFAOBHB PMFJAKONNCF, bool FIKKDFDGGOE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7150350", Offset = "0x714F550", VA = "0x187150350")]
	private void OFOBMDGNPKG(MAENKGKFCOP DONMCNODAED, JFPMNFAOBHB AEPGKOFOFFP, JFPMNFAOBHB EEDMNFEJGIO, bool FIKKDFDGGOE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x714FEB0", Offset = "0x714F0B0", VA = "0x18714FEB0")]
	private void LCIGICGMINM(JFPMNFAOBHB KGPDHHGDIDC, int IOKAOFLAFMC, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x714DCC0", Offset = "0x714CEC0", VA = "0x18714DCC0")]
	private void BNJOPKCIODJ(BACKDIOGIEB DBEHKFODEEL, BACKDIOGIEB MHGIPGKFKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x714F790", Offset = "0x714E990", VA = "0x18714F790", Slot = "18")]
	public JFPMNFAOBHB JKNNBOCGOJE(JFPMNFAOBHB MMPPGBNJMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x714DFE0", Offset = "0x714D1E0", VA = "0x18714DFE0", Slot = "13")]
	public void EJILHKFKNJA(JFPMNFAOBHB MMPPGBNJMIM, HashSet<JFPMNFAOBHB> HIMMPDPEJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x714E480", Offset = "0x714D680", VA = "0x18714E480", Slot = "14")]
	public List<JFPMNFAOBHB> GLIFIFAFLBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7150210", Offset = "0x714F410", VA = "0x187150210")]
	protected BACKDIOGIEB MOCHNPKABCM(BACKDIOGIEB NGCBLOEDNKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x714DF40", Offset = "0x714D140", VA = "0x18714DF40")]
	protected MAENKGKFCOP[] DIIJJJNPDLB(MAENKGKFCOP CIBFPAHHJFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7150450", Offset = "0x714F650", VA = "0x187150450")]
	protected bool OHJMCOBKFEO(JFPMNFAOBHB MMPPGBNJMIM, [Out] MAENKGKFCOP NGCBLOEDNKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x714D6D0", Offset = "0x714C8D0", VA = "0x18714D6D0", Slot = "15")]
	public bool AMEKFHIKGAD(JFPMNFAOBHB MMPPGBNJMIM, [Out] BDAIGNBPFDD FGDBLFDFCCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x714E390", Offset = "0x714D590", VA = "0x18714E390")]
	protected MAENKGKFCOP FOGKAJBDJFO(BDAIGNBPFDD MPADIKCIENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x714D660", Offset = "0x714C860", VA = "0x18714D660", Slot = "10")]
	public bool AHPHJGAHICG(JFPMNFAOBHB CEOKJFCLBMG, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x714F8F0", Offset = "0x714EAF0", VA = "0x18714F8F0")]
	private bool KFKDKIAKKND(JFPMNFAOBHB CEOKJFCLBMG, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7150560", Offset = "0x714F760", VA = "0x187150560")]
	private static bool OHMADJPFMGM(MAENKGKFCOP KDDLEEIOIOF, BDAIGNBPFDD MDEAGHGFPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x714D6C0", Offset = "0x714C8C0", VA = "0x18714D6C0", Slot = "7")]
	private bool ALIJPOHBAAI([In] JFANEGAIKFD LFDKFEEPNFP, bool AEGDCNCGCLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class PGFKDFKDLDM : IHDKGDKFPCD, CIDGALBBDPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly JBPONICDCIO CKNPDKKKGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly EOKCDFJKPPC LAMNNDKOJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly CDBIDALCIBB EGJINFLNGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly JGGBGDDNFHK LNAKAFKDLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly OLDHPBBOAIA CEJADBPEGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal LLJOEDMFPKM CKNLAJJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal GNODNPGKCLL IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal IPFLNBFKCKB DFJFFCIHKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool MAJBHALJHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool HLJHDGICDJB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LCAOKMCJGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E5C0", Offset = "0xA9D7C0", VA = "0x180A9E5C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1079B40", Offset = "0x1078D40", VA = "0x181079B40")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HOKILEEDJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xF4CE00", Offset = "0xF4C000", VA = "0x180F4CE00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x22A9080", Offset = "0x22A8280", VA = "0x1822A9080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GKALAAGIOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JFPMNFAOBHB, JFPMNFAOBHB> HLPMCEJPPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7161A30", Offset = "0x7160C30", VA = "0x187161A30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x71602A0", Offset = "0x715F4A0", VA = "0x1871602A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JFPMNFAOBHB, JFPMNFAOBHB> BMAPPMGFBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7160240", Offset = "0x715F440", VA = "0x187160240", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x71617C0", Offset = "0x71609C0", VA = "0x1871617C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JFPMNFAOBHB, JFPMNFAOBHB, JFPMNFAOBHB> LCPCGPHFOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7160000", Offset = "0x715F200", VA = "0x187160000", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7160AD0", Offset = "0x715FCD0", VA = "0x187160AD0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7161A90", Offset = "0x7160C90", VA = "0x187161A90")]
	public PGFKDFKDLDM(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x71604B0", Offset = "0x715F6B0", VA = "0x1871604B0", Slot = "12")]
	public void GGPOBANFNOP(GameObject GBMEGJCINPI, HHNJGBMFCBP IJOPOJOLDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x715FF20", Offset = "0x715F120", VA = "0x18715FF20", Slot = "26")]
	public void APIIJJHOIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x71614F0", Offset = "0x71606F0", VA = "0x1871614F0", Slot = "13")]
	public void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7161440", Offset = "0x7160640", VA = "0x187161440", Slot = "14")]
	public void JMFBCAGPLCG(JFPMNFAOBHB MMPPGBNJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7160A70", Offset = "0x715FC70", VA = "0x187160A70", Slot = "15")]
	public void GLLHIOFIBAC(JFPMNFAOBHB MMPPGBNJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x715FD90", Offset = "0x715EF90", VA = "0x18715FD90", Slot = "22")]
	public bool AGGNHKPAEGN(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7160B30", Offset = "0x715FD30", VA = "0x187160B30")]
	internal bool HIJDNOABCJI([In] JFANEGAIKFD LFDKFEEPNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7161460", Offset = "0x7160660", VA = "0x187161460")]
	internal bool KFKDKIAKKND([In] JFANEGAIKFD LFDKFEEPNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7160060", Offset = "0x715F260", VA = "0x187160060")]
	internal bool EHDNBEAIEDI([In] JFANEGAIKFD LFDKFEEPNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x71612F0", Offset = "0x71604F0", VA = "0x1871612F0")]
	internal bool JKBDGCNJMAL([In] JFANEGAIKFD LFDKFEEPNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7160BF0", Offset = "0x715FDF0", VA = "0x187160BF0")]
	internal void HNDFBIEOJAE(JFPMNFAOBHB MMPPGBNJMIM, int KFGIHMOLMPG, bool AEGDCNCGCLB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7160A70", Offset = "0x715FC70", VA = "0x187160A70")]
	internal bool MOCEMGEMILG(JFPMNFAOBHB FIBCHAPHPJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7160DD0", Offset = "0x715FFD0", VA = "0x187160DD0")]
	internal bool IAFNBCMIBAB(JFPMNFAOBHB BOCFEMFFHOE, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x71600C0", Offset = "0x715F2C0", VA = "0x1871600C0", Slot = "16")]
	public void EJILHKFKNJA(JFPMNFAOBHB MMPPGBNJMIM, HashSet<JFPMNFAOBHB> DBHANFCIFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7161820", Offset = "0x7160A20", VA = "0x187161820", Slot = "17")]
	public void NLNBIINCCOH(JFPMNFAOBHB BOCFEMFFHOE, JFPMNFAOBHB OMKHLJJKIFD, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x715FDE0", Offset = "0x715EFE0", VA = "0x18715FDE0", Slot = "18")]
	public void AKMNDGKOAJP(JFPMNFAOBHB CEOKJFCLBMG, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7161130", Offset = "0x7160330", VA = "0x187161130", Slot = "19")]
	public void IHJIHEGNGLF(JFPMNFAOBHB CEOKJFCLBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7161570", Offset = "0x7160770", VA = "0x187161570")]
	public void MHLMJHIBEHC([Optional] GNBDMABMPKB MDBAANPNDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x71601B0", Offset = "0x715F3B0", VA = "0x1871601B0", Slot = "23")]
	public void ENIPPDEKKNM(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7160FB0", Offset = "0x71601B0", VA = "0x187160FB0", Slot = "20")]
	public OKPJMNODPLB ICELICMJFGG(bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7160300", Offset = "0x715F500", VA = "0x187160300", Slot = "21")]
	public OKPJMNODPLB GFGNOHAICPL(HashSet<Guid> MLPOPLELKDE, bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x715FFC0", Offset = "0x715F1C0", VA = "0x18715FFC0", Slot = "25")]
	public void CHMJHDGOCOJ(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7160F00", Offset = "0x7160100", VA = "0x187160F00", Slot = "24")]
	public void IBNGCAEFBIL(OKPJMNODPLB CEJADBPEGGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class EOKCDFJKPPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly NJGCEGGLBKK<JFPMNFAOBHB, JFPMNFAOBHB> HLPMCEJPPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly NJGCEGGLBKK<JFPMNFAOBHB, JFPMNFAOBHB> BMAPPMGFBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly COIMHDMDOOB<JFPMNFAOBHB, JFPMNFAOBHB, JFPMNFAOBHB> LCPCGPHFOOF;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x71511B0", Offset = "0x71503B0", VA = "0x1871511B0")]
	public EOKCDFJKPPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	public void GGPOBANFNOP(PGFKDFKDLDM ODPBGAGOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x71510D0", Offset = "0x71502D0", VA = "0x1871510D0")]
	public void FNHDKDFCCKC(JFPMNFAOBHB DBEHKFODEEL, JFPMNFAOBHB KGPDHHGDIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7151070", Offset = "0x7150270", VA = "0x187151070")]
	public void CGCFOJPELMM(JFPMNFAOBHB DBEHKFODEEL, JFPMNFAOBHB KGPDHHGDIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7151130", Offset = "0x7150330", VA = "0x187151130")]
	public void LIFDAMFOOOE(JFPMNFAOBHB PBJPKNOEMPL, JFPMNFAOBHB BCPOGOCDLFM, JFPMNFAOBHB KGPDHHGDIDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class CDBIDALCIBB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PGFKDFKDLDM ODPBGAGOMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private GNODNPGKCLL IBMNPFDADDO;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public CDBIDALCIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x714D410", Offset = "0x714C610", VA = "0x18714D410")]
	public void GGPOBANFNOP(PGFKDFKDLDM ODPBGAGOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x714D290", Offset = "0x714C490", VA = "0x18714D290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x714D540", Offset = "0x714C740", VA = "0x18714D540")]
	private void IEIBHLIPIJG(GNBDMABMPKB IBFPGGCAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x714D2A0", Offset = "0x714C4A0", VA = "0x18714D2A0")]
	private void EMCHPNFPCDE(GNBDMABMPKB CAFBHLENICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x714D560", Offset = "0x714C760", VA = "0x18714D560")]
	public void MNDCEPMNOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x714D310", Offset = "0x714C510", VA = "0x18714D310")]
	public void GCJNPKFABMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LEDKGPJCLDC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LNJDMCPDHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JBPONICDCIO container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LNJDMCPDHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x715B6B0", Offset = "0x715A8B0", VA = "0x18715B6B0")]
		internal PGFKDFKDLDM BFCJOOKEHEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x715AB00", Offset = "0x7159D00", VA = "0x18715AB00")]
	public static void PFOGINCAPEF(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x715AD00", Offset = "0x7159F00", VA = "0x18715AD00")]
	public static void PHJGFDOCIEI(JBPONICDCIO CKNPDKKKGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class LPJDKHBLEMM : IDisposable, IPFLNBFKCKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, JMDJICOIHPM> JCEADGLHKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FHFCAMFCBGM DJGCOEJCJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private MLPIHJPBDFG DFAJOCLJFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private OLDHPBBOAIA CEJADBPEGGM;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker GIPDNBFAGJL;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x715C510", Offset = "0x715B710", VA = "0x18715C510")]
	public LPJDKHBLEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x715BE60", Offset = "0x715B060", VA = "0x18715BE60", Slot = "7")]
	public void GGPOBANFNOP(OLDHPBBOAIA CEJADBPEGGM, MLPIHJPBDFG DFAJOCLJFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x715C0E0", Offset = "0x715B2E0", VA = "0x18715C0E0", Slot = "5")]
	public void PMMFJPPBCID(BACKDIOGIEB GAAJGKLDJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x715BEA0", Offset = "0x715B0A0", VA = "0x18715BEA0", Slot = "9")]
	public void NFDMADDDJKF(BACKDIOGIEB AGIAHENJDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x715B720", Offset = "0x715A920", VA = "0x18715B720", Slot = "8")]
	public void BDMDENHLFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x715B8E0", Offset = "0x715AAE0", VA = "0x18715B8E0", Slot = "10")]
	public void CIEGEMKDDPD(BACKDIOGIEB BHEMIKBDMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x715BB30", Offset = "0x715AD30", VA = "0x18715BB30", Slot = "11")]
	public void CKCMILHKNCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x715BCB0", Offset = "0x715AEB0", VA = "0x18715BCB0")]
	private bool GGNJDIDDAEE(BACKDIOGIEB FOENIOOLJIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class JGGBGDDNFHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct LNIDBHMNLAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly MAENKGKFCOP POIFCEDDANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> MLPOPLELKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly AFIEKEBJKEP MNALGDMLLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly AFIEKEBJKEP JKLCFHNFMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool CACIOKGKEAM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool OEAEAOANJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x715B530", Offset = "0x715A730", VA = "0x18715B530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x715B640", Offset = "0x715A840", VA = "0x18715B640")]
		public LNIDBHMNLAI(MAENKGKFCOP POIFCEDDANB, HashSet<Guid> MLPOPLELKDE, bool CACIOKGKEAM, [Optional] AFIEKEBJKEP MNALGDMLLAI, [Optional] AFIEKEBJKEP JKLCFHNFMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x715B170", Offset = "0x715A370", VA = "0x18715B170")]
		public AFIEKEBJKEP LKDLAIOBOFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x715AD80", Offset = "0x7159F80", VA = "0x18715AD80")]
		private AFIEKEBJKEP CMIHOBGFOIA([Out] AFIEKEBJKEP IDKGEGEKNIA, [Out] AFIEKEBJKEP JGMHJJFKAAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x715B310", Offset = "0x715A510", VA = "0x18715B310")]
		private AFIEKEBJKEP NNMLDAGPLIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x715B000", Offset = "0x715A200", VA = "0x18715B000")]
		private void FNECJCEMNDL(AFIEKEBJKEP PEPPCMIDEHK, AFIEKEBJKEP MFGCLDCDLFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x715AE40", Offset = "0x715A040", VA = "0x18715AE40")]
		private void ELADBABJHBD(AFIEKEBJKEP IDKGEGEKNIA, AFIEKEBJKEP JGMHJJFKAAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private PGFKDFKDLDM ODPBGAGOMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private OLDHPBBOAIA CEJADBPEGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private IPFLNBFKCKB PLJCEHOIAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private GNODNPGKCLL IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool GPPJFMBEKGA;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool NHLKGHFIGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7155340", Offset = "0x7154540", VA = "0x187155340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool LCAOKMCJGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7154570", Offset = "0x7153770", VA = "0x187154570")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7155320", Offset = "0x7154520", VA = "0x187155320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7154410", Offset = "0x7153610", VA = "0x187154410")]
	public void GGPOBANFNOP(PGFKDFKDLDM ODPBGAGOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7154CA0", Offset = "0x7153EA0", VA = "0x187154CA0")]
	public OKPJMNODPLB ICELICMJFGG(bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7154270", Offset = "0x7153470", VA = "0x187154270")]
	public OKPJMNODPLB GFGNOHAICPL(HashSet<Guid> MLPOPLELKDE, bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7153BE0", Offset = "0x7152DE0", VA = "0x187153BE0")]
	public void ENIPPDEKKNM(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7154C00", Offset = "0x7153E00", VA = "0x187154C00")]
	public void IBNGCAEFBIL(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x71555B0", Offset = "0x71547B0", VA = "0x1871555B0")]
	public void OGPJJDGJLEP(OKPJMNODPLB CEJADBPEGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7155770", Offset = "0x7154970", VA = "0x187155770")]
	private void PNOFLBPFCDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7153850", Offset = "0x7152A50", VA = "0x187153850")]
	private AFIEKEBJKEP BGOAPAENOOB(MAENKGKFCOP NGCBLOEDNKL, bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7153F30", Offset = "0x7153130", VA = "0x187153F30")]
	private static void FIEONPJNNEC(MAENKGKFCOP NGCBLOEDNKL, bool CACIOKGKEAM, AFIEKEBJKEP HLMPJHIDIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7155390", Offset = "0x7154590", VA = "0x187155390")]
	private void OCCKDEJFFIG(MAENKGKFCOP NGCBLOEDNKL, bool CACIOKGKEAM, AFIEKEBJKEP HLMPJHIDIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x71541E0", Offset = "0x71533E0", VA = "0x1871541E0")]
	private AFIEKEBJKEP FJEKMAFCILI(MAENKGKFCOP POIFCEDDANB, HashSet<Guid> MLPOPLELKDE, bool CACIOKGKEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7153940", Offset = "0x7152B40", VA = "0x187153940")]
	private bool BNCIMGHCKAN(OKPJMNODPLB MPKPMPOHHGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7154590", Offset = "0x7153790", VA = "0x187154590")]
	private bool HKICGHBDMCF(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7153BC0", Offset = "0x7152DC0", VA = "0x187153BC0")]
	private bool CEPGJCIIMLN(OKPJMNODPLB CEJADBPEGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7153730", Offset = "0x7152930", VA = "0x187153730")]
	private static bool BCDHDELEGDK(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x71534A0", Offset = "0x71526A0", VA = "0x1871534A0")]
	public static bool AGGNHKPAEGN(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7154FD0", Offset = "0x71541D0", VA = "0x187154FD0")]
	private JFPMNFAOBHB MJECKFINAKN(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7154E50", Offset = "0x7154050", VA = "0x187154E50")]
	private JFPMNFAOBHB JFAMNAHIECI(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x71555E0", Offset = "0x71547E0", VA = "0x1871555E0")]
	private JFPMNFAOBHB OIBPFFJFAGI(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7154E10", Offset = "0x7154010", VA = "0x187154E10")]
	private static Guid JEFPCKMPAGG(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7154480", Offset = "0x7153680", VA = "0x187154480")]
	private string HALOMLFJKCL(AFIEKEBJKEP HLMPJHIDIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7155950", Offset = "0x7154B50", VA = "0x187155950")]
	private bool PPFAJOKEENC(MAENKGKFCOP NGCBLOEDNKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7153C70", Offset = "0x7152E70", VA = "0x187153C70")]
	private static void FFHBOMEMLDD(MAENKGKFCOP POIFCEDDANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public JGGBGDDNFHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct JFANEGAIKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public JFPMNFAOBHB KGPDHHGDIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public JFPMNFAOBHB DBEHKFODEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int IOKAOFLAFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int GMONJLDKGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 FAJAPJLLOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion MGLAJONKDHA;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BDAIGNBPFDD CIMHDANOGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7153390", Offset = "0x7152590", VA = "0x187153390")]
		get
		{
			return default(BDAIGNBPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BDAIGNBPFDD CLHDMEMCMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7153360", Offset = "0x7152560", VA = "0x187153360")]
		get
		{
			return default(BDAIGNBPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7153430", Offset = "0x7152630", VA = "0x187153430")]
	public JFANEGAIKFD(JFPMNFAOBHB KGPDHHGDIDC, JFPMNFAOBHB DBEHKFODEEL, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface OLDHPBBOAIA
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BACKDIOGIEB KMOBICEOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGPOBANFNOP(IHDKGDKFPCD ODPBGAGOMOC);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJNDHNBNBMH([In] JFANEGAIKFD LFDKFEEPNFP, bool AEGDCNCGCLB = true);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIGJMLLNGND(JFPMNFAOBHB CJENFMDLKHI);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MMJDCLFJJCB(JFPMNFAOBHB BOCFEMFFHOE, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AHPHJGAHICG(JFPMNFAOBHB CEOKJFCLBMG, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OILIDGMAAOJ();

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INMJIPKJOOH(Func<JFPMNFAOBHB, bool> PKHGBGJDOGJ);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EJILHKFKNJA(JFPMNFAOBHB MMPPGBNJMIM, HashSet<JFPMNFAOBHB> HIMMPDPEJIO);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<JFPMNFAOBHB> GLIFIFAFLBE();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AMEKFHIKGAD(JFPMNFAOBHB MMPPGBNJMIM, [Out] BDAIGNBPFDD FGDBLFDFCCG);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KPLPFOKOCCI(FHFCAMFCBGM FOCHKIPOIOG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool FHFCAMFCBGM(BACKDIOGIEB NGCBLOEDNKL);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface BACKDIOGIEB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JFPMNFAOBHB JAKMAGJPFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BACKDIOGIEB ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BDAIGNBPFDD JHNKMKHANJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HFMGBNHENGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JMDJICOIHPM : DONMNNICLPK.GEODOPPEAJN
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDPAGNEJHAM(JFPMNFAOBHB CCGMLHIOGLH, BDAIGNBPFDD KGPDHHGDIDC);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALFAGGAEGDA(JFPMNFAOBHB CCGMLHIOGLH, BDAIGNBPFDD KGPDHHGDIDC);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICEMEIGPLPN(JFPMNFAOBHB CCGMLHIOGLH, BDAIGNBPFDD KGPDHHGDIDC);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKEDFCFFDIF(JFPMNFAOBHB CCGMLHIOGLH, BDAIGNBPFDD KGPDHHGDIDC);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JMDJICOIHPM Instantiate(Transform MCPAEAAAAAM);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LEGDOGAINAB();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface MLPIHJPBDFG
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGPOBANFNOP(Transform MCPAEAAAAAM, JMDJICOIHPM GCANOCOKGCG);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JMDJICOIHPM OMPLPLCBCJD();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMCPCAFIKKI(JMDJICOIHPM BELFHIJFLDI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LLJOEDMFPKM : PGLBGKJHLLI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCJPBEIJFKC();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBOFMIDGAFE(Guid FIIDDOPMGLB);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface IPFLNBFKCKB
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMMFJPPBCID(BACKDIOGIEB GAAJGKLDJIM);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGPOBANFNOP(OLDHPBBOAIA CEJADBPEGGM, MLPIHJPBDFG CJIICLIHHEB);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDMDENHLFKN();

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFDMADDDJKF(BACKDIOGIEB AGIAHENJDMK);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIEGEMKDDPD(BACKDIOGIEB BHEMIKBDMHM);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CKCMILHKNCG();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class MAENKGKFCOP : BACKDIOGIEB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NDDPHDJCEPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public BDAIGNBPFDD nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public MAENKGKFCOP foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NDDPHDJCEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x715F410", Offset = "0x715E610", VA = "0x18715F410")]
		internal bool DKGFDMFHIBO(BACKDIOGIEB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private BDAIGNBPFDD FGDBLFDFCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<MAENKGKFCOP> ICEEGCEHMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private MAENKGKFCOP MOLBLPIEAAI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BDAIGNBPFDD JHNKMKHANJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1079EF0", Offset = "0x10790F0", VA = "0x181079EF0", Slot = "6")]
		get
		{
			return default(BDAIGNBPFDD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1079C20", Offset = "0x1078E20", VA = "0x181079C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private MAENKGKFCOP DBEHKFODEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x715E910", Offset = "0x715DB10", VA = "0x18715E910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public BACKDIOGIEB ACBBFNLKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JFPMNFAOBHB JAKMAGJPFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HFMGBNHENGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x715E7B0", Offset = "0x715D9B0", VA = "0x18715E7B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool MBILDGGNFII
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x715EE20", Offset = "0x715E020", VA = "0x18715EE20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected MAENKGKFCOP DONMCNODAED
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x715EE70", Offset = "0x715E070", VA = "0x18715EE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x715F230", Offset = "0x715E430", VA = "0x18715F230")]
	public MAENKGKFCOP(BDAIGNBPFDD AONPNDLNMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x715E9F0", Offset = "0x715DBF0", VA = "0x18715E9F0")]
	public MAENKGKFCOP FHJIJLKPAKP(BDAIGNBPFDD MKKCCBLNGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x715EE90", Offset = "0x715E090", VA = "0x18715EE90")]
	public MAENKGKFCOP JOKAPHLNLLB(BDAIGNBPFDD OMCGJKHHPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x715EC40", Offset = "0x715DE40", VA = "0x18715EC40")]
	public MAENKGKFCOP GMODDBABBFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x715E7C0", Offset = "0x715D9C0", VA = "0x18715E7C0")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x715F180", Offset = "0x715E380", VA = "0x18715F180")]
	public MAENKGKFCOP MHGCADPCMLC(BDAIGNBPFDD BCPOGOCDLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x715F010", Offset = "0x715E210", VA = "0x18715F010")]
	private static void KPLPFOKOCCI(MAENKGKFCOP FLBEJIEIJJI, FHFCAMFCBGM AHMKJKELCNK, bool KDFPAEHAAKB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x715F170", Offset = "0x715E370", VA = "0x18715F170", Slot = "9")]
	public void KPLPFOKOCCI(FHFCAMFCBGM FOCHKIPOIOG, bool FIKKDFDGGOE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x715EB40", Offset = "0x715DD40", VA = "0x18715EB40")]
	public static MAENKGKFCOP FOGKAJBDJFO(MAENKGKFCOP FLBEJIEIJJI, BDAIGNBPFDD LBCBPKMKAGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface GNODNPGKCLL
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool NHLKGHFIGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OLFEDGGGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<GNBDMABMPKB> IEIBHLIPIJG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<GNBDMABMPKB> EMCHPNFPCDE;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(PGFKDFKDLDM ODPBGAGOMOC);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(JFPMNFAOBHB BOCFEMFFHOE, JFPMNFAOBHB OMKHLJJKIFD, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(JFPMNFAOBHB CEOKJFCLBMG, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(OKPJMNODPLB FOGDODCGFAF, [Optional] GNBDMABMPKB MDBAANPNDKM);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, GNODNPGKCLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private PGFKDFKDLDM ODPBGAGOMOC;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool NHLKGHFIGLM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x715E410", Offset = "0x715D610", VA = "0x18715E410", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool OLFEDGGGBNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x715E470", Offset = "0x715D670", VA = "0x18715E470", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<GNBDMABMPKB> IEIBHLIPIJG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x715E360", Offset = "0x715D560", VA = "0x18715E360", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x715E560", Offset = "0x715D760", VA = "0x18715E560", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<GNBDMABMPKB> EMCHPNFPCDE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x715E2B0", Offset = "0x715D4B0", VA = "0x18715E2B0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x715E4B0", Offset = "0x715D6B0", VA = "0x18715E4B0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0C0", Offset = "0x8FA2C0", VA = "0x1808FB0C0", Slot = "19")]
		public void SetManager(PGFKDFKDLDM ODPBGAGOMOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x715E280", Offset = "0x715D480", VA = "0x18715E280")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x715D000", Offset = "0x715C200", VA = "0x18715D000", Slot = "23")]
		public void RequestMasterConnectNodes(JFPMNFAOBHB OCGJCFGAENH, int IOKAOFLAFMC, JFPMNFAOBHB CCGMLHIOGLH, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x715D130", Offset = "0x715C330", VA = "0x18715D130", Slot = "24")]
		public void RequestMasterDisconnectNode(JFPMNFAOBHB CJENFMDLKHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x715D1F0", Offset = "0x715C3F0", VA = "0x18715D1F0", Slot = "20")]
		public void RequestMasterModifyNode(JFPMNFAOBHB BOCFEMFFHOE, JFPMNFAOBHB OMKHLJJKIFD, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x715D320", Offset = "0x715C520", VA = "0x18715D320", Slot = "21")]
		public void RequestMasterReparentNodes(JFPMNFAOBHB CEOKJFCLBMG, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x715D450", Offset = "0x715C650", VA = "0x18715D450", Slot = "25")]
		public void RequestMasterReparentToRoot(JFPMNFAOBHB CEOKJFCLBMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x715CED0", Offset = "0x715C0D0", VA = "0x18715CED0", Slot = "22")]
		public void RequestDeserializeConnectableGraph(OKPJMNODPLB FOGDODCGFAF, [Optional] GNBDMABMPKB MDBAANPNDKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x715D830", Offset = "0x715CA30", VA = "0x18715D830")]
		[CIHCEMHCIBO]
		private void RpcMasterConnectNodes(JFPMNFAOBHB OCGJCFGAENH, int IOKAOFLAFMC, JFPMNFAOBHB CCGMLHIOGLH, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x715DAF0", Offset = "0x715CCF0", VA = "0x18715DAF0")]
		[CIHCEMHCIBO]
		private void RpcMasterDisconnectNode(JFPMNFAOBHB CJENFMDLKHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x715DE30", Offset = "0x715D030", VA = "0x18715DE30")]
		[CIHCEMHCIBO]
		private void RpcMasterReparentNodes(JFPMNFAOBHB CEOKJFCLBMG, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x715DC30", Offset = "0x715CE30", VA = "0x18715DC30")]
		[CIHCEMHCIBO]
		private void RpcMasterModifyNode(JFPMNFAOBHB BOCFEMFFHOE, JFPMNFAOBHB OMKHLJJKIFD, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x715D620", Offset = "0x715C820", VA = "0x18715D620")]
		[CIHCEMHCIBO]
		private void RpcConnectNodes(JFPMNFAOBHB OCGJCFGAENH, int IOKAOFLAFMC, JFPMNFAOBHB CCGMLHIOGLH, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA, NMFPNCNAIFP EHGPDECDBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x715D7A0", Offset = "0x715C9A0", VA = "0x18715D7A0")]
		[CIHCEMHCIBO]
		private void RpcDisconnectNode(JFPMNFAOBHB CJENFMDLKHI, NMFPNCNAIFP EHGPDECDBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x715E180", Offset = "0x715D380", VA = "0x18715E180")]
		[CIHCEMHCIBO]
		private void RpcReparentNodes(JFPMNFAOBHB CEOKJFCLBMG, int GLMKLKGKFIA, JFPMNFAOBHB BCPOGOCDLFM, int FNGLKOIMEBA, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA, NMFPNCNAIFP EHGPDECDBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x715E0C0", Offset = "0x715D2C0", VA = "0x18715E0C0")]
		[CIHCEMHCIBO]
		private void RpcModifyNode(JFPMNFAOBHB BOCFEMFFHOE, int IOKAOFLAFMC, int GMONJLDKGPL, Vector3 FAJAPJLLOIA, Quaternion MGLAJONKDHA, NMFPNCNAIFP EHGPDECDBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x715D760", Offset = "0x715C960", VA = "0x18715D760")]
		[CIHCEMHCIBO]
		private void RpcDeserializeConnectableGraph(OKPJMNODPLB CEJADBPEGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x90FE00", Offset = "0x90F000", VA = "0x18090FE00")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, JMDJICOIHPM, DONMNNICLPK.GEODOPPEAJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x715C5F0", Offset = "0x715B7F0", VA = "0x18715C5F0", Slot = "4")]
		private void AEABGPDCMHO(JFPMNFAOBHB CCGMLHIOGLH, BDAIGNBPFDD KGPDHHGDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x715C770", Offset = "0x715B970", VA = "0x18715C770", Slot = "5")]
		private void CMGJPOOGFND(JFPMNFAOBHB CCGMLHIOGLH, BDAIGNBPFDD KGPDHHGDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x715CCA0", Offset = "0x715BEA0", VA = "0x18715CCA0", Slot = "6")]
		private void NOFJMHHKFPC(JFPMNFAOBHB CCGMLHIOGLH, BDAIGNBPFDD KGPDHHGDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x715CA40", Offset = "0x715BC40", VA = "0x18715CA40", Slot = "7")]
		private void HNALIENEHNO(JFPMNFAOBHB CCGMLHIOGLH, BDAIGNBPFDD KGPDHHGDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x715CC30", Offset = "0x715BE30", VA = "0x18715CC30", Slot = "8")]
		private JMDJICOIHPM IIGPCJNNAAO(Transform MCPAEAAAAAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x715C9E0", Offset = "0x715BBE0", VA = "0x18715C9E0", Slot = "9")]
		private void ELOPIDLCCGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class ACJLGLNBAMC
{
	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x39E8530", Offset = "0x39E7730", VA = "0x1839E8530")]
	public static CHEAKKPHINI<T> PPPCEJOBBDG<T>(this JBPONICDCIO CKNPDKKKGFM)
	{
		return null;
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
