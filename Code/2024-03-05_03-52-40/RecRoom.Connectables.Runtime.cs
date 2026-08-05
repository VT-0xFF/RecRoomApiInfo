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
	public class LogRegistrationIndex : OLOBACIMOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6052550", Offset = "0x6051350", VA = "0x186052550", Slot = "4")]
		public override void GGPDGFKFIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
	public class _AssemblyIndex : HEIIAPOGIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private CACBPJDHPME bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private CACBPJDHPME bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6054060", Offset = "0x6052E60", VA = "0x186054060", Slot = "5")]
		public override void IOHBBJLNCOL(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6053BB0", Offset = "0x60529B0", VA = "0x186053BB0")]
		private void HMJIDFNNBOP(IFDICCAMNBA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6053A40", Offset = "0x6052840", VA = "0x186053A40")]
		private void BPHMHHNNMHA(IFDICCAMNBA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6053D20", Offset = "0x6052B20", VA = "0x186053D20", Slot = "6")]
		public override void HPFNHBNDOAM(IFDICCAMNBA registry, [In] DNHMIHMAKPA filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "8")]
		public override void LGPDKPMBCMB(HAPHBLIKDOL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60540A0", Offset = "0x6052EA0", VA = "0x1860540A0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class JHONLLADPAI : NDHLKGEEMHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class AONBPHMJIBD : IEnumerable<LJMPMPBBAGG>, IEnumerable, IEnumerator<LJMPMPBBAGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LJMPMPBBAGG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private EDLOHAABCGP localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EDLOHAABCGP <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JHONLLADPAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PHAPBKDLMJL <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GFADIHGLLAF.HJKJCEFJNHM <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LJMPMPBBAGG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x815510", Offset = "0x814310", VA = "0x180815510")]
		[DebuggerHidden]
		public AONBPHMJIBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6040D10", Offset = "0x603FB10", VA = "0x186040D10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6040850", Offset = "0x603F650", VA = "0x186040850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6040830", Offset = "0x603F630", VA = "0x186040830")]
		private void FHJCGBCHLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6040CC0", Offset = "0x603FAC0", VA = "0x186040CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6040C10", Offset = "0x603FA10", VA = "0x186040C10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LJMPMPBBAGG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6040C10", Offset = "0x603FA10", VA = "0x186040C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IIFCCHIKGII KOLDIMNADKN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly IIFCCHIKGII ENHNFGNKFEA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly IIFCCHIKGII JHIBFHMCMOC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly IIFCCHIKGII KGHJHFFFCFE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IIFCCHIKGII OCHIDLLICAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MPJMFOACMEE CDGDNFNBPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OEMIHPOHKKB ECOODAPNMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private HKDMEIKNPPL LELHLGPDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PNKJFHPDKAE GKPFGLIAHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LGGJBFLLBEI FLDGGEELLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HBGOLNGPMIE EKLNKMPEPEO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CB220", Offset = "0x7CA020", VA = "0x1807CB220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CAA70", Offset = "0x7C9870", VA = "0x1807CAA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<LJMPMPBBAGG, LJMPMPBBAGG> ICHLEJPDHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6045110", Offset = "0x6043F10", VA = "0x186045110", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60487A0", Offset = "0x60475A0", VA = "0x1860487A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<LJMPMPBBAGG, LJMPMPBBAGG> EHCJJLMAEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6047F60", Offset = "0x6046D60", VA = "0x186047F60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6048850", Offset = "0x6047650", VA = "0x186048850", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<LJMPMPBBAGG, LJMPMPBBAGG, LJMPMPBBAGG> NEGOAFJKFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6048900", Offset = "0x6047700", VA = "0x186048900", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60471C0", Offset = "0x6045FC0", VA = "0x1860471C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6049810", Offset = "0x6048610", VA = "0x186049810")]
	public JHONLLADPAI(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6048310", Offset = "0x6047110", VA = "0x186048310", Slot = "11")]
	public void KCJBJGBIMAI(GameObject EAPMMKKAJGJ, JCEBIJFPNIE JMLONEDCPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6046020", Offset = "0x6044E20", VA = "0x186046020", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6048C50", Offset = "0x6047A50", VA = "0x186048C50", Slot = "21")]
	public bool NOMKPOFIMKD(DECFJFAAKIE IMFOFMLKKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6049490", Offset = "0x6048290", VA = "0x186049490")]
	private void PCLFHMOBOMP(EDLOHAABCGP OABGIKDFIOB, EDLOHAABCGP JAMKKDDFBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6047550", Offset = "0x6046350", VA = "0x186047550")]
	private void IAIHJCNEMDO(EDLOHAABCGP OABGIKDFIOB, EDLOHAABCGP OFDICKMDNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6047270", Offset = "0x6046070", VA = "0x186047270")]
	private void HAOBIKLBNFD(EDLOHAABCGP OABGIKDFIOB, EDLOHAABCGP OFDICKMDNOK, EDLOHAABCGP JAMKKDDFBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6045B90", Offset = "0x6044990", VA = "0x186045B90")]
	private void DPFNOGGGAPJ(EDLOHAABCGP OABGIKDFIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "12")]
	public void LAGHJNJIPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6046B40", Offset = "0x6045940", VA = "0x186046B40", Slot = "13")]
	public void GGPDGFKFIKF(LJMPMPBBAGG NCAANLDCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "14")]
	public void AHELJNGPOGN(LJMPMPBBAGG NCAANLDCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60489B0", Offset = "0x60477B0", VA = "0x1860489B0", Slot = "16")]
	public void NMIPICPPLOD(LJMPMPBBAGG NCAANLDCONA, LJMPMPBBAGG OCKDKJMCDOK, Vector3 ABJLHEFAGHP, Quaternion NGMKKHFPKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6048B10", Offset = "0x6047910", VA = "0x186048B10")]
	public void NMIPICPPLOD(EDLOHAABCGP ENAIIHBGJMJ, EDLOHAABCGP OCKDKJMCDOK, Vector3 ABJLHEFAGHP, Quaternion NGMKKHFPKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6046E50", Offset = "0x6045C50", VA = "0x186046E50")]
	public void GNDGBCFLAEP(LJMPMPBBAGG NCAANLDCONA, float LHLKKEFCLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6047070", Offset = "0x6045E70", VA = "0x186047070", Slot = "17")]
	public void GNIMKMILMLA(LJMPMPBBAGG ALNHAOGLLME, int PHDIGFHPMOM, LJMPMPBBAGG BAIGNHJIMCG, int CEOMDHLPALE, Vector3 ABJLHEFAGHP, Quaternion NGMKKHFPKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6047770", Offset = "0x6046570", VA = "0x186047770")]
	private float IHIGDCBDGDC(EDLOHAABCGP ENAIIHBGJMJ, EDLOHAABCGP FEOGIMKDFKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6046EE0", Offset = "0x6045CE0", VA = "0x186046EE0")]
	public void GNIMKMILMLA(EDLOHAABCGP ENAIIHBGJMJ, EDLOHAABCGP FEOGIMKDFKL, Vector3 ABJLHEFAGHP, Quaternion NGMKKHFPKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6047010", Offset = "0x6045E10", VA = "0x186047010")]
	public void GNIMKMILMLA(EDLOHAABCGP ENAIIHBGJMJ, EDLOHAABCGP FEOGIMKDFKL, Vector3 ABJLHEFAGHP, Quaternion NGMKKHFPKEG, float LHLKKEFCLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6049320", Offset = "0x6048120", VA = "0x186049320", Slot = "18")]
	public void PCIGILHILFC(LJMPMPBBAGG NCAANLDCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6047B40", Offset = "0x6046940", VA = "0x186047B40")]
	public bool JBMFHAPAKCP(EDLOHAABCGP JNDMOGCGEKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6048010", Offset = "0x6046E10", VA = "0x186048010", Slot = "15")]
	public void JJBLIEJLPJC(LJMPMPBBAGG NCAANLDCONA, HashSet<LJMPMPBBAGG> PIIKGGMACPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "19")]
	public NNLNEGLAHPL GBOJPGJLKHO(bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "20")]
	public NNLNEGLAHPL JBNCDNGBHGO(HashSet<Guid> APPLMFJHCIM, bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60451C0", Offset = "0x6043FC0", VA = "0x1860451C0", Slot = "22")]
	public void AKMJOBHIKCJ(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60452A0", Offset = "0x60440A0", VA = "0x1860452A0", Slot = "23")]
	public void APBCAOMJHKN(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6045310", Offset = "0x6044110", VA = "0x186045310", Slot = "24")]
	public void CDJPHFKDAJA(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60467E0", Offset = "0x60455E0", VA = "0x1860467E0")]
	private void EMKHELGBKMC(EDLOHAABCGP ENAIIHBGJMJ, EDLOHAABCGP FEOGIMKDFKL, Vector3 ABJLHEFAGHP, Quaternion NGMKKHFPKEG, float LHLKKEFCLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60454A0", Offset = "0x60442A0", VA = "0x1860454A0")]
	private void CHJGOEPMAKN(EDLOHAABCGP ENAIIHBGJMJ, EDLOHAABCGP EIECDKIPGGN, Vector3 ABJLHEFAGHP, Quaternion NGMKKHFPKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6045230", Offset = "0x6044030", VA = "0x186045230")]
	private void AOEJDPJBECK(EDLOHAABCGP ENAIIHBGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6048710", Offset = "0x6047510", VA = "0x186048710")]
	[IteratorStateMachine(typeof(AONBPHMJIBD))]
	public IEnumerable<LJMPMPBBAGG> KNCPCPAAANK(EDLOHAABCGP JNDMOGCGEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6048C60", Offset = "0x6047A60", VA = "0x186048C60")]
	internal LJMPMPBBAGG ODHKNNGKOHJ(EDLOHAABCGP JNDMOGCGEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60490E0", Offset = "0x6047EE0", VA = "0x1860490E0")]
	internal EDLOHAABCGP OFKNBKICKDH(LJMPMPBBAGG NCAANLDCONA)
	{
		return default(EDLOHAABCGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6046210", Offset = "0x6045010", VA = "0x186046210")]
	private bool ECPHKICIAJJ(DECFJFAAKIE IMFOFMLKKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60491B0", Offset = "0x6047FB0", VA = "0x1860491B0")]
	private bool OHDBLOJIHLC(DECFJFAAKIE IMFOFMLKKCI, [Out] LJMPMPBBAGG FEOGIMKDFKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6048DA0", Offset = "0x6047BA0", VA = "0x186048DA0")]
	private LJMPMPBBAGG ODHKNNGKOHJ(DECFJFAAKIE IMFOFMLKKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6047820", Offset = "0x6046620", VA = "0x186047820")]
	private LJMPMPBBAGG IIPAGNAODEC(DECFJFAAKIE IMFOFMLKKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6045330", Offset = "0x6044130", VA = "0x186045330")]
	private LJMPMPBBAGG CHACLFFCEAP(DECFJFAAKIE IMFOFMLKKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x603F6B0", Offset = "0x603E4B0", VA = "0x18603F6B0")]
	private static Guid JHJMIELGIIM(DECFJFAAKIE IMFOFMLKKCI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6048220", Offset = "0x6047020", VA = "0x186048220")]
	private string KCDKKEIGKEJ(DECFJFAAKIE IMFOFMLKKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6048580", Offset = "0x6047380", VA = "0x186048580")]
	private void KGINELFIKGJ(LJMPMPBBAGG ENAIIHBGJMJ, LJMPMPBBAGG EIECDKIPGGN, RigidTransform FOOAJIBMKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60479B0", Offset = "0x60467B0", VA = "0x1860479B0")]
	private void IPLKJHMIKPE(LJMPMPBBAGG EIECDKIPGGN, LJMPMPBBAGG ENAIIHBGJMJ, RigidTransform FOOAJIBMKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60474F0", Offset = "0x60462F0", VA = "0x1860474F0")]
	private void HHJAKEKKLGO(LJMPMPBBAGG IEFGCLIDDAI, LJMPMPBBAGG ENAIIHBGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6047DD0", Offset = "0x6046BD0", VA = "0x186047DD0")]
	private void JGAJCGIGECK(LJMPMPBBAGG ENAIIHBGJMJ, LJMPMPBBAGG FEOGIMKDFKL, RigidTransform FOOAJIBMKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6049210", Offset = "0x6048010", VA = "0x186049210")]
	private void PAIPBMDLHCM(EDLOHAABCGP JNDMOGCGEKD, LJMPMPBBAGG NCAANLDCONA, EDLOHAABCGP OFDICKMDNOK, EDLOHAABCGP JAMKKDDFBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60458B0", Offset = "0x60446B0", VA = "0x1860458B0")]
	private void DENCJKBMKAN(EDLOHAABCGP JNDMOGCGEKD, LJMPMPBBAGG NCAANLDCONA, LJMPMPBBAGG BAAIEPDCCEI, LJMPMPBBAGG CENKKDIGFIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AJPCOHEKKIM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class HFHJFJDPKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CMADEFPIMOE container;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public HFHJFJDPKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6044C40", Offset = "0x6043A40", VA = "0x186044C40")]
		internal JHONLLADPAI OLNKKGEFKNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6040060", Offset = "0x603EE60", VA = "0x186040060")]
	public static void HOGEILJOGML(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60401E0", Offset = "0x603EFE0", VA = "0x1860401E0")]
	public static void MOBAIANFALF(CMADEFPIMOE LANMIEEPANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class EIPBDJMKOJO : KPLNEEGFABA, BDEHKAOHDJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx DLFJFELKBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly JHONLLADPAI GIAFMJDLOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly EHALKDFEBAK MIKOGIFMPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly LKJLMLCOHKP GKPFGLIAHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HDALCBPCPIF[] DHHJCBGEEFA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(EDLOHAABCGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LJMPMPBBAGG EMBKIPKIHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6043B30", Offset = "0x6042930", VA = "0x186043B30", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LJMPMPBBAGG FFCJEADHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6042CA0", Offset = "0x6041AA0", VA = "0x186042CA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 BMKBLEACNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6042C40", Offset = "0x6041A40", VA = "0x186042C40", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion HJNFACCBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60428E0", Offset = "0x60416E0", VA = "0x1860428E0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool OCGPHGDJLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6042330", Offset = "0x6041130", VA = "0x186042330", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<LJMPMPBBAGG> IDGHMAMGBLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60424A0", Offset = "0x60412A0", VA = "0x1860424A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool JOLHJOHPJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x862FA0", Offset = "0x861DA0", VA = "0x180862FA0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8630C0", Offset = "0x861EC0", VA = "0x1808630C0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6043D40", Offset = "0x6042B40", VA = "0x186043D40", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject EFKMFEFIIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x22359E0", Offset = "0x22347E0", VA = "0x1822359E0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string PAHJIBDDKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6043A60", Offset = "0x6042860", VA = "0x186043A60", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid CMFHMFALKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6043B90", Offset = "0x6042990", VA = "0x186043B90", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AAPCBBOFAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6043C70", Offset = "0x6042A70", VA = "0x186043C70", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KBEGLFMPCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool NLGFNKEGLDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6043530", Offset = "0x6042330", VA = "0x186043530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MJLMGOEGBLN MCHKEKPPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60437E0", Offset = "0x60425E0", VA = "0x1860437E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6042AC0", Offset = "0x60418C0", VA = "0x186042AC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MJLMGOEGBLN LILHMAKOLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60423A0", Offset = "0x60411A0", VA = "0x1860423A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6043780", Offset = "0x6042580", VA = "0x186043780", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MJLMGOEGBLN CIHJIFOAHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6042990", Offset = "0x6041790", VA = "0x186042990", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6043840", Offset = "0x6042640", VA = "0x186043840", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event ABNMGLHJLNH PKKGECMLKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60438A0", Offset = "0x60426A0", VA = "0x1860438A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6042290", Offset = "0x6041090", VA = "0x186042290", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6043960", Offset = "0x6042760", VA = "0x186043960")]
	public EIPBDJMKOJO(EDLOHAABCGP PDDIPEOJCBN, RigidbodyEx DLFJFELKBNN, EHALKDFEBAK MIKOGIFMPFO, HDALCBPCPIF[] DHHJCBGEEFA, LKJLMLCOHKP GKPFGLIAHLN, NDHLKGEEMHL GIAFMJDLOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6042F10", Offset = "0x6041D10", VA = "0x186042F10", Slot = "19")]
	public void HFJKDHNFJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "21")]
	public void JACICAPLDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EE61D0", Offset = "0x5EE4FD0", VA = "0x185EE61D0", Slot = "22")]
	public void CLOGACNJMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6042BF0", Offset = "0x60419F0", VA = "0x186042BF0", Slot = "20")]
	public void FPLLGBFFFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6042080", Offset = "0x6040E80", VA = "0x186042080", Slot = "25")]
	public void AOAJLNPCNEB(int HGIFDFGOCIH, LJMPMPBBAGG BAIGNHJIMCG, int GJBAJEMFBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6042B20", Offset = "0x6041920", VA = "0x186042B20", Slot = "26")]
	public void FBEJHADBCPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6043250", Offset = "0x6042050", VA = "0x186043250", Slot = "27")]
	public void HMHGDHFCFBE(int HGIFDFGOCIH, LJMPMPBBAGG ALNHAOGLLME, int MNODLCPAOAM, [Optional] Vector3? KGNFIDBGNLA, [Optional] Quaternion? BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6042A40", Offset = "0x6041840", VA = "0x186042A40", Slot = "28")]
	public void EPLCNMEEOKM(LJMPMPBBAGG ALNHAOGLLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60424D0", Offset = "0x60412D0", VA = "0x1860424D0", Slot = "31")]
	public void DMGICMPMMPA(Vector3 EFCNFIOBAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6042F40", Offset = "0x6041D40", VA = "0x186042F40", Slot = "29")]
	public void HGEIJPFHOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6043580", Offset = "0x6042380", VA = "0x186043580", Slot = "30")]
	public void IJABKNGNBMK(int OHINPGIGDNE, Vector3 OOEFMBGLDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6042E40", Offset = "0x6041C40", VA = "0x186042E40", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int HGIFDFGOCIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6042D10", Offset = "0x6041B10", VA = "0x186042D10", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int HGIFDFGOCIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8257C0", Offset = "0x8245C0", VA = "0x1808257C0", Slot = "42")]
	public Color GetConnectionSlotColor(int HGIFDFGOCIH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6042400", Offset = "0x6041200", VA = "0x186042400", Slot = "43")]
	public bool CanConnectTo(int HGIFDFGOCIH, LJMPMPBBAGG PHPHOGIMILI, int PPPEHDNHHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "44")]
	public void ParentChanged(int HGIFDFGOCIH, LJMPMPBBAGG MIKBEHHPHFH, int KAFNAHPEFKH, Vector3 OFACMMABLGB, Quaternion DOABEPMFCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "45")]
	public void ChildAdded(int HGIFDFGOCIH, LJMPMPBBAGG ONHJJODNAOJ, int LPIEAPEPPPI, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "46")]
	public void ChildRemoved(int HGIFDFGOCIH, LJMPMPBBAGG BCKLLCKHOPH, int GOHCEFGLHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "47")]
	public void ConnectionModified(int HGIFDFGOCIH, LJMPMPBBAGG BAIGNHJIMCG, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6043940", Offset = "0x6042740", VA = "0x186043940", Slot = "48")]
	public void RootChanged(LJMPMPBBAGG JHKFHKLONIL, LJMPMPBBAGG DADAAJJAIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60429F0", Offset = "0x60417F0", VA = "0x1860429F0", Slot = "23")]
	public void EILIHANFOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6042030", Offset = "0x6040E30", VA = "0x186042030", Slot = "24")]
	public void AFLNEAFEHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6042940", Offset = "0x6041740", VA = "0x186042940")]
	private void EAIKODAOBCN(bool FHCLEKEHLDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BBPMGFLEEOB(typeof(BPKMPCKCHJF), new string[] { })]
public class BKLHDAEGCDN : BPKMPCKCHJF, PKPNKDMNHCJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PEEGPMEJBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public BKLHDAEGCDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public GFADIHGLLAF localIds;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public PEEGPMEJBAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6053770", Offset = "0x6052570", VA = "0x186053770")]
		internal void CDOKNINFBDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly IIFCCHIKGII KOLDIMNADKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[NJFFPBKFAFF]
	private NJEJBINKNCK BKJGLGOEJAD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object HDAHMOJPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6040F30", Offset = "0x603FD30", VA = "0x186040F30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6040D70", Offset = "0x603FB70", VA = "0x186040D70", Slot = "6")]
	public void InitReferences(IMCGAAIAFJE EKLNKMPEPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6040DC0", Offset = "0x603FBC0", VA = "0x186040DC0", Slot = "5")]
	public void JGHHECEFBMO(GFADIHGLLAF HGFILCPIOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public BKLHDAEGCDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BBPMGFLEEOB(typeof(NDHLKGEEMHL), new string[] { "Ignore", "Mock" })]
public class HOJKGMJAALG : NDHLKGEEMHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<LJMPMPBBAGG, LJMPMPBBAGG> ICHLEJPDHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6044CF0", Offset = "0x6043AF0", VA = "0x186044CF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6044F00", Offset = "0x6043D00", VA = "0x186044F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LJMPMPBBAGG, LJMPMPBBAGG> EHCJJLMAEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6044E50", Offset = "0x6043C50", VA = "0x186044E50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6044FB0", Offset = "0x6043DB0", VA = "0x186044FB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<LJMPMPBBAGG, LJMPMPBBAGG, LJMPMPBBAGG> NEGOAFJKFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6045060", Offset = "0x6043E60", VA = "0x186045060", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6044DA0", Offset = "0x6043BA0", VA = "0x186044DA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "11")]
	public void KCJBJGBIMAI(GameObject EAPMMKKAJGJ, JCEBIJFPNIE JMLONEDCPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "12")]
	public void LAGHJNJIPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "13")]
	public void GGPDGFKFIKF(LJMPMPBBAGG NCAANLDCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "14")]
	public void AHELJNGPOGN(LJMPMPBBAGG NCAANLDCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "15")]
	public void JJBLIEJLPJC(LJMPMPBBAGG NCAANLDCONA, HashSet<LJMPMPBBAGG> PIIKGGMACPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "16")]
	public void NMIPICPPLOD(LJMPMPBBAGG NCAANLDCONA, LJMPMPBBAGG OCKDKJMCDOK, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "17")]
	public void GNIMKMILMLA(LJMPMPBBAGG NCAANLDCONA, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "18")]
	public void PCIGILHILFC(LJMPMPBBAGG NCAANLDCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "19")]
	public NNLNEGLAHPL GBOJPGJLKHO(bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "20")]
	public NNLNEGLAHPL JBNCDNGBHGO(HashSet<Guid> APPLMFJHCIM, bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "21")]
	public bool NOMKPOFIMKD(DECFJFAAKIE IMFOFMLKKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "22")]
	public void AKMJOBHIKCJ(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "23")]
	public void APBCAOMJHKN(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "24")]
	public void CDJPHFKDAJA(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HOJKGMJAALG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LJMPMPBBAGG : BDEHKAOHDJL, IEquatable<LJMPMPBBAGG>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BDEHKAOHDJL
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LJMPMPBBAGG EMBKIPKIHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform HJKOCBOHHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GameObject EFKMFEFIIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string PAHJIBDDKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Guid CMFHMFALKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int AAPCBBOFAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	EDLOHAABCGP IJLCCNOBJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool KBEGLFMPCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int HGIFDFGOCIH);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int HGIFDFGOCIH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int HGIFDFGOCIH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int HGIFDFGOCIH, LJMPMPBBAGG PHPHOGIMILI, int DCJCGKBNNLB);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int HGIFDFGOCIH, LJMPMPBBAGG MIKBEHHPHFH, int KAFNAHPEFKH, Vector3 OFACMMABLGB, Quaternion DOABEPMFCLO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int HGIFDFGOCIH, LJMPMPBBAGG ONHJJODNAOJ, int LPIEAPEPPPI, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int HGIFDFGOCIH, LJMPMPBBAGG BCKLLCKHOPH, int GOHCEFGLHND);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int HGIFDFGOCIH, LJMPMPBBAGG BAIGNHJIMCG, int FFPCJEKHJEE, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(LJMPMPBBAGG JHKFHKLONIL, LJMPMPBBAGG DADAAJJAIBE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[MIDGHOOAONL(AOJPFHDMMJA.OMRoom)]
public interface NDHLKGEEMHL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LJMPMPBBAGG, LJMPMPBBAGG> ICHLEJPDHBD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<LJMPMPBBAGG, LJMPMPBBAGG> EHCJJLMAEJB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<LJMPMPBBAGG, LJMPMPBBAGG, LJMPMPBBAGG> NEGOAFJKFBC;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KCJBJGBIMAI(GameObject EAPMMKKAJGJ, JCEBIJFPNIE JMLONEDCPFP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LAGHJNJIPJP();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GGPDGFKFIKF(LJMPMPBBAGG NCAANLDCONA);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AHELJNGPOGN(LJMPMPBBAGG NCAANLDCONA);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JJBLIEJLPJC(LJMPMPBBAGG NCAANLDCONA, HashSet<LJMPMPBBAGG> PIIKGGMACPH);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NMIPICPPLOD(LJMPMPBBAGG NCAANLDCONA, LJMPMPBBAGG OCKDKJMCDOK, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GNIMKMILMLA(LJMPMPBBAGG NCAANLDCONA, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PCIGILHILFC(LJMPMPBBAGG NCAANLDCONA);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NNLNEGLAHPL GBOJPGJLKHO(bool GLBMBDDDDGD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NNLNEGLAHPL JBNCDNGBHGO(HashSet<Guid> APPLMFJHCIM, bool GLBMBDDDDGD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool NOMKPOFIMKD(DECFJFAAKIE IMFOFMLKKCI);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AKMJOBHIKCJ(NNLNEGLAHPL FNHIIKAPEEC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void APBCAOMJHKN(NNLNEGLAHPL FNHIIKAPEEC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CDJPHFKDAJA(NNLNEGLAHPL FNHIIKAPEEC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PNKJFHPDKAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JJHCCHFCGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LJMPMPBBAGG CHACLFFCEAP(int BFKGGHOFFAP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LJMPMPBBAGG IIPAGNAODEC(Guid OFGBAHPLADG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NBMEACMFFKI(LJMPMPBBAGG NCAANLDCONA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MDJNIEPIOMN();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJHEGBMNBFN(LJMPMPBBAGG MIKOGIFMPFO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[MIDGHOOAONL(AOJPFHDMMJA.Application)]
public interface LKJLMLCOHKP
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLGFNKEGLDN(EHALKDFEBAK MIKOGIFMPFO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BIGBLGKFMNJ(EHALKDFEBAK MIKOGIFMPFO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string KOLJOIPCMGJ(EHALKDFEBAK MIKOGIFMPFO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid DCHKGNCFEEG(EHALKDFEBAK MIKOGIFMPFO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CAHBPOHKHHK(EHALKDFEBAK MIKOGIFMPFO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AIGEGFIIOCB(EHALKDFEBAK MIKOGIFMPFO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void MJLMGOEGBLN(LJMPMPBBAGG ALNHAOGLLME, int NIOGDNCGPPB, LJMPMPBBAGG BAIGNHJIMCG, int ILBKKHINCFE, [Optional] Vector3? KGNFIDBGNLA, [Optional] Quaternion? BIBFPHJBNBM);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void ABNMGLHJLNH(LJMPMPBBAGG JHKFHKLONIL, LJMPMPBBAGG DADAAJJAIBE);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EHALKDFEBAK : LJMPMPBBAGG, BDEHKAOHDJL, IEquatable<LJMPMPBBAGG>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KPLNEEGFABA : BDEHKAOHDJL
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	LJMPMPBBAGG FFCJEADHHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IEnumerable<LJMPMPBBAGG> IDGHMAMGBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Vector3 BMKBLEACNAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	Quaternion HJNFACCBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool OCGPHGDJLBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JOLHJOHPJGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event MJLMGOEGBLN MCHKEKPPLKC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event MJLMGOEGBLN LILHMAKOLPE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event MJLMGOEGBLN CIHJIFOAHKM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event ABNMGLHJLNH PKKGECMLKDI;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HFJKDHNFJKM();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FPLLGBFFFEM();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JACICAPLDNF();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CLOGACNJMHE();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EILIHANFOFM();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AFLNEAFEHAP();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AOAJLNPCNEB(int HGIFDFGOCIH, LJMPMPBBAGG BAIGNHJIMCG, int GJBAJEMFBAJ);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FBEJHADBCPI();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void HMHGDHFCFBE(int HGIFDFGOCIH, LJMPMPBBAGG ALNHAOGLLME, int MNODLCPAOAM, [Optional] Vector3? KGNFIDBGNLA, [Optional] Quaternion? BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EPLCNMEEOKM(LJMPMPBBAGG ALNHAOGLLME);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HGEIJPFHOKO();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IJABKNGNBMK(int OHINPGIGDNE, Vector3 OOEFMBGLDAP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DMGICMPMMPA(Vector3 EFCNFIOBAJA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HDALCBPCPIF
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 JIDNHINPGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JCEBIJFPNIE
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool KBHBJNCBGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	DKBDEBMGHOB MPPIABGNLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, JCEBIJFPNIE
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x87B500", Offset = "0x87A300", VA = "0x18087B500", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public DKBDEBMGHOB LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6041150", Offset = "0x603FF50", VA = "0x186041150")]
		public static ConnectableConfigData IOPEJEIIOLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6041200", Offset = "0x6040000", VA = "0x186041200")]
		public ConnectableConfigData(LegacyConnectableLinkVisual DDCEIDHLJKO, bool KPGJIJNHGHD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ANAOHBGGHHB : IEquatable<ANAOHBGGHHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public LJMPMPBBAGG NCAANLDCONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int LNCJCJGMODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int FFPCJEKHJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 KGNFIDBGNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion BIBFPHJBNBM;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x60406A0", Offset = "0x603F4A0", VA = "0x1860406A0")]
	public ANAOHBGGHHB(LJMPMPBBAGG NCAANLDCONA, int LNCJCJGMODJ, int FFPCJEKHJEE, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6040790", Offset = "0x603F590", VA = "0x186040790")]
	public ANAOHBGGHHB(LJMPMPBBAGG NCAANLDCONA, int LNCJCJGMODJ, int FFPCJEKHJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6040700", Offset = "0x603F500", VA = "0x186040700")]
	public ANAOHBGGHHB(LJMPMPBBAGG NCAANLDCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6040230", Offset = "0x603F030", VA = "0x186040230", Slot = "4")]
	public bool Equals(ANAOHBGGHHB EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x60402E0", Offset = "0x603F0E0", VA = "0x1860402E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class CKBHJALHMDM : FKLNKKKGNBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform NBCGMJPEDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private DKBDEBMGHOB JBGDFBFMLJP;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B60FB0", Offset = "0x5B5FDB0", VA = "0x185B60FB0", Slot = "4")]
	public void KCJBJGBIMAI(Transform NBCGMJPEDEM, DKBDEBMGHOB JBGDFBFMLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6041030", Offset = "0x603FE30", VA = "0x186041030", Slot = "5")]
	public DKBDEBMGHOB FKKCJADHLLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6041100", Offset = "0x603FF00", VA = "0x186041100", Slot = "6")]
	public void POMDLNBEKFD(DKBDEBMGHOB PDALOLCIDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public CKBHJALHMDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class LLGIEANECMC : IDisposable, DDCFPBCCNJN
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KGAMNFJNBLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LJMPMPBBAGG oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LJMPMPBBAGG newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public KGAMNFJNBLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6049880", Offset = "0x6048680", VA = "0x186049880")]
		internal bool BGFLMDFLLMD(AMBPHMHCBCO node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly NPOKCECJKMM OMBDCHLIIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private PECDOHDENDC HCBINFIOPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private LEMIIADOECE IIPLAIDLNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool KPGJIJNHGHD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public AMBPHMHCBCO IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x604A810", Offset = "0x6049610", VA = "0x18604A810")]
	public bool IJIOKCPHCBP([In] PKEPIAFMJPK EEDANCJJEPL, bool KAGGILBEIKG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x604E230", Offset = "0x604D030", VA = "0x18604E230")]
	private bool OHBAEOFNOKN([In] PKEPIAFMJPK EEDANCJJEPL, bool KAGGILBEIKG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x604E800", Offset = "0x604D600", VA = "0x18604E800")]
	public LLGIEANECMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x604C5C0", Offset = "0x604B3C0", VA = "0x18604C5C0", Slot = "5")]
	public void KCJBJGBIMAI(NDHLKGEEMHL LIDMLHOMNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6049F70", Offset = "0x6048D70", VA = "0x186049F70", Slot = "17")]
	public void BFHKDEFGIKP(ILEEAKIAIPB NHPEKKMOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x604C5B0", Offset = "0x604B3B0", VA = "0x18604C5B0", Slot = "12")]
	public void KBMFKAJBOAG(Func<LJMPMPBBAGG, bool> NBMMCLLGNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x604C2C0", Offset = "0x604B0C0", VA = "0x18604C2C0")]
	private void KBMFKAJBOAG(NPOKCECJKMM NBFOPMANPGI, Func<LJMPMPBBAGG, bool> NBMMCLLGNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6049FA0", Offset = "0x6048DA0", VA = "0x186049FA0", Slot = "11")]
	public void BMMFBIIMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6049BA0", Offset = "0x60489A0", VA = "0x186049BA0", Slot = "8")]
	public bool AECCEFBIADG(LJMPMPBBAGG ODFHCBNBPGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x604CD00", Offset = "0x604BB00", VA = "0x18604CD00")]
	private bool MAKKJPFCENN(LJMPMPBBAGG MLFFGMDPKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x604A860", Offset = "0x6049660", VA = "0x18604A860")]
	private static bool COHAPNGHGLO(LJMPMPBBAGG MLFFGMDPKHE, NPOKCECJKMM GFOHJHOGBNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x604C910", Offset = "0x604B710", VA = "0x18604C910")]
	private void LCIOIIBHGHO(Transform EPLAMOBDKIL, NPOKCECJKMM KDPDEDHAKNP, NPOKCECJKMM[] FOFAKKEJDHN, LJMPMPBBAGG BNMANBPIPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x604B400", Offset = "0x604A200", VA = "0x18604B400")]
	private ANAOHBGGHHB IBMNPJLFJBC(Transform JIDEOBGIMDJ, ANAOHBGGHHB BDABDNBNAIG)
	{
		return default(ANAOHBGGHHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x604A030", Offset = "0x6048E30", VA = "0x18604A030")]
	private static bool CBONHHFEDDB(NPOKCECJKMM GFOHJHOGBNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x604C840", Offset = "0x604B640", VA = "0x18604C840")]
	private string KOLJOIPCMGJ(LJMPMPBBAGG NCAANLDCONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6049FC0", Offset = "0x6048DC0", VA = "0x186049FC0")]
	private string CAHBPOHKHHK(LJMPMPBBAGG NCAANLDCONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x604A1F0", Offset = "0x6048FF0", VA = "0x18604A1F0")]
	private void CHEGMDJPIBC([In] PKEPIAFMJPK EEDANCJJEPL, bool KFNIFOCCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x604B230", Offset = "0x604A030", VA = "0x18604B230")]
	private void HKJLOGCCBFF(LJMPMPBBAGG ENAIIHBGJMJ, bool KFNIFOCCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x604DC60", Offset = "0x604CA60", VA = "0x18604DC60")]
	private void NHLAJGPHKIN(LJMPMPBBAGG LLMBBAHPPDP, int MNODLCPAOAM, LJMPMPBBAGG EIECDKIPGGN, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM, bool KFNIFOCCFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x604D3D0", Offset = "0x604C1D0", VA = "0x18604D3D0")]
	private void MDEMOKNLBME(LJMPMPBBAGG NKOIABNENPK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM, bool JBDJEDOAEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x604B550", Offset = "0x604A350", VA = "0x18604B550", Slot = "9")]
	public bool IBPIPLDDLHK(LJMPMPBBAGG NKOIABNENPK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x604B630", Offset = "0x604A430", VA = "0x18604B630")]
	private bool ILEKAAIHLFB(LJMPMPBBAGG NKOIABNENPK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x604AE70", Offset = "0x6049C70", VA = "0x18604AE70")]
	private static void GHFDEIKFKMM(LJMPMPBBAGG NKOIABNENPK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM, NPOKCECJKMM FHNLAAFDHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x604C720", Offset = "0x604B520", VA = "0x18604C720")]
	private void KGINELFIKGJ(LJMPMPBBAGG LLMBBAHPPDP, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x604AFF0", Offset = "0x6049DF0", VA = "0x18604AFF0")]
	private void HCMPMKDENAI(NPOKCECJKMM NBFOPMANPGI, LJMPMPBBAGG BAAIEPDCCEI, LJMPMPBBAGG CENKKDIGFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x604B060", Offset = "0x6049E60", VA = "0x18604B060")]
	private void HCMPMKDENAI(LJMPMPBBAGG NCAANLDCONA, LJMPMPBBAGG BAAIEPDCCEI, LJMPMPBBAGG CENKKDIGFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x604AC50", Offset = "0x6049A50", VA = "0x18604AC50")]
	private void DENCJKBMKAN(LJMPMPBBAGG NCAANLDCONA, LJMPMPBBAGG BAAIEPDCCEI, LJMPMPBBAGG CENKKDIGFIL, bool IFCOAJKBDHB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x604AB50", Offset = "0x6049950", VA = "0x18604AB50")]
	private void DENCJKBMKAN(NPOKCECJKMM GOKLEGFJHEB, LJMPMPBBAGG BNMANBPIPHI, LJMPMPBBAGG DADAAJJAIBE, bool IFCOAJKBDHB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x604B860", Offset = "0x604A660", VA = "0x18604B860")]
	private void IPLKJHMIKPE(LJMPMPBBAGG ENAIIHBGJMJ, int MNODLCPAOAM, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x604B0D0", Offset = "0x6049ED0", VA = "0x18604B0D0")]
	private void HHJAKEKKLGO(AMBPHMHCBCO FEOGIMKDFKL, AMBPHMHCBCO GOLKHPINCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x604D9D0", Offset = "0x604C7D0", VA = "0x18604D9D0", Slot = "18")]
	public LJMPMPBBAGG NCIJFKDLHHK(LJMPMPBBAGG NCAANLDCONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x604B980", Offset = "0x604A780", VA = "0x18604B980", Slot = "13")]
	public void JJBLIEJLPJC(LJMPMPBBAGG NCAANLDCONA, HashSet<LJMPMPBBAGG> KJABGOLDOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x604A910", Offset = "0x6049710", VA = "0x18604A910", Slot = "14")]
	public List<LJMPMPBBAGG> DABDLPNIKKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x604C650", Offset = "0x604B450", VA = "0x18604C650")]
	protected AMBPHMHCBCO KDOMKOLADHH(AMBPHMHCBCO NBFOPMANPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x604ACC0", Offset = "0x6049AC0", VA = "0x18604ACC0")]
	protected NPOKCECJKMM[] DNGAFNMMFJG(NPOKCECJKMM GFOHJHOGBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6049E60", Offset = "0x6048C60", VA = "0x186049E60")]
	protected bool AJIBGHLCAOM(LJMPMPBBAGG NCAANLDCONA, [Out] NPOKCECJKMM NBFOPMANPGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x604DB30", Offset = "0x604C930", VA = "0x18604DB30", Slot = "15")]
	public bool NEJLOLEGJFA(LJMPMPBBAGG NCAANLDCONA, [Out] ANAOHBGGHHB ODFKNHLDGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x604AD60", Offset = "0x6049B60", VA = "0x18604AD60")]
	protected NPOKCECJKMM EJANJCEEIKE(ANAOHBGGHHB CBNLGPCDCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6049D70", Offset = "0x6048B70", VA = "0x186049D70", Slot = "10")]
	public bool AGLEMKDKDMJ(LJMPMPBBAGG LLMBBAHPPDP, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x604BD30", Offset = "0x604AB30", VA = "0x18604BD30")]
	private bool JOLIOLOCFJF(LJMPMPBBAGG LLMBBAHPPDP, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x604ADA0", Offset = "0x6049BA0", VA = "0x18604ADA0")]
	private static bool FLJLJKOCODH(NPOKCECJKMM HELGAENJMFF, ANAOHBGGHHB MGJOLFPIGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x604A810", Offset = "0x6049610", VA = "0x18604A810", Slot = "7")]
	private bool CHPFMDOKNIN([In] PKEPIAFMJPK EEDANCJJEPL, bool KAGGILBEIKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class LPMKOGAHFHJ : NDHLKGEEMHL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly CMADEFPIMOE LANMIEEPANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly LEMIIADOECE IIPLAIDLNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly EGCGJMBLPNJ HOJFADCFAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly AIJFECFDFKD MPDKDJKGODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly DDCFPBCCNJN FNHIIKAPEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal KMDOHHHILIP GKPFGLIAHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal BOCOMGIIPGM INOBHLFEOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal PECDOHDENDC PGNJHCBGMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool KPGJIJNHGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool KDDAFLLFANE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool OFMIOIPHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x16DBA10", Offset = "0x16DA810", VA = "0x1816DBA10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x16DBA00", Offset = "0x16DA800", VA = "0x1816DBA00")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KMJOLKOJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x16DBA20", Offset = "0x16DA820", VA = "0x1816DBA20", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x16DBA40", Offset = "0x16DA840", VA = "0x1816DBA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LJMPMPBBAGG, LJMPMPBBAGG> ICHLEJPDHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x604E9D0", Offset = "0x604D7D0", VA = "0x18604E9D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x604F7E0", Offset = "0x604E5E0", VA = "0x18604F7E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LJMPMPBBAGG, LJMPMPBBAGG> EHCJJLMAEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x604EF10", Offset = "0x604DD10", VA = "0x18604EF10", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x604F9E0", Offset = "0x604E7E0", VA = "0x18604F9E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LJMPMPBBAGG, LJMPMPBBAGG, LJMPMPBBAGG> NEGOAFJKFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x604FA40", Offset = "0x604E840", VA = "0x18604FA40", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x604EE90", Offset = "0x604DC90", VA = "0x18604EE90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6050260", Offset = "0x604F060", VA = "0x186050260")]
	public LPMKOGAHFHJ(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x604F100", Offset = "0x604DF00", VA = "0x18604F100", Slot = "11")]
	public void KCJBJGBIMAI(GameObject EAPMMKKAJGJ, JCEBIJFPNIE JMLONEDCPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x604EC70", Offset = "0x604DA70", VA = "0x18604EC70", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x604F840", Offset = "0x604E640", VA = "0x18604F840", Slot = "12")]
	public void LAGHJNJIPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x604ED30", Offset = "0x604DB30", VA = "0x18604ED30", Slot = "13")]
	public void GGPDGFKFIKF(LJMPMPBBAGG NCAANLDCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x604EA30", Offset = "0x604D830", VA = "0x18604EA30", Slot = "14")]
	public void AHELJNGPOGN(LJMPMPBBAGG NCAANLDCONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6048C50", Offset = "0x6047A50", VA = "0x186048C50", Slot = "21")]
	public bool NOMKPOFIMKD(DECFJFAAKIE IMFOFMLKKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x604FCB0", Offset = "0x604EAB0", VA = "0x18604FCB0")]
	internal bool OHBAEOFNOKN([In] PKEPIAFMJPK EEDANCJJEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x604F070", Offset = "0x604DE70", VA = "0x18604F070")]
	internal bool JOLIOLOCFJF([In] PKEPIAFMJPK EEDANCJJEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x604EBD0", Offset = "0x604D9D0", VA = "0x18604EBD0")]
	internal bool BGENAFANEDA([In] PKEPIAFMJPK EEDANCJJEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x604F890", Offset = "0x604E690", VA = "0x18604F890")]
	internal bool LFGHIABGPDH([In] PKEPIAFMJPK EEDANCJJEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6050080", Offset = "0x604EE80", VA = "0x186050080")]
	internal void PPOCJAFDGAF(LJMPMPBBAGG NCAANLDCONA, int MBCMLLEANDG, bool KAGGILBEIKG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x604EA30", Offset = "0x604D830", VA = "0x18604EA30")]
	internal bool EMOJABCFJII(LJMPMPBBAGG JLLDDBCBADI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x604FD70", Offset = "0x604EB70", VA = "0x18604FD70")]
	internal bool OKNPKMBDHKP(LJMPMPBBAGG NKOIABNENPK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x604EF70", Offset = "0x604DD70", VA = "0x18604EF70", Slot = "15")]
	public void JJBLIEJLPJC(LJMPMPBBAGG NCAANLDCONA, HashSet<LJMPMPBBAGG> PIIKGGMACPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x604FAA0", Offset = "0x604E8A0", VA = "0x18604FAA0", Slot = "16")]
	public void NMIPICPPLOD(LJMPMPBBAGG NKOIABNENPK, LJMPMPBBAGG OCKDKJMCDOK, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x604ED50", Offset = "0x604DB50", VA = "0x18604ED50", Slot = "17")]
	public void GNIMKMILMLA(LJMPMPBBAGG LLMBBAHPPDP, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x604FEB0", Offset = "0x604ECB0", VA = "0x18604FEB0", Slot = "18")]
	public void PCIGILHILFC(LJMPMPBBAGG LLMBBAHPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x604F6D0", Offset = "0x604E4D0", VA = "0x18604F6D0")]
	public void KJJGDJBHDDD([Optional] ABCJFLHLGDE BDJMAOCGCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x604EA90", Offset = "0x604D890", VA = "0x18604EA90", Slot = "22")]
	public void AKMJOBHIKCJ(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x604ED10", Offset = "0x604DB10", VA = "0x18604ED10", Slot = "19")]
	public NNLNEGLAHPL GBOJPGJLKHO(bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x604EEF0", Offset = "0x604DCF0", VA = "0x18604EEF0", Slot = "20")]
	public NNLNEGLAHPL JBNCDNGBHGO(HashSet<Guid> APPLMFJHCIM, bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x604EC30", Offset = "0x604DA30", VA = "0x18604EC30", Slot = "24")]
	public void CDJPHFKDAJA(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x604EB20", Offset = "0x604D920", VA = "0x18604EB20", Slot = "23")]
	public void APBCAOMJHKN(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class LEMIIADOECE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly EKPMNGLHMHM<LJMPMPBBAGG, LJMPMPBBAGG> ICHLEJPDHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly EKPMNGLHMHM<LJMPMPBBAGG, LJMPMPBBAGG> EHCJJLMAEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly KJAEILIDEKD<LJMPMPBBAGG, LJMPMPBBAGG, LJMPMPBBAGG> NEGOAFJKFBC;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6049A80", Offset = "0x6048880", VA = "0x186049A80")]
	public LEMIIADOECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	public void KCJBJGBIMAI(LPMKOGAHFHJ LIDMLHOMNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6049A20", Offset = "0x6048820", VA = "0x186049A20")]
	public void PKCKFEOCJAI(LJMPMPBBAGG FEOGIMKDFKL, LJMPMPBBAGG ENAIIHBGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x60499C0", Offset = "0x60487C0", VA = "0x1860499C0")]
	public void FGHMGDPCOFD(LJMPMPBBAGG FEOGIMKDFKL, LJMPMPBBAGG ENAIIHBGJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6049940", Offset = "0x6048740", VA = "0x186049940")]
	public void BFNIGJMJGAJ(LJMPMPBBAGG IEFGCLIDDAI, LJMPMPBBAGG EIECDKIPGGN, LJMPMPBBAGG ENAIIHBGJMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class EGCGJMBLPNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private LPMKOGAHFHJ LIDMLHOMNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private BOCOMGIIPGM INOBHLFEOKH;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EGCGJMBLPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6041D90", Offset = "0x6040B90", VA = "0x186041D90")]
	public void KCJBJGBIMAI(LPMKOGAHFHJ LIDMLHOMNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6041C60", Offset = "0x6040A60", VA = "0x186041C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6041C70", Offset = "0x6040A70", VA = "0x186041C70")]
	private void IFDBFBNIOHJ(ABCJFLHLGDE EOHHOGEBGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6041EC0", Offset = "0x6040CC0", VA = "0x186041EC0")]
	private void NPJPPEOLFFB(ABCJFLHLGDE PFMFDHEOPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6041C90", Offset = "0x6040A90", VA = "0x186041C90")]
	public void INIENCLEBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6041F30", Offset = "0x6040D30", VA = "0x186041F30")]
	public void OMCBHGKKKEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class EKCCCBFGNDO
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OALJPOJOFDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CMADEFPIMOE container;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public OALJPOJOFDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6053700", Offset = "0x6052500", VA = "0x186053700")]
		internal LPMKOGAHFHJ OLNKKGEFKNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6043D60", Offset = "0x6042B60", VA = "0x186043D60")]
	public static void HOGEILJOGML(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6043F60", Offset = "0x6042D60", VA = "0x186043F60")]
	public static void MOBAIANFALF(CMADEFPIMOE LANMIEEPANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class GEIPCCMJNAM : IDisposable, PECDOHDENDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, DKBDEBMGHOB> AJIHDNHIIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly ILEEAKIAIPB GMAJMCJNEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private FKLNKKKGNBO OAMHNBBJJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private DDCFPBCCNJN FNHIIKAPEEC;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6044B60", Offset = "0x6043960", VA = "0x186044B60")]
	public GEIPCCMJNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6044570", Offset = "0x6043370", VA = "0x186044570", Slot = "7")]
	public void KCJBJGBIMAI(DDCFPBCCNJN FNHIIKAPEEC, FKLNKKKGNBO OAMHNBBJJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x60445B0", Offset = "0x60433B0", VA = "0x1860445B0", Slot = "5")]
	public void KODGDBOFFJM(AMBPHMHCBCO LLFPFOHDPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6043FE0", Offset = "0x6042DE0", VA = "0x186043FE0", Slot = "9")]
	public void DAHCEOGIEAH(AMBPHMHCBCO BOFHCBFCCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x60449A0", Offset = "0x60437A0", VA = "0x1860449A0", Slot = "8")]
	public void NPFFJGLNONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6044220", Offset = "0x6043020", VA = "0x186044220", Slot = "10")]
	public void GOMNNMDLEFB(AMBPHMHCBCO MBGMLGGNFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6044150", Offset = "0x6042F50", VA = "0x186044150", Slot = "11")]
	public void GILJDNJOICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x60447F0", Offset = "0x60435F0", VA = "0x1860447F0")]
	private bool LOBGLLEMNLH(AMBPHMHCBCO GJCLFAIOADJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class AIJFECFDFKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct DCLJIIKIPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly NPOKCECJKMM EKJBGAMCMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> APPLMFJHCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly DECFJFAAKIE CPKLBJAHDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly DECFJFAAKIE IKAAFAICMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool GLBMBDDDDGD;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool LAPFONIBACA
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x60416F0", Offset = "0x60404F0", VA = "0x1860416F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6041AC0", Offset = "0x60408C0", VA = "0x186041AC0")]
		public DCLJIIKIPLA(NPOKCECJKMM EKJBGAMCMKE, HashSet<Guid> APPLMFJHCIM, bool GLBMBDDDDGD, [Optional] DECFJFAAKIE CPKLBJAHDOB, [Optional] DECFJFAAKIE IKAAFAICMBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6041250", Offset = "0x6040050", VA = "0x186041250")]
		public DECFJFAAKIE CDDFPMJNNJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6041A00", Offset = "0x6040800", VA = "0x186041A00")]
		private DECFJFAAKIE PJHHKBONCJE([Out] DECFJFAAKIE HDFIOPHCFDA, [Out] DECFJFAAKIE MMAKBIMEHCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6041810", Offset = "0x6040610", VA = "0x186041810")]
		private DECFJFAAKIE JIKFBHAJDLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6041580", Offset = "0x6040380", VA = "0x186041580")]
		private void HGCAPJMKOHA(DECFJFAAKIE BEFCLMBNFOA, DECFJFAAKIE GPOGFKJLNJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x60413C0", Offset = "0x60401C0", VA = "0x1860413C0")]
		private void GAACLMEEJHE(DECFJFAAKIE HDFIOPHCFDA, DECFJFAAKIE MMAKBIMEHCB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private LPMKOGAHFHJ LIDMLHOMNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private DDCFPBCCNJN FNHIIKAPEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PECDOHDENDC HCBINFIOPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private BOCOMGIIPGM INOBHLFEOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool PJGBBJEBPKL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private bool LPLONAKHLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x603F850", Offset = "0x603E650", VA = "0x18603F850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private bool OFMIOIPHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x603F8A0", Offset = "0x603E6A0", VA = "0x18603F8A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x603EBA0", Offset = "0x603D9A0", VA = "0x18603EBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x603F7E0", Offset = "0x603E5E0", VA = "0x18603F7E0")]
	public void KCJBJGBIMAI(LPMKOGAHFHJ LIDMLHOMNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x603E660", Offset = "0x603D460", VA = "0x18603E660")]
	public NNLNEGLAHPL GBOJPGJLKHO(bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x603F070", Offset = "0x603DE70", VA = "0x18603F070")]
	public NNLNEGLAHPL JBNCDNGBHGO(HashSet<Guid> APPLMFJHCIM, bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x603D200", Offset = "0x603C000", VA = "0x18603D200")]
	public void AKMJOBHIKCJ(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x603D290", Offset = "0x603C090", VA = "0x18603D290")]
	public void APBCAOMJHKN(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6040030", Offset = "0x603EE30", VA = "0x186040030")]
	public void OPFHAAMLCDL(NNLNEGLAHPL FNHIIKAPEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x603D330", Offset = "0x603C130", VA = "0x18603D330")]
	private void BFHBGLAOEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x603F8C0", Offset = "0x603E6C0", VA = "0x18603F8C0")]
	private DECFJFAAKIE NNJEINGPFGC(NPOKCECJKMM NBFOPMANPGI, bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x603EE20", Offset = "0x603DC20", VA = "0x18603EE20")]
	private static void HMOLFGAKAPC(NPOKCECJKMM NBFOPMANPGI, bool GLBMBDDDDGD, DECFJFAAKIE IMFOFMLKKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x603DAA0", Offset = "0x603C8A0", VA = "0x18603DAA0")]
	private void DAFAIKEGFJI(NPOKCECJKMM NBFOPMANPGI, bool GLBMBDDDDGD, DECFJFAAKIE IMFOFMLKKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x603E5D0", Offset = "0x603D3D0", VA = "0x18603E5D0")]
	private DECFJFAAKIE FCFKGMPJBDM(NPOKCECJKMM EKJBGAMCMKE, HashSet<Guid> APPLMFJHCIM, bool GLBMBDDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x603D520", Offset = "0x603C320", VA = "0x18603D520")]
	private bool CCADJGAMCCB(NNLNEGLAHPL JKOLIPCLDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x603DF40", Offset = "0x603CD40", VA = "0x18603DF40")]
	private bool ECPHKICIAJJ(DECFJFAAKIE IMFOFMLKKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x603E5B0", Offset = "0x603D3B0", VA = "0x18603E5B0")]
	private bool EEEJOAHEEPF(NNLNEGLAHPL FNHIIKAPEEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x603DE20", Offset = "0x603CC20", VA = "0x18603DE20")]
	private static bool DNLNEIFFMEJ(DECFJFAAKIE IMFOFMLKKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x603FAB0", Offset = "0x603E8B0", VA = "0x18603FAB0")]
	public static bool NOMKPOFIMKD(DECFJFAAKIE IMFOFMLKKCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x603FD00", Offset = "0x603EB00", VA = "0x18603FD00")]
	private LJMPMPBBAGG ODHKNNGKOHJ(DECFJFAAKIE IMFOFMLKKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x603D920", Offset = "0x603C720", VA = "0x18603D920")]
	private LJMPMPBBAGG CHACLFFCEAP(DECFJFAAKIE IMFOFMLKKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x603D7B0", Offset = "0x603C5B0", VA = "0x18603D7B0")]
	private LJMPMPBBAGG CFMHCAKFOHK(DECFJFAAKIE IMFOFMLKKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x603F6B0", Offset = "0x603E4B0", VA = "0x18603F6B0")]
	private static Guid JHJMIELGIIM(DECFJFAAKIE IMFOFMLKKCI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x603F6F0", Offset = "0x603E4F0", VA = "0x18603F6F0")]
	private string KCDKKEIGKEJ(DECFJFAAKIE IMFOFMLKKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x603DCC0", Offset = "0x603CAC0", VA = "0x18603DCC0")]
	private bool DLKIHAKDKLJ(NPOKCECJKMM NBFOPMANPGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x603EBC0", Offset = "0x603D9C0", VA = "0x18603EBC0")]
	private static void GDMJJKFACIB(NPOKCECJKMM EKJBGAMCMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public AIJFECFDFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct PKEPIAFMJPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public LJMPMPBBAGG ENAIIHBGJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public LJMPMPBBAGG FEOGIMKDFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int MNODLCPAOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int GJBAJEMFBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 KGNFIDBGNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion BIBFPHJBNBM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ANAOHBGGHHB LEAOMEKAIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6053860", Offset = "0x6052660", VA = "0x186053860")]
		get
		{
			return default(ANAOHBGGHHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ANAOHBGGHHB BOCEBLFICAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6053900", Offset = "0x6052700", VA = "0x186053900")]
		get
		{
			return default(ANAOHBGGHHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6053930", Offset = "0x6052730", VA = "0x186053930")]
	public PKEPIAFMJPK(LJMPMPBBAGG ENAIIHBGJMJ, LJMPMPBBAGG FEOGIMKDFKL, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface DDCFPBCCNJN
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AMBPHMHCBCO IJIEPIJIKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCJBJGBIMAI(NDHLKGEEMHL LIDMLHOMNDK);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJIOKCPHCBP([In] PKEPIAFMJPK EEDANCJJEPL, bool KAGGILBEIKG = true);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AECCEFBIADG(LJMPMPBBAGG ODFHCBNBPGI);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IBPIPLDDLHK(LJMPMPBBAGG NKOIABNENPK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AGLEMKDKDMJ(LJMPMPBBAGG LLMBBAHPPDP, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BMMFBIIMMCN();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KBMFKAJBOAG(Func<LJMPMPBBAGG, bool> NBMMCLLGNFD);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJBLIEJLPJC(LJMPMPBBAGG NCAANLDCONA, HashSet<LJMPMPBBAGG> KJABGOLDOIM);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<LJMPMPBBAGG> DABDLPNIKKA();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NEJLOLEGJFA(LJMPMPBBAGG NCAANLDCONA, [Out] ANAOHBGGHHB ODFKNHLDGBC);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BFHKDEFGIKP(ILEEAKIAIPB NHPEKKMOHMO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool ILEEAKIAIPB(AMBPHMHCBCO NBFOPMANPGI);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface AMBPHMHCBCO
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LJMPMPBBAGG ELAHEJBPBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	AMBPHMHCBCO GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ANAOHBGGHHB FPBAHJCDEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool DEMPKNFGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DKBDEBMGHOB
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAEOMMPCBHP(LJMPMPBBAGG BAIGNHJIMCG, ANAOHBGGHHB ENAIIHBGJMJ);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOHNHEILFJJ(LJMPMPBBAGG BAIGNHJIMCG, ANAOHBGGHHB ENAIIHBGJMJ);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEOLGBJOBAB(LJMPMPBBAGG BAIGNHJIMCG, ANAOHBGGHHB ENAIIHBGJMJ);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LOKIDJPEEPO(LJMPMPBBAGG BAIGNHJIMCG, ANAOHBGGHHB ENAIIHBGJMJ);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DKBDEBMGHOB Instantiate(Transform NBCGMJPEDEM);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void COJAMHJFIEG();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FKLNKKKGNBO
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCJBJGBIMAI(Transform NBCGMJPEDEM, DKBDEBMGHOB JBGDFBFMLJP);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DKBDEBMGHOB FKKCJADHLLI();

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POMDLNBEKFD(DKBDEBMGHOB PDALOLCIDBM);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KMDOHHHILIP : PNKJFHPDKAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGGIBFBMCKG(Guid JGFCKMNFNCN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PECDOHDENDC
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KODGDBOFFJM(AMBPHMHCBCO LLFPFOHDPFB);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCJBJGBIMAI(DDCFPBCCNJN FNHIIKAPEEC, FKLNKKKGNBO IOJFMMOPLLN);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPFFJGLNONE();

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAHCEOGIEAH(AMBPHMHCBCO BOFHCBFCCLD);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GOMNNMDLEFB(AMBPHMHCBCO MBGMLGGNFIF);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GILJDNJOICH();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class NPOKCECJKMM : AMBPHMHCBCO
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DGMPALHHKPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public ANAOHBGGHHB nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NPOKCECJKMM foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public DGMPALHHKPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6041B30", Offset = "0x6040930", VA = "0x186041B30")]
		internal bool EOAINHGAJEK(AMBPHMHCBCO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private ANAOHBGGHHB ODFKNHLDGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<NPOKCECJKMM> LHMFCJHGBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private NPOKCECJKMM IPJOBJCJPLG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public ANAOHBGGHHB FPBAHJCDEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3303FD0", Offset = "0x3302DD0", VA = "0x183303FD0", Slot = "6")]
		get
		{
			return default(ANAOHBGGHHB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6052EE0", Offset = "0x6051CE0", VA = "0x186052EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private NPOKCECJKMM FEOGIMKDFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB70", Offset = "0x7BD970", VA = "0x1807BEB70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6052C90", Offset = "0x6051A90", VA = "0x186052C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public AMBPHMHCBCO GAHJCNPPPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB70", Offset = "0x7BD970", VA = "0x1807BEB70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public LJMPMPBBAGG ELAHEJBPBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DEMPKNFGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6052C80", Offset = "0x6051A80", VA = "0x186052C80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CMOCMEEOBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x60527E0", Offset = "0x60515E0", VA = "0x1860527E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	protected NPOKCECJKMM GOKLEGFJHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6052EC0", Offset = "0x6051CC0", VA = "0x186052EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6053650", Offset = "0x6052450", VA = "0x186053650")]
	public NPOKCECJKMM(ANAOHBGGHHB ELOJGMMHPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6052D70", Offset = "0x6051B70", VA = "0x186052D70")]
	public NPOKCECJKMM JLFICOCDFDA(ANAOHBGGHHB AEBLJCFMOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6052F10", Offset = "0x6051D10", VA = "0x186052F10")]
	public NPOKCECJKMM NJBMBNBAMLP(ANAOHBGGHHB LIMPBAAEIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6052AA0", Offset = "0x60518A0", VA = "0x186052AA0")]
	public NPOKCECJKMM FIJOKOAGLFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6053450", Offset = "0x6052250", VA = "0x186053450")]
	public void OCIHDBDLDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x60535A0", Offset = "0x60523A0", VA = "0x1860535A0")]
	public NPOKCECJKMM OKHHIOGLFIA(ANAOHBGGHHB EIECDKIPGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6052840", Offset = "0x6051640", VA = "0x186052840")]
	private static void BFHKDEFGIKP(NPOKCECJKMM ACCLDGBFKFP, ILEEAKIAIPB OEAIDDHOELL, bool FBBGJHEDLEB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6052830", Offset = "0x6051630", VA = "0x186052830", Slot = "9")]
	public void BFHKDEFGIKP(ILEEAKIAIPB NHPEKKMOHMO, bool IFCOAJKBDHB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6053090", Offset = "0x6051E90", VA = "0x186053090")]
	public static string NPHNFELPIKB(NPOKCECJKMM ACCLDGBFKFP, int NBANIMBJCEB = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x60529A0", Offset = "0x60517A0", VA = "0x1860529A0")]
	public static NPOKCECJKMM EJANJCEEIKE(NPOKCECJKMM ACCLDGBFKFP, ANAOHBGGHHB HHDMJFLBEKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface BOCOMGIIPGM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool LPLONAKHLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool JJHCCHFCGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<ABCJFLHLGDE> IFDBFBNIOHJ;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<ABCJFLHLGDE> NPJPPEOLFFB;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(LPMKOGAHFHJ LIDMLHOMNDK);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(LJMPMPBBAGG NKOIABNENPK, LJMPMPBBAGG OCKDKJMCDOK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(LJMPMPBBAGG LLMBBAHPPDP, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(NNLNEGLAHPL EPNPJDFKIKE, [Optional] ABCJFLHLGDE BDJMAOCGCEF);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, BOCOMGIIPGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private LPMKOGAHFHJ LIDMLHOMNDK;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool LPLONAKHLLG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6052350", Offset = "0x6051150", VA = "0x186052350", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool JJHCCHFCGPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x60523B0", Offset = "0x60511B0", VA = "0x1860523B0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<ABCJFLHLGDE> IFDBFBNIOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x60522A0", Offset = "0x60510A0", VA = "0x1860522A0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x60524A0", Offset = "0x60512A0", VA = "0x1860524A0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<ABCJFLHLGDE> NPJPPEOLFFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x60521F0", Offset = "0x6050FF0", VA = "0x1860521F0", Slot = "17")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x60523F0", Offset = "0x60511F0", VA = "0x1860523F0", Slot = "18")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BE970", Offset = "0x7BD770", VA = "0x1807BE970", Slot = "21")]
		public void SetManager(LPMKOGAHFHJ LIDMLHOMNDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x60521C0", Offset = "0x6050FC0", VA = "0x1860521C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6050F40", Offset = "0x604FD40", VA = "0x186050F40", Slot = "25")]
		public void RequestMasterConnectNodes(LJMPMPBBAGG ALNHAOGLLME, int MNODLCPAOAM, LJMPMPBBAGG BAIGNHJIMCG, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6051070", Offset = "0x604FE70", VA = "0x186051070", Slot = "26")]
		public void RequestMasterDisconnectNode(LJMPMPBBAGG ODFHCBNBPGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6051130", Offset = "0x604FF30", VA = "0x186051130", Slot = "22")]
		public void RequestMasterModifyNode(LJMPMPBBAGG NKOIABNENPK, LJMPMPBBAGG OCKDKJMCDOK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6051260", Offset = "0x6050060", VA = "0x186051260", Slot = "23")]
		public void RequestMasterReparentNodes(LJMPMPBBAGG LLMBBAHPPDP, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6051390", Offset = "0x6050190", VA = "0x186051390", Slot = "27")]
		public void RequestMasterReparentToRoot(LJMPMPBBAGG LLMBBAHPPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6050E10", Offset = "0x604FC10", VA = "0x186050E10", Slot = "24")]
		public void RequestDeserializeConnectableGraph(NNLNEGLAHPL EPNPJDFKIKE, [Optional] ABCJFLHLGDE BDJMAOCGCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6051770", Offset = "0x6050570", VA = "0x186051770")]
		[NJNHFCEFPAE]
		private void RpcMasterConnectNodes(LJMPMPBBAGG ALNHAOGLLME, int MNODLCPAOAM, LJMPMPBBAGG BAIGNHJIMCG, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6051A30", Offset = "0x6050830", VA = "0x186051A30")]
		[NJNHFCEFPAE]
		private void RpcMasterDisconnectNode(LJMPMPBBAGG ODFHCBNBPGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6051D70", Offset = "0x6050B70", VA = "0x186051D70")]
		[NJNHFCEFPAE]
		private void RpcMasterReparentNodes(LJMPMPBBAGG LLMBBAHPPDP, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6051B70", Offset = "0x6050970", VA = "0x186051B70")]
		[NJNHFCEFPAE]
		private void RpcMasterModifyNode(LJMPMPBBAGG NKOIABNENPK, LJMPMPBBAGG OCKDKJMCDOK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6051560", Offset = "0x6050360", VA = "0x186051560")]
		[NJNHFCEFPAE]
		private void RpcConnectNodes(LJMPMPBBAGG ALNHAOGLLME, int MNODLCPAOAM, LJMPMPBBAGG BAIGNHJIMCG, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM, BAIPJMDPOGP FKFNIEFEFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x60516E0", Offset = "0x60504E0", VA = "0x1860516E0")]
		[NJNHFCEFPAE]
		private void RpcDisconnectNode(LJMPMPBBAGG ODFHCBNBPGI, BAIPJMDPOGP FKFNIEFEFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x60520C0", Offset = "0x6050EC0", VA = "0x1860520C0")]
		[NJNHFCEFPAE]
		private void RpcReparentNodes(LJMPMPBBAGG LLMBBAHPPDP, int FMMLKFJLHDP, LJMPMPBBAGG EIECDKIPGGN, int KAFNAHPEFKH, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM, BAIPJMDPOGP FKFNIEFEFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6052000", Offset = "0x6050E00", VA = "0x186052000")]
		[NJNHFCEFPAE]
		private void RpcModifyNode(LJMPMPBBAGG NKOIABNENPK, int MNODLCPAOAM, int GJBAJEMFBAJ, Vector3 KGNFIDBGNLA, Quaternion BIBFPHJBNBM, BAIPJMDPOGP FKFNIEFEFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x60516A0", Offset = "0x60504A0", VA = "0x1860516A0")]
		[NJNHFCEFPAE]
		private void RpcDeserializeConnectableGraph(NNLNEGLAHPL FNHIIKAPEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7D5E80", Offset = "0x7D4C80", VA = "0x1807D5E80")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, DKBDEBMGHOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x60506C0", Offset = "0x604F4C0", VA = "0x1860506C0", Slot = "4")]
		private void CHOJKCPONJM(LJMPMPBBAGG BAIGNHJIMCG, ANAOHBGGHHB ENAIIHBGJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6050840", Offset = "0x604F640", VA = "0x186050840", Slot = "5")]
		private void CPNKAFNNINL(LJMPMPBBAGG BAIGNHJIMCG, ANAOHBGGHHB ENAIIHBGJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6050D00", Offset = "0x604FB00", VA = "0x186050D00", Slot = "6")]
		private void HBJONNJNHLG(LJMPMPBBAGG BAIGNHJIMCG, ANAOHBGGHHB ENAIIHBGJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6050AB0", Offset = "0x604F8B0", VA = "0x186050AB0", Slot = "7")]
		private void EOGDGPHLIGI(LJMPMPBBAGG BAIGNHJIMCG, ANAOHBGGHHB ENAIIHBGJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6050650", Offset = "0x604F450", VA = "0x186050650", Slot = "8")]
		private DKBDEBMGHOB CFPNMADNIJO(Transform NBCGMJPEDEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6050CA0", Offset = "0x604FAA0", VA = "0x186050CA0", Slot = "9")]
		private void FBNHGMMFGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EANLBMHFKPE
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x25F2780", Offset = "0x25F1580", VA = "0x1825F2780")]
	public static GEDPPPNKOFH<T> HFFBGONIAMB<T>(this CMADEFPIMOE LANMIEEPANH)
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
