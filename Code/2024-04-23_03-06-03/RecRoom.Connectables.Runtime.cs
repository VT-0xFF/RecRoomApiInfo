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
	public class LogRegistrationIndex : PPFIOIJOILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x621C850", Offset = "0x621B850", VA = "0x18621C850", Slot = "4")]
		public override void GGEFLGLPFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
	public class _AssemblyIndex : CDBADINMILA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private FHIBGGCBLGM bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private FHIBGGCBLGM bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6220230", Offset = "0x621F230", VA = "0x186220230", Slot = "5")]
		public override void PCDBKALOINM(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6220270", Offset = "0x621F270", VA = "0x186220270")]
		private void PGAGGJGHCFI(ONLPPOONLNB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x621FD80", Offset = "0x621ED80", VA = "0x18621FD80")]
		private void AJLHIJGFCAL(ONLPPOONLNB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x621FEF0", Offset = "0x621EEF0", VA = "0x18621FEF0", Slot = "6")]
		public override void LKKAGAMGGHO(ONLPPOONLNB registry, [In] NOJHENBCIAB filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "8")]
		public override void OEBDDKFLPEG(LILEGJCEJGA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62203E0", Offset = "0x621F3E0", VA = "0x1862203E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class BHHMKNGOHEE : FLJIJHFJFKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class EMBPPFOFLGL : IEnumerable<CKAEKGBHCFC>, IEnumerable, IEnumerator<CKAEKGBHCFC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private CKAEKGBHCFC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private NOFNFJEBPPG localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NOFNFJEBPPG <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BHHMKNGOHEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NHGHMDMJDML <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private BPHEFFILCAL.CIFCPPDBNDP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CKAEKGBHCFC System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8164C0", Offset = "0x8154C0", VA = "0x1808164C0")]
		[DebuggerHidden]
		public EMBPPFOFLGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6212A90", Offset = "0x6211A90", VA = "0x186212A90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62125D0", Offset = "0x62115D0", VA = "0x1862125D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62125B0", Offset = "0x62115B0", VA = "0x1862125B0")]
		private void HPAIKACEAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6212A40", Offset = "0x6211A40", VA = "0x186212A40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6212990", Offset = "0x6211990", VA = "0x186212990", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CKAEKGBHCFC> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6212990", Offset = "0x6211990", VA = "0x186212990", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly NDLEKAMCBHL EOLIFNBMCEG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly NDLEKAMCBHL JJEBDFJAELM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly NDLEKAMCBHL ACEIGAGNFAI;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly NDLEKAMCBHL LEMDDAHIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PDLIOLLJFGJ DGAPLGABMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IKLKAFPKEDF KGKFKMCFLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private OJDLIIODLKN AFKEJAIONMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private EHLJFJEEFAB AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AAPFLIKBDKG ECDDAALBKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CGPIPJGCIAG JIMAIACHILI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NPKMANILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D2500", Offset = "0x7D1500", VA = "0x1807D2500", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D2100", Offset = "0x7D1100", VA = "0x1807D2100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MJPHFNACNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<CKAEKGBHCFC, CKAEKGBHCFC> MNNMMPGINBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x620BE90", Offset = "0x620AE90", VA = "0x18620BE90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x620CA10", Offset = "0x620BA10", VA = "0x18620CA10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<CKAEKGBHCFC, CKAEKGBHCFC> CECHCGHFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x620CE80", Offset = "0x620BE80", VA = "0x18620CE80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x620DDB0", Offset = "0x620CDB0", VA = "0x18620DDB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<CKAEKGBHCFC, CKAEKGBHCFC, CKAEKGBHCFC> FMNHGPPADOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x620BF40", Offset = "0x620AF40", VA = "0x18620BF40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x620B400", Offset = "0x620A400", VA = "0x18620B400", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x620ED70", Offset = "0x620DD70", VA = "0x18620ED70")]
	public BHHMKNGOHEE(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x620B100", Offset = "0x620A100", VA = "0x18620B100", Slot = "12")]
	public void CJMKLAKCCOG(GameObject HOHLOJNOGCD, EKLIHBOIDFA HGMJMIDJPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x620BA20", Offset = "0x620AA20", VA = "0x18620BA20", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x620D340", Offset = "0x620C340", VA = "0x18620D340", Slot = "22")]
	public bool LPEJHNKAGHB(AJALNDPKGLA ECPKNLIIEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x620A920", Offset = "0x6209920", VA = "0x18620A920")]
	private void AHMEECIPNPL(NOFNFJEBPPG GFOIAHGKPOM, NOFNFJEBPPG AEPPHFKPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x620AEE0", Offset = "0x6209EE0", VA = "0x18620AEE0")]
	private void CCCGOHPGJBN(NOFNFJEBPPG GFOIAHGKPOM, NOFNFJEBPPG EHFJBFNCFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x620E770", Offset = "0x620D770", VA = "0x18620E770")]
	private void PNNBKIDPMNC(NOFNFJEBPPG GFOIAHGKPOM, NOFNFJEBPPG EHFJBFNCFBF, NOFNFJEBPPG AEPPHFKPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x620DE60", Offset = "0x620CE60", VA = "0x18620DE60")]
	private void OBAEICJPBKO(NOFNFJEBPPG GFOIAHGKPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "13")]
	public void ACILEHIEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x620BFF0", Offset = "0x620AFF0", VA = "0x18620BFF0", Slot = "14")]
	public void GGEFLGLPFBG(CKAEKGBHCFC DLLAJEJNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "15")]
	public void IEOHJNELHNB(CKAEKGBHCFC DLLAJEJNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x620A7C0", Offset = "0x62097C0", VA = "0x18620A7C0", Slot = "17")]
	public void AHIPKKGEHKB(CKAEKGBHCFC DLLAJEJNDGL, CKAEKGBHCFC KCPMKMACHFP, Vector3 CMCMKLBCKPK, Quaternion JOFKHOOOHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x620A680", Offset = "0x6209680", VA = "0x18620A680")]
	public void AHIPKKGEHKB(NOFNFJEBPPG HJKHNDILIPH, NOFNFJEBPPG KCPMKMACHFP, Vector3 CMCMKLBCKPK, Quaternion JOFKHOOOHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x620CB70", Offset = "0x620BB70", VA = "0x18620CB70")]
	public void JOHNCEJOLOD(CKAEKGBHCFC DLLAJEJNDGL, float MHKKHPKKOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x620B8D0", Offset = "0x620A8D0", VA = "0x18620B8D0", Slot = "18")]
	public void DLECPPJINHP(CKAEKGBHCFC IFDCDKCJMKK, int COPDJMIKHBD, CKAEKGBHCFC FCBPDJOLFAD, int CKNMIEBFNLF, Vector3 CMCMKLBCKPK, Quaternion JOFKHOOOHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x620CAC0", Offset = "0x620BAC0", VA = "0x18620CAC0")]
	private float JHIIMPJMEMP(NOFNFJEBPPG HJKHNDILIPH, NOFNFJEBPPG NNHBJFPLAAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x620B740", Offset = "0x620A740", VA = "0x18620B740")]
	public void DLECPPJINHP(NOFNFJEBPPG HJKHNDILIPH, NOFNFJEBPPG NNHBJFPLAAA, Vector3 CMCMKLBCKPK, Quaternion JOFKHOOOHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x620B870", Offset = "0x620A870", VA = "0x18620B870")]
	public void DLECPPJINHP(NOFNFJEBPPG HJKHNDILIPH, NOFNFJEBPPG NNHBJFPLAAA, Vector3 CMCMKLBCKPK, Quaternion JOFKHOOOHCD, float MHKKHPKKOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x620CC00", Offset = "0x620BC00", VA = "0x18620CC00", Slot = "19")]
	public void KCOLBJKDAIN(CKAEKGBHCFC DLLAJEJNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x620B4B0", Offset = "0x620A4B0", VA = "0x18620B4B0")]
	public bool DBENNJACCFD(NOFNFJEBPPG OJJIOPECNPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x620E9F0", Offset = "0x620D9F0", VA = "0x18620E9F0", Slot = "16")]
	public void POOFIGJBIHP(CKAEKGBHCFC DLLAJEJNDGL, HashSet<CKAEKGBHCFC> LPLIOMLNGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "20")]
	public NIGLHNNEBCE PPNNFDCNNMJ(bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "21")]
	public NIGLHNNEBCE PKDPCMKHPJL(HashSet<Guid> ELCJPNLHFGI, bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x620A610", Offset = "0x6209610", VA = "0x18620A610", Slot = "23")]
	public void AGGGBMIGDIA(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x620ACE0", Offset = "0x6209CE0", VA = "0x18620ACE0", Slot = "24")]
	public void BJHEPJIPBAF(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x620AB30", Offset = "0x6209B30", VA = "0x18620AB30", Slot = "25")]
	public void AJMKFHDENJJ(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x620C640", Offset = "0x620B640", VA = "0x18620C640")]
	private void IIFGDPLKJPO(NOFNFJEBPPG HJKHNDILIPH, NOFNFJEBPPG NNHBJFPLAAA, Vector3 CMCMKLBCKPK, Quaternion JOFKHOOOHCD, float MHKKHPKKOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x620CF30", Offset = "0x620BF30", VA = "0x18620CF30")]
	private void LIEGMCHKAHL(NOFNFJEBPPG HJKHNDILIPH, NOFNFJEBPPG GFOFKCGAIPE, Vector3 CMCMKLBCKPK, Quaternion JOFKHOOOHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x620C9A0", Offset = "0x620B9A0", VA = "0x18620C9A0")]
	private void IIPABJMEBAG(NOFNFJEBPPG HJKHNDILIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x620B370", Offset = "0x620A370", VA = "0x18620B370")]
	[IteratorStateMachine(typeof(EMBPPFOFLGL))]
	public IEnumerable<CKAEKGBHCFC> CKBIEGJAKLE(NOFNFJEBPPG OJJIOPECNPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x620DC70", Offset = "0x620CC70", VA = "0x18620DC70")]
	internal CKAEKGBHCFC NHAGLODGEFB(NOFNFJEBPPG OJJIOPECNPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x620E520", Offset = "0x620D520", VA = "0x18620E520")]
	internal NOFNFJEBPPG PHKMMLGONEN(CKAEKGBHCFC DLLAJEJNDGL)
	{
		return default(NOFNFJEBPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x620D350", Offset = "0x620C350", VA = "0x18620D350")]
	private bool NEIKMIBDICK(AJALNDPKGLA ECPKNLIIEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x620C300", Offset = "0x620B300", VA = "0x18620C300")]
	private bool GHFLHPCAJAM(AJALNDPKGLA ECPKNLIIEJD, [Out] CKAEKGBHCFC NNHBJFPLAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x620D930", Offset = "0x620C930", VA = "0x18620D930")]
	private CKAEKGBHCFC NHAGLODGEFB(AJALNDPKGLA ECPKNLIIEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x620AD50", Offset = "0x6209D50", VA = "0x18620AD50")]
	private CKAEKGBHCFC BLIOIGMFGKE(AJALNDPKGLA ECPKNLIIEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x620E5F0", Offset = "0x620D5F0", VA = "0x18620E5F0")]
	private CKAEKGBHCFC PKAFLMFBGLN(AJALNDPKGLA ECPKNLIIEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x620E2F0", Offset = "0x620D2F0", VA = "0x18620E2F0")]
	private static Guid ODMCDOKDELP(AJALNDPKGLA ECPKNLIIEJD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x620BC10", Offset = "0x620AC10", VA = "0x18620BC10")]
	private string EPPMEDBMKPC(AJALNDPKGLA ECPKNLIIEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x620E330", Offset = "0x620D330", VA = "0x18620E330")]
	private void ONDIEAJLMIH(CKAEKGBHCFC HJKHNDILIPH, CKAEKGBHCFC GFOFKCGAIPE, RigidTransform IODAAENEAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x620BD00", Offset = "0x620AD00", VA = "0x18620BD00")]
	private void FJDEOJHFCLI(CKAEKGBHCFC GFOFKCGAIPE, CKAEKGBHCFC HJKHNDILIPH, RigidTransform IODAAENEAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x620E4C0", Offset = "0x620D4C0", VA = "0x18620E4C0")]
	private void ONIAECCMHHA(CKAEKGBHCFC JMHMJAPCEIE, CKAEKGBHCFC HJKHNDILIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x620AB50", Offset = "0x6209B50", VA = "0x18620AB50")]
	private void BCBEACCBGNA(CKAEKGBHCFC HJKHNDILIPH, CKAEKGBHCFC NNHBJFPLAAA, RigidTransform IODAAENEAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x620CD70", Offset = "0x620BD70", VA = "0x18620CD70")]
	private void KGCDMPCPHGO(NOFNFJEBPPG OJJIOPECNPL, CKAEKGBHCFC DLLAJEJNDGL, NOFNFJEBPPG EHFJBFNCFBF, NOFNFJEBPPG AEPPHFKPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x620C360", Offset = "0x620B360", VA = "0x18620C360")]
	private void HNFBACDHLKE(NOFNFJEBPPG OJJIOPECNPL, CKAEKGBHCFC DLLAJEJNDGL, CKAEKGBHCFC GLFOPIDELIM, CKAEKGBHCFC MPEJBEONEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CHGFMODOBGE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DBOEAALPMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OIEDECFCIPC container;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DBOEAALPMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62123D0", Offset = "0x62113D0", VA = "0x1862123D0")]
		internal BHHMKNGOHEE LDJPJNEJKEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x620F200", Offset = "0x620E200", VA = "0x18620F200")]
	public static void KPKHBJBKAOE(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x620F1B0", Offset = "0x620E1B0", VA = "0x18620F1B0")]
	public static void CKAEKAELAAN(OIEDECFCIPC MJBHKMGKNLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class MLBIMDLNLGE : DJMLHFIHNEK, FAMJIHJPHFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx IHACPEDFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly BHHMKNGOHEE PGONJFLNHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly MIMGEGHBAGA DCHIBLGDKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly POMLPKOHIJH AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BIMOADPFIJL[] MLANHKKPABG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(NOFNFJEBPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CKAEKGBHCFC PIAOEDOIBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x621E420", Offset = "0x621D420", VA = "0x18621E420", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CKAEKGBHCFC BMKCBKCMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x621CBB0", Offset = "0x621BBB0", VA = "0x18621CBB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 NFBLBCFKMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x621E170", Offset = "0x621D170", VA = "0x18621E170", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion ANIGHHFELCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x621DB80", Offset = "0x621CB80", VA = "0x18621DB80", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IIBMCHDGHII
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x621CC20", Offset = "0x621BC20", VA = "0x18621CC20", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<CKAEKGBHCFC> KABIKIFABJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x621DC90", Offset = "0x621CC90", VA = "0x18621DC90", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool JCNJAKIDKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x889610", Offset = "0x888610", VA = "0x180889610", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x889730", Offset = "0x888730", VA = "0x180889730", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x621E630", Offset = "0x621D630", VA = "0x18621E630", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject GJCLDNHCHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x237DA60", Offset = "0x237CA60", VA = "0x18237DA60", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x621E350", Offset = "0x621D350", VA = "0x18621E350", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid OPPIIFGFKME
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x621E480", Offset = "0x621D480", VA = "0x18621E480", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LCNODLLJKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x621E560", Offset = "0x621D560", VA = "0x18621E560", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool IMFNACOBINF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool HCIIHBNKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x621CA10", Offset = "0x621BA10", VA = "0x18621CA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JMFKKJDHPOD FPPIKPBNEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x621DAC0", Offset = "0x621CAC0", VA = "0x18621DAC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x621E0C0", Offset = "0x621D0C0", VA = "0x18621E0C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JMFKKJDHPOD EDBBLLCLMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x621CB50", Offset = "0x621BB50", VA = "0x18621CB50", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x621DA60", Offset = "0x621CA60", VA = "0x18621DA60", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JMFKKJDHPOD LELEIMBNICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x621E1D0", Offset = "0x621D1D0", VA = "0x18621E1D0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x621DB20", Offset = "0x621CB20", VA = "0x18621DB20", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event KCKIOGLBFBM IFMGIBPDOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x621DCC0", Offset = "0x621CCC0", VA = "0x18621DCC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x621C970", Offset = "0x621B970", VA = "0x18621C970", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x621E250", Offset = "0x621D250", VA = "0x18621E250")]
	public MLBIMDLNLGE(NOFNFJEBPPG JOPDPKEGIDD, RigidbodyEx IHACPEDFDJO, MIMGEGHBAGA DCHIBLGDKGA, BIMOADPFIJL[] MLANHKKPABG, POMLPKOHIJH AKJKFGAFELN, FLJIJHFJFKO PGONJFLNHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x621DC60", Offset = "0x621CC60", VA = "0x18621DC60", Slot = "19")]
	public void KLABGHMFFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "21")]
	public void EMBJLLMMIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x607F140", Offset = "0x607E140", VA = "0x18607F140", Slot = "22")]
	public void KHOGJBDCGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x621E070", Offset = "0x621D070", VA = "0x18621E070", Slot = "20")]
	public void MLLCENNIMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x621D650", Offset = "0x621C650", VA = "0x18621D650", Slot = "25")]
	public void GDEOFLNHECO(int ECHFOFBAGPB, CKAEKGBHCFC FCBPDJOLFAD, int HGBKIAMLADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x621CC90", Offset = "0x621BC90", VA = "0x18621CC90", Slot = "26")]
	public void FDIJNKACNMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x621CD60", Offset = "0x621BD60", VA = "0x18621CD60", Slot = "27")]
	public void GBHAOPAFCGO(int ECHFOFBAGPB, CKAEKGBHCFC IFDCDKCJMKK, int NGBFNIJLMKH, [Optional] Vector3? CMOHIIIKDFC, [Optional] Quaternion? JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x621DBE0", Offset = "0x621CBE0", VA = "0x18621DBE0", Slot = "28")]
	public void KIJHIBPMKHH(CKAEKGBHCFC IFDCDKCJMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x621D040", Offset = "0x621C040", VA = "0x18621D040", Slot = "31")]
	public void GBIBCHJAKNO(Vector3 MIGHOEEMDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x621DD60", Offset = "0x621CD60", VA = "0x18621DD60", Slot = "29")]
	public void LFPGBJAFNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x621D450", Offset = "0x621C450", VA = "0x18621D450", Slot = "30")]
	public void GDCFAJADKFP(int GPEHCABDGEJ, Vector3 PDJLKPJAKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x621D990", Offset = "0x621C990", VA = "0x18621D990", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int ECHFOFBAGPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x621D860", Offset = "0x621C860", VA = "0x18621D860", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int ECHFOFBAGPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x848680", Offset = "0x847680", VA = "0x180848680", Slot = "42")]
	public Color GetConnectionSlotColor(int ECHFOFBAGPB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x621CAB0", Offset = "0x621BAB0", VA = "0x18621CAB0", Slot = "43")]
	public bool CanConnectTo(int ECHFOFBAGPB, CKAEKGBHCFC MFHNGLGKNIB, int LCFLDHOECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "44")]
	public void ParentChanged(int ECHFOFBAGPB, CKAEKGBHCFC IFGFPHLHJLF, int LEDAPMMCGDP, Vector3 AFLHKPEBJKN, Quaternion OFAPJHIJEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "45")]
	public void ChildAdded(int ECHFOFBAGPB, CKAEKGBHCFC HMFCFCMIPLK, int FABDFBIBLDN, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "46")]
	public void ChildRemoved(int ECHFOFBAGPB, CKAEKGBHCFC KBCIMINKKEG, int ONLFPOFAKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "47")]
	public void ConnectionModified(int ECHFOFBAGPB, CKAEKGBHCFC FCBPDJOLFAD, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x621E230", Offset = "0x621D230", VA = "0x18621E230", Slot = "48")]
	public void RootChanged(CKAEKGBHCFC GDJJMNEBAIJ, CKAEKGBHCFC KPCOKIKGEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x621CA60", Offset = "0x621BA60", VA = "0x18621CA60", Slot = "23")]
	public void CCBMIFDLEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x621C920", Offset = "0x621B920", VA = "0x18621C920", Slot = "24")]
	public void ADJAODKHNHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x621E120", Offset = "0x621D120", VA = "0x18621E120")]
	private void PDCAOGENEPA(bool HFMDCAGBHDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[KGDCKDGHHEL(typeof(JKFAMPNKDHD), new string[] { })]
public class JHNEIOJFNNM : JKFAMPNKDHD, IDCMJKJGJOM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BDGDCBLHDCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JHNEIOJFNNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public BPHEFFILCAL localIds;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BDGDCBLHDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62095F0", Offset = "0x62085F0", VA = "0x1862095F0")]
		internal void KOMPBHOBDAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[HGKGIPJGEIB]
	private DKIABLIFKBJ NELLAINPCDD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object FPIBCOLODIC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62132C0", Offset = "0x62122C0", VA = "0x1862132C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6213270", Offset = "0x6212270", VA = "0x186213270", Slot = "6")]
	public void InitReferences(DHADIMIDLEJ JIMAIACHILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6213100", Offset = "0x6212100", VA = "0x186213100", Slot = "5")]
	public void HBICALOOKNB(BPHEFFILCAL EGJIMMLDENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public JHNEIOJFNNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KGDCKDGHHEL(typeof(FLJIJHFJFKO), new string[] { "Ignore", "Mock" })]
public class ONHPHJICOPE : FLJIJHFJFKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NPKMANILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MJPHFNACNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<CKAEKGBHCFC, CKAEKGBHCFC> MNNMMPGINBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x621ED10", Offset = "0x621DD10", VA = "0x18621ED10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x621EE70", Offset = "0x621DE70", VA = "0x18621EE70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<CKAEKGBHCFC, CKAEKGBHCFC> CECHCGHFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x621EF20", Offset = "0x621DF20", VA = "0x18621EF20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x621EFD0", Offset = "0x621DFD0", VA = "0x18621EFD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<CKAEKGBHCFC, CKAEKGBHCFC, CKAEKGBHCFC> FMNHGPPADOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x621EDC0", Offset = "0x621DDC0", VA = "0x18621EDC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x621EC60", Offset = "0x621DC60", VA = "0x18621EC60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "12")]
	public void CJMKLAKCCOG(GameObject HOHLOJNOGCD, EKLIHBOIDFA HGMJMIDJPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "13")]
	public void ACILEHIEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "14")]
	public void GGEFLGLPFBG(CKAEKGBHCFC DLLAJEJNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "15")]
	public void IEOHJNELHNB(CKAEKGBHCFC DLLAJEJNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "16")]
	public void POOFIGJBIHP(CKAEKGBHCFC DLLAJEJNDGL, HashSet<CKAEKGBHCFC> LPLIOMLNGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "17")]
	public void AHIPKKGEHKB(CKAEKGBHCFC DLLAJEJNDGL, CKAEKGBHCFC KCPMKMACHFP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "18")]
	public void DLECPPJINHP(CKAEKGBHCFC DLLAJEJNDGL, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "19")]
	public void KCOLBJKDAIN(CKAEKGBHCFC DLLAJEJNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "20")]
	public NIGLHNNEBCE PPNNFDCNNMJ(bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "21")]
	public NIGLHNNEBCE PKDPCMKHPJL(HashSet<Guid> ELCJPNLHFGI, bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "22")]
	public bool LPEJHNKAGHB(AJALNDPKGLA ECPKNLIIEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "23")]
	public void AGGGBMIGDIA(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "24")]
	public void BJHEPJIPBAF(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "25")]
	public void AJMKFHDENJJ(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public ONHPHJICOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CKAEKGBHCFC : FAMJIHJPHFI, IEquatable<CKAEKGBHCFC>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FAMJIHJPHFI
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	CKAEKGBHCFC PIAOEDOIBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject GJCLDNHCHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string FJOKHGLGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid OPPIIFGFKME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int LCNODLLJKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NOFNFJEBPPG ONFNEGMNIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool IMFNACOBINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int ECHFOFBAGPB);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int ECHFOFBAGPB);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int ECHFOFBAGPB);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int ECHFOFBAGPB, CKAEKGBHCFC MFHNGLGKNIB, int IEOFNEKGLAJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int ECHFOFBAGPB, CKAEKGBHCFC IFGFPHLHJLF, int LEDAPMMCGDP, Vector3 AFLHKPEBJKN, Quaternion OFAPJHIJEIE);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int ECHFOFBAGPB, CKAEKGBHCFC HMFCFCMIPLK, int FABDFBIBLDN, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int ECHFOFBAGPB, CKAEKGBHCFC KBCIMINKKEG, int ONLFPOFAKPF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int ECHFOFBAGPB, CKAEKGBHCFC FCBPDJOLFAD, int PEDAIOKGACB, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(CKAEKGBHCFC GDJJMNEBAIJ, CKAEKGBHCFC KPCOKIKGEJL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[CDGCFHBGICH(DOECOPLPHCH.OMRoom)]
public interface FLJIJHFJFKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NPKMANILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MJPHFNACNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CKAEKGBHCFC, CKAEKGBHCFC> MNNMMPGINBN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<CKAEKGBHCFC, CKAEKGBHCFC> CECHCGHFNAG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<CKAEKGBHCFC, CKAEKGBHCFC, CKAEKGBHCFC> FMNHGPPADOH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CJMKLAKCCOG(GameObject HOHLOJNOGCD, EKLIHBOIDFA HGMJMIDJPPE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ACILEHIEJCJ();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GGEFLGLPFBG(CKAEKGBHCFC DLLAJEJNDGL);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IEOHJNELHNB(CKAEKGBHCFC DLLAJEJNDGL);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void POOFIGJBIHP(CKAEKGBHCFC DLLAJEJNDGL, HashSet<CKAEKGBHCFC> LPLIOMLNGDM);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AHIPKKGEHKB(CKAEKGBHCFC DLLAJEJNDGL, CKAEKGBHCFC KCPMKMACHFP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DLECPPJINHP(CKAEKGBHCFC DLLAJEJNDGL, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KCOLBJKDAIN(CKAEKGBHCFC DLLAJEJNDGL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NIGLHNNEBCE PPNNFDCNNMJ(bool CBHNLGCDCKD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NIGLHNNEBCE PKDPCMKHPJL(HashSet<Guid> ELCJPNLHFGI, bool CBHNLGCDCKD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LPEJHNKAGHB(AJALNDPKGLA ECPKNLIIEJD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AGGGBMIGDIA(NIGLHNNEBCE FFHMEKGOLFE);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BJHEPJIPBAF(NIGLHNNEBCE FFHMEKGOLFE);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AJMKFHDENJJ(NIGLHNNEBCE FFHMEKGOLFE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EHLJFJEEFAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CHOBFOOMDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CKAEKGBHCFC PKAFLMFBGLN(int IPHPKKELDJD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CKAEKGBHCFC BLIOIGMFGKE(Guid LBMMMENOEBN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JBHFOPONHGM(CKAEKGBHCFC DLLAJEJNDGL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LPIOCHLAOGK();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKHEEDCINKH(CKAEKGBHCFC DCHIBLGDKGA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CDGCFHBGICH(DOECOPLPHCH.Application)]
public interface POMLPKOHIJH
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCIIHBNKOAH(MIMGEGHBAGA DCHIBLGDKGA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CHMFBEEAKNJ(MIMGEGHBAGA DCHIBLGDKGA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string FHCNIMPFIFC(MIMGEGHBAGA DCHIBLGDKGA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid JEOMKGJEKFA(MIMGEGHBAGA DCHIBLGDKGA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LKJJGHHFNON(MIMGEGHBAGA DCHIBLGDKGA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPDJBAENHJC(MIMGEGHBAGA DCHIBLGDKGA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void JMFKKJDHPOD(CKAEKGBHCFC IFDCDKCJMKK, int LFILJAFENIO, CKAEKGBHCFC FCBPDJOLFAD, int NFIHFAOCEEG, [Optional] Vector3? CMOHIIIKDFC, [Optional] Quaternion? JFCNPIBOCIN);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void KCKIOGLBFBM(CKAEKGBHCFC GDJJMNEBAIJ, CKAEKGBHCFC KPCOKIKGEJL);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MIMGEGHBAGA : CKAEKGBHCFC, FAMJIHJPHFI, IEquatable<CKAEKGBHCFC>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DJMLHFIHNEK : FAMJIHJPHFI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	CKAEKGBHCFC BMKCBKCMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<CKAEKGBHCFC> KABIKIFABJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 NFBLBCFKMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion ANIGHHFELCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool IIBMCHDGHII
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool JCNJAKIDKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event JMFKKJDHPOD FPPIKPBNEKG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event JMFKKJDHPOD EDBBLLCLMGP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event JMFKKJDHPOD LELEIMBNICF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event KCKIOGLBFBM IFMGIBPDOPE;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KLABGHMFFPK();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MLLCENNIMJA();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EMBJLLMMIFK();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KHOGJBDCGFE();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CCBMIFDLEDL();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ADJAODKHNHK();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GDEOFLNHECO(int ECHFOFBAGPB, CKAEKGBHCFC FCBPDJOLFAD, int HGBKIAMLADO);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FDIJNKACNMA();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GBHAOPAFCGO(int ECHFOFBAGPB, CKAEKGBHCFC IFDCDKCJMKK, int NGBFNIJLMKH, [Optional] Vector3? CMOHIIIKDFC, [Optional] Quaternion? JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KIJHIBPMKHH(CKAEKGBHCFC IFDCDKCJMKK);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LFPGBJAFNAB();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GDCFAJADKFP(int GPEHCABDGEJ, Vector3 PDJLKPJAKEO);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GBIBCHJAKNO(Vector3 MIGHOEEMDAI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BIMOADPFIJL
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 PFEIHAGLBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EKLIHBOIDFA
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BMLDHPAONDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NKJLDNHFPKO LMELIDPBIII
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, EKLIHBOIDFA
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

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x82BFE0", Offset = "0x82AFE0", VA = "0x18082BFE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public NKJLDNHFPKO LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x620F380", Offset = "0x620E380", VA = "0x18620F380")]
		public static ConnectableConfigData NIAABDMFHHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x620F430", Offset = "0x620E430", VA = "0x18620F430")]
		public ConnectableConfigData(LegacyConnectableLinkVisual JCILIFBIJJF, bool OKHNHJKAOOH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NKOLMAGCLAC : IEquatable<NKOLMAGCLAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CKAEKGBHCFC DLLAJEJNDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int CAHGPKLKBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int PEDAIOKGACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 CMOHIIIKDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion JFCNPIBOCIN;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x621EC00", Offset = "0x621DC00", VA = "0x18621EC00")]
	public NKOLMAGCLAC(CKAEKGBHCFC DLLAJEJNDGL, int CAHGPKLKBPL, int PEDAIOKGACB, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x621EAD0", Offset = "0x621DAD0", VA = "0x18621EAD0")]
	public NKOLMAGCLAC(CKAEKGBHCFC DLLAJEJNDGL, int CAHGPKLKBPL, int PEDAIOKGACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x621EB70", Offset = "0x621DB70", VA = "0x18621EB70")]
	public NKOLMAGCLAC(CKAEKGBHCFC DLLAJEJNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x621E650", Offset = "0x621D650", VA = "0x18621E650", Slot = "4")]
	public bool Equals(NKOLMAGCLAC JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x621E700", Offset = "0x621D700", VA = "0x18621E700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class DAFFDGGPELF : KBFIOJMKPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform JKAOMNONHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private NKJLDNHFPKO BMMIADKHEAM;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D29FA0", Offset = "0x5D28FA0", VA = "0x185D29FA0", Slot = "4")]
	public void CJMKLAKCCOG(Transform JKAOMNONHAG, NKJLDNHFPKO BMMIADKHEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x620F4D0", Offset = "0x620E4D0", VA = "0x18620F4D0", Slot = "5")]
	public NKJLDNHFPKO ODGFCPMGONN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x620F480", Offset = "0x620E480", VA = "0x18620F480", Slot = "6")]
	public void DJADGFOCFJI(NKJLDNHFPKO FFBJJPFODEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public DAFFDGGPELF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class LFEIBBJDPCL : IDisposable, EDHCGFKDFGL
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HLMECPKLPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CKAEKGBHCFC oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CKAEKGBHCFC newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HLMECPKLPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6212FD0", Offset = "0x6211FD0", VA = "0x186212FD0")]
		internal bool BAJJMHILMHO(EAKLMOCDCNM node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly BDIOJIENINH NFHIEICBFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private LEFHENDANLH HNAANKMBHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private GNOIAGBIFIC APPFGNMDKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool OKHNHJKAOOH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public EAKLMOCDCNM NNCBLFAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6217A60", Offset = "0x6216A60", VA = "0x186217A60")]
	public bool LMDCDCHHELP([In] BDAJDNKGDBL GPKMLHOONCL, bool IMDLOPGLCHL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x62161F0", Offset = "0x62151F0", VA = "0x1862161F0")]
	private bool CEIGFLCJGNO([In] BDAJDNKGDBL GPKMLHOONCL, bool IMDLOPGLCHL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x621A770", Offset = "0x6219770", VA = "0x18621A770")]
	public LFEIBBJDPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x62167C0", Offset = "0x62157C0", VA = "0x1862167C0", Slot = "5")]
	public void CJMKLAKCCOG(FLJIJHFJFKO PGDDBCEFICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6217640", Offset = "0x6216640", VA = "0x186217640", Slot = "17")]
	public void IHAALOAAGAE(CAGAOBIGMCN HLFIKKGGCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6218C80", Offset = "0x6217C80", VA = "0x186218C80", Slot = "12")]
	public void NKFPFPFHGON(Func<CKAEKGBHCFC, bool> OODCOIFKLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6218990", Offset = "0x6217990", VA = "0x186218990")]
	private void NKFPFPFHGON(BDIOJIENINH CDMAFKOHEPF, Func<CKAEKGBHCFC, bool> OODCOIFKLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6216F90", Offset = "0x6215F90", VA = "0x186216F90", Slot = "11")]
	public void GLCBKNKDENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x621A1F0", Offset = "0x62191F0", VA = "0x18621A1F0", Slot = "8")]
	public bool POIPNMJOHNF(CKAEKGBHCFC IOPICKIGDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x62194E0", Offset = "0x62184E0", VA = "0x1862194E0")]
	private bool OKIBKLFMDHK(CKAEKGBHCFC MMBEGNBAAJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6216CF0", Offset = "0x6215CF0", VA = "0x186216CF0")]
	private static bool EPFNNCNIAKA(CKAEKGBHCFC MMBEGNBAAJB, BDIOJIENINH GEAPKIBMOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6217670", Offset = "0x6216670", VA = "0x186217670")]
	private void IJPKBPICMEF(Transform ONMPFMPPEIF, BDIOJIENINH LBKKOPGHKPO, BDIOJIENINH[] MDGOLBBHCCF, CKAEKGBHCFC ADIPMOCMBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6216850", Offset = "0x6215850", VA = "0x186216850")]
	private NKOLMAGCLAC CODJJBONDLF(Transform BKAIHBMBBLE, NKOLMAGCLAC FNIFDELEFNP)
	{
		return default(NKOLMAGCLAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6216FB0", Offset = "0x6215FB0", VA = "0x186216FB0")]
	private static bool HCBIIMDMIGF(BDIOJIENINH GEAPKIBMOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6216DA0", Offset = "0x6215DA0", VA = "0x186216DA0")]
	private string FHCNIMPFIFC(CKAEKGBHCFC DLLAJEJNDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6217AB0", Offset = "0x6216AB0", VA = "0x186217AB0")]
	private string LKJJGHHFNON(CKAEKGBHCFC DLLAJEJNDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6215BC0", Offset = "0x6214BC0", VA = "0x186215BC0")]
	private void CDFAGKPDKHG([In] BDAJDNKGDBL GPKMLHOONCL, bool HBNABJDAFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x621A020", Offset = "0x6219020", VA = "0x18621A020")]
	private void PHPHOGFEOBP(CKAEKGBHCFC HJKHNDILIPH, bool HBNABJDAFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6218F00", Offset = "0x6217F00", VA = "0x186218F00")]
	private void OCPLCGDPLIF(CKAEKGBHCFC MOKMLLFAPFO, int NGBFNIJLMKH, CKAEKGBHCFC GFOFKCGAIPE, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN, bool HBNABJDAFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6218150", Offset = "0x6217150", VA = "0x186218150")]
	private void MGBAGHOOELI(CKAEKGBHCFC CAMHLBBEIJI, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN, bool BNDFCIPJGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6219F40", Offset = "0x6218F40", VA = "0x186219F40", Slot = "9")]
	public bool PEIHMEKMCOC(CKAEKGBHCFC CAMHLBBEIJI, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6218760", Offset = "0x6217760", VA = "0x186218760")]
	private bool MIFEANAOKHC(CKAEKGBHCFC CAMHLBBEIJI, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6218C90", Offset = "0x6217C90", VA = "0x186218C90")]
	private static void NLAGBMLDDAK(CKAEKGBHCFC CAMHLBBEIJI, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN, BDIOJIENINH CHOGEPNADOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6219BB0", Offset = "0x6218BB0", VA = "0x186219BB0")]
	private void ONDIEAJLMIH(CKAEKGBHCFC MOKMLLFAPFO, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6215AE0", Offset = "0x6214AE0", VA = "0x186215AE0")]
	private void BNPOCDFJNHE(BDIOJIENINH CDMAFKOHEPF, CKAEKGBHCFC GLFOPIDELIM, CKAEKGBHCFC MPEJBEONEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6215B50", Offset = "0x6214B50", VA = "0x186215B50")]
	private void BNPOCDFJNHE(CKAEKGBHCFC DLLAJEJNDGL, CKAEKGBHCFC GLFOPIDELIM, CKAEKGBHCFC MPEJBEONEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6217400", Offset = "0x6216400", VA = "0x186217400")]
	private void HNFBACDHLKE(CKAEKGBHCFC DLLAJEJNDGL, CKAEKGBHCFC GLFOPIDELIM, CKAEKGBHCFC MPEJBEONEKJ, bool JBGKGMPHNCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6217470", Offset = "0x6216470", VA = "0x186217470")]
	private void HNFBACDHLKE(BDIOJIENINH OPFDMIOAEHD, CKAEKGBHCFC ADIPMOCMBFI, CKAEKGBHCFC KPCOKIKGEJL, bool JBGKGMPHNCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6216E70", Offset = "0x6215E70", VA = "0x186216E70")]
	private void FJDEOJHFCLI(CKAEKGBHCFC HJKHNDILIPH, int NGBFNIJLMKH, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6219CD0", Offset = "0x6218CD0", VA = "0x186219CD0")]
	private void ONIAECCMHHA(EAKLMOCDCNM NNHBJFPLAAA, EAKLMOCDCNM PFNFECKJEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x62172A0", Offset = "0x62162A0", VA = "0x1862172A0", Slot = "18")]
	public CKAEKGBHCFC HKJCGPBHNAH(CKAEKGBHCFC DLLAJEJNDGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x621A3C0", Offset = "0x62193C0", VA = "0x18621A3C0", Slot = "13")]
	public void POOFIGJBIHP(CKAEKGBHCFC DLLAJEJNDGL, HashSet<CKAEKGBHCFC> GNCKLDDJCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x62169E0", Offset = "0x62159E0", VA = "0x1862169E0", Slot = "14")]
	public List<CKAEKGBHCFC> DOOECBNMEJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6217570", Offset = "0x6216570", VA = "0x186217570")]
	protected EAKLMOCDCNM HOBPNKLOOBG(EAKLMOCDCNM CDMAFKOHEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x62180B0", Offset = "0x62170B0", VA = "0x1862180B0")]
	protected BDIOJIENINH[] MAFBENJINPK(BDIOJIENINH GEAPKIBMOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6219E30", Offset = "0x6218E30", VA = "0x186219E30")]
	protected bool PBPLEHBFBFJ(CKAEKGBHCFC DLLAJEJNDGL, [Out] BDIOJIENINH CDMAFKOHEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6217170", Offset = "0x6216170", VA = "0x186217170", Slot = "15")]
	public bool HJOJPCPHLKP(CKAEKGBHCFC DLLAJEJNDGL, [Out] NKOLMAGCLAC AEIFIABFEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x62169A0", Offset = "0x62159A0", VA = "0x1862169A0")]
	protected BDIOJIENINH DMKNAPBGBNK(NKOLMAGCLAC OACEHOBEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6218E10", Offset = "0x6217E10", VA = "0x186218E10", Slot = "10")]
	public bool OAGMMAJFHPA(CKAEKGBHCFC MOKMLLFAPFO, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6217B20", Offset = "0x6216B20", VA = "0x186217B20")]
	private bool LOFIPMDGAMB(CKAEKGBHCFC MOKMLLFAPFO, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6216C20", Offset = "0x6215C20", VA = "0x186216C20")]
	private static bool EJDBALNIFNK(BDIOJIENINH KKLHKJEMKNL, NKOLMAGCLAC AEGIHIKBIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6217A60", Offset = "0x6216A60", VA = "0x186217A60", Slot = "7")]
	private bool IKPENKLFMBH([In] BDAJDNKGDBL GPKMLHOONCL, bool IMDLOPGLCHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class JKMDIJAJDOO : FLJIJHFJFKO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly OIEDECFCIPC MJBHKMGKNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly GNOIAGBIFIC APPFGNMDKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly BPENOLKAMLF DKEFPNOJLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly DALNKHBPHCI FBJNNGFDDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly EDHCGFKDFGL FFHMEKGOLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal JLKCCNDDPEI AKJKFGAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal LBOPMOFGCEB GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal LEFHENDANLH DHEODEGOAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool OKHNHJKAOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool GHOGDAPOFGD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool IJLAIBLKMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x177CDA0", Offset = "0x177BDA0", VA = "0x18177CDA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x177CD70", Offset = "0x177BD70", VA = "0x18177CD70")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NPKMANILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x177CDC0", Offset = "0x177BDC0", VA = "0x18177CDC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x177CD80", Offset = "0x177BD80", VA = "0x18177CD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MJPHFNACNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<CKAEKGBHCFC, CKAEKGBHCFC> MNNMMPGINBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6214180", Offset = "0x6213180", VA = "0x186214180", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6214320", Offset = "0x6213320", VA = "0x186214320", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<CKAEKGBHCFC, CKAEKGBHCFC> CECHCGHFNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6214690", Offset = "0x6213690", VA = "0x186214690", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6214960", Offset = "0x6213960", VA = "0x186214960", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<CKAEKGBHCFC, CKAEKGBHCFC, CKAEKGBHCFC> FMNHGPPADOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x62141E0", Offset = "0x62131E0", VA = "0x1862141E0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6213E30", Offset = "0x6212E30", VA = "0x186213E30", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6214C50", Offset = "0x6213C50", VA = "0x186214C50")]
	public JKMDIJAJDOO(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6213860", Offset = "0x6212860", VA = "0x186213860", Slot = "12")]
	public void CJMKLAKCCOG(GameObject HOHLOJNOGCD, EKLIHBOIDFA HGMJMIDJPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6213FD0", Offset = "0x6212FD0", VA = "0x186213FD0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x62133C0", Offset = "0x62123C0", VA = "0x1862133C0", Slot = "13")]
	public void ACILEHIEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6214240", Offset = "0x6213240", VA = "0x186214240", Slot = "14")]
	public void GGEFLGLPFBG(CKAEKGBHCFC DLLAJEJNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6214260", Offset = "0x6213260", VA = "0x186214260", Slot = "15")]
	public void IEOHJNELHNB(CKAEKGBHCFC DLLAJEJNDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x620D340", Offset = "0x620C340", VA = "0x18620D340", Slot = "22")]
	public bool LPEJHNKAGHB(AJALNDPKGLA ECPKNLIIEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x62137A0", Offset = "0x62127A0", VA = "0x1862137A0")]
	internal bool CEIGFLCJGNO([In] BDAJDNKGDBL GPKMLHOONCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x62146F0", Offset = "0x62136F0", VA = "0x1862146F0")]
	internal bool LOFIPMDGAMB([In] BDAJDNKGDBL GPKMLHOONCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x62142C0", Offset = "0x62132C0", VA = "0x1862142C0")]
	internal bool IHDCHFLBOFL([In] BDAJDNKGDBL GPKMLHOONCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x62149E0", Offset = "0x62139E0", VA = "0x1862149E0")]
	internal bool PLEOCAOKGKK([In] BDAJDNKGDBL GPKMLHOONCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6214780", Offset = "0x6213780", VA = "0x186214780")]
	internal void LPEGCGJGFJM(CKAEKGBHCFC DLLAJEJNDGL, int GHNCEFIOHEE, bool IMDLOPGLCHL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6214260", Offset = "0x6213260", VA = "0x186214260")]
	internal bool PKFKJBHOGCP(CKAEKGBHCFC JDLIAOJAKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6214550", Offset = "0x6213550", VA = "0x186214550")]
	internal bool KKKAEHLKLCP(CKAEKGBHCFC CAMHLBBEIJI, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6214B30", Offset = "0x6213B30", VA = "0x186214B30", Slot = "16")]
	public void POOFIGJBIHP(CKAEKGBHCFC DLLAJEJNDGL, HashSet<CKAEKGBHCFC> LPLIOMLNGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x62134A0", Offset = "0x62124A0", VA = "0x1862134A0", Slot = "17")]
	public void AHIPKKGEHKB(CKAEKGBHCFC CAMHLBBEIJI, CKAEKGBHCFC KCPMKMACHFP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6213E90", Offset = "0x6212E90", VA = "0x186213E90", Slot = "18")]
	public void DLECPPJINHP(CKAEKGBHCFC MOKMLLFAPFO, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6214380", Offset = "0x6213380", VA = "0x186214380", Slot = "19")]
	public void KCOLBJKDAIN(CKAEKGBHCFC MOKMLLFAPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6214070", Offset = "0x6213070", VA = "0x186214070")]
	public void EHDGPKFNKFL([Optional] GFJGICKLIKH LGKGEJAADMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6213410", Offset = "0x6212410", VA = "0x186213410", Slot = "23")]
	public void AGGGBMIGDIA(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6214C30", Offset = "0x6213C30", VA = "0x186214C30", Slot = "20")]
	public NIGLHNNEBCE PPNNFDCNNMJ(bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x62149C0", Offset = "0x62139C0", VA = "0x1862149C0", Slot = "21")]
	public NIGLHNNEBCE PKDPCMKHPJL(HashSet<Guid> ELCJPNLHFGI, bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x62136B0", Offset = "0x62126B0", VA = "0x1862136B0", Slot = "25")]
	public void AJMKFHDENJJ(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x62136F0", Offset = "0x62126F0", VA = "0x1862136F0", Slot = "24")]
	public void BJHEPJIPBAF(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class GNOIAGBIFIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly EFKALDPIAIL<CKAEKGBHCFC, CKAEKGBHCFC> MNNMMPGINBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly EFKALDPIAIL<CKAEKGBHCFC, CKAEKGBHCFC> CECHCGHFNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly FBOECCOHABO<CKAEKGBHCFC, CKAEKGBHCFC, CKAEKGBHCFC> FMNHGPPADOH;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6212EB0", Offset = "0x6211EB0", VA = "0x186212EB0")]
	public GNOIAGBIFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	public void CJMKLAKCCOG(JKMDIJAJDOO PGDDBCEFICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6212E50", Offset = "0x6211E50", VA = "0x186212E50")]
	public void NDCJBIKPKAE(CKAEKGBHCFC NNHBJFPLAAA, CKAEKGBHCFC HJKHNDILIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6212D70", Offset = "0x6211D70", VA = "0x186212D70")]
	public void CMLKDDOIGPG(CKAEKGBHCFC NNHBJFPLAAA, CKAEKGBHCFC HJKHNDILIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6212DD0", Offset = "0x6211DD0", VA = "0x186212DD0")]
	public void LEDDMKIDJKH(CKAEKGBHCFC JMHMJAPCEIE, CKAEKGBHCFC GFOFKCGAIPE, CKAEKGBHCFC HJKHNDILIPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class BPENOLKAMLF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private JKMDIJAJDOO PGDDBCEFICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private LBOPMOFGCEB GMFPLFAACJJ;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public BPENOLKAMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x620EF50", Offset = "0x620DF50", VA = "0x18620EF50")]
	public void CJMKLAKCCOG(JKMDIJAJDOO PGDDBCEFICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x620F080", Offset = "0x620E080", VA = "0x18620F080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x620F090", Offset = "0x620E090", VA = "0x18620F090")]
	private void GAHBCKJLJDI(GFJGICKLIKH HDKCFFEMGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x620EDE0", Offset = "0x620DDE0", VA = "0x18620EDE0")]
	private void AMBJEJDAHBF(GFJGICKLIKH FNIAMALJDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x620EE50", Offset = "0x620DE50", VA = "0x18620EE50")]
	public void BHBLOOPBOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x620F0B0", Offset = "0x620E0B0", VA = "0x18620F0B0")]
	public void IENHCFPHGGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class FDBMGBHJGDE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ILOMJMADLNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public OIEDECFCIPC container;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ILOMJMADLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6213090", Offset = "0x6212090", VA = "0x186213090")]
		internal JKMDIJAJDOO LDJPJNEJKEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6212B70", Offset = "0x6211B70", VA = "0x186212B70")]
	public static void KPKHBJBKAOE(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6212AF0", Offset = "0x6211AF0", VA = "0x186212AF0")]
	public static void CKAEKAELAAN(OIEDECFCIPC MJBHKMGKNLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class OOEABDOFPNK : IDisposable, LEFHENDANLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, NKJLDNHFPKO> EJKPGNBMLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly CAGAOBIGMCN JGEGCMOPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private KBFIOJMKPKM JHDKONBFBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private EDHCGFKDFGL FFHMEKGOLFE;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x621FC00", Offset = "0x621EC00", VA = "0x18621FC00")]
	public OOEABDOFPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x621F080", Offset = "0x621E080", VA = "0x18621F080", Slot = "7")]
	public void CJMKLAKCCOG(EDHCGFKDFGL FFHMEKGOLFE, KBFIOJMKPKM JHDKONBFBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x621F800", Offset = "0x621E800", VA = "0x18621F800", Slot = "5")]
	public void LIJHBKGIKHC(EAKLMOCDCNM CHPIJNJHPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x621F270", Offset = "0x621E270", VA = "0x18621F270", Slot = "9")]
	public void HHCCHEOBIOB(EAKLMOCDCNM CNNFMGJPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x621FA40", Offset = "0x621EA40", VA = "0x18621FA40", Slot = "8")]
	public void MCCFGMDPJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x621F3E0", Offset = "0x621E3E0", VA = "0x18621F3E0", Slot = "10")]
	public void KOFNOILGABG(EAKLMOCDCNM GJFMOEDMNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x621F730", Offset = "0x621E730", VA = "0x18621F730", Slot = "11")]
	public void LCLMFMCDEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x621F0C0", Offset = "0x621E0C0", VA = "0x18621F0C0")]
	private bool FPCFAAKILDK(EAKLMOCDCNM MBGPCNKOEPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class DALNKHBPHCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct LAAOMLBNHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly BDIOJIENINH KCLFFKDGBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> ELCJPNLHFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly AJALNDPKGLA HPCGEIEHDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly AJALNDPKGLA MBPLGKEDAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool CBHNLGCDCKD;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool ICMKCEDOOKA
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x62156D0", Offset = "0x62146D0", VA = "0x1862156D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6215A70", Offset = "0x6214A70", VA = "0x186215A70")]
		public LAAOMLBNHLJ(BDIOJIENINH KCLFFKDGBKA, HashSet<Guid> ELCJPNLHFGI, bool CBHNLGCDCKD, [Optional] AJALNDPKGLA HPCGEIEHDCB, [Optional] AJALNDPKGLA MBPLGKEDAOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6215200", Offset = "0x6214200", VA = "0x186215200")]
		public AJALNDPKGLA AFIENNPCBKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x62159B0", Offset = "0x62149B0", VA = "0x1862159B0")]
		private AJALNDPKGLA KNACEHMOJPL([Out] AJALNDPKGLA BANPAKMAHGC, [Out] AJALNDPKGLA LPHPOAIJDLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6215370", Offset = "0x6214370", VA = "0x186215370")]
		private AJALNDPKGLA AJIHFGKPNPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6215560", Offset = "0x6214560", VA = "0x186215560")]
		private void COCLDOACENJ(AJALNDPKGLA JGCEJIBADNG, AJALNDPKGLA DLEOMAMJNPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x62157F0", Offset = "0x62147F0", VA = "0x1862157F0")]
		private void JOACPAKHOKD(AJALNDPKGLA BANPAKMAHGC, AJALNDPKGLA LPHPOAIJDLO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private JKMDIJAJDOO PGDDBCEFICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private EDHCGFKDFGL FFHMEKGOLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private LEFHENDANLH HNAANKMBHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private LBOPMOFGCEB GMFPLFAACJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool GKHIBOAFBOB;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool IJBIFNCBDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6210A50", Offset = "0x620FA50", VA = "0x186210A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool IJLAIBLKMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x62104B0", Offset = "0x620F4B0", VA = "0x1862104B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x62104D0", Offset = "0x620F4D0", VA = "0x1862104D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x620FAC0", Offset = "0x620EAC0", VA = "0x18620FAC0")]
	public void CJMKLAKCCOG(JKMDIJAJDOO PGDDBCEFICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6211E80", Offset = "0x6210E80", VA = "0x186211E80")]
	public NIGLHNNEBCE PPNNFDCNNMJ(bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x62115E0", Offset = "0x62105E0", VA = "0x1862115E0")]
	public NIGLHNNEBCE PKDPCMKHPJL(HashSet<Guid> ELCJPNLHFGI, bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x620F830", Offset = "0x620E830", VA = "0x18620F830")]
	public void AGGGBMIGDIA(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x620F8C0", Offset = "0x620E8C0", VA = "0x18620F8C0")]
	public void BJHEPJIPBAF(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6210740", Offset = "0x620F740", VA = "0x186210740")]
	public void KKPPBLPPPBP(NIGLHNNEBCE FFHMEKGOLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6210150", Offset = "0x620F150", VA = "0x186210150")]
	private void HMLNFLBJNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x620FF60", Offset = "0x620EF60", VA = "0x18620FF60")]
	private AJALNDPKGLA HCDNHOLIPAN(BDIOJIENINH CDMAFKOHEPF, bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x62104F0", Offset = "0x620F4F0", VA = "0x1862104F0")]
	private static void JLFFBBNFKKH(BDIOJIENINH CDMAFKOHEPF, bool CBHNLGCDCKD, AJALNDPKGLA ECPKNLIIEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x620FB30", Offset = "0x620EB30", VA = "0x18620FB30")]
	private void DHDBHNDGPBB(BDIOJIENINH CDMAFKOHEPF, bool CBHNLGCDCKD, AJALNDPKGLA ECPKNLIIEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x62109C0", Offset = "0x620F9C0", VA = "0x1862109C0")]
	private AJALNDPKGLA MBJAEOCEJLG(BDIOJIENINH KCLFFKDGBKA, HashSet<Guid> ELCJPNLHFGI, bool CBHNLGCDCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x620F5A0", Offset = "0x620E5A0", VA = "0x18620F5A0")]
	private bool ADMCGIPMHAF(NIGLHNNEBCE PGHEJGHDNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6210AA0", Offset = "0x620FAA0", VA = "0x186210AA0")]
	private bool NEIKMIBDICK(AJALNDPKGLA ECPKNLIIEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6211440", Offset = "0x6210440", VA = "0x186211440")]
	private bool PIMADIFAKCB(NIGLHNNEBCE FFHMEKGOLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x620FD50", Offset = "0x620ED50", VA = "0x18620FD50")]
	private static bool EGNBMFJEEKL(AJALNDPKGLA ECPKNLIIEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6210770", Offset = "0x620F770", VA = "0x186210770")]
	public static bool LPEJHNKAGHB(AJALNDPKGLA ECPKNLIIEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6211110", Offset = "0x6210110", VA = "0x186211110")]
	private CKAEKGBHCFC NHAGLODGEFB(AJALNDPKGLA ECPKNLIIEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6211460", Offset = "0x6210460", VA = "0x186211460")]
	private CKAEKGBHCFC PKAFLMFBGLN(AJALNDPKGLA ECPKNLIIEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6210340", Offset = "0x620F340", VA = "0x186210340")]
	private CKAEKGBHCFC HPEEDBBGLOE(AJALNDPKGLA ECPKNLIIEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x620E2F0", Offset = "0x620D2F0", VA = "0x18620E2F0")]
	private static Guid ODMCDOKDELP(AJALNDPKGLA ECPKNLIIEJD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x620FE70", Offset = "0x620EE70", VA = "0x18620FE70")]
	private string EPPMEDBMKPC(AJALNDPKGLA ECPKNLIIEJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x620F960", Offset = "0x620E960", VA = "0x18620F960")]
	private bool BLNJLJBGLMM(BDIOJIENINH CDMAFKOHEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6211C20", Offset = "0x6210C20", VA = "0x186211C20")]
	private static void PLEABNOGPME(BDIOJIENINH KCLFFKDGBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public DALNKHBPHCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct BDAJDNKGDBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public CKAEKGBHCFC HJKHNDILIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public CKAEKGBHCFC NNHBJFPLAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int NGBFNIJLMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int HGBKIAMLADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 CMOHIIIKDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion JFCNPIBOCIN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NKOLMAGCLAC NHPHNEHMAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x62094B0", Offset = "0x62084B0", VA = "0x1862094B0")]
		get
		{
			return default(NKOLMAGCLAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NKOLMAGCLAC JNGPFNPHBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6209550", Offset = "0x6208550", VA = "0x186209550")]
		get
		{
			return default(NKOLMAGCLAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6209580", Offset = "0x6208580", VA = "0x186209580")]
	public BDAJDNKGDBL(CKAEKGBHCFC HJKHNDILIPH, CKAEKGBHCFC NNHBJFPLAAA, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface EDHCGFKDFGL
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EAKLMOCDCNM NNCBLFAOELK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJMKLAKCCOG(FLJIJHFJFKO PGDDBCEFICD);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LMDCDCHHELP([In] BDAJDNKGDBL GPKMLHOONCL, bool IMDLOPGLCHL = true);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool POIPNMJOHNF(CKAEKGBHCFC IOPICKIGDDP);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PEIHMEKMCOC(CKAEKGBHCFC CAMHLBBEIJI, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OAGMMAJFHPA(CKAEKGBHCFC MOKMLLFAPFO, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GLCBKNKDENA();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NKFPFPFHGON(Func<CKAEKGBHCFC, bool> OODCOIFKLPK);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void POOFIGJBIHP(CKAEKGBHCFC DLLAJEJNDGL, HashSet<CKAEKGBHCFC> GNCKLDDJCFM);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<CKAEKGBHCFC> DOOECBNMEJH();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HJOJPCPHLKP(CKAEKGBHCFC DLLAJEJNDGL, [Out] NKOLMAGCLAC AEIFIABFEAN);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IHAALOAAGAE(CAGAOBIGMCN HLFIKKGGCCK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool CAGAOBIGMCN(EAKLMOCDCNM CDMAFKOHEPF);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface EAKLMOCDCNM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CKAEKGBHCFC DGOINEBOFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EAKLMOCDCNM MILAJCEOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NKOLMAGCLAC JFNEOAKBEPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool MBPDKPODGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NKJLDNHFPKO
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPHLHCOPMDI(CKAEKGBHCFC FCBPDJOLFAD, NKOLMAGCLAC HJKHNDILIPH);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBECLJGAFMI(CKAEKGBHCFC FCBPDJOLFAD, NKOLMAGCLAC HJKHNDILIPH);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNGDNFPAKIE(CKAEKGBHCFC FCBPDJOLFAD, NKOLMAGCLAC HJKHNDILIPH);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OFLDOCDHIBA(CKAEKGBHCFC FCBPDJOLFAD, NKOLMAGCLAC HJKHNDILIPH);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NKJLDNHFPKO Instantiate(Transform JKAOMNONHAG);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FAAFJENLCBJ();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KBFIOJMKPKM
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJMKLAKCCOG(Transform JKAOMNONHAG, NKJLDNHFPKO BMMIADKHEAM);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NKJLDNHFPKO ODGFCPMGONN();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJADGFOCFJI(NKJLDNHFPKO FFBJJPFODEE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JLKCCNDDPEI : EHLJFJEEFAB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAPJAIEEELJ(Guid PJEKMGFOICC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface LEFHENDANLH
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LIJHBKGIKHC(EAKLMOCDCNM CHPIJNJHPAM);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJMKLAKCCOG(EDHCGFKDFGL FFHMEKGOLFE, KBFIOJMKPKM OOHICOJLEKP);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCCFGMDPJIN();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHCCHEOBIOB(EAKLMOCDCNM CNNFMGJPMDG);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KOFNOILGABG(EAKLMOCDCNM GJFMOEDMNOK);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LCLMFMCDEAJ();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class BDIOJIENINH : EAKLMOCDCNM
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DGGPELMPLDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NKOLMAGCLAC nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public BDIOJIENINH foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DGGPELMPLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6212480", Offset = "0x6211480", VA = "0x186212480")]
		internal bool ILNOIHBEDFC(EAKLMOCDCNM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private NKOLMAGCLAC AEIFIABFEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<BDIOJIENINH> CLDMIFOOGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private BDIOJIENINH NHAIPAABMEH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NKOLMAGCLAC JFNEOAKBEPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x35888D0", Offset = "0x35878D0", VA = "0x1835888D0", Slot = "6")]
		get
		{
			return default(NKOLMAGCLAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x620A3B0", Offset = "0x62093B0", VA = "0x18620A3B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private BDIOJIENINH NNHBJFPLAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C6560", Offset = "0x7C5560", VA = "0x1807C6560")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x62096E0", Offset = "0x62086E0", VA = "0x1862096E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EAKLMOCDCNM MILAJCEOCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C6560", Offset = "0x7C5560", VA = "0x1807C6560", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CKAEKGBHCFC DGOINEBOFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MBPDKPODGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x62097E0", Offset = "0x62087E0", VA = "0x1862097E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool BCIIBIJHFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6209DB0", Offset = "0x6208DB0", VA = "0x186209DB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected BDIOJIENINH OPFDMIOAEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x62097C0", Offset = "0x62087C0", VA = "0x1862097C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x620A560", Offset = "0x6209560", VA = "0x18620A560")]
	public BDIOJIENINH(NKOLMAGCLAC LHJKMBMFNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6209BB0", Offset = "0x6208BB0", VA = "0x186209BB0")]
	public BDIOJIENINH JGINDGHHPNF(NKOLMAGCLAC NLBAPBANHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x620A3E0", Offset = "0x62093E0", VA = "0x18620A3E0")]
	public BDIOJIENINH OPPHGKJJGHM(NKOLMAGCLAC HOLCCJEEGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6209E00", Offset = "0x6208E00", VA = "0x186209E00")]
	public BDIOJIENINH NCLCGNJGAKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x62098F0", Offset = "0x62088F0", VA = "0x1862098F0")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6209D00", Offset = "0x6208D00", VA = "0x186209D00")]
	public BDIOJIENINH JNADCMCMMJK(NKOLMAGCLAC GFOFKCGAIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6209A40", Offset = "0x6208A40", VA = "0x186209A40")]
	private static void IHAALOAAGAE(BDIOJIENINH FBCNBCHIMEI, CAGAOBIGMCN LNPIDFLJKCD, bool NLOLKBGPDBA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6209BA0", Offset = "0x6208BA0", VA = "0x186209BA0", Slot = "9")]
	public void IHAALOAAGAE(CAGAOBIGMCN HLFIKKGGCCK, bool JBGKGMPHNCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6209FE0", Offset = "0x6208FE0", VA = "0x186209FE0")]
	public static string NKHKDJPNNBO(BDIOJIENINH FBCNBCHIMEI, int AAAOJHPKGKF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x62097F0", Offset = "0x62087F0", VA = "0x1862097F0")]
	public static BDIOJIENINH DMKNAPBGBNK(BDIOJIENINH FBCNBCHIMEI, NKOLMAGCLAC CKJBHPLGOOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface LBOPMOFGCEB
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IJBIFNCBDMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool CHOBFOOMDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<GFJGICKLIKH> GAHBCKJLJDI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<GFJGICKLIKH> AMBJEJDAHBF;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(JKMDIJAJDOO PGDDBCEFICD);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(CKAEKGBHCFC CAMHLBBEIJI, CKAEKGBHCFC KCPMKMACHFP, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(CKAEKGBHCFC MOKMLLFAPFO, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(NIGLHNNEBCE IKIAAAEGCCG, [Optional] GFJGICKLIKH LGKGEJAADMF);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, LBOPMOFGCEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private JKMDIJAJDOO PGDDBCEFICD;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool IJBIFNCBDMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x621C650", Offset = "0x621B650", VA = "0x18621C650", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool CHOBFOOMDGH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x621C6B0", Offset = "0x621B6B0", VA = "0x18621C6B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<GFJGICKLIKH> GAHBCKJLJDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x621C5A0", Offset = "0x621B5A0", VA = "0x18621C5A0", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x621C7A0", Offset = "0x621B7A0", VA = "0x18621C7A0", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<GFJGICKLIKH> AMBJEJDAHBF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x621C4F0", Offset = "0x621B4F0", VA = "0x18621C4F0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x621C6F0", Offset = "0x621B6F0", VA = "0x18621C6F0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C65A0", Offset = "0x7C55A0", VA = "0x1807C65A0", Slot = "19")]
		public void SetManager(JKMDIJAJDOO PGDDBCEFICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x621C4C0", Offset = "0x621B4C0", VA = "0x18621C4C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x621B240", Offset = "0x621A240", VA = "0x18621B240", Slot = "23")]
		public void RequestMasterConnectNodes(CKAEKGBHCFC IFDCDKCJMKK, int NGBFNIJLMKH, CKAEKGBHCFC FCBPDJOLFAD, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x621B370", Offset = "0x621A370", VA = "0x18621B370", Slot = "24")]
		public void RequestMasterDisconnectNode(CKAEKGBHCFC IOPICKIGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x621B430", Offset = "0x621A430", VA = "0x18621B430", Slot = "20")]
		public void RequestMasterModifyNode(CKAEKGBHCFC CAMHLBBEIJI, CKAEKGBHCFC KCPMKMACHFP, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x621B560", Offset = "0x621A560", VA = "0x18621B560", Slot = "21")]
		public void RequestMasterReparentNodes(CKAEKGBHCFC MOKMLLFAPFO, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x621B690", Offset = "0x621A690", VA = "0x18621B690", Slot = "25")]
		public void RequestMasterReparentToRoot(CKAEKGBHCFC MOKMLLFAPFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x621B110", Offset = "0x621A110", VA = "0x18621B110", Slot = "22")]
		public void RequestDeserializeConnectableGraph(NIGLHNNEBCE IKIAAAEGCCG, [Optional] GFJGICKLIKH LGKGEJAADMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x621BA70", Offset = "0x621AA70", VA = "0x18621BA70")]
		[IDKMJLBMAAC]
		private void RpcMasterConnectNodes(CKAEKGBHCFC IFDCDKCJMKK, int NGBFNIJLMKH, CKAEKGBHCFC FCBPDJOLFAD, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x621BD30", Offset = "0x621AD30", VA = "0x18621BD30")]
		[IDKMJLBMAAC]
		private void RpcMasterDisconnectNode(CKAEKGBHCFC IOPICKIGDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x621C070", Offset = "0x621B070", VA = "0x18621C070")]
		[IDKMJLBMAAC]
		private void RpcMasterReparentNodes(CKAEKGBHCFC MOKMLLFAPFO, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x621BE70", Offset = "0x621AE70", VA = "0x18621BE70")]
		[IDKMJLBMAAC]
		private void RpcMasterModifyNode(CKAEKGBHCFC CAMHLBBEIJI, CKAEKGBHCFC KCPMKMACHFP, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x621B860", Offset = "0x621A860", VA = "0x18621B860")]
		[IDKMJLBMAAC]
		private void RpcConnectNodes(CKAEKGBHCFC IFDCDKCJMKK, int NGBFNIJLMKH, CKAEKGBHCFC FCBPDJOLFAD, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN, MMHOGFPDOPD EFABDEKNABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x621B9E0", Offset = "0x621A9E0", VA = "0x18621B9E0")]
		[IDKMJLBMAAC]
		private void RpcDisconnectNode(CKAEKGBHCFC IOPICKIGDDP, MMHOGFPDOPD EFABDEKNABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x621C3C0", Offset = "0x621B3C0", VA = "0x18621C3C0")]
		[IDKMJLBMAAC]
		private void RpcReparentNodes(CKAEKGBHCFC MOKMLLFAPFO, int HEBDFEFGAHN, CKAEKGBHCFC GFOFKCGAIPE, int LEDAPMMCGDP, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN, MMHOGFPDOPD EFABDEKNABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x621C300", Offset = "0x621B300", VA = "0x18621C300")]
		[IDKMJLBMAAC]
		private void RpcModifyNode(CKAEKGBHCFC CAMHLBBEIJI, int NGBFNIJLMKH, int HGBKIAMLADO, Vector3 CMOHIIIKDFC, Quaternion JFCNPIBOCIN, MMHOGFPDOPD EFABDEKNABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x621B9A0", Offset = "0x621A9A0", VA = "0x18621B9A0")]
		[IDKMJLBMAAC]
		private void RpcDeserializeConnectableGraph(NIGLHNNEBCE FFHMEKGOLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF80", Offset = "0x7DBF80", VA = "0x1807DCF80")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, NKJLDNHFPKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x621A940", Offset = "0x6219940", VA = "0x18621A940", Slot = "4")]
		private void CADIDHGDLKI(CKAEKGBHCFC FCBPDJOLFAD, NKOLMAGCLAC HJKHNDILIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x621AB20", Offset = "0x6219B20", VA = "0x18621AB20", Slot = "5")]
		private void HDBLNFHDJKG(CKAEKGBHCFC FCBPDJOLFAD, NKOLMAGCLAC HJKHNDILIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x621ADA0", Offset = "0x6219DA0", VA = "0x18621ADA0", Slot = "6")]
		private void IFMOKLAPHMA(CKAEKGBHCFC FCBPDJOLFAD, NKOLMAGCLAC HJKHNDILIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x621AEB0", Offset = "0x6219EB0", VA = "0x18621AEB0", Slot = "7")]
		private void PCIKBGNOPPF(CKAEKGBHCFC FCBPDJOLFAD, NKOLMAGCLAC HJKHNDILIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x621B0A0", Offset = "0x621A0A0", VA = "0x18621B0A0", Slot = "8")]
		private NKJLDNHFPKO PJJMOBKALEP(Transform JKAOMNONHAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x621AAC0", Offset = "0x6219AC0", VA = "0x18621AAC0", Slot = "9")]
		private void GAPEFLDKLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GCNOHIJALPE
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x28B84F0", Offset = "0x28B74F0", VA = "0x1828B84F0")]
	public static KLPFLMLJJPA<T> HBNGMLCAKGD<T>(this OIEDECFCIPC MJBHKMGKNLL)
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
