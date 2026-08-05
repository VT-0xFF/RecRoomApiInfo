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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A298C0", Offset = "0x7A28CC0", VA = "0x187A298C0", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F870", Offset = "0x7A2EC70", VA = "0x187A2F870", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F3C0", Offset = "0x7A2E7C0", VA = "0x187A2F3C0")]
		private void NJKHJLGIPFD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F250", Offset = "0x7A2E650", VA = "0x187A2F250")]
		private void AKOLMCBFEPK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F530", Offset = "0x7A2E930", VA = "0x187A2F530", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F8B0", Offset = "0x7A2ECB0", VA = "0x187A2F8B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class CHGEAGFIIKK : CCGBOGNLGIA, BAEPLJFAONJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GECNAAOOJHN : IEnumerable<DFJEOPPFCPN>, IEnumerable, IEnumerator<DFJEOPPFCPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private DFJEOPPFCPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private NLJNHNAFJHN localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NLJNHNAFJHN <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CHGEAGFIIKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GKJIAFBFJDA <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private BJPAKDOPCOI <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private BJPAKDOPCOI.PHJCEJOKODK <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DFJEOPPFCPN System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public GECNAAOOJHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A23010", Offset = "0x7A22410", VA = "0x187A23010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A22BB0", Offset = "0x7A21FB0", VA = "0x187A22BB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7A22B70", Offset = "0x7A21F70", VA = "0x187A22B70")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7A22B90", Offset = "0x7A21F90", VA = "0x187A22B90")]
		private void LNCBGHLOKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7A22FC0", Offset = "0x7A223C0", VA = "0x187A22FC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A22F10", Offset = "0x7A22310", VA = "0x187A22F10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DFJEOPPFCPN> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7A22F10", Offset = "0x7A22310", VA = "0x187A22F10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LGIHAEABEEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CHGEAGFIIKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CHCONPFIFEN nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public LGIHAEABEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7A29030", Offset = "0x7A28430", VA = "0x187A29030")]
		internal object EPGJENBJPFH(CHCONPFIFEN x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BMMCDLDJLJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CHCONPFIFEN child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LGIHAEABEEO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BMMCDLDJLJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7A1AA90", Offset = "0x7A19E90", VA = "0x187A1AA90")]
		internal object AGAIBMMLBPM((CHCONPFIFEN child, CHCONPFIFEN nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly LMKAPNBAFDO NCOGBMCGCBO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly LMKAPNBAFDO OOOHBJIPNNE;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly LMKAPNBAFDO OMBNPGDOGIP;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LMKAPNBAFDO DAGPBIPHMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FDMKLOLDJNB IJMOGGPDAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FEOCMBCLKLC JINJFHIHLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private CHIINBBJCCE NODINOMMGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private KDDDKHKODED HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private PLGMKEJBMDL EAKHKLKENBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PILAODGLCPL OCMEKOJAAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BLCLEGLJOKH GDLAIBAPFED;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CMCDPHOIBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9CE3A0", Offset = "0x9CD7A0", VA = "0x1809CE3A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9CE370", Offset = "0x9CD770", VA = "0x1809CE370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HNABLNJKPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<DFJEOPPFCPN, DFJEOPPFCPN> OABFPFMHJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7A20380", Offset = "0x7A1F780", VA = "0x187A20380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7A1F1B0", Offset = "0x7A1E5B0", VA = "0x187A1F1B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<DFJEOPPFCPN, DFJEOPPFCPN> EABLCDGDODF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A1D310", Offset = "0x7A1C710", VA = "0x187A1D310", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A1E860", Offset = "0x7A1DC60", VA = "0x187A1E860", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<DFJEOPPFCPN, DFJEOPPFCPN, DFJEOPPFCPN> ACJCIPGPNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A1F2F0", Offset = "0x7A1E6F0", VA = "0x187A1F2F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7A1F100", Offset = "0x7A1E500", VA = "0x187A1F100", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A21990", Offset = "0x7A20D90", VA = "0x187A21990")]
	public CHGEAGFIIKK(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E5D0", Offset = "0x7A1D9D0", VA = "0x187A1E5D0", Slot = "12")]
	public void ENMMELFAOHH(GameObject GMFIIANHHCH, DIHNHJDCLEI HNBEEEEFKDP, EOEGLGNMFPM JCKKGJBOMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A1CE80", Offset = "0x7A1C280", VA = "0x187A1CE80", Slot = "26")]
	public void AECAJPPNPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E2F0", Offset = "0x7A1D6F0", VA = "0x187A1E2F0", Slot = "22")]
	public bool DLPAFENDNJJ(CHCONPFIFEN JBBAONHBPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E0E0", Offset = "0x7A1D4E0", VA = "0x187A1E0E0")]
	private void CJEGCBKNAME(NLJNHNAFJHN PPAKHICEDIA, NLJNHNAFJHN FEHPGHMDKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A1F7B0", Offset = "0x7A1EBB0", VA = "0x187A1F7B0")]
	private void HGLDAILJCLP(NLJNHNAFJHN PPAKHICEDIA, NLJNHNAFJHN CINEDCOGNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D3C0", Offset = "0x7A1C7C0", VA = "0x187A1D3C0")]
	private void BKMGBLJGAPJ(NLJNHNAFJHN PPAKHICEDIA, NLJNHNAFJHN CINEDCOGNLJ, NLJNHNAFJHN FEHPGHMDKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A21270", Offset = "0x7A20670", VA = "0x187A21270")]
	private void NMDHADCEAKB(NLJNHNAFJHN PPAKHICEDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "13")]
	public void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A20990", Offset = "0x7A1FD90", VA = "0x187A20990", Slot = "14")]
	public void KECNLMAOALC(DFJEOPPFCPN EEHFKMFHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "15")]
	public void CODCHFHDNJL(DFJEOPPFCPN EEHFKMFHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D070", Offset = "0x7A1C470", VA = "0x187A1D070", Slot = "17")]
	public void AGGADEMPHED(DFJEOPPFCPN EEHFKMFHNGA, DFJEOPPFCPN HGEJFJICMMO, Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D1D0", Offset = "0x7A1C5D0", VA = "0x187A1D1D0")]
	public void AGGADEMPHED(NLJNHNAFJHN EDKEHABGEPK, NLJNHNAFJHN HGEJFJICMMO, Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7A1F260", Offset = "0x7A1E660", VA = "0x187A1F260")]
	public void GJICLDNPDLA(DFJEOPPFCPN EEHFKMFHNGA, float BBKFIAGCKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A20FD0", Offset = "0x7A203D0", VA = "0x187A20FD0", Slot = "18")]
	public void NGHKHLIEIDM(DFJEOPPFCPN CPEGMDFINFH, int JDFNIIEKINB, DFJEOPPFCPN BIAMAAOKHPH, int MHHCKCCIEPO, Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A20CA0", Offset = "0x7A200A0", VA = "0x187A20CA0")]
	private float LPGPELCCDHA(NLJNHNAFJHN EDKEHABGEPK, NLJNHNAFJHN GEFLCBDBKHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7A21130", Offset = "0x7A20530", VA = "0x187A21130")]
	public void NGHKHLIEIDM(NLJNHNAFJHN EDKEHABGEPK, NLJNHNAFJHN GEFLCBDBKHP, Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB, bool DLMBLDKALJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A1EF90", Offset = "0x7A1E390", VA = "0x187A1EF90", Slot = "19")]
	public void FMLNMLIDHKH(DFJEOPPFCPN EEHFKMFHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A20490", Offset = "0x7A1F890", VA = "0x187A20490", Slot = "16")]
	public void HPHOALIGNIO(DFJEOPPFCPN EEHFKMFHNGA, HashSet<DFJEOPPFCPN> GOMEJJOHBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "20")]
	public LBFFJBPBGDL POEPKCDLFGK(bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "21")]
	public LBFFJBPBGDL BJLFAAEAFIN(HashSet<Guid> LFKOBDAGICG, bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A216A0", Offset = "0x7A20AA0", VA = "0x187A216A0", Slot = "23")]
	public void OKONNIKKENM(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E340", Offset = "0x7A1D740", VA = "0x187A1E340", Slot = "24")]
	public void DOAGAKMDNGI(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A21680", Offset = "0x7A20A80", VA = "0x187A21680", Slot = "25")]
	public void OIMANKPHLJJ(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FF70", Offset = "0x7A1F370", VA = "0x187A1FF70")]
	private void HHJPFOMODII(NLJNHNAFJHN EDKEHABGEPK, NLJNHNAFJHN GEFLCBDBKHP, Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB, float BBKFIAGCKKH, bool DLMBLDKALJE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D620", Offset = "0x7A1CA20", VA = "0x187A1D620")]
	private void BMFGHMDLFJH(NLJNHNAFJHN EDKEHABGEPK, NLJNHNAFJHN EEKCDPNNHKN, Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A208E0", Offset = "0x7A1FCE0", VA = "0x187A208E0")]
	private void JLMEOADFNAF(NLJNHNAFJHN EDKEHABGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E3B0", Offset = "0x7A1D7B0", VA = "0x187A1E3B0")]
	[IteratorStateMachine(typeof(GECNAAOOJHN))]
	public IEnumerable<DFJEOPPFCPN> DOENEHAOPNO(NLJNHNAFJHN LAOCDNNIMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A1EE50", Offset = "0x7A1E250", VA = "0x187A1EE50")]
	internal DFJEOPPFCPN FLOEDNIIJDM(NLJNHNAFJHN LAOCDNNIMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E910", Offset = "0x7A1DD10", VA = "0x187A1E910")]
	internal NLJNHNAFJHN EPOOLNKOJIH(DFJEOPPFCPN EEHFKMFHNGA)
	{
		return default(NLJNHNAFJHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7A1F9D0", Offset = "0x7A1EDD0", VA = "0x187A1F9D0")]
	private bool HHBADFAPAIB(CHCONPFIFEN JBBAONHBPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A20430", Offset = "0x7A1F830", VA = "0x187A20430")]
	private bool HLPBNJLMFCO(CHCONPFIFEN JBBAONHBPHP, [Out] DFJEOPPFCPN GEFLCBDBKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A1EAA0", Offset = "0x7A1DEA0", VA = "0x187A1EAA0")]
	private DFJEOPPFCPN FLOEDNIIJDM(CHCONPFIFEN JBBAONHBPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A1F3A0", Offset = "0x7A1E7A0", VA = "0x187A1F3A0")]
	private DFJEOPPFCPN HBLJOGBPLPB(CHCONPFIFEN JBBAONHBPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A206A0", Offset = "0x7A1FAA0", VA = "0x187A206A0")]
	private DFJEOPPFCPN INJNFHDJFFC(CHCONPFIFEN JBBAONHBPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A20950", Offset = "0x7A1FD50", VA = "0x187A20950")]
	private static Guid JLMGONMJECI(CHCONPFIFEN JBBAONHBPHP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A20EE0", Offset = "0x7A202E0", VA = "0x187A20EE0")]
	private string NBJJEMLMIOM(CHCONPFIFEN JBBAONHBPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A1DF50", Offset = "0x7A1D350", VA = "0x187A1DF50")]
	private void CINDCMNPGDM(DFJEOPPFCPN EDKEHABGEPK, DFJEOPPFCPN EEKCDPNNHKN, RigidTransform FBLOEBGKBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7A20D50", Offset = "0x7A20150", VA = "0x187A20D50")]
	private void MKDDLMNBACN(DFJEOPPFCPN EEKCDPNNHKN, DFJEOPPFCPN EDKEHABGEPK, RigidTransform FBLOEBGKBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7A20880", Offset = "0x7A1FC80", VA = "0x187A20880")]
	private void JHCOHLPDPDI(DFJEOPPFCPN BCJIACDOMKL, DFJEOPPFCPN EDKEHABGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E440", Offset = "0x7A1D840", VA = "0x187A1E440")]
	private void EFHCMNLOKDO(DFJEOPPFCPN EDKEHABGEPK, DFJEOPPFCPN GEFLCBDBKHP, RigidTransform FBLOEBGKBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A21710", Offset = "0x7A20B10", VA = "0x187A21710")]
	private void PMKECPPCDKK(NLJNHNAFJHN LAOCDNNIMLF, DFJEOPPFCPN EEHFKMFHNGA, NLJNHNAFJHN CINEDCOGNLJ, NLJNHNAFJHN FEHPGHMDKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A1F530", Offset = "0x7A1E930", VA = "0x187A1F530")]
	private void HFPDCFGBHHF(NLJNHNAFJHN LAOCDNNIMLF, DFJEOPPFCPN EEHFKMFHNGA, DFJEOPPFCPN ANJHAIACNPM, DFJEOPPFCPN DPPJOLMEMMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GEODENIBIOG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CAJLLKPDGOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NPCGGDCACLM container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public CAJLLKPDGOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7A1CDD0", Offset = "0x7A1C1D0", VA = "0x187A1CDD0")]
		internal CHGEAGFIIKK CMCJPCOHAON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A230F0", Offset = "0x7A224F0", VA = "0x187A230F0")]
	public static void EFGBAEJALPI(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A23270", Offset = "0x7A22670", VA = "0x187A23270")]
	public static void PMAKDNNMJJP(NPCGGDCACLM INELJPKBMLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class PPOJCMKCLOL : BIPPJBPGECD, GFCFJJJENAE
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly CHGEAGFIIKK EKBILDLIHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly KPOLBAJGCAC ELMFCPLAAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly ANJPHIHMGAN HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly PMCPGNCJMIK[] FDIJANJOFED;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NLJNHNAFJHN NMHFPEJCKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(NLJNHNAFJHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DFJEOPPFCPN JLAPJDEDDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2EDF0", Offset = "0x7A2E1F0", VA = "0x187A2EDF0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DFJEOPPFCPN JOJGOIAGMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7A2DAD0", Offset = "0x7A2CED0", VA = "0x187A2DAD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 EHDHHHFGNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E990", Offset = "0x7A2DD90", VA = "0x187A2E990", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion KNIDKAEGIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7A2D5C0", Offset = "0x7A2C9C0", VA = "0x187A2D5C0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IIEICAPLECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E240", Offset = "0x7A2D640", VA = "0x187A2E240", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<DFJEOPPFCPN> GJDAJKEAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E960", Offset = "0x7A2DD60", VA = "0x187A2E960", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool ANKFAMKDEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBEB240", Offset = "0xBEA640", VA = "0x180BEB240", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBF1640", Offset = "0xBF0A40", VA = "0x180BF1640", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform ACIFLJLGGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A2F000", Offset = "0x7A2E400", VA = "0x187A2F000", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject BNJNOHCALEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7A2ED00", Offset = "0x7A2E100", VA = "0x187A2ED00", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7A2ED20", Offset = "0x7A2E120", VA = "0x187A2ED20", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid DNOJDDJEOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7A2EE50", Offset = "0x7A2E250", VA = "0x187A2EE50", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KDOPGLBKLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7A2EF30", Offset = "0x7A2E330", VA = "0x187A2EF30", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GDDACPOJPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool DGFLDJEGAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7A2DFE0", Offset = "0x7A2D3E0", VA = "0x187A2DFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HIFMLMGIDFP AFHHADIGAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7A2DC60", Offset = "0x7A2D060", VA = "0x187A2DC60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E2B0", Offset = "0x7A2D6B0", VA = "0x187A2E2B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HIFMLMGIDFP EADJGFEPJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7A2EAF0", Offset = "0x7A2DEF0", VA = "0x187A2EAF0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7A2D1F0", Offset = "0x7A2C5F0", VA = "0x187A2D1F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HIFMLMGIDFP BOHJGPMMHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E5F0", Offset = "0x7A2D9F0", VA = "0x187A2E5F0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2EA90", Offset = "0x7A2DE90", VA = "0x187A2EA90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event FICBMMFCIPD NLNDCNJPCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7A2DF40", Offset = "0x7A2D340", VA = "0x187A2DF40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2E9F0", Offset = "0x7A2DDF0", VA = "0x187A2E9F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7A2EC00", Offset = "0x7A2E000", VA = "0x187A2EC00")]
	public PPOJCMKCLOL(NLJNHNAFJHN OOGFIGJOHMP, RigidbodyEx HPGKJPCLFAN, KPOLBAJGCAC ELMFCPLAAOI, PMCPGNCJMIK[] FDIJANJOFED, ANJPHIHMGAN HLIKBEKBJPB, CCGBOGNLGIA EKBILDLIHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DD10", Offset = "0x7A2D110", VA = "0x187A2DD10", Slot = "19")]
	public void GNGOBIJMNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "21")]
	public void BBHHGLMBDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7783250", Offset = "0x7782650", VA = "0x187783250", Slot = "22")]
	public void IKMJINLCPPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D570", Offset = "0x7A2C970", VA = "0x187A2D570", Slot = "20")]
	public void BOFHKCJPDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E030", Offset = "0x7A2D430", VA = "0x187A2E030", Slot = "25")]
	public void HJKGDDPOAGJ(int HKHPIMEGHBH, DFJEOPPFCPN BIAMAAOKHPH, int PJNMJPMMKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D250", Offset = "0x7A2C650", VA = "0x187A2D250", Slot = "26")]
	public void AJOIHBCLILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E310", Offset = "0x7A2D710", VA = "0x187A2E310", Slot = "27")]
	public void LINOEKIKBFC(int HKHPIMEGHBH, DFJEOPPFCPN CPEGMDFINFH, int ILNIKNICLLI, [Optional] Vector3? ALLJPPEOMKN, [Optional] Quaternion? HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DBE0", Offset = "0x7A2CFE0", VA = "0x187A2DBE0", Slot = "28")]
	public void EAMAOCKLPKC(DFJEOPPFCPN CPEGMDFINFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D620", Offset = "0x7A2CA20", VA = "0x187A2D620", Slot = "31")]
	public void CHADKEKAEGI(Vector3 ONLNDICCLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E650", Offset = "0x7A2DA50", VA = "0x187A2E650", Slot = "29")]
	public void LJINICCBPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D320", Offset = "0x7A2C720", VA = "0x187A2D320", Slot = "30")]
	public void ALEOMFKOMKO(int COPLIEINKOF, Vector3 EIODCDKJBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DE70", Offset = "0x7A2D270", VA = "0x187A2DE70", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int HKHPIMEGHBH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DD40", Offset = "0x7A2D140", VA = "0x187A2DD40", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int HKHPIMEGHBH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xBC3F90", Offset = "0xBC3390", VA = "0x180BC3F90", Slot = "42")]
	public Color GetConnectionSlotColor(int HKHPIMEGHBH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DA30", Offset = "0x7A2CE30", VA = "0x187A2DA30", Slot = "43")]
	public bool CanConnectTo(int HKHPIMEGHBH, DFJEOPPFCPN FNLNDKGOOKB, int PEBMBNDMBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "44")]
	public void ParentChanged(int HKHPIMEGHBH, DFJEOPPFCPN PGPOHGMAICJ, int POMHEDMIOPJ, Vector3 GJOEPPJNIHO, Quaternion PDJJOBKHADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "45")]
	public void ChildAdded(int HKHPIMEGHBH, DFJEOPPFCPN OBCGFFJKIEB, int KNINFDKNJKE, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "46")]
	public void ChildRemoved(int HKHPIMEGHBH, DFJEOPPFCPN EBJJKJJGBLM, int AIGCEPPCIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "47")]
	public void ConnectionModified(int HKHPIMEGHBH, DFJEOPPFCPN BIAMAAOKHPH, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2EB50", Offset = "0x7A2DF50", VA = "0x187A2EB50", Slot = "48")]
	public void RootChanged(DFJEOPPFCPN ECGHIFGAEHO, DFJEOPPFCPN NEGAFCKHNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DB90", Offset = "0x7A2CF90", VA = "0x187A2DB90", Slot = "23")]
	public void DHHBMKJADIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D520", Offset = "0x7A2C920", VA = "0x187A2D520", Slot = "24")]
	public void BFGBPFIAJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DCC0", Offset = "0x7A2D0C0", VA = "0x187A2DCC0")]
	private void GJLLEMPJENI(bool CBBCPBBHHKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(FOJFGLPPJKE), new string[] { })]
public class DDLBJHDLPDH : FOJFGLPPJKE, DNHLMEDMKFA, JAPHOPEKBNC
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BNPBKLDGMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BNPBKLDGMEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private EHPIBOPELOI DMMOIDHGCMK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object EIFNBNAMDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7A21BD0", Offset = "0x7A20FD0", VA = "0x187A21BD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7A21B80", Offset = "0x7A20F80", VA = "0x187A21B80", Slot = "5")]
	private void FNKOKEAHKOA(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x10CF690", Offset = "0x10CEA90", VA = "0x1810CF690", Slot = "6")]
	private void CKBMOLKFEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public DDLBJHDLPDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(CCGBOGNLGIA), new string[] { "Ignore", "Mock" })]
public class EKOPPKJNFKK : CCGBOGNLGIA, BAEPLJFAONJ
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CMCDPHOIBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HNABLNJKPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<DFJEOPPFCPN, DFJEOPPFCPN> OABFPFMHJKG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7A22040", Offset = "0x7A21440", VA = "0x187A22040", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7A21EE0", Offset = "0x7A212E0", VA = "0x187A21EE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<DFJEOPPFCPN, DFJEOPPFCPN> EABLCDGDODF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7A21CD0", Offset = "0x7A210D0", VA = "0x187A21CD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7A21D80", Offset = "0x7A21180", VA = "0x187A21D80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<DFJEOPPFCPN, DFJEOPPFCPN, DFJEOPPFCPN> ACJCIPGPNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7A21F90", Offset = "0x7A21390", VA = "0x187A21F90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7A21E30", Offset = "0x7A21230", VA = "0x187A21E30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "26")]
	public void AECAJPPNPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "12")]
	public void ENMMELFAOHH(GameObject GMFIIANHHCH, DIHNHJDCLEI HNBEEEEFKDP, EOEGLGNMFPM JLOGFNEDBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "13")]
	public void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "14")]
	public void KECNLMAOALC(DFJEOPPFCPN EEHFKMFHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "15")]
	public void CODCHFHDNJL(DFJEOPPFCPN EEHFKMFHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "16")]
	public void HPHOALIGNIO(DFJEOPPFCPN EEHFKMFHNGA, HashSet<DFJEOPPFCPN> GOMEJJOHBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "17")]
	public void AGGADEMPHED(DFJEOPPFCPN EEHFKMFHNGA, DFJEOPPFCPN HGEJFJICMMO, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "18")]
	public void NGHKHLIEIDM(DFJEOPPFCPN EEHFKMFHNGA, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "19")]
	public void FMLNMLIDHKH(DFJEOPPFCPN EEHFKMFHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "20")]
	public LBFFJBPBGDL POEPKCDLFGK(bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "21")]
	public LBFFJBPBGDL BJLFAAEAFIN(HashSet<Guid> LFKOBDAGICG, bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "22")]
	public bool DLPAFENDNJJ(CHCONPFIFEN JBBAONHBPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "23")]
	public void OKONNIKKENM(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "24")]
	public void DOAGAKMDNGI(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "25")]
	public void OIMANKPHLJJ(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public EKOPPKJNFKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DFJEOPPFCPN : GFCFJJJENAE, IEquatable<DFJEOPPFCPN>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GFCFJJJENAE
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DFJEOPPFCPN JLAPJDEDDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform ACIFLJLGGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject BNJNOHCALEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid DNOJDDJEOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int KDOPGLBKLLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NLJNHNAFJHN NMHFPEJCKLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GDDACPOJPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int HKHPIMEGHBH);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int HKHPIMEGHBH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int HKHPIMEGHBH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int HKHPIMEGHBH, DFJEOPPFCPN FNLNDKGOOKB, int KJKLOCGGADL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int HKHPIMEGHBH, DFJEOPPFCPN PGPOHGMAICJ, int POMHEDMIOPJ, Vector3 GJOEPPJNIHO, Quaternion PDJJOBKHADK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int HKHPIMEGHBH, DFJEOPPFCPN OBCGFFJKIEB, int KNINFDKNJKE, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int HKHPIMEGHBH, DFJEOPPFCPN EBJJKJJGBLM, int AIGCEPPCIPN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int HKHPIMEGHBH, DFJEOPPFCPN BIAMAAOKHPH, int MGJNIOHNJEI, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(DFJEOPPFCPN ECGHIFGAEHO, DFJEOPPFCPN NEGAFCKHNKC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCGBOGNLGIA : BAEPLJFAONJ
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CMCDPHOIBJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool HNABLNJKPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<DFJEOPPFCPN, DFJEOPPFCPN> OABFPFMHJKG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<DFJEOPPFCPN, DFJEOPPFCPN> EABLCDGDODF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<DFJEOPPFCPN, DFJEOPPFCPN, DFJEOPPFCPN> ACJCIPGPNHJ;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ENMMELFAOHH(GameObject GMFIIANHHCH, DIHNHJDCLEI HNBEEEEFKDP, EOEGLGNMFPM HANCNNFFPOD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LFKOACHICEI();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KECNLMAOALC(DFJEOPPFCPN EEHFKMFHNGA);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CODCHFHDNJL(DFJEOPPFCPN EEHFKMFHNGA);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HPHOALIGNIO(DFJEOPPFCPN EEHFKMFHNGA, HashSet<DFJEOPPFCPN> GOMEJJOHBGI);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AGGADEMPHED(DFJEOPPFCPN EEHFKMFHNGA, DFJEOPPFCPN HGEJFJICMMO, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NGHKHLIEIDM(DFJEOPPFCPN EEHFKMFHNGA, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FMLNMLIDHKH(DFJEOPPFCPN EEHFKMFHNGA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LBFFJBPBGDL POEPKCDLFGK(bool CBIPJMJFKOL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LBFFJBPBGDL BJLFAAEAFIN(HashSet<Guid> LFKOBDAGICG, bool CBIPJMJFKOL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DLPAFENDNJJ(CHCONPFIFEN JBBAONHBPHP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OKONNIKKENM(LBFFJBPBGDL OFGCJBCHPLD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DOAGAKMDNGI(LBFFJBPBGDL OFGCJBCHPLD);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OIMANKPHLJJ(LBFFJBPBGDL OFGCJBCHPLD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KDDDKHKODED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CCKFFFNOJND
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DFJEOPPFCPN INJNFHDJFFC(int MBKPHHENGGF);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DFJEOPPFCPN HBLJOGBPLPB(Guid ILELGJEBEEP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AAOBBLLPHIA(DFJEOPPFCPN EEHFKMFHNGA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EANPHINPGOP();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JEHHACBGHBA(DFJEOPPFCPN ELMFCPLAAOI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface ANJPHIHMGAN
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGFLDJEGAJM(KPOLBAJGCAC ELMFCPLAAOI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLCOPJGGJMH(KPOLBAJGCAC ELMFCPLAAOI);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MBFKNGPEFHE(KPOLBAJGCAC ELMFCPLAAOI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ODBFLPBAMPC(KPOLBAJGCAC ELMFCPLAAOI);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IPLFEHNJLPK(KPOLBAJGCAC ELMFCPLAAOI);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFAMNBOFHIO(KPOLBAJGCAC ELMFCPLAAOI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void HIFMLMGIDFP(DFJEOPPFCPN CPEGMDFINFH, int GBFFJMIJFGO, DFJEOPPFCPN BIAMAAOKHPH, int KCDGFAPOOHJ, [Optional] Vector3? ALLJPPEOMKN, [Optional] Quaternion? HMNHHJNIFNI);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void FICBMMFCIPD(DFJEOPPFCPN ECGHIFGAEHO, DFJEOPPFCPN NEGAFCKHNKC);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KPOLBAJGCAC : DFJEOPPFCPN, GFCFJJJENAE, IEquatable<DFJEOPPFCPN>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BIPPJBPGECD : GFCFJJJENAE
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DFJEOPPFCPN JOJGOIAGMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<DFJEOPPFCPN> GJDAJKEAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 EHDHHHFGNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion KNIDKAEGIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool IIEICAPLECB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool ANKFAMKDEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event HIFMLMGIDFP AFHHADIGAIC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event HIFMLMGIDFP EADJGFEPJKB;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HIFMLMGIDFP BOHJGPMMHHB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event FICBMMFCIPD NLNDCNJPCAK;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GNGOBIJMNKI();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BOFHKCJPDLE();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BBHHGLMBDIG();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IKMJINLCPPN();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DHHBMKJADIF();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BFGBPFIAJEH();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HJKGDDPOAGJ(int HKHPIMEGHBH, DFJEOPPFCPN BIAMAAOKHPH, int PJNMJPMMKID);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AJOIHBCLILA();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LINOEKIKBFC(int HKHPIMEGHBH, DFJEOPPFCPN CPEGMDFINFH, int ILNIKNICLLI, [Optional] Vector3? ALLJPPEOMKN, [Optional] Quaternion? HMNHHJNIFNI);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EAMAOCKLPKC(DFJEOPPFCPN CPEGMDFINFH);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LJINICCBPJJ();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ALEOMFKOMKO(int COPLIEINKOF, Vector3 EIODCDKJBOE);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CHADKEKAEGI(Vector3 ONLNDICCLGK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PMCPGNCJMIK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 OMCANMHHCHH
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
public interface DIHNHJDCLEI
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool PJLAOEFJNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IFOAKNFCOGF MPAFBPHNJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, DIHNHJDCLEI
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
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA813E0", Offset = "0xA807E0", VA = "0x180A813E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IFOAKNFCOGF LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A21A00", Offset = "0x7A20E00", VA = "0x187A21A00")]
		public static ConnectableConfigData PGEMMGIFPIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A21AC0", Offset = "0x7A20EC0", VA = "0x187A21AC0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual CIJHGAIHOJN, bool FHLNFLEFOPJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GICDCHDJLMK : IEquatable<GICDCHDJLMK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public DFJEOPPFCPN EEHFKMFHNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int PJOBJMPCFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int MGJNIOHNJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 ALLJPPEOMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion HMNHHJNIFNI;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7A23740", Offset = "0x7A22B40", VA = "0x187A23740")]
	public GICDCHDJLMK(DFJEOPPFCPN EEHFKMFHNGA, int PJOBJMPCFKF, int MGJNIOHNJEI, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7A237A0", Offset = "0x7A22BA0", VA = "0x187A237A0")]
	public GICDCHDJLMK(DFJEOPPFCPN EEHFKMFHNGA, int PJOBJMPCFKF, int MGJNIOHNJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7A23840", Offset = "0x7A22C40", VA = "0x187A23840")]
	public GICDCHDJLMK(DFJEOPPFCPN EEHFKMFHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7A232C0", Offset = "0x7A226C0", VA = "0x187A232C0", Slot = "4")]
	public bool Equals(GICDCHDJLMK DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7A23370", Offset = "0x7A22770", VA = "0x187A23370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class FHCEDKNJCLE : NNEFMGEDHJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform NIBJBBEPHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private IFOAKNFCOGF PNCCPLKBOAC;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x74192B0", Offset = "0x74186B0", VA = "0x1874192B0", Slot = "4")]
	public void ENMMELFAOHH(Transform NIBJBBEPHBE, IFOAKNFCOGF PNCCPLKBOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7A22A30", Offset = "0x7A21E30", VA = "0x187A22A30", Slot = "5")]
	public IFOAKNFCOGF AKNMNABALJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7A22B00", Offset = "0x7A21F00", VA = "0x187A22B00", Slot = "6")]
	public void GMBKDKONPDN(IFOAKNFCOGF GBHIIKIAJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public FHCEDKNJCLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class HKJMDCOKAIE : IDisposable, ABICNIIKIIP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NGAAPAOMLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public DFJEOPPFCPN oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DFJEOPPFCPN newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NGAAPAOMLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7A29B60", Offset = "0x7A28F60", VA = "0x187A29B60")]
		internal bool JGICFBDLDBF(CIEOJJILINN node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly HCAFPKIGFHP FADHLCKILFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private EIAGDFABANH EODKIBLKPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private BEJKGBEHBMC MGHLKNNNHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool FHLNFLEFOPJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly LMKAPNBAFDO PLHAIHKDACI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CIEOJJILINN IAKDDPPLCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7A24E80", Offset = "0x7A24280", VA = "0x187A24E80")]
	public bool EPKEGKOJDOF([In] NOANDGDANPO AOFGGGKINCN, bool DFBJEAHOAAK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7A26540", Offset = "0x7A25940", VA = "0x187A26540")]
	private bool NDEEDINLCCP([In] NOANDGDANPO AOFGGGKINCN, bool DFBJEAHOAAK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7A279B0", Offset = "0x7A26DB0", VA = "0x187A279B0")]
	public HKJMDCOKAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7A24DD0", Offset = "0x7A241D0", VA = "0x187A24DD0", Slot = "5")]
	public void ENMMELFAOHH(CCGBOGNLGIA BIGODBDFGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7A245C0", Offset = "0x7A239C0", VA = "0x187A245C0", Slot = "17")]
	public void AFCBAIEDACK(BCFKKFPCMOE IBDCICFCEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7A26330", Offset = "0x7A25730", VA = "0x187A26330", Slot = "12")]
	public void KLIIOIFIHMD(Func<DFJEOPPFCPN, bool> AMOMOEHDLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7A26200", Offset = "0x7A25600", VA = "0x187A26200")]
	private void KLIIOIFIHMD(HCAFPKIGFHP HAIECNDMOKO, Func<DFJEOPPFCPN, bool> AMOMOEHDLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7A24DB0", Offset = "0x7A241B0", VA = "0x187A24DB0", Slot = "11")]
	public void EMEBKIKPJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7A278D0", Offset = "0x7A26CD0", VA = "0x187A278D0", Slot = "8")]
	public bool PHLPPENILIN(DFJEOPPFCPN GMGJHJAFAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7A26B10", Offset = "0x7A25F10", VA = "0x187A26B10")]
	private bool OENFOAHKHHD(DFJEOPPFCPN OLADOINKDCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7A245F0", Offset = "0x7A239F0", VA = "0x187A245F0")]
	private static bool APNOOPADKGF(DFJEOPPFCPN OLADOINKDCK, HCAFPKIGFHP MAMDECDGAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7A25C00", Offset = "0x7A25000", VA = "0x187A25C00")]
	private void JOAHPHDEIOA(Transform IFBCOCCHIFI, HCAFPKIGFHP NCDJLHIBHLE, HCAFPKIGFHP[] BJFGINGONMD, DFJEOPPFCPN LPDANPIBNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7A24E90", Offset = "0x7A24290", VA = "0x187A24E90")]
	private GICDCHDJLMK GHHAFELDECG(Transform LNILGPMKJMG, GICDCHDJLMK NBCEMGGJBNN)
	{
		return default(GICDCHDJLMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7A24940", Offset = "0x7A23D40", VA = "0x187A24940")]
	private static bool DDPKFMMBOID(HCAFPKIGFHP MAMDECDGAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7A25FF0", Offset = "0x7A253F0", VA = "0x187A25FF0", Slot = "9")]
	public bool KAGLELJCGPC(DFJEOPPFCPN IEDEDECKPHD, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7A24B60", Offset = "0x7A23F60", VA = "0x187A24B60")]
	private bool ELBIDKOLPKI(DFJEOPPFCPN IEDEDECKPHD, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7A247C0", Offset = "0x7A23BC0", VA = "0x187A247C0")]
	private static void CJBNOBOLFPN(DFJEOPPFCPN IEDEDECKPHD, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI, HCAFPKIGFHP LEOKEEGHHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7A246A0", Offset = "0x7A23AA0", VA = "0x187A246A0")]
	private void CINDCMNPGDM(DFJEOPPFCPN JOHFAMFEDBB, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7A263B0", Offset = "0x7A257B0", VA = "0x187A263B0")]
	private void LFCNPICPIFE(HCAFPKIGFHP HAIECNDMOKO, DFJEOPPFCPN ANJHAIACNPM, DFJEOPPFCPN DPPJOLMEMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7A26340", Offset = "0x7A25740", VA = "0x187A26340")]
	private void LFCNPICPIFE(DFJEOPPFCPN EEHFKMFHNGA, DFJEOPPFCPN ANJHAIACNPM, DFJEOPPFCPN DPPJOLMEMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7A24FE0", Offset = "0x7A243E0", VA = "0x187A24FE0")]
	private void HFPDCFGBHHF(DFJEOPPFCPN EEHFKMFHNGA, DFJEOPPFCPN ANJHAIACNPM, DFJEOPPFCPN DPPJOLMEMMB, bool MNBGEAKCPMN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7A25050", Offset = "0x7A24450", VA = "0x187A25050")]
	private void HFPDCFGBHHF(HCAFPKIGFHP DGFFJNKGDJD, DFJEOPPFCPN LPDANPIBNCL, DFJEOPPFCPN NEGAFCKHNKC, bool MNBGEAKCPMN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7A26420", Offset = "0x7A25820", VA = "0x187A26420")]
	private void MKDDLMNBACN(DFJEOPPFCPN EDKEHABGEPK, int ILNIKNICLLI, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7A25700", Offset = "0x7A24B00", VA = "0x187A25700")]
	private void JHCOHLPDPDI(CIEOJJILINN GEFLCBDBKHP, CIEOJJILINN AACFIGMICEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7A25860", Offset = "0x7A24C60", VA = "0x187A25860", Slot = "18")]
	public DFJEOPPFCPN JLLGIMELECL(DFJEOPPFCPN EEHFKMFHNGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7A25280", Offset = "0x7A24680", VA = "0x187A25280", Slot = "13")]
	public void HPHOALIGNIO(DFJEOPPFCPN EEHFKMFHNGA, HashSet<DFJEOPPFCPN> BMPPPEJOGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7A259C0", Offset = "0x7A24DC0", VA = "0x187A259C0", Slot = "14")]
	public List<DFJEOPPFCPN> JLOBFBGLAJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7A25630", Offset = "0x7A24A30", VA = "0x187A25630")]
	protected CIEOJJILINN IAPKANJOCLO(CIEOJJILINN HAIECNDMOKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7A26050", Offset = "0x7A25450", VA = "0x187A26050")]
	protected HCAFPKIGFHP[] KAMMNMMNJJP(HCAFPKIGFHP MAMDECDGAAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7A27210", Offset = "0x7A26610", VA = "0x187A27210")]
	protected bool OOPINANKPDC(DFJEOPPFCPN EEHFKMFHNGA, [Out] HCAFPKIGFHP HAIECNDMOKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7A25150", Offset = "0x7A24550", VA = "0x187A25150", Slot = "15")]
	public bool HJNBGOEHJAL(DFJEOPPFCPN EEHFKMFHNGA, [Out] GICDCHDJLMK MIJAKMHBPEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7A260F0", Offset = "0x7A254F0", VA = "0x187A260F0")]
	protected HCAFPKIGFHP KGHAEBGJNFM(GICDCHDJLMK MILKOHFPMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7A24B00", Offset = "0x7A23F00", VA = "0x187A24B00", Slot = "10")]
	public bool EDDNEOABMCF(DFJEOPPFCPN JOHFAMFEDBB, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7A27320", Offset = "0x7A26720", VA = "0x187A27320")]
	private bool PEMLENKLPGO(DFJEOPPFCPN JOHFAMFEDBB, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7A26130", Offset = "0x7A25530", VA = "0x187A26130")]
	private static bool KJBGPEENHJO(HCAFPKIGFHP HNIIHAGFCBC, GICDCHDJLMK BMNNPJDJHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7A24E80", Offset = "0x7A24280", VA = "0x187A24E80", Slot = "7")]
	private bool IBCABLGJFFP([In] NOANDGDANPO AOFGGGKINCN, bool DFBJEAHOAAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class BMNNGKIBBKA : CCGBOGNLGIA, BAEPLJFAONJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly NPCGGDCACLM INELJPKBMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly BEJKGBEHBMC MGHLKNNNHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly KLDHCHIIJHM PFEILPIJCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly NOCDAGJIEGF IPOKPMLJEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly ABICNIIKIIP OFGCJBCHPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal AFLDKNFGCPL HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal HEOOFHNJICP MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal EIAGDFABANH JPHHPGKEICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool FHLNFLEFOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool LAPJLBLNCEG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HFDOLCNLFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xBCF2F0", Offset = "0xBCE6F0", VA = "0x180BCF2F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x11E56D0", Offset = "0x11E4AD0", VA = "0x1811E56D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CMCDPHOIBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xEDE7A0", Offset = "0xEDDBA0", VA = "0x180EDE7A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2527730", Offset = "0x2526B30", VA = "0x182527730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool HNABLNJKPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<DFJEOPPFCPN, DFJEOPPFCPN> OABFPFMHJKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7A1BED0", Offset = "0x7A1B2D0", VA = "0x187A1BED0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7A1BE10", Offset = "0x7A1B210", VA = "0x187A1BE10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<DFJEOPPFCPN, DFJEOPPFCPN> EABLCDGDODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7A1AFC0", Offset = "0x7A1A3C0", VA = "0x187A1AFC0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7A1BB80", Offset = "0x7A1AF80", VA = "0x187A1BB80", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<DFJEOPPFCPN, DFJEOPPFCPN, DFJEOPPFCPN> ACJCIPGPNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7A1BE70", Offset = "0x7A1B270", VA = "0x187A1BE70", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7A1BDB0", Offset = "0x7A1B1B0", VA = "0x187A1BDB0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C9E0", Offset = "0x7A1BDE0", VA = "0x187A1C9E0")]
	public BMNNGKIBBKA(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B570", Offset = "0x7A1A970", VA = "0x187A1B570", Slot = "12")]
	public void ENMMELFAOHH(GameObject GMFIIANHHCH, DIHNHJDCLEI HNBEEEEFKDP, EOEGLGNMFPM HANCNNFFPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7A1ACE0", Offset = "0x7A1A0E0", VA = "0x187A1ACE0", Slot = "26")]
	public void AECAJPPNPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C370", Offset = "0x7A1B770", VA = "0x187A1C370", Slot = "13")]
	public void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C170", Offset = "0x7A1B570", VA = "0x187A1C170", Slot = "14")]
	public void KECNLMAOALC(DFJEOPPFCPN EEHFKMFHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B410", Offset = "0x7A1A810", VA = "0x187A1B410", Slot = "15")]
	public void CODCHFHDNJL(DFJEOPPFCPN EEHFKMFHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B470", Offset = "0x7A1A870", VA = "0x187A1B470", Slot = "22")]
	public bool DLPAFENDNJJ(CHCONPFIFEN JBBAONHBPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C750", Offset = "0x7A1BB50", VA = "0x187A1C750")]
	internal bool PEMLENKLPGO([In] NOANDGDANPO AOFGGGKINCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C530", Offset = "0x7A1B930", VA = "0x187A1C530")]
	internal bool NIJIIGBJDGC([In] NOANDGDANPO AOFGGGKINCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C190", Offset = "0x7A1B590", VA = "0x187A1C190")]
	internal void LABCJKCNFBB(DFJEOPPFCPN EEHFKMFHNGA, int BBLLEHOCFGL, bool DFBJEAHOAAK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B410", Offset = "0x7A1A810", VA = "0x187A1B410")]
	internal bool MPGFICAEBMP(DFJEOPPFCPN MOMKMPNIJPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C030", Offset = "0x7A1B430", VA = "0x187A1C030")]
	internal bool JNIDIJAFKKF(DFJEOPPFCPN IEDEDECKPHD, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7A1BF30", Offset = "0x7A1B330", VA = "0x187A1BF30", Slot = "16")]
	public void HPHOALIGNIO(DFJEOPPFCPN EEHFKMFHNGA, HashSet<DFJEOPPFCPN> GOMEJJOHBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7A1ADB0", Offset = "0x7A1A1B0", VA = "0x187A1ADB0", Slot = "17")]
	public void AGGADEMPHED(DFJEOPPFCPN IEDEDECKPHD, DFJEOPPFCPN HGEJFJICMMO, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C3F0", Offset = "0x7A1B7F0", VA = "0x187A1C3F0", Slot = "18")]
	public void NGHKHLIEIDM(DFJEOPPFCPN JOHFAMFEDBB, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7A1BBE0", Offset = "0x7A1AFE0", VA = "0x187A1BBE0", Slot = "19")]
	public void FMLNMLIDHKH(DFJEOPPFCPN JOHFAMFEDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B020", Offset = "0x7A1A420", VA = "0x187A1B020")]
	public void ANIAFEMDLNL([Optional] AFBJPBGMJIG HNFJCPGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C6C0", Offset = "0x7A1BAC0", VA = "0x187A1C6C0", Slot = "23")]
	public void OKONNIKKENM(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C860", Offset = "0x7A1BC60", VA = "0x187A1C860", Slot = "20")]
	public LBFFJBPBGDL POEPKCDLFGK(bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B270", Offset = "0x7A1A670", VA = "0x187A1B270", Slot = "21")]
	public LBFFJBPBGDL BJLFAAEAFIN(HashSet<Guid> LFKOBDAGICG, bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C680", Offset = "0x7A1BA80", VA = "0x187A1C680", Slot = "25")]
	public void OIMANKPHLJJ(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B4C0", Offset = "0x7A1A8C0", VA = "0x187A1B4C0", Slot = "24")]
	public void DOAGAKMDNGI(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class BEJKGBEHBMC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly DEBGLLPOJFA<DFJEOPPFCPN, DFJEOPPFCPN> OABFPFMHJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly DEBGLLPOJFA<DFJEOPPFCPN, DFJEOPPFCPN> EABLCDGDODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly PHJFNHOIGCK<DFJEOPPFCPN, DFJEOPPFCPN, DFJEOPPFCPN> ACJCIPGPNHJ;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A970", Offset = "0x7A19D70", VA = "0x187A1A970")]
	public BEJKGBEHBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	public void ENMMELFAOHH(BMNNGKIBBKA BIGODBDFGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A890", Offset = "0x7A19C90", VA = "0x187A1A890")]
	public void KNMMDAKAGGC(DFJEOPPFCPN GEFLCBDBKHP, DFJEOPPFCPN EDKEHABGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A830", Offset = "0x7A19C30", VA = "0x187A1A830")]
	public void BEIAKIKPDLH(DFJEOPPFCPN GEFLCBDBKHP, DFJEOPPFCPN EDKEHABGEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A8F0", Offset = "0x7A19CF0", VA = "0x187A1A8F0")]
	public void PHBHEJLLBKA(DFJEOPPFCPN BCJIACDOMKL, DFJEOPPFCPN EEKCDPNNHKN, DFJEOPPFCPN EDKEHABGEPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KLDHCHIIJHM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private BMNNGKIBBKA BIGODBDFGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private HEOOFHNJICP MFHPJCBDCMN;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KLDHCHIIJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C90", Offset = "0x7A28090", VA = "0x187A28C90")]
	public void ENMMELFAOHH(BMNNGKIBBKA BIGODBDFGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C80", Offset = "0x7A28080", VA = "0x187A28C80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7A28EE0", Offset = "0x7A282E0", VA = "0x187A28EE0")]
	private void OOKDJBBIPKP(LENNHFKFEFN JAOBHFJGJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7A28C10", Offset = "0x7A28010", VA = "0x187A28C10")]
	private void APEEJEADEAO(AFBJPBGMJIG GELCADDMBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7A28DD0", Offset = "0x7A281D0", VA = "0x187A28DD0")]
	public void FHBELLOKGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7A28F20", Offset = "0x7A28320", VA = "0x187A28F20")]
	public void PBAIIHLBMCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class APKIDIGOOBE
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DDBCEPJOBAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NPCGGDCACLM container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public DDBCEPJOBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7A21B10", Offset = "0x7A20F10", VA = "0x187A21B10")]
		internal BMNNGKIBBKA CMCJPCOHAON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A5B0", Offset = "0x7A199B0", VA = "0x187A1A5B0")]
	public static void EFGBAEJALPI(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A7B0", Offset = "0x7A19BB0", VA = "0x187A1A7B0")]
	public static void PMAKDNNMJJP(NPCGGDCACLM INELJPKBMLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class OIEGEHNEPDP : IDisposable, EIAGDFABANH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, IFOAKNFCOGF> GPFDJKCCDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly BCFKKFPCMOE BHDEMMFMNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NNEFMGEDHJG IIJDAGDOKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private ABICNIIKIIP OFGCJBCHPLD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker JCNCNOBLHGJ;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7A2D110", Offset = "0x7A2C510", VA = "0x187A2D110")]
	public OIEGEHNEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C600", Offset = "0x7A2BA00", VA = "0x187A2C600", Slot = "7")]
	public void ENMMELFAOHH(ABICNIIKIIP OFGCJBCHPLD, NNEFMGEDHJG IIJDAGDOKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CE70", Offset = "0x7A2C270", VA = "0x187A2CE70", Slot = "5")]
	public void NJDEKHKLIHI(CIEOJJILINN FBNJNHLGFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C640", Offset = "0x7A2BA40", VA = "0x187A2C640", Slot = "9")]
	public void IGHDDFNHBLG(CIEOJJILINN AOOGEPHEMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C960", Offset = "0x7A2BD60", VA = "0x187A2C960", Slot = "8")]
	public void KCGBBKOPOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2CB20", Offset = "0x7A2BF20", VA = "0x187A2CB20", Slot = "10")]
	public void KMNGOCDEBOH(CIEOJJILINN EJEKIMCJMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C480", Offset = "0x7A2B880", VA = "0x187A2C480", Slot = "11")]
	public void EGKGFCFDAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C7B0", Offset = "0x7A2BBB0", VA = "0x187A2C7B0")]
	private bool JHBNDILAKNK(CIEOJJILINN LDMILEIDPGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class NOCDAGJIEGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct FEBIFDHBKOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HCAFPKIGFHP FGIMMBLACLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> LFKOBDAGICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly CHCONPFIFEN BLFDAFFGNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly CHCONPFIFEN AOOGMIGGFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool CBIPJMJFKOL;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool IPNBGLMIAHA
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7A22420", Offset = "0x7A21820", VA = "0x187A22420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7A229C0", Offset = "0x7A21DC0", VA = "0x187A229C0")]
		public FEBIFDHBKOK(HCAFPKIGFHP FGIMMBLACLG, HashSet<Guid> LFKOBDAGICG, bool CBIPJMJFKOL, [Optional] CHCONPFIFEN BLFDAFFGNFE, [Optional] CHCONPFIFEN AOOGMIGGFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7A22820", Offset = "0x7A21C20", VA = "0x187A22820")]
		public CHCONPFIFEN PEGKBLBFNLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7A22540", Offset = "0x7A21940", VA = "0x187A22540")]
		private CHCONPFIFEN HKJFPNHCIFI([Out] CHCONPFIFEN HCKKHBLCKJI, [Out] CHCONPFIFEN LANPGHHJLJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7A22600", Offset = "0x7A21A00", VA = "0x187A22600")]
		private CHCONPFIFEN LHKHKFENGFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7A222B0", Offset = "0x7A216B0", VA = "0x187A222B0")]
		private void FBMMMAHLJLF(CHCONPFIFEN EFKFGDHAIIG, CHCONPFIFEN MFENCADPFIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7A220F0", Offset = "0x7A214F0", VA = "0x187A220F0")]
		private void CGFCMFELEPM(CHCONPFIFEN HCKKHBLCKJI, CHCONPFIFEN LANPGHHJLJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private BMNNGKIBBKA BIGODBDFGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private ABICNIIKIIP OFGCJBCHPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private EIAGDFABANH EODKIBLKPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private HEOOFHNJICP MFHPJCBDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool HMKEMDNJNCO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool IHKAAJOHLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A990", Offset = "0x7A29D90", VA = "0x187A2A990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool HFDOLCNLFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7A2AED0", Offset = "0x7A2A2D0", VA = "0x187A2AED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7A2A150", Offset = "0x7A29550", VA = "0x187A2A150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A920", Offset = "0x7A29D20", VA = "0x187A2A920")]
	public void ENMMELFAOHH(BMNNGKIBBKA BIGODBDFGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C2A0", Offset = "0x7A2B6A0", VA = "0x187A2C2A0")]
	public LBFFJBPBGDL POEPKCDLFGK(bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7A29D60", Offset = "0x7A29160", VA = "0x187A29D60")]
	public LBFFJBPBGDL BJLFAAEAFIN(HashSet<Guid> LFKOBDAGICG, bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BB40", Offset = "0x7A2AF40", VA = "0x187A2BB40")]
	public void OKONNIKKENM(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A690", Offset = "0x7A29A90", VA = "0x187A2A690")]
	public void DOAGAKMDNGI(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BA20", Offset = "0x7A2AE20", VA = "0x187A2BA20")]
	public void NABIMMPAFKF(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A730", Offset = "0x7A29B30", VA = "0x187A2A730")]
	private void EJCHOALELMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BDF0", Offset = "0x7A2B1F0", VA = "0x187A2BDF0")]
	private CHCONPFIFEN PFBLPHIPEKM(HCAFPKIGFHP HAIECNDMOKO, bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7A29F00", Offset = "0x7A29300", VA = "0x187A29F00")]
	private static void CNFMOJPOAAM(HCAFPKIGFHP HAIECNDMOKO, bool CBIPJMJFKOL, CHCONPFIFEN JBBAONHBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BBD0", Offset = "0x7A2AFD0", VA = "0x187A2BBD0")]
	private void OOGEBILJCJD(HCAFPKIGFHP HAIECNDMOKO, bool CBIPJMJFKOL, CHCONPFIFEN JBBAONHBPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B990", Offset = "0x7A2AD90", VA = "0x187A2B990")]
	private CHCONPFIFEN KILFGCGJMCL(HCAFPKIGFHP FGIMMBLACLG, HashSet<Guid> LFKOBDAGICG, bool CBIPJMJFKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A170", Offset = "0x7A29570", VA = "0x187A2A170")]
	private bool DJFBHNPDOMC(LBFFJBPBGDL MDEFFKAKADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B080", Offset = "0x7A2A480", VA = "0x187A2B080")]
	private bool HHBADFAPAIB(CHCONPFIFEN JBBAONHBPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C280", Offset = "0x7A2B680", VA = "0x187A2C280")]
	private bool PMGMOCCBBLL(LBFFJBPBGDL OFGCJBCHPLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B870", Offset = "0x7A2AC70", VA = "0x187A2B870")]
	private static bool KGAEMGBBEDC(CHCONPFIFEN JBBAONHBPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A400", Offset = "0x7A29800", VA = "0x187A2A400")]
	public static bool DLPAFENDNJJ(CHCONPFIFEN JBBAONHBPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7A2AB70", Offset = "0x7A29F70", VA = "0x187A2AB70")]
	private DFJEOPPFCPN FLOEDNIIJDM(CHCONPFIFEN JBBAONHBPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7A2B6F0", Offset = "0x7A2AAF0", VA = "0x187A2B6F0")]
	private DFJEOPPFCPN INJNFHDJFFC(CHCONPFIFEN JBBAONHBPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7A2AEF0", Offset = "0x7A2A2F0", VA = "0x187A2AEF0")]
	private DFJEOPPFCPN GLKMBEEAEIL(CHCONPFIFEN JBBAONHBPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7A20950", Offset = "0x7A1FD50", VA = "0x187A20950")]
	private static Guid JLMGONMJECI(CHCONPFIFEN JBBAONHBPHP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7A2BA50", Offset = "0x7A2AE50", VA = "0x187A2BA50")]
	private string NBJJEMLMIOM(CHCONPFIFEN JBBAONHBPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7A2A9E0", Offset = "0x7A29DE0", VA = "0x187A2A9E0")]
	private bool FLNFNIOOKID(HCAFPKIGFHP HAIECNDMOKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7A2C020", Offset = "0x7A2B420", VA = "0x187A2C020")]
	private static void PILAEIGGKBG(HCAFPKIGFHP FGIMMBLACLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public NOCDAGJIEGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct NOANDGDANPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public DFJEOPPFCPN EDKEHABGEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public DFJEOPPFCPN GEFLCBDBKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int ILNIKNICLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int PJNMJPMMKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 ALLJPPEOMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion HMNHHJNIFNI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GICDCHDJLMK DHKBNIEBHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7A29C20", Offset = "0x7A29020", VA = "0x187A29C20")]
		get
		{
			return default(GICDCHDJLMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GICDCHDJLMK NBKEHAIIFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7A29CC0", Offset = "0x7A290C0", VA = "0x187A29CC0")]
		get
		{
			return default(GICDCHDJLMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7A29CF0", Offset = "0x7A290F0", VA = "0x187A29CF0")]
	public NOANDGDANPO(DFJEOPPFCPN EDKEHABGEPK, DFJEOPPFCPN GEFLCBDBKHP, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface ABICNIIKIIP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CIEOJJILINN IAKDDPPLCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENMMELFAOHH(CCGBOGNLGIA BIGODBDFGBM);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EPKEGKOJDOF([In] NOANDGDANPO AOFGGGKINCN, bool DFBJEAHOAAK = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PHLPPENILIN(DFJEOPPFCPN GMGJHJAFAIP);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KAGLELJCGPC(DFJEOPPFCPN IEDEDECKPHD, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EDDNEOABMCF(DFJEOPPFCPN JOHFAMFEDBB, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EMEBKIKPJFA();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KLIIOIFIHMD(Func<DFJEOPPFCPN, bool> AMOMOEHDLOB);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HPHOALIGNIO(DFJEOPPFCPN EEHFKMFHNGA, HashSet<DFJEOPPFCPN> BMPPPEJOGGI);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<DFJEOPPFCPN> JLOBFBGLAJJ();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HJNBGOEHJAL(DFJEOPPFCPN EEHFKMFHNGA, [Out] GICDCHDJLMK MIJAKMHBPEI);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AFCBAIEDACK(BCFKKFPCMOE IBDCICFCEPJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool BCFKKFPCMOE(CIEOJJILINN HAIECNDMOKO);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface CIEOJJILINN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DFJEOPPFCPN NHKDOKPBKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CIEOJJILINN KCNKMLOKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GICDCHDJLMK KBMLBINODDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OODJKKHIPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IFOAKNFCOGF
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGEPFBBIJLL(DFJEOPPFCPN BIAMAAOKHPH, GICDCHDJLMK EDKEHABGEPK);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFJHHHHPCCM(DFJEOPPFCPN BIAMAAOKHPH, GICDCHDJLMK EDKEHABGEPK);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBFODPINPFC(DFJEOPPFCPN BIAMAAOKHPH, GICDCHDJLMK EDKEHABGEPK);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNEDKCPNMFG(DFJEOPPFCPN BIAMAAOKHPH, GICDCHDJLMK EDKEHABGEPK);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IFOAKNFCOGF Instantiate(Transform NIBJBBEPHBE);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLKCCHLFIFB();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NNEFMGEDHJG
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENMMELFAOHH(Transform NIBJBBEPHBE, IFOAKNFCOGF PNCCPLKBOAC);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IFOAKNFCOGF AKNMNABALJE();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMBKDKONPDN(IFOAKNFCOGF GBHIIKIAJMF);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface AFLDKNFGCPL : KDDDKHKODED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBDGECNGAAJ();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JOPBJDLEPBO(Guid MGDNCABPODA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface EIAGDFABANH
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJDEKHKLIHI(CIEOJJILINN FBNJNHLGFHD);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENMMELFAOHH(ABICNIIKIIP OFGCJBCHPLD, NNEFMGEDHJG OPIHAEACFLH);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KCGBBKOPOBO();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGHDDFNHBLG(CIEOJJILINN AOOGEPHEMCD);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMNGOCDEBOH(CIEOJJILINN EJEKIMCJMLN);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGKGFCFDAGK();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class HCAFPKIGFHP : CIEOJJILINN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IBCLOAMLMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GICDCHDJLMK nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public HCAFPKIGFHP foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public IBCLOAMLMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A27B80", Offset = "0x7A26F80", VA = "0x187A27B80")]
		internal bool FHNGNHHNDPG(CIEOJJILINN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private GICDCHDJLMK MIJAKMHBPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<HCAFPKIGFHP> DNOAAJMKEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private HCAFPKIGFHP FAIKOLFMHLA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GICDCHDJLMK KBMLBINODDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x11E5320", Offset = "0x11E4720", VA = "0x1811E5320", Slot = "6")]
		get
		{
			return default(GICDCHDJLMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x11E5050", Offset = "0x11E4450", VA = "0x1811E5050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private HCAFPKIGFHP GEFLCBDBKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A23D30", Offset = "0x7A23130", VA = "0x187A23D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public CIEOJJILINN KCNKMLOKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DFJEOPPFCPN NHKDOKPBKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OODJKKHIPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7A24060", Offset = "0x7A23460", VA = "0x187A24060", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OFDJHOLIADP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A24070", Offset = "0x7A23470", VA = "0x187A24070", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected HCAFPKIGFHP DGFFJNKGDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A23BC0", Offset = "0x7A22FC0", VA = "0x187A23BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A24350", Offset = "0x7A23750", VA = "0x187A24350")]
	public HCAFPKIGFHP(GICDCHDJLMK EHCOOLJKDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7A23E10", Offset = "0x7A23210", VA = "0x187A23E10")]
	public HCAFPKIGFHP IJGKMPINBMM(GICDCHDJLMK INCIDILAHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7A23A40", Offset = "0x7A22E40", VA = "0x187A23A40")]
	public HCAFPKIGFHP DAIKILGEFGF(GICDCHDJLMK ICNEKLHOEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7A240C0", Offset = "0x7A234C0", VA = "0x187A240C0")]
	public HCAFPKIGFHP NMPKBAOEGPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7A23BE0", Offset = "0x7A22FE0", VA = "0x187A23BE0")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7A242A0", Offset = "0x7A236A0", VA = "0x187A242A0")]
	public HCAFPKIGFHP PJDJIDJPMLL(GICDCHDJLMK EEKCDPNNHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7A238E0", Offset = "0x7A22CE0", VA = "0x187A238E0")]
	private static void AFCBAIEDACK(HCAFPKIGFHP DLACOJGBONN, BCFKKFPCMOE LLGAMDBNNCE, bool FHDOAEJIJCB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7A238D0", Offset = "0x7A22CD0", VA = "0x187A238D0", Slot = "9")]
	public void AFCBAIEDACK(BCFKKFPCMOE IBDCICFCEPJ, bool MNBGEAKCPMN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7A23F60", Offset = "0x7A23360", VA = "0x187A23F60")]
	public static HCAFPKIGFHP KGHAEBGJNFM(HCAFPKIGFHP DLACOJGBONN, GICDCHDJLMK OGNKGKABOBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface HEOOFHNJICP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IHKAAJOHLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool CCKFFFNOJND
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<LENNHFKFEFN> OOKDJBBIPKP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<AFBJPBGMJIG> APEEJEADEAO;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HGEPFBBIJLL(BMNNGKIBBKA BIGODBDFGBM, EOEGLGNMFPM JLOGFNEDBJH);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AGGADEMPHED(DFJEOPPFCPN IEDEDECKPHD, DFJEOPPFCPN HGEJFJICMMO, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NGHKHLIEIDM(DFJEOPPFCPN JOHFAMFEDBB, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KCCNANEILPP(LBFFJBPBGDL JBHPPGCBPIF, [Optional] AFBJPBGMJIG HNFJCPGGLND);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NBFMOPNDFHC
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type PLJKCMOLLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A29A60", Offset = "0x7A28E60", VA = "0x187A29A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object IADGMEFIGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A29AC0", Offset = "0x7A28EC0", VA = "0x187A29AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A29B00", Offset = "0x7A28F00", VA = "0x187A29B00")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class JMPKACIGIKH : HEOOFHNJICP, IDisposable, DIPFIIABABL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private BMNNGKIBBKA BIGODBDFGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private EOEGLGNMFPM HANCNNFFPOD;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool IHKAAJOHLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A27F80", Offset = "0x7A27380", VA = "0x187A27F80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool CCKFFFNOJND
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A281C0", Offset = "0x7A275C0", VA = "0x187A281C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView HHHKIKPIAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A27DF0", Offset = "0x7A271F0", VA = "0x187A27DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<LENNHFKFEFN> OOKDJBBIPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A28090", Offset = "0x7A27490", VA = "0x187A28090", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7A28200", Offset = "0x7A27600", VA = "0x187A28200", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<AFBJPBGMJIG> APEEJEADEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A27ED0", Offset = "0x7A272D0", VA = "0x187A27ED0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A27FE0", Offset = "0x7A273E0", VA = "0x187A27FE0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A28130", Offset = "0x7A27530", VA = "0x187A28130", Slot = "10")]
	public void HGEPFBBIJLL(BMNNGKIBBKA BIGODBDFGBM, EOEGLGNMFPM HANCNNFFPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7A27E80", Offset = "0x7A27280", VA = "0x187A27E80", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7A27CC0", Offset = "0x7A270C0", VA = "0x187A27CC0", Slot = "11")]
	public void AGGADEMPHED(DFJEOPPFCPN IEDEDECKPHD, DFJEOPPFCPN HGEJFJICMMO, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7A283D0", Offset = "0x7A277D0", VA = "0x187A283D0", Slot = "12")]
	public void NGHKHLIEIDM(DFJEOPPFCPN JOHFAMFEDBB, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7A282A0", Offset = "0x7A276A0", VA = "0x187A282A0", Slot = "13")]
	public void KCCNANEILPP(LBFFJBPBGDL JBHPPGCBPIF, [Optional] AFBJPBGMJIG HNFJCPGGLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7A28740", Offset = "0x7A27B40", VA = "0x187A28740")]
	[IGHOEJMCFGB]
	private void RpcMasterReparentNodes(DFJEOPPFCPN JOHFAMFEDBB, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7A28540", Offset = "0x7A27940", VA = "0x187A28540")]
	[IGHOEJMCFGB]
	private void RpcMasterModifyNode(DFJEOPPFCPN IEDEDECKPHD, DFJEOPPFCPN HGEJFJICMMO, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7A28B10", Offset = "0x7A27F10", VA = "0x187A28B10")]
	[IGHOEJMCFGB]
	private void RpcReparentNodes(DFJEOPPFCPN JOHFAMFEDBB, int JMGCDNNGDDA, DFJEOPPFCPN EEKCDPNNHKN, int POMHEDMIOPJ, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI, KALPENGLBBA JAHKIAGKPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7A28A50", Offset = "0x7A27E50", VA = "0x187A28A50")]
	[IGHOEJMCFGB]
	private void RpcModifyNode(DFJEOPPFCPN IEDEDECKPHD, int ILNIKNICLLI, int PJNMJPMMKID, Vector3 ALLJPPEOMKN, Quaternion HMNHHJNIFNI, KALPENGLBBA JAHKIAGKPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7A28500", Offset = "0x7A27900", VA = "0x187A28500")]
	[IGHOEJMCFGB]
	private void RpcDeserializeConnectableGraph(LBFFJBPBGDL OFGCJBCHPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public JMPKACIGIKH()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, IFOAKNFCOGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7A29740", Offset = "0x7A28B40", VA = "0x187A29740", Slot = "4")]
		private void PGOKICFCKND(DFJEOPPFCPN BIAMAAOKHPH, GICDCHDJLMK EDKEHABGEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7A29450", Offset = "0x7A28850", VA = "0x187A29450", Slot = "5")]
		private void KHIAAABBPMK(DFJEOPPFCPN BIAMAAOKHPH, GICDCHDJLMK EDKEHABGEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7A292F0", Offset = "0x7A286F0", VA = "0x187A292F0", Slot = "6")]
		private void HKGEHEIENAB(DFJEOPPFCPN BIAMAAOKHPH, GICDCHDJLMK EDKEHABGEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A290A0", Offset = "0x7A284A0", VA = "0x187A290A0", Slot = "7")]
		private void FMALIKMANPF(DFJEOPPFCPN BIAMAAOKHPH, GICDCHDJLMK EDKEHABGEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7A296D0", Offset = "0x7A28AD0", VA = "0x187A296D0", Slot = "8")]
		private IFOAKNFCOGF NCHICMMAOBP(Transform NIBJBBEPHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A29290", Offset = "0x7A28690", VA = "0x187A29290", Slot = "9")]
		private void GGCGGPPHKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class MEPNIBEFPEF
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x37B8FD0", Offset = "0x37B83D0", VA = "0x1837B8FD0")]
	public static EPAFAAKHGHP<T> EODIPHMAKHL<T>(this NPCGGDCACLM INELJPKBMLP)
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
