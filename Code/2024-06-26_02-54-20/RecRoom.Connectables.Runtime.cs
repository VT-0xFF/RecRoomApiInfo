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
	public class LogRegistrationIndex : DAMGOKPKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6884240", Offset = "0x6882840", VA = "0x186884240", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
	public class _AssemblyIndex : KHGPJHOJOHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private HODLKMJCPDK bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private HODLKMJCPDK bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x688B4D0", Offset = "0x6889AD0", VA = "0x18688B4D0", Slot = "5")]
		public override void GFCMAGCMMPB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x688B020", Offset = "0x6889620", VA = "0x18688B020")]
		private void CIONGDPCBDA(DMJKCLJBHON registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x688B510", Offset = "0x6889B10", VA = "0x18688B510")]
		private void JGOAKBBBDJN(DMJKCLJBHON registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x688B190", Offset = "0x6889790", VA = "0x18688B190", Slot = "6")]
		public override void CKJFBMFKCLI(DMJKCLJBHON registry, [In] MIOEIJGFFCO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "8")]
		public override void LOCAGFNGOIC(ADLFNLPBEEE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x688B680", Offset = "0x6889C80", VA = "0x18688B680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class CGGBBKPOOAN : HPABFBMIFPF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OPOAPBDPFDC : IEnumerable<GMJKJCNNJPE>, IEnumerable, IEnumerator<GMJKJCNNJPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private GMJKJCNNJPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private AAEGPHPJNLD localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AAEGPHPJNLD <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CGGBBKPOOAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KLHDIAOOCPK <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private ANDJNBHCECG.BJEFNDFHHBA <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private GMJKJCNNJPE System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BC660", Offset = "0x8BAC60", VA = "0x1808BC660")]
		[DebuggerHidden]
		public OPOAPBDPFDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x688A180", Offset = "0x6888780", VA = "0x18688A180", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6889CA0", Offset = "0x68882A0", VA = "0x186889CA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x688A060", Offset = "0x6888660", VA = "0x18688A060")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x688A130", Offset = "0x6888730", VA = "0x18688A130", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x688A080", Offset = "0x6888680", VA = "0x18688A080", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GMJKJCNNJPE> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x688A080", Offset = "0x6888680", VA = "0x18688A080", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class FKHCHBCNEPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CGGBBKPOOAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KAIPELELCHG nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FKHCHBCNEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x687CFB0", Offset = "0x687B5B0", VA = "0x18687CFB0")]
		internal object KPBIHBCMKCI(KAIPELELCHG x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DCJACLBEABN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KAIPELELCHG child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public FKHCHBCNEPO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DCJACLBEABN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x687C850", Offset = "0x687AE50", VA = "0x18687C850")]
		internal object PLAOJJNKGCO((KAIPELELCHG child, KAIPELELCHG nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ICJNMGNJFIN PCIEEKIAAIP;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ICJNMGNJFIN JCKDGOJAKJE;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly ICJNMGNJFIN ANLGDAPGLMK;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly ICJNMGNJFIN PDNELFALJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private ILBAJNELFOI GLBOJIKAOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NCJHBDLHOGE FNKICHMEFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private IPBFDMGMDCC PGLONMDBLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HNAKFAGLLOD AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private ALBECIIMDNG HDMOJMNEFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PDBNDHLFMCD PDKMAMNDBJB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x874440", Offset = "0x872A40", VA = "0x180874440", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x873F30", Offset = "0x872530", VA = "0x180873F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JIKMPJAABDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<GMJKJCNNJPE, GMJKJCNNJPE> NGCIBNKHBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6879380", Offset = "0x6877980", VA = "0x186879380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x687A450", Offset = "0x6878A50", VA = "0x18687A450", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<GMJKJCNNJPE, GMJKJCNNJPE> KAPCLDHFBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x687BFC0", Offset = "0x687A5C0", VA = "0x18687BFC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x687A3A0", Offset = "0x68789A0", VA = "0x18687A3A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<GMJKJCNNJPE, GMJKJCNNJPE, GMJKJCNNJPE> BEAKJBJKICC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x687B520", Offset = "0x6879B20", VA = "0x18687B520", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x687AB60", Offset = "0x6879160", VA = "0x18687AB60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x687C6D0", Offset = "0x687ACD0", VA = "0x18687C6D0")]
	public CGGBBKPOOAN(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6878340", Offset = "0x6876940", VA = "0x186878340", Slot = "12")]
	public void BGGINNGCCML(GameObject INALOLPJOHI, MPPHGODNJKL FBGMHPANGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6879190", Offset = "0x6877790", VA = "0x186879190", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x687A710", Offset = "0x6878D10", VA = "0x18687A710", Slot = "22")]
	public bool HPFHCLENHLC(KAIPELELCHG LFGOPFNHKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x687A8F0", Offset = "0x6878EF0", VA = "0x18687A8F0")]
	private void IBCKNHFJEMC(AAEGPHPJNLD LIEAAPAHHKD, AAEGPHPJNLD LINCCJJHGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6879AE0", Offset = "0x68780E0", VA = "0x186879AE0")]
	private void FGLBODLJKGH(AAEGPHPJNLD LIEAAPAHHKD, AAEGPHPJNLD KICOJENABBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6879D00", Offset = "0x6878300", VA = "0x186879D00")]
	private void FIHCBFOJCIG(AAEGPHPJNLD LIEAAPAHHKD, AAEGPHPJNLD KICOJENABBD, AAEGPHPJNLD LINCCJJHGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6879430", Offset = "0x6877A30", VA = "0x186879430")]
	private void EJIDNKNHBNA(AAEGPHPJNLD LIEAAPAHHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "13")]
	public void OMKLHJHPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x687C070", Offset = "0x687A670", VA = "0x18687C070", Slot = "14")]
	public void PIKNDMFIIPK(GMJKJCNNJPE HPEDOOPINDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "15")]
	public void KAAMLDMKLFD(GMJKJCNNJPE HPEDOOPINDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6879980", Offset = "0x6877F80", VA = "0x186879980", Slot = "17")]
	public void EPLHCKJIHLI(GMJKJCNNJPE HPEDOOPINDA, GMJKJCNNJPE OJKMNCEMIPN, Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6879840", Offset = "0x6877E40", VA = "0x186879840")]
	public void EPLHCKJIHLI(AAEGPHPJNLD FLFKBMMIINC, AAEGPHPJNLD OJKMNCEMIPN, Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x687B5D0", Offset = "0x6879BD0", VA = "0x18687B5D0")]
	public void LBPJGALOEJO(GMJKJCNNJPE HPEDOOPINDA, float MMHPMHNOCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x687AF60", Offset = "0x6879560", VA = "0x18687AF60", Slot = "18")]
	public void KDJEFKDDCJG(GMJKJCNNJPE MDHJBKHHBBL, int GHEPGFLIFPA, GMJKJCNNJPE PMKAGILCPKD, int DKMJJABDKHO, Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x687B8E0", Offset = "0x6879EE0", VA = "0x18687B8E0")]
	private float MHLGBBBDING(AAEGPHPJNLD FLFKBMMIINC, AAEGPHPJNLD HHMPHBNGMGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x687B0B0", Offset = "0x68796B0", VA = "0x18687B0B0")]
	public void KDJEFKDDCJG(AAEGPHPJNLD FLFKBMMIINC, AAEGPHPJNLD HHMPHBNGMGF, Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x687B1E0", Offset = "0x68797E0", VA = "0x18687B1E0")]
	public void KDJEFKDDCJG(AAEGPHPJNLD FLFKBMMIINC, AAEGPHPJNLD HHMPHBNGMGF, Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG, float MMHPMHNOCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x687B660", Offset = "0x6879C60", VA = "0x18687B660", Slot = "19")]
	public void LCFNIDMAODO(GMJKJCNNJPE HPEDOOPINDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6879F80", Offset = "0x6878580", VA = "0x186879F80")]
	public bool FNBDPKEMINK(AAEGPHPJNLD OJMEEMCEEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x687A500", Offset = "0x6878B00", VA = "0x18687A500", Slot = "16")]
	public void HLPKKMIBJFP(GMJKJCNNJPE HPEDOOPINDA, HashSet<GMJKJCNNJPE> DMAFOIIEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "20")]
	public FEDJAAAIKEC BICAPLMMHLC(bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "21")]
	public FEDJAAAIKEC HNHNCPHPFDN(HashSet<Guid> MHBBJMGNONA, bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6878B70", Offset = "0x6877170", VA = "0x186878B70", Slot = "23")]
	public void DEGLKPEELGE(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x687BF30", Offset = "0x687A530", VA = "0x18687BF30", Slot = "24")]
	public void MPPJKJFPHNM(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x687BFA0", Offset = "0x687A5A0", VA = "0x18687BFA0", Slot = "25")]
	public void NANFMDIJOFI(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6877F10", Offset = "0x6876510", VA = "0x186877F10")]
	private void BEPCOEINDLN(AAEGPHPJNLD FLFKBMMIINC, AAEGPHPJNLD HHMPHBNGMGF, Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG, float MMHPMHNOCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6878BE0", Offset = "0x68771E0", VA = "0x186878BE0")]
	private void DHABOBLKDJD(AAEGPHPJNLD FLFKBMMIINC, AAEGPHPJNLD NAEADMGDGFI, Vector3 DCBNBHMBGKP, Quaternion JAFBJNOBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6878AA0", Offset = "0x68770A0", VA = "0x186878AA0")]
	private void CKLHBCBPHOD(AAEGPHPJNLD FLFKBMMIINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x687AD00", Offset = "0x6879300", VA = "0x18687AD00")]
	[IteratorStateMachine(typeof(OPOAPBDPFDC))]
	public IEnumerable<GMJKJCNNJPE> JCGALCIPPAL(AAEGPHPJNLD OJMEEMCEEJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6878960", Offset = "0x6876F60", VA = "0x186878960")]
	internal GMJKJCNNJPE BIPKGCOMJAP(AAEGPHPJNLD OJMEEMCEEJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6878270", Offset = "0x6876870", VA = "0x186878270")]
	internal AAEGPHPJNLD BFBCFIIKHPL(GMJKJCNNJPE HPEDOOPINDA)
	{
		return default(AAEGPHPJNLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x687B990", Offset = "0x6879F90", VA = "0x18687B990")]
	private bool MLLGNILGMBM(KAIPELELCHG LFGOPFNHKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x687AB00", Offset = "0x6879100", VA = "0x18687AB00")]
	private bool ICLMAMIPPDF(KAIPELELCHG LFGOPFNHKKH, [Out] GMJKJCNNJPE HHMPHBNGMGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68785B0", Offset = "0x6876BB0", VA = "0x1868785B0")]
	private GMJKJCNNJPE BIPKGCOMJAP(KAIPELELCHG LFGOPFNHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x687A760", Offset = "0x6878D60", VA = "0x18687A760")]
	private GMJKJCNNJPE HPGCEEHLEAA(KAIPELELCHG LFGOPFNHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x687C380", Offset = "0x687A980", VA = "0x18687C380")]
	private GMJKJCNNJPE PIMEDEFPFIN(KAIPELELCHG LFGOPFNHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x687AF20", Offset = "0x6879520", VA = "0x18687AF20")]
	private static Guid KCNFLBGDLHD(KAIPELELCHG LFGOPFNHKKH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x687AC10", Offset = "0x6879210", VA = "0x18687AC10")]
	private string IPDCCKDOEEP(KAIPELELCHG LFGOPFNHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x687A210", Offset = "0x6878810", VA = "0x18687A210")]
	private void GJKCNDFDPOF(GMJKJCNNJPE FLFKBMMIINC, GMJKJCNNJPE NAEADMGDGFI, RigidTransform HEHKKIOOIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x687AD90", Offset = "0x6879390", VA = "0x18687AD90")]
	private void JNLAOKABDHI(GMJKJCNNJPE NAEADMGDGFI, GMJKJCNNJPE FLFKBMMIINC, RigidTransform HEHKKIOOIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6878B10", Offset = "0x6877110", VA = "0x186878B10")]
	private void DBNLEAOLHHA(GMJKJCNNJPE JFLPKAEFKDG, GMJKJCNNJPE FLFKBMMIINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6879000", Offset = "0x6877600", VA = "0x186879000")]
	private void DNOJCHPOPCD(GMJKJCNNJPE FLFKBMMIINC, GMJKJCNNJPE HHMPHBNGMGF, RigidTransform HEHKKIOOIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x687B7D0", Offset = "0x6879DD0", VA = "0x18687B7D0")]
	private void MEGPPJDLMFK(AAEGPHPJNLD OJMEEMCEEJO, GMJKJCNNJPE HPEDOOPINDA, AAEGPHPJNLD KICOJENABBD, AAEGPHPJNLD LINCCJJHGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x687B240", Offset = "0x6879840", VA = "0x18687B240")]
	private void KDNJOALGHHL(AAEGPHPJNLD OJMEEMCEEJO, GMJKJCNNJPE HPEDOOPINDA, GMJKJCNNJPE BDHNFEPJDDP, GMJKJCNNJPE JDLKLHDHDEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OHKOINDLMKC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ILDJBMBLOAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public DIIANKCHAHD container;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public ILDJBMBLOAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x687E440", Offset = "0x687CA40", VA = "0x18687E440")]
		internal CGGBBKPOOAN MMCLIKANOEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6887D60", Offset = "0x6886360", VA = "0x186887D60")]
	public static void OBOFKHCDFNO(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6887D10", Offset = "0x6886310", VA = "0x186887D10")]
	public static void IGJAJMEKHOG(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class OICFGCLJAOH : CMJOHBDFAPH, BAGGNFFFPEE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx HOIOIPJLNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly CGGBBKPOOAN FOOOKIPELJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DBHOECLFOEK KFGHOPDONGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly PJFCIMJOLBA AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EHPPJEJNINM[] MILJBEEBNEF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GMJKJCNNJPE LDCACKHBHGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6889A70", Offset = "0x6888070", VA = "0x186889A70", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GMJKJCNNJPE KOKOGDEHOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6888D80", Offset = "0x6887380", VA = "0x186888D80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 GFMEFGOGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6888C70", Offset = "0x6887270", VA = "0x186888C70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion GMCONBDNDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68888C0", Offset = "0x6886EC0", VA = "0x1868888C0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PFPGLGECLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68889A0", Offset = "0x6886FA0", VA = "0x1868889A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<GMJKJCNNJPE> MCLLDMIALGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6887EE0", Offset = "0x68864E0", VA = "0x186887EE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool LHECAHBJPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F18B0", Offset = "0x9EFEB0", VA = "0x1809F18B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F19D0", Offset = "0x9EFFD0", VA = "0x1809F19D0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6889C80", Offset = "0x6888280", VA = "0x186889C80", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject CHNINBIEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2546D70", Offset = "0x2545370", VA = "0x182546D70", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68899A0", Offset = "0x6887FA0", VA = "0x1868899A0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid KBKECDCOFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6889AD0", Offset = "0x68880D0", VA = "0x186889AD0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KJPFKCIOOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6889BB0", Offset = "0x68881B0", VA = "0x186889BB0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FCDELHAAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool PBBJOFGHMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x68897A0", Offset = "0x6887DA0", VA = "0x1868897A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HLIBHEONKFA FFLNHMAMOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6888860", Offset = "0x6886E60", VA = "0x186888860", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6888C10", Offset = "0x6887210", VA = "0x186888C10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HLIBHEONKFA DMCPCDAOOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6888D20", Offset = "0x6887320", VA = "0x186888D20", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6888DF0", Offset = "0x68873F0", VA = "0x186888DF0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HLIBHEONKFA HALKDAHPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6889740", Offset = "0x6887D40", VA = "0x186889740", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6888F90", Offset = "0x6887590", VA = "0x186888F90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event AAOJJMPMEIL OJGLDELBFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6887FE0", Offset = "0x68865E0", VA = "0x186887FE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6888E50", Offset = "0x6887450", VA = "0x186888E50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68898A0", Offset = "0x6887EA0", VA = "0x1868898A0")]
	public OICFGCLJAOH(AAEGPHPJNLD BMKMOMMIDOK, RigidbodyEx HOIOIPJLNDO, DBHOECLFOEK KFGHOPDONGO, EHPPJEJNINM[] MILJBEEBNEF, PJFCIMJOLBA AHBNABCBLNH, HPABFBMIFPF FOOOKIPELJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6889710", Offset = "0x6887D10", VA = "0x186889710", Slot = "19")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "21")]
	public void KFMFLCFEPMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x66F6C30", Offset = "0x66F5230", VA = "0x1866F6C30", Slot = "22")]
	public void AFGJOOEADGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6888360", Offset = "0x6886960", VA = "0x186888360", Slot = "20")]
	public void BKDEJNGAEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x68883B0", Offset = "0x68869B0", VA = "0x1868883B0", Slot = "25")]
	public void CKHPDAKFLJO(int FMECGGGAFDL, GMJKJCNNJPE PMKAGILCPKD, int DHMCDDCFLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6887F10", Offset = "0x6886510", VA = "0x186887F10", Slot = "26")]
	public void ALMDFJPABAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6888080", Offset = "0x6886680", VA = "0x186888080", Slot = "27")]
	public void ANGOJLOPDJN(int FMECGGGAFDL, GMJKJCNNJPE MDHJBKHHBBL, int IIGENDCFMBH, [Optional] Vector3? GBKOFELPANE, [Optional] Quaternion? GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6888920", Offset = "0x6886F20", VA = "0x186888920", Slot = "28")]
	public void FBCMLDAKBJH(GMJKJCNNJPE MDHJBKHHBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6888FF0", Offset = "0x68875F0", VA = "0x186888FF0", Slot = "31")]
	public void MLAMJIIIMFG(Vector3 CHCPDFBHOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6889400", Offset = "0x6887A00", VA = "0x186889400", Slot = "29")]
	public void MPCGCKNJHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6888660", Offset = "0x6886C60", VA = "0x186888660", Slot = "30")]
	public void DMGPMPKCGIE(int LLPJHIPCNFD, Vector3 OGNOLJCMDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6888B40", Offset = "0x6887140", VA = "0x186888B40", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int FMECGGGAFDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6888A10", Offset = "0x6887010", VA = "0x186888A10", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int FMECGGGAFDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8CB3C0", Offset = "0x8C99C0", VA = "0x1808CB3C0", Slot = "42")]
	public Color GetConnectionSlotColor(int FMECGGGAFDL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x68885C0", Offset = "0x6886BC0", VA = "0x1868885C0", Slot = "43")]
	public bool CanConnectTo(int FMECGGGAFDL, GMJKJCNNJPE FPGBIBMANJP, int PAHMMJNAGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "44")]
	public void ParentChanged(int FMECGGGAFDL, GMJKJCNNJPE MHHMGLAABAJ, int KOICKJKFAGF, Vector3 MOGCCMGAOPN, Quaternion KNELKAPKPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "45")]
	public void ChildAdded(int FMECGGGAFDL, GMJKJCNNJPE IJMKIDNJJGK, int DEKLMIBPAFK, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "46")]
	public void ChildRemoved(int FMECGGGAFDL, GMJKJCNNJPE KKHKKMDICHJ, int CIDMIJBPNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "47")]
	public void ConnectionModified(int FMECGGGAFDL, GMJKJCNNJPE PMKAGILCPKD, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x68897F0", Offset = "0x6887DF0", VA = "0x1868897F0", Slot = "48")]
	public void RootChanged(GMJKJCNNJPE FHKEHBOEKNI, GMJKJCNNJPE APKGLJCMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6888F40", Offset = "0x6887540", VA = "0x186888F40", Slot = "23")]
	public void LNKPAJGNAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6888CD0", Offset = "0x68872D0", VA = "0x186888CD0", Slot = "24")]
	public void IILOKIFGBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6888EF0", Offset = "0x68874F0", VA = "0x186888EF0")]
	private void KIGIFEGFFJI(bool JNHNMOIFJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[CMLNAOLMFON(typeof(MDFELAEONHL), new string[] { })]
public class CELLLHDLCAL : MDFELAEONHL, FDGJCDDLIFG
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KEGPMLFAJKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CELLLHDLCAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ANDJNBHCECG localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public KEGPMLFAJKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x687E4F0", Offset = "0x687CAF0", VA = "0x18687E4F0")]
		internal void JGLNKEABGME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ICNJJAINNMH]
	private KABIIEPADHK ECFOBHKDIGL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object EPMAPFKMHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6877C50", Offset = "0x6876250", VA = "0x186877C50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6877CE0", Offset = "0x68762E0", VA = "0x186877CE0", Slot = "6")]
	public void InitReferences(HODPOPFOFDD PDKMAMNDBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6877D30", Offset = "0x6876330", VA = "0x186877D30", Slot = "5")]
	public void OHHCEDNBMNL(ANDJNBHCECG HDPAMFPMPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public CELLLHDLCAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[CMLNAOLMFON(typeof(HPABFBMIFPF), new string[] { "Ignore", "Mock" })]
public class LJKMABGNBEI : HPABFBMIFPF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JIKMPJAABDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<GMJKJCNNJPE, GMJKJCNNJPE> NGCIBNKHBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6881F20", Offset = "0x6880520", VA = "0x186881F20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6882080", Offset = "0x6880680", VA = "0x186882080", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<GMJKJCNNJPE, GMJKJCNNJPE> KAPCLDHFBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6882290", Offset = "0x6880890", VA = "0x186882290", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6881FD0", Offset = "0x68805D0", VA = "0x186881FD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<GMJKJCNNJPE, GMJKJCNNJPE, GMJKJCNNJPE> BEAKJBJKICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x68821E0", Offset = "0x68807E0", VA = "0x1868821E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6882130", Offset = "0x6880730", VA = "0x186882130", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "12")]
	public void BGGINNGCCML(GameObject INALOLPJOHI, MPPHGODNJKL FBGMHPANGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "13")]
	public void OMKLHJHPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "14")]
	public void PIKNDMFIIPK(GMJKJCNNJPE HPEDOOPINDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "15")]
	public void KAAMLDMKLFD(GMJKJCNNJPE HPEDOOPINDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "16")]
	public void HLPKKMIBJFP(GMJKJCNNJPE HPEDOOPINDA, HashSet<GMJKJCNNJPE> DMAFOIIEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "17")]
	public void EPLHCKJIHLI(GMJKJCNNJPE HPEDOOPINDA, GMJKJCNNJPE OJKMNCEMIPN, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "18")]
	public void KDJEFKDDCJG(GMJKJCNNJPE HPEDOOPINDA, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "19")]
	public void LCFNIDMAODO(GMJKJCNNJPE HPEDOOPINDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "20")]
	public FEDJAAAIKEC BICAPLMMHLC(bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "21")]
	public FEDJAAAIKEC HNHNCPHPFDN(HashSet<Guid> MHBBJMGNONA, bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "22")]
	public bool HPFHCLENHLC(KAIPELELCHG LFGOPFNHKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "23")]
	public void DEGLKPEELGE(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "24")]
	public void MPPJKJFPHNM(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "25")]
	public void NANFMDIJOFI(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public LJKMABGNBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GMJKJCNNJPE : BAGGNFFFPEE, IEquatable<GMJKJCNNJPE>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BAGGNFFFPEE
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GMJKJCNNJPE LDCACKHBHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject CHNINBIEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid KBKECDCOFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int KJPFKCIOOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	AAEGPHPJNLD PACDPOKOKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FCDELHAAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int FMECGGGAFDL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int FMECGGGAFDL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int FMECGGGAFDL);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int FMECGGGAFDL, GMJKJCNNJPE FPGBIBMANJP, int OBOIMJFHDNP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int FMECGGGAFDL, GMJKJCNNJPE MHHMGLAABAJ, int KOICKJKFAGF, Vector3 MOGCCMGAOPN, Quaternion KNELKAPKPMG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int FMECGGGAFDL, GMJKJCNNJPE IJMKIDNJJGK, int DEKLMIBPAFK, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int FMECGGGAFDL, GMJKJCNNJPE KKHKKMDICHJ, int CIDMIJBPNDD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int FMECGGGAFDL, GMJKJCNNJPE PMKAGILCPKD, int FOBOBIOEHNK, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(GMJKJCNNJPE FHKEHBOEKNI, GMJKJCNNJPE APKGLJCMONE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[PBELGAHGGLA(AFHNLDKMONP.OMRoom)]
public interface HPABFBMIFPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool JIKMPJAABDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GMJKJCNNJPE, GMJKJCNNJPE> NGCIBNKHBJJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<GMJKJCNNJPE, GMJKJCNNJPE> KAPCLDHFBIJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<GMJKJCNNJPE, GMJKJCNNJPE, GMJKJCNNJPE> BEAKJBJKICC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BGGINNGCCML(GameObject INALOLPJOHI, MPPHGODNJKL FBGMHPANGGK);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OMKLHJHPBJI();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PIKNDMFIIPK(GMJKJCNNJPE HPEDOOPINDA);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KAAMLDMKLFD(GMJKJCNNJPE HPEDOOPINDA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HLPKKMIBJFP(GMJKJCNNJPE HPEDOOPINDA, HashSet<GMJKJCNNJPE> DMAFOIIEHMP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EPLHCKJIHLI(GMJKJCNNJPE HPEDOOPINDA, GMJKJCNNJPE OJKMNCEMIPN, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KDJEFKDDCJG(GMJKJCNNJPE HPEDOOPINDA, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LCFNIDMAODO(GMJKJCNNJPE HPEDOOPINDA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FEDJAAAIKEC BICAPLMMHLC(bool NMNNJNGJNCB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FEDJAAAIKEC HNHNCPHPFDN(HashSet<Guid> MHBBJMGNONA, bool NMNNJNGJNCB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HPFHCLENHLC(KAIPELELCHG LFGOPFNHKKH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DEGLKPEELGE(FEDJAAAIKEC MJOHLJLDMNN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MPPJKJFPHNM(FEDJAAAIKEC MJOHLJLDMNN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NANFMDIJOFI(FEDJAAAIKEC MJOHLJLDMNN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HNAKFAGLLOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OGPLEDGKMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GMJKJCNNJPE PIMEDEFPFIN(int KGFGEPOKOJA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GMJKJCNNJPE HPGCEEHLEAA(Guid JHJMNCKOBDJ);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OJLPPKNIJCD(GMJKJCNNJPE HPEDOOPINDA);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BGCJHCDMDPH();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ILNIMKOFFIG(GMJKJCNNJPE KFGHOPDONGO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[PBELGAHGGLA(AFHNLDKMONP.Application)]
public interface PJFCIMJOLBA
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBBJOFGHMMC(DBHOECLFOEK KFGHOPDONGO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBDMFGJPGNP(DBHOECLFOEK KFGHOPDONGO);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string ONKBCOKAIMF(DBHOECLFOEK KFGHOPDONGO);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid NKGNFAJIGCJ(DBHOECLFOEK KFGHOPDONGO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MNIIGEKBILF(DBHOECLFOEK KFGHOPDONGO);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JAPPKPMKLLD(DBHOECLFOEK KFGHOPDONGO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void HLIBHEONKFA(GMJKJCNNJPE MDHJBKHHBBL, int GLIKJDHPKCM, GMJKJCNNJPE PMKAGILCPKD, int MFCHICCKLPI, [Optional] Vector3? GBKOFELPANE, [Optional] Quaternion? GHLONPJIMPI);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void AAOJJMPMEIL(GMJKJCNNJPE FHKEHBOEKNI, GMJKJCNNJPE APKGLJCMONE);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DBHOECLFOEK : GMJKJCNNJPE, BAGGNFFFPEE, IEquatable<GMJKJCNNJPE>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CMJOHBDFAPH : BAGGNFFFPEE
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GMJKJCNNJPE KOKOGDEHOOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<GMJKJCNNJPE> MCLLDMIALGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 GFMEFGOGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion GMCONBDNDBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool PFPGLGECLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LHECAHBJPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event HLIBHEONKFA FFLNHMAMOCN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event HLIBHEONKFA DMCPCDAOOKG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HLIBHEONKFA HALKDAHPGAG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event AAOJJMPMEIL OJGLDELBFBB;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NJNJFFLKLJH();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BKDEJNGAEPP();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KFMFLCFEPMI();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AFGJOOEADGD();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LNKPAJGNAAE();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IILOKIFGBLF();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CKHPDAKFLJO(int FMECGGGAFDL, GMJKJCNNJPE PMKAGILCPKD, int DHMCDDCFLFE);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ALMDFJPABAH();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ANGOJLOPDJN(int FMECGGGAFDL, GMJKJCNNJPE MDHJBKHHBBL, int IIGENDCFMBH, [Optional] Vector3? GBKOFELPANE, [Optional] Quaternion? GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FBCMLDAKBJH(GMJKJCNNJPE MDHJBKHHBBL);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MPCGCKNJHNC();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DMGPMPKCGIE(int LLPJHIPCNFD, Vector3 OGNOLJCMDMP);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MLAMJIIIMFG(Vector3 CHCPDFBHOCC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EHPPJEJNINM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 IIJPCECDCAI
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
public interface MPPHGODNJKL
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool JIKPGNDKBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	OKKGPHLACID JOBABEJBGOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, MPPHGODNJKL
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
			[Cpp2IlInjected.Address(RVA = "0x92FCA0", Offset = "0x92E2A0", VA = "0x18092FCA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public OKKGPHLACID LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x687C740", Offset = "0x687AD40", VA = "0x18687C740")]
		public static ConnectableConfigData IGDFKNKMMKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x687C800", Offset = "0x687AE00", VA = "0x18687C800")]
		public ConnectableConfigData(LegacyConnectableLinkVisual DFHCCKHEJNM, bool NEBOLPAHOEI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FNBBBPMDJEA : IEquatable<FNBBBPMDJEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public GMJKJCNNJPE HPEDOOPINDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int PELKODHFFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int FOBOBIOEHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 GBKOFELPANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion GHLONPJIMPI;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x687D5C0", Offset = "0x687BBC0", VA = "0x18687D5C0")]
	public FNBBBPMDJEA(GMJKJCNNJPE HPEDOOPINDA, int PELKODHFFGF, int FOBOBIOEHNK, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x687D490", Offset = "0x687BA90", VA = "0x18687D490")]
	public FNBBBPMDJEA(GMJKJCNNJPE HPEDOOPINDA, int PELKODHFFGF, int FOBOBIOEHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x687D530", Offset = "0x687BB30", VA = "0x18687D530")]
	public FNBBBPMDJEA(GMJKJCNNJPE HPEDOOPINDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x687D020", Offset = "0x687B620", VA = "0x18687D020", Slot = "4")]
	public bool Equals(FNBBBPMDJEA LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x687D0D0", Offset = "0x687B6D0", VA = "0x18687D0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class PKDCPPJGBIF : CFCBOPHCGOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform DNPKMJFBJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private OKKGPHLACID HNCLNOINDPH;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6382E60", Offset = "0x6381460", VA = "0x186382E60", Slot = "4")]
	public void BGGINNGCCML(Transform DNPKMJFBJBC, OKKGPHLACID HNCLNOINDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x688AD40", Offset = "0x6889340", VA = "0x18688AD40", Slot = "5")]
	public OKKGPHLACID FDIHCIFHCHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x688AE10", Offset = "0x6889410", VA = "0x18688AE10", Slot = "6")]
	public void KMPCMKEMPCK(OKKGPHLACID DGDNLGPMOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public PKDCPPJGBIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class NMLILEPIBEF : IDisposable, EKGKFCENFIF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NCNDNLNAFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GMJKJCNNJPE oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GMJKJCNNJPE newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public NCNDNLNAFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x68846B0", Offset = "0x6882CB0", VA = "0x1868846B0")]
		internal bool JHJJHIEFFNN(LDLFMBNKOLF node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly PIMGJDPFLDG KNMHMDLGOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private CIHJNJAAODC MNLMKBAMJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MPGJEEAIJNE JPFKNIEEJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool NEBOLPAHOEI;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly ICJNMGNJFIN AJCCHOHCDHA;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LDLFMBNKOLF JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x68857A0", Offset = "0x6883DA0", VA = "0x1868857A0")]
	public bool FOHAMPCAACE([In] FFAGBOMHBPG FHNKDHIILBL, bool EKJBCDCBPGO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6886820", Offset = "0x6884E20", VA = "0x186886820")]
	private bool JOLGDKFEBOO([In] FFAGBOMHBPG FHNKDHIILBL, bool EKJBCDCBPGO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6887B40", Offset = "0x6886140", VA = "0x186887B40")]
	public NMLILEPIBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6885020", Offset = "0x6883620", VA = "0x186885020", Slot = "5")]
	public void BGGINNGCCML(HPABFBMIFPF MFNJBGPIIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6884D20", Offset = "0x6883320", VA = "0x186884D20", Slot = "17")]
	public void AHKGICIEDHJ(EDMLOPHELKC AHJILKLLLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6884E80", Offset = "0x6883480", VA = "0x186884E80", Slot = "12")]
	public void AMMHBEGKBJM(Func<GMJKJCNNJPE, bool> CNKCBEIIIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6884D50", Offset = "0x6883350", VA = "0x186884D50")]
	private void AMMHBEGKBJM(PIMGJDPFLDG MPJOKOKILNG, Func<GMJKJCNNJPE, bool> CNKCBEIIIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x68850B0", Offset = "0x68836B0", VA = "0x1868850B0", Slot = "11")]
	public void BKOCGGIGHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6887670", Offset = "0x6885C70", VA = "0x186887670", Slot = "8")]
	public bool OFKNJJMNNCO(GMJKJCNNJPE OBCIEJGBDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x68857B0", Offset = "0x6883DB0", VA = "0x1868857B0")]
	private bool GBJIMKNLFLH(GMJKJCNNJPE HCKENNDIFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6884F70", Offset = "0x6883570", VA = "0x186884F70")]
	private static bool APEIIHANBFE(GMJKJCNNJPE HCKENNDIFKA, PIMGJDPFLDG FHFPPDJIKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6887680", Offset = "0x6885C80", VA = "0x186887680")]
	private void ONLLJFJBMAK(Transform HAOJNIOMHFP, PIMGJDPFLDG KLGBPNCFOMO, PIMGJDPFLDG[] GBNBEMBOBBH, GMJKJCNNJPE GEGHBIOMOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x68850D0", Offset = "0x68836D0", VA = "0x1868850D0")]
	private FNBBBPMDJEA BMBCEKJAEFG(Transform FLIPCEIIMEH, FNBBBPMDJEA OKBGELKAELO)
	{
		return default(FNBBBPMDJEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6886540", Offset = "0x6884B40", VA = "0x186886540")]
	private static bool IIPKNKABDAG(PIMGJDPFLDG FHFPPDJIKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6887610", Offset = "0x6885C10", VA = "0x186887610", Slot = "9")]
	public bool ODHPCOBIODH(GMJKJCNNJPE BOPCIPDICHF, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6887270", Offset = "0x6885870", VA = "0x186887270")]
	private bool LEHDPEDAOCH(GMJKJCNNJPE BOPCIPDICHF, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6885220", Offset = "0x6883820", VA = "0x186885220")]
	private static void CPPPIIDAJHK(GMJKJCNNJPE BOPCIPDICHF, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI, PIMGJDPFLDG NJGBMPEAEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6886010", Offset = "0x6884610", VA = "0x186886010")]
	private void GJKCNDFDPOF(GMJKJCNNJPE DLKCHPNFDJD, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6884E90", Offset = "0x6883490", VA = "0x186884E90")]
	private void AONNKLNGPKJ(PIMGJDPFLDG MPJOKOKILNG, GMJKJCNNJPE BDHNFEPJDDP, GMJKJCNNJPE JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6884F00", Offset = "0x6883500", VA = "0x186884F00")]
	private void AONNKLNGPKJ(GMJKJCNNJPE HPEDOOPINDA, GMJKJCNNJPE BDHNFEPJDDP, GMJKJCNNJPE JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6886DF0", Offset = "0x68853F0", VA = "0x186886DF0")]
	private void KDNJOALGHHL(GMJKJCNNJPE HPEDOOPINDA, GMJKJCNNJPE BDHNFEPJDDP, GMJKJCNNJPE JDLKLHDHDEB, bool OJLAKEOKPNL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6886E60", Offset = "0x6885460", VA = "0x186886E60")]
	private void KDNJOALGHHL(PIMGJDPFLDG FMGEJNFFGHE, GMJKJCNNJPE GEGHBIOMOIL, GMJKJCNNJPE APKGLJCMONE, bool OJLAKEOKPNL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6886700", Offset = "0x6884D00", VA = "0x186886700")]
	private void JNLAOKABDHI(GMJKJCNNJPE FLFKBMMIINC, int IIGENDCFMBH, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x68853A0", Offset = "0x68839A0", VA = "0x1868853A0")]
	private void DBNLEAOLHHA(LDLFMBNKOLF HHMPHBNGMGF, LDLFMBNKOLF AFADPLKPEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6885EB0", Offset = "0x68844B0", VA = "0x186885EB0", Slot = "18")]
	public GMJKJCNNJPE GFIMKFBNKAD(GMJKJCNNJPE HPEDOOPINDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6886130", Offset = "0x6884730", VA = "0x186886130", Slot = "13")]
	public void HLPKKMIBJFP(GMJKJCNNJPE HPEDOOPINDA, HashSet<GMJKJCNNJPE> ADMCICDCKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6886F60", Offset = "0x6885560", VA = "0x186886F60", Slot = "14")]
	public List<GMJKJCNNJPE> KIOPKCNNPOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6885500", Offset = "0x6883B00", VA = "0x186885500")]
	protected LDLFMBNKOLF DCDJOCNCGFF(LDLFMBNKOLF MPJOKOKILNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x68855D0", Offset = "0x6883BD0", VA = "0x1868855D0")]
	protected PIMGJDPFLDG[] DMPDDCANIMF(PIMGJDPFLDG FHFPPDJIKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x68874C0", Offset = "0x6885AC0", VA = "0x1868874C0")]
	protected bool MNLDBNOEDCL(GMJKJCNNJPE HPEDOOPINDA, [Out] PIMGJDPFLDG MPJOKOKILNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6885670", Offset = "0x6883C70", VA = "0x186885670", Slot = "15")]
	public bool ELBIAOONLMK(GMJKJCNNJPE HPEDOOPINDA, [Out] FNBBBPMDJEA JEEIKHJONKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x68875D0", Offset = "0x6885BD0", VA = "0x1868875D0")]
	protected PIMGJDPFLDG OBBMCBBNKNF(FNBBBPMDJEA JJMEPGGNNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x68864E0", Offset = "0x6884AE0", VA = "0x1868864E0", Slot = "10")]
	public bool IEOOECJHALP(GMJKJCNNJPE DLKCHPNFDJD, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6884770", Offset = "0x6882D70", VA = "0x186884770")]
	private bool AFKFKJJFOPE(GMJKJCNNJPE DLKCHPNFDJD, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x68871A0", Offset = "0x68857A0", VA = "0x1868871A0")]
	private static bool KLIKHFPADKK(PIMGJDPFLDG KCLLEJOGGEF, FNBBBPMDJEA FIELCDJANFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x68857A0", Offset = "0x6883DA0", VA = "0x1868857A0", Slot = "7")]
	private bool LMLAPFFPLDN([In] FFAGBOMHBPG FHNKDHIILBL, bool EKJBCDCBPGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class BNKPODGGFGA : HPABFBMIFPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly DIIANKCHAHD OMDOLEEBJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly MPGJEEAIJNE JPFKNIEEJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly FBGCNOPCIED LBPGKOLGBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly LGEKMCAGLFJ PJOJCBAMMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly EKGKFCENFIF MJOHLJLDMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal LAMIIFMLHIJ AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal GOJPIGHDFDG KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal CIHJNJAAODC ENANGGPMDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool NEBOLPAHOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool JFOFOAKEKCF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool PFOPAGAJGOD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x92F0D0", Offset = "0x92D6D0", VA = "0x18092F0D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1931CA0", Offset = "0x19302A0", VA = "0x181931CA0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x92F0B0", Offset = "0x92D6B0", VA = "0x18092F0B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1931C80", Offset = "0x1930280", VA = "0x181931C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JIKMPJAABDH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<GMJKJCNNJPE, GMJKJCNNJPE> NGCIBNKHBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6876770", Offset = "0x6874D70", VA = "0x186876770", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6876C20", Offset = "0x6875220", VA = "0x186876C20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<GMJKJCNNJPE, GMJKJCNNJPE> KAPCLDHFBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6877520", Offset = "0x6875B20", VA = "0x186877520", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6876BC0", Offset = "0x68751C0", VA = "0x186876BC0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<GMJKJCNNJPE, GMJKJCNNJPE, GMJKJCNNJPE> BEAKJBJKICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x68770B0", Offset = "0x68756B0", VA = "0x1868770B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6876DF0", Offset = "0x68753F0", VA = "0x186876DF0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6877730", Offset = "0x6875D30", VA = "0x186877730")]
	public BNKPODGGFGA(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6875EE0", Offset = "0x68744E0", VA = "0x186875EE0", Slot = "12")]
	public void BGGINNGCCML(GameObject INALOLPJOHI, MPPHGODNJKL FBGMHPANGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x68766D0", Offset = "0x6874CD0", VA = "0x1868766D0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6877580", Offset = "0x6875B80", VA = "0x186877580", Slot = "13")]
	public void OMKLHJHPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x68775D0", Offset = "0x6875BD0", VA = "0x1868775D0", Slot = "14")]
	public void PIKNDMFIIPK(GMJKJCNNJPE HPEDOOPINDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6876670", Offset = "0x6874C70", VA = "0x186876670", Slot = "15")]
	public void KAAMLDMKLFD(GMJKJCNNJPE HPEDOOPINDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6876DA0", Offset = "0x68753A0", VA = "0x186876DA0", Slot = "22")]
	public bool HPFHCLENHLC(KAIPELELCHG LFGOPFNHKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6876EB0", Offset = "0x68754B0", VA = "0x186876EB0")]
	internal bool JOLGDKFEBOO([In] FFAGBOMHBPG FHNKDHIILBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6875E50", Offset = "0x6874450", VA = "0x186875E50")]
	internal bool AFKFKJJFOPE([In] FFAGBOMHBPG FHNKDHIILBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6876E50", Offset = "0x6875450", VA = "0x186876E50")]
	internal bool JHDIENPAAOK([In] FFAGBOMHBPG FHNKDHIILBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x68772E0", Offset = "0x68758E0", VA = "0x1868772E0")]
	internal bool LFHDLLECHJP([In] FFAGBOMHBPG FHNKDHIILBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x68769E0", Offset = "0x6874FE0", VA = "0x1868769E0")]
	internal void GJNBHCKCIEK(GMJKJCNNJPE HPEDOOPINDA, int LIMLLMOKLAM, bool EKJBCDCBPGO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6876670", Offset = "0x6874C70", VA = "0x186876670")]
	internal bool DEMCBLDABOO(GMJKJCNNJPE GAPJDKEHPJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x68775F0", Offset = "0x6875BF0", VA = "0x1868775F0")]
	internal bool PMOLPMLBEMC(GMJKJCNNJPE BOPCIPDICHF, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6876C80", Offset = "0x6875280", VA = "0x186876C80", Slot = "16")]
	public void HLPKKMIBJFP(GMJKJCNNJPE HPEDOOPINDA, HashSet<GMJKJCNNJPE> DMAFOIIEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x68767D0", Offset = "0x6874DD0", VA = "0x1868767D0", Slot = "17")]
	public void EPLHCKJIHLI(GMJKJCNNJPE BOPCIPDICHF, GMJKJCNNJPE OJKMNCEMIPN, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6876F70", Offset = "0x6875570", VA = "0x186876F70", Slot = "18")]
	public void KDJEFKDDCJG(GMJKJCNNJPE DLKCHPNFDJD, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6877110", Offset = "0x6875710", VA = "0x186877110", Slot = "19")]
	public void LCFNIDMAODO(GMJKJCNNJPE DLKCHPNFDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x68764D0", Offset = "0x6874AD0", VA = "0x1868764D0")]
	public void CMHPMNIEKPC([Optional] PFCAGLIFOHP HIAKPCPGJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x68765E0", Offset = "0x6874BE0", VA = "0x1868765E0", Slot = "23")]
	public void DEGLKPEELGE(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x68764B0", Offset = "0x6874AB0", VA = "0x1868764B0", Slot = "20")]
	public FEDJAAAIKEC BICAPLMMHLC(bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6876D80", Offset = "0x6875380", VA = "0x186876D80", Slot = "21")]
	public FEDJAAAIKEC HNHNCPHPFDN(HashSet<Guid> MHBBJMGNONA, bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x68774E0", Offset = "0x6875AE0", VA = "0x1868774E0", Slot = "25")]
	public void NANFMDIJOFI(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6877430", Offset = "0x6875A30", VA = "0x186877430", Slot = "24")]
	public void MPPJKJFPHNM(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class MPGJEEAIJNE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly MLMADGFCCJE<GMJKJCNNJPE, GMJKJCNNJPE> NGCIBNKHBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly MLMADGFCCJE<GMJKJCNNJPE, GMJKJCNNJPE> KAPCLDHFBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly NLMLNFBKPBM<GMJKJCNNJPE, GMJKJCNNJPE, GMJKJCNNJPE> BEAKJBJKICC;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6884590", Offset = "0x6882B90", VA = "0x186884590")]
	public MPGJEEAIJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	public void BGGINNGCCML(BNKPODGGFGA MFNJBGPIIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6884450", Offset = "0x6882A50", VA = "0x186884450")]
	public void BFNJGKILJOD(GMJKJCNNJPE HHMPHBNGMGF, GMJKJCNNJPE FLFKBMMIINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x68844B0", Offset = "0x6882AB0", VA = "0x1868844B0")]
	public void GJILKBIMFGN(GMJKJCNNJPE HHMPHBNGMGF, GMJKJCNNJPE FLFKBMMIINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6884510", Offset = "0x6882B10", VA = "0x186884510")]
	public void HKBACBLKEEM(GMJKJCNNJPE JFLPKAEFKDG, GMJKJCNNJPE NAEADMGDGFI, GMJKJCNNJPE FLFKBMMIINC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FBGCNOPCIED : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private BNKPODGGFGA MFNJBGPIIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private GOJPIGHDFDG KJHMNPPBFKI;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public FBGCNOPCIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x687CB10", Offset = "0x687B110", VA = "0x18687CB10")]
	public void BGGINNGCCML(BNKPODGGFGA MFNJBGPIIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x687CC40", Offset = "0x687B240", VA = "0x18687CC40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x687CE50", Offset = "0x687B450", VA = "0x18687CE50")]
	private void JKJCOKLPLPB(PFCAGLIFOHP GOBKHJJOFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x687CAA0", Offset = "0x687B0A0", VA = "0x18687CAA0")]
	private void APAHHADGACM(PFCAGLIFOHP OKBCHDHAJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x687CC50", Offset = "0x687B250", VA = "0x18687CC50")]
	public void FKBPJKJNCGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x687CD50", Offset = "0x687B350", VA = "0x18687CD50")]
	public void GDJCLDOBANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class ANGFAMNLOEI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MECLHHHACAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public DIIANKCHAHD container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public MECLHHHACAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x68843E0", Offset = "0x68829E0", VA = "0x1868843E0")]
		internal BNKPODGGFGA MMCLIKANOEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6875C50", Offset = "0x6874250", VA = "0x186875C50")]
	public static void OBOFKHCDFNO(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6875BD0", Offset = "0x68741D0", VA = "0x186875BD0")]
	public static void IGJAJMEKHOG(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class HPBMMLKHKFO : IDisposable, CIHJNJAAODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, OKKGPHLACID> NBNGJOHAFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EDMLOPHELKC MCNJPEFMMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private CFCBOPHCGOD AEPILAELHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private EKGKFCENFIF MJOHLJLDMNN;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x687E360", Offset = "0x687C960", VA = "0x18687E360")]
	public HPBMMLKHKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x687D7E0", Offset = "0x687BDE0", VA = "0x18687D7E0", Slot = "7")]
	public void BGGINNGCCML(EKGKFCENFIF MJOHLJLDMNN, CFCBOPHCGOD AEPILAELHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x687E050", Offset = "0x687C650", VA = "0x18687E050", Slot = "5")]
	public void IEOFDCNGAFK(LDLFMBNKOLF OKGMGPBDICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x687DB90", Offset = "0x687C190", VA = "0x18687DB90", Slot = "9")]
	public void GJMPOJANGJH(LDLFMBNKOLF DAPLFFMCJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x687D820", Offset = "0x687BE20", VA = "0x18687D820", Slot = "8")]
	public void EAOLFNJEDKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x687DD00", Offset = "0x687C300", VA = "0x18687DD00", Slot = "10")]
	public void HCDIGCJNPMP(LDLFMBNKOLF JIENCEMLDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x687E290", Offset = "0x687C890", VA = "0x18687E290", Slot = "11")]
	public void KEPFELPLEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x687D9E0", Offset = "0x687BFE0", VA = "0x18687D9E0")]
	private bool FHKAJJNEFNA(LDLFMBNKOLF HPNFCDLKBEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class LGEKMCAGLFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct KGHPNGDGCKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly PIMGJDPFLDG CKJHJLPBPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> MHBBJMGNONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly KAIPELELCHG PNKHIKMGOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly KAIPELELCHG BENLBHNBAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool NMNNJNGJNCB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool MNBFBNHOMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x687ED90", Offset = "0x687D390", VA = "0x18687ED90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x687EEB0", Offset = "0x687D4B0", VA = "0x18687EEB0")]
		public KGHPNGDGCKN(PIMGJDPFLDG CKJHJLPBPBH, HashSet<Guid> MHBBJMGNONA, bool NMNNJNGJNCB, [Optional] KAIPELELCHG PNKHIKMGOLL, [Optional] KAIPELELCHG BENLBHNBAOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x687EBF0", Offset = "0x687D1F0", VA = "0x18687EBF0")]
		public KAIPELELCHG KLDBPIDHOEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x687EB30", Offset = "0x687D130", VA = "0x18687EB30")]
		private KAIPELELCHG HGCAEPINFGJ([Out] KAIPELELCHG MIJHDNDHFJL, [Out] KAIPELELCHG EELIKDDAAGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x687E5E0", Offset = "0x687CBE0", VA = "0x18687E5E0")]
		private KAIPELELCHG BPPKEKDJOIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x687E9C0", Offset = "0x687CFC0", VA = "0x18687E9C0")]
		private void GHAPIPOKDCK(KAIPELELCHG JLBHHBJJKMF, KAIPELELCHG PIILDCNAHPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x687E800", Offset = "0x687CE00", VA = "0x18687E800")]
		private void EGPNMDENLAI(KAIPELELCHG MIJHDNDHFJL, KAIPELELCHG EELIKDDAAGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private BNKPODGGFGA MFNJBGPIIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private EKGKFCENFIF MJOHLJLDMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private CIHJNJAAODC MNLMKBAMJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GOJPIGHDFDG KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool HENDGHAOIIK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool NKABODLKMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x68807A0", Offset = "0x687EDA0", VA = "0x1868807A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool PFOPAGAJGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6881D10", Offset = "0x6880310", VA = "0x186881D10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6880970", Offset = "0x687EF70", VA = "0x186880970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x687F170", Offset = "0x687D770", VA = "0x18687F170")]
	public void BGGINNGCCML(BNKPODGGFGA MFNJBGPIIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x687F300", Offset = "0x687D900", VA = "0x18687F300")]
	public FEDJAAAIKEC BICAPLMMHLC(bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6880990", Offset = "0x687EF90", VA = "0x186880990")]
	public FEDJAAAIKEC HNHNCPHPFDN(HashSet<Guid> MHBBJMGNONA, bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x687FE80", Offset = "0x687E480", VA = "0x18687FE80")]
	public void DEGLKPEELGE(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6881C70", Offset = "0x6880270", VA = "0x186881C70")]
	public void MPPJKJFPHNM(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x687F140", Offset = "0x687D740", VA = "0x18687F140")]
	public void BFGOAEAJFPO(FEDJAAAIKEC MJOHLJLDMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6880380", Offset = "0x687E980", VA = "0x186880380")]
	private void FDGNCBIDFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6880570", Offset = "0x687EB70", VA = "0x186880570")]
	private KAIPELELCHG GNIAEOKHKEK(PIMGJDPFLDG MPJOKOKILNG, bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x687FF10", Offset = "0x687E510", VA = "0x18687FF10")]
	private static void DFFEHJBCJLP(PIMGJDPFLDG MPJOKOKILNG, bool NMNNJNGJNCB, KAIPELELCHG LFGOPFNHKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x687EF20", Offset = "0x687D520", VA = "0x18687EF20")]
	private void BBMINGOKMJB(PIMGJDPFLDG MPJOKOKILNG, bool NMNNJNGJNCB, KAIPELELCHG LFGOPFNHKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x68802F0", Offset = "0x687E8F0", VA = "0x1868802F0")]
	private KAIPELELCHG EJOOBBDDNNI(PIMGJDPFLDG CKJHJLPBPBH, HashSet<Guid> MHBBJMGNONA, bool NMNNJNGJNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x687FBF0", Offset = "0x687E1F0", VA = "0x18687FBF0")]
	private bool CBHLIMNOJOP(FEDJAAAIKEC BCMLIMOADPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6881600", Offset = "0x687FC00", VA = "0x186881600")]
	private bool MLLGNILGMBM(KAIPELELCHG LFGOPFNHKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x687FBD0", Offset = "0x687E1D0", VA = "0x18687FBD0")]
	private bool BNKJAGHIHIO(FEDJAAAIKEC MJOHLJLDMNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x687F1E0", Offset = "0x687D7E0", VA = "0x18687F1E0")]
	private static bool BHFNIOCCLLP(KAIPELELCHG LFGOPFNHKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6881020", Offset = "0x687F620", VA = "0x186881020")]
	public static bool HPFHCLENHLC(KAIPELELCHG LFGOPFNHKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x687F880", Offset = "0x687DE80", VA = "0x18687F880")]
	private GMJKJCNNJPE BIPKGCOMJAP(KAIPELELCHG LFGOPFNHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6881D30", Offset = "0x6880330", VA = "0x186881D30")]
	private GMJKJCNNJPE PIMEDEFPFIN(KAIPELELCHG LFGOPFNHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6880160", Offset = "0x687E760", VA = "0x186880160")]
	private GMJKJCNNJPE DKLPMEHHOIJ(KAIPELELCHG LFGOPFNHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x687AF20", Offset = "0x6879520", VA = "0x18687AF20")]
	private static Guid KCNFLBGDLHD(KAIPELELCHG LFGOPFNHKKH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x68812B0", Offset = "0x687F8B0", VA = "0x1868812B0")]
	private string IPDCCKDOEEP(KAIPELELCHG LFGOPFNHKKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x68807F0", Offset = "0x687EDF0", VA = "0x1868807F0")]
	private bool HIKEIPMKNJC(PIMGJDPFLDG MPJOKOKILNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x68813A0", Offset = "0x687F9A0", VA = "0x1868813A0")]
	private static void IPNAOPHEOHH(PIMGJDPFLDG CKJHJLPBPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public LGEKMCAGLFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct FFAGBOMHBPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public GMJKJCNNJPE FLFKBMMIINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public GMJKJCNNJPE HHMPHBNGMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int IIGENDCFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int DHMCDDCFLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 GBKOFELPANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion GHLONPJIMPI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FNBBBPMDJEA EDHEDAHJMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x687CEA0", Offset = "0x687B4A0", VA = "0x18687CEA0")]
		get
		{
			return default(FNBBBPMDJEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FNBBBPMDJEA JHBCDCPGLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x687CE70", Offset = "0x687B470", VA = "0x18687CE70")]
		get
		{
			return default(FNBBBPMDJEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x687CF40", Offset = "0x687B540", VA = "0x18687CF40")]
	public FFAGBOMHBPG(GMJKJCNNJPE FLFKBMMIINC, GMJKJCNNJPE HHMPHBNGMGF, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface EKGKFCENFIF
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LDLFMBNKOLF JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGGINNGCCML(HPABFBMIFPF MFNJBGPIIEN);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FOHAMPCAACE([In] FFAGBOMHBPG FHNKDHIILBL, bool EKJBCDCBPGO = true);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OFKNJJMNNCO(GMJKJCNNJPE OBCIEJGBDKI);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ODHPCOBIODH(GMJKJCNNJPE BOPCIPDICHF, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IEOOECJHALP(GMJKJCNNJPE DLKCHPNFDJD, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BKOCGGIGHMP();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AMMHBEGKBJM(Func<GMJKJCNNJPE, bool> CNKCBEIIIFB);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HLPKKMIBJFP(GMJKJCNNJPE HPEDOOPINDA, HashSet<GMJKJCNNJPE> ADMCICDCKIO);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<GMJKJCNNJPE> KIOPKCNNPOP();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ELBIAOONLMK(GMJKJCNNJPE HPEDOOPINDA, [Out] FNBBBPMDJEA JEEIKHJONKP);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AHKGICIEDHJ(EDMLOPHELKC AHJILKLLLDE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool EDMLOPHELKC(LDLFMBNKOLF MPJOKOKILNG);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface LDLFMBNKOLF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	GMJKJCNNJPE BHMNKOFNJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LDLFMBNKOLF EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FNBBBPMDJEA DCKMCGAGEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool PLLIKAIBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OKKGPHLACID : OJONAANFIPN.CLMDPBEODHA
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPJLDPAJHCH(GMJKJCNNJPE PMKAGILCPKD, FNBBBPMDJEA FLFKBMMIINC);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMIAGJGPJPP(GMJKJCNNJPE PMKAGILCPKD, FNBBBPMDJEA FLFKBMMIINC);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHEGEKMLHIO(GMJKJCNNJPE PMKAGILCPKD, FNBBBPMDJEA FLFKBMMIINC);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AENJHAEIBEJ(GMJKJCNNJPE PMKAGILCPKD, FNBBBPMDJEA FLFKBMMIINC);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OKKGPHLACID Instantiate(Transform DNPKMJFBJBC);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKCGKDNFFIN();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CFCBOPHCGOD
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGGINNGCCML(Transform DNPKMJFBJBC, OKKGPHLACID HNCLNOINDPH);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKKGPHLACID FDIHCIFHCHE();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMPCMKEMPCK(OKKGPHLACID DGDNLGPMOPH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LAMIIFMLHIJ : HNAKFAGLLOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBPBGOACJAC(Guid ALJDGHENGFO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface CIHJNJAAODC
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEOFDCNGAFK(LDLFMBNKOLF OKGMGPBDICI);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGGINNGCCML(EKGKFCENFIF MJOHLJLDMNN, CFCBOPHCGOD JJJHKAELGHH);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EAOLFNJEDKC();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GJMPOJANGJH(LDLFMBNKOLF DAPLFFMCJKG);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCDIGCJNPMP(LDLFMBNKOLF JIENCEMLDAM);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KEPFELPLEFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class PIMGJDPFLDG : LDLFMBNKOLF
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BODEPLKMFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public FNBBBPMDJEA nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public PIMGJDPFLDG foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BODEPLKMFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6877B20", Offset = "0x6876120", VA = "0x186877B20")]
		internal bool MBIEEPMLPMJ(LDLFMBNKOLF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private FNBBBPMDJEA JEEIKHJONKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<PIMGJDPFLDG> ACNCGBCHAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private PIMGJDPFLDG GGIECEHFJFJ;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public FNBBBPMDJEA DCKMCGAGEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3893800", Offset = "0x3891E00", VA = "0x183893800", Slot = "6")]
		get
		{
			return default(FNBBBPMDJEA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x688A760", Offset = "0x6888D60", VA = "0x18688A760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private PIMGJDPFLDG HHMPHBNGMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x688A910", Offset = "0x6888F10", VA = "0x18688A910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public LDLFMBNKOLF EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GMJKJCNNJPE BHMNKOFNJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PLLIKAIBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x688A420", Offset = "0x6888A20", VA = "0x18688A420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HGNMEFGAPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x688A9F0", Offset = "0x6888FF0", VA = "0x18688A9F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected PIMGJDPFLDG FMGEJNFFGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x688A400", Offset = "0x6888A00", VA = "0x18688A400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x688AC90", Offset = "0x6889290", VA = "0x18688AC90")]
	public PIMGJDPFLDG(FNBBBPMDJEA GPHAFKFMEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x688A610", Offset = "0x6888C10", VA = "0x18688A610")]
	public PIMGJDPFLDG GAMMKDIBDLH(FNBBBPMDJEA IELPCMNHOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x688A790", Offset = "0x6888D90", VA = "0x18688A790")]
	public PIMGJDPFLDG JBENDDILPDF(FNBBBPMDJEA AIKPOJHOGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x688A430", Offset = "0x6888A30", VA = "0x18688A430")]
	public PIMGJDPFLDG GAGDAFIMOPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x688AA40", Offset = "0x6889040", VA = "0x18688AA40")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x688A350", Offset = "0x6888950", VA = "0x18688A350")]
	public PIMGJDPFLDG BGCKCJLCEEJ(FNBBBPMDJEA NAEADMGDGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x688A1F0", Offset = "0x68887F0", VA = "0x18688A1F0")]
	private static void AHKGICIEDHJ(PIMGJDPFLDG HNAJOJDHODE, EDMLOPHELKC DNEKMHCKHLJ, bool IJJIDJHDPDK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x688A1E0", Offset = "0x68887E0", VA = "0x18688A1E0", Slot = "9")]
	public void AHKGICIEDHJ(EDMLOPHELKC AHJILKLLLDE, bool OJLAKEOKPNL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x688AB90", Offset = "0x6889190", VA = "0x18688AB90")]
	public static PIMGJDPFLDG OBBMCBBNKNF(PIMGJDPFLDG HNAJOJDHODE, FNBBBPMDJEA BPDJAFNGHJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface GOJPIGHDFDG
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool NKABODLKMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OGPLEDGKMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<PFCAGLIFOHP> JKJCOKLPLPB;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<PFCAGLIFOHP> APAHHADGACM;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(BNKPODGGFGA MFNJBGPIIEN);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(GMJKJCNNJPE BOPCIPDICHF, GMJKJCNNJPE OJKMNCEMIPN, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(GMJKJCNNJPE DLKCHPNFDJD, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(FEDJAAAIKEC HKFLMLBBHEM, [Optional] PFCAGLIFOHP HIAKPCPGJJD);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, GOJPIGHDFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private BNKPODGGFGA MFNJBGPIIEN;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool NKABODLKMJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6884040", Offset = "0x6882640", VA = "0x186884040", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool OGPLEDGKMGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x68840A0", Offset = "0x68826A0", VA = "0x1868840A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PFCAGLIFOHP> JKJCOKLPLPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6883F90", Offset = "0x6882590", VA = "0x186883F90", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6884190", Offset = "0x6882790", VA = "0x186884190", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<PFCAGLIFOHP> APAHHADGACM
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6883EE0", Offset = "0x68824E0", VA = "0x186883EE0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x68840E0", Offset = "0x68826E0", VA = "0x1868840E0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x86CF10", Offset = "0x86B510", VA = "0x18086CF10", Slot = "19")]
		public void SetManager(BNKPODGGFGA MFNJBGPIIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6883EB0", Offset = "0x68824B0", VA = "0x186883EB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6882C30", Offset = "0x6881230", VA = "0x186882C30", Slot = "23")]
		public void RequestMasterConnectNodes(GMJKJCNNJPE MDHJBKHHBBL, int IIGENDCFMBH, GMJKJCNNJPE PMKAGILCPKD, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6882D60", Offset = "0x6881360", VA = "0x186882D60", Slot = "24")]
		public void RequestMasterDisconnectNode(GMJKJCNNJPE OBCIEJGBDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6882E20", Offset = "0x6881420", VA = "0x186882E20", Slot = "20")]
		public void RequestMasterModifyNode(GMJKJCNNJPE BOPCIPDICHF, GMJKJCNNJPE OJKMNCEMIPN, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6882F50", Offset = "0x6881550", VA = "0x186882F50", Slot = "21")]
		public void RequestMasterReparentNodes(GMJKJCNNJPE DLKCHPNFDJD, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6883080", Offset = "0x6881680", VA = "0x186883080", Slot = "25")]
		public void RequestMasterReparentToRoot(GMJKJCNNJPE DLKCHPNFDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6882B00", Offset = "0x6881100", VA = "0x186882B00", Slot = "22")]
		public void RequestDeserializeConnectableGraph(FEDJAAAIKEC HKFLMLBBHEM, [Optional] PFCAGLIFOHP HIAKPCPGJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6883460", Offset = "0x6881A60", VA = "0x186883460")]
		[GAEPMADMMMF]
		private void RpcMasterConnectNodes(GMJKJCNNJPE MDHJBKHHBBL, int IIGENDCFMBH, GMJKJCNNJPE PMKAGILCPKD, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6883720", Offset = "0x6881D20", VA = "0x186883720")]
		[GAEPMADMMMF]
		private void RpcMasterDisconnectNode(GMJKJCNNJPE OBCIEJGBDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6883A60", Offset = "0x6882060", VA = "0x186883A60")]
		[GAEPMADMMMF]
		private void RpcMasterReparentNodes(GMJKJCNNJPE DLKCHPNFDJD, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6883860", Offset = "0x6881E60", VA = "0x186883860")]
		[GAEPMADMMMF]
		private void RpcMasterModifyNode(GMJKJCNNJPE BOPCIPDICHF, GMJKJCNNJPE OJKMNCEMIPN, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6883250", Offset = "0x6881850", VA = "0x186883250")]
		[GAEPMADMMMF]
		private void RpcConnectNodes(GMJKJCNNJPE MDHJBKHHBBL, int IIGENDCFMBH, GMJKJCNNJPE PMKAGILCPKD, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI, LNGNBCIDPOB DLJMEHGDKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x68833D0", Offset = "0x68819D0", VA = "0x1868833D0")]
		[GAEPMADMMMF]
		private void RpcDisconnectNode(GMJKJCNNJPE OBCIEJGBDKI, LNGNBCIDPOB DLJMEHGDKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6883DB0", Offset = "0x68823B0", VA = "0x186883DB0")]
		[GAEPMADMMMF]
		private void RpcReparentNodes(GMJKJCNNJPE DLKCHPNFDJD, int BONNEGOHKON, GMJKJCNNJPE NAEADMGDGFI, int KOICKJKFAGF, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI, LNGNBCIDPOB DLJMEHGDKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6883CF0", Offset = "0x68822F0", VA = "0x186883CF0")]
		[GAEPMADMMMF]
		private void RpcModifyNode(GMJKJCNNJPE BOPCIPDICHF, int IIGENDCFMBH, int DHMCDDCFLFE, Vector3 GBKOFELPANE, Quaternion GHLONPJIMPI, LNGNBCIDPOB DLJMEHGDKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6883390", Offset = "0x6881990", VA = "0x186883390")]
		[GAEPMADMMMF]
		private void RpcDeserializeConnectableGraph(FEDJAAAIKEC MJOHLJLDMNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x87F310", Offset = "0x87D910", VA = "0x18087F310")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, OKKGPHLACID, OJONAANFIPN.CLMDPBEODHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6882710", Offset = "0x6880D10", VA = "0x186882710", Slot = "4")]
		private void MAEEAAPLKMK(GMJKJCNNJPE PMKAGILCPKD, FNBBBPMDJEA FLFKBMMIINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6882890", Offset = "0x6880E90", VA = "0x186882890", Slot = "5")]
		private void PFKPDJKHAJA(GMJKJCNNJPE PMKAGILCPKD, FNBBBPMDJEA FLFKBMMIINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6882340", Offset = "0x6880940", VA = "0x186882340", Slot = "6")]
		private void COOAMBADGFG(GMJKJCNNJPE PMKAGILCPKD, FNBBBPMDJEA FLFKBMMIINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x68824B0", Offset = "0x6880AB0", VA = "0x1868824B0", Slot = "7")]
		private void IIIHACIJFMF(GMJKJCNNJPE PMKAGILCPKD, FNBBBPMDJEA FLFKBMMIINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x68826A0", Offset = "0x6880CA0", VA = "0x1868826A0", Slot = "8")]
		private OKKGPHLACID JKPKKPOEECK(Transform DNPKMJFBJBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6882450", Offset = "0x6880A50", VA = "0x186882450", Slot = "9")]
		private void GLKKIMOPEIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KHDKHFMFMNL
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BD6A50", Offset = "0x2BD5050", VA = "0x182BD6A50")]
	public static MKNLHPJAEPE<T> FDDKBFDLPKP<T>(this DIIANKCHAHD OMDOLEEBJJJ)
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
