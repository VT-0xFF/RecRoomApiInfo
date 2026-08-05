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
	public class LogRegistrationIndex : AGBKNAFJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68BE5D0", Offset = "0x68BD5D0", VA = "0x1868BE5D0", Slot = "4")]
		public override void GGLLICMBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
	public class _AssemblyIndex : HPGCOLCGLFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private JCHPKCLPDGD bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private JCHPKCLPDGD bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68C6F60", Offset = "0x68C5F60", VA = "0x1868C6F60", Slot = "5")]
		public override void JGHHFPAAFIK(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68C6DF0", Offset = "0x68C5DF0", VA = "0x1868C6DF0")]
		private void JFFKPLCLODI(LBEKBNOBNBA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68C6C80", Offset = "0x68C5C80", VA = "0x1868C6C80")]
		private void GHOJNPOFIGP(LBEKBNOBNBA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68C6950", Offset = "0x68C5950", VA = "0x1868C6950", Slot = "6")]
		public override void AKPNBKINMBO(LBEKBNOBNBA registry, [In] ACFLJKIEOHM filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "9")]
		public override void EGOKAKAMEDC(MIBLFBDCCLC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68C6FA0", Offset = "0x68C5FA0", VA = "0x1868C6FA0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class MFKKIJIAKFP : PJMFMNBEBBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BIJHHJLKFPK : IEnumerable<HLIBDGEMJOE>, IEnumerable, IEnumerator<HLIBDGEMJOE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HLIBDGEMJOE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private CGNEFKCKCBE localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public CGNEFKCKCBE <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MFKKIJIAKFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OEENGDBIBNC <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private LKKANPIGGEI.OLGMACOEDKI <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HLIBDGEMJOE System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A4A30", Offset = "0x8A3A30", VA = "0x1808A4A30")]
		[DebuggerHidden]
		public BIJHHJLKFPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68B4600", Offset = "0x68B3600", VA = "0x1868B4600", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68B4140", Offset = "0x68B3140", VA = "0x1868B4140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68B4120", Offset = "0x68B3120", VA = "0x1868B4120")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68B45B0", Offset = "0x68B35B0", VA = "0x1868B45B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68B4500", Offset = "0x68B3500", VA = "0x1868B4500", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HLIBDGEMJOE> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68B4500", Offset = "0x68B3500", VA = "0x1868B4500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class JPJJBIBLKBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MFKKIJIAKFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MBHEBJKPDFI nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JPJJBIBLKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x68B7F80", Offset = "0x68B6F80", VA = "0x1868B7F80")]
		internal object JDDACPHCKDD(MBHEBJKPDFI x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FGFGPEHAMFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MBHEBJKPDFI child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JPJJBIBLKBE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public FGFGPEHAMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x68B4BC0", Offset = "0x68B3BC0", VA = "0x1868B4BC0")]
		internal object OCDJPPKKNDA((MBHEBJKPDFI child, MBHEBJKPDFI nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly PHLKHBEJKKB DLLFPMBPFFG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly PHLKHBEJKKB CPGCCKJDHKN;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly PHLKHBEJKKB GFFPNHAALLA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly PHLKHBEJKKB OLBEPPDDOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OCMGEOKHNIG JNANGDEOAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private AFOMIBACJBH DAEHHHGOBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private NHCPPBLHPHO JHOHFNCGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private FIBGHMOFPMI LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private FMBFPNOAMOB FKOJJJBKLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CAGLIKPDIOD NDICMFPNNJB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8637D0", Offset = "0x8627D0", VA = "0x1808637D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8632C0", Offset = "0x8622C0", VA = "0x1808632C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MGDAGLFMBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<HLIBDGEMJOE, HLIBDGEMJOE> MDLILEBPCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68C1EF0", Offset = "0x68C0EF0", VA = "0x1868C1EF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68BF180", Offset = "0x68BE180", VA = "0x1868BF180", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<HLIBDGEMJOE, HLIBDGEMJOE> GMPEOPKGEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68C2B30", Offset = "0x68C1B30", VA = "0x1868C2B30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68C2C40", Offset = "0x68C1C40", VA = "0x1868C2C40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<HLIBDGEMJOE, HLIBDGEMJOE, HLIBDGEMJOE> PCOMLELDAOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68C23C0", Offset = "0x68C13C0", VA = "0x1868C23C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68C09E0", Offset = "0x68BF9E0", VA = "0x1868C09E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68C2EF0", Offset = "0x68C1EF0", VA = "0x1868C2EF0")]
	public MFKKIJIAKFP(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68C1C80", Offset = "0x68C0C80", VA = "0x1868C1C80", Slot = "12")]
	public void LFNNOPDGNGK(GameObject IDHOMJBMFPB, LPNANCLPMKG KLIOHNILOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68BF630", Offset = "0x68BE630", VA = "0x1868BF630", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68BF9D0", Offset = "0x68BE9D0", VA = "0x1868BF9D0", Slot = "22")]
	public bool EHPFHFIBOOI(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68C0A90", Offset = "0x68BFA90", VA = "0x1868C0A90")]
	private void IPACMICEJIJ(CGNEFKCKCBE CCMDDMHHOFD, CGNEFKCKCBE NNPHPFCFLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68C26F0", Offset = "0x68C16F0", VA = "0x1868C26F0")]
	private void NCPFFPAHGNJ(CGNEFKCKCBE CCMDDMHHOFD, CGNEFKCKCBE LGODHBBPAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68BF3C0", Offset = "0x68BE3C0", VA = "0x1868BF3C0")]
	private void DLLICKBPIHN(CGNEFKCKCBE CCMDDMHHOFD, CGNEFKCKCBE LGODHBBPAKI, CGNEFKCKCBE NNPHPFCFLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68BED70", Offset = "0x68BDD70", VA = "0x1868BED70")]
	private void DCPCGBHFGBI(CGNEFKCKCBE CCMDDMHHOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "13")]
	public void GACAEOGENLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68BFB20", Offset = "0x68BEB20", VA = "0x1868BFB20", Slot = "14")]
	public void GGLLICMBJNI(HLIBDGEMJOE JIMFJKNHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "15")]
	public void CNEBNJPACBD(HLIBDGEMJOE JIMFJKNHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68C03E0", Offset = "0x68BF3E0", VA = "0x1868C03E0", Slot = "17")]
	public void GNOBGGOBJEK(HLIBDGEMJOE JIMFJKNHNFO, HLIBDGEMJOE FEAEJHMDDMM, Vector3 IJLMJJLHNIG, Quaternion EJNJAFFEDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68C0540", Offset = "0x68BF540", VA = "0x1868C0540")]
	public void GNOBGGOBJEK(CGNEFKCKCBE CDKDCIHMCOB, CGNEFKCKCBE FEAEJHMDDMM, Vector3 IJLMJJLHNIG, Quaternion EJNJAFFEDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68BFA90", Offset = "0x68BEA90", VA = "0x1868BFA90")]
	public void FEKOKLAEDJD(HLIBDGEMJOE JIMFJKNHNFO, float FNEHDJDKKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68C0100", Offset = "0x68BF100", VA = "0x1868C0100", Slot = "18")]
	public void GLODDIFINFE(HLIBDGEMJOE CFCGKFPLMDN, int IBHOKALODDH, HLIBDGEMJOE KEDJKAHDNCH, int EMILBCJJGAK, Vector3 IJLMJJLHNIG, Quaternion EJNJAFFEDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68C2A80", Offset = "0x68C1A80", VA = "0x1868C2A80")]
	private float OIAEMLONPOA(CGNEFKCKCBE CDKDCIHMCOB, CGNEFKCKCBE EMOKCJBMKOL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68C02B0", Offset = "0x68BF2B0", VA = "0x1868C02B0")]
	public void GLODDIFINFE(CGNEFKCKCBE CDKDCIHMCOB, CGNEFKCKCBE EMOKCJBMKOL, Vector3 IJLMJJLHNIG, Quaternion EJNJAFFEDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68C0250", Offset = "0x68BF250", VA = "0x1868C0250")]
	public void GLODDIFINFE(CGNEFKCKCBE CDKDCIHMCOB, CGNEFKCKCBE EMOKCJBMKOL, Vector3 IJLMJJLHNIG, Quaternion EJNJAFFEDPH, float FNEHDJDKKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68C2910", Offset = "0x68C1910", VA = "0x1868C2910", Slot = "19")]
	public void NEKLJOMCHIC(HLIBDGEMJOE JIMFJKNHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68C0CA0", Offset = "0x68BFCA0", VA = "0x1868C0CA0")]
	public bool JHECJMMJBGM(CGNEFKCKCBE BAAPAEECMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68C1A70", Offset = "0x68C0A70", VA = "0x1868C1A70", Slot = "16")]
	public void LDIFAOBPPGJ(HLIBDGEMJOE JIMFJKNHNFO, HashSet<HLIBDGEMJOE> MKFCLEPBEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "20")]
	public LKBFGJGBJEC KAOFPJDPEJC(bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "21")]
	public LKBFGJGBJEC BCHDNKHIABG(HashSet<Guid> OKLICKEMEHJ, bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68BE7B0", Offset = "0x68BD7B0", VA = "0x1868BE7B0", Slot = "23")]
	public void BOGAHIEHKEH(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68C1A00", Offset = "0x68C0A00", VA = "0x1868C1A00", Slot = "24")]
	public void LCKLBANBHHC(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x68BF820", Offset = "0x68BE820", VA = "0x1868BF820", Slot = "25")]
	public void EEFHEEOCHFG(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68C0680", Offset = "0x68BF680", VA = "0x1868C0680")]
	private void HLFFPKKJKEE(CGNEFKCKCBE CDKDCIHMCOB, CGNEFKCKCBE EMOKCJBMKOL, Vector3 IJLMJJLHNIG, Quaternion EJNJAFFEDPH, float FNEHDJDKKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68C1FA0", Offset = "0x68C0FA0", VA = "0x1868C1FA0")]
	private void LMBOLBKLONH(CGNEFKCKCBE CDKDCIHMCOB, CGNEFKCKCBE MECDJMBEHCP, Vector3 IJLMJJLHNIG, Quaternion EJNJAFFEDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68BFA20", Offset = "0x68BEA20", VA = "0x1868BFA20")]
	private void EPKPCAOHPKF(CGNEFKCKCBE CDKDCIHMCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68C2CF0", Offset = "0x68C1CF0", VA = "0x1868C2CF0")]
	[IteratorStateMachine(typeof(BIJHHJLKFPK))]
	public IEnumerable<HLIBDGEMJOE> PJCGKKHIJFK(CGNEFKCKCBE BAAPAEECMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68C18D0", Offset = "0x68C08D0", VA = "0x1868C18D0")]
	internal HLIBDGEMJOE KLBCMAIACLF(CGNEFKCKCBE BAAPAEECMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68BECA0", Offset = "0x68BDCA0", VA = "0x1868BECA0")]
	internal CGNEFKCKCBE DAJDBCACOON(HLIBDGEMJOE JIMFJKNHNFO)
	{
		return default(CGNEFKCKCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68C0F30", Offset = "0x68BFF30", VA = "0x1868C0F30")]
	private bool JJJKCCIGHGK(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68C14D0", Offset = "0x68C04D0", VA = "0x1868C14D0")]
	private bool KAMOEDHEIKD(MBHEBJKPDFI CBKMIAOMAIC, [Out] HLIBDGEMJOE EMOKCJBMKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68C1530", Offset = "0x68C0530", VA = "0x1868C1530")]
	private HLIBDGEMJOE KLBCMAIACLF(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68BF230", Offset = "0x68BE230", VA = "0x1868BF230")]
	private HLIBDGEMJOE DKIJEAHPAJP(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x68BE820", Offset = "0x68BD820", VA = "0x1868BE820")]
	private HLIBDGEMJOE BPDCLBLEDEI(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68BE770", Offset = "0x68BD770", VA = "0x1868BE770")]
	private static Guid AKBFKKGLFJM(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68C2470", Offset = "0x68C1470", VA = "0x1868C2470")]
	private string MMKOEHEFJNF(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68C2560", Offset = "0x68C1560", VA = "0x1868C2560")]
	private void NAOPANKOALO(HLIBDGEMJOE CDKDCIHMCOB, HLIBDGEMJOE MECDJMBEHCP, RigidTransform NKKKCLCLIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68BEA00", Offset = "0x68BDA00", VA = "0x1868BEA00")]
	private void BPIFBBKNAOD(HLIBDGEMJOE MECDJMBEHCP, HLIBDGEMJOE CDKDCIHMCOB, RigidTransform NKKKCLCLIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68C2BE0", Offset = "0x68C1BE0", VA = "0x1868C2BE0")]
	private void ONKGNDEMLCI(HLIBDGEMJOE JHCCBIEGECC, HLIBDGEMJOE CDKDCIHMCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68BF840", Offset = "0x68BE840", VA = "0x1868BF840")]
	private void EFIGJNEKLAE(HLIBDGEMJOE CDKDCIHMCOB, HLIBDGEMJOE EMOKCJBMKOL, RigidTransform NKKKCLCLIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68BEB90", Offset = "0x68BDB90", VA = "0x1868BEB90")]
	private void CNFFBHHMLBO(CGNEFKCKCBE BAAPAEECMJF, HLIBDGEMJOE JIMFJKNHNFO, CGNEFKCKCBE LGODHBBPAKI, CGNEFKCKCBE NNPHPFCFLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68BFE30", Offset = "0x68BEE30", VA = "0x1868BFE30")]
	private void GHBGEKDMLBK(CGNEFKCKCBE BAAPAEECMJF, HLIBDGEMJOE JIMFJKNHNFO, HLIBDGEMJOE EODIBGFHMBJ, HLIBDGEMJOE NHBKNIAECDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FGAHNOJGEPM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JNPNFACCPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public NDJGECDCBMH container;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public JNPNFACCPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x68B78C0", Offset = "0x68B68C0", VA = "0x1868B78C0")]
		internal MFKKIJIAKFP BKNOKFKLACP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68B49F0", Offset = "0x68B39F0", VA = "0x1868B49F0")]
	public static void HEDHDPLCNKO(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x68B4B70", Offset = "0x68B3B70", VA = "0x1868B4B70")]
	public static void MJNELEKEADG(NDJGECDCBMH MMBLPJPOBHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HEKNHPPLHGP : GGGIDHLBFJH, JAHFNGCPCAL
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx DFDEBBEGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly MFKKIJIAKFP MCONGBCLPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DIAIAIEFNPG JEJBGKANNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly KDGDCLPEMLL LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly GAOCAMKKGDF[] KHBHHDCJIKE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(CGNEFKCKCBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HLIBDGEMJOE BPNCAECCAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x68B6C10", Offset = "0x68B5C10", VA = "0x1868B6C10", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HLIBDGEMJOE DENGGEADFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x68B52D0", Offset = "0x68B42D0", VA = "0x1868B52D0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 FMOBCCOFPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68B6440", Offset = "0x68B5440", VA = "0x1868B6440", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion ICOOIINFNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68B53C0", Offset = "0x68B43C0", VA = "0x1868B53C0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BPKHKABHCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68B67D0", Offset = "0x68B57D0", VA = "0x1868B67D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<HLIBDGEMJOE> CJGPMBFHLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68B5390", Offset = "0x68B4390", VA = "0x1868B5390", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool KPOEOEJOAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95C910", VA = "0x18095D910", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAE4D20", Offset = "0xAE3D20", VA = "0x180AE4D20", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform EALAKNFEFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68B6E20", Offset = "0x68B5E20", VA = "0x1868B6E20", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject AKFNNOMHACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x25B3EE0", Offset = "0x25B2EE0", VA = "0x1825B3EE0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68B6B40", Offset = "0x68B5B40", VA = "0x1868B6B40", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid BNGFJMBLCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68B6C70", Offset = "0x68B5C70", VA = "0x1868B6C70", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IAIMMFGDICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68B6D50", Offset = "0x68B5D50", VA = "0x1868B6D50", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool KPDIBFOJGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool PECJIIDKBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x68B6780", Offset = "0x68B5780", VA = "0x1868B6780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event OACIGPAJDDJ PMIDCKPHMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x68B59C0", Offset = "0x68B49C0", VA = "0x1868B59C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x68B5A20", Offset = "0x68B4A20", VA = "0x1868B5A20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event OACIGPAJDDJ IHCKPBOLPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68B54C0", Offset = "0x68B44C0", VA = "0x1868B54C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68B5520", Offset = "0x68B4520", VA = "0x1868B5520", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event OACIGPAJDDJ IOGIIHMHMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68B63E0", Offset = "0x68B53E0", VA = "0x1868B63E0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68B62E0", Offset = "0x68B52E0", VA = "0x1868B62E0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event CGDMDANBNDA IFNIKFHJJML
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x68B6240", Offset = "0x68B5240", VA = "0x1868B6240", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68B6340", Offset = "0x68B5340", VA = "0x1868B6340", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68B6A40", Offset = "0x68B5A40", VA = "0x1868B6A40")]
	public HEKNHPPLHGP(CGNEFKCKCBE BEHCCOMHFAP, RigidbodyEx DFDEBBEGAOA, DIAIAIEFNPG JEJBGKANNBD, GAOCAMKKGDF[] KHBHHDCJIKE, KDGDCLPEMLL LCGMLIBOFMO, PJMFMNBEBBK MCONGBCLPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68B5780", Offset = "0x68B4780", VA = "0x1868B5780", Slot = "19")]
	public void HKPMLCIOMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "21")]
	public void OMGEOHMCONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67192A0", Offset = "0x67182A0", VA = "0x1867192A0", Slot = "22")]
	public void EKFNCCAFMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68B5340", Offset = "0x68B4340", VA = "0x1868B5340", Slot = "20")]
	public void BHMAKOOBFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x68B57B0", Offset = "0x68B47B0", VA = "0x1868B57B0", Slot = "25")]
	public void IEMFIONAHCG(int KFEHOEEBGJI, HLIBDGEMJOE KEDJKAHDNCH, int BNDJBIDIMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x68B6840", Offset = "0x68B5840", VA = "0x1868B6840", Slot = "26")]
	public void OFBBABIEPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x68B64A0", Offset = "0x68B54A0", VA = "0x1868B64A0", Slot = "27")]
	public void MFENABLJMJH(int KFEHOEEBGJI, HLIBDGEMJOE CFCGKFPLMDN, int JJFODKANDBC, [Optional] Vector3? GAAAAMHHMNP, [Optional] Quaternion? IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x68B6910", Offset = "0x68B5910", VA = "0x1868B6910", Slot = "28")]
	public void OGBMDPPLFIC(HLIBDGEMJOE CFCGKFPLMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68B5AD0", Offset = "0x68B4AD0", VA = "0x1868B5AD0", Slot = "31")]
	public void INGIDLNGHNF(Vector3 LLMGGJGPDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68B5EE0", Offset = "0x68B4EE0", VA = "0x1868B5EE0", Slot = "29")]
	public void JGEKCHFIPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68B50D0", Offset = "0x68B40D0", VA = "0x1868B50D0", Slot = "30")]
	public void ALBIBJPCCOK(int HCALFJOJKJO, Vector3 NPKPBDEJFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68B56B0", Offset = "0x68B46B0", VA = "0x1868B56B0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int KFEHOEEBGJI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68B5580", Offset = "0x68B4580", VA = "0x1868B5580", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int KFEHOEEBGJI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9955B0", Offset = "0x9945B0", VA = "0x1809955B0", Slot = "42")]
	public Color GetConnectionSlotColor(int KFEHOEEBGJI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x68B5420", Offset = "0x68B4420", VA = "0x1868B5420", Slot = "43")]
	public bool CanConnectTo(int KFEHOEEBGJI, HLIBDGEMJOE FEONOJLADDD, int HFIMCDMEDKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "44")]
	public void ParentChanged(int KFEHOEEBGJI, HLIBDGEMJOE DJCKLAMFDOA, int JEJHJCLKJMB, Vector3 MOGKDNCFFLO, Quaternion ELDAEEBMMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "45")]
	public void ChildAdded(int KFEHOEEBGJI, HLIBDGEMJOE BKDENEBNGLH, int FCJDJFHGCAM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "46")]
	public void ChildRemoved(int KFEHOEEBGJI, HLIBDGEMJOE NEENDAEEGKJ, int AKPLCCFDFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "47")]
	public void ConnectionModified(int KFEHOEEBGJI, HLIBDGEMJOE KEDJKAHDNCH, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x68B6990", Offset = "0x68B5990", VA = "0x1868B6990", Slot = "48")]
	public void RootChanged(HLIBDGEMJOE LFFFMJOOIPA, HLIBDGEMJOE AFDKABHHBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x68B5A80", Offset = "0x68B4A80", VA = "0x1868B5A80", Slot = "23")]
	public void IMMNHFDDDPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x68B5080", Offset = "0x68B4080", VA = "0x1868B5080", Slot = "24")]
	public void AACAHHKDJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68B61F0", Offset = "0x68B51F0", VA = "0x1868B61F0")]
	private void JJMHMDEKAAD(bool FKAABLDBIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[NCOAPLINBMC(typeof(CFMBKPCNCPN), new string[] { })]
public class NCHPALAMFHJ : CFMBKPCNCPN, IIGBGGHKDKO
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OGHOCFLNIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public NCHPALAMFHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public LKKANPIGGEI localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public OGHOCFLNIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x68C66C0", Offset = "0x68C56C0", VA = "0x1868C66C0")]
		internal void BCKLEFIDMJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[FDECJLEHCBL]
	private ELPHIHAJAON JAJIMFKDCOE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object HGHNIAOJNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x68C3190", Offset = "0x68C2190", VA = "0x1868C3190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x68C3140", Offset = "0x68C2140", VA = "0x1868C3140", Slot = "6")]
	public void InitReferences(APGMJOIFDDC NDICMFPNNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x68C2FD0", Offset = "0x68C1FD0", VA = "0x1868C2FD0", Slot = "5")]
	public void FDEOGKEAAOG(LKKANPIGGEI HDBEGMKJNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public NCHPALAMFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[NCOAPLINBMC(typeof(PJMFMNBEBBK), new string[] { "Ignore", "Mock" })]
public class AKFCNKGDDNM : PJMFMNBEBBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MGDAGLFMBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HLIBDGEMJOE, HLIBDGEMJOE> MDLILEBPCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x68B3300", Offset = "0x68B2300", VA = "0x1868B3300", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x68B31A0", Offset = "0x68B21A0", VA = "0x1868B31A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<HLIBDGEMJOE, HLIBDGEMJOE> GMPEOPKGEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x68B3460", Offset = "0x68B2460", VA = "0x1868B3460", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x68B3510", Offset = "0x68B2510", VA = "0x1868B3510", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<HLIBDGEMJOE, HLIBDGEMJOE, HLIBDGEMJOE> PCOMLELDAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x68B33B0", Offset = "0x68B23B0", VA = "0x1868B33B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x68B3250", Offset = "0x68B2250", VA = "0x1868B3250", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "12")]
	public void LFNNOPDGNGK(GameObject IDHOMJBMFPB, LPNANCLPMKG KLIOHNILOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "13")]
	public void GACAEOGENLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "14")]
	public void GGLLICMBJNI(HLIBDGEMJOE JIMFJKNHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "15")]
	public void CNEBNJPACBD(HLIBDGEMJOE JIMFJKNHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "16")]
	public void LDIFAOBPPGJ(HLIBDGEMJOE JIMFJKNHNFO, HashSet<HLIBDGEMJOE> MKFCLEPBEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "17")]
	public void GNOBGGOBJEK(HLIBDGEMJOE JIMFJKNHNFO, HLIBDGEMJOE FEAEJHMDDMM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "18")]
	public void GLODDIFINFE(HLIBDGEMJOE JIMFJKNHNFO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "19")]
	public void NEKLJOMCHIC(HLIBDGEMJOE JIMFJKNHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "20")]
	public LKBFGJGBJEC KAOFPJDPEJC(bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "21")]
	public LKBFGJGBJEC BCHDNKHIABG(HashSet<Guid> OKLICKEMEHJ, bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "22")]
	public bool EHPFHFIBOOI(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "23")]
	public void BOGAHIEHKEH(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "24")]
	public void LCKLBANBHHC(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "25")]
	public void EEFHEEOCHFG(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public AKFCNKGDDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HLIBDGEMJOE : JAHFNGCPCAL, IEquatable<HLIBDGEMJOE>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JAHFNGCPCAL
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HLIBDGEMJOE BPNCAECCAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform EALAKNFEFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject AKFNNOMHACD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid BNGFJMBLCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int IAIMMFGDICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CGNEFKCKCBE KEHFAMPKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KPDIBFOJGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int KFEHOEEBGJI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int KFEHOEEBGJI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int KFEHOEEBGJI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int KFEHOEEBGJI, HLIBDGEMJOE FEONOJLADDD, int OEIGGFNIPHO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int KFEHOEEBGJI, HLIBDGEMJOE DJCKLAMFDOA, int JEJHJCLKJMB, Vector3 MOGKDNCFFLO, Quaternion ELDAEEBMMFC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int KFEHOEEBGJI, HLIBDGEMJOE BKDENEBNGLH, int FCJDJFHGCAM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int KFEHOEEBGJI, HLIBDGEMJOE NEENDAEEGKJ, int AKPLCCFDFIE);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int KFEHOEEBGJI, HLIBDGEMJOE KEDJKAHDNCH, int CGKNMBGPFNI, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(HLIBDGEMJOE LFFFMJOOIPA, HLIBDGEMJOE AFDKABHHBLA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[CCHFMGLFBCK(ICPIBLGDMFM.OMRoom)]
public interface PJMFMNBEBBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MGDAGLFMBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HLIBDGEMJOE, HLIBDGEMJOE> MDLILEBPCNK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HLIBDGEMJOE, HLIBDGEMJOE> GMPEOPKGEGO;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HLIBDGEMJOE, HLIBDGEMJOE, HLIBDGEMJOE> PCOMLELDAOF;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LFNNOPDGNGK(GameObject IDHOMJBMFPB, LPNANCLPMKG KLIOHNILOOM);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GACAEOGENLN();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GGLLICMBJNI(HLIBDGEMJOE JIMFJKNHNFO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CNEBNJPACBD(HLIBDGEMJOE JIMFJKNHNFO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LDIFAOBPPGJ(HLIBDGEMJOE JIMFJKNHNFO, HashSet<HLIBDGEMJOE> MKFCLEPBEOG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GNOBGGOBJEK(HLIBDGEMJOE JIMFJKNHNFO, HLIBDGEMJOE FEAEJHMDDMM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GLODDIFINFE(HLIBDGEMJOE JIMFJKNHNFO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NEKLJOMCHIC(HLIBDGEMJOE JIMFJKNHNFO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	LKBFGJGBJEC KAOFPJDPEJC(bool BNLEDKHOCDP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	LKBFGJGBJEC BCHDNKHIABG(HashSet<Guid> OKLICKEMEHJ, bool BNLEDKHOCDP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EHPFHFIBOOI(MBHEBJKPDFI CBKMIAOMAIC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BOGAHIEHKEH(LKBFGJGBJEC MKCPNDCEKPI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LCKLBANBHHC(LKBFGJGBJEC MKCPNDCEKPI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EEFHEEOCHFG(LKBFGJGBJEC MKCPNDCEKPI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FIBGHMOFPMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DAEPGHIJCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HLIBDGEMJOE BPDCLBLEDEI(int BJDEGAHEFFB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HLIBDGEMJOE DKIJEAHPAJP(Guid JHNJLCKMJHP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDKBJLLHGDJ(HLIBDGEMJOE JIMFJKNHNFO);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IJHCGIGGJNI();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GILHIOCBGDC(HLIBDGEMJOE JEJBGKANNBD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CCHFMGLFBCK(ICPIBLGDMFM.Application)]
public interface KDGDCLPEMLL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PECJIIDKBBE(DIAIAIEFNPG JEJBGKANNBD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DNODBJMEKBI(DIAIAIEFNPG JEJBGKANNBD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MMINDHKBAKF(DIAIAIEFNPG JEJBGKANNBD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid KEGMGHDOMLD(DIAIAIEFNPG JEJBGKANNBD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FHJNOJPKDEI(DIAIAIEFNPG JEJBGKANNBD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JFEIKOELCPG(DIAIAIEFNPG JEJBGKANNBD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void OACIGPAJDDJ(HLIBDGEMJOE CFCGKFPLMDN, int NAJKAFLHMFI, HLIBDGEMJOE KEDJKAHDNCH, int LFADONDGNIO, [Optional] Vector3? GAAAAMHHMNP, [Optional] Quaternion? IFNIIKLFIFC);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void CGDMDANBNDA(HLIBDGEMJOE LFFFMJOOIPA, HLIBDGEMJOE AFDKABHHBLA);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DIAIAIEFNPG : HLIBDGEMJOE, JAHFNGCPCAL, IEquatable<HLIBDGEMJOE>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GGGIDHLBFJH : JAHFNGCPCAL
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HLIBDGEMJOE DENGGEADFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<HLIBDGEMJOE> CJGPMBFHLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 FMOBCCOFPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion ICOOIINFNDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool BPKHKABHCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool KPOEOEJOAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event OACIGPAJDDJ PMIDCKPHMMO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event OACIGPAJDDJ IHCKPBOLPEN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event OACIGPAJDDJ IOGIIHMHMDJ;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event CGDMDANBNDA IFNIKFHJJML;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HKPMLCIOMID();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BHMAKOOBFHF();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OMGEOHMCONL();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EKFNCCAFMIL();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IMMNHFDDDPA();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AACAHHKDJIC();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IEMFIONAHCG(int KFEHOEEBGJI, HLIBDGEMJOE KEDJKAHDNCH, int BNDJBIDIMJM);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OFBBABIEPPA();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MFENABLJMJH(int KFEHOEEBGJI, HLIBDGEMJOE CFCGKFPLMDN, int JJFODKANDBC, [Optional] Vector3? GAAAAMHHMNP, [Optional] Quaternion? IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OGBMDPPLFIC(HLIBDGEMJOE CFCGKFPLMDN);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void JGEKCHFIPPI();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ALBIBJPCCOK(int HCALFJOJKJO, Vector3 NPKPBDEJFNH);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void INGIDLNGHNF(Vector3 LLMGGJGPDFE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GAOCAMKKGDF
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 PHEEFLGILJO
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
public interface LPNANCLPMKG
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BAIFHIJAKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IOMHLCCOOLE FAPNLDNKDNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, LPNANCLPMKG
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
			[Cpp2IlInjected.Address(RVA = "0x95D990", Offset = "0x95C990", VA = "0x18095D990", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IOMHLCCOOLE LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x68B4660", Offset = "0x68B3660", VA = "0x1868B4660")]
		public static ConnectableConfigData HLFOIHJLILB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x68B4720", Offset = "0x68B3720", VA = "0x1868B4720")]
		public ConnectableConfigData(LegacyConnectableLinkVisual COINDOCGNMP, bool CJIEDGBKFAB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JOCKAABMCMC : IEquatable<JOCKAABMCMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public HLIBDGEMJOE JIMFJKNHNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int DFJEFGPHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int CGKNMBGPFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 GAAAAMHHMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion IFNIIKLFIFC;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x68B7DF0", Offset = "0x68B6DF0", VA = "0x1868B7DF0")]
	public JOCKAABMCMC(HLIBDGEMJOE JIMFJKNHNFO, int DFJEFGPHPMN, int CGKNMBGPFNI, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x68B7EE0", Offset = "0x68B6EE0", VA = "0x1868B7EE0")]
	public JOCKAABMCMC(HLIBDGEMJOE JIMFJKNHNFO, int DFJEFGPHPMN, int CGKNMBGPFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x68B7E50", Offset = "0x68B6E50", VA = "0x1868B7E50")]
	public JOCKAABMCMC(HLIBDGEMJOE JIMFJKNHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x68B7970", Offset = "0x68B6970", VA = "0x1868B7970", Slot = "4")]
	public bool Equals(JOCKAABMCMC ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x68B7A20", Offset = "0x68B6A20", VA = "0x1868B7A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class HFBEDNCBJJD : MEHDODPIIEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform DBCCBLKNBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private IOMHLCCOOLE EBCLNLJEICG;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x63B4C80", Offset = "0x63B3C80", VA = "0x1863B4C80", Slot = "4")]
	public void LFNNOPDGNGK(Transform DBCCBLKNBHK, IOMHLCCOOLE EBCLNLJEICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x68B6EB0", Offset = "0x68B5EB0", VA = "0x1868B6EB0", Slot = "5")]
	public IOMHLCCOOLE IGNFHKJJDGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x68B6E40", Offset = "0x68B5E40", VA = "0x1868B6E40", Slot = "6")]
	public void AEICAPBBGBI(IOMHLCCOOLE OANBIKPBANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public HFBEDNCBJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KECEEIPEDKJ : IDisposable, NILCLFJKOMC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KLGEBNNFEIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public HLIBDGEMJOE oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HLIBDGEMJOE newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public KLGEBNNFEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x68BC230", Offset = "0x68BB230", VA = "0x1868BC230")]
		internal bool EFCJJKGOLOH(IMJAFGNHIKA node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly BCEDMMKPEML BCCLGAPDNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private JFLGOAFOOPF ICKCCEJHFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NMHEMAGENMK PHHCGKEOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool CJIEDGBKFAB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly PHLKHBEJKKB FGIMBBFPHPI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IMJAFGNHIKA KILMHGFMJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x68BB7F0", Offset = "0x68BA7F0", VA = "0x1868BB7F0")]
	public bool OBLAPDCEACC([In] GHOBOBEDOJF AHGAPHMJDIB, bool LMMOCDOLNCH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x68B9D40", Offset = "0x68B8D40", VA = "0x1868B9D40")]
	private bool GBDPOOEKGIN([In] GHOBOBEDOJF AHGAPHMJDIB, bool LMMOCDOLNCH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x68BC060", Offset = "0x68BB060", VA = "0x1868BC060")]
	public KECEEIPEDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x68BB800", Offset = "0x68BA800", VA = "0x1868BB800", Slot = "5")]
	public void LFNNOPDGNGK(PJMFMNBEBBK HADKCEDAMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x68BB360", Offset = "0x68BA360", VA = "0x1868BB360", Slot = "17")]
	public void KIHDGHMCPKG(MADFLPEOINA IPCEAEAAIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x68B8DD0", Offset = "0x68B7DD0", VA = "0x1868B8DD0", Slot = "12")]
	public void ADAJCPEDKAP(Func<HLIBDGEMJOE, bool> FFEGCKOJGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x68B8CA0", Offset = "0x68B7CA0", VA = "0x1868B8CA0")]
	private void ADAJCPEDKAP(BCEDMMKPEML OHDOOCGHDGN, Func<HLIBDGEMJOE, bool> FFEGCKOJGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x68BAEC0", Offset = "0x68B9EC0", VA = "0x1868BAEC0", Slot = "11")]
	public void JJJFJJCIHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x68BACF0", Offset = "0x68B9CF0", VA = "0x1868BACF0", Slot = "8")]
	public bool INMODOFAAAJ(HLIBDGEMJOE BGHIPCLOGCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x68B9630", Offset = "0x68B8630", VA = "0x1868B9630")]
	private bool FIHKJGMDGOD(HLIBDGEMJOE HGKEBABCNOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x68BB390", Offset = "0x68BA390", VA = "0x1868BB390")]
	private static bool LCHDGBLOIPI(HLIBDGEMJOE HGKEBABCNOE, BCEDMMKPEML ILJJHGIDMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x68BAF80", Offset = "0x68B9F80", VA = "0x1868BAF80")]
	private void JPHIKHFDPBA(Transform BKMFMLMGOAL, BCEDMMKPEML EMBFPPPDOFB, BCEDMMKPEML[] HMIALOLJOGL, HLIBDGEMJOE LPOJCFCPHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x68BB890", Offset = "0x68BA890", VA = "0x1868BB890")]
	private JOCKAABMCMC LOAEOPIJPDI(Transform MOMJFILBPOE, JOCKAABMCMC LLOKDCFELAO)
	{
		return default(JOCKAABMCMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68BAD00", Offset = "0x68B9D00", VA = "0x1868BAD00")]
	private static bool JADHLDNKADI(BCEDMMKPEML ILJJHGIDMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68B9350", Offset = "0x68B8350", VA = "0x1868B9350", Slot = "9")]
	public bool CGGLALLHJJF(HLIBDGEMJOE OMMNHDEIHNG, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x68BBD40", Offset = "0x68BAD40", VA = "0x1868BBD40")]
	private bool PHCMBCFIDIJ(HLIBDGEMJOE OMMNHDEIHNG, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x68B8DE0", Offset = "0x68B7DE0", VA = "0x1868B8DE0")]
	private static void AGGNMEOICGI(HLIBDGEMJOE OMMNHDEIHNG, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC, BCEDMMKPEML HGGEBKHAOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x68BB9E0", Offset = "0x68BA9E0", VA = "0x1868BB9E0")]
	private void NAOPANKOALO(HLIBDGEMJOE KLJLPOGDLBO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x68BBB00", Offset = "0x68BAB00", VA = "0x1868BBB00")]
	private void NGDPDMMBPID(BCEDMMKPEML OHDOOCGHDGN, HLIBDGEMJOE EODIBGFHMBJ, HLIBDGEMJOE NHBKNIAECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x68BBB70", Offset = "0x68BAB70", VA = "0x1868BBB70")]
	private void NGDPDMMBPID(HLIBDGEMJOE JIMFJKNHNFO, HLIBDGEMJOE EODIBGFHMBJ, HLIBDGEMJOE NHBKNIAECDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x68BA910", Offset = "0x68B9910", VA = "0x1868BA910")]
	private void GHBGEKDMLBK(HLIBDGEMJOE JIMFJKNHNFO, HLIBDGEMJOE EODIBGFHMBJ, HLIBDGEMJOE NHBKNIAECDE, bool OKCIACNFKBA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68BA980", Offset = "0x68B9980", VA = "0x1868BA980")]
	private void GHBGEKDMLBK(BCEDMMKPEML JMCFDCHCIPI, HLIBDGEMJOE LPOJCFCPHOK, HLIBDGEMJOE AFDKABHHBLA, bool OKCIACNFKBA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x68B9160", Offset = "0x68B8160", VA = "0x1868B9160")]
	private void BPIFBBKNAOD(HLIBDGEMJOE CDKDCIHMCOB, int JJFODKANDBC, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x68BBBE0", Offset = "0x68BABE0", VA = "0x1868BBBE0")]
	private void ONKGNDEMLCI(IMJAFGNHIKA EMOKCJBMKOL, IMJAFGNHIKA HCJJMFJCFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x68BAA80", Offset = "0x68B9A80", VA = "0x1868BAA80", Slot = "18")]
	public HLIBDGEMJOE GKOGHGDOFJD(HLIBDGEMJOE JIMFJKNHNFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x68BB440", Offset = "0x68BA440", VA = "0x1868BB440", Slot = "13")]
	public void LDIFAOBPPGJ(HLIBDGEMJOE JIMFJKNHNFO, HashSet<HLIBDGEMJOE> ALMOMDBGINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x68B93F0", Offset = "0x68B83F0", VA = "0x1868B93F0", Slot = "14")]
	public List<HLIBDGEMJOE> CPOEEHONKDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x68B9280", Offset = "0x68B8280", VA = "0x1868B9280")]
	protected IMJAFGNHIKA CEEMGONLPKH(IMJAFGNHIKA OHDOOCGHDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x68BAEE0", Offset = "0x68B9EE0", VA = "0x1868BAEE0")]
	protected BCEDMMKPEML[] JLJJBMLFLBL(BCEDMMKPEML ILJJHGIDMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x68BABE0", Offset = "0x68B9BE0", VA = "0x1868BABE0")]
	protected bool HGANABDNOHN(HLIBDGEMJOE JIMFJKNHNFO, [Out] BCEDMMKPEML OHDOOCGHDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x68B8F60", Offset = "0x68B7F60", VA = "0x1868B8F60", Slot = "15")]
	public bool AJGKDLGPHAH(HLIBDGEMJOE JIMFJKNHNFO, [Out] JOCKAABMCMC BLODLAPNEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x68B93B0", Offset = "0x68B83B0", VA = "0x1868B93B0")]
	protected BCEDMMKPEML CHKGOBOMFCE(JOCKAABMCMC JLOKJLGICKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x68BA310", Offset = "0x68B9310", VA = "0x1868BA310", Slot = "10")]
	public bool GDKJBHLFHAL(HLIBDGEMJOE KLJLPOGDLBO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x68BA370", Offset = "0x68B9370", VA = "0x1868BA370")]
	private bool GFPKJEFMFCG(HLIBDGEMJOE KLJLPOGDLBO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x68B9090", Offset = "0x68B8090", VA = "0x1868B9090")]
	private static bool BOOJNPGLCKJ(BCEDMMKPEML IBIKLPJGOGL, JOCKAABMCMC MBFJBIJNJPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x68BB7F0", Offset = "0x68BA7F0", VA = "0x1868BB7F0", Slot = "7")]
	private bool LFMIGLOLIKM([In] GHOBOBEDOJF AHGAPHMJDIB, bool LMMOCDOLNCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class AIDMCINNKEE : PJMFMNBEBBK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly NDJGECDCBMH MMBLPJPOBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly NMHEMAGENMK PHHCGKEOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly LDMNMENJBNC OOALDOIBEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly NOBHFPGEPPP MMGEHFIODCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly NILCLFJKOMC MKCPNDCEKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal CCCMIJOFMKK LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal NHKMGBEMBND PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal JFLGOAFOOPF KDPLAOFLGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool CJIEDGBKFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool GMMOMKBANON;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool JJPNEJDINPE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1EA0", Offset = "0x9F0EA0", VA = "0x1809F1EA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1A3A2B0", Offset = "0x1A392B0", VA = "0x181A3A2B0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1E80", Offset = "0x9F0E80", VA = "0x1809F1E80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1A3A2A0", Offset = "0x1A392A0", VA = "0x181A3A2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MGDAGLFMBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HLIBDGEMJOE, HLIBDGEMJOE> MDLILEBPCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x68B2780", Offset = "0x68B1780", VA = "0x1868B2780", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x68B1600", Offset = "0x68B0600", VA = "0x1868B1600", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HLIBDGEMJOE, HLIBDGEMJOE> GMPEOPKGEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x68B2C90", Offset = "0x68B1C90", VA = "0x1868B2C90", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x68B2CF0", Offset = "0x68B1CF0", VA = "0x1868B2CF0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HLIBDGEMJOE, HLIBDGEMJOE, HLIBDGEMJOE> PCOMLELDAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x68B27E0", Offset = "0x68B17E0", VA = "0x1868B27E0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x68B1F90", Offset = "0x68B0F90", VA = "0x1868B1F90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x68B2DB0", Offset = "0x68B1DB0", VA = "0x1868B2DB0")]
	public AIDMCINNKEE(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x68B21C0", Offset = "0x68B11C0", VA = "0x1868B21C0", Slot = "12")]
	public void LFNNOPDGNGK(GameObject IDHOMJBMFPB, LPNANCLPMKG KLIOHNILOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x68B1660", Offset = "0x68B0660", VA = "0x1868B1660", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x68B1790", Offset = "0x68B0790", VA = "0x1868B1790", Slot = "13")]
	public void GACAEOGENLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x68B1930", Offset = "0x68B0930", VA = "0x1868B1930", Slot = "14")]
	public void GGLLICMBJNI(HLIBDGEMJOE JIMFJKNHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x68B15A0", Offset = "0x68B05A0", VA = "0x1868B15A0", Slot = "15")]
	public void CNEBNJPACBD(HLIBDGEMJOE JIMFJKNHNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x68B1740", Offset = "0x68B0740", VA = "0x1868B1740", Slot = "22")]
	public bool EHPFHFIBOOI(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x68B17E0", Offset = "0x68B07E0", VA = "0x1868B17E0")]
	internal bool GBDPOOEKGIN([In] GHOBOBEDOJF AHGAPHMJDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x68B18A0", Offset = "0x68B08A0", VA = "0x1868B18A0")]
	internal bool GFPKJEFMFCG([In] GHOBOBEDOJF AHGAPHMJDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x68B2D50", Offset = "0x68B1D50", VA = "0x1868B2D50")]
	internal bool PELEKBGDMLC([In] GHOBOBEDOJF AHGAPHMJDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x68B2970", Offset = "0x68B1970", VA = "0x1868B2970")]
	internal bool NBPAANHGMDC([In] GHOBOBEDOJF AHGAPHMJDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x68B1CA0", Offset = "0x68B0CA0", VA = "0x1868B1CA0")]
	internal void GNPAIIBNFHA(HLIBDGEMJOE JIMFJKNHNFO, int MIJDMCPMBMD, bool LMMOCDOLNCH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x68B15A0", Offset = "0x68B05A0", VA = "0x1868B15A0")]
	internal bool OCHAOMIPALO(HLIBDGEMJOE PJAKFDDBJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x68B2840", Offset = "0x68B1840", VA = "0x1868B2840")]
	internal bool MFBBDNOPOLC(HLIBDGEMJOE OMMNHDEIHNG, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x68B20C0", Offset = "0x68B10C0", VA = "0x1868B20C0", Slot = "16")]
	public void LDIFAOBPPGJ(HLIBDGEMJOE JIMFJKNHNFO, HashSet<HLIBDGEMJOE> MKFCLEPBEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x68B1A90", Offset = "0x68B0A90", VA = "0x1868B1A90", Slot = "17")]
	public void GNOBGGOBJEK(HLIBDGEMJOE OMMNHDEIHNG, HLIBDGEMJOE FEAEJHMDDMM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x68B1950", Offset = "0x68B0950", VA = "0x1868B1950", Slot = "18")]
	public void GLODDIFINFE(HLIBDGEMJOE KLJLPOGDLBO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x68B2AC0", Offset = "0x68B1AC0", VA = "0x1868B2AC0", Slot = "19")]
	public void NEKLJOMCHIC(HLIBDGEMJOE KLJLPOGDLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x68B1E80", Offset = "0x68B0E80", VA = "0x1868B1E80")]
	public void HHPMPAOABJA([Optional] FOGBAACKIFG KHKLKJIGHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x68B1510", Offset = "0x68B0510", VA = "0x1868B1510", Slot = "23")]
	public void BOGAHIEHKEH(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x68B1FF0", Offset = "0x68B0FF0", VA = "0x1868B1FF0", Slot = "20")]
	public LKBFGJGBJEC KAOFPJDPEJC(bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x68B14F0", Offset = "0x68B04F0", VA = "0x1868B14F0", Slot = "21")]
	public LKBFGJGBJEC BCHDNKHIABG(HashSet<Guid> OKLICKEMEHJ, bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x68B1700", Offset = "0x68B0700", VA = "0x1868B1700", Slot = "25")]
	public void EEFHEEOCHFG(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x68B2010", Offset = "0x68B1010", VA = "0x1868B2010", Slot = "24")]
	public void LCKLBANBHHC(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class NMHEMAGENMK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly DNDLMNGOFAF<HLIBDGEMJOE, HLIBDGEMJOE> MDLILEBPCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly DNDLMNGOFAF<HLIBDGEMJOE, HLIBDGEMJOE> GMPEOPKGEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly BGDMCGKFNLN<HLIBDGEMJOE, HLIBDGEMJOE, HLIBDGEMJOE> PCOMLELDAOF;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x68C33D0", Offset = "0x68C23D0", VA = "0x1868C33D0")]
	public NMHEMAGENMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	public void LFNNOPDGNGK(AIDMCINNKEE HADKCEDAMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x68C3370", Offset = "0x68C2370", VA = "0x1868C3370")]
	public void LABCCADGILC(HLIBDGEMJOE EMOKCJBMKOL, HLIBDGEMJOE CDKDCIHMCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x68C3310", Offset = "0x68C2310", VA = "0x1868C3310")]
	public void KJMIFCAIJBL(HLIBDGEMJOE EMOKCJBMKOL, HLIBDGEMJOE CDKDCIHMCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x68C3290", Offset = "0x68C2290", VA = "0x1868C3290")]
	public void CONPMGGKNBN(HLIBDGEMJOE JHCCBIEGECC, HLIBDGEMJOE MECDJMBEHCP, HLIBDGEMJOE CDKDCIHMCOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LDMNMENJBNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private AIDMCINNKEE HADKCEDAMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NHKMGBEMBND PIKFDLICNNE;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public LDMNMENJBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x68BC590", Offset = "0x68BB590", VA = "0x1868BC590")]
	public void LFNNOPDGNGK(AIDMCINNKEE HADKCEDAMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x68BC3F0", Offset = "0x68BB3F0", VA = "0x1868BC3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x68BC570", Offset = "0x68BB570", VA = "0x1868BC570")]
	private void IGILLMDJNFH(FOGBAACKIFG GOJJHGGKKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x68BC500", Offset = "0x68BB500", VA = "0x1868BC500")]
	private void GHFLOCOECKD(FOGBAACKIFG IDBEHPCFICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x68BC400", Offset = "0x68BB400", VA = "0x1868BC400")]
	public void FPIECLIIIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x68BC2F0", Offset = "0x68BB2F0", VA = "0x1868BC2F0")]
	public void BMFJIOPIMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FCCCCOMMPFP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NBJCLNPNNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NDJGECDCBMH container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public NBJCLNPNNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x68C2F60", Offset = "0x68C1F60", VA = "0x1868C2F60")]
		internal AIDMCINNKEE BKNOKFKLACP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x68B4770", Offset = "0x68B3770", VA = "0x1868B4770")]
	public static void HEDHDPLCNKO(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x68B4970", Offset = "0x68B3970", VA = "0x1868B4970")]
	public static void MJNELEKEADG(NDJGECDCBMH MMBLPJPOBHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class KDJBIMOKEIN : IDisposable, JFLGOAFOOPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, IOMHLCCOOLE> ICGDOHKHHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly MADFLPEOINA MHKIGGJFOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private MEHDODPIIEP NLEHFGPEFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NILCLFJKOMC MKCPNDCEKPI;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68B8BC0", Offset = "0x68B7BC0", VA = "0x1868B8BC0")]
	public KDJBIMOKEIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68B86B0", Offset = "0x68B76B0", VA = "0x1868B86B0", Slot = "7")]
	public void LFNNOPDGNGK(NILCLFJKOMC MKCPNDCEKPI, MEHDODPIIEP NLEHFGPEFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x68B8920", Offset = "0x68B7920", VA = "0x1868B8920", Slot = "5")]
	public void PFEBEPPGBLE(IMJAFGNHIKA CLBBJKBIFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x68B87B0", Offset = "0x68B77B0", VA = "0x1868B87B0", Slot = "9")]
	public void OIFMMCFGFMN(IMJAFGNHIKA OIBIBELOGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x68B84F0", Offset = "0x68B74F0", VA = "0x1868B84F0", Slot = "8")]
	public void KFIEGJJGALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x68B81A0", Offset = "0x68B71A0", VA = "0x1868B81A0", Slot = "10")]
	public void JAGDEEDGEHA(IMJAFGNHIKA NLPCOABBIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x68B86F0", Offset = "0x68B76F0", VA = "0x1868B86F0", Slot = "11")]
	public void MPOLKAFEDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x68B7FF0", Offset = "0x68B6FF0", VA = "0x1868B7FF0")]
	private bool AJJJIHKHDHF(IMJAFGNHIKA BBIKELPGJLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class NOBHFPGEPPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct IJFKECKOOJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly BCEDMMKPEML HCKBIMBKNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> OKLICKEMEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly MBHEBJKPDFI LCFBNIFMKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly MBHEBJKPDFI GPKFLFLBDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool BNLEDKHOCDP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool DBLOGPAEJGO
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x68B71A0", Offset = "0x68B61A0", VA = "0x1868B71A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x68B7850", Offset = "0x68B6850", VA = "0x1868B7850")]
		public IJFKECKOOJH(BCEDMMKPEML HCKBIMBKNCN, HashSet<Guid> OKLICKEMEHJ, bool BNLEDKHOCDP, [Optional] MBHEBJKPDFI LCFBNIFMKOA, [Optional] MBHEBJKPDFI GPKFLFLBDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x68B7430", Offset = "0x68B6430", VA = "0x1868B7430")]
		public MBHEBJKPDFI JMNIMAIKKED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x68B75D0", Offset = "0x68B65D0", VA = "0x1868B75D0")]
		private MBHEBJKPDFI NGOCPFCFFMA([Out] MBHEBJKPDFI FFMJOFKJBID, [Out] MBHEBJKPDFI CNOBJEBHCGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x68B6F80", Offset = "0x68B5F80", VA = "0x1868B6F80")]
		private MBHEBJKPDFI DFGIKCPGEKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x68B72C0", Offset = "0x68B62C0", VA = "0x1868B72C0")]
		private void GGAPPMNGIEA(MBHEBJKPDFI EMNFNNLGOPF, MBHEBJKPDFI POPDEMIIKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x68B7690", Offset = "0x68B6690", VA = "0x1868B7690")]
		private void OLGOOHIILEO(MBHEBJKPDFI FFMJOFKJBID, MBHEBJKPDFI CNOBJEBHCGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private AIDMCINNKEE HADKCEDAMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NILCLFJKOMC MKCPNDCEKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private JFLGOAFOOPF ICKCCEJHFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NHKMGBEMBND PIKFDLICNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool MPIGJMIBKAF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool HLDBKNNLOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x68C4AD0", Offset = "0x68C3AD0", VA = "0x1868C4AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool JJPNEJDINPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x68C4170", Offset = "0x68C3170", VA = "0x1868C4170")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x68C42B0", Offset = "0x68C32B0", VA = "0x1868C42B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x68C6150", Offset = "0x68C5150", VA = "0x1868C6150")]
	public void LFNNOPDGNGK(AIDMCINNKEE HADKCEDAMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x68C55E0", Offset = "0x68C45E0", VA = "0x1868C55E0")]
	public LKBFGJGBJEC KAOFPJDPEJC(bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x68C34F0", Offset = "0x68C24F0", VA = "0x1868C34F0")]
	public LKBFGJGBJEC BCHDNKHIABG(HashSet<Guid> OKLICKEMEHJ, bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x68C3F60", Offset = "0x68C2F60", VA = "0x1868C3F60")]
	public void BOGAHIEHKEH(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x68C60B0", Offset = "0x68C50B0", VA = "0x1868C60B0")]
	public void LCKLBANBHHC(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68C61C0", Offset = "0x68C51C0", VA = "0x1868C61C0")]
	public void LOODKDCCEJJ(LKBFGJGBJEC MKCPNDCEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x68C5B60", Offset = "0x68C4B60", VA = "0x1868C5B60")]
	private void KGJAOPDBBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x68C4B20", Offset = "0x68C3B20", VA = "0x1868C4B20")]
	private MBHEBJKPDFI HNECLMBGANH(BCEDMMKPEML OHDOOCGHDGN, bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x68C4880", Offset = "0x68C3880", VA = "0x1868C4880")]
	private static void EOGAGIPDAEB(BCEDMMKPEML OHDOOCGHDGN, bool BNLEDKHOCDP, MBHEBJKPDFI CBKMIAOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x68C4D50", Offset = "0x68C3D50", VA = "0x1868C4D50")]
	private void ILGKIGMMKII(BCEDMMKPEML OHDOOCGHDGN, bool BNLEDKHOCDP, MBHEBJKPDFI CBKMIAOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x68C4560", Offset = "0x68C3560", VA = "0x1868C4560")]
	private MBHEBJKPDFI EBPHBJAMHHA(BCEDMMKPEML HCKBIMBKNCN, HashSet<Guid> OKLICKEMEHJ, bool BNLEDKHOCDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68C42D0", Offset = "0x68C32D0", VA = "0x1868C42D0")]
	private bool EBCLEHHFFEB(LKBFGJGBJEC HEJHLMLEMMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68C4F70", Offset = "0x68C3F70", VA = "0x1868C4F70")]
	private bool JJJKCCIGHGK(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68C6470", Offset = "0x68C5470", VA = "0x1868C6470")]
	private bool NFPPPIGFKCB(LKBFGJGBJEC MKCPNDCEKPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x68C4190", Offset = "0x68C3190", VA = "0x1868C4190")]
	private static bool CPJEOPIKDAN(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x68C45F0", Offset = "0x68C35F0", VA = "0x1868C45F0")]
	public static bool EHPFHFIBOOI(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x68C5D50", Offset = "0x68C4D50", VA = "0x1868C5D50")]
	private HLIBDGEMJOE KLBCMAIACLF(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x68C3FF0", Offset = "0x68C2FF0", VA = "0x1868C3FF0")]
	private HLIBDGEMJOE BPDCLBLEDEI(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x68C62E0", Offset = "0x68C52E0", VA = "0x1868C62E0")]
	private HLIBDGEMJOE NFMGEKOHGPC(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x68BE770", Offset = "0x68BD770", VA = "0x1868BE770")]
	private static Guid AKBFKKGLFJM(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x68C61F0", Offset = "0x68C51F0", VA = "0x1868C61F0")]
	private string MMKOEHEFJNF(MBHEBJKPDFI CBKMIAOMAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x68C3DE0", Offset = "0x68C2DE0", VA = "0x1868C3DE0")]
	private bool BLINJKMKJIB(BCEDMMKPEML OHDOOCGHDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x68C3B80", Offset = "0x68C2B80", VA = "0x1868C3B80")]
	private static void BINPKIEOEJO(BCEDMMKPEML HCKBIMBKNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public NOBHFPGEPPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct GHOBOBEDOJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public HLIBDGEMJOE CDKDCIHMCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HLIBDGEMJOE EMOKCJBMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int JJFODKANDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int BNDJBIDIMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 GAAAAMHHMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion IFNIIKLFIFC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public JOCKAABMCMC HKOJIHOOGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x68B4E10", Offset = "0x68B3E10", VA = "0x1868B4E10")]
		get
		{
			return default(JOCKAABMCMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public JOCKAABMCMC GPNINAAEGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x68B4EB0", Offset = "0x68B3EB0", VA = "0x1868B4EB0")]
		get
		{
			return default(JOCKAABMCMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x68B4EE0", Offset = "0x68B3EE0", VA = "0x1868B4EE0")]
	public GHOBOBEDOJF(HLIBDGEMJOE CDKDCIHMCOB, HLIBDGEMJOE EMOKCJBMKOL, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface NILCLFJKOMC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IMJAFGNHIKA KILMHGFMJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFNNOPDGNGK(PJMFMNBEBBK HADKCEDAMNP);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OBLAPDCEACC([In] GHOBOBEDOJF AHGAPHMJDIB, bool LMMOCDOLNCH = true);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool INMODOFAAAJ(HLIBDGEMJOE BGHIPCLOGCD);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CGGLALLHJJF(HLIBDGEMJOE OMMNHDEIHNG, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GDKJBHLFHAL(HLIBDGEMJOE KLJLPOGDLBO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JJJFJJCIHEP();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ADAJCPEDKAP(Func<HLIBDGEMJOE, bool> FFEGCKOJGKG);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LDIFAOBPPGJ(HLIBDGEMJOE JIMFJKNHNFO, HashSet<HLIBDGEMJOE> ALMOMDBGINP);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<HLIBDGEMJOE> CPOEEHONKDK();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AJGKDLGPHAH(HLIBDGEMJOE JIMFJKNHNFO, [Out] JOCKAABMCMC BLODLAPNEIL);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KIHDGHMCPKG(MADFLPEOINA IPCEAEAAIHH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool MADFLPEOINA(IMJAFGNHIKA OHDOOCGHDGN);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface IMJAFGNHIKA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HLIBDGEMJOE IADAJODECFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IMJAFGNHIKA EOBHJDGKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JOCKAABMCMC NNANANAHMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool JJCFMHKLANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IOMHLCCOOLE : LPELPLOFIFI.JJMGFFDJBPG
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEDHOPCKIAC(HLIBDGEMJOE KEDJKAHDNCH, JOCKAABMCMC CDKDCIHMCOB);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBIFMAJOGOB(HLIBDGEMJOE KEDJKAHDNCH, JOCKAABMCMC CDKDCIHMCOB);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFPKOGEMAAP(HLIBDGEMJOE KEDJKAHDNCH, JOCKAABMCMC CDKDCIHMCOB);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANMBDEFFCII(HLIBDGEMJOE KEDJKAHDNCH, JOCKAABMCMC CDKDCIHMCOB);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IOMHLCCOOLE Instantiate(Transform DBCCBLKNBHK);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CANECBKHGDE();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface MEHDODPIIEP
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFNNOPDGNGK(Transform DBCCBLKNBHK, IOMHLCCOOLE EBCLNLJEICG);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IOMHLCCOOLE IGNFHKJJDGG();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEICAPBBGBI(IOMHLCCOOLE OANBIKPBANA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CCCMIJOFMKK : FIBGHMOFPMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNNBOBCFPEE(Guid OFMJIJCFKGI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface JFLGOAFOOPF
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFEBEPPGBLE(IMJAFGNHIKA CLBBJKBIFPG);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFNNOPDGNGK(NILCLFJKOMC MKCPNDCEKPI, MEHDODPIIEP CJHNHLONNDD);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFIEGJJGALD();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OIFMMCFGFMN(IMJAFGNHIKA OIBIBELOGPH);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JAGDEEDGEHA(IMJAFGNHIKA NLPCOABBIDF);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MPOLKAFEDFN();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class BCEDMMKPEML : IMJAFGNHIKA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HEKLPBODIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public JOCKAABMCMC nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public BCEDMMKPEML foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public HEKLPBODIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x68B4F50", Offset = "0x68B3F50", VA = "0x1868B4F50")]
		internal bool FNLOCIDFMPB(IMJAFGNHIKA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private JOCKAABMCMC BLODLAPNEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<BCEDMMKPEML> NMONFNJHMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private BCEDMMKPEML KOECBIADNPI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JOCKAABMCMC NNANANAHMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3908320", Offset = "0x3907320", VA = "0x183908320", Slot = "6")]
		get
		{
			return default(JOCKAABMCMC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x68B3A70", Offset = "0x68B2A70", VA = "0x1868B3A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private BCEDMMKPEML EMOKCJBMKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x68B3AA0", Offset = "0x68B2AA0", VA = "0x1868B3AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IMJAFGNHIKA EOBHJDGKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HLIBDGEMJOE IADAJODECFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JJCFMHKLANA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x68B3DA0", Offset = "0x68B2DA0", VA = "0x1868B3DA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IJADIGOABMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x68B35C0", Offset = "0x68B25C0", VA = "0x1868B35C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected BCEDMMKPEML JMCFDCHCIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x68B3DB0", Offset = "0x68B2DB0", VA = "0x1868B3DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x68B4070", Offset = "0x68B3070", VA = "0x1868B4070")]
	public BCEDMMKPEML(JOCKAABMCMC DLLGMMMPECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x68B3DD0", Offset = "0x68B2DD0", VA = "0x1868B3DD0")]
	public BCEDMMKPEML MOFEODPEIPI(JOCKAABMCMC CCOBCNEOJGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x68B3710", Offset = "0x68B2710", VA = "0x1868B3710")]
	public BCEDMMKPEML FCDKDDEKGCK(JOCKAABMCMC DDNLGPLFAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x68B3890", Offset = "0x68B2890", VA = "0x1868B3890")]
	public BCEDMMKPEML FFDBNDOHLIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x68B3F20", Offset = "0x68B2F20", VA = "0x1868B3F20")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x68B3B80", Offset = "0x68B2B80", VA = "0x1868B3B80")]
	public BCEDMMKPEML FNINLEJHNLC(JOCKAABMCMC MECDJMBEHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x68B3C40", Offset = "0x68B2C40", VA = "0x1868B3C40")]
	private static void KIHDGHMCPKG(BCEDMMKPEML NEEHAMCIDNM, MADFLPEOINA IEHHLNFCIFN, bool ACMIKDADOLA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x68B3C30", Offset = "0x68B2C30", VA = "0x1868B3C30", Slot = "9")]
	public void KIHDGHMCPKG(MADFLPEOINA IPCEAEAAIHH, bool OKCIACNFKBA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x68B3610", Offset = "0x68B2610", VA = "0x1868B3610")]
	public static BCEDMMKPEML CHKGOBOMFCE(BCEDMMKPEML NEEHAMCIDNM, JOCKAABMCMC CALKKHOPHPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface NHKMGBEMBND
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool HLDBKNNLOND
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DAEPGHIJCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<FOGBAACKIFG> IGILLMDJNFH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<FOGBAACKIFG> GHFLOCOECKD;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(AIDMCINNKEE HADKCEDAMNP);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(HLIBDGEMJOE OMMNHDEIHNG, HLIBDGEMJOE FEAEJHMDDMM, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(HLIBDGEMJOE KLJLPOGDLBO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(LKBFGJGBJEC NKKKLIGLOFJ, [Optional] FOGBAACKIFG KHKLKJIGHDE);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, NHKMGBEMBND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private AIDMCINNKEE HADKCEDAMNP;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool HLDBKNNLOND
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x68BE3D0", Offset = "0x68BD3D0", VA = "0x1868BE3D0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool DAEPGHIJCAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x68BE430", Offset = "0x68BD430", VA = "0x1868BE430", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<FOGBAACKIFG> IGILLMDJNFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x68BE320", Offset = "0x68BD320", VA = "0x1868BE320", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x68BE520", Offset = "0x68BD520", VA = "0x1868BE520", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<FOGBAACKIFG> GHFLOCOECKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x68BE270", Offset = "0x68BD270", VA = "0x1868BE270", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x68BE470", Offset = "0x68BD470", VA = "0x1868BE470", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x851620", Offset = "0x850620", VA = "0x180851620", Slot = "19")]
		public void SetManager(AIDMCINNKEE HADKCEDAMNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x68BE240", Offset = "0x68BD240", VA = "0x1868BE240")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x68BCFC0", Offset = "0x68BBFC0", VA = "0x1868BCFC0", Slot = "23")]
		public void RequestMasterConnectNodes(HLIBDGEMJOE CFCGKFPLMDN, int JJFODKANDBC, HLIBDGEMJOE KEDJKAHDNCH, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x68BD0F0", Offset = "0x68BC0F0", VA = "0x1868BD0F0", Slot = "24")]
		public void RequestMasterDisconnectNode(HLIBDGEMJOE BGHIPCLOGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x68BD1B0", Offset = "0x68BC1B0", VA = "0x1868BD1B0", Slot = "20")]
		public void RequestMasterModifyNode(HLIBDGEMJOE OMMNHDEIHNG, HLIBDGEMJOE FEAEJHMDDMM, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x68BD2E0", Offset = "0x68BC2E0", VA = "0x1868BD2E0", Slot = "21")]
		public void RequestMasterReparentNodes(HLIBDGEMJOE KLJLPOGDLBO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x68BD410", Offset = "0x68BC410", VA = "0x1868BD410", Slot = "25")]
		public void RequestMasterReparentToRoot(HLIBDGEMJOE KLJLPOGDLBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x68BCE90", Offset = "0x68BBE90", VA = "0x1868BCE90", Slot = "22")]
		public void RequestDeserializeConnectableGraph(LKBFGJGBJEC NKKKLIGLOFJ, [Optional] FOGBAACKIFG KHKLKJIGHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x68BD7F0", Offset = "0x68BC7F0", VA = "0x1868BD7F0")]
		[CFKFFGFIFJN]
		private void RpcMasterConnectNodes(HLIBDGEMJOE CFCGKFPLMDN, int JJFODKANDBC, HLIBDGEMJOE KEDJKAHDNCH, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x68BDAB0", Offset = "0x68BCAB0", VA = "0x1868BDAB0")]
		[CFKFFGFIFJN]
		private void RpcMasterDisconnectNode(HLIBDGEMJOE BGHIPCLOGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x68BDDF0", Offset = "0x68BCDF0", VA = "0x1868BDDF0")]
		[CFKFFGFIFJN]
		private void RpcMasterReparentNodes(HLIBDGEMJOE KLJLPOGDLBO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x68BDBF0", Offset = "0x68BCBF0", VA = "0x1868BDBF0")]
		[CFKFFGFIFJN]
		private void RpcMasterModifyNode(HLIBDGEMJOE OMMNHDEIHNG, HLIBDGEMJOE FEAEJHMDDMM, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x68BD5E0", Offset = "0x68BC5E0", VA = "0x1868BD5E0")]
		[CFKFFGFIFJN]
		private void RpcConnectNodes(HLIBDGEMJOE CFCGKFPLMDN, int JJFODKANDBC, HLIBDGEMJOE KEDJKAHDNCH, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC, JNHJIECEPNH HILKMOJGOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x68BD760", Offset = "0x68BC760", VA = "0x1868BD760")]
		[CFKFFGFIFJN]
		private void RpcDisconnectNode(HLIBDGEMJOE BGHIPCLOGCD, JNHJIECEPNH HILKMOJGOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x68BE140", Offset = "0x68BD140", VA = "0x1868BE140")]
		[CFKFFGFIFJN]
		private void RpcReparentNodes(HLIBDGEMJOE KLJLPOGDLBO, int AKGCBOFANBI, HLIBDGEMJOE MECDJMBEHCP, int JEJHJCLKJMB, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC, JNHJIECEPNH HILKMOJGOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x68BE080", Offset = "0x68BD080", VA = "0x1868BE080")]
		[CFKFFGFIFJN]
		private void RpcModifyNode(HLIBDGEMJOE OMMNHDEIHNG, int JJFODKANDBC, int BNDJBIDIMJM, Vector3 GAAAAMHHMNP, Quaternion IFNIIKLFIFC, JNHJIECEPNH HILKMOJGOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x68BD720", Offset = "0x68BC720", VA = "0x1868BD720")]
		[CFKFFGFIFJN]
		private void RpcDeserializeConnectableGraph(LKBFGJGBJEC MKCPNDCEKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x86E820", Offset = "0x86D820", VA = "0x18086E820")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, IOMHLCCOOLE, LPELPLOFIFI.JJMGFFDJBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x68BC6C0", Offset = "0x68BB6C0", VA = "0x1868BC6C0", Slot = "4")]
		private void EEADEMBGNAI(HLIBDGEMJOE KEDJKAHDNCH, JOCKAABMCMC CDKDCIHMCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x68BC840", Offset = "0x68BB840", VA = "0x1868BC840", Slot = "5")]
		private void HNNBDBCCELO(HLIBDGEMJOE KEDJKAHDNCH, JOCKAABMCMC CDKDCIHMCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x68BCAC0", Offset = "0x68BBAC0", VA = "0x1868BCAC0", Slot = "6")]
		private void JJOCBNFLHCD(HLIBDGEMJOE KEDJKAHDNCH, JOCKAABMCMC CDKDCIHMCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x68BCBD0", Offset = "0x68BBBD0", VA = "0x1868BCBD0", Slot = "7")]
		private void KAFIELEKIAM(HLIBDGEMJOE KEDJKAHDNCH, JOCKAABMCMC CDKDCIHMCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x68BCDC0", Offset = "0x68BBDC0", VA = "0x1868BCDC0", Slot = "8")]
		private IOMHLCCOOLE NLMHGDBOGHA(Transform DBCCBLKNBHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x68BCE30", Offset = "0x68BBE30", VA = "0x1868BCE30", Slot = "9")]
		private void OKDLIFFEMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MNKLCKGGOIO
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8A90", Offset = "0x2CA7A90", VA = "0x182CA8A90")]
	public static FNBDJPPLJGC<T> LIENFNAEGGG<T>(this NDJGECDCBMH MMBLPJPOBHB)
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
