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
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D248E0", Offset = "0x6D23CE0", VA = "0x186D248E0", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private OGGMFKFHPGE bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private OGGMFKFHPGE bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D26350", Offset = "0x6D25750", VA = "0x186D26350", Slot = "5")]
		public override void OHILFHDNMJH(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D261E0", Offset = "0x6D255E0", VA = "0x186D261E0")]
		private void MBBEPNKNMNH(OOCPEHCJIIC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D26070", Offset = "0x6D25470", VA = "0x186D26070")]
		private void EJEJNAHOGMG(OOCPEHCJIIC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D25D40", Offset = "0x6D25140", VA = "0x186D25D40", Slot = "6")]
		public override void CKKGPJCNOFN(OOCPEHCJIIC registry, [In] DEPDLDENAIO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D26390", Offset = "0x6D25790", VA = "0x186D26390")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class KOCMLCFLBBG : OOJCGLBDLHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class PKMELLGKAIK : IEnumerable<HCKPLPPJLND>, IEnumerable, IEnumerator<HCKPLPPJLND>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HCKPLPPJLND <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private EJCLGEIBEFL localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EJCLGEIBEFL <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KOCMLCFLBBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PPOAFIPMFHM <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CLMKKAKLCJG.PEIPMKOMHNB <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HCKPLPPJLND System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public PKMELLGKAIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D25A70", Offset = "0x6D24E70", VA = "0x186D25A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D25590", Offset = "0x6D24990", VA = "0x186D25590", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D25950", Offset = "0x6D24D50", VA = "0x186D25950")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D25A20", Offset = "0x6D24E20", VA = "0x186D25A20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D25970", Offset = "0x6D24D70", VA = "0x186D25970", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCKPLPPJLND> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D25970", Offset = "0x6D24D70", VA = "0x186D25970", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class AHEACODHAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public KOCMLCFLBBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AFLNLKDBMAP nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public AHEACODHAPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D12F50", Offset = "0x6D12350", VA = "0x186D12F50")]
		internal object DMGNJKHAICF(AFLNLKDBMAP x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OEIACOFPKBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AFLNLKDBMAP child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AHEACODHAPC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OEIACOFPKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D25340", Offset = "0x6D24740", VA = "0x186D25340")]
		internal object IAODKOCPBEN((AFLNLKDBMAP child, AFLNLKDBMAP nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly EGGMDNJPOBA CNAPPKFNODF;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly EGGMDNJPOBA LHEHMKJNBFG;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly EGGMDNJPOBA OAHKHHCKLII;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly EGGMDNJPOBA IGLPBMFCEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JMIJGNILGFN KAGHOAPECPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GFPBNCMKEGA IDIMPCEPAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private JMKBLOINLLH JDDGELLHCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private KJLBIGLFNNH AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private JJJAFANJKFB KGEGFAPDDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DHMPLOKIFHG NEOPINGDODK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IMHJEBACLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC680", Offset = "0x8BBA80", VA = "0x1808BC680", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BC290", Offset = "0x8BB690", VA = "0x1808BC290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FLOIBCOPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<HCKPLPPJLND, HCKPLPPJLND> FNLMDEJCFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D20F70", Offset = "0x6D20370", VA = "0x186D20F70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D1FE60", Offset = "0x6D1F260", VA = "0x186D1FE60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<HCKPLPPJLND, HCKPLPPJLND> IPEFEFBHDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D1F500", Offset = "0x6D1E900", VA = "0x186D1F500", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D1FDB0", Offset = "0x6D1F1B0", VA = "0x186D1FDB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<HCKPLPPJLND, HCKPLPPJLND, HCKPLPPJLND> MOJODAHOMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D20880", Offset = "0x6D1FC80", VA = "0x186D20880", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D21C30", Offset = "0x6D21030", VA = "0x186D21C30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D21FC0", Offset = "0x6D213C0", VA = "0x186D21FC0")]
	public KOCMLCFLBBG(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D20D00", Offset = "0x6D20100", VA = "0x186D20D00", Slot = "12")]
	public void JLABJFAHLGH(GameObject JPONDMDOHLN, HMKONNPCKAH DMCPDKIDLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EE50", Offset = "0x6D1E250", VA = "0x186D1EE50", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DE70", Offset = "0x6D1D270", VA = "0x186D1DE70", Slot = "22")]
	public bool BPBJKPMKCMO(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D21720", Offset = "0x6D20B20", VA = "0x186D21720")]
	private void MHGJFFHGEBM(EJCLGEIBEFL FMLHOPLCHFJ, EJCLGEIBEFL CPNGOIDPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DBE0", Offset = "0x6D1CFE0", VA = "0x186D1DBE0")]
	private void BOBCPMHGEGG(EJCLGEIBEFL FMLHOPLCHFJ, EJCLGEIBEFL FODGJGDJLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D1D980", Offset = "0x6D1CD80", VA = "0x186D1D980")]
	private void BHCHFLLEPCG(EJCLGEIBEFL FMLHOPLCHFJ, EJCLGEIBEFL FODGJGDJLPL, EJCLGEIBEFL CPNGOIDPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F9A0", Offset = "0x6D1EDA0", VA = "0x186D1F9A0")]
	private void FBPFGAHEJOJ(EJCLGEIBEFL FMLHOPLCHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "13")]
	public void BNOGHBKOPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D21920", Offset = "0x6D20D20", VA = "0x186D21920", Slot = "14")]
	public void PFLPBBOAAPI(HCKPLPPJLND PAMBKKEPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "15")]
	public void LCBAONAKPAP(HCKPLPPJLND PAMBKKEPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D20120", Offset = "0x6D1F520", VA = "0x186D20120", Slot = "17")]
	public void GMAAJNBHEME(HCKPLPPJLND PAMBKKEPPAN, HCKPLPPJLND MGNCLNEDOBB, Vector3 MIPHEMMOPOK, Quaternion ECBCCENFGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D20280", Offset = "0x6D1F680", VA = "0x186D20280")]
	public void GMAAJNBHEME(EJCLGEIBEFL BBNLJLBANGM, EJCLGEIBEFL MGNCLNEDOBB, Vector3 MIPHEMMOPOK, Quaternion ECBCCENFGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D21350", Offset = "0x6D20750", VA = "0x186D21350")]
	public void KOACODCJOGB(HCKPLPPJLND PAMBKKEPPAN, float NDFBABACJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F700", Offset = "0x6D1EB00", VA = "0x186D1F700", Slot = "18")]
	public void ELKKMJODBFJ(HCKPLPPJLND ICIGMOHLOFB, int BFINJMCFIHB, HCKPLPPJLND KANEKDDILKA, int ANACINBDEHK, Vector3 MIPHEMMOPOK, Quaternion ECBCCENFGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EB10", Offset = "0x6D1DF10", VA = "0x186D1EB10")]
	private float DHKLKLMCKNL(EJCLGEIBEFL BBNLJLBANGM, EJCLGEIBEFL IIOPLDELPHL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F5D0", Offset = "0x6D1E9D0", VA = "0x186D1F5D0")]
	public void ELKKMJODBFJ(EJCLGEIBEFL BBNLJLBANGM, EJCLGEIBEFL IIOPLDELPHL, Vector3 MIPHEMMOPOK, Quaternion ECBCCENFGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F850", Offset = "0x6D1EC50", VA = "0x186D1F850")]
	public void ELKKMJODBFJ(EJCLGEIBEFL BBNLJLBANGM, EJCLGEIBEFL IIOPLDELPHL, Vector3 MIPHEMMOPOK, Quaternion ECBCCENFGFM, float NDFBABACJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D213E0", Offset = "0x6D207E0", VA = "0x186D213E0", Slot = "19")]
	public void LFNJGMKIBNJ(HCKPLPPJLND PAMBKKEPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EBC0", Offset = "0x6D1DFC0", VA = "0x186D1EBC0")]
	public bool DPINEJOFPJM(EJCLGEIBEFL GKKCCKNHJKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FF10", Offset = "0x6D1F310", VA = "0x186D1FF10", Slot = "16")]
	public void GFICHACBBOK(HCKPLPPJLND PAMBKKEPPAN, HashSet<HCKPLPPJLND> KMHJDMKODKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "20")]
	public DHNLHLMGAND PPFAABBADNM(bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "21")]
	public DHNLHLMGAND FHMBOCKNMEP(HashSet<Guid> GCDKPEOGBLD, bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D21020", Offset = "0x6D20420", VA = "0x186D21020", Slot = "23")]
	public void JPNBOGLMOMK(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DE00", Offset = "0x6D1D200", VA = "0x186D1DE00", Slot = "24")]
	public void BOOOINIFBCI(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F5B0", Offset = "0x6D1E9B0", VA = "0x186D1F5B0", Slot = "25")]
	public void EHEDGAANDBE(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D209A0", Offset = "0x6D1FDA0", VA = "0x186D209A0")]
	private void JIAACNCFJPP(EJCLGEIBEFL BBNLJLBANGM, EJCLGEIBEFL IIOPLDELPHL, Vector3 MIPHEMMOPOK, Quaternion ECBCCENFGFM, float NDFBABACJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E560", Offset = "0x6D1D960", VA = "0x186D1E560")]
	private void DGEDIILFJMH(EJCLGEIBEFL BBNLJLBANGM, EJCLGEIBEFL FFCFOAEFPGC, Vector3 MIPHEMMOPOK, Quaternion ECBCCENFGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D20930", Offset = "0x6D1FD30", VA = "0x186D20930")]
	private void JCHGILNNALI(EJCLGEIBEFL BBNLJLBANGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1D8F0", Offset = "0x6D1CCF0", VA = "0x186D1D8F0")]
	[IteratorStateMachine(typeof(PKMELLGKAIK))]
	public IEnumerable<HCKPLPPJLND> BCKJNEIHELK(EJCLGEIBEFL GKKCCKNHJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F3D0", Offset = "0x6D1E7D0", VA = "0x186D1F3D0")]
	internal HCKPLPPJLND EBEOKPPMNAA(EJCLGEIBEFL GKKCCKNHJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D21220", Offset = "0x6D20620", VA = "0x186D21220")]
	internal EJCLGEIBEFL KKHDFBIEACJ(HCKPLPPJLND PAMBKKEPPAN)
	{
		return default(EJCLGEIBEFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DFD0", Offset = "0x6D1D3D0", VA = "0x186D1DFD0")]
	private bool DELNCCLPDBN(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D212F0", Offset = "0x6D206F0", VA = "0x186D212F0")]
	private bool KMMNECBOHIA(AFLNLKDBMAP KFGHKJHEFCL, [Out] HCKPLPPJLND IIOPLDELPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F040", Offset = "0x6D1E440", VA = "0x186D1F040")]
	private HCKPLPPJLND EBEOKPPMNAA(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D21090", Offset = "0x6D20490", VA = "0x186D21090")]
	private HCKPLPPJLND KKHBHPJFBPC(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D21550", Offset = "0x6D20950", VA = "0x186D21550")]
	private HCKPLPPJLND LMDCEPKMBJF(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D1CA90", Offset = "0x6D1BE90", VA = "0x186D1CA90")]
	private static Guid HFENBNLABCE(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F8B0", Offset = "0x6D1ECB0", VA = "0x186D1F8B0")]
	private string EOGCHPLHAEB(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E980", Offset = "0x6D1DD80", VA = "0x186D1E980")]
	private void DHHBHFFLCKA(HCKPLPPJLND BBNLJLBANGM, HCKPLPPJLND FFCFOAEFPGC, RigidTransform GPIAIHBJNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D21CE0", Offset = "0x6D210E0", VA = "0x186D21CE0")]
	private void PNGFKEGGLCG(HCKPLPPJLND FFCFOAEFPGC, HCKPLPPJLND BBNLJLBANGM, RigidTransform GPIAIHBJNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D203C0", Offset = "0x6D1F7C0", VA = "0x186D203C0")]
	private void HALMAFJEKAH(HCKPLPPJLND EJCOGOCMDDO, HCKPLPPJLND BBNLJLBANGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D206F0", Offset = "0x6D1FAF0", VA = "0x186D206F0")]
	private void HNHOPOMLFPP(HCKPLPPJLND BBNLJLBANGM, HCKPLPPJLND IIOPLDELPHL, RigidTransform GPIAIHBJNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DEC0", Offset = "0x6D1D2C0", VA = "0x186D1DEC0")]
	private void CPENJMPDGFJ(EJCLGEIBEFL GKKCCKNHJKG, HCKPLPPJLND PAMBKKEPPAN, EJCLGEIBEFL FODGJGDJLPL, EJCLGEIBEFL CPNGOIDPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D20420", Offset = "0x6D1F820", VA = "0x186D20420")]
	private void HMOHJNKLBPH(EJCLGEIBEFL GKKCCKNHJKG, HCKPLPPJLND PAMBKKEPPAN, HCKPLPPJLND PELFHDFGIND, HCKPLPPJLND KNIGLOAPIND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GHMAGOGMDLF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NOFCIEHLIOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ACFNHMKNHLL container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NOFCIEHLIOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D24E20", Offset = "0x6D24220", VA = "0x186D24E20")]
		internal KOCMLCFLBBG DEEFIBIJNII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D17870", Offset = "0x6D16C70", VA = "0x186D17870")]
	public static void FJGMHLONPAJ(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6D179F0", Offset = "0x6D16DF0", VA = "0x186D179F0")]
	public static void JCNDPHBLMKI(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FNPBFGMECBN : COLKPNKJFHM, CKBAIAAGHAE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx DODIHPOGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly KOCMLCFLBBG DECNJHGFMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly PLBLEJIEHCI LPOMAJEOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NOIAMFGAHDF AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly AHGPLPAJDJB[] KADENBBEPJL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EJCLGEIBEFL BENKNCHEADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(EJCLGEIBEFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HCKPLPPJLND HELJHGPJFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D17640", Offset = "0x6D16A40", VA = "0x186D17640", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HCKPLPPJLND PECDDKNPJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D16D50", Offset = "0x6D16150", VA = "0x186D16D50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 PEFCHBNBNAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D17090", Offset = "0x6D16490", VA = "0x186D17090", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion JOIOJOGGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D168F0", Offset = "0x6D15CF0", VA = "0x186D168F0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GDLNEHOPHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D17300", Offset = "0x6D16700", VA = "0x186D17300", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<HCKPLPPJLND> EOANJAGNJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D16870", Offset = "0x6D15C70", VA = "0x186D16870", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool INOKBMMCFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x91A180", Offset = "0x919580", VA = "0x18091A180", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x91F860", Offset = "0x91EC60", VA = "0x18091F860", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform GCKCOGKHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D17850", Offset = "0x6D16C50", VA = "0x186D17850", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject IPFINNCCMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x27EC650", Offset = "0x27EBA50", VA = "0x1827EC650", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D17570", Offset = "0x6D16970", VA = "0x186D17570", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid OAOGJDIJOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D176A0", Offset = "0x6D16AA0", VA = "0x186D176A0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MHGEIBCAPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D17780", Offset = "0x6D16B80", VA = "0x186D17780", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DBBHAJLIPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool CLMEFABBONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D16FA0", Offset = "0x6D163A0", VA = "0x186D16FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event OCGMKEFMABL KHKACAEBGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D16810", Offset = "0x6D15C10", VA = "0x186D16810", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6D15EB0", Offset = "0x6D152B0", VA = "0x186D15EB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event OCGMKEFMABL BJECEKNKGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D16F40", Offset = "0x6D16340", VA = "0x186D16F40", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6D15E50", Offset = "0x6D15250", VA = "0x186D15E50", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event OCGMKEFMABL KBFLPDGEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D16E90", Offset = "0x6D16290", VA = "0x186D16E90", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D17370", Offset = "0x6D16770", VA = "0x186D17370", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event ILDOAGOFDPM EDLHINJLOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D15F90", Offset = "0x6D15390", VA = "0x186D15F90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D16FF0", Offset = "0x6D163F0", VA = "0x186D16FF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D17470", Offset = "0x6D16870", VA = "0x186D17470")]
	public FNPBFGMECBN(EJCLGEIBEFL CCLCAJPAGBH, RigidbodyEx DODIHPOGMBH, PLBLEJIEHCI LPOMAJEOJOA, AHGPLPAJDJB[] KADENBBEPJL, NOIAMFGAHDF AJKICPHDFFF, OOJCGLBDLHD DECNJHGFMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D16E60", Offset = "0x6D16260", VA = "0x186D16E60", Slot = "19")]
	public void JBLDGJLDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "21")]
	public void FKPNMEJNGKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B6F640", Offset = "0x6B6EA40", VA = "0x186B6F640", Slot = "22")]
	public void KENDJOPAKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D16E10", Offset = "0x6D16210", VA = "0x186D16E10", Slot = "20")]
	public void IOGIABOPHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D170F0", Offset = "0x6D164F0", VA = "0x186D170F0", Slot = "25")]
	public void OCCJOMIEOLI(int LELIJNDCAOG, HCKPLPPJLND KANEKDDILKA, int HPBOAAAONAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D15A70", Offset = "0x6D14E70", VA = "0x186D15A70", Slot = "26")]
	public void AAEJEDJNBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D16530", Offset = "0x6D15930", VA = "0x186D16530", Slot = "27")]
	public void DLOAJNLMBEE(int LELIJNDCAOG, HCKPLPPJLND ICIGMOHLOFB, int GOFPNFHAADC, [Optional] Vector3? JHPBPDLNLMB, [Optional] Quaternion? KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D15F10", Offset = "0x6D15310", VA = "0x186D15F10", Slot = "28")]
	public void BOCHGECJPMO(HCKPLPPJLND ICIGMOHLOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D16120", Offset = "0x6D15520", VA = "0x186D16120", Slot = "31")]
	public void DGLKMFHNIFM(Vector3 JHBGMEMLODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D15B40", Offset = "0x6D14F40", VA = "0x186D15B40", Slot = "29")]
	public void AKBGBFLAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D16B50", Offset = "0x6D15F50", VA = "0x186D16B50", Slot = "30")]
	public void IFKDOOBNHGM(int AEAHMAMPNLO, Vector3 JMOAHJJIPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D16A80", Offset = "0x6D15E80", VA = "0x186D16A80", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int LELIJNDCAOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D16950", Offset = "0x6D15D50", VA = "0x186D16950", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int LELIJNDCAOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9BB7B0", Offset = "0x9BABB0", VA = "0x1809BB7B0", Slot = "42")]
	public Color GetConnectionSlotColor(int LELIJNDCAOG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D16080", Offset = "0x6D15480", VA = "0x186D16080", Slot = "43")]
	public bool CanConnectTo(int LELIJNDCAOG, HCKPLPPJLND IMDPHCFOPPO, int CNHEIGNKFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "44")]
	public void ParentChanged(int LELIJNDCAOG, HCKPLPPJLND FAOMFIFJPPC, int ICDHBINBCMF, Vector3 BDAOOFKPJDL, Quaternion AOCBHFJHCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "45")]
	public void ChildAdded(int LELIJNDCAOG, HCKPLPPJLND FJAELAJBDIN, int CLCKHGBNNAA, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "46")]
	public void ChildRemoved(int LELIJNDCAOG, HCKPLPPJLND GLNANGOBFHP, int EEPGOOGCEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "47")]
	public void ConnectionModified(int LELIJNDCAOG, HCKPLPPJLND KANEKDDILKA, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D173D0", Offset = "0x6D167D0", VA = "0x186D173D0", Slot = "48")]
	public void RootChanged(HCKPLPPJLND GHAFBOBNDIH, HCKPLPPJLND OJDAODAMGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D168A0", Offset = "0x6D15CA0", VA = "0x186D168A0", Slot = "23")]
	public void EPFJHBAODBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D16EF0", Offset = "0x6D162F0", VA = "0x186D16EF0", Slot = "24")]
	public void MFGKPBNJOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D16030", Offset = "0x6D15430", VA = "0x186D16030")]
	private void CGHOIJFPELD(bool JKPFGMEPNHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DKHNDPDIDGH(typeof(EBDHEHNLCHB), new string[] { })]
public class NPOLBJHNKPJ : EBDHEHNLCHB, KHBMANBAPGM
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PPMFODAIFDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public NPOLBJHNKPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CLMKKAKLCJG localIds;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PPMFODAIFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6D25AD0", Offset = "0x6D24ED0", VA = "0x186D25AD0")]
		internal void OOBAKBGMMKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[FLHBEOFNNOB]
	private MIHHKGLIJBP IMMBGNDBPHG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object DPEAFPNBIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D24ED0", Offset = "0x6D242D0", VA = "0x186D24ED0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6D250C0", Offset = "0x6D244C0", VA = "0x186D250C0", Slot = "6")]
	public void InitReferences(IAKDMLIJPDA NEOPINGDODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D24F60", Offset = "0x6D24360", VA = "0x186D24F60", Slot = "5")]
	public void ICPDGHOIFBB(CLMKKAKLCJG IPALMIGMDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public NPOLBJHNKPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DKHNDPDIDGH(typeof(OOJCGLBDLHD), new string[] { "Ignore", "Mock" })]
public class EPLCECOPCOE : OOJCGLBDLHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool IMHJEBACLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool FLOIBCOPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HCKPLPPJLND, HCKPLPPJLND> FNLMDEJCFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D15910", Offset = "0x6D14D10", VA = "0x186D15910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6D157B0", Offset = "0x6D14BB0", VA = "0x186D157B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<HCKPLPPJLND, HCKPLPPJLND> IPEFEFBHDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D15650", Offset = "0x6D14A50", VA = "0x186D15650", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D15700", Offset = "0x6D14B00", VA = "0x186D15700", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<HCKPLPPJLND, HCKPLPPJLND, HCKPLPPJLND> MOJODAHOMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D15860", Offset = "0x6D14C60", VA = "0x186D15860", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D159C0", Offset = "0x6D14DC0", VA = "0x186D159C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "12")]
	public void JLABJFAHLGH(GameObject JPONDMDOHLN, HMKONNPCKAH DMCPDKIDLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "13")]
	public void BNOGHBKOPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "14")]
	public void PFLPBBOAAPI(HCKPLPPJLND PAMBKKEPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "15")]
	public void LCBAONAKPAP(HCKPLPPJLND PAMBKKEPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "16")]
	public void GFICHACBBOK(HCKPLPPJLND PAMBKKEPPAN, HashSet<HCKPLPPJLND> KMHJDMKODKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "17")]
	public void GMAAJNBHEME(HCKPLPPJLND PAMBKKEPPAN, HCKPLPPJLND MGNCLNEDOBB, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "18")]
	public void ELKKMJODBFJ(HCKPLPPJLND PAMBKKEPPAN, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "19")]
	public void LFNJGMKIBNJ(HCKPLPPJLND PAMBKKEPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "20")]
	public DHNLHLMGAND PPFAABBADNM(bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "21")]
	public DHNLHLMGAND FHMBOCKNMEP(HashSet<Guid> GCDKPEOGBLD, bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "22")]
	public bool BPBJKPMKCMO(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "23")]
	public void JPNBOGLMOMK(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "24")]
	public void BOOOINIFBCI(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "25")]
	public void EHEDGAANDBE(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public EPLCECOPCOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HCKPLPPJLND : CKBAIAAGHAE, IEquatable<HCKPLPPJLND>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CKBAIAAGHAE
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HCKPLPPJLND HELJHGPJFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform GCKCOGKHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject IPFINNCCMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string BKJCNMKILGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid OAOGJDIJOML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int MHGEIBCAPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EJCLGEIBEFL BENKNCHEADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DBBHAJLIPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int LELIJNDCAOG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int LELIJNDCAOG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int LELIJNDCAOG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int LELIJNDCAOG, HCKPLPPJLND IMDPHCFOPPO, int HMOKFIGABDD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int LELIJNDCAOG, HCKPLPPJLND FAOMFIFJPPC, int ICDHBINBCMF, Vector3 BDAOOFKPJDL, Quaternion AOCBHFJHCNO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int LELIJNDCAOG, HCKPLPPJLND FJAELAJBDIN, int CLCKHGBNNAA, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int LELIJNDCAOG, HCKPLPPJLND GLNANGOBFHP, int EEPGOOGCEHM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int LELIJNDCAOG, HCKPLPPJLND KANEKDDILKA, int IFGFEFPHION, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(HCKPLPPJLND GHAFBOBNDIH, HCKPLPPJLND OJDAODAMGNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[CMNNIKGKEON(MFDGBKGGINJ.OMRoom)]
public interface OOJCGLBDLHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool IMHJEBACLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FLOIBCOPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HCKPLPPJLND, HCKPLPPJLND> FNLMDEJCFBF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HCKPLPPJLND, HCKPLPPJLND> IPEFEFBHDMJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HCKPLPPJLND, HCKPLPPJLND, HCKPLPPJLND> MOJODAHOMNL;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JLABJFAHLGH(GameObject JPONDMDOHLN, HMKONNPCKAH DMCPDKIDLBJ);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BNOGHBKOPKE();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PFLPBBOAAPI(HCKPLPPJLND PAMBKKEPPAN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LCBAONAKPAP(HCKPLPPJLND PAMBKKEPPAN);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GFICHACBBOK(HCKPLPPJLND PAMBKKEPPAN, HashSet<HCKPLPPJLND> KMHJDMKODKG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GMAAJNBHEME(HCKPLPPJLND PAMBKKEPPAN, HCKPLPPJLND MGNCLNEDOBB, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ELKKMJODBFJ(HCKPLPPJLND PAMBKKEPPAN, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LFNJGMKIBNJ(HCKPLPPJLND PAMBKKEPPAN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DHNLHLMGAND PPFAABBADNM(bool BKNHBJEMKFB);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	DHNLHLMGAND FHMBOCKNMEP(HashSet<Guid> GCDKPEOGBLD, bool BKNHBJEMKFB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BPBJKPMKCMO(AFLNLKDBMAP KFGHKJHEFCL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JPNBOGLMOMK(DHNLHLMGAND GFHEHGHBDMK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BOOOINIFBCI(DHNLHLMGAND GFHEHGHBDMK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EHEDGAANDBE(DHNLHLMGAND GFHEHGHBDMK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KJLBIGLFNNH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool ELNEGCNFJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HCKPLPPJLND LMDCEPKMBJF(int CGNAJJFLOLA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCKPLPPJLND KKHBHPJFBPC(Guid CCOIKFPNJLO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CBHEINPALHK(HCKPLPPJLND PAMBKKEPPAN);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LFBEMPLHMGI();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PBPPKOIOEEC(HCKPLPPJLND LPOMAJEOJOA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CMNNIKGKEON(MFDGBKGGINJ.Application)]
public interface NOIAMFGAHDF
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLMEFABBONM(PLBLEJIEHCI LPOMAJEOJOA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HODKLDBHKDC(PLBLEJIEHCI LPOMAJEOJOA);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string GBLLEGLHBEC(PLBLEJIEHCI LPOMAJEOJOA);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid EMPOOPHJHAM(PLBLEJIEHCI LPOMAJEOJOA);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IIINKKHHEME(PLBLEJIEHCI LPOMAJEOJOA);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOOPHFOLDMI(PLBLEJIEHCI LPOMAJEOJOA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void OCGMKEFMABL(HCKPLPPJLND ICIGMOHLOFB, int BNOLEHCHJEP, HCKPLPPJLND KANEKDDILKA, int BDCFDIFNODK, [Optional] Vector3? JHPBPDLNLMB, [Optional] Quaternion? KAJLGLLJANO);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void ILDOAGOFDPM(HCKPLPPJLND GHAFBOBNDIH, HCKPLPPJLND OJDAODAMGNJ);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PLBLEJIEHCI : HCKPLPPJLND, CKBAIAAGHAE, IEquatable<HCKPLPPJLND>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface COLKPNKJFHM : CKBAIAAGHAE
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HCKPLPPJLND PECDDKNPJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<HCKPLPPJLND> EOANJAGNJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 PEFCHBNBNAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion JOIOJOGGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool GDLNEHOPHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool INOKBMMCFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event OCGMKEFMABL KHKACAEBGPL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event OCGMKEFMABL BJECEKNKGAH;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event OCGMKEFMABL KBFLPDGEJAF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event ILDOAGOFDPM EDLHINJLOMN;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JBLDGJLDMEF();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IOGIABOPHFE();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FKPNMEJNGKN();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KENDJOPAKNB();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EPFJHBAODBO();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MFGKPBNJOHN();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OCCJOMIEOLI(int LELIJNDCAOG, HCKPLPPJLND KANEKDDILKA, int HPBOAAAONAN);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AAEJEDJNBJM();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DLOAJNLMBEE(int LELIJNDCAOG, HCKPLPPJLND ICIGMOHLOFB, int GOFPNFHAADC, [Optional] Vector3? JHPBPDLNLMB, [Optional] Quaternion? KAJLGLLJANO);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BOCHGECJPMO(HCKPLPPJLND ICIGMOHLOFB);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void AKBGBFLAMOK();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IFKDOOBNHGM(int AEAHMAMPNLO, Vector3 JMOAHJJIPDJ);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DGLKMFHNIFM(Vector3 JHBGMEMLODK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AHGPLPAJDJB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 KOELMHOMCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HMKONNPCKAH
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool ABFDIGNFPCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OAKBKIABBLA AMNHAPPLEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, HMKONNPCKAH
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
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xB81E30", Offset = "0xB81230", VA = "0x180B81E30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public OAKBKIABBLA LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D14840", Offset = "0x6D13C40", VA = "0x186D14840")]
		public static ConnectableConfigData DIJOILJABBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D14900", Offset = "0x6D13D00", VA = "0x186D14900")]
		public ConnectableConfigData(LegacyConnectableLinkVisual LFBGDCJMJII, bool KLJCEEIAKGM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LJLIMMEKAPI : IEquatable<LJLIMMEKAPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public HCKPLPPJLND PAMBKKEPPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int JLLMACKDECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int IFGFEFPHION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 JHPBPDLNLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion KAJLGLLJANO;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D229A0", Offset = "0x6D21DA0", VA = "0x186D229A0")]
	public LJLIMMEKAPI(HCKPLPPJLND PAMBKKEPPAN, int JLLMACKDECJ, int IFGFEFPHION, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D22880", Offset = "0x6D21C80", VA = "0x186D22880")]
	public LJLIMMEKAPI(HCKPLPPJLND PAMBKKEPPAN, int JLLMACKDECJ, int IFGFEFPHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D22920", Offset = "0x6D21D20", VA = "0x186D22920")]
	public LJLIMMEKAPI(HCKPLPPJLND PAMBKKEPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6D22400", Offset = "0x6D21800", VA = "0x186D22400", Slot = "4")]
	public bool Equals(LJLIMMEKAPI OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D224B0", Offset = "0x6D218B0", VA = "0x186D224B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class ELAGODEAMGL : GDGGALHJAMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform ADJOLMKPBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private OAKBKIABBLA FEDMBMBBLDK;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6806C50", Offset = "0x6806050", VA = "0x186806C50", Slot = "4")]
	public void JLABJFAHLGH(Transform ADJOLMKPBJM, OAKBKIABBLA FEDMBMBBLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6D15580", Offset = "0x6D14980", VA = "0x186D15580", Slot = "5")]
	public OAKBKIABBLA OMNCNFMJCHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6D15510", Offset = "0x6D14910", VA = "0x186D15510", Slot = "6")]
	public void BEKDBBOOIAF(OAKBKIABBLA FIFPNGIOPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public ELAGODEAMGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KGIMECFPHIG : IDisposable, IAGKLMHIHMF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KMCBCPBOGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public HCKPLPPJLND oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HCKPLPPJLND newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KMCBCPBOGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6D1D830", Offset = "0x6D1CC30", VA = "0x186D1D830")]
		internal bool NEBOAEOOIBD(FCBMIEGAACH node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly AKOPHBABCGO EGMFCMLIHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private ONKDBNIMONL PCCIONPNHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NEFPDGGPCJA FHGBEFFJLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool KLJCEEIAKGM;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly EGGMDNJPOBA BONGIMEJLKI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public FCBMIEGAACH FKDEHKMEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6D186D0", Offset = "0x6D17AD0", VA = "0x186D186D0")]
	public bool CCNHCLHDNPJ([In] MLCOCFONMON MPMEGOKIEPF, bool PJPLGGFCHOK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D17B80", Offset = "0x6D16F80", VA = "0x186D17B80")]
	private bool AADCAAFLNFK([In] MLCOCFONMON MPMEGOKIEPF, bool PJPLGGFCHOK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AF30", Offset = "0x6D1A330", VA = "0x186D1AF30")]
	public KGIMECFPHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A560", Offset = "0x6D19960", VA = "0x186D1A560", Slot = "5")]
	public void JLABJFAHLGH(OOJCGLBDLHD HPCAPMNEHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D186A0", Offset = "0x6D17AA0", VA = "0x186D186A0", Slot = "17")]
	public void BNJLJKPNABJ(GGHKOAGEHGA BNNBDLHMCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6D1ACA0", Offset = "0x6D1A0A0", VA = "0x186D1ACA0", Slot = "12")]
	public void LJCIKKCMCHL(Func<HCKPLPPJLND, bool> FBLGPPKNLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AB70", Offset = "0x6D19F70", VA = "0x186D1AB70")]
	private void LJCIKKCMCHL(AKOPHBABCGO ABBPLCKDHFH, Func<HCKPLPPJLND, bool> FBLGPPKNLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A4E0", Offset = "0x6D198E0", VA = "0x186D1A4E0", Slot = "11")]
	public void JCMFIJCLMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6D19DA0", Offset = "0x6D191A0", VA = "0x186D19DA0", Slot = "8")]
	public bool GMPNHLPAMAE(HCKPLPPJLND CAMPFBNNLDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6D187F0", Offset = "0x6D17BF0", VA = "0x186D187F0")]
	private bool DFNDIFDCABI(HCKPLPPJLND AGCNLMKAIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A350", Offset = "0x6D19750", VA = "0x186D1A350")]
	private static bool IKJMJLDMEBB(HCKPLPPJLND AGCNLMKAIJL, AKOPHBABCGO JIHPJEDJFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A610", Offset = "0x6D19A10", VA = "0x186D1A610")]
	private void KIJLAPKECBM(Transform NFMBPCGLGGD, AKOPHBABCGO KGKECNMCKHM, AKOPHBABCGO[] OGLHANFCCJH, HCKPLPPJLND LFHJNLLMACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D19310", Offset = "0x6D18710", VA = "0x186D19310")]
	private LJLIMMEKAPI FOPKDLAONEH(Transform FCKIFMGBIFA, LJLIMMEKAPI GHCIPPHJBKD)
	{
		return default(LJLIMMEKAPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D19020", Offset = "0x6D18420", VA = "0x186D19020")]
	private static bool DPJONKOOPKP(AKOPHBABCGO JIHPJEDJFDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D1ACF0", Offset = "0x6D1A0F0", VA = "0x186D1ACF0", Slot = "9")]
	public bool PMAGAKKLHIE(HCKPLPPJLND HMLALDEGOBI, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D18140", Offset = "0x6D17540", VA = "0x186D18140")]
	private bool ABIOFGKDDEK(HCKPLPPJLND HMLALDEGOBI, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A9F0", Offset = "0x6D19DF0", VA = "0x186D1A9F0")]
	private static void KJKEGHIAHNI(HCKPLPPJLND HMLALDEGOBI, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO, AKOPHBABCGO BNHPHDMNBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6D18F00", Offset = "0x6D18300", VA = "0x186D18F00")]
	private void DHHBHFFLCKA(HCKPLPPJLND DBMEPGGGNNH, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A470", Offset = "0x6D19870", VA = "0x186D1A470")]
	private void IPCMKMDCJNB(AKOPHBABCGO ABBPLCKDHFH, HCKPLPPJLND PELFHDFGIND, HCKPLPPJLND KNIGLOAPIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A400", Offset = "0x6D19800", VA = "0x186D1A400")]
	private void IPCMKMDCJNB(HCKPLPPJLND PAMBKKEPPAN, HCKPLPPJLND PELFHDFGIND, HCKPLPPJLND KNIGLOAPIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A140", Offset = "0x6D19540", VA = "0x186D1A140")]
	private void HMOHJNKLBPH(HCKPLPPJLND PAMBKKEPPAN, HCKPLPPJLND PELFHDFGIND, HCKPLPPJLND KNIGLOAPIND, bool EJEMCHAKKHG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A1B0", Offset = "0x6D195B0", VA = "0x186D1A1B0")]
	private void HMOHJNKLBPH(AKOPHBABCGO FINELPFBLOK, HCKPLPPJLND LFHJNLLMACG, HCKPLPPJLND OJDAODAMGNJ, bool EJEMCHAKKHG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AD50", Offset = "0x6D1A150", VA = "0x186D1AD50")]
	private void PNGFKEGGLCG(HCKPLPPJLND BBNLJLBANGM, int GOFPNFHAADC, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6D19DB0", Offset = "0x6D191B0", VA = "0x186D19DB0")]
	private void HALMAFJEKAH(FCBMIEGAACH IIOPLDELPHL, FCBMIEGAACH KBMCDMIOIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6D19FE0", Offset = "0x6D193E0", VA = "0x186D19FE0", Slot = "18")]
	public HCKPLPPJLND HLJOCOJFNDB(HCKPLPPJLND PAMBKKEPPAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6D19A00", Offset = "0x6D18E00", VA = "0x186D19A00", Slot = "13")]
	public void GFICHACBBOK(HCKPLPPJLND PAMBKKEPPAN, HashSet<HCKPLPPJLND> HHMBDOJPHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6D18460", Offset = "0x6D17860", VA = "0x186D18460", Slot = "14")]
	public List<HCKPLPPJLND> ANBCHCCPIBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6D19F10", Offset = "0x6D19310", VA = "0x186D19F10")]
	protected FCBMIEGAACH HKGMIOIJCJI(FCBMIEGAACH ABBPLCKDHFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A2B0", Offset = "0x6D196B0", VA = "0x186D1A2B0")]
	protected AKOPHBABCGO[] IJLBBCKOMPA(AKOPHBABCGO JIHPJEDJFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D186E0", Offset = "0x6D17AE0", VA = "0x186D186E0")]
	protected bool DDDEBDNGLAC(HCKPLPPJLND PAMBKKEPPAN, [Out] AKOPHBABCGO ABBPLCKDHFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D191E0", Offset = "0x6D185E0", VA = "0x186D191E0", Slot = "15")]
	public bool EOCPODLMPOA(HCKPLPPJLND PAMBKKEPPAN, [Out] LJLIMMEKAPI MKBAICPIFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D1ACB0", Offset = "0x6D1A0B0", VA = "0x186D1ACB0")]
	protected AKOPHBABCGO NJMHCGEEFPF(LJLIMMEKAPI IHBFGFFGNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A500", Offset = "0x6D19900", VA = "0x186D1A500", Slot = "10")]
	public bool JDLAGCBOEHE(HCKPLPPJLND DBMEPGGGNNH, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6D19460", Offset = "0x6D18860", VA = "0x186D19460")]
	private bool GDEENIOKBOP(HCKPLPPJLND DBMEPGGGNNH, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6D18390", Offset = "0x6D17790", VA = "0x186D18390")]
	private static bool AMMJLMFKBFD(AKOPHBABCGO IFDEGLDKCBJ, LJLIMMEKAPI EHBLLFNLBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6D186D0", Offset = "0x6D17AD0", VA = "0x186D186D0", Slot = "7")]
	private bool KCFJGNNPPEJ([In] MLCOCFONMON MPMEGOKIEPF, bool PJPLGGFCHOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class AGAIFLNNEPA : OOJCGLBDLHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly ACFNHMKNHLL KLAPMCLMAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly NEFPDGGPCJA FHGBEFFJLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly LHJJCHOKKHJ DMEIBAGFHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly KKCCIADFCMB KDJAGKLLCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly IAGKLMHIHMF GFHEHGHBDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal PJBMBHOBMHE AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal AEHHLOFGIPG GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal ONKDBNIMONL ENAOLIPKBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool KLJCEEIAKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool HPCNDEJKHLO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GMJHNELBJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xC206F0", Offset = "0xC1FAF0", VA = "0x180C206F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1E21620", Offset = "0x1E20A20", VA = "0x181E21620")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IMHJEBACLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xC206E0", Offset = "0xC1FAE0", VA = "0x180C206E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1E21640", Offset = "0x1E20A40", VA = "0x181E21640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FLOIBCOPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HCKPLPPJLND, HCKPLPPJLND> FNLMDEJCFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6D123C0", Offset = "0x6D117C0", VA = "0x186D123C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6D11940", Offset = "0x6D10D40", VA = "0x186D11940", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HCKPLPPJLND, HCKPLPPJLND> IPEFEFBHDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D11550", Offset = "0x6D10950", VA = "0x186D11550", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D11730", Offset = "0x6D10B30", VA = "0x186D11730", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HCKPLPPJLND, HCKPLPPJLND, HCKPLPPJLND> MOJODAHOMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6D11DA0", Offset = "0x6D111A0", VA = "0x186D11DA0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6D12980", Offset = "0x6D11D80", VA = "0x186D12980", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6D12B60", Offset = "0x6D11F60", VA = "0x186D12B60")]
	public AGAIFLNNEPA(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6D11E00", Offset = "0x6D11200", VA = "0x186D11E00", Slot = "12")]
	public void JLABJFAHLGH(GameObject JPONDMDOHLN, HMKONNPCKAH DMCPDKIDLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6D114B0", Offset = "0x6D108B0", VA = "0x186D114B0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D10F30", Offset = "0x6D10330", VA = "0x186D10F30", Slot = "13")]
	public void BNOGHBKOPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6D12960", Offset = "0x6D11D60", VA = "0x186D12960", Slot = "14")]
	public void PFLPBBOAAPI(HCKPLPPJLND PAMBKKEPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D125E0", Offset = "0x6D119E0", VA = "0x186D125E0", Slot = "15")]
	public void LCBAONAKPAP(HCKPLPPJLND PAMBKKEPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6D11030", Offset = "0x6D10430", VA = "0x186D11030", Slot = "22")]
	public bool BPBJKPMKCMO(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6D10E70", Offset = "0x6D10270", VA = "0x186D10E70")]
	internal bool AADCAAFLNFK([In] MLCOCFONMON MPMEGOKIEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6D119A0", Offset = "0x6D10DA0", VA = "0x186D119A0")]
	internal bool GDEENIOKBOP([In] MLCOCFONMON MPMEGOKIEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6D11D40", Offset = "0x6D11140", VA = "0x186D11D40")]
	internal bool IBPKCJEIMAP([In] MLCOCFONMON MPMEGOKIEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6D12810", Offset = "0x6D11C10", VA = "0x186D12810")]
	internal bool OGJOEMNBLMM([In] MLCOCFONMON MPMEGOKIEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6D112D0", Offset = "0x6D106D0", VA = "0x186D112D0")]
	internal void DFGCIOODFON(HCKPLPPJLND PAMBKKEPPAN, int LOMFLBHFDBI, bool PJPLGGFCHOK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6D125E0", Offset = "0x6D119E0", VA = "0x186D125E0")]
	internal bool NNDGFIIPDAF(HCKPLPPJLND OGJMANGBFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D124B0", Offset = "0x6D118B0", VA = "0x186D124B0")]
	internal bool LABGLLNPJKM(HCKPLPPJLND HMLALDEGOBI, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D11A30", Offset = "0x6D10E30", VA = "0x186D11A30", Slot = "16")]
	public void GFICHACBBOK(HCKPLPPJLND PAMBKKEPPAN, HashSet<HCKPLPPJLND> KMHJDMKODKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6D11B30", Offset = "0x6D10F30", VA = "0x186D11B30", Slot = "17")]
	public void GMAAJNBHEME(HCKPLPPJLND HMLALDEGOBI, HCKPLPPJLND MGNCLNEDOBB, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D115F0", Offset = "0x6D109F0", VA = "0x186D115F0", Slot = "18")]
	public void ELKKMJODBFJ(HCKPLPPJLND DBMEPGGGNNH, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D12640", Offset = "0x6D11A40", VA = "0x186D12640", Slot = "19")]
	public void LFNJGMKIBNJ(HCKPLPPJLND DBMEPGGGNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D11080", Offset = "0x6D10480", VA = "0x186D11080")]
	public void CHFLNGBOPON([Optional] KFHNPMFCDCH FHJLHCAOAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6D12420", Offset = "0x6D11820", VA = "0x186D12420", Slot = "23")]
	public void JPNBOGLMOMK(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D129E0", Offset = "0x6D11DE0", VA = "0x186D129E0", Slot = "20")]
	public DHNLHLMGAND PPFAABBADNM(bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6D11790", Offset = "0x6D10B90", VA = "0x186D11790", Slot = "21")]
	public DHNLHLMGAND FHMBOCKNMEP(HashSet<Guid> GCDKPEOGBLD, bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D115B0", Offset = "0x6D109B0", VA = "0x186D115B0", Slot = "25")]
	public void EHEDGAANDBE(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6D10F80", Offset = "0x6D10380", VA = "0x186D10F80", Slot = "24")]
	public void BOOOINIFBCI(DHNLHLMGAND GFHEHGHBDMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class NEFPDGGPCJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly GFIOHNKJPFA<HCKPLPPJLND, HCKPLPPJLND> FNLMDEJCFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly GFIOHNKJPFA<HCKPLPPJLND, HCKPLPPJLND> IPEFEFBHDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly FEIOHBLDMOM<HCKPLPPJLND, HCKPLPPJLND, HCKPLPPJLND> MOJODAHOMNL;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D24D00", Offset = "0x6D24100", VA = "0x186D24D00")]
	public NEFPDGGPCJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	public void JLABJFAHLGH(AGAIFLNNEPA HPCAPMNEHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6D24C40", Offset = "0x6D24040", VA = "0x186D24C40")]
	public void GAHDLDOMICF(HCKPLPPJLND IIOPLDELPHL, HCKPLPPJLND BBNLJLBANGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D24CA0", Offset = "0x6D240A0", VA = "0x186D24CA0")]
	public void PJMGLIJNPGM(HCKPLPPJLND IIOPLDELPHL, HCKPLPPJLND BBNLJLBANGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6D24BC0", Offset = "0x6D23FC0", VA = "0x186D24BC0")]
	public void BHKMBHEKDBD(HCKPLPPJLND EJCOGOCMDDO, HCKPLPPJLND FFCFOAEFPGC, HCKPLPPJLND BBNLJLBANGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LHJJCHOKKHJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private AGAIFLNNEPA HPCAPMNEHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private AEHHLOFGIPG GLAAFJDOHIB;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public LHJJCHOKKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6D22140", Offset = "0x6D21540", VA = "0x186D22140")]
	public void JLABJFAHLGH(AGAIFLNNEPA HPCAPMNEHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D22030", Offset = "0x6D21430", VA = "0x186D22030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D22270", Offset = "0x6D21670", VA = "0x186D22270")]
	private void KLAGFOMLAHC(KFHNPMFCDCH PBJBOGHPHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D22390", Offset = "0x6D21790", VA = "0x186D22390")]
	private void MDLGKAGAEBK(KFHNPMFCDCH ONGJHIODFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D22290", Offset = "0x6D21690", VA = "0x186D22290")]
	public void KMCDDAKGFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D22040", Offset = "0x6D21440", VA = "0x186D22040")]
	public void EGGIGIBJCMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DLCCJJPNAII
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BOHKIHDADPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ACFNHMKNHLL container;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BOHKIHDADPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6D147D0", Offset = "0x6D13BD0", VA = "0x186D147D0")]
		internal AGAIFLNNEPA DEEFIBIJNII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6D14950", Offset = "0x6D13D50", VA = "0x186D14950")]
	public static void FJGMHLONPAJ(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D14B50", Offset = "0x6D13F50", VA = "0x186D14B50")]
	public static void JCNDPHBLMKI(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class BGNMINDCFOC : IDisposable, ONKDBNIMONL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, OAKBKIABBLA> OAOFHEEJJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GGHKOAGEHGA KLGOBGOJECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private GDGGALHJAMM MCFLEKLMIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private IAGKLMHIHMF GFHEHGHBDMK;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6D146F0", Offset = "0x6D13AF0", VA = "0x186D146F0")]
	public BGNMINDCFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6D140F0", Offset = "0x6D134F0", VA = "0x186D140F0", Slot = "7")]
	public void JLABJFAHLGH(IAGKLMHIHMF GFHEHGHBDMK, GDGGALHJAMM MCFLEKLMIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6D142E0", Offset = "0x6D136E0", VA = "0x186D142E0", Slot = "5")]
	public void NMFKHKMMDBF(FCBMIEGAACH NNEFMDIJCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6D14580", Offset = "0x6D13980", VA = "0x186D14580", Slot = "9")]
	public void OFGMBNAOIOC(FCBMIEGAACH FAIDICHFEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6D13F30", Offset = "0x6D13330", VA = "0x186D13F30", Slot = "8")]
	public void GCMLGJPIKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D13B20", Offset = "0x6D12F20", VA = "0x186D13B20", Slot = "10")]
	public void FGJDDJEDGNP(FCBMIEGAACH LAKPDNEHAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6D13E70", Offset = "0x6D13270", VA = "0x186D13E70", Slot = "11")]
	public void FOIBOKPPAJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6D14130", Offset = "0x6D13530", VA = "0x186D14130")]
	private bool KHBALCMEHBN(FCBMIEGAACH DNDOEPAKCMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class KKCCIADFCMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct EIBODAJBNKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly AKOPHBABCGO NHKDBOCIMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> GCDKPEOGBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly AFLNLKDBMAP GIDBGLAKKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly AFLNLKDBMAP LGMFIIFIFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool BKNHBJEMKFB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool OLPDHCGCILP
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6D14D90", Offset = "0x6D14190", VA = "0x186D14D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6D154A0", Offset = "0x6D148A0", VA = "0x186D154A0")]
		public EIBODAJBNKB(AKOPHBABCGO NHKDBOCIMMA, HashSet<Guid> GCDKPEOGBLD, bool BKNHBJEMKFB, [Optional] AFLNLKDBMAP GIDBGLAKKGE, [Optional] AFLNLKDBMAP LGMFIIFIFHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6D15190", Offset = "0x6D14590", VA = "0x186D15190")]
		public AFLNLKDBMAP KEEAKGCJIOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6D150D0", Offset = "0x6D144D0", VA = "0x186D150D0")]
		private AFLNLKDBMAP HCGKHMKBJJM([Out] AFLNLKDBMAP MMKELPABGDL, [Out] AFLNLKDBMAP JHFPLANECOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6D14EB0", Offset = "0x6D142B0", VA = "0x186D14EB0")]
		private AFLNLKDBMAP GLEMIBDABFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6D15330", Offset = "0x6D14730", VA = "0x186D15330")]
		private void LIBAAIHMPIP(AFLNLKDBMAP KKGAEAANLDJ, AFLNLKDBMAP JLBPOIPOFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6D14BD0", Offset = "0x6D13FD0", VA = "0x186D14BD0")]
		private void CPJKNOLJDDF(AFLNLKDBMAP MMKELPABGDL, AFLNLKDBMAP JHFPLANECOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private AGAIFLNNEPA HPCAPMNEHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private IAGKLMHIHMF GFHEHGHBDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private ONKDBNIMONL PCCIONPNHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private AEHHLOFGIPG GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool BNJKNLABHON;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool LHIIJMLIOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CAD0", Offset = "0x6D1BED0", VA = "0x186D1CAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool GMJHNELBJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6D1D3E0", Offset = "0x6D1C7E0", VA = "0x186D1D3E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C3F0", Offset = "0x6D1B7F0", VA = "0x186D1C3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6D1CDB0", Offset = "0x6D1C1B0", VA = "0x186D1CDB0")]
	public void JLABJFAHLGH(AGAIFLNNEPA HPCAPMNEHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6D1D650", Offset = "0x6D1CA50", VA = "0x186D1D650")]
	public DHNLHLMGAND PPFAABBADNM(bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C520", Offset = "0x6D1B920", VA = "0x186D1C520")]
	public DHNLHLMGAND FHMBOCKNMEP(HashSet<Guid> GCDKPEOGBLD, bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6D1CE20", Offset = "0x6D1C220", VA = "0x186D1CE20")]
	public void JPNBOGLMOMK(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B2F0", Offset = "0x6D1A6F0", VA = "0x186D1B2F0")]
	public void BOOOINIFBCI(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C6C0", Offset = "0x6D1BAC0", VA = "0x186D1C6C0")]
	public void FLABGIMJHKO(DHNLHLMGAND GFHEHGHBDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B100", Offset = "0x6D1A500", VA = "0x186D1B100")]
	private void AKNKJNKPNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C870", Offset = "0x6D1BC70", VA = "0x186D1C870")]
	private AFLNLKDBMAP HDGEOENKIBO(AKOPHBABCGO ABBPLCKDHFH, bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6D1D400", Offset = "0x6D1C800", VA = "0x186D1D400")]
	private static void OAIIGILPMIE(AKOPHBABCGO ABBPLCKDHFH, bool BKNHBJEMKFB, AFLNLKDBMAP KFGHKJHEFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6D1CEB0", Offset = "0x6D1C2B0", VA = "0x186D1CEB0")]
	private void LDLNNMDJEIG(AKOPHBABCGO ABBPLCKDHFH, bool BKNHBJEMKFB, AFLNLKDBMAP KFGHKJHEFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C100", Offset = "0x6D1B500", VA = "0x186D1C100")]
	private AFLNLKDBMAP EIDIPFGNOBO(AKOPHBABCGO NHKDBOCIMMA, HashSet<Guid> GCDKPEOGBLD, bool BKNHBJEMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6D1CB20", Offset = "0x6D1BF20", VA = "0x186D1CB20")]
	private bool JKPJHONOOMA(DHNLHLMGAND LGAELPJHPCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B730", Offset = "0x6D1AB30", VA = "0x186D1B730")]
	private bool DELNCCLPDBN(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C500", Offset = "0x6D1B900", VA = "0x186D1C500")]
	private bool FHIIHIPIOAF(DHNLHLMGAND GFHEHGHBDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B620", Offset = "0x6D1AA20", VA = "0x186D1B620")]
	private static bool CODIFBMOOLB(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B390", Offset = "0x6D1A790", VA = "0x186D1B390")]
	public static bool BPBJKPMKCMO(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6D1BDA0", Offset = "0x6D1B1A0", VA = "0x186D1BDA0")]
	private HCKPLPPJLND EBEOKPPMNAA(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6D1D0D0", Offset = "0x6D1C4D0", VA = "0x186D1D0D0")]
	private HCKPLPPJLND LMDCEPKMBJF(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6D1D250", Offset = "0x6D1C650", VA = "0x186D1D250")]
	private HCKPLPPJLND MLPBMIEPLCH(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6D1CA90", Offset = "0x6D1BE90", VA = "0x186D1CA90")]
	private static Guid HFENBNLABCE(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C410", Offset = "0x6D1B810", VA = "0x186D1C410")]
	private string EOGCHPLHAEB(AFLNLKDBMAP KFGHKJHEFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C6F0", Offset = "0x6D1BAF0", VA = "0x186D1C6F0")]
	private bool GLMEDCCOCOM(AKOPHBABCGO ABBPLCKDHFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C190", Offset = "0x6D1B590", VA = "0x186D1C190")]
	private static void ELONADCFIIC(AKOPHBABCGO NHKDBOCIMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public KKCCIADFCMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct MLCOCFONMON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public HCKPLPPJLND BBNLJLBANGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HCKPLPPJLND IIOPLDELPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int GOFPNFHAADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int HPBOAAAONAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 JHPBPDLNLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion KAJLGLLJANO;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LJLIMMEKAPI DHIBPNPGJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6D24AB0", Offset = "0x6D23EB0", VA = "0x186D24AB0")]
		get
		{
			return default(LJLIMMEKAPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LJLIMMEKAPI PJPJEMOPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6D24A80", Offset = "0x6D23E80", VA = "0x186D24A80")]
		get
		{
			return default(LJLIMMEKAPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6D24B50", Offset = "0x6D23F50", VA = "0x186D24B50")]
	public MLCOCFONMON(HCKPLPPJLND BBNLJLBANGM, HCKPLPPJLND IIOPLDELPHL, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface IAGKLMHIHMF
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FCBMIEGAACH FKDEHKMEOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLABJFAHLGH(OOJCGLBDLHD HPCAPMNEHGA);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCNHCLHDNPJ([In] MLCOCFONMON MPMEGOKIEPF, bool PJPLGGFCHOK = true);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GMPNHLPAMAE(HCKPLPPJLND CAMPFBNNLDB);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PMAGAKKLHIE(HCKPLPPJLND HMLALDEGOBI, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JDLAGCBOEHE(HCKPLPPJLND DBMEPGGGNNH, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JCMFIJCLMEO();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LJCIKKCMCHL(Func<HCKPLPPJLND, bool> FBLGPPKNLAH);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GFICHACBBOK(HCKPLPPJLND PAMBKKEPPAN, HashSet<HCKPLPPJLND> HHMBDOJPHIM);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<HCKPLPPJLND> ANBCHCCPIBH();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EOCPODLMPOA(HCKPLPPJLND PAMBKKEPPAN, [Out] LJLIMMEKAPI MKBAICPIFLP);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BNJLJKPNABJ(GGHKOAGEHGA BNNBDLHMCLC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool GGHKOAGEHGA(FCBMIEGAACH ABBPLCKDHFH);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface FCBMIEGAACH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HCKPLPPJLND LNKONBNJBJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	FCBMIEGAACH DIEIKKLOHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LJLIMMEKAPI MHNFOIPLDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CHIIHBMMHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OAKBKIABBLA : ELFOLKCLFNL.NMEAOAMKJEB
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHMGAKDCLGK(HCKPLPPJLND KANEKDDILKA, LJLIMMEKAPI BBNLJLBANGM);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHBPJEEGGOE(HCKPLPPJLND KANEKDDILKA, LJLIMMEKAPI BBNLJLBANGM);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOIDCBBIJNJ(HCKPLPPJLND KANEKDDILKA, LJLIMMEKAPI BBNLJLBANGM);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMAIICIFNOL(HCKPLPPJLND KANEKDDILKA, LJLIMMEKAPI BBNLJLBANGM);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OAKBKIABBLA Instantiate(Transform ADJOLMKPBJM);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBHGGLOEOHI();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GDGGALHJAMM
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLABJFAHLGH(Transform ADJOLMKPBJM, OAKBKIABBLA FEDMBMBBLDK);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OAKBKIABBLA OMNCNFMJCHG();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEKDBBOOIAF(OAKBKIABBLA FIFPNGIOPDH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface PJBMBHOBMHE : KJLBIGLFNNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDDKPDOHNBF(Guid HJHGEIKMJIL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface ONKDBNIMONL
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMFKHKMMDBF(FCBMIEGAACH NNEFMDIJCEA);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLABJFAHLGH(IAGKLMHIHMF GFHEHGHBDMK, GDGGALHJAMM BFHLJHBPJBG);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCMLGJPIKGB();

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OFGMBNAOIOC(FCBMIEGAACH FAIDICHFEFG);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGJDDJEDGNP(FCBMIEGAACH LAKPDNEHAPH);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FOIBOKPPAJL();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class AKOPHBABCGO : FCBMIEGAACH
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HDJNLGPKAEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public LJLIMMEKAPI nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AKOPHBABCGO foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HDJNLGPKAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D17A40", Offset = "0x6D16E40", VA = "0x186D17A40")]
		internal bool DNDJKJHCENB(FCBMIEGAACH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private LJLIMMEKAPI MKBAICPIFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<AKOPHBABCGO> NJONKLMDNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private AKOPHBABCGO CEMANELGBJF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public LJLIMMEKAPI MHNFOIPLDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3BC90D0", Offset = "0x3BC84D0", VA = "0x183BC90D0", Slot = "6")]
		get
		{
			return default(LJLIMMEKAPI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D130A0", Offset = "0x6D124A0", VA = "0x186D130A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private AKOPHBABCGO IIOPLDELPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D12FC0", Offset = "0x6D123C0", VA = "0x186D12FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FCBMIEGAACH DIEIKKLOHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HCKPLPPJLND LNKONBNJBJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CHIIHBMMHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D130D0", Offset = "0x6D124D0", VA = "0x186D130D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OKOECGJLNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D13870", Offset = "0x6D12C70", VA = "0x186D13870", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected AKOPHBABCGO FINELPFBLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D13670", Offset = "0x6D12A70", VA = "0x186D13670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D13A70", Offset = "0x6D12E70", VA = "0x186D13A70")]
	public AKOPHBABCGO(LJLIMMEKAPI ADBMAEEACHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D133A0", Offset = "0x6D127A0", VA = "0x186D133A0")]
	public AKOPHBABCGO IPADPHKPOBL(LJLIMMEKAPI CICCIFADALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D134F0", Offset = "0x6D128F0", VA = "0x186D134F0")]
	public AKOPHBABCGO LCBDILCKCDJ(LJLIMMEKAPI PPHAOHGDEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D13690", Offset = "0x6D12A90", VA = "0x186D13690")]
	public AKOPHBABCGO MAHJHHAHNPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D13250", Offset = "0x6D12650", VA = "0x186D13250")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D139C0", Offset = "0x6D12DC0", VA = "0x186D139C0")]
	public AKOPHBABCGO OBFLHMNKCAF(LJLIMMEKAPI FFCFOAEFPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D130E0", Offset = "0x6D124E0", VA = "0x186D130E0")]
	private static void BNJLJKPNABJ(AKOPHBABCGO IABPIBIIEDJ, GGHKOAGEHGA KFMKOKFLOBK, bool LGFDMHAJAFH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D13240", Offset = "0x6D12640", VA = "0x186D13240", Slot = "9")]
	public void BNJLJKPNABJ(GGHKOAGEHGA BNNBDLHMCLC, bool EJEMCHAKKHG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D138C0", Offset = "0x6D12CC0", VA = "0x186D138C0")]
	public static AKOPHBABCGO NJMHCGEEFPF(AKOPHBABCGO IABPIBIIEDJ, LJLIMMEKAPI FOHOEDHDAFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface AEHHLOFGIPG
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool LHIIJMLIOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool ELNEGCNFJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<KFHNPMFCDCH> KLAGFOMLAHC;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<KFHNPMFCDCH> MDLGKAGAEBK;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(AGAIFLNNEPA HPCAPMNEHGA);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(HCKPLPPJLND HMLALDEGOBI, HCKPLPPJLND MGNCLNEDOBB, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(HCKPLPPJLND DBMEPGGGNNH, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(DHNLHLMGAND FABLGAKIJHK, [Optional] KFHNPMFCDCH FHJLHCAOAID);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, AEHHLOFGIPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private AGAIFLNNEPA HPCAPMNEHGA;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool LHIIJMLIOKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x6D24700", Offset = "0x6D23B00", VA = "0x186D24700", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool ELNEGCNFJOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6D24760", Offset = "0x6D23B60", VA = "0x186D24760", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<KFHNPMFCDCH> KLAGFOMLAHC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6D24660", Offset = "0x6D23A60", VA = "0x186D24660", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6D24840", Offset = "0x6D23C40", VA = "0x186D24840", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<KFHNPMFCDCH> MDLGKAGAEBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6D245C0", Offset = "0x6D239C0", VA = "0x186D245C0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6D247A0", Offset = "0x6D23BA0", VA = "0x186D247A0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B75A0", VA = "0x1808B81A0", Slot = "19")]
		public void SetManager(AGAIFLNNEPA HPCAPMNEHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D24590", Offset = "0x6D23990", VA = "0x186D24590")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D23310", Offset = "0x6D22710", VA = "0x186D23310", Slot = "23")]
		public void RequestMasterConnectNodes(HCKPLPPJLND ICIGMOHLOFB, int GOFPNFHAADC, HCKPLPPJLND KANEKDDILKA, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D23440", Offset = "0x6D22840", VA = "0x186D23440", Slot = "24")]
		public void RequestMasterDisconnectNode(HCKPLPPJLND CAMPFBNNLDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D23500", Offset = "0x6D22900", VA = "0x186D23500", Slot = "20")]
		public void RequestMasterModifyNode(HCKPLPPJLND HMLALDEGOBI, HCKPLPPJLND MGNCLNEDOBB, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D23630", Offset = "0x6D22A30", VA = "0x186D23630", Slot = "21")]
		public void RequestMasterReparentNodes(HCKPLPPJLND DBMEPGGGNNH, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D23760", Offset = "0x6D22B60", VA = "0x186D23760", Slot = "25")]
		public void RequestMasterReparentToRoot(HCKPLPPJLND DBMEPGGGNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D231E0", Offset = "0x6D225E0", VA = "0x186D231E0", Slot = "22")]
		public void RequestDeserializeConnectableGraph(DHNLHLMGAND FABLGAKIJHK, [Optional] KFHNPMFCDCH FHJLHCAOAID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D23B40", Offset = "0x6D22F40", VA = "0x186D23B40")]
		[IAHBGAGIKDN]
		private void RpcMasterConnectNodes(HCKPLPPJLND ICIGMOHLOFB, int GOFPNFHAADC, HCKPLPPJLND KANEKDDILKA, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D23E00", Offset = "0x6D23200", VA = "0x186D23E00")]
		[IAHBGAGIKDN]
		private void RpcMasterDisconnectNode(HCKPLPPJLND CAMPFBNNLDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D24140", Offset = "0x6D23540", VA = "0x186D24140")]
		[IAHBGAGIKDN]
		private void RpcMasterReparentNodes(HCKPLPPJLND DBMEPGGGNNH, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D23F40", Offset = "0x6D23340", VA = "0x186D23F40")]
		[IAHBGAGIKDN]
		private void RpcMasterModifyNode(HCKPLPPJLND HMLALDEGOBI, HCKPLPPJLND MGNCLNEDOBB, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6D23930", Offset = "0x6D22D30", VA = "0x186D23930")]
		[IAHBGAGIKDN]
		private void RpcConnectNodes(HCKPLPPJLND ICIGMOHLOFB, int GOFPNFHAADC, HCKPLPPJLND KANEKDDILKA, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO, HCMAHKOGKEG OBDKGBDNPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6D23AB0", Offset = "0x6D22EB0", VA = "0x186D23AB0")]
		[IAHBGAGIKDN]
		private void RpcDisconnectNode(HCKPLPPJLND CAMPFBNNLDB, HCMAHKOGKEG OBDKGBDNPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D24490", Offset = "0x6D23890", VA = "0x186D24490")]
		[IAHBGAGIKDN]
		private void RpcReparentNodes(HCKPLPPJLND DBMEPGGGNNH, int HGNAENGHBCM, HCKPLPPJLND FFCFOAEFPGC, int ICDHBINBCMF, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO, HCMAHKOGKEG OBDKGBDNPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6D243D0", Offset = "0x6D237D0", VA = "0x186D243D0")]
		[IAHBGAGIKDN]
		private void RpcModifyNode(HCKPLPPJLND HMLALDEGOBI, int GOFPNFHAADC, int HPBOAAAONAN, Vector3 JHPBPDLNLMB, Quaternion KAJLGLLJANO, HCMAHKOGKEG OBDKGBDNPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D23A70", Offset = "0x6D22E70", VA = "0x186D23A70")]
		[IAHBGAGIKDN]
		private void RpcDeserializeConnectableGraph(DHNLHLMGAND GFHEHGHBDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C7430", Offset = "0x8C6830", VA = "0x1808C7430")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, OAKBKIABBLA, ELFOLKCLFNL.NMEAOAMKJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D22B90", Offset = "0x6D21F90", VA = "0x186D22B90", Slot = "4")]
		private void HMMPDKDBCDM(HCKPLPPJLND KANEKDDILKA, LJLIMMEKAPI BBNLJLBANGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D22F00", Offset = "0x6D22300", VA = "0x186D22F00", Slot = "5")]
		private void MPJEMGNKAKH(HCKPLPPJLND KANEKDDILKA, LJLIMMEKAPI BBNLJLBANGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D22A70", Offset = "0x6D21E70", VA = "0x186D22A70", Slot = "6")]
		private void HJGKPCNAAEG(HCKPLPPJLND KANEKDDILKA, LJLIMMEKAPI BBNLJLBANGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D22D10", Offset = "0x6D22110", VA = "0x186D22D10", Slot = "7")]
		private void LGLJOIIBPEK(HCKPLPPJLND KANEKDDILKA, LJLIMMEKAPI BBNLJLBANGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D22A00", Offset = "0x6D21E00", VA = "0x186D22A00", Slot = "8")]
		private OAKBKIABBLA EJJAMKFDJAA(Transform ADJOLMKPBJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D23180", Offset = "0x6D22580", VA = "0x186D23180", Slot = "9")]
		private void NDPDDNLPOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IDNMHCGICJG
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2E96E10", Offset = "0x2E96210", VA = "0x182E96E10")]
	public static OCEBGIIBPBP<T> HEOHJLBCJNB<T>(this ACFNHMKNHLL KLAPMCLMAPI)
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
