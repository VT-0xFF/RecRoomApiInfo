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
	public class LogRegistrationIndex : DHLIEKNFJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6097810", Offset = "0x6096410", VA = "0x186097810", Slot = "4")]
		public override void FAEDNEGPAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
	public class _AssemblyIndex : PHLPCMENMHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LDHNJOCMJPB bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private LDHNJOCMJPB bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6098AD0", Offset = "0x60976D0", VA = "0x186098AD0", Slot = "5")]
		public override void BMHMIKCNLDO(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6098B10", Offset = "0x6097710", VA = "0x186098B10")]
		private void CHPLFCKFEKA(ABPDLMJCFLP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6098C80", Offset = "0x6097880", VA = "0x186098C80")]
		private void IINCMBEFNLF(ABPDLMJCFLP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6098DF0", Offset = "0x60979F0", VA = "0x186098DF0", Slot = "6")]
		public override void LHKPJBJBOHH(ABPDLMJCFLP registry, [In] DPPIIBFLCBO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "8")]
		public override void CAHAKELCOOI(EJCABKCJHLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6099130", Offset = "0x6097D30", VA = "0x186099130")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class HLHHIDEOHLI : AIGMLGBDOHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class IGIOGGONPHD : IEnumerable<OFJKCILBDFK>, IEnumerable, IEnumerator<OFJKCILBDFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OFJKCILBDFK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private BEKECMPFECE localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BEKECMPFECE <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HLHHIDEOHLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HCEJACJAGCN <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GJOLOGJOFLE.ABMIELJKGJI <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private OFJKCILBDFK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
		[DebuggerHidden]
		public IGIOGGONPHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6094770", Offset = "0x6093370", VA = "0x186094770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60942B0", Offset = "0x6092EB0", VA = "0x1860942B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6094290", Offset = "0x6092E90", VA = "0x186094290")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6094720", Offset = "0x6093320", VA = "0x186094720", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6094670", Offset = "0x6093270", VA = "0x186094670", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OFJKCILBDFK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6094670", Offset = "0x6093270", VA = "0x186094670", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly HEENJBKIIAO MEEMOBPOBEN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HEENJBKIIAO OCJAEIFACKE;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly HEENJBKIIAO MNFLOMAFKPO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HEENJBKIIAO PIAMBMGMDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PABEKECGEMG LCGAHGDLPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LPGNIANKLPK PAMDJEAMGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private KOBHAGKKCOG DADEEGJCOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MHCGANMPMKE FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CHFFKLBHJIC NHLCBMFJOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly AJOBFGJHGJG CNNJJGDOONK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CPEAOGPNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C2220", Offset = "0x7C0E20", VA = "0x1807C2220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C00", Offset = "0x7C0800", VA = "0x1807C1C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<OFJKCILBDFK, OFJKCILBDFK> NHFMJAMPJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x608FD10", Offset = "0x608E910", VA = "0x18608FD10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60906F0", Offset = "0x608F2F0", VA = "0x1860906F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<OFJKCILBDFK, OFJKCILBDFK> MMLNHHGGIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60933D0", Offset = "0x6091FD0", VA = "0x1860933D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60923F0", Offset = "0x6090FF0", VA = "0x1860923F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<OFJKCILBDFK, OFJKCILBDFK, OFJKCILBDFK> PGNLMHHEAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60924A0", Offset = "0x60910A0", VA = "0x1860924A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6090EF0", Offset = "0x608FAF0", VA = "0x186090EF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6093940", Offset = "0x6092540", VA = "0x186093940")]
	public HLHHIDEOHLI(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6090830", Offset = "0x608F430", VA = "0x186090830", Slot = "11")]
	public void HAJAGMDCLHL(GameObject DNJHAKIPIPL, IIENDKGBPKB BLNJCLNOLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x608FDC0", Offset = "0x608E9C0", VA = "0x18608FDC0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60829F0", Offset = "0x60815F0", VA = "0x1860829F0", Slot = "21")]
	public bool GJILLNMPICP(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6090AA0", Offset = "0x608F6A0", VA = "0x186090AA0")]
	private void HJJNIKOMCCJ(BEKECMPFECE GCHEFNLBADE, BEKECMPFECE OFMAAJLOMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6091B40", Offset = "0x6090740", VA = "0x186091B40")]
	private void MBLKKMGGBEM(BEKECMPFECE GCHEFNLBADE, BEKECMPFECE ONPDNAJKJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x608F250", Offset = "0x608DE50", VA = "0x18608F250")]
	private void AKCIDOAHJNG(BEKECMPFECE GCHEFNLBADE, BEKECMPFECE ONPDNAJKJCC, BEKECMPFECE OFMAAJLOMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60916B0", Offset = "0x60902B0", VA = "0x1860916B0")]
	private void LMPFLBHFCGC(BEKECMPFECE GCHEFNLBADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "12")]
	public void BBEBOIIGBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6090180", Offset = "0x608ED80", VA = "0x186090180", Slot = "13")]
	public void FAEDNEGPAEK(OFJKCILBDFK OJONBJJAPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "14")]
	public void MKLHNKIFDAA(OFJKCILBDFK OJONBJJAPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60929F0", Offset = "0x60915F0", VA = "0x1860929F0", Slot = "16")]
	public void OFJFFFJEEBP(OFJKCILBDFK OJONBJJAPMK, OFJKCILBDFK PBPBFDLDPMJ, Vector3 FBFBHGAGOOB, Quaternion AMHIBJAFJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60928B0", Offset = "0x60914B0", VA = "0x1860928B0")]
	public void OFJFFFJEEBP(BEKECMPFECE MAEGJLGHFOA, BEKECMPFECE PBPBFDLDPMJ, Vector3 FBFBHGAGOOB, Quaternion AMHIBJAFJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60907A0", Offset = "0x608F3A0", VA = "0x1860907A0")]
	public void GNLCBPJOAGN(OFJKCILBDFK OJONBJJAPMK, float MPLHIABBNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6093280", Offset = "0x6091E80", VA = "0x186093280", Slot = "17")]
	public void PGDPJAELGBN(OFJKCILBDFK MLCIDMIGGKK, int BHOPCLOOAMH, OFJKCILBDFK FLKCMHBMNHG, int MNINIBADOPO, Vector3 FBFBHGAGOOB, Quaternion AMHIBJAFJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6090E40", Offset = "0x608FA40", VA = "0x186090E40")]
	private float KPDCLJKPAJJ(BEKECMPFECE MAEGJLGHFOA, BEKECMPFECE MJOMMKLGFIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6093150", Offset = "0x6091D50", VA = "0x186093150")]
	public void PGDPJAELGBN(BEKECMPFECE MAEGJLGHFOA, BEKECMPFECE MJOMMKLGFIJ, Vector3 FBFBHGAGOOB, Quaternion AMHIBJAFJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60930F0", Offset = "0x6091CF0", VA = "0x1860930F0")]
	public void PGDPJAELGBN(BEKECMPFECE MAEGJLGHFOA, BEKECMPFECE MJOMMKLGFIJ, Vector3 FBFBHGAGOOB, Quaternion AMHIBJAFJID, float MPLHIABBNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x608FBA0", Offset = "0x608E7A0", VA = "0x18608FBA0", Slot = "18")]
	public void DHKFAFKHACA(OFJKCILBDFK OJONBJJAPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6091420", Offset = "0x6090020", VA = "0x186091420")]
	public bool LJIDEDACODK(BEKECMPFECE OJMIDFGBOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60925B0", Offset = "0x60911B0", VA = "0x1860925B0", Slot = "15")]
	public void ODACJJOPDFH(OFJKCILBDFK OJONBJJAPMK, HashSet<OFJKCILBDFK> OPIJLCEFMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "19")]
	public NPPBIAIIDOF MILCJDHKGOM(bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "20")]
	public NPPBIAIIDOF PHDJJKIEHFL(HashSet<Guid> COMPKFLOHKL, bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x608F4D0", Offset = "0x608E0D0", VA = "0x18608F4D0", Slot = "22")]
	public void BDHKOKDICJP(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x608FB10", Offset = "0x608E710", VA = "0x18608FB10", Slot = "23")]
	public void CMGOJKMEEFC(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x608FB80", Offset = "0x608E780", VA = "0x18608FB80", Slot = "24")]
	public void DBENLGIBMHD(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6092090", Offset = "0x6090C90", VA = "0x186092090")]
	private void NDCMCEMLAHM(BEKECMPFECE MAEGJLGHFOA, BEKECMPFECE MJOMMKLGFIJ, Vector3 FBFBHGAGOOB, Quaternion AMHIBJAFJID, float MPLHIABBNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6092B50", Offset = "0x6091750", VA = "0x186092B50")]
	private void OJHDADJHLNK(BEKECMPFECE MAEGJLGHFOA, BEKECMPFECE AECJKOCMHDK, Vector3 FBFBHGAGOOB, Quaternion AMHIBJAFJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6093480", Offset = "0x6092080", VA = "0x186093480")]
	private void PIIJILCOOLH(BEKECMPFECE MAEGJLGHFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6092000", Offset = "0x6090C00", VA = "0x186092000")]
	[IteratorStateMachine(typeof(IGIOGGONPHD))]
	public IEnumerable<OFJKCILBDFK> MNCIEINDIHI(BEKECMPFECE OJMIDFGBOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6090FA0", Offset = "0x608FBA0", VA = "0x186090FA0")]
	internal OFJKCILBDFK LJFHCPFFECI(BEKECMPFECE OJMIDFGBOBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6090490", Offset = "0x608F090", VA = "0x186090490")]
	internal BEKECMPFECE FJMNOOLJBGK(OFJKCILBDFK OJONBJJAPMK)
	{
		return default(BEKECMPFECE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x608F540", Offset = "0x608E140", VA = "0x18608F540")]
	private bool BKOEICOLPLA(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6092550", Offset = "0x6091150", VA = "0x186092550")]
	private bool NOIJMMPDIAD(APGPNPNJJFJ MHHDCKCJJOL, [Out] OFJKCILBDFK MJOMMKLGFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60910E0", Offset = "0x608FCE0", VA = "0x1860910E0")]
	private OFJKCILBDFK LJFHCPFFECI(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6090CB0", Offset = "0x608F8B0", VA = "0x186090CB0")]
	private OFJKCILBDFK KGMGHONJLEM(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x608FFB0", Offset = "0x608EBB0", VA = "0x18608FFB0")]
	private OFJKCILBDFK EDLNALMIHAB(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6089570", Offset = "0x6088170", VA = "0x186089570")]
	private static Guid BELBGDJMAAN(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60927C0", Offset = "0x60913C0", VA = "0x1860927C0")]
	private string OECKPKFKLMN(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6091D60", Offset = "0x6090960", VA = "0x186091D60")]
	private void MFAKMEHIAKP(OFJKCILBDFK MAEGJLGHFOA, OFJKCILBDFK AECJKOCMHDK, RigidTransform MMAIJNOAOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6090560", Offset = "0x608F160", VA = "0x186090560")]
	private void FOJHFCJEKBO(OFJKCILBDFK AECJKOCMHDK, OFJKCILBDFK MAEGJLGHFOA, RigidTransform MMAIJNOAOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6090120", Offset = "0x608ED20", VA = "0x186090120")]
	private void ELBLFFNHGCE(OFJKCILBDFK NMBNKFIIGPI, OFJKCILBDFK MAEGJLGHFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6092F60", Offset = "0x6091B60", VA = "0x186092F60")]
	private void PDHIGAKIKGJ(OFJKCILBDFK MAEGJLGHFOA, OFJKCILBDFK MJOMMKLGFIJ, RigidTransform MMAIJNOAOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6091EF0", Offset = "0x6090AF0", VA = "0x186091EF0")]
	private void MMNNGKBDNDH(BEKECMPFECE OJMIDFGBOBJ, OFJKCILBDFK OJONBJJAPMK, BEKECMPFECE ONPDNAJKJCC, BEKECMPFECE OFMAAJLOMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60934F0", Offset = "0x60920F0", VA = "0x1860934F0")]
	private void POAOEJIBICD(BEKECMPFECE OJMIDFGBOBJ, OFJKCILBDFK OJONBJJAPMK, OFJKCILBDFK NMKGGNKAHNC, OFJKCILBDFK IDPPDAEHKHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MKEOPANFILP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class ANANMAFGHOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OJEGDOKHPNO container;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public ANANMAFGHOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6083F20", Offset = "0x6082B20", VA = "0x186083F20")]
		internal HLHHIDEOHLI GBFJIGJCHKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6097A20", Offset = "0x6096620", VA = "0x186097A20")]
	public static void ADFKCGOHHIF(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6097BA0", Offset = "0x60967A0", VA = "0x186097BA0")]
	public static void JABKMINACDA(OJEGDOKHPNO JEAKPHJODOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HBJLJKMCGCM : KIGELAMIDJB, GADHNDAPHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HLHHIDEOHLI JIOAGJCBFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly LLNIHCOMFKK AAHCIPDCPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly AFABNLGEKOF FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly APGKGBGLCOM[] BCIGDOHOEOH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BEKECMPFECE GJILOKJAIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(BEKECMPFECE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OFJKCILBDFK GEMELPIECPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x608DE40", Offset = "0x608CA40", VA = "0x18608DE40", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OFJKCILBDFK BMJBJGJJFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x608CFD0", Offset = "0x608BBD0", VA = "0x18608CFD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 MGFAAELPMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x608D170", Offset = "0x608BD70", VA = "0x18608D170", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion EFIKHDBNJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x608D0C0", Offset = "0x608BCC0", VA = "0x18608D0C0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool HCNEPJHDCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x608CA20", Offset = "0x608B620", VA = "0x18608CA20", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<OFJKCILBDFK> DLLCPCBKLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x608C710", Offset = "0x608B310", VA = "0x18608C710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool DFGPFHJHIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x878320", Offset = "0x876F20", VA = "0x180878320", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x878440", Offset = "0x877040", VA = "0x180878440", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x608E050", Offset = "0x608CC50", VA = "0x18608E050", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject JPLPKEPDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x22AB160", Offset = "0x22A9D60", VA = "0x1822AB160", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x608DD70", Offset = "0x608C970", VA = "0x18608DD70", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid DKGHKCDEGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x608DEA0", Offset = "0x608CAA0", VA = "0x18608DEA0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NBMODJIIKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x608DF80", Offset = "0x608CB80", VA = "0x18608DF80", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool NKOBJDNHCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool CLADKKCIKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x608D6F0", Offset = "0x608C2F0", VA = "0x18608D6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event FJPNFFHGCAJ GGGADJGPDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x608CED0", Offset = "0x608BAD0", VA = "0x18608CED0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x608C340", Offset = "0x608AF40", VA = "0x18608C340", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event FJPNFFHGCAJ OCDHNIMLJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x608CE70", Offset = "0x608BA70", VA = "0x18608CE70", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x608D740", Offset = "0x608C340", VA = "0x18608D740", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FJPNFFHGCAJ FKJBJAPFAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x608CB30", Offset = "0x608B730", VA = "0x18608CB30", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x608CBE0", Offset = "0x608B7E0", VA = "0x18608CBE0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event OLHMCBBNHOH KEICOLNONPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x608CA90", Offset = "0x608B690", VA = "0x18608CA90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x608D7A0", Offset = "0x608C3A0", VA = "0x18608D7A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x608DC70", Offset = "0x608C870", VA = "0x18608DC70")]
	public HBJLJKMCGCM(BEKECMPFECE HKEBHFPJOKD, RigidbodyEx OMNMDMGCEIK, LLNIHCOMFKK AAHCIPDCPEK, APGKGBGLCOM[] BCIGDOHOEOH, AFABNLGEKOF FOHLLAJCPJF, AIGMLGBDOHJ JIOAGJCBFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x608CC40", Offset = "0x608B840", VA = "0x18608CC40", Slot = "19")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "21")]
	public void GHHKJFHJIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EFDAE0", Offset = "0x5EFC6E0", VA = "0x185EFDAE0", Slot = "22")]
	public void IFMBHDFLGDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x608CB90", Offset = "0x608B790", VA = "0x18608CB90", Slot = "20")]
	public void GJNOBIEAGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x608D1D0", Offset = "0x608BDD0", VA = "0x18608D1D0", Slot = "25")]
	public void LBBAPKMPBCM(int GKHFAJMFBDI, OFJKCILBDFK FLKCMHBMNHG, int NNHADHCGMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x608C3A0", Offset = "0x608AFA0", VA = "0x18608C3A0", Slot = "26")]
	public void BKFOMDIIFOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x608C740", Offset = "0x608B340", VA = "0x18608C740", Slot = "27")]
	public void EPBAKFBECML(int GKHFAJMFBDI, OFJKCILBDFK MLCIDMIGGKK, int KILBKEFNGNJ, [Optional] Vector3? BGKFEFOFKPN, [Optional] Quaternion? FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x608D040", Offset = "0x608BC40", VA = "0x18608D040", Slot = "28")]
	public void IKBJCCFPLFN(OFJKCILBDFK MLCIDMIGGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x608D840", Offset = "0x608C440", VA = "0x18608D840", Slot = "31")]
	public void PHIALCCBJDA(Vector3 LLJHDIHPPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x608D3E0", Offset = "0x608BFE0", VA = "0x18608D3E0", Slot = "29")]
	public void NBHMLPGMMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x608C470", Offset = "0x608B070", VA = "0x18608C470", Slot = "30")]
	public void CDKDPADLMHH(int PMIDLPOCCEE, Vector3 IMBPOLOMLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x608CDA0", Offset = "0x608B9A0", VA = "0x18608CDA0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int GKHFAJMFBDI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x608CC70", Offset = "0x608B870", VA = "0x18608CC70", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int GKHFAJMFBDI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x83A4F0", Offset = "0x8390F0", VA = "0x18083A4F0", Slot = "42")]
	public Color GetConnectionSlotColor(int GKHFAJMFBDI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x608C670", Offset = "0x608B270", VA = "0x18608C670", Slot = "43")]
	public bool CanConnectTo(int GKHFAJMFBDI, OFJKCILBDFK DDOLKDAMMKI, int IMLLOLKOEAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "44")]
	public void ParentChanged(int GKHFAJMFBDI, OFJKCILBDFK HLMLPGJMJHI, int ABKGDBHCACD, Vector3 NEMANILOAFC, Quaternion GINFDIICCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "45")]
	public void ChildAdded(int GKHFAJMFBDI, OFJKCILBDFK OHFNMGKMOCF, int HGPKFEBKNDF, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "46")]
	public void ChildRemoved(int GKHFAJMFBDI, OFJKCILBDFK HHNIDHLMNPH, int HALFOLIAFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "47")]
	public void ConnectionModified(int GKHFAJMFBDI, OFJKCILBDFK FLKCMHBMNHG, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x608DC50", Offset = "0x608C850", VA = "0x18608DC50", Slot = "48")]
	public void RootChanged(OFJKCILBDFK HKEBPAFMACC, OFJKCILBDFK OOANAKFBLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x608CF80", Offset = "0x608BB80", VA = "0x18608CF80", Slot = "23")]
	public void IHJCDBNKFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x608D120", Offset = "0x608BD20", VA = "0x18608D120", Slot = "24")]
	public void KJHGLJMDIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x608CF30", Offset = "0x608BB30", VA = "0x18608CF30")]
	private void HMIMPICJMHC(bool NOMEIELDAFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HPFMEPGDOBP(typeof(AJDBEKKJPHB), new string[] { })]
public class HJMPFODIECL : AJDBEKKJPHB, CODHFNHPPCE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JEENJLDHFHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public HJMPFODIECL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public GJOLOGJOFLE localIds;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JEENJLDHFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6094970", Offset = "0x6093570", VA = "0x186094970")]
		internal void AAFAFNLPOMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[MGKGBPDFBHO]
	private MOEKMNKHBOJ CHJILIBAEBO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object MKILBPFOMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x608F100", Offset = "0x608DD00", VA = "0x18608F100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x608F190", Offset = "0x608DD90", VA = "0x18608F190", Slot = "6")]
	public void InitReferences(FEPHIFPIELB CNNJJGDOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x608EF90", Offset = "0x608DB90", VA = "0x18608EF90", Slot = "5")]
	public void IDAGAFMEHFH(GJOLOGJOFLE JOPELOINCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public HJMPFODIECL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[HPFMEPGDOBP(typeof(AIGMLGBDOHJ), new string[] { "Ignore", "Mock" })]
public class EGJGAOJDFPC : AIGMLGBDOHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CPEAOGPNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<OFJKCILBDFK, OFJKCILBDFK> NHFMJAMPJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60840D0", Offset = "0x6082CD0", VA = "0x1860840D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6084180", Offset = "0x6082D80", VA = "0x186084180", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<OFJKCILBDFK, OFJKCILBDFK> MMLNHHGGIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6084440", Offset = "0x6083040", VA = "0x186084440", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60842E0", Offset = "0x6082EE0", VA = "0x1860842E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<OFJKCILBDFK, OFJKCILBDFK, OFJKCILBDFK> PGNLMHHEAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6084390", Offset = "0x6082F90", VA = "0x186084390", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6084230", Offset = "0x6082E30", VA = "0x186084230", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "11")]
	public void HAJAGMDCLHL(GameObject DNJHAKIPIPL, IIENDKGBPKB BLNJCLNOLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "12")]
	public void BBEBOIIGBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "13")]
	public void FAEDNEGPAEK(OFJKCILBDFK OJONBJJAPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "14")]
	public void MKLHNKIFDAA(OFJKCILBDFK OJONBJJAPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "15")]
	public void ODACJJOPDFH(OFJKCILBDFK OJONBJJAPMK, HashSet<OFJKCILBDFK> OPIJLCEFMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "16")]
	public void OFJFFFJEEBP(OFJKCILBDFK OJONBJJAPMK, OFJKCILBDFK PBPBFDLDPMJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "17")]
	public void PGDPJAELGBN(OFJKCILBDFK OJONBJJAPMK, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "18")]
	public void DHKFAFKHACA(OFJKCILBDFK OJONBJJAPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "19")]
	public NPPBIAIIDOF MILCJDHKGOM(bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "20")]
	public NPPBIAIIDOF PHDJJKIEHFL(HashSet<Guid> COMPKFLOHKL, bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "21")]
	public bool GJILLNMPICP(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "22")]
	public void BDHKOKDICJP(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "23")]
	public void CMGOJKMEEFC(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "24")]
	public void DBENLGIBMHD(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public EGJGAOJDFPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OFJKCILBDFK : GADHNDAPHMF, IEquatable<OFJKCILBDFK>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GADHNDAPHMF
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OFJKCILBDFK GEMELPIECPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GameObject JPLPKEPDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Guid DKGHKCDEGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int NBMODJIIKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	BEKECMPFECE GJILOKJAIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NKOBJDNHCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int GKHFAJMFBDI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int GKHFAJMFBDI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int GKHFAJMFBDI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int GKHFAJMFBDI, OFJKCILBDFK DDOLKDAMMKI, int NJDKJLHOLON);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int GKHFAJMFBDI, OFJKCILBDFK HLMLPGJMJHI, int ABKGDBHCACD, Vector3 NEMANILOAFC, Quaternion GINFDIICCPA);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int GKHFAJMFBDI, OFJKCILBDFK OHFNMGKMOCF, int HGPKFEBKNDF, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int GKHFAJMFBDI, OFJKCILBDFK HHNIDHLMNPH, int HALFOLIAFLL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int GKHFAJMFBDI, OFJKCILBDFK FLKCMHBMNHG, int GPIKGHCICIB, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(OFJKCILBDFK HKEBPAFMACC, OFJKCILBDFK OOANAKFBLKG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DGEMLDNOGCP(KHAPMDLCPBB.OMRoom)]
public interface AIGMLGBDOHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CPEAOGPNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<OFJKCILBDFK, OFJKCILBDFK> NHFMJAMPJJF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<OFJKCILBDFK, OFJKCILBDFK> MMLNHHGGIFG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<OFJKCILBDFK, OFJKCILBDFK, OFJKCILBDFK> PGNLMHHEAPC;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HAJAGMDCLHL(GameObject DNJHAKIPIPL, IIENDKGBPKB BLNJCLNOLON);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BBEBOIIGBMN();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FAEDNEGPAEK(OFJKCILBDFK OJONBJJAPMK);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MKLHNKIFDAA(OFJKCILBDFK OJONBJJAPMK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ODACJJOPDFH(OFJKCILBDFK OJONBJJAPMK, HashSet<OFJKCILBDFK> OPIJLCEFMPF);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OFJFFFJEEBP(OFJKCILBDFK OJONBJJAPMK, OFJKCILBDFK PBPBFDLDPMJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PGDPJAELGBN(OFJKCILBDFK OJONBJJAPMK, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DHKFAFKHACA(OFJKCILBDFK OJONBJJAPMK);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NPPBIAIIDOF MILCJDHKGOM(bool ANANEJNJPHG);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NPPBIAIIDOF PHDJJKIEHFL(HashSet<Guid> COMPKFLOHKL, bool ANANEJNJPHG);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GJILLNMPICP(APGPNPNJJFJ MHHDCKCJJOL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BDHKOKDICJP(NPPBIAIIDOF IKOAHIFGOIC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CMGOJKMEEFC(NPPBIAIIDOF IKOAHIFGOIC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DBENLGIBMHD(NPPBIAIIDOF IKOAHIFGOIC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MHCGANMPMKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GNDLLJFJGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OFJKCILBDFK EDLNALMIHAB(int BOPHLKCCOCP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OFJKCILBDFK KGMGHONJLEM(Guid FIMPBNJKHOA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LOBAEMOONKL(OFJKCILBDFK OJONBJJAPMK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MNEDACENDLH();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EMFLLCLIDLF(OFJKCILBDFK AAHCIPDCPEK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DGEMLDNOGCP(KHAPMDLCPBB.Application)]
public interface AFABNLGEKOF
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLADKKCIKIH(LLNIHCOMFKK AAHCIPDCPEK);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OGNDJMALKLL(LLNIHCOMFKK AAHCIPDCPEK);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string JGBKJDOILKM(LLNIHCOMFKK AAHCIPDCPEK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid LJBBCPKEBCF(LLNIHCOMFKK AAHCIPDCPEK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NGBFALLKGLE(LLNIHCOMFKK AAHCIPDCPEK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHJGPECHHEJ(LLNIHCOMFKK AAHCIPDCPEK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void FJPNFFHGCAJ(OFJKCILBDFK MLCIDMIGGKK, int BJNBCNCBKDF, OFJKCILBDFK FLKCMHBMNHG, int HKOEMHANFPD, [Optional] Vector3? BGKFEFOFKPN, [Optional] Quaternion? FLINMEACHBH);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void OLHMCBBNHOH(OFJKCILBDFK HKEBPAFMACC, OFJKCILBDFK OOANAKFBLKG);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LLNIHCOMFKK : OFJKCILBDFK, GADHNDAPHMF, IEquatable<OFJKCILBDFK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KIGELAMIDJB : GADHNDAPHMF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	OFJKCILBDFK BMJBJGJJFPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IEnumerable<OFJKCILBDFK> DLLCPCBKLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Vector3 MGFAAELPMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	Quaternion EFIKHDBNJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HCNEPJHDCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool DFGPFHJHIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event FJPNFFHGCAJ GGGADJGPDPA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event FJPNFFHGCAJ OCDHNIMLJGH;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event FJPNFFHGCAJ FKJBJAPFAPN;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event OLHMCBBNHOH KEICOLNONPI;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GOCGJIABMDK();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GJNOBIEAGDP();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GHHKJFHJIBI();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IFMBHDFLGDO();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IHJCDBNKFEB();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KJHGLJMDIPC();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LBBAPKMPBCM(int GKHFAJMFBDI, OFJKCILBDFK FLKCMHBMNHG, int NNHADHCGMIJ);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BKFOMDIIFOK();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EPBAKFBECML(int GKHFAJMFBDI, OFJKCILBDFK MLCIDMIGGKK, int KILBKEFNGNJ, [Optional] Vector3? BGKFEFOFKPN, [Optional] Quaternion? FLINMEACHBH);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IKBJCCFPLFN(OFJKCILBDFK MLCIDMIGGKK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NBHMLPGMMCD();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CDKDPADLMHH(int PMIDLPOCCEE, Vector3 IMBPOLOMLBB);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PHIALCCBJDA(Vector3 LLJHDIHPPPL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface APGKGBGLCOM
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 ONLFOABMILP
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
public interface IIENDKGBPKB
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool PIHHCCICGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HDGNNOLBIEP OCDPGLCCBDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, IIENDKGBPKB
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
			[Cpp2IlInjected.Address(RVA = "0x82E0E0", Offset = "0x82CCE0", VA = "0x18082E0E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public HDGNNOLBIEP LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6083FD0", Offset = "0x6082BD0", VA = "0x186083FD0")]
		public static ConnectableConfigData LHBMNJEBMCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6084080", Offset = "0x6082C80", VA = "0x186084080")]
		public ConnectableConfigData(LegacyConnectableLinkVisual KBBHBJODOFA, bool BCPMIHFDLJC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KAPHPIDHFCG : IEquatable<KAPHPIDHFCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public OFJKCILBDFK OJONBJJAPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int GALIFHHHMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int GPIKGHCICIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 BGKFEFOFKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion FLINMEACHBH;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6095130", Offset = "0x6093D30", VA = "0x186095130")]
	public KAPHPIDHFCG(OFJKCILBDFK OJONBJJAPMK, int GALIFHHHMNP, int GPIKGHCICIB, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6095220", Offset = "0x6093E20", VA = "0x186095220")]
	public KAPHPIDHFCG(OFJKCILBDFK OJONBJJAPMK, int GALIFHHHMNP, int GPIKGHCICIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6095190", Offset = "0x6093D90", VA = "0x186095190")]
	public KAPHPIDHFCG(OFJKCILBDFK OJONBJJAPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6094CC0", Offset = "0x60938C0", VA = "0x186094CC0", Slot = "4")]
	public bool Equals(KAPHPIDHFCG NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6094D70", Offset = "0x6093970", VA = "0x186094D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class NDAODMDNCBF : CCHLCKLPHIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform NBNNMCCMOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private HDGNNOLBIEP BPLGJIPFECK;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7B10", Offset = "0x5BA6710", VA = "0x185BA7B10", Slot = "4")]
	public void HAJAGMDCLHL(Transform NBNNMCCMOPL, HDGNNOLBIEP BPLGJIPFECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6097BF0", Offset = "0x60967F0", VA = "0x186097BF0", Slot = "5")]
	public HDGNNOLBIEP DNKMODMHNHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6097CC0", Offset = "0x60968C0", VA = "0x186097CC0", Slot = "6")]
	public void GBCDOMMAMMC(HDGNNOLBIEP CDPMAILGHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NDAODMDNCBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class FFNLGFOMNHM : IDisposable, CBBEDCONCCA
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PCDFGKOFPFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OFJKCILBDFK oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public OFJKCILBDFK newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PCDFGKOFPFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6098970", Offset = "0x6097570", VA = "0x186098970")]
		internal bool MOFGKKONGIL(KAHIJDNGCHM node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly HJCJMHCOJPJ GNLDGIECHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private PPBLNACGKFG IDAHFJIPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private JGLAPHJPGKE KPMEDAIGLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool BCPMIHFDLJC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public KAHIJDNGCHM IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6084B00", Offset = "0x6083700", VA = "0x186084B00")]
	public bool PJIKMFDBKBN([In] MFFJAMEOHLO KOMCCCIEHEA, bool IDMKAHLCLNP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60876A0", Offset = "0x60862A0", VA = "0x1860876A0")]
	private bool NGBONEJLLGL([In] MFFJAMEOHLO KOMCCCIEHEA, bool IDMKAHLCLNP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6089150", Offset = "0x6087D50", VA = "0x186089150")]
	public FFNLGFOMNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6085F80", Offset = "0x6084B80", VA = "0x186085F80", Slot = "5")]
	public void HAJAGMDCLHL(AIGMLGBDOHJ DFCFBMIMDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6086FE0", Offset = "0x6085BE0", VA = "0x186086FE0", Slot = "17")]
	public void MIDMJDCGPML(JHGMICCNFKC NLOLPKLGIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6086010", Offset = "0x6084C10", VA = "0x186086010", Slot = "12")]
	public void HHHHLFEDNIA(Func<OFJKCILBDFK, bool> MOKPDBDBLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6086020", Offset = "0x6084C20", VA = "0x186086020")]
	private void HHHHLFEDNIA(HJCJMHCOJPJ FJKJNIMGBPD, Func<OFJKCILBDFK, bool> MOKPDBDBLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6088270", Offset = "0x6086E70", VA = "0x186088270", Slot = "11")]
	public void OHJKEFPGAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60847E0", Offset = "0x60833E0", VA = "0x1860847E0", Slot = "8")]
	public bool BFFLLILKINB(OFJKCILBDFK FNEPIKHMNMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6085610", Offset = "0x6084210", VA = "0x186085610")]
	private bool FJBKBNBHGEM(OFJKCILBDFK HLBKLEMIOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60844F0", Offset = "0x60830F0", VA = "0x1860844F0")]
	private static bool ABFOIHBPLCO(OFJKCILBDFK HLBKLEMIOBJ, HJCJMHCOJPJ CAFOFLOEJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60868D0", Offset = "0x60854D0", VA = "0x1860868D0")]
	private void LCKPFPKCJPC(Transform AAHAOCLBIPJ, HJCJMHCOJPJ LJLICCAPICA, HJCJMHCOJPJ[] HGHINMEJEMB, OFJKCILBDFK CCKEOJHMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60849B0", Offset = "0x60835B0", VA = "0x1860849B0")]
	private KAPHPIDHFCG BLMDHGNNLGI(Transform MOOJLECKLPJ, KAPHPIDHFCG FJLMEJNMKCH)
	{
		return default(KAPHPIDHFCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6086CC0", Offset = "0x60858C0", VA = "0x186086CC0")]
	private static bool LKCGHCGBAFE(HJCJMHCOJPJ CAFOFLOEJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6086720", Offset = "0x6085320", VA = "0x186086720")]
	private string JGBKJDOILKM(OFJKCILBDFK OJONBJJAPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6087630", Offset = "0x6086230", VA = "0x186087630")]
	private string NGBFALLKGLE(OFJKCILBDFK OJONBJJAPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6087010", Offset = "0x6085C10", VA = "0x186087010")]
	private void NBBCPDFKNAM([In] MFFJAMEOHLO KOMCCCIEHEA, bool DHFBKAPIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6085210", Offset = "0x6083E10", VA = "0x186085210")]
	private void EHAHODDKHIK(OFJKCILBDFK MAEGJLGHFOA, bool DHFBKAPIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6088290", Offset = "0x6086E90", VA = "0x186088290")]
	private void PAFKLKKAELE(OFJKCILBDFK DLGPOADELKP, int KILBKEFNGNJ, OFJKCILBDFK AECJKOCMHDK, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH, bool DHFBKAPIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6088940", Offset = "0x6087540", VA = "0x186088940")]
	private void PHFOJPCDHJL(OFJKCILBDFK GNHGMEPLPAO, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH, bool APJGLOPMEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6088860", Offset = "0x6087460", VA = "0x186088860", Slot = "9")]
	public bool PEHHKHKEJNI(OFJKCILBDFK GNHGMEPLPAO, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60863E0", Offset = "0x6084FE0", VA = "0x1860863E0")]
	private bool ICAFOIMKIFE(OFJKCILBDFK GNHGMEPLPAO, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6085E00", Offset = "0x6084A00", VA = "0x186085E00")]
	private static void GOPHOLFCKDB(OFJKCILBDFK GNHGMEPLPAO, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH, HJCJMHCOJPJ IJDFDHEECOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6086EC0", Offset = "0x6085AC0", VA = "0x186086EC0")]
	private void MFAKMEHIAKP(OFJKCILBDFK DLGPOADELKP, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6086860", Offset = "0x6085460", VA = "0x186086860")]
	private void KMHBOICDIMJ(HJCJMHCOJPJ FJKJNIMGBPD, OFJKCILBDFK NMKGGNKAHNC, OFJKCILBDFK IDPPDAEHKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60867F0", Offset = "0x60853F0", VA = "0x1860867F0")]
	private void KMHBOICDIMJ(OFJKCILBDFK OJONBJJAPMK, OFJKCILBDFK NMKGGNKAHNC, OFJKCILBDFK IDPPDAEHKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6088F40", Offset = "0x6087B40", VA = "0x186088F40")]
	private void POAOEJIBICD(OFJKCILBDFK OJONBJJAPMK, OFJKCILBDFK NMKGGNKAHNC, OFJKCILBDFK IDPPDAEHKHE, bool LHEAJHFCFEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6088FB0", Offset = "0x6087BB0", VA = "0x186088FB0")]
	private void POAOEJIBICD(HJCJMHCOJPJ EBCHPMPLBLG, OFJKCILBDFK CCKEOJHMEOA, OFJKCILBDFK OOANAKFBLKG, bool LHEAJHFCFEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6085CE0", Offset = "0x60848E0", VA = "0x186085CE0")]
	private void FOJHFCJEKBO(OFJKCILBDFK MAEGJLGHFOA, int KILBKEFNGNJ, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x60853E0", Offset = "0x6083FE0", VA = "0x1860853E0")]
	private void ELBLFFNHGCE(KAHIJDNGCHM MJOMMKLGFIJ, KAHIJDNGCHM JNNAPOIHNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6087D60", Offset = "0x6086960", VA = "0x186087D60", Slot = "18")]
	public OFJKCILBDFK OAMALNLHDKG(OFJKCILBDFK OJONBJJAPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6087EC0", Offset = "0x6086AC0", VA = "0x186087EC0", Slot = "13")]
	public void ODACJJOPDFH(OFJKCILBDFK OJONBJJAPMK, HashSet<OFJKCILBDFK> OMCHCMOKLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60845A0", Offset = "0x60831A0", VA = "0x1860845A0", Slot = "14")]
	public List<OFJKCILBDFK> ALFJGKEGMGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6086310", Offset = "0x6084F10", VA = "0x186086310")]
	protected KAHIJDNGCHM HOIKNPBFHNA(KAHIJDNGCHM FJKJNIMGBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60890B0", Offset = "0x6087CB0", VA = "0x1860890B0")]
	protected HJCJMHCOJPJ[] POPNLHEDCJI(HJCJMHCOJPJ CAFOFLOEJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6086610", Offset = "0x6085210", VA = "0x186086610")]
	protected bool IJJDJLPOBFA(OFJKCILBDFK OJONBJJAPMK, [Out] HJCJMHCOJPJ FJKJNIMGBPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x60850E0", Offset = "0x6083CE0", VA = "0x1860850E0", Slot = "15")]
	public bool EFEPOIBBADG(OFJKCILBDFK OJONBJJAPMK, [Out] KAPHPIDHFCG HNOFFALPOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6086E80", Offset = "0x6085A80", VA = "0x186086E80")]
	protected HJCJMHCOJPJ MAGPKILBAOB(KAPHPIDHFCG PKIGMNLLIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6087C70", Offset = "0x6086870", VA = "0x186087C70", Slot = "10")]
	public bool NGPFNNENJDC(OFJKCILBDFK DLGPOADELKP, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6084B50", Offset = "0x6083750", VA = "0x186084B50")]
	private bool EEMHLILCOND(OFJKCILBDFK DLGPOADELKP, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6085540", Offset = "0x6084140", VA = "0x186085540")]
	private static bool FIHJOMKGNJG(HJCJMHCOJPJ FKAEGKPCKFD, KAPHPIDHFCG CNMNHEAECAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6084B00", Offset = "0x6083700", VA = "0x186084B00", Slot = "7")]
	private bool DNPNNCPHFJG([In] MFFJAMEOHLO KOMCCCIEHEA, bool IDMKAHLCLNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class ACKLEHJOPAP : AIGMLGBDOHJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly OJEGDOKHPNO JEAKPHJODOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly JGLAPHJPGKE KPMEDAIGLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly KIIPEJHFAAE GBDBIKFDGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly FMPFGOELOLP NLEBPDGGGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly CBBEDCONCCA IKOAHIFGOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal ONFECBPFPHI FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal OBFPCNEKAAM GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal PPBLNACGKFG AIOBMDFFLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool BCPMIHFDLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool EJJPBDHBMAK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool AGGGMMJEFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x17407A0", Offset = "0x173F3A0", VA = "0x1817407A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1740790", Offset = "0x173F390", VA = "0x181740790")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CPEAOGPNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x17407B0", Offset = "0x173F3B0", VA = "0x1817407B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x17407D0", Offset = "0x173F3D0", VA = "0x1817407D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<OFJKCILBDFK, OFJKCILBDFK> NHFMJAMPJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6082690", Offset = "0x6081290", VA = "0x186082690", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6082990", Offset = "0x6081590", VA = "0x186082990", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<OFJKCILBDFK, OFJKCILBDFK> MMLNHHGGIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6083AD0", Offset = "0x60826D0", VA = "0x186083AD0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6083460", Offset = "0x6082060", VA = "0x186083460", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<OFJKCILBDFK, OFJKCILBDFK, OFJKCILBDFK> PGNLMHHEAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x60834C0", Offset = "0x60820C0", VA = "0x1860834C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6083320", Offset = "0x6081F20", VA = "0x186083320", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6083B30", Offset = "0x6082730", VA = "0x186083B30")]
	public ACKLEHJOPAP(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6082A00", Offset = "0x6081600", VA = "0x186082A00", Slot = "11")]
	public void HAJAGMDCLHL(GameObject DNJHAKIPIPL, IIENDKGBPKB BLNJCLNOLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x60826F0", Offset = "0x60812F0", VA = "0x1860826F0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x60822F0", Offset = "0x6080EF0", VA = "0x1860822F0", Slot = "12")]
	public void BBEBOIIGBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6082970", Offset = "0x6081570", VA = "0x186082970", Slot = "13")]
	public void FAEDNEGPAEK(OFJKCILBDFK OJONBJJAPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6082290", Offset = "0x6080E90", VA = "0x186082290", Slot = "14")]
	public void MKLHNKIFDAA(OFJKCILBDFK OJONBJJAPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x60829F0", Offset = "0x60815F0", VA = "0x1860829F0", Slot = "21")]
	public bool GJILLNMPICP(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x60833A0", Offset = "0x6081FA0", VA = "0x1860833A0")]
	internal bool NGBONEJLLGL([In] MFFJAMEOHLO KOMCCCIEHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6082790", Offset = "0x6081390", VA = "0x186082790")]
	internal bool EEMHLILCOND([In] MFFJAMEOHLO KOMCCCIEHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x60832C0", Offset = "0x6081EC0", VA = "0x1860832C0")]
	internal bool LHJFGPPCPFM([In] MFFJAMEOHLO KOMCCCIEHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6082820", Offset = "0x6081420", VA = "0x186082820")]
	internal bool EPNOGGHPEML([In] MFFJAMEOHLO KOMCCCIEHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x60830E0", Offset = "0x6081CE0", VA = "0x1860830E0")]
	internal void KGLBPLBEKJD(OFJKCILBDFK OJONBJJAPMK, int LILOJDAGHML, bool IDMKAHLCLNP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6082290", Offset = "0x6080E90", VA = "0x186082290")]
	internal bool AGONIGBAPIP(OFJKCILBDFK AIHAJGNGAMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6083830", Offset = "0x6082430", VA = "0x186083830")]
	internal bool PCNPFKEPFJI(OFJKCILBDFK GNHGMEPLPAO, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6083520", Offset = "0x6082120", VA = "0x186083520", Slot = "15")]
	public void ODACJJOPDFH(OFJKCILBDFK OJONBJJAPMK, HashSet<OFJKCILBDFK> OPIJLCEFMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6083620", Offset = "0x6082220", VA = "0x186083620", Slot = "16")]
	public void OFJFFFJEEBP(OFJKCILBDFK GNHGMEPLPAO, OFJKCILBDFK PBPBFDLDPMJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6083970", Offset = "0x6082570", VA = "0x186083970", Slot = "17")]
	public void PGDPJAELGBN(OFJKCILBDFK DLGPOADELKP, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x60824C0", Offset = "0x60810C0", VA = "0x1860824C0", Slot = "18")]
	public void DHKFAFKHACA(OFJKCILBDFK DLGPOADELKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6082FD0", Offset = "0x6081BD0", VA = "0x186082FD0")]
	public void HFFCOMNNLEA([Optional] PGGNJPENPEC ILLIJBLIMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6082340", Offset = "0x6080F40", VA = "0x186082340", Slot = "22")]
	public void BDHKOKDICJP(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6083380", Offset = "0x6081F80", VA = "0x186083380", Slot = "19")]
	public NPPBIAIIDOF MILCJDHKGOM(bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6083AB0", Offset = "0x60826B0", VA = "0x186083AB0", Slot = "20")]
	public NPPBIAIIDOF PHDJJKIEHFL(HashSet<Guid> COMPKFLOHKL, bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6082480", Offset = "0x6081080", VA = "0x186082480", Slot = "24")]
	public void DBENLGIBMHD(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x60823D0", Offset = "0x6080FD0", VA = "0x1860823D0", Slot = "23")]
	public void CMGOJKMEEFC(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class JGLAPHJPGKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly MICCGNDBPKA<OFJKCILBDFK, OFJKCILBDFK> NHFMJAMPJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly MICCGNDBPKA<OFJKCILBDFK, OFJKCILBDFK> MMLNHHGGIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly BFGGANIGMAO<OFJKCILBDFK, OFJKCILBDFK, OFJKCILBDFK> PGNLMHHEAPC;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6094BA0", Offset = "0x60937A0", VA = "0x186094BA0")]
	public JGLAPHJPGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	public void HAJAGMDCLHL(ACKLEHJOPAP DFCFBMIMDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6094A60", Offset = "0x6093660", VA = "0x186094A60")]
	public void HMKGAGINCJG(OFJKCILBDFK MJOMMKLGFIJ, OFJKCILBDFK MAEGJLGHFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6094B40", Offset = "0x6093740", VA = "0x186094B40")]
	public void MLEBJBADPEI(OFJKCILBDFK MJOMMKLGFIJ, OFJKCILBDFK MAEGJLGHFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6094AC0", Offset = "0x60936C0", VA = "0x186094AC0")]
	public void ILGICDFFHOP(OFJKCILBDFK NMBNKFIIGPI, OFJKCILBDFK AECJKOCMHDK, OFJKCILBDFK MAEGJLGHFOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class KIIPEJHFAAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private ACKLEHJOPAP DFCFBMIMDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private OBFPCNEKAAM GHMLFJKNGCO;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public KIIPEJHFAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6095670", Offset = "0x6094270", VA = "0x186095670")]
	public void HAJAGMDCLHL(ACKLEHJOPAP DFCFBMIMDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6095540", Offset = "0x6094140", VA = "0x186095540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6095550", Offset = "0x6094150", VA = "0x186095550")]
	private void ELNOHDDKHIP(PGGNJPENPEC POHDOBOBLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x60957A0", Offset = "0x60943A0", VA = "0x1860957A0")]
	private void HPMLFPJHCOG(PGGNJPENPEC PNMDJBFOOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6095570", Offset = "0x6094170", VA = "0x186095570")]
	public void FPCHBMOBODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6095810", Offset = "0x6094410", VA = "0x186095810")]
	public void KCOJMDEMBOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class KDPGDKNIAIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IPKIDPIKFKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public OJEGDOKHPNO container;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public IPKIDPIKFKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6094900", Offset = "0x6093500", VA = "0x186094900")]
		internal ACKLEHJOPAP GBFJIGJCHKN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x60952C0", Offset = "0x6093EC0", VA = "0x1860952C0")]
	public static void ADFKCGOHHIF(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x60954C0", Offset = "0x60940C0", VA = "0x1860954C0")]
	public static void JABKMINACDA(OJEGDOKHPNO JEAKPHJODOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class NHCMABJLMOO : IDisposable, PPBLNACGKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, HDGNNOLBIEP> AJNHEOIBCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly JHGMICCNFKC ANFGDMBOJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private CCHLCKLPHIB EDDLHHPOCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private CBBEDCONCCA IKOAHIFGOIC;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6098890", Offset = "0x6097490", VA = "0x186098890")]
	public NHCMABJLMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6098110", Offset = "0x6096D10", VA = "0x186098110", Slot = "7")]
	public void HAJAGMDCLHL(CBBEDCONCCA IKOAHIFGOIC, CCHLCKLPHIB EDDLHHPOCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6097ED0", Offset = "0x6096AD0", VA = "0x186097ED0", Slot = "5")]
	public void ECNCFMJFDOO(KAHIJDNGCHM KFKGGGPOKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6098720", Offset = "0x6097320", VA = "0x186098720", Slot = "9")]
	public void NKCJCKMPIAK(KAHIJDNGCHM NHEIBLLAIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6097D10", Offset = "0x6096910", VA = "0x186097D10", Slot = "8")]
	public void AEEGAGCCMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x60983D0", Offset = "0x6096FD0", VA = "0x1860983D0", Slot = "10")]
	public void KIHMMKENNFN(KAHIJDNGCHM ADINNBFEGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6098300", Offset = "0x6096F00", VA = "0x186098300", Slot = "11")]
	public void IPGJEJKEGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6098150", Offset = "0x6096D50", VA = "0x186098150")]
	private bool ICNFPINJKHC(KAHIJDNGCHM DEBINDIDJKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class FMPFGOELOLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct IEHLJJBOJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly HJCJMHCOJPJ DKGFJPJPCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> COMPKFLOHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly APGPNPNJJFJ KANBGLLFMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly APGPNPNJJFJ NKIOMDJPLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool ANANEJNJPHG;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool BPODPBPDHDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x6093F90", Offset = "0x6092B90", VA = "0x186093F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6094220", Offset = "0x6092E20", VA = "0x186094220")]
		public IEHLJJBOJLD(HJCJMHCOJPJ DKGFJPJPCBA, HashSet<Guid> COMPKFLOHKL, bool ANANEJNJPHG, [Optional] APGPNPNJJFJ KANBGLLFMPB, [Optional] APGPNPNJJFJ NKIOMDJPLEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6093D60", Offset = "0x6092960", VA = "0x186093D60")]
		public APGPNPNJJFJ GAPNIKJAJOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6093ED0", Offset = "0x6092AD0", VA = "0x186093ED0")]
		private APGPNPNJJFJ GCCJHKJACFO([Out] APGPNPNJJFJ KENAHIFLMMK, [Out] APGPNPNJJFJ FBHPGIMMEOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6093B70", Offset = "0x6092770", VA = "0x186093B70")]
		private APGPNPNJJFJ AGDDAKCBKDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x60940B0", Offset = "0x6092CB0", VA = "0x1860940B0")]
		private void MMHOHGNBNKD(APGPNPNJJFJ JODELBMNEPE, APGPNPNJJFJ GKKHLMNGALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x60939B0", Offset = "0x60925B0", VA = "0x1860939B0")]
		private void ADBFIPCKBII(APGPNPNJJFJ KENAHIFLMMK, APGPNPNJJFJ FBHPGIMMEOP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private ACKLEHJOPAP DFCFBMIMDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private CBBEDCONCCA IKOAHIFGOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PPBLNACGKFG IDAHFJIPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private OBFPCNEKAAM GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool MFJPKPOCCPF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private bool CJCBFFNDGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x608AB90", Offset = "0x6089790", VA = "0x18608AB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private bool AGGGMMJEFEC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6089C20", Offset = "0x6088820", VA = "0x186089C20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x608A990", Offset = "0x6089590", VA = "0x18608A990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x608A9B0", Offset = "0x60895B0", VA = "0x18608A9B0")]
	public void HAJAGMDCLHL(ACKLEHJOPAP DFCFBMIMDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x608B3F0", Offset = "0x6089FF0", VA = "0x18608B3F0")]
	public NPPBIAIIDOF MILCJDHKGOM(bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x608BCE0", Offset = "0x608A8E0", VA = "0x18608BCE0")]
	public NPPBIAIIDOF PHDJJKIEHFL(HashSet<Guid> COMPKFLOHKL, bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x60894E0", Offset = "0x60880E0", VA = "0x1860894E0")]
	public void BDHKOKDICJP(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6089D60", Offset = "0x6088960", VA = "0x186089D60")]
	public void CMGOJKMEEFC(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x608BA20", Offset = "0x608A620", VA = "0x18608BA20")]
	public void OGPLADINMNH(NPPBIAIIDOF IKOAHIFGOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x608AED0", Offset = "0x6089AD0", VA = "0x18608AED0")]
	private void LAFBFOAMLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x608A7A0", Offset = "0x60893A0", VA = "0x18608A7A0")]
	private APGPNPNJJFJ GJLBJBJKMOI(HJCJMHCOJPJ FJKJNIMGBPD, bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x608A300", Offset = "0x6088F00", VA = "0x18608A300")]
	private static void FKLFPICKGLH(HJCJMHCOJPJ FJKJNIMGBPD, bool ANANEJNJPHG, APGPNPNJJFJ MHHDCKCJJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x608A0E0", Offset = "0x6088CE0", VA = "0x18608A0E0")]
	private void EGKOJGEHOJL(HJCJMHCOJPJ FJKJNIMGBPD, bool ANANEJNJPHG, APGPNPNJJFJ MHHDCKCJJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x608ABE0", Offset = "0x60897E0", VA = "0x18608ABE0")]
	private APGPNPNJJFJ IBAPKKLFDPC(HJCJMHCOJPJ DKGFJPJPCBA, HashSet<Guid> COMPKFLOHKL, bool ANANEJNJPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x608BA50", Offset = "0x608A650", VA = "0x18608BA50")]
	private bool PDGJEJCJGLC(NPPBIAIIDOF EJAEBJLDNGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x60895B0", Offset = "0x60881B0", VA = "0x1860895B0")]
	private bool BKOEICOLPLA(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x608C320", Offset = "0x608AF20", VA = "0x18608C320")]
	private bool PHMOGMNKCAM(NPPBIAIIDOF IKOAHIFGOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6089C40", Offset = "0x6088840", VA = "0x186089C40")]
	private static bool CBAHOBKFHCF(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x608A550", Offset = "0x6089150", VA = "0x18608A550")]
	public static bool GJILLNMPICP(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x608B0C0", Offset = "0x6089CC0", VA = "0x18608B0C0")]
	private OFJKCILBDFK LJFHCPFFECI(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6089F60", Offset = "0x6088B60", VA = "0x186089F60")]
	private OFJKCILBDFK EDLNALMIHAB(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x608AA20", Offset = "0x6089620", VA = "0x18608AA20")]
	private OFJKCILBDFK HHBPBNNPOME(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6089570", Offset = "0x6088170", VA = "0x186089570")]
	private static Guid BELBGDJMAAN(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x608B930", Offset = "0x608A530", VA = "0x18608B930")]
	private string OECKPKFKLMN(APGPNPNJJFJ MHHDCKCJJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6089E00", Offset = "0x6088A00", VA = "0x186089E00")]
	private bool COPKNNDHMNH(HJCJMHCOJPJ FJKJNIMGBPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x608AC70", Offset = "0x6089870", VA = "0x18608AC70")]
	private static void KEPALNKGMKG(HJCJMHCOJPJ DKGFJPJPCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public FMPFGOELOLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct MFFJAMEOHLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public OFJKCILBDFK MAEGJLGHFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public OFJKCILBDFK MJOMMKLGFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int KILBKEFNGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int NNHADHCGMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 BGKFEFOFKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion FLINMEACHBH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public KAPHPIDHFCG PCHJDLIOGID
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6097910", Offset = "0x6096510", VA = "0x186097910")]
		get
		{
			return default(KAPHPIDHFCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KAPHPIDHFCG NKGALOIPBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x60978E0", Offset = "0x60964E0", VA = "0x1860978E0")]
		get
		{
			return default(KAPHPIDHFCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x60979B0", Offset = "0x60965B0", VA = "0x1860979B0")]
	public MFFJAMEOHLO(OFJKCILBDFK MAEGJLGHFOA, OFJKCILBDFK MJOMMKLGFIJ, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface CBBEDCONCCA
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	KAHIJDNGCHM IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAJAGMDCLHL(AIGMLGBDOHJ DFCFBMIMDHA);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJIKMFDBKBN([In] MFFJAMEOHLO KOMCCCIEHEA, bool IDMKAHLCLNP = true);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BFFLLILKINB(OFJKCILBDFK FNEPIKHMNMG);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PEHHKHKEJNI(OFJKCILBDFK GNHGMEPLPAO, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NGPFNNENJDC(OFJKCILBDFK DLGPOADELKP, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OHJKEFPGAOI();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HHHHLFEDNIA(Func<OFJKCILBDFK, bool> MOKPDBDBLCK);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ODACJJOPDFH(OFJKCILBDFK OJONBJJAPMK, HashSet<OFJKCILBDFK> OMCHCMOKLOC);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<OFJKCILBDFK> ALFJGKEGMGO();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EFEPOIBBADG(OFJKCILBDFK OJONBJJAPMK, [Out] KAPHPIDHFCG HNOFFALPOEN);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MIDMJDCGPML(JHGMICCNFKC NLOLPKLGIBB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool JHGMICCNFKC(KAHIJDNGCHM FJKJNIMGBPD);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface KAHIJDNGCHM
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OFJKCILBDFK IHIFOBJCADL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KAHIJDNGCHM CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KAPHPIDHFCG ELJAKCOEBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool MFDBECMFILM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HDGNNOLBIEP
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKHOBAFCBDI(OFJKCILBDFK FLKCMHBMNHG, KAPHPIDHFCG MAEGJLGHFOA);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGLHPOGEGPK(OFJKCILBDFK FLKCMHBMNHG, KAPHPIDHFCG MAEGJLGHFOA);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OANKLPCKHDM(OFJKCILBDFK FLKCMHBMNHG, KAPHPIDHFCG MAEGJLGHFOA);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEEIJHCDGBJ(OFJKCILBDFK FLKCMHBMNHG, KAPHPIDHFCG MAEGJLGHFOA);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDGNNOLBIEP Instantiate(Transform NBNNMCCMOPL);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AIMIAMDLHAG();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CCHLCKLPHIB
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAJAGMDCLHL(Transform NBNNMCCMOPL, HDGNNOLBIEP BPLGJIPFECK);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HDGNNOLBIEP DNKMODMHNHO();

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBCDOMMAMMC(HDGNNOLBIEP CDPMAILGHDP);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface ONFECBPFPHI : MHCGANMPMKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLPJGKGDPKN(Guid FEOMFEADOBB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PPBLNACGKFG
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECNCFMJFDOO(KAHIJDNGCHM KFKGGGPOKHD);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HAJAGMDCLHL(CBBEDCONCCA IKOAHIFGOIC, CCHLCKLPHIB GBMLLKNNGGF);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEEGAGCCMHP();

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKCJCKMPIAK(KAHIJDNGCHM NHEIBLLAIGD);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KIHMMKENNFN(KAHIJDNGCHM ADINNBFEGFM);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPGJEJKEGCE();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class HJCJMHCOJPJ : KAHIJDNGCHM
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IJCMGODMCKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public KAPHPIDHFCG nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public HJCJMHCOJPJ foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public IJCMGODMCKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x60947D0", Offset = "0x60933D0", VA = "0x1860947D0")]
		internal bool PGNKCIKAIAC(KAHIJDNGCHM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private KAPHPIDHFCG HNOFFALPOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<HJCJMHCOJPJ> ALKDPFOCKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private HJCJMHCOJPJ LHIKGJIPBCJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KAPHPIDHFCG ELJAKCOEBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x339A110", Offset = "0x3398D10", VA = "0x18339A110", Slot = "6")]
		get
		{
			return default(KAPHPIDHFCG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x608E2A0", Offset = "0x608CEA0", VA = "0x18608E2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private HJCJMHCOJPJ MJOMMKLGFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x608E5A0", Offset = "0x608D1A0", VA = "0x18608E5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public KAHIJDNGCHM CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public OFJKCILBDFK IHIFOBJCADL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MFDBECMFILM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x608EED0", Offset = "0x608DAD0", VA = "0x18608EED0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LJMEEPFDADK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x608E070", Offset = "0x608CC70", VA = "0x18608E070", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	protected HJCJMHCOJPJ EBCHPMPLBLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x608E680", Offset = "0x608D280", VA = "0x18608E680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x608EEE0", Offset = "0x608DAE0", VA = "0x18608EEE0")]
	public HJCJMHCOJPJ(KAPHPIDHFCG OGLHIDJLOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x608E6A0", Offset = "0x608D2A0", VA = "0x18608E6A0")]
	public HJCJMHCOJPJ KBPDEGGFOIC(KAPHPIDHFCG IDHPBJKBLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x608E2D0", Offset = "0x608CED0", VA = "0x18608E2D0")]
	public HJCJMHCOJPJ FAOMILAPGHM(KAPHPIDHFCG HNFCDHKGDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x608E0C0", Offset = "0x608CCC0", VA = "0x18608E0C0")]
	public HJCJMHCOJPJ DMBJGENFJDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x608E450", Offset = "0x608D050", VA = "0x18608E450")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x608EE20", Offset = "0x608DA20", VA = "0x18608EE20")]
	public HJCJMHCOJPJ NAEKKFBIEEA(KAPHPIDHFCG AECJKOCMHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x608E900", Offset = "0x608D500", VA = "0x18608E900")]
	private static void MIDMJDCGPML(HJCJMHCOJPJ FDGNMAHFNHA, JHGMICCNFKC ELLJNACABMF, bool KHIKEHGFJGA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x608E8F0", Offset = "0x608D4F0", VA = "0x18608E8F0", Slot = "9")]
	public void MIDMJDCGPML(JHGMICCNFKC NLOLPKLGIBB, bool LHEAJHFCFEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x608EA60", Offset = "0x608D660", VA = "0x18608EA60")]
	public static string MOJCJNDAENO(HJCJMHCOJPJ FDGNMAHFNHA, int EIGGDODJGMH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x608E7F0", Offset = "0x608D3F0", VA = "0x18608E7F0")]
	public static HJCJMHCOJPJ MAGPKILBAOB(HJCJMHCOJPJ FDGNMAHFNHA, KAPHPIDHFCG BKFPGCKOGDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface OBFPCNEKAAM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool CJCBFFNDGLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool GNDLLJFJGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<PGGNJPENPEC> ELNOHDDKHIP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<PGGNJPENPEC> HPMLFPJHCOG;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(ACKLEHJOPAP DFCFBMIMDHA);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(OFJKCILBDFK GNHGMEPLPAO, OFJKCILBDFK PBPBFDLDPMJ, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(OFJKCILBDFK DLGPOADELKP, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(NPPBIAIIDOF HINFMBEOAMI, [Optional] PGGNJPENPEC ILLIJBLIMHK);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, OBFPCNEKAAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private ACKLEHJOPAP DFCFBMIMDHA;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool CJCBFFNDGLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6097610", Offset = "0x6096210", VA = "0x186097610", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool GNDLLJFJGEH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x6097670", Offset = "0x6096270", VA = "0x186097670", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PGGNJPENPEC> ELNOHDDKHIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x6097560", Offset = "0x6096160", VA = "0x186097560", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x6097760", Offset = "0x6096360", VA = "0x186097760", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<PGGNJPENPEC> HPMLFPJHCOG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x60974B0", Offset = "0x60960B0", VA = "0x1860974B0", Slot = "17")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x60976B0", Offset = "0x60962B0", VA = "0x1860976B0", Slot = "18")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F30", Offset = "0x7B8B30", VA = "0x1807B9F30", Slot = "21")]
		public void SetManager(ACKLEHJOPAP DFCFBMIMDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6097480", Offset = "0x6096080", VA = "0x186097480")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6096200", Offset = "0x6094E00", VA = "0x186096200", Slot = "25")]
		public void RequestMasterConnectNodes(OFJKCILBDFK MLCIDMIGGKK, int KILBKEFNGNJ, OFJKCILBDFK FLKCMHBMNHG, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6096330", Offset = "0x6094F30", VA = "0x186096330", Slot = "26")]
		public void RequestMasterDisconnectNode(OFJKCILBDFK FNEPIKHMNMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x60963F0", Offset = "0x6094FF0", VA = "0x1860963F0", Slot = "22")]
		public void RequestMasterModifyNode(OFJKCILBDFK GNHGMEPLPAO, OFJKCILBDFK PBPBFDLDPMJ, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6096520", Offset = "0x6095120", VA = "0x186096520", Slot = "23")]
		public void RequestMasterReparentNodes(OFJKCILBDFK DLGPOADELKP, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6096650", Offset = "0x6095250", VA = "0x186096650", Slot = "27")]
		public void RequestMasterReparentToRoot(OFJKCILBDFK DLGPOADELKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x60960D0", Offset = "0x6094CD0", VA = "0x1860960D0", Slot = "24")]
		public void RequestDeserializeConnectableGraph(NPPBIAIIDOF HINFMBEOAMI, [Optional] PGGNJPENPEC ILLIJBLIMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6096A30", Offset = "0x6095630", VA = "0x186096A30")]
		[OMMNNEOMJAC]
		private void RpcMasterConnectNodes(OFJKCILBDFK MLCIDMIGGKK, int KILBKEFNGNJ, OFJKCILBDFK FLKCMHBMNHG, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6096CF0", Offset = "0x60958F0", VA = "0x186096CF0")]
		[OMMNNEOMJAC]
		private void RpcMasterDisconnectNode(OFJKCILBDFK FNEPIKHMNMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6097030", Offset = "0x6095C30", VA = "0x186097030")]
		[OMMNNEOMJAC]
		private void RpcMasterReparentNodes(OFJKCILBDFK DLGPOADELKP, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6096E30", Offset = "0x6095A30", VA = "0x186096E30")]
		[OMMNNEOMJAC]
		private void RpcMasterModifyNode(OFJKCILBDFK GNHGMEPLPAO, OFJKCILBDFK PBPBFDLDPMJ, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6096820", Offset = "0x6095420", VA = "0x186096820")]
		[OMMNNEOMJAC]
		private void RpcConnectNodes(OFJKCILBDFK MLCIDMIGGKK, int KILBKEFNGNJ, OFJKCILBDFK FLKCMHBMNHG, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH, FNDGECDLAGG IKGPPOEFMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x60969A0", Offset = "0x60955A0", VA = "0x1860969A0")]
		[OMMNNEOMJAC]
		private void RpcDisconnectNode(OFJKCILBDFK FNEPIKHMNMG, FNDGECDLAGG IKGPPOEFMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6097380", Offset = "0x6095F80", VA = "0x186097380")]
		[OMMNNEOMJAC]
		private void RpcReparentNodes(OFJKCILBDFK DLGPOADELKP, int FCPEBNMBHOG, OFJKCILBDFK AECJKOCMHDK, int ABKGDBHCACD, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH, FNDGECDLAGG IKGPPOEFMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x60972C0", Offset = "0x6095EC0", VA = "0x1860972C0")]
		[OMMNNEOMJAC]
		private void RpcModifyNode(OFJKCILBDFK GNHGMEPLPAO, int KILBKEFNGNJ, int NNHADHCGMIJ, Vector3 BGKFEFOFKPN, Quaternion FLINMEACHBH, FNDGECDLAGG IKGPPOEFMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6096960", Offset = "0x6095560", VA = "0x186096960")]
		[OMMNNEOMJAC]
		private void RpcDeserializeConnectableGraph(NPPBIAIIDOF IKOAHIFGOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CD590", Offset = "0x7CC190", VA = "0x1807CD590")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, HDGNNOLBIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6095910", Offset = "0x6094510", VA = "0x186095910", Slot = "4")]
		private void FLIPLNOEOEJ(OFJKCILBDFK FLKCMHBMNHG, KAPHPIDHFCG MAEGJLGHFOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6095E60", Offset = "0x6094A60", VA = "0x186095E60", Slot = "5")]
		private void NNGOABJLBKE(OFJKCILBDFK FLKCMHBMNHG, KAPHPIDHFCG MAEGJLGHFOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6095B00", Offset = "0x6094700", VA = "0x186095B00", Slot = "6")]
		private void IDDPJGNEGPL(OFJKCILBDFK FLKCMHBMNHG, KAPHPIDHFCG MAEGJLGHFOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6095C10", Offset = "0x6094810", VA = "0x186095C10", Slot = "7")]
		private void KCGIJNCCFCE(OFJKCILBDFK FLKCMHBMNHG, KAPHPIDHFCG MAEGJLGHFOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6095A90", Offset = "0x6094690", VA = "0x186095A90", Slot = "8")]
		private HDGNNOLBIEP HFGILLGMHKK(Transform NBNNMCCMOPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6095E00", Offset = "0x6094A00", VA = "0x186095E00", Slot = "9")]
		private void LFCKBCGLBON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MGFPKACPACP
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x289B6A0", Offset = "0x289A2A0", VA = "0x18289B6A0")]
	public static MHJMKBLILAJ<T> KJLDJLOLFMI<T>(this OJEGDOKHPNO JEAKPHJODOO)
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
