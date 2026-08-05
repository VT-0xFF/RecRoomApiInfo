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
	public class LogRegistrationIndex : DLJCNHBICIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6840F30", Offset = "0x6840330", VA = "0x186840F30", Slot = "4")]
		public override void NLGJOIAOEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
	public class _AssemblyIndex : OIHPLJCCMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private HELGCKGNJCP bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private HELGCKGNJCP bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6842E40", Offset = "0x6842240", VA = "0x186842E40", Slot = "5")]
		public override void LGJJIPPJFHB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6842990", Offset = "0x6841D90", VA = "0x186842990")]
		private void HKLAFMGGDHJ(NLGBDMBMDHC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6842E80", Offset = "0x6842280", VA = "0x186842E80")]
		private void MIGNDDDNKKA(NLGBDMBMDHC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6842B00", Offset = "0x6841F00", VA = "0x186842B00", Slot = "6")]
		public override void HOLCLMBHKNK(NLGBDMBMDHC registry, [In] FACCPJLOOCE filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "8")]
		public override void DLOFGCDOMEH(FELKOHNNBJK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6842FF0", Offset = "0x68423F0", VA = "0x186842FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class DLAEPDEOAII : OBJHDHIKCFI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FKDGNFFIHOP : IEnumerable<NNEGNMIMJLO>, IEnumerable, IEnumerator<NNEGNMIMJLO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NNEGNMIMJLO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private EBAHGGHEDAJ localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EBAHGGHEDAJ <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DLAEPDEOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IEBGDLJNKIA <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private MADLFEDHJJF.AHHNAFFNLCJ <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private NNEGNMIMJLO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89EDF0", Offset = "0x89E1F0", VA = "0x18089EDF0")]
		[DebuggerHidden]
		public FKDGNFFIHOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6839690", Offset = "0x6838A90", VA = "0x186839690", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68391D0", Offset = "0x68385D0", VA = "0x1868391D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68391B0", Offset = "0x68385B0", VA = "0x1868391B0")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6839640", Offset = "0x6838A40", VA = "0x186839640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6839590", Offset = "0x6838990", VA = "0x186839590", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NNEGNMIMJLO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6839590", Offset = "0x6838990", VA = "0x186839590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PGGAIKEAPOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public DLAEPDEOAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CGGFLGEONJM nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public PGGAIKEAPOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6842180", Offset = "0x6841580", VA = "0x186842180")]
		internal object NEEFEFIMNKD(CGGFLGEONJM x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MNKLPCMEHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CGGFLGEONJM child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public PGGAIKEAPOO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public MNKLPCMEHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x68410D0", Offset = "0x68404D0", VA = "0x1868410D0")]
		internal object HEFMBINDLJG((CGGFLGEONJM child, CGGFLGEONJM nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly BADOKLEEAHE LCOBMDHEMJO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly BADOKLEEAHE GFPCNPIOFKG;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly BADOKLEEAHE BOFHIGCICIN;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly BADOKLEEAHE PJJCIFOBOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EFAMEOPHAOP JHHJFAPGGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BMDNPBCDNAB BBFJJKDIBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private HEODIBIFAHE MOONAACBDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private CBCJOGKEGAA PKEMJFONHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private NHFJLPGDHPF LJGPEPKJCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HMJIBIAJEPI AGFGGBNBOGB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ENEMNHNNKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85D5E0", Offset = "0x85C9E0", VA = "0x18085D5E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85D160", Offset = "0x85C560", VA = "0x18085D160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHKHFPCFFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<NNEGNMIMJLO, NNEGNMIMJLO> FDLPLPNGKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6836050", Offset = "0x6835450", VA = "0x186836050", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68363E0", Offset = "0x68357E0", VA = "0x1868363E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<NNEGNMIMJLO, NNEGNMIMJLO> BADFFKKLGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6835ED0", Offset = "0x68352D0", VA = "0x186835ED0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68372F0", Offset = "0x68366F0", VA = "0x1868372F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<NNEGNMIMJLO, NNEGNMIMJLO, NNEGNMIMJLO> FAGANADFLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68358C0", Offset = "0x6834CC0", VA = "0x1868358C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68351C0", Offset = "0x68345C0", VA = "0x1868351C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6838B00", Offset = "0x6837F00", VA = "0x186838B00")]
	public DLAEPDEOAII(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68379C0", Offset = "0x6836DC0", VA = "0x1868379C0", Slot = "12")]
	public void MGIGIPLLEKC(GameObject GODEJCKEDNP, HHAFMEHNGIH CCGMLDOOOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6835270", Offset = "0x6834670", VA = "0x186835270", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68380E0", Offset = "0x68374E0", VA = "0x1868380E0", Slot = "22")]
	public bool MOIFJHGOPAB(CGGFLGEONJM CAHNDBICCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6837410", Offset = "0x6836810", VA = "0x186837410")]
	private void LHPMNCOCNBM(EBAHGGHEDAJ APHDMHLDOMK, EBAHGGHEDAJ FAPCEDHHIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68343A0", Offset = "0x68337A0", VA = "0x1868343A0")]
	private void AKJHMBHLPFA(EBAHGGHEDAJ APHDMHLDOMK, EBAHGGHEDAJ MJBKMBEIDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6837620", Offset = "0x6836A20", VA = "0x186837620")]
	private void LPLJLFLIHDC(EBAHGGHEDAJ APHDMHLDOMK, EBAHGGHEDAJ MJBKMBEIDFM, EBAHGGHEDAJ FAPCEDHHIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68345C0", Offset = "0x68339C0", VA = "0x1868345C0")]
	private void BOKNKLJNLKK(EBAHGGHEDAJ APHDMHLDOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "13")]
	public void DKKALNJCGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6838130", Offset = "0x6837530", VA = "0x186838130", Slot = "14")]
	public void NLGJOIAOEAN(NNEGNMIMJLO HACGEFHOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "15")]
	public void NGLMLECLEDL(NNEGNMIMJLO HACGEFHOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6837D70", Offset = "0x6837170", VA = "0x186837D70", Slot = "17")]
	public void MMACPEABOBH(NNEGNMIMJLO HACGEFHOFHL, NNEGNMIMJLO CDCICKNCAIH, Vector3 NCLBJGONFMN, Quaternion BDPMNAOLAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6837C30", Offset = "0x6837030", VA = "0x186837C30")]
	public void MMACPEABOBH(EBAHGGHEDAJ LGDEAAPGGHL, EBAHGGHEDAJ CDCICKNCAIH, Vector3 NCLBJGONFMN, Quaternion BDPMNAOLAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6837930", Offset = "0x6836D30", VA = "0x186837930")]
	public void MEKBOILKCON(NNEGNMIMJLO HACGEFHOFHL, float OGCFKDPCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6836160", Offset = "0x6835560", VA = "0x186836160", Slot = "18")]
	public void INLAHECPGGH(NNEGNMIMJLO JLDCDDGIFPI, int LEHJBHMEHBD, NNEGNMIMJLO HNMJHGEPMEL, int KEEJJLMEKEP, Vector3 NCLBJGONFMN, Quaternion BDPMNAOLAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6835640", Offset = "0x6834A40", VA = "0x186835640")]
	private float FCNDAKNEHFO(EBAHGGHEDAJ LGDEAAPGGHL, EBAHGGHEDAJ KOBAADDGPBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68362B0", Offset = "0x68356B0", VA = "0x1868362B0")]
	public void INLAHECPGGH(EBAHGGHEDAJ LGDEAAPGGHL, EBAHGGHEDAJ KOBAADDGPBN, Vector3 NCLBJGONFMN, Quaternion BDPMNAOLAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6836100", Offset = "0x6835500", VA = "0x186836100")]
	public void INLAHECPGGH(EBAHGGHEDAJ LGDEAAPGGHL, EBAHGGHEDAJ KOBAADDGPBN, Vector3 NCLBJGONFMN, Quaternion BDPMNAOLAED, float OGCFKDPCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6835750", Offset = "0x6834B50", VA = "0x186835750", Slot = "19")]
	public void FLDNDGJJICO(NNEGNMIMJLO HACGEFHOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68349D0", Offset = "0x6833DD0", VA = "0x1868349D0")]
	public bool CFCKEOFGANN(EBAHGGHEDAJ OCKGPBNMNLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6837ED0", Offset = "0x68372D0", VA = "0x186837ED0", Slot = "16")]
	public void MNBAIBMGODF(NNEGNMIMJLO HACGEFHOFHL, HashSet<NNEGNMIMJLO> KNDONKCMKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "20")]
	public NABHEMBKEEJ LGBHFIEHOJB(bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "21")]
	public NABHEMBKEEJ FEOAMFOOKDN(HashSet<Guid> IFOLKEMLIOA, bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6835E60", Offset = "0x6835260", VA = "0x186835E60", Slot = "23")]
	public void HEMGJGMIFHF(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6837280", Offset = "0x6836680", VA = "0x186837280", Slot = "24")]
	public void LAOEDJIJLLH(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6834380", Offset = "0x6833780", VA = "0x186834380", Slot = "25")]
	public void AFFFGHCGIOF(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6838630", Offset = "0x6837A30", VA = "0x186838630")]
	private void PGDEBBFINOD(EBAHGGHEDAJ LGDEAAPGGHL, EBAHGGHEDAJ KOBAADDGPBN, Vector3 NCLBJGONFMN, Quaternion BDPMNAOLAED, float OGCFKDPCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6836BC0", Offset = "0x6835FC0", VA = "0x186836BC0")]
	private void KMAOAGLPFOE(EBAHGGHEDAJ LGDEAAPGGHL, EBAHGGHEDAJ DADNCNLHDCH, Vector3 NCLBJGONFMN, Quaternion BDPMNAOLAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68373A0", Offset = "0x68367A0", VA = "0x1868373A0")]
	private void LBFLPEGGNNO(EBAHGGHEDAJ LGDEAAPGGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68378A0", Offset = "0x6836CA0", VA = "0x1868378A0")]
	[IteratorStateMachine(typeof(FKDGNFFIHOP))]
	public IEnumerable<NNEGNMIMJLO> LPNPCPBBCPB(EBAHGGHEDAJ OCKGPBNMNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6835970", Offset = "0x6834D70", VA = "0x186835970")]
	internal NNEGNMIMJLO GCMAPCGDBLL(EBAHGGHEDAJ OCKGPBNMNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6835F80", Offset = "0x6835380", VA = "0x186835F80")]
	internal EBAHGGHEDAJ HNHKDPBHCOM(NNEGNMIMJLO HACGEFHOFHL)
	{
		return default(EBAHGGHEDAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6836620", Offset = "0x6835A20", VA = "0x186836620")]
	private bool KLGOGFBBINP(CGGFLGEONJM CAHNDBICCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68356F0", Offset = "0x6834AF0", VA = "0x1868356F0")]
	private bool FJNEHKPNAGK(CGGFLGEONJM CAHNDBICCFN, [Out] NNEGNMIMJLO KOBAADDGPBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6835AB0", Offset = "0x6834EB0", VA = "0x186835AB0")]
	private NNEGNMIMJLO GCMAPCGDBLL(CGGFLGEONJM CAHNDBICCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6836490", Offset = "0x6835890", VA = "0x186836490")]
	private NNEGNMIMJLO JGHHNOJNOHD(CGGFLGEONJM CAHNDBICCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6835460", Offset = "0x6834860", VA = "0x186835460")]
	private NNEGNMIMJLO EADHOPJHLBM(CGGFLGEONJM CAHNDBICCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6830EE0", Offset = "0x68302E0", VA = "0x186830EE0")]
	private static Guid MNPCGIMDACO(CGGFLGEONJM CAHNDBICCFN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6834F40", Offset = "0x6834340", VA = "0x186834F40")]
	private string DDJABDHHHJE(CGGFLGEONJM CAHNDBICCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6836FE0", Offset = "0x68363E0", VA = "0x186836FE0")]
	private void KNEPIALFPLN(NNEGNMIMJLO LGDEAAPGGHL, NNEGNMIMJLO DADNCNLHDCH, RigidTransform ILIAHNJMIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68384A0", Offset = "0x68378A0", VA = "0x1868384A0")]
	private void PBDHIFGIJCK(NNEGNMIMJLO DADNCNLHDCH, NNEGNMIMJLO LGDEAAPGGHL, RigidTransform ILIAHNJMIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6838440", Offset = "0x6837840", VA = "0x186838440")]
	private void OMFBLIJPKLG(NNEGNMIMJLO NMENDHGIKLP, NNEGNMIMJLO LGDEAAPGGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6835030", Offset = "0x6834430", VA = "0x186835030")]
	private void DEPEGILDAEG(NNEGNMIMJLO LGDEAAPGGHL, NNEGNMIMJLO KOBAADDGPBN, RigidTransform ILIAHNJMIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6837170", Offset = "0x6836570", VA = "0x186837170")]
	private void LAIALKFHAGL(EBAHGGHEDAJ OCKGPBNMNLE, NNEGNMIMJLO HACGEFHOFHL, EBAHGGHEDAJ MJBKMBEIDFM, EBAHGGHEDAJ FAPCEDHHIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6834C60", Offset = "0x6834060", VA = "0x186834C60")]
	private void CKACEHCFDII(EBAHGGHEDAJ OCKGPBNMNLE, NNEGNMIMJLO HACGEFHOFHL, NNEGNMIMJLO HHECJAMAIEK, NNEGNMIMJLO CHHECICKGJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LJPKLJONDGM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BOFNGFGECAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public NFLAEHJHNPL container;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public BOFNGFGECAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6831620", Offset = "0x6830A20", VA = "0x186831620")]
		internal DLAEPDEOAII DMALAFHMEOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x683EEB0", Offset = "0x683E2B0", VA = "0x18683EEB0")]
	public static void NCHGKDEAMJE(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x683EE60", Offset = "0x683E260", VA = "0x18683EE60")]
	public static void IAPNMKPKPDL(NFLAEHJHNPL IFELLLJKHDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class DKEBFCEGNBI : CNEMAADBFDB, NADCDGMKCFD
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx CNGOHFHGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DLAEPDEOAII NAIACFCNLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly CHEKCLLNAED LEGFDCJMHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NLHKDIAKFJE PKEMJFONHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly KLHLEMKOBOK[] GLALEHLCADH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EBAHGGHEDAJ FGFMCGCOEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(EBAHGGHEDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NNEGNMIMJLO LKDBANPMIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6834150", Offset = "0x6833550", VA = "0x186834150", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NNEGNMIMJLO MPIGHDDFAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x68337B0", Offset = "0x6832BB0", VA = "0x1868337B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 MCEOCMLDPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6833270", Offset = "0x6832670", VA = "0x186833270", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion HPKKMMNENOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6833A60", Offset = "0x6832E60", VA = "0x186833A60", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MEMGKKHMAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6832800", Offset = "0x6831C00", VA = "0x186832800", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<NNEGNMIMJLO> NPFGGLKEAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68327D0", Offset = "0x6831BD0", VA = "0x1868327D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool ONMOHOGHMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x95D480", Offset = "0x95C880", VA = "0x18095D480", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAD6100", Offset = "0xAD5500", VA = "0x180AD6100", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform PEDBLOEBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6834360", Offset = "0x6833760", VA = "0x186834360", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject MHEPINPOCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x259E2C0", Offset = "0x259D6C0", VA = "0x18259E2C0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6834080", Offset = "0x6833480", VA = "0x186834080", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid IMPDEELEMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68341B0", Offset = "0x68335B0", VA = "0x1868341B0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DMJFPMDHNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6834290", Offset = "0x6833690", VA = "0x186834290", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool LHFBIFGGJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool IJMHIONBAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6832780", Offset = "0x6831B80", VA = "0x186832780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event CFPCILNKLJP MBCFKGPPNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x68328A0", Offset = "0x6831CA0", VA = "0x1868328A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x68330D0", Offset = "0x68324D0", VA = "0x1868330D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event CFPCILNKLJP OHJFIGILAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6832620", Offset = "0x6831A20", VA = "0x186832620", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68325C0", Offset = "0x68319C0", VA = "0x1868325C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CFPCILNKLJP EKFLFBKMPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6832D10", Offset = "0x6832110", VA = "0x186832D10", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6832680", Offset = "0x6831A80", VA = "0x186832680", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event IKCOFJGFNKK ANJHAPHLCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6833130", Offset = "0x6832530", VA = "0x186833130", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68331D0", Offset = "0x68325D0", VA = "0x1868331D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6833F80", Offset = "0x6833380", VA = "0x186833F80")]
	public DKEBFCEGNBI(EBAHGGHEDAJ IMBDNPNCDFL, RigidbodyEx CNGOHFHGBJN, CHEKCLLNAED LEGFDCJMHBB, KLHLEMKOBOK[] GLALEHLCADH, NLHKDIAKFJE PKEMJFONHGN, OBJHDHIKCFI NAIACFCNLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6832870", Offset = "0x6831C70", VA = "0x186832870", Slot = "19")]
	public void EOHNLKEPLBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "21")]
	public void FFHLDFCOJKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x668C760", Offset = "0x668BB60", VA = "0x18668C760", Slot = "22")]
	public void CMIJCNGNNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68338F0", Offset = "0x6832CF0", VA = "0x1868338F0", Slot = "20")]
	public void OBMMDJGNFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6832900", Offset = "0x6831D00", VA = "0x186832900", Slot = "25")]
	public void GNCGJPJMNCA(int AAPHCEAPPLH, NNEGNMIMJLO HNMJHGEPMEL, int AKEIEPNLHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6833940", Offset = "0x6832D40", VA = "0x186833940", Slot = "26")]
	public void OIOBPOEEMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x68334D0", Offset = "0x68328D0", VA = "0x1868334D0", Slot = "27")]
	public void LLPENEJOFND(int AAPHCEAPPLH, NNEGNMIMJLO JLDCDDGIFPI, int GFHGBBGBHIN, [Optional] Vector3? FDJNBPEHPHC, [Optional] Quaternion? KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6833870", Offset = "0x6832C70", VA = "0x186833870", Slot = "28")]
	public void NDOLFPPBCBC(NNEGNMIMJLO JLDCDDGIFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6833AC0", Offset = "0x6832EC0", VA = "0x186833AC0", Slot = "31")]
	public void POBHGOKIKCH(Vector3 GFGIHGEDODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6832D70", Offset = "0x6832170", VA = "0x186832D70", Slot = "29")]
	public void IFDEJEIBIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68332D0", Offset = "0x68326D0", VA = "0x1868332D0", Slot = "30")]
	public void LJDJDAGHOOM(int AGAGKNBDCIG, Vector3 DHLCOAONPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6832C40", Offset = "0x6832040", VA = "0x186832C40", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int AAPHCEAPPLH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6832B10", Offset = "0x6831F10", VA = "0x186832B10", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int AAPHCEAPPLH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x98EC60", Offset = "0x98E060", VA = "0x18098EC60", Slot = "42")]
	public Color GetConnectionSlotColor(int AAPHCEAPPLH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x68326E0", Offset = "0x6831AE0", VA = "0x1868326E0", Slot = "43")]
	public bool CanConnectTo(int AAPHCEAPPLH, NNEGNMIMJLO FFJPMFCHBNH, int OCGPLDNIDLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "44")]
	public void ParentChanged(int AAPHCEAPPLH, NNEGNMIMJLO HBNJJCFIFHB, int KFNCNBHDCFH, Vector3 NAGPNBHNODK, Quaternion PAPAPMJPKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "45")]
	public void ChildAdded(int AAPHCEAPPLH, NNEGNMIMJLO MPNGJHABOJG, int KHAEKHGNEKL, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "46")]
	public void ChildRemoved(int AAPHCEAPPLH, NNEGNMIMJLO MLKDAHEJJEK, int GAHMLHMPPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "47")]
	public void ConnectionModified(int AAPHCEAPPLH, NNEGNMIMJLO HNMJHGEPMEL, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6833ED0", Offset = "0x68332D0", VA = "0x186833ED0", Slot = "48")]
	public void RootChanged(NNEGNMIMJLO FCIKOFNALCI, NNEGNMIMJLO GGDFGCBGADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6833820", Offset = "0x6832C20", VA = "0x186833820", Slot = "23")]
	public void MCOPCDIAMIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6833080", Offset = "0x6832480", VA = "0x186833080", Slot = "24")]
	public void JCLDJGLDAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6833A10", Offset = "0x6832E10", VA = "0x186833A10")]
	private void OJAOKABAABK(bool LHAHOHKAAAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[EFCEPDIPLEI(typeof(KLOCPJLPFDB), new string[] { })]
public class OKAOIOGHDMG : KLOCPJLPFDB, HGLPGAMBODG
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ELEEFFCEMMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public OKAOIOGHDMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public MADLFEDHJJF localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public ELEEFFCEMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6838B70", Offset = "0x6837F70", VA = "0x186838B70")]
		internal void FPLELECCCCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[AFKIJNMKPHG]
	private HEGEJMDHIIC OLAPOPPPDNC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object PFGAKAJNDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6842080", Offset = "0x6841480", VA = "0x186842080", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6842030", Offset = "0x6841430", VA = "0x186842030", Slot = "6")]
	public void InitReferences(EGOJPPMNMDN AGFGGBNBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6841EC0", Offset = "0x68412C0", VA = "0x186841EC0", Slot = "5")]
	public void EINLEJMAOJE(MADLFEDHJJF AEBCGFIOJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public OKAOIOGHDMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[EFCEPDIPLEI(typeof(OBJHDHIKCFI), new string[] { "Ignore", "Mock" })]
public class FJCAODNMMBG : OBJHDHIKCFI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool ENEMNHNNKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AHKHFPCFFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<NNEGNMIMJLO, NNEGNMIMJLO> FDLPLPNGKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6838FA0", Offset = "0x68383A0", VA = "0x186838FA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6839050", Offset = "0x6838450", VA = "0x186839050", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<NNEGNMIMJLO, NNEGNMIMJLO> BADFFKKLGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6838EF0", Offset = "0x68382F0", VA = "0x186838EF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6839100", Offset = "0x6838500", VA = "0x186839100", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<NNEGNMIMJLO, NNEGNMIMJLO, NNEGNMIMJLO> FAGANADFLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6838E40", Offset = "0x6838240", VA = "0x186838E40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6838D90", Offset = "0x6838190", VA = "0x186838D90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "12")]
	public void MGIGIPLLEKC(GameObject GODEJCKEDNP, HHAFMEHNGIH CCGMLDOOOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "13")]
	public void DKKALNJCGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "14")]
	public void NLGJOIAOEAN(NNEGNMIMJLO HACGEFHOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "15")]
	public void NGLMLECLEDL(NNEGNMIMJLO HACGEFHOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "16")]
	public void MNBAIBMGODF(NNEGNMIMJLO HACGEFHOFHL, HashSet<NNEGNMIMJLO> KNDONKCMKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "17")]
	public void MMACPEABOBH(NNEGNMIMJLO HACGEFHOFHL, NNEGNMIMJLO CDCICKNCAIH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "18")]
	public void INLAHECPGGH(NNEGNMIMJLO HACGEFHOFHL, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "19")]
	public void FLDNDGJJICO(NNEGNMIMJLO HACGEFHOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "20")]
	public NABHEMBKEEJ LGBHFIEHOJB(bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "21")]
	public NABHEMBKEEJ FEOAMFOOKDN(HashSet<Guid> IFOLKEMLIOA, bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "22")]
	public bool MOIFJHGOPAB(CGGFLGEONJM CAHNDBICCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "23")]
	public void HEMGJGMIFHF(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "24")]
	public void LAOEDJIJLLH(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "25")]
	public void AFFFGHCGIOF(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public FJCAODNMMBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NNEGNMIMJLO : NADCDGMKCFD, IEquatable<NNEGNMIMJLO>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NADCDGMKCFD
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NNEGNMIMJLO LKDBANPMIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform PEDBLOEBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject MHEPINPOCON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string KHPOGHNODCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid IMPDEELEMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int DMJFPMDHNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EBAHGGHEDAJ FGFMCGCOEPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LHFBIFGGJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int AAPHCEAPPLH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int AAPHCEAPPLH);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int AAPHCEAPPLH);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int AAPHCEAPPLH, NNEGNMIMJLO FFJPMFCHBNH, int BJFIHOLMEAJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int AAPHCEAPPLH, NNEGNMIMJLO HBNJJCFIFHB, int KFNCNBHDCFH, Vector3 NAGPNBHNODK, Quaternion PAPAPMJPKGI);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int AAPHCEAPPLH, NNEGNMIMJLO MPNGJHABOJG, int KHAEKHGNEKL, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int AAPHCEAPPLH, NNEGNMIMJLO MLKDAHEJJEK, int GAHMLHMPPKN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int AAPHCEAPPLH, NNEGNMIMJLO HNMJHGEPMEL, int MBMMGKGEMCF, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(NNEGNMIMJLO FCIKOFNALCI, NNEGNMIMJLO GGDFGCBGADN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[HNPBPAPMCJD(HLMJHHDGPFE.OMRoom)]
public interface OBJHDHIKCFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ENEMNHNNKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool AHKHFPCFFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NNEGNMIMJLO, NNEGNMIMJLO> FDLPLPNGKIA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<NNEGNMIMJLO, NNEGNMIMJLO> BADFFKKLGNK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<NNEGNMIMJLO, NNEGNMIMJLO, NNEGNMIMJLO> FAGANADFLIJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MGIGIPLLEKC(GameObject GODEJCKEDNP, HHAFMEHNGIH CCGMLDOOOEF);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DKKALNJCGIH();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NLGJOIAOEAN(NNEGNMIMJLO HACGEFHOFHL);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NGLMLECLEDL(NNEGNMIMJLO HACGEFHOFHL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MNBAIBMGODF(NNEGNMIMJLO HACGEFHOFHL, HashSet<NNEGNMIMJLO> KNDONKCMKIM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MMACPEABOBH(NNEGNMIMJLO HACGEFHOFHL, NNEGNMIMJLO CDCICKNCAIH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void INLAHECPGGH(NNEGNMIMJLO HACGEFHOFHL, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FLDNDGJJICO(NNEGNMIMJLO HACGEFHOFHL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NABHEMBKEEJ LGBHFIEHOJB(bool BMGKAEFEDOB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NABHEMBKEEJ FEOAMFOOKDN(HashSet<Guid> IFOLKEMLIOA, bool BMGKAEFEDOB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MOIFJHGOPAB(CGGFLGEONJM CAHNDBICCFN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HEMGJGMIFHF(NABHEMBKEEJ KHHCBCFNIBN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LAOEDJIJLLH(NABHEMBKEEJ KHHCBCFNIBN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AFFFGHCGIOF(NABHEMBKEEJ KHHCBCFNIBN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CBCJOGKEGAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GONKNMDFGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NNEGNMIMJLO EADHOPJHLBM(int PHHFDMFLENM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NNEGNMIMJLO JGHHNOJNOHD(Guid AFADFHCLPPP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PFMIKJAPLLP(NNEGNMIMJLO HACGEFHOFHL);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CMIBAHPGDIL();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHCHHAHMBKC(NNEGNMIMJLO LEGFDCJMHBB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[HNPBPAPMCJD(HLMJHHDGPFE.Application)]
public interface NLHKDIAKFJE
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJMHIONBAEH(CHEKCLLNAED LEGFDCJMHBB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DPHOKOLFLCJ(CHEKCLLNAED LEGFDCJMHBB);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string FCDEMIMAHJM(CHEKCLLNAED LEGFDCJMHBB);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ELEIJDFNEHF(CHEKCLLNAED LEGFDCJMHBB);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GNDKIPJENHC(CHEKCLLNAED LEGFDCJMHBB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JDKJIIDHKND(CHEKCLLNAED LEGFDCJMHBB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void CFPCILNKLJP(NNEGNMIMJLO JLDCDDGIFPI, int DELBLLLFIEE, NNEGNMIMJLO HNMJHGEPMEL, int NPKPOFLJGKB, [Optional] Vector3? FDJNBPEHPHC, [Optional] Quaternion? KBJNPBHNDMN);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void IKCOFJGFNKK(NNEGNMIMJLO FCIKOFNALCI, NNEGNMIMJLO GGDFGCBGADN);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CHEKCLLNAED : NNEGNMIMJLO, NADCDGMKCFD, IEquatable<NNEGNMIMJLO>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CNEMAADBFDB : NADCDGMKCFD
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	NNEGNMIMJLO MPIGHDDFAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<NNEGNMIMJLO> NPFGGLKEAKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 MCEOCMLDPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion HPKKMMNENOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MEMGKKHMAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool ONMOHOGHMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event CFPCILNKLJP MBCFKGPPNJO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event CFPCILNKLJP OHJFIGILAAE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event CFPCILNKLJP EKFLFBKMPJO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event IKCOFJGFNKK ANJHAPHLCFH;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EOHNLKEPLBJ();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OBMMDJGNFBM();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FFHLDFCOJKK();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CMIJCNGNNIB();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MCOPCDIAMIO();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JCLDJGLDAHF();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GNCGJPJMNCA(int AAPHCEAPPLH, NNEGNMIMJLO HNMJHGEPMEL, int AKEIEPNLHDG);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OIOBPOEEMKL();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LLPENEJOFND(int AAPHCEAPPLH, NNEGNMIMJLO JLDCDDGIFPI, int GFHGBBGBHIN, [Optional] Vector3? FDJNBPEHPHC, [Optional] Quaternion? KBJNPBHNDMN);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NDOLFPPBCBC(NNEGNMIMJLO JLDCDDGIFPI);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IFDEJEIBIOO();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LJDJDAGHOOM(int AGAGKNBDCIG, Vector3 DHLCOAONPFN);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void POBHGOKIKCH(Vector3 GFGIHGEDODJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KLHLEMKOBOK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 PPIHPMIOJPD
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
public interface HHAFMEHNGIH
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool INIDMDEDJFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	JNILGLIIEMB PNHEOIJHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, HHAFMEHNGIH
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
			[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JNILGLIIEMB LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x68324B0", Offset = "0x68318B0", VA = "0x1868324B0")]
		public static ConnectableConfigData LKIBIHAFKGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6832570", Offset = "0x6831970", VA = "0x186832570")]
		public ConnectableConfigData(LegacyConnectableLinkVisual MHJMNFDOKKD, bool MDPJLKJICAB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PNFOJAFHHPK : IEquatable<PNFOJAFHHPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NNEGNMIMJLO HACGEFHOFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int LLCPIKPJEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int MBMMGKGEMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 FDJNBPEHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion KBJNPBHNDMN;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6842700", Offset = "0x6841B00", VA = "0x186842700")]
	public PNFOJAFHHPK(NNEGNMIMJLO HACGEFHOFHL, int LLCPIKPJEFE, int MBMMGKGEMCF, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6842660", Offset = "0x6841A60", VA = "0x186842660")]
	public PNFOJAFHHPK(NNEGNMIMJLO HACGEFHOFHL, int LLCPIKPJEFE, int MBMMGKGEMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6842760", Offset = "0x6841B60", VA = "0x186842760")]
	public PNFOJAFHHPK(NNEGNMIMJLO HACGEFHOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x68421F0", Offset = "0x68415F0", VA = "0x1868421F0", Slot = "4")]
	public bool Equals(PNFOJAFHHPK IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x68422A0", Offset = "0x68416A0", VA = "0x1868422A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class GFINMJFCCLE : HEIFHONACMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform HDODENDDMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private JNILGLIIEMB EOMHGLGLKPN;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x63252D0", Offset = "0x63246D0", VA = "0x1863252D0", Slot = "4")]
	public void MGIGIPLLEKC(Transform HDODENDDMOJ, JNILGLIIEMB EOMHGLGLKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6839760", Offset = "0x6838B60", VA = "0x186839760", Slot = "5")]
	public JNILGLIIEMB KOPMHJOMFAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x68396F0", Offset = "0x6838AF0", VA = "0x1868396F0", Slot = "6")]
	public void FELEFOJGEAN(JNILGLIIEMB PMGKNPLLGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public GFINMJFCCLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class JMJIHLKJHCG : IDisposable, PKKHBEEBBCB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CCBDICAOEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NNEGNMIMJLO oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NNEGNMIMJLO newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public CCBDICAOEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x68316D0", Offset = "0x6830AD0", VA = "0x1868316D0")]
		internal bool KKCHNACIPNA(GIBPGGGFNEN node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly CJKDJECACOH PFFBCBPBFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private OOAFGILGOAG PEEFPFPIFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NAMOCCFCJJC MPECHCIHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool MDPJLKJICAB;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly BADOKLEEAHE EGGOMPMEJPJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public GIBPGGGFNEN JIDLAENMFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x683CAD0", Offset = "0x683BED0", VA = "0x18683CAD0")]
	public bool JIBKNDLIAIA([In] IMKPHJIEKAC LDNEPNAGEGN, bool CAIDLIBHLBH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x683BA30", Offset = "0x683AE30", VA = "0x18683BA30")]
	private bool CDEEMLADHJL([In] IMKPHJIEKAC LDNEPNAGEGN, bool CAIDLIBHLBH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x683EC90", Offset = "0x683E090", VA = "0x18683EC90")]
	public JMJIHLKJHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x683DDA0", Offset = "0x683D1A0", VA = "0x18683DDA0", Slot = "5")]
	public void MGIGIPLLEKC(OBJHDHIKCFI BENNAIJLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x683B8C0", Offset = "0x683ACC0", VA = "0x18683B8C0", Slot = "17")]
	public void AACKNEAOHIA(IMBCDLPNBFA PKJIBFLDCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x683B8F0", Offset = "0x683ACF0", VA = "0x18683B8F0", Slot = "12")]
	public void BBIODIKIALK(Func<NNEGNMIMJLO, bool> IIFDMDOPKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x683B900", Offset = "0x683AD00", VA = "0x18683B900")]
	private void BBIODIKIALK(CJKDJECACOH ILPFPPMNEDJ, Func<NNEGNMIMJLO, bool> IIFDMDOPKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x683EBA0", Offset = "0x683DFA0", VA = "0x18683EBA0", Slot = "11")]
	public void PEAKGLHLALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x683CC30", Offset = "0x683C030", VA = "0x18683CC30", Slot = "8")]
	public bool GPLDPDKCAJK(NNEGNMIMJLO ICDECHAKCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x683E220", Offset = "0x683D620", VA = "0x18683E220")]
	private bool OKOINAJJMBN(NNEGNMIMJLO NCANFCFKBJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x683CA20", Offset = "0x683BE20", VA = "0x18683CA20")]
	private static bool ELCLCDLJKFE(NNEGNMIMJLO NCANFCFKBJI, CJKDJECACOH DJMBMKDEBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x683D260", Offset = "0x683C660", VA = "0x18683D260")]
	private void KHNEPAKCKGA(Transform POONEHHMGDM, CJKDJECACOH KNOAKBACENC, CJKDJECACOH[] GNJMBPDCPDL, NNEGNMIMJLO PIAOGHEMAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x683CAE0", Offset = "0x683BEE0", VA = "0x18683CAE0")]
	private PNFOJAFHHPK GNJIJKKGGJG(Transform GADOEBGKAMP, PNFOJAFHHPK DMPJBOAOEOD)
	{
		return default(PNFOJAFHHPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x683DA60", Offset = "0x683CE60", VA = "0x18683DA60")]
	private static bool LCNEDFOBENC(CJKDJECACOH DJMBMKDEBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x683C3B0", Offset = "0x683B7B0", VA = "0x18683C3B0", Slot = "9")]
	public bool DGIAMIMILDG(NNEGNMIMJLO OAECAALBJCE, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x683D810", Offset = "0x683CC10", VA = "0x18683D810")]
	private bool KPMCEIPGOGN(NNEGNMIMJLO OAECAALBJCE, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x683DC20", Offset = "0x683D020", VA = "0x18683DC20")]
	private static void LDCAENKIKBF(NNEGNMIMJLO OAECAALBJCE, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN, CJKDJECACOH MNGKAICPIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x683D6F0", Offset = "0x683CAF0", VA = "0x18683D6F0")]
	private void KNEPIALFPLN(NNEGNMIMJLO DHDKCLFNMFN, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x683CFF0", Offset = "0x683C3F0", VA = "0x18683CFF0")]
	private void JBOMDDHOMHA(CJKDJECACOH ILPFPPMNEDJ, NNEGNMIMJLO HHECJAMAIEK, NNEGNMIMJLO CHHECICKGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x683CF80", Offset = "0x683C380", VA = "0x18683CF80")]
	private void JBOMDDHOMHA(NNEGNMIMJLO HACGEFHOFHL, NNEGNMIMJLO HHECJAMAIEK, NNEGNMIMJLO CHHECICKGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x683C100", Offset = "0x683B500", VA = "0x18683C100")]
	private void CKACEHCFDII(NNEGNMIMJLO HACGEFHOFHL, NNEGNMIMJLO HHECJAMAIEK, NNEGNMIMJLO CHHECICKGJD, bool OKEKIMNDOCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x683C000", Offset = "0x683B400", VA = "0x18683C000")]
	private void CKACEHCFDII(CJKDJECACOH MILPLABKJCF, NNEGNMIMJLO PIAOGHEMAGL, NNEGNMIMJLO GGDFGCBGADN, bool OKEKIMNDOCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x683EA80", Offset = "0x683DE80", VA = "0x18683EA80")]
	private void PBDHIFGIJCK(NNEGNMIMJLO LGDEAAPGGHL, int GFHGBBGBHIN, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x683E920", Offset = "0x683DD20", VA = "0x18683E920")]
	private void OMFBLIJPKLG(GIBPGGGFNEN KOBAADDGPBN, GIBPGGGFNEN AGECMCAEEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x683CD10", Offset = "0x683C110", VA = "0x18683CD10", Slot = "18")]
	public NNEGNMIMJLO INOPJMJEBKH(NNEGNMIMJLO HACGEFHOFHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x683DE70", Offset = "0x683D270", VA = "0x18683DE70", Slot = "13")]
	public void MNBAIBMGODF(NNEGNMIMJLO HACGEFHOFHL, HashSet<NNEGNMIMJLO> IHDOCFLPGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x683C170", Offset = "0x683B570", VA = "0x18683C170", Slot = "14")]
	public List<NNEGNMIMJLO> DEAPGJHEHPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x683CC40", Offset = "0x683C040", VA = "0x18683CC40")]
	protected GIBPGGGFNEN HJBIJNHBPEP(GIBPGGGFNEN ILPFPPMNEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x683D650", Offset = "0x683CA50", VA = "0x18683D650")]
	protected CJKDJECACOH[] KLAANEDGCMN(CJKDJECACOH DJMBMKDEBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x683CE70", Offset = "0x683C270", VA = "0x18683CE70")]
	protected bool IPILHPFMICH(NNEGNMIMJLO HACGEFHOFHL, [Out] CJKDJECACOH ILPFPPMNEDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x683D060", Offset = "0x683C460", VA = "0x18683D060", Slot = "15")]
	public bool JDNCLJFPNMF(NNEGNMIMJLO HACGEFHOFHL, [Out] PNFOJAFHHPK FDIDAOAENIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x683DE30", Offset = "0x683D230", VA = "0x18683DE30")]
	protected CJKDJECACOH MMALOCCOBGO(PNFOJAFHHPK EJBMGJNPFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x683C9C0", Offset = "0x683BDC0", VA = "0x18683C9C0", Slot = "10")]
	public bool DLIODHDDLCM(NNEGNMIMJLO DHDKCLFNMFN, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x683C410", Offset = "0x683B810", VA = "0x18683C410")]
	private bool DKIKOINNKKF(NNEGNMIMJLO DHDKCLFNMFN, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x683D190", Offset = "0x683C590", VA = "0x18683D190")]
	private static bool JKDOFJNFDHH(CJKDJECACOH GHADFCCBEJJ, PNFOJAFHHPK ILDEFDDKJKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x683CAD0", Offset = "0x683BED0", VA = "0x18683CAD0", Slot = "7")]
	private bool FFOPGGBHIMF([In] IMKPHJIEKAC LDNEPNAGEGN, bool CAIDLIBHLBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class IDBKJDMIPAO : OBJHDHIKCFI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly NFLAEHJHNPL IFELLLJKHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly NAMOCCFCJJC MPECHCIHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly BKGPNEKNMLI AHBMPMCKGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly BGKFBEHOGPN NIGGEKLGPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly PKKHBEEBBCB KHHCBCFNIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal PDBHLENCFNO PKEMJFONHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal EKHANMLDEJA IDIPBKPIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal OOAFGILGOAG NJCNACMBCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool MDPJLKJICAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool LDNPOFKLBFK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GMHDMAJHKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2C90", Offset = "0x9F2090", VA = "0x1809F2C90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B560", Offset = "0x1A2A960", VA = "0x181A2B560")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ENEMNHNNKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2C70", Offset = "0x9F2070", VA = "0x1809F2C70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1A2B540", Offset = "0x1A2A940", VA = "0x181A2B540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool AHKHFPCFFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<NNEGNMIMJLO, NNEGNMIMJLO> FDLPLPNGKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x683A370", Offset = "0x6839770", VA = "0x18683A370", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x683A510", Offset = "0x6839910", VA = "0x18683A510", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<NNEGNMIMJLO, NNEGNMIMJLO> BADFFKKLGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x683A310", Offset = "0x6839710", VA = "0x18683A310", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x683A730", Offset = "0x6839B30", VA = "0x18683A730", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<NNEGNMIMJLO, NNEGNMIMJLO, NNEGNMIMJLO> FAGANADFLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x683A1C0", Offset = "0x68395C0", VA = "0x18683A1C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6839ED0", Offset = "0x68392D0", VA = "0x186839ED0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x683B390", Offset = "0x683A790", VA = "0x18683B390")]
	public IDBKJDMIPAO(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x683A7B0", Offset = "0x6839BB0", VA = "0x18683A7B0", Slot = "12")]
	public void MGIGIPLLEKC(GameObject GODEJCKEDNP, HHAFMEHNGIH CCGMLDOOOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6839F30", Offset = "0x6839330", VA = "0x186839F30", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6839E80", Offset = "0x6839280", VA = "0x186839E80", Slot = "13")]
	public void DKKALNJCGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x683B230", Offset = "0x683A630", VA = "0x18683B230", Slot = "14")]
	public void NLGJOIAOEAN(NNEGNMIMJLO HACGEFHOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x683A220", Offset = "0x6839620", VA = "0x18683A220", Slot = "15")]
	public void NGLMLECLEDL(NNEGNMIMJLO HACGEFHOFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x683B090", Offset = "0x683A490", VA = "0x18683B090", Slot = "22")]
	public bool MOIFJHGOPAB(CGGFLGEONJM CAHNDBICCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6839B50", Offset = "0x6838F50", VA = "0x186839B50")]
	internal bool CDEEMLADHJL([In] IMKPHJIEKAC LDNEPNAGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6839DF0", Offset = "0x68391F0", VA = "0x186839DF0")]
	internal bool DKIKOINNKKF([In] IMKPHJIEKAC LDNEPNAGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6839AB0", Offset = "0x6838EB0", VA = "0x186839AB0")]
	internal bool AAGMPIAKJJA([In] IMKPHJIEKAC LDNEPNAGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x683B0E0", Offset = "0x683A4E0", VA = "0x18683B0E0")]
	internal bool MPKNGBKFKKE([In] IMKPHJIEKAC LDNEPNAGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6839C10", Offset = "0x6839010", VA = "0x186839C10")]
	internal void CENNNLHFOAL(NNEGNMIMJLO HACGEFHOFHL, int JGOMAAKBFDO, bool CAIDLIBHLBH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x683A220", Offset = "0x6839620", VA = "0x18683A220")]
	internal bool GIHBKDNOMNB(NNEGNMIMJLO FFKDNCEJODA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x683B250", Offset = "0x683A650", VA = "0x18683B250")]
	internal bool PPLPOMFLDGE(NNEGNMIMJLO OAECAALBJCE, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x683AF90", Offset = "0x683A390", VA = "0x18683AF90", Slot = "16")]
	public void MNBAIBMGODF(NNEGNMIMJLO HACGEFHOFHL, HashSet<NNEGNMIMJLO> KNDONKCMKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x683AD80", Offset = "0x683A180", VA = "0x18683AD80", Slot = "17")]
	public void MMACPEABOBH(NNEGNMIMJLO OAECAALBJCE, NNEGNMIMJLO CDCICKNCAIH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x683A3D0", Offset = "0x68397D0", VA = "0x18683A3D0", Slot = "18")]
	public void INLAHECPGGH(NNEGNMIMJLO DHDKCLFNMFN, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6839FF0", Offset = "0x68393F0", VA = "0x186839FF0", Slot = "19")]
	public void FLDNDGJJICO(NNEGNMIMJLO DHDKCLFNMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x683A570", Offset = "0x6839970", VA = "0x18683A570")]
	public void KPLMAENHHOA([Optional] ODEPIIMLPHI EJLHHGOMMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x683A280", Offset = "0x6839680", VA = "0x18683A280", Slot = "23")]
	public void HEMGJGMIFHF(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x683A790", Offset = "0x6839B90", VA = "0x18683A790", Slot = "20")]
	public NABHEMBKEEJ LGBHFIEHOJB(bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6839FD0", Offset = "0x68393D0", VA = "0x186839FD0", Slot = "21")]
	public NABHEMBKEEJ FEOAMFOOKDN(HashSet<Guid> IFOLKEMLIOA, bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6839B10", Offset = "0x6838F10", VA = "0x186839B10", Slot = "25")]
	public void AFFFGHCGIOF(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x683A680", Offset = "0x6839A80", VA = "0x18683A680", Slot = "24")]
	public void LAOEDJIJLLH(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class NAMOCCFCJJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly FGIECLHLMKA<NNEGNMIMJLO, NNEGNMIMJLO> FDLPLPNGKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FGIECLHLMKA<NNEGNMIMJLO, NNEGNMIMJLO> BADFFKKLGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly DMOKIFNKBFF<NNEGNMIMJLO, NNEGNMIMJLO, NNEGNMIMJLO> FAGANADFLIJ;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6841DA0", Offset = "0x68411A0", VA = "0x186841DA0")]
	public NAMOCCFCJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	public void MGIGIPLLEKC(IDBKJDMIPAO BENNAIJLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6841C60", Offset = "0x6841060", VA = "0x186841C60")]
	public void GGMDIMABIFN(NNEGNMIMJLO KOBAADDGPBN, NNEGNMIMJLO LGDEAAPGGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6841D40", Offset = "0x6841140", VA = "0x186841D40")]
	public void OBPBJBFGDFC(NNEGNMIMJLO KOBAADDGPBN, NNEGNMIMJLO LGDEAAPGGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6841CC0", Offset = "0x68410C0", VA = "0x186841CC0")]
	public void MMIPDMALFHA(NNEGNMIMJLO NMENDHGIKLP, NNEGNMIMJLO DADNCNLHDCH, NNEGNMIMJLO LGDEAAPGGHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class BKGPNEKNMLI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private IDBKJDMIPAO BENNAIJLPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private EKHANMLDEJA IDIPBKPIPIO;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public BKGPNEKNMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x68314F0", Offset = "0x68308F0", VA = "0x1868314F0")]
	public void MGIGIPLLEKC(IDBKJDMIPAO BENNAIJLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x68312E0", Offset = "0x68306E0", VA = "0x1868312E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x68312C0", Offset = "0x68306C0", VA = "0x1868312C0")]
	private void AFBCLHDONOG(ODEPIIMLPHI MPPBKBAPBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6831250", Offset = "0x6830650", VA = "0x186831250")]
	private void ADINOIOOAPL(ODEPIIMLPHI FLGHPJAKOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x68312F0", Offset = "0x68306F0", VA = "0x1868312F0")]
	public void LBDHNGHGJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x68313F0", Offset = "0x68307F0", VA = "0x1868313F0")]
	public void LFHNPFAMKFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class HNIEJMJHLIN
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AJIFLOFLION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NFLAEHJHNPL container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public AJIFLOFLION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x682D540", Offset = "0x682C940", VA = "0x18682D540")]
		internal IDBKJDMIPAO DMALAFHMEOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x68398B0", Offset = "0x6838CB0", VA = "0x1868398B0")]
	public static void NCHGKDEAMJE(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6839830", Offset = "0x6838C30", VA = "0x186839830")]
	public static void IAPNMKPKPDL(NFLAEHJHNPL IFELLLJKHDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class BDFEJFFLLJB : IDisposable, OOAFGILGOAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, JNILGLIIEMB> OHOBNFBCIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IMBCDLPNBFA JLAHJAENNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private HEIFHONACMG NKABFOIIBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PKKHBEEBBCB KHHCBCFNIBN;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x682E130", Offset = "0x682D530", VA = "0x18682E130")]
	public BDFEJFFLLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x682DDE0", Offset = "0x682D1E0", VA = "0x18682DDE0", Slot = "7")]
	public void MGIGIPLLEKC(PKKHBEEBBCB KHHCBCFNIBN, HEIFHONACMG NKABFOIIBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x682DEF0", Offset = "0x682D2F0", VA = "0x18682DEF0", Slot = "5")]
	public void NEHJGAMABAC(GIBPGGGFNEN OJPBKHHLHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x682D5B0", Offset = "0x682C9B0", VA = "0x18682D5B0", Slot = "9")]
	public void AGNGBEIDEIJ(GIBPGGGFNEN PIHGPBPHHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x682DA70", Offset = "0x682CE70", VA = "0x18682DA70", Slot = "8")]
	public void CPAPPJLCJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x682D720", Offset = "0x682CB20", VA = "0x18682D720", Slot = "10")]
	public void CGMNOLHJCEG(GIBPGGGFNEN AMDEDOMDCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x682DE20", Offset = "0x682D220", VA = "0x18682DE20", Slot = "11")]
	public void MOHKFMBLMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x682DC30", Offset = "0x682D030", VA = "0x18682DC30")]
	private bool LKNEIBLGMHE(GIBPGGGFNEN DMNNLPDGIGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class BGKFBEHOGPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct MPCEIIFHOHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CJKDJECACOH JGGNKAFEAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> IFOLKEMLIOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly CGGFLGEONJM ALMKCOMAONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly CGGFLGEONJM IDOENPENHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool BMGKAEFEDOB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool OMKENFIDAGN
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6841630", Offset = "0x6840A30", VA = "0x186841630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6841BF0", Offset = "0x6840FF0", VA = "0x186841BF0")]
		public MPCEIIFHOHC(CJKDJECACOH JGGNKAFEAPH, HashSet<Guid> IFOLKEMLIOA, bool BMGKAEFEDOB, [Optional] CGGFLGEONJM ALMKCOMAONH, [Optional] CGGFLGEONJM IDOENPENHAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6841490", Offset = "0x6840890", VA = "0x186841490")]
		public CGGFLGEONJM KPIBKDOHBCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6841750", Offset = "0x6840B50", VA = "0x186841750")]
		private CGGFLGEONJM NBJCPDCKDHH([Out] CGGFLGEONJM LCIAIJBFCPH, [Out] CGGFLGEONJM JEMNJAFNMJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x68419D0", Offset = "0x6840DD0", VA = "0x1868419D0")]
		private CGGFLGEONJM OMINHKJIANL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6841320", Offset = "0x6840720", VA = "0x186841320")]
		private void HCIBJFIJHLI(CGGFLGEONJM CIBFCBNGLPG, CGGFLGEONJM CEBEDIEJMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6841810", Offset = "0x6840C10", VA = "0x186841810")]
		private void NBLNNAJMOLE(CGGFLGEONJM LCIAIJBFCPH, CGGFLGEONJM JEMNJAFNMJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private IDBKJDMIPAO BENNAIJLPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private PKKHBEEBBCB KHHCBCFNIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private OOAFGILGOAG PEEFPFPIFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private EKHANMLDEJA IDIPBKPIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool HOOIGKEHEDI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool HKGBKBKNBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x682EAD0", Offset = "0x682DED0", VA = "0x18682EAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool GMHDMAJHKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x682F1B0", Offset = "0x682E5B0", VA = "0x18682F1B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x682F400", Offset = "0x682E800", VA = "0x18682F400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6830E70", Offset = "0x6830270", VA = "0x186830E70")]
	public void MGIGIPLLEKC(IDBKJDMIPAO BENNAIJLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x68308F0", Offset = "0x682FCF0", VA = "0x1868308F0")]
	public NABHEMBKEEJ LGBHFIEHOJB(bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x682EB20", Offset = "0x682DF20", VA = "0x18682EB20")]
	public NABHEMBKEEJ FEOAMFOOKDN(HashSet<Guid> IFOLKEMLIOA, bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x682F9C0", Offset = "0x682EDC0", VA = "0x18682F9C0")]
	public void HEMGJGMIFHF(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6830850", Offset = "0x682FC50", VA = "0x186830850")]
	public void LAOEDJIJLLH(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68311B0", Offset = "0x68305B0", VA = "0x1868311B0")]
	public void NBAPDDGGBJJ(NABHEMBKEEJ KHHCBCFNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x682E760", Offset = "0x682DB60", VA = "0x18682E760")]
	private void DPPLCIGNIMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x682F1D0", Offset = "0x682E5D0", VA = "0x18682F1D0")]
	private CGGFLGEONJM FLGBANEGAIL(CJKDJECACOH ILPFPPMNEDJ, bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x682F770", Offset = "0x682EB70", VA = "0x18682F770")]
	private static void GDLKFFFMJEM(CJKDJECACOH ILPFPPMNEDJ, bool BMGKAEFEDOB, CGGFLGEONJM CAHNDBICCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x682E3A0", Offset = "0x682D7A0", VA = "0x18682E3A0")]
	private void CEGDKINGBKI(CJKDJECACOH ILPFPPMNEDJ, bool BMGKAEFEDOB, CGGFLGEONJM CAHNDBICCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x682E6D0", Offset = "0x682DAD0", VA = "0x18682E6D0")]
	private CGGFLGEONJM DKCOPKOMJOK(CJKDJECACOH JGGNKAFEAPH, HashSet<Guid> IFOLKEMLIOA, bool BMGKAEFEDOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x682FF50", Offset = "0x682F350", VA = "0x18682FF50")]
	private bool JHEGCPGFOPK(NABHEMBKEEJ KEPPBIMLNPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68301E0", Offset = "0x682F5E0", VA = "0x1868301E0")]
	private bool KLGOGFBBINP(CGGFLGEONJM CAHNDBICCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x682E6B0", Offset = "0x682DAB0", VA = "0x18682E6B0")]
	private bool DEMGJNKEBJE(NABHEMBKEEJ KHHCBCFNIBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x682FCB0", Offset = "0x682F0B0", VA = "0x18682FCB0")]
	private static bool IFBCBKEFEDF(CGGFLGEONJM CAHNDBICCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6830F20", Offset = "0x6830320", VA = "0x186830F20")]
	public static bool MOIFJHGOPAB(CGGFLGEONJM CAHNDBICCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x682F420", Offset = "0x682E820", VA = "0x18682F420")]
	private NNEGNMIMJLO GCMAPCGDBLL(CGGFLGEONJM CAHNDBICCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x682E950", Offset = "0x682DD50", VA = "0x18682E950")]
	private NNEGNMIMJLO EADHOPJHLBM(CGGFLGEONJM CAHNDBICCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x682E210", Offset = "0x682D610", VA = "0x18682E210")]
	private NNEGNMIMJLO BCGPNJJMIAA(CGGFLGEONJM CAHNDBICCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6830EE0", Offset = "0x68302E0", VA = "0x186830EE0")]
	private static Guid MNPCGIMDACO(CGGFLGEONJM CAHNDBICCFN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x682E5C0", Offset = "0x682D9C0", VA = "0x18682E5C0")]
	private string DDJABDHHHJE(CGGFLGEONJM CAHNDBICCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x682FDD0", Offset = "0x682F1D0", VA = "0x18682FDD0")]
	private bool ILMCMJIOOBJ(CJKDJECACOH ILPFPPMNEDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x682FA50", Offset = "0x682EE50", VA = "0x18682FA50")]
	private static void HGNMJFKNMFH(CJKDJECACOH JGGNKAFEAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public BGKFBEHOGPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct IMKPHJIEKAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NNEGNMIMJLO LGDEAAPGGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NNEGNMIMJLO KOBAADDGPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int GFHGBBGBHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int AKEIEPNLHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 FDJNBPEHPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion KBJNPBHNDMN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public PNFOJAFHHPK OJJNDICGOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x683B780", Offset = "0x683AB80", VA = "0x18683B780")]
		get
		{
			return default(PNFOJAFHHPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PNFOJAFHHPK AECGOHIKGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x683B820", Offset = "0x683AC20", VA = "0x18683B820")]
		get
		{
			return default(PNFOJAFHHPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x683B850", Offset = "0x683AC50", VA = "0x18683B850")]
	public IMKPHJIEKAC(NNEGNMIMJLO LGDEAAPGGHL, NNEGNMIMJLO KOBAADDGPBN, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface PKKHBEEBBCB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GIBPGGGFNEN JIDLAENMFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGIGIPLLEKC(OBJHDHIKCFI BENNAIJLPHL);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JIBKNDLIAIA([In] IMKPHJIEKAC LDNEPNAGEGN, bool CAIDLIBHLBH = true);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GPLDPDKCAJK(NNEGNMIMJLO ICDECHAKCGM);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DGIAMIMILDG(NNEGNMIMJLO OAECAALBJCE, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DLIODHDDLCM(NNEGNMIMJLO DHDKCLFNMFN, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PEAKGLHLALK();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BBIODIKIALK(Func<NNEGNMIMJLO, bool> IIFDMDOPKOL);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MNBAIBMGODF(NNEGNMIMJLO HACGEFHOFHL, HashSet<NNEGNMIMJLO> IHDOCFLPGPN);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<NNEGNMIMJLO> DEAPGJHEHPD();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JDNCLJFPNMF(NNEGNMIMJLO HACGEFHOFHL, [Out] PNFOJAFHHPK FDIDAOAENIL);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AACKNEAOHIA(IMBCDLPNBFA PKJIBFLDCKK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool IMBCDLPNBFA(GIBPGGGFNEN ILPFPPMNEDJ);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface GIBPGGGFNEN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NNEGNMIMJLO DGEKMHAAJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	GIBPGGGFNEN EOCBFDAOCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	PNFOJAFHHPK EJPECJMJBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool LJPHFOMHNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JNILGLIIEMB : DDOMJCDMBBI.ONLDOEPOMAH
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGMBKGHFJON(NNEGNMIMJLO HNMJHGEPMEL, PNFOJAFHHPK LGDEAAPGGHL);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKAFDKNBFFD(NNEGNMIMJLO HNMJHGEPMEL, PNFOJAFHHPK LGDEAAPGGHL);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LJCMCGGDMLE(NNEGNMIMJLO HNMJHGEPMEL, PNFOJAFHHPK LGDEAAPGGHL);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEBGAHIFLPF(NNEGNMIMJLO HNMJHGEPMEL, PNFOJAFHHPK LGDEAAPGGHL);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JNILGLIIEMB Instantiate(Transform HDODENDDMOJ);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDBCEOANHGG();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HEIFHONACMG
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGIGIPLLEKC(Transform HDODENDDMOJ, JNILGLIIEMB EOMHGLGLKPN);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JNILGLIIEMB KOPMHJOMFAD();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FELEFOJGEAN(JNILGLIIEMB PMGKNPLLGIO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface PDBHLENCFNO : CBCJOGKEGAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJLEBJJPDGP(Guid JPDECNJMLJL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface OOAFGILGOAG
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEHJGAMABAC(GIBPGGGFNEN OJPBKHHLHEH);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGIGIPLLEKC(PKKHBEEBBCB KHHCBCFNIBN, HEIFHONACMG PEHDFPJHEIN);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPAPPJLCJIH();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGNGBEIDEIJ(GIBPGGGFNEN PIHGPBPHHLB);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGMNOLHJCEG(GIBPGGGFNEN AMDEDOMDCAG);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MOHKFMBLMDO();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class CJKDJECACOH : GIBPGGGFNEN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class ENCELFEKPEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public PNFOJAFHHPK nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CJKDJECACOH foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public ENCELFEKPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6838C60", Offset = "0x6838060", VA = "0x186838C60")]
		internal bool LGGBEAPNDHK(GIBPGGGFNEN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private PNFOJAFHHPK FDIDAOAENIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<CJKDJECACOH> BKLBHPKCBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private CJKDJECACOH PNODEGFEEOC;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public PNFOJAFHHPK EJPECJMJBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x38FB060", Offset = "0x38FA460", VA = "0x1838FB060", Slot = "6")]
		get
		{
			return default(PNFOJAFHHPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6831D10", Offset = "0x6831110", VA = "0x186831D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private CJKDJECACOH KOBAADDGPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6831C10", Offset = "0x6831010", VA = "0x186831C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GIBPGGGFNEN EOCBFDAOCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NNEGNMIMJLO DGEKMHAAJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LJPHFOMHNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x68323F0", Offset = "0x68317F0", VA = "0x1868323F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DEMCDBMEFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6831D40", Offset = "0x6831140", VA = "0x186831D40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected CJKDJECACOH MILPLABKJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6831CF0", Offset = "0x68310F0", VA = "0x186831CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6832400", Offset = "0x6831800", VA = "0x186832400")]
	public CJKDJECACOH(PNFOJAFHHPK KMPBAHAGFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x68322A0", Offset = "0x68316A0", VA = "0x1868322A0")]
	public CJKDJECACOH PFOLEMCNFJG(PNFOJAFHHPK GOHOFHLEOEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6832070", Offset = "0x6831470", VA = "0x186832070")]
	public CJKDJECACOH NCLHOOOPNFN(PNFOJAFHHPK LKKGBBKEGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6831D90", Offset = "0x6831190", VA = "0x186831D90")]
	public CJKDJECACOH LHAIFCNDDDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6831AC0", Offset = "0x6830EC0", VA = "0x186831AC0")]
	public void IHJLNMEMMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x68321F0", Offset = "0x68315F0", VA = "0x1868321F0")]
	public CJKDJECACOH PEKPGKOCFIJ(PNFOJAFHHPK DADNCNLHDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6831960", Offset = "0x6830D60", VA = "0x186831960")]
	private static void AACKNEAOHIA(CJKDJECACOH CIIOILLIIJM, IMBCDLPNBFA HECMIIICJJG, bool FFNGGGEJEPB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6831950", Offset = "0x6830D50", VA = "0x186831950", Slot = "9")]
	public void AACKNEAOHIA(IMBCDLPNBFA PKJIBFLDCKK, bool OKEKIMNDOCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6831F70", Offset = "0x6831370", VA = "0x186831F70")]
	public static CJKDJECACOH MMALOCCOBGO(CJKDJECACOH CIIOILLIIJM, PNFOJAFHHPK NNKANMCHDGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface EKHANMLDEJA
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool HKGBKBKNBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool GONKNMDFGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<ODEPIIMLPHI> AFBCLHDONOG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<ODEPIIMLPHI> ADINOIOOAPL;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(IDBKJDMIPAO BENNAIJLPHL);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(NNEGNMIMJLO OAECAALBJCE, NNEGNMIMJLO CDCICKNCAIH, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(NNEGNMIMJLO DHDKCLFNMFN, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(NABHEMBKEEJ NGBJMGLGGBD, [Optional] ODEPIIMLPHI EJLHHGOMMPD);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, EKHANMLDEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private IDBKJDMIPAO BENNAIJLPHL;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool HKGBKBKNBIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6840D30", Offset = "0x6840130", VA = "0x186840D30", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool GONKNMDFGEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6840D90", Offset = "0x6840190", VA = "0x186840D90", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<ODEPIIMLPHI> AFBCLHDONOG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6840C80", Offset = "0x6840080", VA = "0x186840C80", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6840E80", Offset = "0x6840280", VA = "0x186840E80", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<ODEPIIMLPHI> ADINOIOOAPL
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6840BD0", Offset = "0x683FFD0", VA = "0x186840BD0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6840DD0", Offset = "0x68401D0", VA = "0x186840DD0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8541A0", Offset = "0x8535A0", VA = "0x1808541A0", Slot = "19")]
		public void SetManager(IDBKJDMIPAO BENNAIJLPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6840BA0", Offset = "0x683FFA0", VA = "0x186840BA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x683F920", Offset = "0x683ED20", VA = "0x18683F920", Slot = "23")]
		public void RequestMasterConnectNodes(NNEGNMIMJLO JLDCDDGIFPI, int GFHGBBGBHIN, NNEGNMIMJLO HNMJHGEPMEL, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x683FA50", Offset = "0x683EE50", VA = "0x18683FA50", Slot = "24")]
		public void RequestMasterDisconnectNode(NNEGNMIMJLO ICDECHAKCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x683FB10", Offset = "0x683EF10", VA = "0x18683FB10", Slot = "20")]
		public void RequestMasterModifyNode(NNEGNMIMJLO OAECAALBJCE, NNEGNMIMJLO CDCICKNCAIH, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x683FC40", Offset = "0x683F040", VA = "0x18683FC40", Slot = "21")]
		public void RequestMasterReparentNodes(NNEGNMIMJLO DHDKCLFNMFN, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x683FD70", Offset = "0x683F170", VA = "0x18683FD70", Slot = "25")]
		public void RequestMasterReparentToRoot(NNEGNMIMJLO DHDKCLFNMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x683F7F0", Offset = "0x683EBF0", VA = "0x18683F7F0", Slot = "22")]
		public void RequestDeserializeConnectableGraph(NABHEMBKEEJ NGBJMGLGGBD, [Optional] ODEPIIMLPHI EJLHHGOMMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6840150", Offset = "0x683F550", VA = "0x186840150")]
		[FGKHJABDADH]
		private void RpcMasterConnectNodes(NNEGNMIMJLO JLDCDDGIFPI, int GFHGBBGBHIN, NNEGNMIMJLO HNMJHGEPMEL, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6840410", Offset = "0x683F810", VA = "0x186840410")]
		[FGKHJABDADH]
		private void RpcMasterDisconnectNode(NNEGNMIMJLO ICDECHAKCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6840750", Offset = "0x683FB50", VA = "0x186840750")]
		[FGKHJABDADH]
		private void RpcMasterReparentNodes(NNEGNMIMJLO DHDKCLFNMFN, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6840550", Offset = "0x683F950", VA = "0x186840550")]
		[FGKHJABDADH]
		private void RpcMasterModifyNode(NNEGNMIMJLO OAECAALBJCE, NNEGNMIMJLO CDCICKNCAIH, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x683FF40", Offset = "0x683F340", VA = "0x18683FF40")]
		[FGKHJABDADH]
		private void RpcConnectNodes(NNEGNMIMJLO JLDCDDGIFPI, int GFHGBBGBHIN, NNEGNMIMJLO HNMJHGEPMEL, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN, NAOPOJHEJPO CFMHGEEAFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x68400C0", Offset = "0x683F4C0", VA = "0x1868400C0")]
		[FGKHJABDADH]
		private void RpcDisconnectNode(NNEGNMIMJLO ICDECHAKCGM, NAOPOJHEJPO CFMHGEEAFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6840AA0", Offset = "0x683FEA0", VA = "0x186840AA0")]
		[FGKHJABDADH]
		private void RpcReparentNodes(NNEGNMIMJLO DHDKCLFNMFN, int CBEFEMCFHDJ, NNEGNMIMJLO DADNCNLHDCH, int KFNCNBHDCFH, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN, NAOPOJHEJPO CFMHGEEAFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x68409E0", Offset = "0x683FDE0", VA = "0x1868409E0")]
		[FGKHJABDADH]
		private void RpcModifyNode(NNEGNMIMJLO OAECAALBJCE, int GFHGBBGBHIN, int AKEIEPNLHDG, Vector3 FDJNBPEHPHC, Quaternion KBJNPBHNDMN, NAOPOJHEJPO CFMHGEEAFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6840080", Offset = "0x683F480", VA = "0x186840080")]
		[FGKHJABDADH]
		private void RpcDeserializeConnectableGraph(NABHEMBKEEJ KHHCBCFNIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x868090", Offset = "0x867490", VA = "0x180868090")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, JNILGLIIEMB, DDOMJCDMBBI.ONLDOEPOMAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x683F030", Offset = "0x683E430", VA = "0x18683F030", Slot = "4")]
		private void IDOAAEGLIKA(NNEGNMIMJLO HNMJHGEPMEL, PNFOJAFHHPK LGDEAAPGGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x683F2C0", Offset = "0x683E6C0", VA = "0x18683F2C0", Slot = "5")]
		private void KBMHBCMFPAL(NNEGNMIMJLO HNMJHGEPMEL, PNFOJAFHHPK LGDEAAPGGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x683F1B0", Offset = "0x683E5B0", VA = "0x18683F1B0", Slot = "6")]
		private void JMEDJNNEENK(NNEGNMIMJLO HNMJHGEPMEL, PNFOJAFHHPK LGDEAAPGGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x683F5A0", Offset = "0x683E9A0", VA = "0x18683F5A0", Slot = "7")]
		private void OAAGBLHABBD(NNEGNMIMJLO HNMJHGEPMEL, PNFOJAFHHPK LGDEAAPGGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x683F530", Offset = "0x683E930", VA = "0x18683F530", Slot = "8")]
		private JNILGLIIEMB MODDFHDFBHK(Transform HDODENDDMOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x683F790", Offset = "0x683EB90", VA = "0x18683F790", Slot = "9")]
		private void OCPMEJNBLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DOOFDJHHJIN
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x299E030", Offset = "0x299D430", VA = "0x18299E030")]
	public static CDLDGHDELAD<T> GBJAHNPHEGL<T>(this NFLAEHJHNPL IFELLLJKHDO)
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
