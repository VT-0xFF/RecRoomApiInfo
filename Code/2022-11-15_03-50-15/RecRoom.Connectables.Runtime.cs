using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom;
using RecRoom.ObjectModel.Connectables;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Preserve]
public class FDDFJEMDNHO : CAOLBKCEHDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Transform MLMJNFGMBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IOJBBGGLAEM MOFAHCOMLPJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3040830", Offset = "0x303F230", VA = "0x183040830", Slot = "4")]
	public void GICNDCMAEJH(Transform MLMJNFGMBPE, IOJBBGGLAEM MOFAHCOMLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4FF52D0", Offset = "0x4FF3CD0", VA = "0x184FF52D0", Slot = "5")]
	public IOJBBGGLAEM GHHLNIGPNBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public FDDFJEMDNHO()
	{
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[OJEJDFBPPED(FHFOPEOFOPD.Connectables)]
	public sealed class OMConnectableManager : CLHMFLMOMOE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class NNGLEPCHFKD : IEnumerable<GHDGELDIJEA>, IEnumerable, IEnumerator<GHDGELDIJEA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private GHDGELDIJEA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private CAMBCDMDDIB localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public CAMBCDMDDIB <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public OMConnectableManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private PPBLJKKDGPH <objects>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private OIAFHGFMCMO.MDINLNEJDDI <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private GHDGELDIJEA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
			[DebuggerHidden]
			public NNGLEPCHFKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x50009C0", Offset = "0x4FFF3C0", VA = "0x1850009C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x50005A0", Offset = "0x4FFEFA0", VA = "0x1850005A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5000A20", Offset = "0x4FFF420", VA = "0x185000A20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5000980", Offset = "0x4FFF380", VA = "0x185000980", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x50008D0", Offset = "0x4FFF2D0", VA = "0x1850008D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GHDGELDIJEA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x50008D0", Offset = "0x4FFF2D0", VA = "0x1850008D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly LOOGELFKPLM CCCMAJDJKDA;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly LOOGELFKPLM KJGCKKJNGCC;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly LOOGELFKPLM POAIEOGKOCB;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly LOOGELFKPLM GPPHCDOJEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private GMOEBONBILL FOPIGLELKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private LKBGGDFMKHG HDFHOPBBCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FHMCLICBCEM MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PKHFPLBKFGA KPNFEILPOCL;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int MJPILBJAOEO = 0;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int EKHDHIBLNMK = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LAGGBJEMAHE KDGPDENJJDJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MMGCNOGJJID
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6E2F80", Offset = "0x6E1980", VA = "0x1806E2F80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC72690", Offset = "0xC71090", VA = "0x180C72690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<GHDGELDIJEA, GHDGELDIJEA> PLFCNPKHAAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5004D60", Offset = "0x5003760", VA = "0x185004D60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x50034E0", Offset = "0x5001EE0", VA = "0x1850034E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<GHDGELDIJEA, GHDGELDIJEA> NNEPFJMCGOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5004E00", Offset = "0x5003800", VA = "0x185004E00", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5005E40", Offset = "0x5004840", VA = "0x185005E40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<GHDGELDIJEA, GHDGELDIJEA, GHDGELDIJEA> LDDABIGJOGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x50032B0", Offset = "0x5001CB0", VA = "0x1850032B0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5005EE0", Offset = "0x50048E0", VA = "0x185005EE0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x50065B0", Offset = "0x5004FB0", VA = "0x1850065B0")]
		public OMConnectableManager(MCKMOPCGMKB FOFFAOBPIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5002E60", Offset = "0x5001860", VA = "0x185002E60", Slot = "11")]
		public void GICNDCMAEJH(GameObject OOAFGPFKNDK, AJCAAFIIELM DGHNOAJEKEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5002470", Offset = "0x5000E70", VA = "0x185002470", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9A10", Offset = "0x4FF8410", VA = "0x184FF9A10", Slot = "22")]
		public bool FPJNDMCLJDE(KMJLLKLNMEP PGAEIMKMJEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5004250", Offset = "0x5002C50", VA = "0x185004250")]
		private void JHFLMIPCDID(CAMBCDMDDIB OPDLGBEAKBJ, CAMBCDMDDIB NNCBKAEBBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5001E80", Offset = "0x5000880", VA = "0x185001E80")]
		private void CONMPCAFIJM(CAMBCDMDDIB OPDLGBEAKBJ, CAMBCDMDDIB NFPNLDMOAMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5005760", Offset = "0x5004160", VA = "0x185005760")]
		private void MNCOCBAOFNH(CAMBCDMDDIB OPDLGBEAKBJ, CAMBCDMDDIB NFPNLDMOAMA, CAMBCDMDDIB NNCBKAEBBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50017E0", Offset = "0x50001E0", VA = "0x1850017E0")]
		private void BDINPILEOHD(CAMBCDMDDIB OPDLGBEAKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "12")]
		public void OPDLCGHKCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x50053B0", Offset = "0x5003DB0", VA = "0x1850053B0", Slot = "13")]
		public void MKIHEFFHNPG(GHDGELDIJEA GFJJKAJGMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5002BD0", Offset = "0x50015D0", VA = "0x185002BD0", Slot = "14")]
		public void EPNEEGPIJCB(GHDGELDIJEA GFJJKAJGMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5004550", Offset = "0x5002F50", VA = "0x185004550", Slot = "16")]
		public void JPEPCCNPAGI(GHDGELDIJEA GFJJKAJGMKF, GHDGELDIJEA KOHEAHFONMC, Vector3 JJPMPKMDDHD, Quaternion JOJONLKIPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x50047A0", Offset = "0x50031A0", VA = "0x1850047A0")]
		public void JPEPCCNPAGI(CAMBCDMDDIB AHDACGEMPDI, CAMBCDMDDIB KOHEAHFONMC, Vector3 JJPMPKMDDHD, Quaternion JOJONLKIPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5003FA0", Offset = "0x50029A0", VA = "0x185003FA0", Slot = "17")]
		public void JENHKJHCCKM(GHDGELDIJEA GNANPBBENAI, int GPCGDKAPHHE, GHDGELDIJEA GDIENNOBGBH, int JFEDONMBMCE, Vector3 JJPMPKMDDHD, Quaternion JOJONLKIPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x50041E0", Offset = "0x5002BE0", VA = "0x1850041E0")]
		public void JENHKJHCCKM(CAMBCDMDDIB AHDACGEMPDI, CAMBCDMDDIB EGNCPOLPGCD, Vector3 JJPMPKMDDHD, Quaternion JOJONLKIPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x50051C0", Offset = "0x5003BC0", VA = "0x1850051C0", Slot = "18")]
		public void MJPIINGEIHC(GHDGELDIJEA GFJJKAJGMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x50062A0", Offset = "0x5004CA0", VA = "0x1850062A0", Slot = "19")]
		public bool PCPMEJFBKCC(GHDGELDIJEA GFJJKAJGMKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5006050", Offset = "0x5004A50", VA = "0x185006050")]
		public bool PCPMEJFBKCC(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5002670", Offset = "0x5001070", VA = "0x185002670", Slot = "15")]
		public void EEFPPHDAPID(GHDGELDIJEA GFJJKAJGMKF, HashSet<GHDGELDIJEA> GJEDDPJLJIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69EB40", VA = "0x1806A0140", Slot = "20")]
		public BKGAHBFKJIL CHKHHICCNDO(bool DFIMAOEIDBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69EB40", VA = "0x1806A0140", Slot = "21")]
		public BKGAHBFKJIL MBBBBKFMEHK(HashSet<Guid> GLNEOFBCBNO, bool DFIMAOEIDBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5001E10", Offset = "0x5000810", VA = "0x185001E10", Slot = "23")]
		public void CLEMOLKHNFG(BKGAHBFKJIL DDLGPJEILKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x50056F0", Offset = "0x50040F0", VA = "0x1850056F0", Slot = "24")]
		public void MLJCGAALAGP(BKGAHBFKJIL DDLGPJEILKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5002CB0", Offset = "0x50016B0", VA = "0x185002CB0", Slot = "25")]
		public void FBEOFMCIGLJ(BKGAHBFKJIL DDLGPJEILKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5003C10", Offset = "0x5002610", VA = "0x185003C10")]
		private void JEFAOPDMDFN(CAMBCDMDDIB AHDACGEMPDI, CAMBCDMDDIB EGNCPOLPGCD, Vector3 JJPMPKMDDHD, Quaternion JOJONLKIPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5001250", Offset = "0x4FFFC50", VA = "0x185001250")]
		private void AHCHKEEGOFA(CAMBCDMDDIB AHDACGEMPDI, CAMBCDMDDIB CLJJCFEFLNI, Vector3 JJPMPKMDDHD, Quaternion JOJONLKIPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5005F80", Offset = "0x5004980", VA = "0x185005F80")]
		private void OGFEAGAPPHL(CAMBCDMDDIB AHDACGEMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5001D80", Offset = "0x5000780", VA = "0x185001D80")]
		[IteratorStateMachine(typeof(NNGLEPCHFKD))]
		public IEnumerable<GHDGELDIJEA> BHEOCODPFCM(CAMBCDMDDIB BCJDDLNACAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5004CE0", Offset = "0x50036E0", VA = "0x185004CE0")]
		internal GHDGELDIJEA LAFKHMOHCEC(CAMBCDMDDIB BCJDDLNACAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5002940", Offset = "0x5001340", VA = "0x185002940")]
		internal CAMBCDMDDIB EJCMNEKEHKK(GHDGELDIJEA GFJJKAJGMKF)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5003580", Offset = "0x5001F80", VA = "0x185003580")]
		private bool IKNIGDGALJA(KMJLLKLNMEP PGAEIMKMJEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5003BB0", Offset = "0x50025B0", VA = "0x185003BB0")]
		private bool IMNAHLPKPIA(KMJLLKLNMEP PGAEIMKMJEI, out GHDGELDIJEA EGNCPOLPGCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5004980", Offset = "0x5003380", VA = "0x185004980")]
		private GHDGELDIJEA LAFKHMOHCEC(KMJLLKLNMEP PGAEIMKMJEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5002A30", Offset = "0x5001430", VA = "0x185002A30")]
		private GHDGELDIJEA EKMKFMDNCCP(KMJLLKLNMEP PGAEIMKMJEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5005030", Offset = "0x5003A30", VA = "0x185005030")]
		private GHDGELDIJEA MJLGIPEDIBE(KMJLLKLNMEP PGAEIMKMJEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4FFBFD0", Offset = "0x4FFA9D0", VA = "0x184FFBFD0")]
		private static Guid FIFEDOBLEFI(KMJLLKLNMEP PGAEIMKMJEI)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5006390", Offset = "0x5004D90", VA = "0x185006390")]
		private string PPCCLIKLPDP(KMJLLKLNMEP PGAEIMKMJEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5002CD0", Offset = "0x50016D0", VA = "0x185002CD0")]
		private void FIIKLPNDLMJ(GHDGELDIJEA AHDACGEMPDI, GHDGELDIJEA CLJJCFEFLNI, RigidTransform MABFHCIMHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5004EA0", Offset = "0x50038A0", VA = "0x185004EA0")]
		private void LPDCINBDMEG(GHDGELDIJEA CLJJCFEFLNI, GHDGELDIJEA AHDACGEMPDI, RigidTransform MABFHCIMHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5001780", Offset = "0x5000180", VA = "0x185001780")]
		private void AJJHPLBBCHG(GHDGELDIJEA NKGEBLNPFNO, GHDGELDIJEA AHDACGEMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5003350", Offset = "0x5001D50", VA = "0x185003350")]
		private void GOFLLOIENPP(GHDGELDIJEA AHDACGEMPDI, GHDGELDIJEA EGNCPOLPGCD, RigidTransform MABFHCIMHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5002190", Offset = "0x5000B90", VA = "0x185002190")]
		private void DFFJODKENAM(CAMBCDMDDIB BCJDDLNACAB, GHDGELDIJEA GFJJKAJGMKF, CAMBCDMDDIB NFPNLDMOAMA, CAMBCDMDDIB NNCBKAEBBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5005B20", Offset = "0x5004520", VA = "0x185005B20")]
		private void MPIFMIAIEKI(CAMBCDMDDIB BCJDDLNACAB, GHDGELDIJEA GFJJKAJGMKF, GHDGELDIJEA GJIHMHGMMMC, GHDGELDIJEA JMPJNJGCPLO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JFNAPJKOHNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EACLFIIKMGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public MCKMOPCGMKB container;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public EACLFIIKMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4E40", Offset = "0x4FF3840", VA = "0x184FF4E40")]
		internal OMConnectableManager <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6130", Offset = "0x4FF4B30", VA = "0x184FF6130")]
	public static void JNFAHCDNCJK(MCKMOPCGMKB FOFFAOBPIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6300", Offset = "0x4FF4D00", VA = "0x184FF6300")]
	public static void OLBONHCAGDK(MCKMOPCGMKB FOFFAOBPIJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JFOLHHFEHAI : GMHFEOLHCCL, GNMLMDCIJFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly RigidbodyEx AFGMBLEFIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OMConnectableManager MOFCOAHCJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly PDOBOFCLJAF DGCBKHEJKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MMGPHCFKFLG MGOGCFMPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly AEPJKABJIKB[] CLMIGEDABPD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CAMBCDMDDIB JDFAMBIABIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7A0810", Offset = "0x79F210", VA = "0x1807A0810", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(CAMBCDMDDIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GHDGELDIJEA NDAGLONGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GHDGELDIJEA EFCHEJDNNNG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4FF8010", Offset = "0x4FF6A10", VA = "0x184FF8010", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GHDGELDIJEA PPCFGKEMEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7D50", Offset = "0x4FF6750", VA = "0x184FF7D50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 HHEAKENFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4FF69E0", Offset = "0x4FF53E0", VA = "0x184FF69E0", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion EDGANIKEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7CE0", Offset = "0x4FF66E0", VA = "0x184FF7CE0", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PADINPONGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4FF6A50", Offset = "0x4FF5450", VA = "0x184FF6A50", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<GHDGELDIJEA> JNDFEFINCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4FF75D0", Offset = "0x4FF5FD0", VA = "0x184FF75D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool LOLPBDINKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E2F80", Offset = "0x6E1980", VA = "0x1806E2F80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xC72690", Offset = "0xC71090", VA = "0x180C72690", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform OCHLAIKCOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4FF8230", Offset = "0x4FF6C30", VA = "0x184FF8230", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject IDBECDIBJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7FA0", Offset = "0x4FF69A0", VA = "0x184FF7FA0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string PCBAHGDOBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7FC0", Offset = "0x4FF69C0", VA = "0x184FF7FC0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid OFGBBFDHNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4FF8100", Offset = "0x4FF6B00", VA = "0x184FF8100", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PCAFFDIBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4FF81E0", Offset = "0x4FF6BE0", VA = "0x184FF81E0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool AMJJPKINAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool BHIPIBHHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7500", Offset = "0x4FF5F00", VA = "0x184FF7500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event GCKDDFPHKCL JGMIGFONDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4FF6D30", Offset = "0x4FF5730", VA = "0x184FF6D30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4FF6670", Offset = "0x4FF5070", VA = "0x184FF6670", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GCKDDFPHKCL IPNGMOLAHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4FF72B0", Offset = "0x4FF5CB0", VA = "0x184FF72B0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4FF65C0", Offset = "0x4FF4FC0", VA = "0x184FF65C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GCKDDFPHKCL MGAPMKLBHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4FF6570", Offset = "0x4FF4F70", VA = "0x184FF6570", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7300", Offset = "0x4FF5D00", VA = "0x184FF7300", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event APONMGBBIOK IJLFEPPJONF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4FF7C40", Offset = "0x4FF6640", VA = "0x184FF7C40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4FF76F0", Offset = "0x4FF60F0", VA = "0x184FF76F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7EC0", Offset = "0x4FF68C0", VA = "0x184FF7EC0")]
	public JFOLHHFEHAI(CAMBCDMDDIB MMCCMEFGKOD, RigidbodyEx AFGMBLEFIEH, PDOBOFCLJAF DGCBKHEJKPN, AEPJKABJIKB[] CLMIGEDABPD, MMGPHCFKFLG MGOGCFMPFGO, CLHMFLMOMOE MOFCOAHCJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6910", Offset = "0x4FF5310", VA = "0x184FF6910", Slot = "20")]
	public void CKNLEBEOEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "22")]
	public void MJILHEEHHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7350", Offset = "0x4FF5D50", VA = "0x184FF7350", Slot = "23")]
	public void IPCKJCGBKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7790", Offset = "0x4FF6190", VA = "0x184FF7790", Slot = "21")]
	public void LOIIHJFIPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF66C0", Offset = "0x4FF50C0", VA = "0x184FF66C0", Slot = "26")]
	public void CDNPLBBFKKH(int LFKBCKKNHOH, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7670", Offset = "0x4FF6070", VA = "0x184FF7670", Slot = "27")]
	public void KMOJEKFKEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6F90", Offset = "0x4FF5990", VA = "0x184FF6F90", Slot = "28")]
	public void HGPOOKCIBPD(int LFKBCKKNHOH, GHDGELDIJEA GNANPBBENAI, int CMIOPJCNKFM, [Optional] Vector3? IJBMDEBMHMN, [Optional] Quaternion? ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7550", Offset = "0x4FF5F50", VA = "0x184FF7550", Slot = "29")]
	public void KHOPANACFBB(GHDGELDIJEA GNANPBBENAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4FF77E0", Offset = "0x4FF61E0", VA = "0x184FF77E0", Slot = "32")]
	public void NIFOGIMENEJ(Vector3 MNAMNMDDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6A70", Offset = "0x4FF5470", VA = "0x184FF6A70", Slot = "30")]
	public void EOHFEOLFMPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6370", Offset = "0x4FF4D70", VA = "0x184FF6370", Slot = "31")]
	public void ACOOMLCIDJE(int NENMOOINMCH, Vector3 DEFMLJAJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6EC0", Offset = "0x4FF58C0", VA = "0x184FF6EC0", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int LFKBCKKNHOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6D80", Offset = "0x4FF5780", VA = "0x184FF6D80", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int LFKBCKKNHOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xD768B0", Offset = "0xD752B0", VA = "0x180D768B0", Slot = "43")]
	public Color GetConnectionSlotColor(int LFKBCKKNHOH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6940", Offset = "0x4FF5340", VA = "0x184FF6940", Slot = "44")]
	public bool CanConnectTo(int LFKBCKKNHOH, GHDGELDIJEA BBHMDBONOGC, int ALHIPPNKIAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "45")]
	public void ParentChanged(int LFKBCKKNHOH, GHDGELDIJEA IEFECJJPGCH, int FCAOCJOLOBL, Vector3 BFONBEIJDBC, Quaternion MFNAFELJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "46")]
	public void ChildAdded(int LFKBCKKNHOH, GHDGELDIJEA FPOEGFDKGIO, int CIGFLGAADCN, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "47")]
	public void ChildRemoved(int LFKBCKKNHOH, GHDGELDIJEA LJDJANKHGPM, int GFPOGFKHLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "48")]
	public void ConnectionModified(int LFKBCKKNHOH, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7EA0", Offset = "0x4FF68A0", VA = "0x184FF7EA0", Slot = "49")]
	public void RootChanged(GHDGELDIJEA MHDPKPPHLGG, GHDGELDIJEA MKHOFKIPDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7450", Offset = "0x4FF5E50", VA = "0x184FF7450")]
	public bool JEJFAEMEMPN(GHDGELDIJEA BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7E40", Offset = "0x4FF6840", VA = "0x184FF7E40", Slot = "24")]
	public void PONJEDPCFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6610", Offset = "0x4FF5010", VA = "0x184FF6610", Slot = "25")]
	public void BIECHEFGLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7BE0", Offset = "0x4FF65E0", VA = "0x184FF7BE0")]
	private void OHJNFCPOOKF(bool EEMGPHJLCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4FF6510", Offset = "0x4FF4F10", VA = "0x184FF6510")]
	private RigidbodyEx ADOFELFGJBO(GHDGELDIJEA DGCBKHEJKPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DNKFJNHNNCA(typeof(MAPMDJPOPFI), new string[] { })]
public class NFACCAEMBDG : MAPMDJPOPFI, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[MJIDFIFGMKP]
	private PNLHBOHNCFH MGOGCFMPFGO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object LFGDFHMKHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5000420", Offset = "0x4FFEE20", VA = "0x185000420", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x50003D0", Offset = "0x4FFEDD0", VA = "0x1850003D0", Slot = "6")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x50004C0", Offset = "0x4FFEEC0", VA = "0x1850004C0", Slot = "5")]
	public void LMOILLCHDPK(OIAFHGFMCMO EAOELIGDFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public NFACCAEMBDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DNKFJNHNNCA(typeof(CLHMFLMOMOE), new string[] { "Ignore", "Mock" })]
public class BCHKPDDLDOC : CLHMFLMOMOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MMGCNOGJJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<GHDGELDIJEA, GHDGELDIJEA> PLFCNPKHAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF780", Offset = "0x4FEE180", VA = "0x184FEF780", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF6E0", Offset = "0x4FEE0E0", VA = "0x184FEF6E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<GHDGELDIJEA, GHDGELDIJEA> NNEPFJMCGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF820", Offset = "0x4FEE220", VA = "0x184FEF820", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF8C0", Offset = "0x4FEE2C0", VA = "0x184FEF8C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<GHDGELDIJEA, GHDGELDIJEA, GHDGELDIJEA> LDDABIGJOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF640", Offset = "0x4FEE040", VA = "0x184FEF640", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF960", Offset = "0x4FEE360", VA = "0x184FEF960", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "11")]
	public void GICNDCMAEJH(GameObject OOAFGPFKNDK, AJCAAFIIELM DGHNOAJEKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "12")]
	public void OPDLCGHKCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "13")]
	public void MKIHEFFHNPG(GHDGELDIJEA GFJJKAJGMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "14")]
	public void EPNEEGPIJCB(GHDGELDIJEA GFJJKAJGMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "15")]
	public void EEFPPHDAPID(GHDGELDIJEA GFJJKAJGMKF, HashSet<GHDGELDIJEA> GJEDDPJLJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "16")]
	public void JPEPCCNPAGI(GHDGELDIJEA GFJJKAJGMKF, GHDGELDIJEA KOHEAHFONMC, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "17")]
	public void JENHKJHCCKM(GHDGELDIJEA GFJJKAJGMKF, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "18")]
	public void MJPIINGEIHC(GHDGELDIJEA GFJJKAJGMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "19")]
	public bool PCPMEJFBKCC(GHDGELDIJEA GFJJKAJGMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69EB40", VA = "0x1806A0140", Slot = "20")]
	public BKGAHBFKJIL CHKHHICCNDO(bool DFIMAOEIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69EB40", VA = "0x1806A0140", Slot = "21")]
	public BKGAHBFKJIL MBBBBKFMEHK(HashSet<Guid> GLNEOFBCBNO, bool DFIMAOEIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "22")]
	public bool FPJNDMCLJDE(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "23")]
	public void CLEMOLKHNFG(BKGAHBFKJIL DDLGPJEILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "24")]
	public void MLJCGAALAGP(BKGAHBFKJIL DDLGPJEILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "25")]
	public void FBEOFMCIGLJ(BKGAHBFKJIL DDLGPJEILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public BCHKPDDLDOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KDIIGIBEHKK : MOCGNBGEDEM, IOJBBGGLAEM, IDisposable
{
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConnectableLinkVisual : MonoBehaviour, KDIIGIBEHKK, MOCGNBGEDEM, IOJBBGGLAEM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Entity HKPLBJGGAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Entity PNPOJJDCJHE;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity GFDOBMIPJBK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "20")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xC72660", Offset = "0xC71060", VA = "0x180C72660", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Entity AHBNGGDGHDK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10", Slot = "11")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xF4B050", Offset = "0xF49A50", VA = "0x180F4B050", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3870", Offset = "0x4FF2270", VA = "0x184FF3870", Slot = "4")]
		private void ABGPPOEMOAP(GHDGELDIJEA GDIENNOBGBH, OFFCEFNEKFO AHDACGEMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3B20", Offset = "0x4FF2520", VA = "0x184FF3B20", Slot = "5")]
		private void DHLIEGNECMF(GHDGELDIJEA GDIENNOBGBH, OFFCEFNEKFO AHDACGEMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3930", Offset = "0x4FF2330", VA = "0x184FF3930", Slot = "6")]
		private void ADCEJKFBBIO(GHDGELDIJEA GDIENNOBGBH, OFFCEFNEKFO AHDACGEMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3DD0", Offset = "0x4FF27D0", VA = "0x184FF3DD0", Slot = "7")]
		private void EHHEJENCFCO(GHDGELDIJEA GDIENNOBGBH, OFFCEFNEKFO AHDACGEMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4370", Offset = "0x4FF2D70", VA = "0x184FF4370", Slot = "8")]
		private MOCGNBGEDEM ONIIGMBMKHF(Transform MLMJNFGMBPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4220", Offset = "0x4FF2C20", VA = "0x184FF4220", Slot = "9")]
		private void IIBOEGLAMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4FF42E0", Offset = "0x4FF2CE0", VA = "0x184FF42E0")]
		private void LMCGMFHIJLB(ref Entity EBOGCLNNJGN, Entity NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4140", Offset = "0x4FF2B40", VA = "0x184FF4140", Slot = "14")]
		private void GCJCNEEPJEA(float3 DEFMLJAJEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4FF41B0", Offset = "0x4FF2BB0", VA = "0x184FF41B0", Slot = "13")]
		private void ICPNLPJAHOJ(float3 DEFMLJAJEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3FA0", Offset = "0x4FF29A0", VA = "0x184FF3FA0", Slot = "15")]
		private void FGAHJCDHMOJ(out float3 NJEPHEABALF, out float3 AFPKKIJINFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4070", Offset = "0x4FF2A70", VA = "0x184FF4070", Slot = "16")]
		private void FLJCILMHLGP(float3 NJEPHEABALF, float3 AFPKKIJINFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4280", Offset = "0x4FF2C80", VA = "0x184FF4280", Slot = "17")]
		private void LKGACGNBHJH(Color NJEPHEABALF, Color AFPKKIJINFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4FF42F0", Offset = "0x4FF2CF0", VA = "0x184FF42F0", Slot = "18")]
		private IOJBBGGLAEM MKLCMMMOLEP(Transform MLMJNFGMBPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4FF43F0", Offset = "0x4FF2DF0", VA = "0x184FF43F0", Slot = "19")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public ConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GHDGELDIJEA : GNMLMDCIJFP, IEquatable<GHDGELDIJEA>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GNMLMDCIJFP
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GHDGELDIJEA EFCHEJDNNNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform OCHLAIKCOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject IDBECDIBJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string PCBAHGDOBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid OFGBBFDHNEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int PCAFFDIBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	CAMBCDMDDIB JDFAMBIABIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool AMJJPKINAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int LFKBCKKNHOH);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int LFKBCKKNHOH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int LFKBCKKNHOH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int LFKBCKKNHOH, GHDGELDIJEA BBHMDBONOGC, int ABOKEDPCMOC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int LFKBCKKNHOH, GHDGELDIJEA IEFECJJPGCH, int FCAOCJOLOBL, Vector3 BFONBEIJDBC, Quaternion MFNAFELJCNH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int LFKBCKKNHOH, GHDGELDIJEA FPOEGFDKGIO, int CIGFLGAADCN, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int LFKBCKKNHOH, GHDGELDIJEA LJDJANKHGPM, int GFPOGFKHLFG);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int LFKBCKKNHOH, GHDGELDIJEA GDIENNOBGBH, int KGFEHNPIMOB, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(GHDGELDIJEA MHDPKPPHLGG, GHDGELDIJEA MKHOFKIPDIG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
public interface CLHMFLMOMOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MMGCNOGJJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GHDGELDIJEA, GHDGELDIJEA> PLFCNPKHAAP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<GHDGELDIJEA, GHDGELDIJEA> NNEPFJMCGOH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<GHDGELDIJEA, GHDGELDIJEA, GHDGELDIJEA> LDDABIGJOGM;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GICNDCMAEJH(GameObject OOAFGPFKNDK, AJCAAFIIELM DGHNOAJEKEO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OPDLCGHKCDC();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MKIHEFFHNPG(GHDGELDIJEA GFJJKAJGMKF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EPNEEGPIJCB(GHDGELDIJEA GFJJKAJGMKF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EEFPPHDAPID(GHDGELDIJEA GFJJKAJGMKF, HashSet<GHDGELDIJEA> GJEDDPJLJIC);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JPEPCCNPAGI(GHDGELDIJEA GFJJKAJGMKF, GHDGELDIJEA KOHEAHFONMC, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JENHKJHCCKM(GHDGELDIJEA GFJJKAJGMKF, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MJPIINGEIHC(GHDGELDIJEA GFJJKAJGMKF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PCPMEJFBKCC(GHDGELDIJEA GFJJKAJGMKF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BKGAHBFKJIL CHKHHICCNDO(bool DFIMAOEIDBB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BKGAHBFKJIL MBBBBKFMEHK(HashSet<Guid> GLNEOFBCBNO, bool DFIMAOEIDBB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FPJNDMCLJDE(KMJLLKLNMEP PGAEIMKMJEI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CLEMOLKHNFG(BKGAHBFKJIL DDLGPJEILKB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MLJCGAALAGP(BKGAHBFKJIL DDLGPJEILKB);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FBEOFMCIGLJ(BKGAHBFKJIL DDLGPJEILKB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FHMCLICBCEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DHCHDNIPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GHDGELDIJEA MJLGIPEDIBE(int DNABGAHFEMO);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GHDGELDIJEA EKMKFMDNCCP(Guid OPBAKNHEAJC);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NABBKACKEIC(GHDGELDIJEA GFJJKAJGMKF, out Guid CAPPBFKKCMA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DPPCLLNEMFG(GHDGELDIJEA GFJJKAJGMKF);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNKKEAEGCOG();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJKDPMMKEAD(GHDGELDIJEA DGCBKHEJKPN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DDOFDCHAEEC(AHJKMAKLGJA.Application)]
public interface MMGPHCFKFLG
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHIPIBHHHEH(PDOBOFCLJAF DGCBKHEJKPN);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFIJJHLMLEH(PDOBOFCLJAF DGCBKHEJKPN);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string CKGMOMNGAHE(PDOBOFCLJAF DGCBKHEJKPN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ACEOBOABHFB(PDOBOFCLJAF DGCBKHEJKPN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KFJCCHJMFHN(PDOBOFCLJAF DGCBKHEJKPN);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MIADJKEPEKJ(GHDGELDIJEA DGCBKHEJKPN, Action<GKKJANMNCLK> CJCABNNPDMJ);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOLMAGKMHCC(GHDGELDIJEA DGCBKHEJKPN, Action<GKKJANMNCLK> CJCABNNPDMJ);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BKPNKMOBBGE(PDOBOFCLJAF DGCBKHEJKPN);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ACGIBJIKJEL(PDOBOFCLJAF DGCBKHEJKPN);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KJKDPMMKEAD(PDOBOFCLJAF DGCBKHEJKPN);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BNOBIGBMNCI(PDOBOFCLJAF DGCBKHEJKPN, object KBCPLDFOJJL);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BAMJPGCKOHE(PDOBOFCLJAF DGCBKHEJKPN, object KBCPLDFOJJL);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	RigidbodyEx ADOFELFGJBO(GHDGELDIJEA DGCBKHEJKPN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DJJNDPGFMFB JPAFOIPGALA(PDOBOFCLJAF ABFHDOGCMDC, string KFEMFMGCJPM, bool DJFOKMFDJPD, EPMFFBNFAFE IOILBGIEEFJ, Action MLFGBBGKHEO);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MDGIOGDHHND(GMHFEOLHCCL KAODIPDCDDI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void GCKDDFPHKCL(GHDGELDIJEA GNANPBBENAI, int FGBLGIHJKDP, GHDGELDIJEA GDIENNOBGBH, int CCPBBNKMNJG, [Optional] Vector3? IJBMDEBMHMN, [Optional] Quaternion? ABMJIMFAJBP);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void APONMGBBIOK(GHDGELDIJEA MHDPKPPHLGG, GHDGELDIJEA MKHOFKIPDIG);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool HKAHDCBGOII(int LFKBCKKNHOH, GHDGELDIJEA BBHMDBONOGC, int ALHIPPNKIAH);
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PDOBOFCLJAF : GHDGELDIJEA, GNMLMDCIJFP, IEquatable<GHDGELDIJEA>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	GMHFEOLHCCL FCFHOEBOKID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GMHFEOLHCCL : GNMLMDCIJFP
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GHDGELDIJEA NDAGLONGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	GHDGELDIJEA PPCFGKEMEOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IEnumerable<GHDGELDIJEA> JNDFEFINCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 HHEAKENFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Quaternion EDGANIKEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool PADINPONGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool LOLPBDINKKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event GCKDDFPHKCL JGMIGFONDAK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event GCKDDFPHKCL IPNGMOLAHCH;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event GCKDDFPHKCL MGAPMKLBHKL;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event APONMGBBIOK IJLFEPPJONF;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CKNLEBEOEIL();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LOIIHJFIPMJ();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MJILHEEHHDL();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IPCKJCGBKHJ();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PONJEDPCFPE();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BIECHEFGLAD();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CDNPLBBFKKH(int LFKBCKKNHOH, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KMOJEKFKEIG();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HGPOOKCIBPD(int LFKBCKKNHOH, GHDGELDIJEA GNANPBBENAI, int CMIOPJCNKFM, [Optional] Vector3? IJBMDEBMHMN, [Optional] Quaternion? ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void KHOPANACFBB(GHDGELDIJEA GNANPBBENAI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EOHFEOLFMPE();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ACOOMLCIDJE(int NENMOOINMCH, Vector3 DEFMLJAJEKI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NIFOGIMENEJ(Vector3 MNAMNMDDDGA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AEPJKABJIKB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Vector3 KBMGMFINLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AJCAAFIIELM
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool IEJPAEKEEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KDIIGIBEHKK MDJDAOKBHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KDIIGIBEHKK LMPMPPJCBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CreateAssetMenu]
	public class ConnectableConfigData : ScriptableObject, AJCAAFIIELM
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private ConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private ConnectableLinkVisual objectModelLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7F5D60", Offset = "0x7F4760", VA = "0x1807F5D60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public KDIIGIBEHKK LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public KDIIGIBEHKK ObjectModelLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3780", Offset = "0x4FF2180", VA = "0x184FF3780")]
		public static ConnectableConfigData PFEOIBHPKGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3820", Offset = "0x4FF2220", VA = "0x184FF3820")]
		public ConnectableConfigData(ConnectableLinkVisual DHMFFHDPBFP, bool HADGFIFKEHF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OFFCEFNEKFO : IEquatable<OFFCEFNEKFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public GHDGELDIJEA GFJJKAJGMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int NONLECIPMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int KGFEHNPIMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Vector3 IJBMDEBMHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Quaternion ABMJIMFAJBP;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5000EF0", Offset = "0x4FFF8F0", VA = "0x185000EF0")]
	public OFFCEFNEKFO(GHDGELDIJEA GFJJKAJGMKF, int NONLECIPMNH, int KGFEHNPIMOB, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5000FA0", Offset = "0x4FFF9A0", VA = "0x185000FA0")]
	public OFFCEFNEKFO(GHDGELDIJEA GFJJKAJGMKF, int NONLECIPMNH, int KGFEHNPIMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5000F50", Offset = "0x4FFF950", VA = "0x185000F50")]
	public OFFCEFNEKFO(GHDGELDIJEA GFJJKAJGMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5000A40", Offset = "0x4FFF440", VA = "0x185000A40", Slot = "4")]
	public bool Equals(OFFCEFNEKFO BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5000AE0", Offset = "0x4FFF4E0", VA = "0x185000AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class KEBHFIOJOEB : OAJOKLEOGNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Transform MLMJNFGMBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private MOCGNBGEDEM MOFAHCOMLPJ;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3040830", Offset = "0x303F230", VA = "0x183040830", Slot = "4")]
	public void GICNDCMAEJH(Transform MLMJNFGMBPE, MOCGNBGEDEM MOFAHCOMLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF85B0", Offset = "0x4FF6FB0", VA = "0x184FF85B0", Slot = "5")]
	public MOCGNBGEDEM GHHLNIGPNBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8600", Offset = "0x4FF7000", VA = "0x184FF8600", Slot = "6")]
	public void KMDGPMJMJAH(MOCGNBGEDEM FGGPGMIGNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public KEBHFIOJOEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal class ONFOCJGFJGH : IDisposable, EOJCAFOBDHG
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JAPDDAHHIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public GHDGELDIJEA oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GHDGELDIJEA newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public JAPDDAHHIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4FF6070", Offset = "0x4FF4A70", VA = "0x184FF6070")]
		internal bool <NotifyRootChangedRecurse>b__0(OAFCDMOCILF node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly KENDMMOAFKD PMOMDHIMOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private JKMCCHOCMCE IMIANDCFCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private OGCCOOPAGDI HNIDBFHKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool HADGFIFKEHF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public OAFCDMOCILF OBODCAIPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5008370", Offset = "0x5006D70", VA = "0x185008370")]
	public bool ILNKKJCFIBH(in GJNCOPOLDKH PJIINDGLAPJ, bool BAMKGGDBHEK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5009D30", Offset = "0x5008730", VA = "0x185009D30")]
	private bool MJJHDGJMIML(in GJNCOPOLDKH PJIINDGLAPJ, bool BAMKGGDBHEK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5007410", Offset = "0x5005E10", VA = "0x185007410", Slot = "8")]
	public bool DFFBGPNODAP(GHDGELDIJEA OHGANMPPHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x500ABD0", Offset = "0x50095D0", VA = "0x18500ABD0")]
	private bool PHJKKMNIMJM(GHDGELDIJEA BIJEEOFCAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5007360", Offset = "0x5005D60", VA = "0x185007360")]
	private static bool CLBGDCIKODH(GHDGELDIJEA BIJEEOFCAKO, KENDMMOAFKD FIFGBGBCJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5006DC0", Offset = "0x50057C0", VA = "0x185006DC0")]
	private void BPIBDBDLFMI(Transform GDFELEGCAKH, KENDMMOAFKD MCPKMKFHCFO, KENDMMOAFKD[] OCNFOILNCHI, GHDGELDIJEA BDDNJIEJEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x50092F0", Offset = "0x5007CF0", VA = "0x1850092F0")]
	private OFFCEFNEKFO KLHNJAIFDJL(Transform GHHGJBCDAIG, OFFCEFNEKFO EDLNIAAFOFO)
	{
		return default(OFFCEFNEKFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5007A50", Offset = "0x5006450", VA = "0x185007A50")]
	private static bool FCAGEFCPABJ(KENDMMOAFKD FIFGBGBCJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5007290", Offset = "0x5005C90", VA = "0x185007290")]
	private string CKGMOMNGAHE(GHDGELDIJEA GFJJKAJGMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5009190", Offset = "0x5007B90", VA = "0x185009190")]
	private string KFJCCHJMFHN(GHDGELDIJEA GFJJKAJGMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5006780", Offset = "0x5005180", VA = "0x185006780")]
	private void BIMIHDAEAAI(in GJNCOPOLDKH PJIINDGLAPJ, bool FOLNLFBDPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x500A900", Offset = "0x5009300", VA = "0x18500A900")]
	private void NPBIPAOBCGH(GHDGELDIJEA AHDACGEMPDI, bool FOLNLFBDPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x50083C0", Offset = "0x5006DC0", VA = "0x1850083C0")]
	private void IBFLGBDOIJG(GHDGELDIJEA IEBBDBECCID, int CMIOPJCNKFM, GHDGELDIJEA CLJJCFEFLNI, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP, bool FOLNLFBDPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5007D30", Offset = "0x5006730", VA = "0x185007D30")]
	private void HAFDGAELBPG(GHDGELDIJEA MFFCAKEJHFI, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP, bool AIEHMANILKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x50075F0", Offset = "0x5005FF0", VA = "0x1850075F0", Slot = "9")]
	public bool ECABEOODJDC(GHDGELDIJEA MFFCAKEJHFI, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x50089B0", Offset = "0x50073B0", VA = "0x1850089B0")]
	private bool ILFOCLDJCMM(GHDGELDIJEA MFFCAKEJHFI, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5009480", Offset = "0x5007E80", VA = "0x185009480")]
	private static void LCGIPOMPPEP(GHDGELDIJEA MFFCAKEJHFI, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP, KENDMMOAFKD FINPCHCMEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5007B50", Offset = "0x5006550", VA = "0x185007B50")]
	private void FIIKLPNDLMJ(GHDGELDIJEA IEBBDBECCID, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5008FF0", Offset = "0x50079F0", VA = "0x185008FF0")]
	private void JEHAOFDJIKN(KENDMMOAFKD CPEGANFPGPI, GHDGELDIJEA GJIHMHGMMMC, GHDGELDIJEA JMPJNJGCPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5008F80", Offset = "0x5007980", VA = "0x185008F80")]
	private void JEHAOFDJIKN(GHDGELDIJEA GFJJKAJGMKF, GHDGELDIJEA GJIHMHGMMMC, GHDGELDIJEA JMPJNJGCPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x500A2C0", Offset = "0x5008CC0", VA = "0x18500A2C0")]
	private void MPIFMIAIEKI(GHDGELDIJEA GFJJKAJGMKF, GHDGELDIJEA GJIHMHGMMMC, GHDGELDIJEA JMPJNJGCPLO, bool EBLHCCBCAHD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x500A3E0", Offset = "0x5008DE0", VA = "0x18500A3E0")]
	private void MPIFMIAIEKI(KENDMMOAFKD JBBMOMLGMKJ, GHDGELDIJEA BDDNJIEJEGH, GHDGELDIJEA MKHOFKIPDIG, bool EBLHCCBCAHD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5009C20", Offset = "0x5008620", VA = "0x185009C20")]
	private void LPDCINBDMEG(GHDGELDIJEA AHDACGEMPDI, int CMIOPJCNKFM, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5006620", Offset = "0x5005020", VA = "0x185006620")]
	private void AJJHPLBBCHG(OAFCDMOCILF EGNCPOLPGCD, OAFCDMOCILF BPGKNEOBBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x500A7D0", Offset = "0x50091D0", VA = "0x18500A7D0", Slot = "13")]
	public void NOALDJMFGNC(GHDGELDIJEA GFJJKAJGMKF, out Vector3 IJBMDEBMHMN, out Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5009060", Offset = "0x5007A60", VA = "0x185009060", Slot = "14")]
	public GHDGELDIJEA JPIOANIGLFM(GHDGELDIJEA GFJJKAJGMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x50076D0", Offset = "0x50060D0", VA = "0x1850076D0", Slot = "15")]
	public void EEFPPHDAPID(GHDGELDIJEA GFJJKAJGMKF, HashSet<GHDGELDIJEA> KCCLBIPOHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x500A4F0", Offset = "0x5008EF0", VA = "0x18500A4F0", Slot = "16")]
	public List<GHDGELDIJEA> NJNPAOIHOEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x500A700", Offset = "0x5009100", VA = "0x18500A700")]
	protected OAFCDMOCILF NNNKCKEAPAJ(OAFCDMOCILF CPEGANFPGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x50071F0", Offset = "0x5005BF0", VA = "0x1850071F0")]
	protected KENDMMOAFKD[] CBBMPPFMFPD(KENDMMOAFKD FIFGBGBCJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5007A80", Offset = "0x5006480", VA = "0x185007A80")]
	protected bool FDLPOIJFPGJ(GHDGELDIJEA GFJJKAJGMKF, out KENDMMOAFKD CPEGANFPGPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x500AAD0", Offset = "0x50094D0", VA = "0x18500AAD0", Slot = "17")]
	public bool PGPEEDGNOFN(GHDGELDIJEA GFJJKAJGMKF, out OFFCEFNEKFO AGBILCDNNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5007A10", Offset = "0x5006410", VA = "0x185007A10")]
	protected KENDMMOAFKD FBOKEHDBMNH(OFFCEFNEKFO HILLCCADHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5009200", Offset = "0x5007C00", VA = "0x185009200", Slot = "10")]
	public bool KIIJBCEPGCH(GHDGELDIJEA IEBBDBECCID, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5009600", Offset = "0x5008000", VA = "0x185009600")]
	private bool LJCDAELKLIN(GHDGELDIJEA IEBBDBECCID, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5009B50", Offset = "0x5008550", VA = "0x185009B50")]
	private static bool LKDMNIGBMPO(KENDMMOAFKD FGJGKMFAEMA, OFFCEFNEKFO ADGLLMMGNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x500B1B0", Offset = "0x5009BB0", VA = "0x18500B1B0")]
	public ONFOCJGFJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5007CA0", Offset = "0x50066A0", VA = "0x185007CA0", Slot = "5")]
	public void GICNDCMAEJH(CLHMFLMOMOE PCKMABEFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5007C70", Offset = "0x5006670", VA = "0x185007C70", Slot = "19")]
	public void GCBPPBEHGPP(KALHIIDOMGD MLFGBBGKHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5008C40", Offset = "0x5007640", VA = "0x185008C40", Slot = "12")]
	public void IMDAIJGHIGG(Func<GHDGELDIJEA, bool> BILKJOBOBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5008C50", Offset = "0x5007650", VA = "0x185008C50")]
	private void IMDAIJGHIGG(KENDMMOAFKD CPEGANFPGPI, Func<GHDGELDIJEA, bool> BILKJOBOBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x500A2A0", Offset = "0x5008CA0", VA = "0x18500A2A0", Slot = "11")]
	public void MOOAGNONGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5008370", Offset = "0x5006D70", VA = "0x185008370", Slot = "7")]
	private bool HMBKIELPNKA(in GJNCOPOLDKH PJIINDGLAPJ, bool BAMKGGDBHEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Preserve]
internal class KNKALJALALH : CLHMFLMOMOE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly MCKMOPCGMKB FOFFAOBPIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly OGCCOOPAGDI HNIDBFHKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly EGJELDBIMBF JLCDJCJCHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly KPBGNGLCOBN AKMKADIDNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly EOJCAFOBDHG DDLGPJEILKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal PAKEHFIODGK MGOGCFMPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal FDIMNMJNCBN MCPBOIHDMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal JKMCCHOCMCE EAGGHNIEMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal bool HADGFIFKEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool DMNICDMFNCM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MKIOEECCJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x869800", Offset = "0x868200", VA = "0x180869800")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xC726D0", Offset = "0xC710D0", VA = "0x180C726D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool MMGCNOGJJID
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xC726C0", Offset = "0xC710C0", VA = "0x180C726C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xC726E0", Offset = "0xC710E0", VA = "0x180C726E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<GHDGELDIJEA, GHDGELDIJEA> PLFCNPKHAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4FFA930", Offset = "0x4FF9330", VA = "0x184FFA930", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4FFA260", Offset = "0x4FF8C60", VA = "0x184FFA260", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<GHDGELDIJEA, GHDGELDIJEA> NNEPFJMCGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4FFA990", Offset = "0x4FF9390", VA = "0x184FFA990", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4FFAE50", Offset = "0x4FF9850", VA = "0x184FFAE50", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<GHDGELDIJEA, GHDGELDIJEA, GHDGELDIJEA> LDDABIGJOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9FA0", Offset = "0x4FF89A0", VA = "0x184FF9FA0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4FFAEB0", Offset = "0x4FF98B0", VA = "0x184FFAEB0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB0E0", Offset = "0x4FF9AE0", VA = "0x184FFB0E0")]
	public KNKALJALALH(MCKMOPCGMKB FOFFAOBPIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9A20", Offset = "0x4FF8420", VA = "0x184FF9A20", Slot = "11")]
	public void GICNDCMAEJH(GameObject OOAFGPFKNDK, AJCAAFIIELM DGHNOAJEKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF97D0", Offset = "0x4FF81D0", VA = "0x184FF97D0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAF10", Offset = "0x4FF9910", VA = "0x184FFAF10", Slot = "12")]
	public void OPDLCGHKCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAD20", Offset = "0x4FF9720", VA = "0x184FFAD20", Slot = "13")]
	public void MKIHEFFHNPG(GHDGELDIJEA GFJJKAJGMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9770", Offset = "0x4FF8170", VA = "0x184FF9770", Slot = "14")]
	public void EPNEEGPIJCB(GHDGELDIJEA GFJJKAJGMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9A10", Offset = "0x4FF8410", VA = "0x184FF9A10", Slot = "22")]
	public bool FPJNDMCLJDE(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAAA0", Offset = "0x4FF94A0", VA = "0x184FFAAA0")]
	internal bool MJJHDGJMIML(in GJNCOPOLDKH PJIINDGLAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA9F0", Offset = "0x4FF93F0", VA = "0x184FFA9F0")]
	internal bool LJCDAELKLIN(in GJNCOPOLDKH PJIINDGLAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4FF99B0", Offset = "0x4FF83B0", VA = "0x184FF99B0")]
	internal bool FIEGPCJLJPA(in GJNCOPOLDKH PJIINDGLAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9580", Offset = "0x4FF7F80", VA = "0x184FF9580")]
	internal bool AOCKGMLBGPF(in GJNCOPOLDKH PJIINDGLAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA750", Offset = "0x4FF9150", VA = "0x184FFA750")]
	internal void KLHIBBBPMEB(GHDGELDIJEA GFJJKAJGMKF, int GAMMAOPKHFL, bool BAMKGGDBHEK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9770", Offset = "0x4FF8170", VA = "0x184FF9770")]
	internal bool DKFKOJCBKBI(GHDGELDIJEA KJKMKHEJHCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAFB0", Offset = "0x4FF99B0", VA = "0x184FFAFB0")]
	internal bool PNGDNDKANIF(GHDGELDIJEA MFFCAKEJHFI, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9870", Offset = "0x4FF8270", VA = "0x184FF9870", Slot = "15")]
	public void EEFPPHDAPID(GHDGELDIJEA GFJJKAJGMKF, HashSet<GHDGELDIJEA> GJEDDPJLJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA400", Offset = "0x4FF8E00", VA = "0x184FFA400", Slot = "16")]
	public void JPEPCCNPAGI(GHDGELDIJEA MFFCAKEJHFI, GHDGELDIJEA KOHEAHFONMC, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA000", Offset = "0x4FF8A00", VA = "0x184FFA000")]
	public void HDCJDJIJBDC(GHDGELDIJEA GNANPBBENAI, int CMIOPJCNKFM, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4FFADF0", Offset = "0x4FF97F0", VA = "0x184FFADF0")]
	public void MMENDDIPDBI(GHDGELDIJEA OHGANMPPHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA610", Offset = "0x4FF9010", VA = "0x184FFA610")]
	public void JPEPCCNPAGI(GHDGELDIJEA MFFCAKEJHFI, GHDGELDIJEA KOHEAHFONMC, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA2C0", Offset = "0x4FF8CC0", VA = "0x184FFA2C0", Slot = "17")]
	public void JENHKJHCCKM(GHDGELDIJEA IEBBDBECCID, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAB60", Offset = "0x4FF9560", VA = "0x184FFAB60", Slot = "18")]
	public void MJPIINGEIHC(GHDGELDIJEA IEBBDBECCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAF60", Offset = "0x4FF9960", VA = "0x184FFAF60", Slot = "19")]
	public bool PCPMEJFBKCC(GHDGELDIJEA GFJJKAJGMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA140", Offset = "0x4FF8B40", VA = "0x184FFA140")]
	public void HIFBPGDBHBA([Optional] GKKJANMNCLK DBOGENDIBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4FF96E0", Offset = "0x4FF80E0", VA = "0x184FF96E0", Slot = "23")]
	public void CLEMOLKHNFG(BKGAHBFKJIL DDLGPJEILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4FF96C0", Offset = "0x4FF80C0", VA = "0x184FF96C0", Slot = "20")]
	public BKGAHBFKJIL CHKHHICCNDO(bool DFIMAOEIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAA80", Offset = "0x4FF9480", VA = "0x184FFAA80", Slot = "21")]
	public BKGAHBFKJIL MBBBBKFMEHK(HashSet<Guid> GLNEOFBCBNO, bool DFIMAOEIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9970", Offset = "0x4FF8370", VA = "0x184FF9970", Slot = "25")]
	public void FBEOFMCIGLJ(BKGAHBFKJIL DDLGPJEILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAD40", Offset = "0x4FF9740", VA = "0x184FFAD40", Slot = "24")]
	public void MLJCGAALAGP(BKGAHBFKJIL DDLGPJEILKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class OGCCOOPAGDI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly global::KPOAKAINNON<GHDGELDIJEA, GHDGELDIJEA> PLFCNPKHAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly global::KPOAKAINNON<GHDGELDIJEA, GHDGELDIJEA> NNEPFJMCGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly global::EOKHNCLKHDO<GHDGELDIJEA, GHDGELDIJEA, GHDGELDIJEA> LDDABIGJOGM;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5001150", Offset = "0x4FFFB50", VA = "0x185001150")]
	public OGCCOOPAGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public void GICNDCMAEJH(KNKALJALALH PCKMABEFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x50010F0", Offset = "0x4FFFAF0", VA = "0x1850010F0")]
	public void PKEBONGFLHB(GHDGELDIJEA EGNCPOLPGCD, GHDGELDIJEA AHDACGEMPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5001010", Offset = "0x4FFFA10", VA = "0x185001010")]
	public void DDMDMHIDCMA(GHDGELDIJEA EGNCPOLPGCD, GHDGELDIJEA AHDACGEMPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5001070", Offset = "0x4FFFA70", VA = "0x185001070")]
	public void GHKHCFFICCA(GHDGELDIJEA NKGEBLNPFNO, GHDGELDIJEA CLJJCFEFLNI, GHDGELDIJEA AHDACGEMPDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class EGJELDBIMBF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private KNKALJALALH PCKMABEFMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private FDIMNMJNCBN MCPBOIHDMMJ;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public EGJELDBIMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5020", Offset = "0x4FF3A20", VA = "0x184FF5020")]
	public void GICNDCMAEJH(KNKALJALALH PCKMABEFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4FF0", Offset = "0x4FF39F0", VA = "0x184FF4FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5000", Offset = "0x4FF3A00", VA = "0x184FF5000")]
	private void EIJJNLAGCGI(GKKJANMNCLK IBALNAIHOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5260", Offset = "0x4FF3C60", VA = "0x184FF5260")]
	private void LPOMKFMHEFL(GKKJANMNCLK PNAIBFOOLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5160", Offset = "0x4FF3B60", VA = "0x184FF5160")]
	public void IJPIDBDOFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4EE0", Offset = "0x4FF38E0", VA = "0x184FF4EE0")]
	public void ANNJDALFHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class PLMGFOGOGKL
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FOHCNBBPBLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MCKMOPCGMKB container;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public FOHCNBBPBLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5320", Offset = "0x4FF3D20", VA = "0x184FF5320")]
		internal KNKALJALALH <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x500B4C0", Offset = "0x5009EC0", VA = "0x18500B4C0")]
	public static void JNFAHCDNCJK(MCKMOPCGMKB FOFFAOBPIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x500B6C0", Offset = "0x500A0C0", VA = "0x18500B6C0")]
	public static void OLBONHCAGDK(MCKMOPCGMKB FOFFAOBPIJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
internal class AFJKGNKADDL : IDisposable, JKMCCHOCMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Dictionary<int, MOCGNBGEDEM> GGIIGLHBJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly KALHIIDOMGD EJLHFOKGNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private OAJOKLEOGNL CNKJNAIKGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private EOJCAFOBDHG DDLGPJEILKB;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4FEF1C0", Offset = "0x4FEDBC0", VA = "0x184FEF1C0")]
	public AFJKGNKADDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4FEEF10", Offset = "0x4FED910", VA = "0x184FEEF10", Slot = "7")]
	public void GICNDCMAEJH(EOJCAFOBDHG DDLGPJEILKB, OAJOKLEOGNL CNKJNAIKGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE810", Offset = "0x4FED210", VA = "0x184FEE810", Slot = "5")]
	public void BBAEHOFEHAI(OAFCDMOCILF AOAAJFHCNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE6A0", Offset = "0x4FED0A0", VA = "0x184FEE6A0", Slot = "9")]
	public void AKLIEHCLJNH(OAFCDMOCILF PHIFFCFKOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4FEF010", Offset = "0x4FEDA10", VA = "0x184FEF010", Slot = "8")]
	public void NBFKJCPJDOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4FEEBF0", Offset = "0x4FED5F0", VA = "0x184FEEBF0", Slot = "10")]
	public void FDEPLJMKAAH(OAFCDMOCILF MHKGFBLEIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4FEEF50", Offset = "0x4FED950", VA = "0x184FEEF50", Slot = "11")]
	public void KIBDKPBGKCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4FEEA50", Offset = "0x4FED450", VA = "0x184FEEA50")]
	private bool ELEAOLMCHPM(OAFCDMOCILF JMEPHEBPBHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class KPBGNGLCOBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal struct DKMIEAMNEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly KENDMMOAFKD JHDGGIICKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly HashSet<Guid> GLNEOFBCBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly KMJLLKLNMEP EANCAJPGGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly KMJLLKLNMEP CPICDIGOJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly bool DFIMAOEIDBB;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool GJCOHMMEJNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x4FF4B60", Offset = "0x4FF3560", VA = "0x184FF4B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4DD0", Offset = "0x4FF37D0", VA = "0x184FF4DD0")]
		public DKMIEAMNEFN(KENDMMOAFKD JHDGGIICKDA, HashSet<Guid> GLNEOFBCBNO, bool DFIMAOEIDBB, [Optional] KMJLLKLNMEP EANCAJPGGAK, [Optional] KMJLLKLNMEP CPICDIGOJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4C70", Offset = "0x4FF3670", VA = "0x184FF4C70")]
		public KMJLLKLNMEP NJDODOCIOLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4700", Offset = "0x4FF3100", VA = "0x184FF4700")]
		private KMJLLKLNMEP DBICHEOJLOE(out KMJLLKLNMEP HCCMDCLEFFF, out KMJLLKLNMEP LJCALFBPJJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4960", Offset = "0x4FF3360", VA = "0x184FF4960")]
		private KMJLLKLNMEP LJPDLHMIPON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4580", Offset = "0x4FF2F80", VA = "0x184FF4580")]
		private void BAGONCFJNHA(KMJLLKLNMEP PJLHCABJBGI, KMJLLKLNMEP ODOFLFPJMEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4FF47C0", Offset = "0x4FF31C0", VA = "0x184FF47C0")]
		private void LDKIDACPJNK(KMJLLKLNMEP HCCMDCLEFFF, KMJLLKLNMEP LJCALFBPJJK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private KNKALJALALH PCKMABEFMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private EOJCAFOBDHG DDLGPJEILKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private JKMCCHOCMCE IMIANDCFCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private FDIMNMJNCBN MCPBOIHDMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool NEIBLBMHHDF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool DEIEOMADKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4FFD680", Offset = "0x4FFC080", VA = "0x184FFD680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool MKIOEECCJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4FFB420", Offset = "0x4FF9E20", VA = "0x184FFB420")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4FFBFB0", Offset = "0x4FFA9B0", VA = "0x184FFBFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC440", Offset = "0x4FFAE40", VA = "0x184FFC440")]
	public void GICNDCMAEJH(KNKALJALALH PCKMABEFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB5C0", Offset = "0x4FF9FC0", VA = "0x184FFB5C0")]
	public BKGAHBFKJIL CHKHHICCNDO(bool DFIMAOEIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD6D0", Offset = "0x4FFC0D0", VA = "0x184FFD6D0")]
	public BKGAHBFKJIL MBBBBKFMEHK(HashSet<Guid> GLNEOFBCBNO, bool DFIMAOEIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4FFBC80", Offset = "0x4FFA680", VA = "0x184FFBC80")]
	public void CLEMOLKHNFG(BKGAHBFKJIL DDLGPJEILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE020", Offset = "0x4FFCA20", VA = "0x184FFE020")]
	public void MLJCGAALAGP(BKGAHBFKJIL DDLGPJEILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC8E0", Offset = "0x4FFB2E0", VA = "0x184FFC8E0")]
	public void IJPILJMKDEB(BKGAHBFKJIL DDLGPJEILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC4B0", Offset = "0x4FFAEB0", VA = "0x184FFC4B0")]
	private void HBPAKJFDJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE2C0", Offset = "0x4FFCCC0", VA = "0x184FFE2C0")]
	private KMJLLKLNMEP ONIJAIJKMOA(KENDMMOAFKD CPEGANFPGPI, bool DFIMAOEIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD0B0", Offset = "0x4FFBAB0", VA = "0x184FFD0B0")]
	private static void KCPFEBJPLFA(KENDMMOAFKD CPEGANFPGPI, bool DFIMAOEIDBB, KMJLLKLNMEP PGAEIMKMJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE0C0", Offset = "0x4FFCAC0", VA = "0x184FFE0C0")]
	private void OAOJALKNNDG(KENDMMOAFKD CPEGANFPGPI, bool DFIMAOEIDBB, KMJLLKLNMEP PGAEIMKMJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE4A0", Offset = "0x4FFCEA0", VA = "0x184FFE4A0")]
	private KMJLLKLNMEP ONMHLEPENOB(KENDMMOAFKD JHDGGIICKDA, HashSet<Guid> GLNEOFBCBNO, bool DFIMAOEIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4FFBD30", Offset = "0x4FFA730", VA = "0x184FFBD30")]
	private bool FEKOLPGKMJA(BKGAHBFKJIL EGJBKEODPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC910", Offset = "0x4FFB310", VA = "0x184FFC910")]
	private bool IKNIGDGALJA(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4FFBD10", Offset = "0x4FFA710", VA = "0x184FFBD10")]
	private bool FBAAHCAKFHL(BKGAHBFKJIL DDLGPJEILKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC010", Offset = "0x4FFAA10", VA = "0x184FFC010")]
	private static bool FKJEBGMMBEN(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC180", Offset = "0x4FFAB80", VA = "0x184FFC180")]
	public static bool FPJNDMCLJDE(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD330", Offset = "0x4FFBD30", VA = "0x184FFD330")]
	private GHDGELDIJEA LAFKHMOHCEC(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4FFDE90", Offset = "0x4FFC890", VA = "0x184FFDE90")]
	private GHDGELDIJEA MJLGIPEDIBE(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB440", Offset = "0x4FF9E40", VA = "0x184FFB440")]
	private GHDGELDIJEA CDFPDLHICMP(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4FFBFD0", Offset = "0x4FFA9D0", VA = "0x184FFBFD0")]
	private static Guid FIFEDOBLEFI(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE530", Offset = "0x4FFCF30", VA = "0x184FFE530")]
	private string PPCCLIKLPDP(KMJLLKLNMEP PGAEIMKMJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4FFCF50", Offset = "0x4FFB950", VA = "0x184FFCF50")]
	private bool INPPBGALPJJ(KENDMMOAFKD CPEGANFPGPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC640", Offset = "0x4FFB040", VA = "0x184FFC640")]
	private static void HJEGGHCLDFN(KENDMMOAFKD JHDGGIICKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public KPBGNGLCOBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BIDAOOEMLKC : GMHFEOLHCCL, GNMLMDCIJFP
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private const string AHEAGIHMHLP = "Parented";

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string CLFHGPHEEMP = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GameObject OOAFGPFKNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CLHMFLMOMOE MOFCOAHCJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly PDOBOFCLJAF DGCBKHEJKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly AEPJKABJIKB[] CLMIGEDABPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly MMGPHCFKFLG MGOGCFMPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<GHDGELDIJEA> PBDIAOGMHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private DJJNDPGFMFB KJPBHCCHANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private Vector3 BCHOFDONKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Quaternion MNMHNFBPGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool OEJOLOFFADA;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GHDGELDIJEA NDAGLONGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GHDGELDIJEA EFCHEJDNNNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6983A0", Offset = "0x696DA0", VA = "0x1806983A0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A4870", Offset = "0x6A3270", VA = "0x1806A4870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Vector3 HHEAKENFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4FF0630", Offset = "0x4FEF030", VA = "0x184FF0630", Slot = "15")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9C12F0", Offset = "0x9BFCF0", VA = "0x1809C12F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Quaternion EDGANIKEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4FF2720", Offset = "0x4FF1120", VA = "0x184FF2720", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xDC7EC0", Offset = "0xDC68C0", VA = "0x180DC7EC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DDGMLEKEPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x90AB00", Offset = "0x909500", VA = "0x18090AB00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E88B0", Offset = "0x6E72B0", VA = "0x1806E88B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PADINPONGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4FF06A0", Offset = "0x4FEF0A0", VA = "0x184FF06A0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public GHDGELDIJEA PPCFGKEMEOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x761310", Offset = "0x75FD10", VA = "0x180761310", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x761360", Offset = "0x75FD60", VA = "0x180761360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool BHIPIBHHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4FF1B70", Offset = "0x4FF0570", VA = "0x184FF1B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private RigidbodyEx DHPKLEGPIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4FF19F0", Offset = "0x4FF03F0", VA = "0x184FF19F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<GHDGELDIJEA> JNDFEFINCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6B0AB0", Offset = "0x6AF4B0", VA = "0x1806B0AB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LOLPBDINKKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4FF1F50", Offset = "0x4FF0950", VA = "0x184FF1F50", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4FF1290", Offset = "0x4FEFC90", VA = "0x184FF1290", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Transform OCHLAIKCOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3760", Offset = "0x4FF2160", VA = "0x184FF3760", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GameObject IDBECDIBJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string PCBAHGDOBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4FF34D0", Offset = "0x4FF1ED0", VA = "0x184FF34D0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Guid OFGBBFDHNEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3630", Offset = "0x4FF2030", VA = "0x184FF3630", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int PCAFFDIBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3710", Offset = "0x4FF2110", VA = "0x184FF3710", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public CAMBCDMDDIB JDFAMBIABIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3520", Offset = "0x4FF1F20", VA = "0x184FF3520", Slot = "39")]
		get
		{
			return default(CAMBCDMDDIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool AMJJPKINAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event GCKDDFPHKCL JGMIGFONDAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4FF11F0", Offset = "0x4FEFBF0", VA = "0x184FF11F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4FEFD60", Offset = "0x4FEE760", VA = "0x184FEFD60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event GCKDDFPHKCL IPNGMOLAHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4FF18B0", Offset = "0x4FF02B0", VA = "0x184FF18B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4FEFCA0", Offset = "0x4FEE6A0", VA = "0x184FEFCA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event GCKDDFPHKCL MGAPMKLBHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4FEFC00", Offset = "0x4FEE600", VA = "0x184FEFC00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4FF1950", Offset = "0x4FF0350", VA = "0x184FF1950", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event APONMGBBIOK IJLFEPPJONF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4FF2680", Offset = "0x4FF1080", VA = "0x184FF2680", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4FF1EB0", Offset = "0x4FF08B0", VA = "0x184FF1EB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4FEFBA0", Offset = "0x4FEE5A0", VA = "0x184FEFBA0")]
	private RigidbodyEx ADOFELFGJBO(GHDGELDIJEA DGCBKHEJKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4FF33E0", Offset = "0x4FF1DE0", VA = "0x184FF33E0")]
	public BIDAOOEMLKC(GameObject OOAFGPFKNDK, PDOBOFCLJAF DGCBKHEJKPN, AEPJKABJIKB[] CLMIGEDABPD, MMGPHCFKFLG MGOGCFMPFGO, CLHMFLMOMOE MOFCOAHCJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0070", Offset = "0x4FEEA70", VA = "0x184FF0070", Slot = "20")]
	public void CKNLEBEOEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4FF2030", Offset = "0x4FF0A30", VA = "0x184FF2030", Slot = "22")]
	public void MJILHEEHHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1A50", Offset = "0x4FF0450", VA = "0x184FF1A50", Slot = "23")]
	public void IPCKJCGBKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1FA0", Offset = "0x4FF09A0", VA = "0x184FF1FA0", Slot = "21")]
	public void LOIIHJFIPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1BC0", Offset = "0x4FF05C0", VA = "0x184FF1BC0")]
	private void JPFBHEAGEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4FF24D0", Offset = "0x4FF0ED0", VA = "0x184FF24D0")]
	private void OJGPLMNGDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4FF2790", Offset = "0x4FF1190", VA = "0x184FF2790", Slot = "24")]
	public void PONJEDPCFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4FEFD40", Offset = "0x4FEE740", VA = "0x184FEFD40", Slot = "25")]
	public void BIECHEFGLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4FEFE00", Offset = "0x4FEE800", VA = "0x184FEFE00", Slot = "26")]
	public void CDNPLBBFKKH(int LFKBCKKNHOH, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1E10", Offset = "0x4FF0810", VA = "0x184FF1E10", Slot = "27")]
	public void KMOJEKFKEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1560", Offset = "0x4FEFF60", VA = "0x184FF1560", Slot = "28")]
	public void HGPOOKCIBPD(int LFKBCKKNHOH, GHDGELDIJEA GNANPBBENAI, int CMIOPJCNKFM, [Optional] Vector3? IJBMDEBMHMN, [Optional] Quaternion? ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1D70", Offset = "0x4FF0770", VA = "0x184FF1D70", Slot = "29")]
	public void KHOPANACFBB(GHDGELDIJEA GNANPBBENAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4FF06B0", Offset = "0x4FEF0B0", VA = "0x184FF06B0")]
	private void EKNIOLPNNLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4FEFA00", Offset = "0x4FEE400", VA = "0x184FEFA00", Slot = "31")]
	public void ACOOMLCIDJE(int NENMOOINMCH, Vector3 DEFMLJAJEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4FF2090", Offset = "0x4FF0A90", VA = "0x184FF2090", Slot = "32")]
	public void NIFOGIMENEJ(Vector3 MNAMNMDDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0AA0", Offset = "0x4FEF4A0", VA = "0x184FF0AA0", Slot = "30")]
	public void EOHFEOLFMPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1490", Offset = "0x4FEFE90", VA = "0x184FF1490", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int LFKBCKKNHOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1350", Offset = "0x4FEFD50", VA = "0x184FF1350", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int LFKBCKKNHOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0xD768B0", Offset = "0xD752B0", VA = "0x180D768B0", Slot = "43")]
	public Color GetConnectionSlotColor(int LFKBCKKNHOH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4FF01C0", Offset = "0x4FEEBC0", VA = "0x184FF01C0", Slot = "44")]
	public bool CanConnectTo(int LFKBCKKNHOH, GHDGELDIJEA BBHMDBONOGC, int ALHIPPNKIAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1AD0", Offset = "0x4FF04D0", VA = "0x184FF1AD0")]
	public bool JEJFAEMEMPN(GHDGELDIJEA BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4FF27B0", Offset = "0x4FF11B0", VA = "0x184FF27B0", Slot = "45")]
	public void ParentChanged(int LFKBCKKNHOH, GHDGELDIJEA IEFECJJPGCH, int FCAOCJOLOBL, Vector3 BFONBEIJDBC, Quaternion MFNAFELJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0260", Offset = "0x4FEEC60", VA = "0x184FF0260", Slot = "46")]
	public void ChildAdded(int LFKBCKKNHOH, GHDGELDIJEA FPOEGFDKGIO, int CIGFLGAADCN, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0410", Offset = "0x4FEEE10", VA = "0x184FF0410", Slot = "47")]
	public void ChildRemoved(int LFKBCKKNHOH, GHDGELDIJEA LJDJANKHGPM, int GFPOGFKHLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4FF04D0", Offset = "0x4FEEED0", VA = "0x184FF04D0", Slot = "48")]
	public void ConnectionModified(int LFKBCKKNHOH, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3380", Offset = "0x4FF1D80", VA = "0x184FF3380", Slot = "49")]
	public void RootChanged(GHDGELDIJEA MHDPKPPHLGG, GHDGELDIJEA MKHOFKIPDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1180", Offset = "0x4FEFB80", VA = "0x184FF1180")]
	private void EOPNKPHHJAN(GKKJANMNCLK CJCABNNPDMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct GJNCOPOLDKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public GHDGELDIJEA AHDACGEMPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public GHDGELDIJEA EGNCPOLPGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int CMIOPJCNKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public int GECPIEDBOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 IJBMDEBMHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion ABMJIMFAJBP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public OFFCEFNEKFO EAMDDDAIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5C40", Offset = "0x4FF4640", VA = "0x184FF5C40")]
		get
		{
			return default(OFFCEFNEKFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public OFFCEFNEKFO LHJNMLAHODA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5BD0", Offset = "0x4FF45D0", VA = "0x184FF5BD0")]
		get
		{
			return default(OFFCEFNEKFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4FF5CE0", Offset = "0x4FF46E0", VA = "0x184FF5CE0")]
	public GJNCOPOLDKH(GHDGELDIJEA AHDACGEMPDI, GHDGELDIJEA EGNCPOLPGCD, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface EOJCAFOBDHG
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	OAFCDMOCILF OBODCAIPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GICNDCMAEJH(CLHMFLMOMOE PCKMABEFMOP);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ILNKKJCFIBH(in GJNCOPOLDKH PJIINDGLAPJ, bool BAMKGGDBHEK = true);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DFFBGPNODAP(GHDGELDIJEA OHGANMPPHGO);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ECABEOODJDC(GHDGELDIJEA MFFCAKEJHFI, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KIIJBCEPGCH(GHDGELDIJEA IEBBDBECCID, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MOOAGNONGMA();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IMDAIJGHIGG(Func<GHDGELDIJEA, bool> BILKJOBOBML);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NOALDJMFGNC(GHDGELDIJEA GFJJKAJGMKF, out Vector3 IJBMDEBMHMN, out Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GHDGELDIJEA JPIOANIGLFM(GHDGELDIJEA GFJJKAJGMKF);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EEFPPHDAPID(GHDGELDIJEA GFJJKAJGMKF, HashSet<GHDGELDIJEA> KCCLBIPOHIG);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "11")]
	List<GHDGELDIJEA> NJNPAOIHOEN();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PGPEEDGNOFN(GHDGELDIJEA GFJJKAJGMKF, out OFFCEFNEKFO AGBILCDNNPO);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GCBPPBEHGPP(KALHIIDOMGD MLFGBBGKHEO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal delegate bool KALHIIDOMGD(OAFCDMOCILF CPEGANFPGPI);
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface OAFCDMOCILF
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	GHDGELDIJEA NDAGLONGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int PLKHEIIHFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int HNOPBHEBBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Vector3 LPAIDMPCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Quaternion DCIIPCIGOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	OAFCDMOCILF JGBBHLPMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	OAFCDMOCILF OBODCAIPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	OFFCEFNEKFO EPPAMKJKDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool DDKOGLEKNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool FFEIHJAFOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GCBPPBEHGPP(KALHIIDOMGD MLFGBBGKHEO, bool EBLHCCBCAHD = true);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OAFCDMOCILF FBOKEHDBMNH(OFFCEFNEKFO GJHJAKLMJCB);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MOCGNBGEDEM
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCHEDBCCHIE(GHDGELDIJEA GDIENNOBGBH, OFFCEFNEKFO AHDACGEMPDI);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEEIKIJCBMN(GHDGELDIJEA GDIENNOBGBH, OFFCEFNEKFO AHDACGEMPDI);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKLBGCCLJDM(GHDGELDIJEA GDIENNOBGBH, OFFCEFNEKFO AHDACGEMPDI);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJGGBKEHLIP(GHDGELDIJEA GDIENNOBGBH, OFFCEFNEKFO AHDACGEMPDI);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MOCGNBGEDEM Instantiate(Transform MLMJNFGMBPE);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGJCJPODOEB();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OAJOKLEOGNL
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GICNDCMAEJH(Transform MLMJNFGMBPE, MOCGNBGEDEM MOFAHCOMLPJ);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MOCGNBGEDEM GHHLNIGPNBO();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMDGPMJMJAH(MOCGNBGEDEM FGGPGMIGNKP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PAKEHFIODGK : FHMCLICBCEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JIFCCGMECLG(Guid ALDGECFPEKH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface JKMCCHOCMCE
{
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBAEHOFEHAI(OAFCDMOCILF AOAAJFHCNJI);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GICNDCMAEJH(EOJCAFOBDHG DDLGPJEILKB, OAJOKLEOGNL MPPBBLFFJEP);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NBFKJCPJDOM();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKLIEHCLJNH(OAFCDMOCILF PHIFFCFKOCN);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FDEPLJMKAAH(OAFCDMOCILF MHKGFBLEIPG);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KIBDKPBGKCJ();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal class KENDMMOAFKD : OAFCDMOCILF
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DHLFBIHPICK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public OFFCEFNEKFO nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public KENDMMOAFKD foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public DHLFBIHPICK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4450", Offset = "0x4FF2E50", VA = "0x184FF4450")]
		internal bool <FindNode>b__0(OAFCDMOCILF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private OFFCEFNEKFO AGBILCDNNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public LinkedList<KENDMMOAFKD> CAGHDNHGGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private KENDMMOAFKD LBGGMAEOHIG;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public OFFCEFNEKFO EPPAMKJKDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2787880", Offset = "0x2786280", VA = "0x182787880", Slot = "16")]
		get
		{
			return default(OFFCEFNEKFO);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4FF8E10", Offset = "0x4FF7810", VA = "0x184FF8E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private KENDMMOAFKD EGNCPOLPGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD80", Offset = "0x6AE780", VA = "0x1806AFD80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4FF8650", Offset = "0x4FF7050", VA = "0x184FF8650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public OAFCDMOCILF JGBBHLPMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD80", Offset = "0x6AE780", VA = "0x1806AFD80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public GHDGELDIJEA NDAGLONGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA0", Offset = "0x6A38A0", VA = "0x1806A4EA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int PLKHEIIHFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70", Slot = "6")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF20", Offset = "0x7FD920", VA = "0x1807FEF20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int HNOPBHEBBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4F0", Offset = "0x7D8EF0", VA = "0x1807DA4F0", Slot = "8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA15C40", Offset = "0xA14640", VA = "0x180A15C40", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 LPAIDMPCCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x80DFB0", Offset = "0x80C9B0", VA = "0x18080DFB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x80E350", Offset = "0x80CD50", VA = "0x18080E350", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Quaternion DCIIPCIGOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x48C4190", Offset = "0x48C2B90", VA = "0x1848C4190", Slot = "12")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x48C41A0", Offset = "0x48C2BA0", VA = "0x1848C41A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool DDKOGLEKNBG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3D28B10", Offset = "0x3D27510", VA = "0x183D28B10", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool FFEIHJAFOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x4FF8730", Offset = "0x4FF7130", VA = "0x184FF8730", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	protected KENDMMOAFKD JBBMOMLGMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9030", Offset = "0x4FF7A30", VA = "0x184FF9030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public OAFCDMOCILF OBODCAIPJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9030", Offset = "0x4FF7A30", VA = "0x184FF9030", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF94E0", Offset = "0x4FF7EE0", VA = "0x184FF94E0")]
	public KENDMMOAFKD(OFFCEFNEKFO NPKIACIHNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8E40", Offset = "0x4FF7840", VA = "0x184FF8E40")]
	public KENDMMOAFKD HNICBHANMKL(OFFCEFNEKFO IMHAIENHAGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9190", Offset = "0x4FF7B90", VA = "0x184FF9190")]
	public KENDMMOAFKD LIIBMDMMAAP(OFFCEFNEKFO GJJMFBJBMGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9310", Offset = "0x4FF7D10", VA = "0x184FF9310")]
	public KENDMMOAFKD OMBMHDCIFDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9050", Offset = "0x4FF7A50", VA = "0x184FF9050")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8F80", Offset = "0x4FF7980", VA = "0x184FF8F80")]
	public KENDMMOAFKD ILDGEPKBIBE(OFFCEFNEKFO CLJJCFEFLNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8CB0", Offset = "0x4FF76B0", VA = "0x184FF8CB0")]
	private static void GCBPPBEHGPP(KENDMMOAFKD JJFMLKJLKLA, KALHIIDOMGD KOBHFNBFEEB, bool NKDEIALJGBH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8E00", Offset = "0x4FF7800", VA = "0x184FF8E00", Slot = "19")]
	public void GCBPPBEHGPP(KALHIIDOMGD MLFGBBGKHEO, bool EBLHCCBCAHD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8780", Offset = "0x4FF7180", VA = "0x184FF8780")]
	public static string ELAHFBKAPEK(KENDMMOAFKD JJFMLKJLKLA, int MFAINABGBEA = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8C80", Offset = "0x4FF7680", VA = "0x184FF8C80", Slot = "20")]
	public OAFCDMOCILF FBOKEHDBMNH(OFFCEFNEKFO GJHJAKLMJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8B70", Offset = "0x4FF7570", VA = "0x184FF8B70")]
	public static KENDMMOAFKD FBOKEHDBMNH(KENDMMOAFKD JJFMLKJLKLA, OFFCEFNEKFO GJHJAKLMJCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface FDIMNMJNCBN
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool DEIEOMADKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool DHCHDNIPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event Action<GKKJANMNCLK> EIJJNLAGCGI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event Action<GKKJANMNCLK> LPOMKFMHEFL;

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(KNKALJALALH PCKMABEFMOP);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterConnectNodes(GHDGELDIJEA GNANPBBENAI, int CMIOPJCNKFM, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterDisconnectNode(GHDGELDIJEA OHGANMPPHGO);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestMasterModifyNode(GHDGELDIJEA MFFCAKEJHFI, GHDGELDIJEA KOHEAHFONMC, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void RequestMasterReparentNodes(GHDGELDIJEA IEBBDBECCID, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void RequestMasterReparentToRoot(GHDGELDIJEA IEBBDBECCID);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void RequestDeserializeConnectableGraph(BKGAHBFKJIL KGLDBIIHBIE, [Optional] GKKJANMNCLK DBOGENDIBMC);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, FDIMNMJNCBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private KNKALJALALH PCKMABEFMOP;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool DEIEOMADKLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x50001E0", Offset = "0x4FFEBE0", VA = "0x1850001E0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool DHCHDNIPFOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x5000240", Offset = "0x4FFEC40", VA = "0x185000240", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<GKKJANMNCLK> EIJJNLAGCGI
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x5000140", Offset = "0x4FFEB40", VA = "0x185000140", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x5000330", Offset = "0x4FFED30", VA = "0x185000330", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<GKKJANMNCLK> LPOMKFMHEFL
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x50000A0", Offset = "0x4FFEAA0", VA = "0x1850000A0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x5000290", Offset = "0x4FFEC90", VA = "0x185000290", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x85EE80", Offset = "0x85D880", VA = "0x18085EE80", Slot = "22")]
		public void SetManager(KNKALJALALH PCKMABEFMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5000070", Offset = "0x4FFEA70", VA = "0x185000070")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x4FFED70", Offset = "0x4FFD770", VA = "0x184FFED70", Slot = "23")]
		public void RequestMasterConnectNodes(GHDGELDIJEA GNANPBBENAI, int CMIOPJCNKFM, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4FFEEA0", Offset = "0x4FFD8A0", VA = "0x184FFEEA0", Slot = "24")]
		public void RequestMasterDisconnectNode(GHDGELDIJEA OHGANMPPHGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4FFEF70", Offset = "0x4FFD970", VA = "0x184FFEF70", Slot = "25")]
		public void RequestMasterModifyNode(GHDGELDIJEA MFFCAKEJHFI, GHDGELDIJEA KOHEAHFONMC, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x4FFF0A0", Offset = "0x4FFDAA0", VA = "0x184FFF0A0", Slot = "26")]
		public void RequestMasterReparentNodes(GHDGELDIJEA IEBBDBECCID, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x4FFF1D0", Offset = "0x4FFDBD0", VA = "0x184FFF1D0", Slot = "27")]
		public void RequestMasterReparentToRoot(GHDGELDIJEA IEBBDBECCID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4FFEC40", Offset = "0x4FFD640", VA = "0x184FFEC40", Slot = "28")]
		public void RequestDeserializeConnectableGraph(BKGAHBFKJIL KGLDBIIHBIE, [Optional] GKKJANMNCLK DBOGENDIBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4FFF5C0", Offset = "0x4FFDFC0", VA = "0x184FFF5C0")]
		[HMIJKEMHEDA]
		private void RpcMasterConnectNodes(GHDGELDIJEA GNANPBBENAI, int CMIOPJCNKFM, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4FFF890", Offset = "0x4FFE290", VA = "0x184FFF890")]
		[HMIJKEMHEDA]
		private void RpcMasterDisconnectNode(GHDGELDIJEA OHGANMPPHGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4FFFBF0", Offset = "0x4FFE5F0", VA = "0x184FFFBF0")]
		[HMIJKEMHEDA]
		private void RpcMasterReparentNodes(GHDGELDIJEA IEBBDBECCID, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4FFF9E0", Offset = "0x4FFE3E0", VA = "0x184FFF9E0")]
		[HMIJKEMHEDA]
		private void RpcMasterModifyNode(GHDGELDIJEA MFFCAKEJHFI, GHDGELDIJEA KOHEAHFONMC, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x4FFF3A0", Offset = "0x4FFDDA0", VA = "0x184FFF3A0")]
		[HMIJKEMHEDA]
		private void RpcConnectNodes(GHDGELDIJEA GNANPBBENAI, int CMIOPJCNKFM, GHDGELDIJEA GDIENNOBGBH, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP, OHCOONFDHPM NEKHLDMAIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4FFF530", Offset = "0x4FFDF30", VA = "0x184FFF530")]
		[HMIJKEMHEDA]
		private void RpcDisconnectNode(GHDGELDIJEA OHGANMPPHGO, OHCOONFDHPM NEKHLDMAIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4FFFF60", Offset = "0x4FFE960", VA = "0x184FFFF60")]
		[HMIJKEMHEDA]
		private void RpcReparentNodes(GHDGELDIJEA IEBBDBECCID, int HGNICIBBFME, GHDGELDIJEA CLJJCFEFLNI, int FCAOCJOLOBL, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP, OHCOONFDHPM NEKHLDMAIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4FFFE90", Offset = "0x4FFE890", VA = "0x184FFFE90")]
		[HMIJKEMHEDA]
		private void RpcModifyNode(GHDGELDIJEA MFFCAKEJHFI, int CMIOPJCNKFM, int GECPIEDBOBI, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP, OHCOONFDHPM NEKHLDMAIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4FFF4F0", Offset = "0x4FFDEF0", VA = "0x184FFF4F0")]
		[HMIJKEMHEDA]
		private void RpcDeserializeConnectableGraph(BKGAHBFKJIL DDLGPJEILKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x74CBF0", Offset = "0x74B5F0", VA = "0x18074CBF0")]
		public LegacyConnectableNetworking()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LHPNJAOCMFF
{
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x25F09B0", Offset = "0x25EF3B0", VA = "0x1825F09B0")]
	public static global::JFOOAFJDLKH<T> IJFONNNPGDM<T>(this MCKMOPCGMKB FOFFAOBPIJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface DJJNDPGFMFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNANCALJAPO();

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMCGMFHIJLB(bool NKJMIDIDBOE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PIIPDJPCCJG : DJJNDPGFMFB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly global::LICJEFKFIDA<bool> FELFGFPIGEP;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x500B3F0", Offset = "0x5009DF0", VA = "0x18500B3F0")]
	public PIIPDJPCCJG(JABEKDEJCAN ABFHDOGCMDC, string KFEMFMGCJPM, bool DJFOKMFDJPD, EPMFFBNFAFE GCFAJBFIOAP, [Optional] Action MLFGBBGKHEO, [Optional] AHPGBCJPEDC KGEEBDDIBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x500B320", Offset = "0x5009D20", VA = "0x18500B320", Slot = "4")]
	public bool DNANCALJAPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x500B390", Offset = "0x5009D90", VA = "0x18500B390", Slot = "5")]
	public void LMCGMFHIJLB(bool NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x500B370", Offset = "0x5009D70", VA = "0x18500B370", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HNJHPLEEHCE
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public const string HBIGMNEAFAM = "The connectable subgraph being deserialized is corrupt.";

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public const string GHJBKKNJPCE = "The connectable subgraph failed to deserialize, even though it passed the corruption check.";
}
namespace RRAssemblyIndex.RecRoom.Connectables.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	internal class _RRAssemblyIndex : ODIDKPKCBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x500B820", Offset = "0x500A220", VA = "0x18500B820", Slot = "6")]
		public sealed override void OAOEINPMJJJ(NBLCNNHCPAE MLFGBBGKHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x500B7C0", Offset = "0x500A1C0", VA = "0x18500B7C0", Slot = "4")]
		public sealed override void HGKEFMKAFGI()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE610", Offset = "0x4FFD010", VA = "0x184FFE610")]
	private static string GKOJACPJHAL(byte[] KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE720", Offset = "0x4FFD120", VA = "0x184FFE720")]
	public static string MEDIDALCMKC(byte[] GHEBPHBJKNK, bool FPEGHFMMINI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
