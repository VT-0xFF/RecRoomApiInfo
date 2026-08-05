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
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB740", Offset = "0x6ADA140", VA = "0x186ADB740", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private HMPAICJIGED bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private HMPAICJIGED bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AE13F0", Offset = "0x6ADFDF0", VA = "0x186AE13F0", Slot = "5")]
		public override void MOJOJHIFMIM(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1280", Offset = "0x6ADFC80", VA = "0x186AE1280")]
		private void ILLMDAGMECA(CIEDHBGLHLN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1760", Offset = "0x6AE0160", VA = "0x186AE1760")]
		private void PBJHOCLLNHH(CIEDHBGLHLN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AE1430", Offset = "0x6ADFE30", VA = "0x186AE1430", Slot = "6")]
		public override void OHBCOLHBNBK(CIEDHBGLHLN registry, [In] NMJMFLJNABF filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AE18D0", Offset = "0x6AE02D0", VA = "0x186AE18D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class OBLKADPINPL : BANLLCMCCKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JCBHKBJGAFH : IEnumerable<ANAFCJBEMPM>, IEnumerable, IEnumerator<ANAFCJBEMPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private ANAFCJBEMPM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private LBMKHNNNCPK localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LBMKHNNNCPK <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OBLKADPINPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private MIKMJLGOEBN <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private ECKJADHBOIC.PEEDAHBDHDM <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private ANAFCJBEMPM System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public JCBHKBJGAFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6AD43C0", Offset = "0x6AD2DC0", VA = "0x186AD43C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3F00", Offset = "0x6AD2900", VA = "0x186AD3F00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3EE0", Offset = "0x6AD28E0", VA = "0x186AD3EE0")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4370", Offset = "0x6AD2D70", VA = "0x186AD4370", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AD42C0", Offset = "0x6AD2CC0", VA = "0x186AD42C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ANAFCJBEMPM> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6AD42C0", Offset = "0x6AD2CC0", VA = "0x186AD42C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KACEJBNGNCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OBLKADPINPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public IFMGLINAGKP nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public KACEJBNGNCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9580", Offset = "0x6AD7F80", VA = "0x186AD9580")]
		internal object NDNPFLEIOBG(IFMGLINAGKP x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DPMGCEOCNFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IFMGLINAGKP child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KACEJBNGNCG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public DPMGCEOCNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0800", Offset = "0x6ACF200", VA = "0x186AD0800")]
		internal object MJCEPLIBEOJ((IFMGLINAGKP child, IFMGLINAGKP nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly CAFGMNLACIN OGEPEHJGLIG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly CAFGMNLACIN AFJNGCGMDBF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly CAFGMNLACIN OFBCCLFPLGJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly CAFGMNLACIN ACFABFNAHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private KHHOHOFHBIL ABMANAKCEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LMKIIMOLCHA CKMLNLJIJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private JFDKBKANKAF CFOGCAPAPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private FJEIHDLKMME HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CGJEBAEAPGL PMCBNJFIAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MIEMBEBKOCM PFGCONMFOJA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x895C80", Offset = "0x894680", VA = "0x180895C80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x895800", Offset = "0x894200", VA = "0x180895800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EHIPNOIODCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<ANAFCJBEMPM, ANAFCJBEMPM> NEMIEDOHDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6ADE670", Offset = "0x6ADD070", VA = "0x186ADE670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF8E0", Offset = "0x6ADE2E0", VA = "0x186ADF8E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<ANAFCJBEMPM, ANAFCJBEMPM> IEAIAKGAEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC710", Offset = "0x6ADB110", VA = "0x186ADC710", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADCA90", Offset = "0x6ADB490", VA = "0x186ADCA90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<ANAFCJBEMPM, ANAFCJBEMPM, ANAFCJBEMPM> MIBKFEGKIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE08E0", Offset = "0x6ADF2E0", VA = "0x186AE08E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF440", Offset = "0x6ADDE40", VA = "0x186ADF440", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0DE0", Offset = "0x6ADF7E0", VA = "0x186AE0DE0")]
	public OBLKADPINPL(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE290", Offset = "0x6ADCC90", VA = "0x186ADE290", Slot = "12")]
	public void HINDDHMAHAN(GameObject BICFCMICGIH, GKOLLCGOJDK KLNJIENDFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD380", Offset = "0x6ADBD80", VA = "0x186ADD380", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0AB0", Offset = "0x6ADF4B0", VA = "0x186AE0AB0", Slot = "22")]
	public bool OKHKBAJHDMI(IFMGLINAGKP EDAMHICEDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0220", Offset = "0x6ADEC20", VA = "0x186AE0220")]
	private void NHEPPEPNJOL(LBMKHNNNCPK GKBMLNGHDNI, LBMKHNNNCPK JBFMCCEDBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDD10", Offset = "0x6ADC710", VA = "0x186ADDD10")]
	private void GNKBJIOBFGN(LBMKHNNNCPK GKBMLNGHDNI, LBMKHNNNCPK JGNBOKAFOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF4F0", Offset = "0x6ADDEF0", VA = "0x186ADF4F0")]
	private void KFLLLAPNCFB(LBMKHNNNCPK GKBMLNGHDNI, LBMKHNNNCPK JGNBOKAFOOH, LBMKHNNNCPK JBFMCCEDBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0420", Offset = "0x6ADEE20", VA = "0x186AE0420")]
	private void NKNMKCHDFKI(LBMKHNNNCPK GKBMLNGHDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "13")]
	public void EOBPLEKHDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD640", Offset = "0x6ADC040", VA = "0x186ADD640", Slot = "14")]
	public void FBIMIMMHNIB(ANAFCJBEMPM EAPGILEBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "15")]
	public void IFGBNDJNHBH(ANAFCJBEMPM EAPGILEBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCC50", Offset = "0x6ADB650", VA = "0x186ADCC50", Slot = "17")]
	public void DJBAHPIHDOH(ANAFCJBEMPM EAPGILEBPPH, ANAFCJBEMPM BGGAGFMAKHF, Vector3 BJDMPNAKILN, Quaternion GPDCENANAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCDB0", Offset = "0x6ADB7B0", VA = "0x186ADCDB0")]
	public void DJBAHPIHDOH(LBMKHNNNCPK PPFEFKBKBLH, LBMKHNNNCPK BGGAGFMAKHF, Vector3 BJDMPNAKILN, Quaternion GPDCENANAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0A20", Offset = "0x6ADF420", VA = "0x186AE0A20")]
	public void OJIEDIAMPFG(ANAFCJBEMPM EAPGILEBPPH, float EOPFFPFBBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE8B0", Offset = "0x6ADD2B0", VA = "0x186ADE8B0", Slot = "18")]
	public void INNMKIIKBFM(ANAFCJBEMPM PDBDGACJCFH, int FONLKCCPEBH, ANAFCJBEMPM OKKEKMOBHON, int DFJCKLBPHEA, Vector3 BJDMPNAKILN, Quaternion GPDCENANAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0830", Offset = "0x6ADF230", VA = "0x186AE0830")]
	private float NNOJFCAONFH(LBMKHNNNCPK PPFEFKBKBLH, LBMKHNNNCPK KMAENCDMJDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE720", Offset = "0x6ADD120", VA = "0x186ADE720")]
	public void INNMKIIKBFM(LBMKHNNNCPK PPFEFKBKBLH, LBMKHNNNCPK KMAENCDMJDN, Vector3 BJDMPNAKILN, Quaternion GPDCENANAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE850", Offset = "0x6ADD250", VA = "0x186ADE850")]
	public void INNMKIIKBFM(LBMKHNNNCPK PPFEFKBKBLH, LBMKHNNNCPK KMAENCDMJDN, Vector3 BJDMPNAKILN, Quaternion GPDCENANAMK, float EOPFFPFBBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6ADE500", Offset = "0x6ADCF00", VA = "0x186ADE500", Slot = "19")]
	public void HPOABEAAIPM(ANAFCJBEMPM EAPGILEBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFF30", Offset = "0x6ADE930", VA = "0x186ADFF30")]
	public bool MAPCFKGDODM(LBMKHNNNCPK GMEDGMJCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD950", Offset = "0x6ADC350", VA = "0x186ADD950", Slot = "16")]
	public void FCAFFBGPMOC(ANAFCJBEMPM EAPGILEBPPH, HashSet<ANAFCJBEMPM> DFPDIOOMMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "20")]
	public GCODPBGGDIB OJMBGFJAKNK(bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "21")]
	public GCODPBGGDIB CJIPIFJKLPE(HashSet<Guid> AAONJNLKCBE, bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFE50", Offset = "0x6ADE850", VA = "0x186ADFE50", Slot = "23")]
	public void LHKOLIEBHAI(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFEC0", Offset = "0x6ADE8C0", VA = "0x186ADFEC0", Slot = "24")]
	public void LLFDDIIINDI(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDB60", Offset = "0x6ADC560", VA = "0x186ADDB60", Slot = "25")]
	public void FHCHLIPDELB(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDF30", Offset = "0x6ADC930", VA = "0x186ADDF30")]
	private void HDIEBLFACKD(LBMKHNNNCPK PPFEFKBKBLH, LBMKHNNNCPK KMAENCDMJDN, Vector3 BJDMPNAKILN, Quaternion GPDCENANAMK, float EOPFFPFBBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCF60", Offset = "0x6ADB960", VA = "0x186ADCF60")]
	private void DOGKDGEEDIM(LBMKHNNNCPK PPFEFKBKBLH, LBMKHNNNCPK AAJANANFHLN, Vector3 BJDMPNAKILN, Quaternion GPDCENANAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCEF0", Offset = "0x6ADB8F0", VA = "0x186ADCEF0")]
	private void DOFFIIENPBN(LBMKHNNNCPK PPFEFKBKBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0990", Offset = "0x6ADF390", VA = "0x186AE0990")]
	[IteratorStateMachine(typeof(JCBHKBJGAFH))]
	public IEnumerable<ANAFCJBEMPM> OFEBNFBJDOE(LBMKHNNNCPK GMEDGMJCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF990", Offset = "0x6ADE390", VA = "0x186ADF990")]
	internal ANAFCJBEMPM LFAKJFGGCHJ(LBMKHNNNCPK GMEDGMJCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6ADD570", Offset = "0x6ADBF70", VA = "0x186ADD570")]
	internal LBMKHNNNCPK EFFCLNDPHJA(ANAFCJBEMPM EAPGILEBPPH)
	{
		return default(LBMKHNNNCPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEB50", Offset = "0x6ADD550", VA = "0x186ADEB50")]
	private bool JLAPFKDIDFF(IFMGLINAGKP EDAMHICEDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AE01C0", Offset = "0x6ADEBC0", VA = "0x186AE01C0")]
	private bool MLLFMLPMOMB(IFMGLINAGKP EDAMHICEDPD, [Out] ANAFCJBEMPM KMAENCDMJDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6ADFAC0", Offset = "0x6ADE4C0", VA = "0x186ADFAC0")]
	private ANAFCJBEMPM LFAKJFGGCHJ(IFMGLINAGKP EDAMHICEDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF750", Offset = "0x6ADE150", VA = "0x186ADF750")]
	private ANAFCJBEMPM KNGNEECHLAH(IFMGLINAGKP EDAMHICEDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF270", Offset = "0x6ADDC70", VA = "0x186ADF270")]
	private ANAFCJBEMPM KBHCMFEDFFO(IFMGLINAGKP EDAMHICEDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6310", Offset = "0x6AD4D10", VA = "0x186AD6310")]
	private static Guid ADDNFAHDAKE(IFMGLINAGKP EDAMHICEDPD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEA00", Offset = "0x6ADD400", VA = "0x186ADEA00")]
	private string JCCOIJNMNOJ(IFMGLINAGKP EDAMHICEDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0B00", Offset = "0x6ADF500", VA = "0x186AE0B00")]
	private void PIFMKIPLDGG(ANAFCJBEMPM PPFEFKBKBLH, ANAFCJBEMPM AAJANANFHLN, RigidTransform GLKOCMNKMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADDB80", Offset = "0x6ADC580", VA = "0x186ADDB80")]
	private void GCKNJHGPLGE(ANAFCJBEMPM AAJANANFHLN, ANAFCJBEMPM PPFEFKBKBLH, RigidTransform GLKOCMNKMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADEAF0", Offset = "0x6ADD4F0", VA = "0x186ADEAF0")]
	private void JFEMIPBIBBN(ANAFCJBEMPM CJNGOIMNLJM, ANAFCJBEMPM PPFEFKBKBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADF0E0", Offset = "0x6ADDAE0", VA = "0x186ADF0E0")]
	private void KBCDJHHLFPK(ANAFCJBEMPM PPFEFKBKBLH, ANAFCJBEMPM KMAENCDMJDN, RigidTransform GLKOCMNKMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6ADCB40", Offset = "0x6ADB540", VA = "0x186ADCB40")]
	private void DGAHBGDANJC(LBMKHNNNCPK GMEDGMJCEEO, ANAFCJBEMPM EAPGILEBPPH, LBMKHNNNCPK JGNBOKAFOOH, LBMKHNNNCPK JBFMCCEDBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC7C0", Offset = "0x6ADB1C0", VA = "0x186ADC7C0")]
	private void CDMBICCODKK(LBMKHNNNCPK GMEDGMJCEEO, ANAFCJBEMPM EAPGILEBPPH, ANAFCJBEMPM FDKHKPBJBCN, ANAFCJBEMPM OBDDDPBKGNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BHDBBPDHIAE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FCPNCKHEKHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public FNNNJBMCDDC container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FCPNCKHEKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0A50", Offset = "0x6ACF450", VA = "0x186AD0A50")]
		internal OBLKADPINPL BDLOLOAGFCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCE90", Offset = "0x6ACB890", VA = "0x186ACCE90")]
	public static void IKJKJBOLHEB(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCE40", Offset = "0x6ACB840", VA = "0x186ACCE40")]
	public static void HBAPOEGMFAE(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JFEKOIGGPNM : ABCOOIBPEBB, OFBIFIPMEMN
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx DGJECMOALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly OBLKADPINPL BOIJOHBFPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly APKILHLBKEF MEJLLLDCMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly LJENIICBHKO HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly OBPBIHCKMHM[] BIIPCPHCBKH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(LBMKHNNNCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ANAFCJBEMPM IBJLMJOAEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD60E0", Offset = "0x6AD4AE0", VA = "0x186AD60E0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ANAFCJBEMPM ICJBFHIDAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4F10", Offset = "0x6AD3910", VA = "0x186AD4F10", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 AFNKGJMHMOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD51D0", Offset = "0x6AD3BD0", VA = "0x186AD51D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion LLPKMEANLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6AD58C0", Offset = "0x6AD42C0", VA = "0x186AD58C0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KMAHBHHDBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5400", Offset = "0x6AD3E00", VA = "0x186AD5400", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<ANAFCJBEMPM> HPLOACJEOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4770", Offset = "0x6AD3170", VA = "0x186AD4770", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool EAKDDGNILPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAAC060", Offset = "0xAAAA60", VA = "0x180AAC060", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC55C90", Offset = "0xC54690", VA = "0x180C55C90", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6AD62F0", Offset = "0x6AD4CF0", VA = "0x186AD62F0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject HIHCJEHCKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x26FBCA0", Offset = "0x26FA6A0", VA = "0x1826FBCA0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6010", Offset = "0x6AD4A10", VA = "0x186AD6010", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid EKGBGKPCEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6140", Offset = "0x6AD4B40", VA = "0x186AD6140", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CDEMFAIILNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6220", Offset = "0x6AD4C20", VA = "0x186AD6220", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HNJCNELKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JPDECKFIMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6AD47A0", Offset = "0x6AD31A0", VA = "0x186AD47A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NOLPCNBCGKN HBDEEBIMMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5E10", Offset = "0x6AD4810", VA = "0x186AD5E10", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5D80", Offset = "0x6AD4780", VA = "0x186AD5D80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NOLPCNBCGKN EILGMBLEPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5860", Offset = "0x6AD4260", VA = "0x186AD5860", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5470", Offset = "0x6AD3E70", VA = "0x186AD5470", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NOLPCNBCGKN KHAMKIPLBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5520", Offset = "0x6AD3F20", VA = "0x186AD5520", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5230", Offset = "0x6AD3C30", VA = "0x186AD5230", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event BMIMEECHLJN OGGGBDEJOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5360", Offset = "0x6AD3D60", VA = "0x186AD5360", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4910", Offset = "0x6AD3310", VA = "0x186AD4910", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5F10", Offset = "0x6AD4910", VA = "0x186AD5F10")]
	public JFEKOIGGPNM(LBMKHNNNCPK NDHGEIKELEB, RigidbodyEx DGJECMOALOE, APKILHLBKEF MEJLLLDCMAB, OBPBIHCKMHM[] BIIPCPHCBKH, LJENIICBHKO HILLMDJLLHN, BANLLCMCCKO BOIJOHBFPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5DE0", Offset = "0x6AD47E0", VA = "0x186AD5DE0", Slot = "19")]
	public void PNBEJFPEDIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "21")]
	public void OAOKKDNEKLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x693E050", Offset = "0x693CA50", VA = "0x18693E050", Slot = "22")]
	public void HAJKMLFBLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6AD54D0", Offset = "0x6AD3ED0", VA = "0x186AD54D0", Slot = "20")]
	public void MIKAPCLAFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4560", Offset = "0x6AD2F60", VA = "0x186AD4560", Slot = "25")]
	public void AAHDIKHHGIF(int EPEPDOGEKHL, ANAFCJBEMPM OKKEKMOBHON, int PGMALMJALAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5290", Offset = "0x6AD3C90", VA = "0x186AD5290", Slot = "26")]
	public void JMABOMLNGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5580", Offset = "0x6AD3F80", VA = "0x186AD5580", Slot = "27")]
	public void MLNKALDLJKK(int EPEPDOGEKHL, ANAFCJBEMPM PDBDGACJCFH, int KBHNACJJNMC, [Optional] Vector3? MMEJLKDLJGC, [Optional] Quaternion? DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD47F0", Offset = "0x6AD31F0", VA = "0x186AD47F0", Slot = "28")]
	public void BJCPPPMMKNG(ANAFCJBEMPM PDBDGACJCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5970", Offset = "0x6AD4370", VA = "0x186AD5970", Slot = "31")]
	public void OKAOAOHPHCB(Vector3 MOKJDPLPGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4C00", Offset = "0x6AD3600", VA = "0x186AD4C00", Slot = "29")]
	public void GOICNCPLBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4A00", Offset = "0x6AD3400", VA = "0x186AD4A00", Slot = "30")]
	public void FMFHAICAMIJ(int ENMILGHAHOM, Vector3 BJFHPDFPFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AD50B0", Offset = "0x6AD3AB0", VA = "0x186AD50B0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int EPEPDOGEKHL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4F80", Offset = "0x6AD3980", VA = "0x186AD4F80", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int EPEPDOGEKHL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x90E920", Offset = "0x90D320", VA = "0x18090E920", Slot = "42")]
	public Color GetConnectionSlotColor(int EPEPDOGEKHL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4870", Offset = "0x6AD3270", VA = "0x186AD4870", Slot = "43")]
	public bool CanConnectTo(int EPEPDOGEKHL, ANAFCJBEMPM DAPLDNKHPGF, int NGDAPIPNHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "44")]
	public void ParentChanged(int EPEPDOGEKHL, ANAFCJBEMPM NHKJCDHOEPO, int DNMAPPDEILI, Vector3 PECCBGFAEGK, Quaternion HCJIJEIHDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "45")]
	public void ChildAdded(int EPEPDOGEKHL, ANAFCJBEMPM PDALLAOAHNN, int DNEKIDHKFKE, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "46")]
	public void ChildRemoved(int EPEPDOGEKHL, ANAFCJBEMPM IPIHBKCNEOF, int FOIBDCODKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "47")]
	public void ConnectionModified(int EPEPDOGEKHL, ANAFCJBEMPM OKKEKMOBHON, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5E70", Offset = "0x6AD4870", VA = "0x186AD5E70", Slot = "48")]
	public void RootChanged(ANAFCJBEMPM EGHCCLBABCP, ANAFCJBEMPM OMDGGBBKJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6AD49B0", Offset = "0x6AD33B0", VA = "0x186AD49B0", Slot = "23")]
	public void EOCPFPPLDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5920", Offset = "0x6AD4320", VA = "0x186AD5920", Slot = "24")]
	public void NFFOJGFLMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5180", Offset = "0x6AD3B80", VA = "0x186AD5180")]
	private void HJFDFHJHIKO(bool CHOKDOLMDMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[HFJNCABCFLK(typeof(BEPELBPKCEE), new string[] { })]
public class PEHDCJLGPJC : BEPELBPKCEE, AGOPHKGBOPE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BPLKKIBBEBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PEHDCJLGPJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ECKJADHBOIC localIds;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BPLKKIBBEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD010", Offset = "0x6ACBA10", VA = "0x186ACD010")]
		internal void MBOJDLILIFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[BHJIGLLAPPG]
	private JPHNOHHLLLL FGHAHIFNFEN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object NIJKIHHKMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AE0E50", Offset = "0x6ADF850", VA = "0x186AE0E50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1040", Offset = "0x6ADFA40", VA = "0x186AE1040", Slot = "6")]
	public void InitReferences(BEMAECNLOEH PFGCONMFOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6AE0EE0", Offset = "0x6ADF8E0", VA = "0x186AE0EE0", Slot = "5")]
	public void IFBDFPHEGDL(ECKJADHBOIC AOFJCLOAGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public PEHDCJLGPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[HFJNCABCFLK(typeof(BANLLCMCCKO), new string[] { "Ignore", "Mock" })]
public class OAHGBMNKPHJ : BANLLCMCCKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EHIPNOIODCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<ANAFCJBEMPM, ANAFCJBEMPM> NEMIEDOHDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC450", Offset = "0x6ADAE50", VA = "0x186ADC450", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC5B0", Offset = "0x6ADAFB0", VA = "0x186ADC5B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<ANAFCJBEMPM, ANAFCJBEMPM> IEAIAKGAEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC2F0", Offset = "0x6ADACF0", VA = "0x186ADC2F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC3A0", Offset = "0x6ADADA0", VA = "0x186ADC3A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<ANAFCJBEMPM, ANAFCJBEMPM, ANAFCJBEMPM> MIBKFEGKIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC660", Offset = "0x6ADB060", VA = "0x186ADC660", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6ADC500", Offset = "0x6ADAF00", VA = "0x186ADC500", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "12")]
	public void HINDDHMAHAN(GameObject BICFCMICGIH, GKOLLCGOJDK KLNJIENDFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "13")]
	public void EOBPLEKHDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "14")]
	public void FBIMIMMHNIB(ANAFCJBEMPM EAPGILEBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "15")]
	public void IFGBNDJNHBH(ANAFCJBEMPM EAPGILEBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "16")]
	public void FCAFFBGPMOC(ANAFCJBEMPM EAPGILEBPPH, HashSet<ANAFCJBEMPM> DFPDIOOMMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "17")]
	public void DJBAHPIHDOH(ANAFCJBEMPM EAPGILEBPPH, ANAFCJBEMPM BGGAGFMAKHF, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "18")]
	public void INNMKIIKBFM(ANAFCJBEMPM EAPGILEBPPH, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "19")]
	public void HPOABEAAIPM(ANAFCJBEMPM EAPGILEBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "20")]
	public GCODPBGGDIB OJMBGFJAKNK(bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240", Slot = "21")]
	public GCODPBGGDIB CJIPIFJKLPE(HashSet<Guid> AAONJNLKCBE, bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "22")]
	public bool OKHKBAJHDMI(IFMGLINAGKP EDAMHICEDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "23")]
	public void LHKOLIEBHAI(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "24")]
	public void LLFDDIIINDI(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "25")]
	public void FHCHLIPDELB(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public OAHGBMNKPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ANAFCJBEMPM : OFBIFIPMEMN, IEquatable<ANAFCJBEMPM>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OFBIFIPMEMN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	ANAFCJBEMPM IBJLMJOAEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject HIHCJEHCKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid EKGBGKPCEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int CDEMFAIILNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	LBMKHNNNCPK AMOIIJBOOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HNJCNELKNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int EPEPDOGEKHL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int EPEPDOGEKHL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int EPEPDOGEKHL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int EPEPDOGEKHL, ANAFCJBEMPM DAPLDNKHPGF, int HCLAFAKKOFH);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int EPEPDOGEKHL, ANAFCJBEMPM NHKJCDHOEPO, int DNMAPPDEILI, Vector3 PECCBGFAEGK, Quaternion HCJIJEIHDFM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int EPEPDOGEKHL, ANAFCJBEMPM PDALLAOAHNN, int DNEKIDHKFKE, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int EPEPDOGEKHL, ANAFCJBEMPM IPIHBKCNEOF, int FOIBDCODKGH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int EPEPDOGEKHL, ANAFCJBEMPM OKKEKMOBHON, int NEJDJIAGMIB, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(ANAFCJBEMPM EGHCCLBABCP, ANAFCJBEMPM OMDGGBBKJBO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BDNMHMNCMLI(DACEBDJEIDP.OMRoom)]
public interface BANLLCMCCKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EHIPNOIODCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<ANAFCJBEMPM, ANAFCJBEMPM> NEMIEDOHDGJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<ANAFCJBEMPM, ANAFCJBEMPM> IEAIAKGAEGE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<ANAFCJBEMPM, ANAFCJBEMPM, ANAFCJBEMPM> MIBKFEGKIJP;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HINDDHMAHAN(GameObject BICFCMICGIH, GKOLLCGOJDK KLNJIENDFGP);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EOBPLEKHDDD();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FBIMIMMHNIB(ANAFCJBEMPM EAPGILEBPPH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IFGBNDJNHBH(ANAFCJBEMPM EAPGILEBPPH);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FCAFFBGPMOC(ANAFCJBEMPM EAPGILEBPPH, HashSet<ANAFCJBEMPM> DFPDIOOMMNO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DJBAHPIHDOH(ANAFCJBEMPM EAPGILEBPPH, ANAFCJBEMPM BGGAGFMAKHF, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void INNMKIIKBFM(ANAFCJBEMPM EAPGILEBPPH, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HPOABEAAIPM(ANAFCJBEMPM EAPGILEBPPH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GCODPBGGDIB OJMBGFJAKNK(bool DKGKCNCANIL);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GCODPBGGDIB CJIPIFJKLPE(HashSet<Guid> AAONJNLKCBE, bool DKGKCNCANIL);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OKHKBAJHDMI(IFMGLINAGKP EDAMHICEDPD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LHKOLIEBHAI(GCODPBGGDIB OAHHBCOOBCN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LLFDDIIINDI(GCODPBGGDIB OAHHBCOOBCN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FHCHLIPDELB(GCODPBGGDIB OAHHBCOOBCN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FJEIHDLKMME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PDOKLFBKPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ANAFCJBEMPM KBHCMFEDFFO(int JEPGELAHFFF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ANAFCJBEMPM KNGNEECHLAH(Guid LEOJMFBGLEK);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GKJGJKDPKPE(ANAFCJBEMPM EAPGILEBPPH);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PCBJPNDLDID();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBJFCIDEGJO(ANAFCJBEMPM MEJLLLDCMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BDNMHMNCMLI(DACEBDJEIDP.Application)]
public interface LJENIICBHKO
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JPDECKFIMNC(APKILHLBKEF MEJLLLDCMAB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CECMAEKGADE(APKILHLBKEF MEJLLLDCMAB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string PBLPAOKMCKA(APKILHLBKEF MEJLLLDCMAB);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ACJNHEJFNHO(APKILHLBKEF MEJLLLDCMAB);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JFDPBIKLLEL(APKILHLBKEF MEJLLLDCMAB);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HDHEIFCABJK(APKILHLBKEF MEJLLLDCMAB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void NOLPCNBCGKN(ANAFCJBEMPM PDBDGACJCFH, int GHOOAOBLBPN, ANAFCJBEMPM OKKEKMOBHON, int CFLMOCEOFNA, [Optional] Vector3? MMEJLKDLJGC, [Optional] Quaternion? DPHBADBHKCD);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void BMIMEECHLJN(ANAFCJBEMPM EGHCCLBABCP, ANAFCJBEMPM OMDGGBBKJBO);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface APKILHLBKEF : ANAFCJBEMPM, OFBIFIPMEMN, IEquatable<ANAFCJBEMPM>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ABCOOIBPEBB : OFBIFIPMEMN
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	ANAFCJBEMPM ICJBFHIDAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<ANAFCJBEMPM> HPLOACJEOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 AFNKGJMHMOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion LLPKMEANLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool KMAHBHHDBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool EAKDDGNILPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event NOLPCNBCGKN HBDEEBIMMOA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event NOLPCNBCGKN EILGMBLEPCE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NOLPCNBCGKN KHAMKIPLBOJ;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event BMIMEECHLJN OGGGBDEJOIJ;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PNBEJFPEDIJ();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MIKAPCLAFCB();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OAOKKDNEKLJ();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HAJKMLFBLOJ();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EOCPFPPLDOO();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NFFOJGFLMID();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AAHDIKHHGIF(int EPEPDOGEKHL, ANAFCJBEMPM OKKEKMOBHON, int PGMALMJALAM);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JMABOMLNGOE();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MLNKALDLJKK(int EPEPDOGEKHL, ANAFCJBEMPM PDBDGACJCFH, int KBHNACJJNMC, [Optional] Vector3? MMEJLKDLJGC, [Optional] Quaternion? DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BJCPPPMMKNG(ANAFCJBEMPM PDBDGACJCFH);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void GOICNCPLBIA();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FMFHAICAMIJ(int ENMILGHAHOM, Vector3 BJFHPDFPFFI);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OKAOAOHPHCB(Vector3 MOKJDPLPGOK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OBPBIHCKMHM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 KNAOKANFNPM
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
public interface GKOLLCGOJDK
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DLGIANFAKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HCINOOHAIPF NGOOABPKDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, GKOLLCGOJDK
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
			[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public HCINOOHAIPF LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0680", Offset = "0x6ACF080", VA = "0x186AD0680")]
		public static ConnectableConfigData JEPGCJOBLFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0740", Offset = "0x6ACF140", VA = "0x186AD0740")]
		public ConnectableConfigData(LegacyConnectableLinkVisual DPMLBGDHHIA, bool GKGHAOAMKEP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MMCGCCKLPLG : IEquatable<MMCGCCKLPLG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public ANAFCJBEMPM EAPGILEBPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int LDENBEFJCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int NEJDJIAGMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 MMEJLKDLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion DPHBADBHKCD;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBE70", Offset = "0x6ADA870", VA = "0x186ADBE70")]
	public MMCGCCKLPLG(ANAFCJBEMPM EAPGILEBPPH, int LDENBEFJCEC, int NEJDJIAGMIB, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBDD0", Offset = "0x6ADA7D0", VA = "0x186ADBDD0")]
	public MMCGCCKLPLG(ANAFCJBEMPM EAPGILEBPPH, int LDENBEFJCEC, int NEJDJIAGMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBD50", Offset = "0x6ADA750", VA = "0x186ADBD50")]
	public MMCGCCKLPLG(ANAFCJBEMPM EAPGILEBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB8E0", Offset = "0x6ADA2E0", VA = "0x186ADB8E0", Slot = "4")]
	public bool Equals(MMCGCCKLPLG CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6ADB990", Offset = "0x6ADA390", VA = "0x186ADB990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class IFOKKIDNBAH : CHOLLCHAKHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform ICGEMCDDICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private HCINOOHAIPF LLBCJLLCNOC;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x65D1690", Offset = "0x65D0090", VA = "0x1865D1690", Slot = "4")]
	public void HINDDHMAHAN(Transform ICGEMCDDICC, HCINOOHAIPF LLBCJLLCNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6AD39D0", Offset = "0x6AD23D0", VA = "0x186AD39D0", Slot = "5")]
	public HCINOOHAIPF LHFBNKDGPMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3AA0", Offset = "0x6AD24A0", VA = "0x186AD3AA0", Slot = "6")]
	public void NAJBMOLMBFI(HCINOOHAIPF COPJFDFPHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public IFOKKIDNBAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class CKIIDOFAHAO : IDisposable, CCFJLHHCHGN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AJLBJJPIGDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ANAFCJBEMPM oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public ANAFCJBEMPM newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AJLBJJPIGDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCD80", Offset = "0x6ACB780", VA = "0x186ACCD80")]
		internal bool CMGMHPJIPEE(KBKBPMOKDAP node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly JOMPPLOBNDM LAKDJAJHPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private DFEJMDACIIA DODDDJOJOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NDJONLMIOMO EOBABJGIHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool GKGHAOAMKEP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly CAFGMNLACIN LCCFBCKAHEF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KBKBPMOKDAP CHMOOKFGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0090", Offset = "0x6ACEA90", VA = "0x186AD0090")]
	public bool NMKOJAHOHJH([In] JCCNFGABIED LNCKNHNHHDF, bool EDOHFKHPPOJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEC80", Offset = "0x6ACD680", VA = "0x186ACEC80")]
	private bool JCCGKKGHABN([In] JCCNFGABIED LNCKNHNHHDF, bool EDOHFKHPPOJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD04B0", Offset = "0x6ACEEB0", VA = "0x186AD04B0")]
	public CKIIDOFAHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEBD0", Offset = "0x6ACD5D0", VA = "0x186ACEBD0", Slot = "5")]
	public void HINDDHMAHAN(BANLLCMCCKO PEDEFMGDCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD8B0", Offset = "0x6ACC2B0", VA = "0x186ACD8B0", Slot = "17")]
	public void DOGCKPHBIDF(AMLJECGKMMD AGMLFHLAIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDA10", Offset = "0x6ACC410", VA = "0x186ACDA10", Slot = "12")]
	public void EJGOMLCEGEL(Func<ANAFCJBEMPM, bool> NPMAPCJPDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD8E0", Offset = "0x6ACC2E0", VA = "0x186ACD8E0")]
	private void EJGOMLCEGEL(JOMPPLOBNDM AOOGCKADIHP, Func<ANAFCJBEMPM, bool> NPMAPCJPDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD100", Offset = "0x6ACBB00", VA = "0x186ACD100", Slot = "11")]
	public void AIDLDNNNBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF240", Offset = "0x6ACDC40", VA = "0x186ACF240", Slot = "8")]
	public bool JELIAHCGPOE(ANAFCJBEMPM LDOBHCCHIAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE0F0", Offset = "0x6ACCAF0", VA = "0x186ACE0F0")]
	private bool FMHGOPLJJKB(ANAFCJBEMPM JOMCJMGOEND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE040", Offset = "0x6ACCA40", VA = "0x186ACE040")]
	private static bool FGBOAINENEH(ANAFCJBEMPM JOMCJMGOEND, JOMPPLOBNDM EDJDEGDGBCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD360", Offset = "0x6ACBD60", VA = "0x186ACD360")]
	private void BNDNKEELNCI(Transform MMEKFBPICON, JOMPPLOBNDM JGMMLIKMNFM, JOMPPLOBNDM[] MGEMCDDEDHF, ANAFCJBEMPM MMGPHIONBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFCE0", Offset = "0x6ACE6E0", VA = "0x186ACFCE0")]
	private MMCGCCKLPLG MOEEJDGCFCI(Transform DKEKEHEKCOH, MMCGCCKLPLG MGOLFEMIHMH)
	{
		return default(MMCGCCKLPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFB20", Offset = "0x6ACE520", VA = "0x186ACFB20")]
	private static bool MGHAKGHFIIK(JOMPPLOBNDM EDJDEGDGBCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE920", Offset = "0x6ACD320", VA = "0x186ACE920", Slot = "9")]
	public bool GDGCNGLPINP(ANAFCJBEMPM NIAOJIPBPMM, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE980", Offset = "0x6ACD380", VA = "0x186ACE980")]
	private bool HIMPPABHOMP(ANAFCJBEMPM NIAOJIPBPMM, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFE30", Offset = "0x6ACE830", VA = "0x186ACFE30")]
	private static void NDAIEGGBGPM(ANAFCJBEMPM NIAOJIPBPMM, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD, JOMPPLOBNDM PJCOBKHFBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0170", Offset = "0x6ACEB70", VA = "0x186AD0170")]
	private void PIFMKIPLDGG(ANAFCJBEMPM NENLJCMOBML, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0020", Offset = "0x6ACEA20", VA = "0x186AD0020")]
	private void NLOCLGEMKLO(JOMPPLOBNDM AOOGCKADIHP, ANAFCJBEMPM FDKHKPBJBCN, ANAFCJBEMPM OBDDDPBKGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFFB0", Offset = "0x6ACE9B0", VA = "0x186ACFFB0")]
	private void NLOCLGEMKLO(ANAFCJBEMPM EAPGILEBPPH, ANAFCJBEMPM FDKHKPBJBCN, ANAFCJBEMPM OBDDDPBKGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD740", Offset = "0x6ACC140", VA = "0x186ACD740")]
	private void CDMBICCODKK(ANAFCJBEMPM EAPGILEBPPH, ANAFCJBEMPM FDKHKPBJBCN, ANAFCJBEMPM OBDDDPBKGNK, bool EJOPFPJDLAK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD7B0", Offset = "0x6ACC1B0", VA = "0x186ACD7B0")]
	private void CDMBICCODKK(JOMPPLOBNDM BAFHJDFHJHD, ANAFCJBEMPM MMGPHIONBOP, ANAFCJBEMPM OMDGGBBKJBO, bool EJOPFPJDLAK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE800", Offset = "0x6ACD200", VA = "0x186ACE800")]
	private void GCKNJHGPLGE(ANAFCJBEMPM PPFEFKBKBLH, int KBHNACJJNMC, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF250", Offset = "0x6ACDC50", VA = "0x186ACF250")]
	private void JFEMIPBIBBN(KBKBPMOKDAP KMAENCDMJDN, KBKBPMOKDAP PEDIAOBNEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0290", Offset = "0x6ACEC90", VA = "0x186AD0290", Slot = "18")]
	public ANAFCJBEMPM PIIMICONPBM(ANAFCJBEMPM EAPGILEBPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDC60", Offset = "0x6ACC660", VA = "0x186ACDC60", Slot = "13")]
	public void FCAFFBGPMOC(ANAFCJBEMPM EAPGILEBPPH, HashSet<ANAFCJBEMPM> NMJDJGLCKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD120", Offset = "0x6ACBB20", VA = "0x186ACD120", Slot = "14")]
	public List<ANAFCJBEMPM> BHCJIHIKAPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6AD00A0", Offset = "0x6ACEAA0", VA = "0x186AD00A0")]
	protected KBKBPMOKDAP PEIBONDBFGK(KBKBPMOKDAP AOOGCKADIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFA20", Offset = "0x6ACE420", VA = "0x186ACFA20")]
	protected JOMPPLOBNDM[] KLCOOOJILDO(JOMPPLOBNDM EDJDEGDGBCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDA20", Offset = "0x6ACC420", VA = "0x186ACDA20")]
	protected bool EKNOLBNLDFF(ANAFCJBEMPM EAPGILEBPPH, [Out] JOMPPLOBNDM AOOGCKADIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6ACDB30", Offset = "0x6ACC530", VA = "0x186ACDB30", Slot = "15")]
	public bool EPPENPOJOBH(ANAFCJBEMPM EAPGILEBPPH, [Out] MMCGCCKLPLG NKICAFLOBJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE000", Offset = "0x6ACCA00", VA = "0x186ACE000")]
	protected JOMPPLOBNDM FEEPKDALONF(MMCGCCKLPLG MICJGFCCLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFAC0", Offset = "0x6ACE4C0", VA = "0x186ACFAC0", Slot = "10")]
	public bool LNAPDLBKFNK(ANAFCJBEMPM NENLJCMOBML, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF480", Offset = "0x6ACDE80", VA = "0x186ACF480")]
	private bool KDIEDHIGOKO(ANAFCJBEMPM NENLJCMOBML, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF3B0", Offset = "0x6ACDDB0", VA = "0x186ACF3B0")]
	private static bool JKEAFKNCEIH(JOMPPLOBNDM GAKHPMFMENE, MMCGCCKLPLG BGAAFFKKNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0090", Offset = "0x6ACEA90", VA = "0x186AD0090", Slot = "7")]
	private bool PBEKPJNJOMO([In] JCCNFGABIED LNCKNHNHHDF, bool EDOHFKHPPOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class ICFHBHJLFJM : BANLLCMCCKO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly FNNNJBMCDDC NKDOKEFKKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly NDJONLMIOMO EOBABJGIHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly IGNHFHMDCGH BCFJNOMCOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly JGDIIEAINPB JOKPOCPPLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly CCFJLHHCHGN OAHHBCOOBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal KPCLHENHFFF HILLMDJLLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal DEAIKONHNFD NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal DFEJMDACIIA AOIPCJLJHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool GKGHAOAMKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool EIDHMFOJIIN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool AKHKBPPLFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB6A1C0", Offset = "0xB68BC0", VA = "0x180B6A1C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8BF0", Offset = "0x1CA75F0", VA = "0x181CA8BF0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xB6A1B0", Offset = "0xB68BB0", VA = "0x180B6A1B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8BE0", Offset = "0x1CA75E0", VA = "0x181CA8BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool EHIPNOIODCA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<ANAFCJBEMPM, ANAFCJBEMPM> NEMIEDOHDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2900", Offset = "0x6AD1300", VA = "0x186AD2900", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2C50", Offset = "0x6AD1650", VA = "0x186AD2C50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<ANAFCJBEMPM, ANAFCJBEMPM> IEAIAKGAEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6AD18F0", Offset = "0x6AD02F0", VA = "0x186AD18F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1C50", Offset = "0x6AD0650", VA = "0x186AD1C50", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ANAFCJBEMPM, ANAFCJBEMPM, ANAFCJBEMPM> MIBKFEGKIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3220", Offset = "0x6AD1C20", VA = "0x186AD3220", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2B60", Offset = "0x6AD1560", VA = "0x186AD2B60", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD35E0", Offset = "0x6AD1FE0", VA = "0x186AD35E0")]
	public ICFHBHJLFJM(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2170", Offset = "0x6AD0B70", VA = "0x186AD2170", Slot = "12")]
	public void HINDDHMAHAN(GameObject BICFCMICGIH, GKOLLCGOJDK KLNJIENDFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1EC0", Offset = "0x6AD08C0", VA = "0x186AD1EC0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1F60", Offset = "0x6AD0960", VA = "0x186AD1F60", Slot = "13")]
	public void EOBPLEKHDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1FB0", Offset = "0x6AD09B0", VA = "0x186AD1FB0", Slot = "14")]
	public void FBIMIMMHNIB(ANAFCJBEMPM EAPGILEBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2110", Offset = "0x6AD0B10", VA = "0x186AD2110", Slot = "15")]
	public void IFGBNDJNHBH(ANAFCJBEMPM EAPGILEBPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3460", Offset = "0x6AD1E60", VA = "0x186AD3460", Slot = "22")]
	public bool OKHKBAJHDMI(IFMGLINAGKP EDAMHICEDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2AA0", Offset = "0x6AD14A0", VA = "0x186AD2AA0")]
	internal bool JCCGKKGHABN([In] JCCNFGABIED LNCKNHNHHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2BC0", Offset = "0x6AD15C0", VA = "0x186AD2BC0")]
	internal bool KDIEDHIGOKO([In] JCCNFGABIED LNCKNHNHHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3280", Offset = "0x6AD1C80", VA = "0x186AD3280")]
	internal bool OJKJILPFJMK([In] JCCNFGABIED LNCKNHNHHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1950", Offset = "0x6AD0350", VA = "0x186AD1950")]
	internal bool BDOBJJCCKKG([In] JCCNFGABIED LNCKNHNHHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2DF0", Offset = "0x6AD17F0", VA = "0x186AD2DF0")]
	internal void LMDOBKGEGOL(ANAFCJBEMPM EAPGILEBPPH, int NKOKNNPLCPF, bool EDOHFKHPPOJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2110", Offset = "0x6AD0B10", VA = "0x186AD2110")]
	internal bool GBOMNNCLODL(ANAFCJBEMPM IPKEOAMPPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD34B0", Offset = "0x6AD1EB0", VA = "0x186AD34B0")]
	internal bool PMMKLKNPJNO(ANAFCJBEMPM NIAOJIPBPMM, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1FD0", Offset = "0x6AD09D0", VA = "0x186AD1FD0", Slot = "16")]
	public void FCAFFBGPMOC(ANAFCJBEMPM EAPGILEBPPH, HashSet<ANAFCJBEMPM> DFPDIOOMMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1CB0", Offset = "0x6AD06B0", VA = "0x186AD1CB0", Slot = "17")]
	public void DJBAHPIHDOH(ANAFCJBEMPM NIAOJIPBPMM, ANAFCJBEMPM BGGAGFMAKHF, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2960", Offset = "0x6AD1360", VA = "0x186AD2960", Slot = "18")]
	public void INNMKIIKBFM(ANAFCJBEMPM NENLJCMOBML, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2730", Offset = "0x6AD1130", VA = "0x186AD2730", Slot = "19")]
	public void HPOABEAAIPM(ANAFCJBEMPM NENLJCMOBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2FD0", Offset = "0x6AD19D0", VA = "0x186AD2FD0")]
	public void NOGKIONGACM([Optional] HACHNCKJHJE EKMEAMOGKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2CB0", Offset = "0x6AD16B0", VA = "0x186AD2CB0", Slot = "23")]
	public void LHKOLIEBHAI(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6AD32E0", Offset = "0x6AD1CE0", VA = "0x186AD32E0", Slot = "20")]
	public GCODPBGGDIB OJMBGFJAKNK(bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1AA0", Offset = "0x6AD04A0", VA = "0x186AD1AA0", Slot = "21")]
	public GCODPBGGDIB CJIPIFJKLPE(HashSet<Guid> AAONJNLKCBE, bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6AD20D0", Offset = "0x6AD0AD0", VA = "0x186AD20D0", Slot = "25")]
	public void FHCHLIPDELB(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2D40", Offset = "0x6AD1740", VA = "0x186AD2D40", Slot = "24")]
	public void LLFDDIIINDI(GCODPBGGDIB OAHHBCOOBCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class NDJONLMIOMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly LNJIOIKIJCK<ANAFCJBEMPM, ANAFCJBEMPM> NEMIEDOHDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly LNJIOIKIJCK<ANAFCJBEMPM, ANAFCJBEMPM> IEAIAKGAEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly FIGHDDEIJIF<ANAFCJBEMPM, ANAFCJBEMPM, ANAFCJBEMPM> MIBKFEGKIJP;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6ADC010", Offset = "0x6ADAA10", VA = "0x186ADC010")]
	public NDJONLMIOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public void HINDDHMAHAN(ICFHBHJLFJM PEDEFMGDCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBED0", Offset = "0x6ADA8D0", VA = "0x186ADBED0")]
	public void ELOJAAENDCF(ANAFCJBEMPM KMAENCDMJDN, ANAFCJBEMPM PPFEFKBKBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBF30", Offset = "0x6ADA930", VA = "0x186ADBF30")]
	public void JEAEBOHFNHM(ANAFCJBEMPM KMAENCDMJDN, ANAFCJBEMPM PPFEFKBKBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6ADBF90", Offset = "0x6ADA990", VA = "0x186ADBF90")]
	public void PPICEBCCIBE(ANAFCJBEMPM CJNGOIMNLJM, ANAFCJBEMPM AAJANANFHLN, ANAFCJBEMPM PPFEFKBKBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class IGNHFHMDCGH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private ICFHBHJLFJM PEDEFMGDCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private DEAIKONHNFD NHPIKOHJFBH;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public IGNHFHMDCGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3D20", Offset = "0x6AD2720", VA = "0x186AD3D20")]
	public void HINDDHMAHAN(ICFHBHJLFJM PEDEFMGDCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3D10", Offset = "0x6AD2710", VA = "0x186AD3D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3EC0", Offset = "0x6AD28C0", VA = "0x186AD3EC0")]
	private void LINGLPCFJHI(HACHNCKJHJE DBKPGAEGHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3E50", Offset = "0x6AD2850", VA = "0x186AD3E50")]
	private void JCIMDLCBPHB(HACHNCKJHJE DLOOADGNGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3C10", Offset = "0x6AD2610", VA = "0x186AD3C10")]
	public void BGMLBGDBHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3B10", Offset = "0x6AD2510", VA = "0x186AD3B10")]
	public void AKLDBBDNILJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LHCKGFDPNGA
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DOIEPAFIAEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FNNNJBMCDDC container;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public DOIEPAFIAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0790", Offset = "0x6ACF190", VA = "0x186AD0790")]
		internal ICFHBHJLFJM BDLOLOAGFCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9670", Offset = "0x6AD8070", VA = "0x186AD9670")]
	public static void IKJKJBOLHEB(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6AD95F0", Offset = "0x6AD7FF0", VA = "0x186AD95F0")]
	public static void HBAPOEGMFAE(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class HMDHOHNJAEF : IDisposable, DFEJMDACIIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, HCINOOHAIPF> BCCHDDHEFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly AMLJECGKMMD MEMPBHLFOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private CHOLLCHAKHK GPDFNLNLNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private CCFJLHHCHGN OAHHBCOOBCN;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1810", Offset = "0x6AD0210", VA = "0x186AD1810")]
	public HMDHOHNJAEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6AD13A0", Offset = "0x6ACFDA0", VA = "0x186AD13A0", Slot = "7")]
	public void HINDDHMAHAN(CCFJLHHCHGN OAHHBCOOBCN, CHOLLCHAKHK GPDFNLNLNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0F90", Offset = "0x6ACF990", VA = "0x186AD0F90", Slot = "5")]
	public void FFMIAPBKILI(KBKBPMOKDAP PPMLJPGIGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1230", Offset = "0x6ACFC30", VA = "0x186AD1230", Slot = "9")]
	public void FNPGLBCCHGK(KBKBPMOKDAP PFEHAECMBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1590", Offset = "0x6ACFF90", VA = "0x186AD1590", Slot = "8")]
	public void MONAJLOJKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0C40", Offset = "0x6ACF640", VA = "0x186AD0C40", Slot = "10")]
	public void DILLDLNCDIH(KBKBPMOKDAP MDNLLGNCPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1750", Offset = "0x6AD0150", VA = "0x186AD1750", Slot = "11")]
	public void NEDOMIHCLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6AD13E0", Offset = "0x6ACFDE0", VA = "0x186AD13E0")]
	private bool KKHNLDABFLK(KBKBPMOKDAP JCHGHJIDPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class JGDIIEAINPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct AGDEJIMMLMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly JOMPPLOBNDM EOFINPDEHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> AAONJNLKCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly IFMGLINAGKP EGKHNDMEGJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly IFMGLINAGKP DKPKGCLMCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool DKGKCNCANIL;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool NDBEINELPKK
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6ACCBF0", Offset = "0x6ACB5F0", VA = "0x186ACCBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCD10", Offset = "0x6ACB710", VA = "0x186ACCD10")]
		public AGDEJIMMLMI(JOMPPLOBNDM EOFINPDEHFA, HashSet<Guid> AAONJNLKCBE, bool DKGKCNCANIL, [Optional] IFMGLINAGKP EGKHNDMEGJD, [Optional] IFMGLINAGKP DKPKGCLMCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC660", Offset = "0x6ACB060", VA = "0x186ACC660")]
		public IFMGLINAGKP BBLOJHGNHMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCB30", Offset = "0x6ACB530", VA = "0x186ACCB30")]
		private IFMGLINAGKP PCNPGLHCKEP([Out] IFMGLINAGKP ADNAFJJDPEA, [Out] IFMGLINAGKP ECBMIENDODK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC440", Offset = "0x6ACAE40", VA = "0x186ACC440")]
		private IFMGLINAGKP AHMFHAIGFPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC800", Offset = "0x6ACB200", VA = "0x186ACC800")]
		private void NPIFAHBBGLC(IFMGLINAGKP LKCGPBEEAJP, IFMGLINAGKP KADIOEOAAGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC970", Offset = "0x6ACB370", VA = "0x186ACC970")]
		private void OGODFDOHPIB(IFMGLINAGKP ADNAFJJDPEA, IFMGLINAGKP ECBMIENDODK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private ICFHBHJLFJM PEDEFMGDCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private CCFJLHHCHGN OAHHBCOOBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private DFEJMDACIIA DODDDJOJOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private DEAIKONHNFD NHPIKOHJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool FFJKNEMPEGJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool BPLAFNEIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7D00", Offset = "0x6AD6700", VA = "0x186AD7D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool AKHKBPPLFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7ED0", Offset = "0x6AD68D0", VA = "0x186AD7ED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8990", Offset = "0x6AD7390", VA = "0x186AD8990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6EA0", Offset = "0x6AD58A0", VA = "0x186AD6EA0")]
	public void HINDDHMAHAN(ICFHBHJLFJM PEDEFMGDCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8590", Offset = "0x6AD6F90", VA = "0x186AD8590")]
	public GCODPBGGDIB OJMBGFJAKNK(bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6600", Offset = "0x6AD5000", VA = "0x186AD6600")]
	public GCODPBGGDIB CJIPIFJKLPE(HashSet<Guid> AAONJNLKCBE, bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8240", Offset = "0x6AD6C40", VA = "0x186AD8240")]
	public void LHKOLIEBHAI(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6AD82D0", Offset = "0x6AD6CD0", VA = "0x186AD82D0")]
	public void LLFDDIIINDI(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8560", Offset = "0x6AD6F60", VA = "0x186AD8560")]
	public void NJIJEDJKLGJ(GCODPBGGDIB OAHHBCOOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8370", Offset = "0x6AD6D70", VA = "0x186AD8370")]
	private void NJHBGEDIMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7480", Offset = "0x6AD5E80", VA = "0x186AD7480")]
	private IFMGLINAGKP JHAJKBINHJN(JOMPPLOBNDM AOOGCKADIHP, bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6B40", Offset = "0x6AD5540", VA = "0x186AD6B40")]
	private static void FJLLPDOGLFK(JOMPPLOBNDM AOOGCKADIHP, bool DKGKCNCANIL, IFMGLINAGKP EDAMHICEDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6920", Offset = "0x6AD5320", VA = "0x186AD6920")]
	private void FBOLLIJPDGC(JOMPPLOBNDM AOOGCKADIHP, bool DKGKCNCANIL, IFMGLINAGKP EDAMHICEDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6F10", Offset = "0x6AD5910", VA = "0x186AD6F10")]
	private IFMGLINAGKP HLKOKHBLHKP(JOMPPLOBNDM EOFINPDEHFA, HashSet<Guid> AAONJNLKCBE, bool DKGKCNCANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6350", Offset = "0x6AD4D50", VA = "0x186AD6350")]
	private bool CBBGJKDCPAB(GCODPBGGDIB NAIKIBCDGKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6AD76A0", Offset = "0x6AD60A0", VA = "0x186AD76A0")]
	private bool JLAPFKDIDFF(IFMGLINAGKP EDAMHICEDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6AD65E0", Offset = "0x6AD4FE0", VA = "0x186AD65E0")]
	private bool CEBBKMNFIOF(GCODPBGGDIB OAHHBCOOBCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6D90", Offset = "0x6AD5790", VA = "0x186AD6D90")]
	private static bool GJNIMLEGKNL(IFMGLINAGKP EDAMHICEDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8700", Offset = "0x6AD7100", VA = "0x186AD8700")]
	public static bool OKHKBAJHDMI(IFMGLINAGKP EDAMHICEDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7EF0", Offset = "0x6AD68F0", VA = "0x186AD7EF0")]
	private ANAFCJBEMPM LFAKJFGGCHJ(IFMGLINAGKP EDAMHICEDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7D50", Offset = "0x6AD6750", VA = "0x186AD7D50")]
	private ANAFCJBEMPM KBHCMFEDFFO(IFMGLINAGKP EDAMHICEDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6FA0", Offset = "0x6AD59A0", VA = "0x186AD6FA0")]
	private ANAFCJBEMPM HOHDOFIAPIE(IFMGLINAGKP EDAMHICEDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6310", Offset = "0x6AD4D10", VA = "0x186AD6310")]
	private static Guid ADDNFAHDAKE(IFMGLINAGKP EDAMHICEDPD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7130", Offset = "0x6AD5B30", VA = "0x186AD7130")]
	private string JCCOIJNMNOJ(IFMGLINAGKP EDAMHICEDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD67A0", Offset = "0x6AD51A0", VA = "0x186AD67A0")]
	private bool EAJAAFNEDDP(JOMPPLOBNDM AOOGCKADIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7220", Offset = "0x6AD5C20", VA = "0x186AD7220")]
	private static void JEEHMJMDMCP(JOMPPLOBNDM EOFINPDEHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public JGDIIEAINPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct JCCNFGABIED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public ANAFCJBEMPM PPFEFKBKBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public ANAFCJBEMPM KMAENCDMJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int KBHNACJJNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int PGMALMJALAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 MMEJLKDLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion DPHBADBHKCD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MMCGCCKLPLG ACPMNLABKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4420", Offset = "0x6AD2E20", VA = "0x186AD4420")]
		get
		{
			return default(MMCGCCKLPLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MMCGCCKLPLG ILKOFLBJNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6AD44C0", Offset = "0x6AD2EC0", VA = "0x186AD44C0")]
		get
		{
			return default(MMCGCCKLPLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6AD44F0", Offset = "0x6AD2EF0", VA = "0x186AD44F0")]
	public JCCNFGABIED(ANAFCJBEMPM PPFEFKBKBLH, ANAFCJBEMPM KMAENCDMJDN, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface CCFJLHHCHGN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KBKBPMOKDAP CHMOOKFGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HINDDHMAHAN(BANLLCMCCKO PEDEFMGDCEP);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NMKOJAHOHJH([In] JCCNFGABIED LNCKNHNHHDF, bool EDOHFKHPPOJ = true);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JELIAHCGPOE(ANAFCJBEMPM LDOBHCCHIAH);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GDGCNGLPINP(ANAFCJBEMPM NIAOJIPBPMM, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LNAPDLBKFNK(ANAFCJBEMPM NENLJCMOBML, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AIDLDNNNBND();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJGOMLCEGEL(Func<ANAFCJBEMPM, bool> NPMAPCJPDMK);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FCAFFBGPMOC(ANAFCJBEMPM EAPGILEBPPH, HashSet<ANAFCJBEMPM> NMJDJGLCKDK);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<ANAFCJBEMPM> BHCJIHIKAPN();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EPPENPOJOBH(ANAFCJBEMPM EAPGILEBPPH, [Out] MMCGCCKLPLG NKICAFLOBJI);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DOGCKPHBIDF(AMLJECGKMMD AGMLFHLAIFJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool AMLJECGKMMD(KBKBPMOKDAP AOOGCKADIHP);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KBKBPMOKDAP
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ANAFCJBEMPM EEJDMJBJDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KBKBPMOKDAP JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MMCGCCKLPLG COIOGDKOGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool JNGFEPOILEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HCINOOHAIPF : JLMLKHOKJDL.MMJAGBJACKB
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDNFIJHBNDG(ANAFCJBEMPM OKKEKMOBHON, MMCGCCKLPLG PPFEFKBKBLH);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICEFCCFDHIH(ANAFCJBEMPM OKKEKMOBHON, MMCGCCKLPLG PPFEFKBKBLH);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOMFDAKJOJK(ANAFCJBEMPM OKKEKMOBHON, MMCGCCKLPLG PPFEFKBKBLH);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PINJIIEJEHD(ANAFCJBEMPM OKKEKMOBHON, MMCGCCKLPLG PPFEFKBKBLH);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HCINOOHAIPF Instantiate(Transform ICGEMCDDICC);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MOGENANDEFO();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CHOLLCHAKHK
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HINDDHMAHAN(Transform ICGEMCDDICC, HCINOOHAIPF LLBCJLLCNOC);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HCINOOHAIPF LHFBNKDGPMD();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAJBMOLMBFI(HCINOOHAIPF COPJFDFPHGB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface KPCLHENHFFF : FJEIHDLKMME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MPGGCBELLKD(Guid HEMEIDBLMMF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DFEJMDACIIA
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFMIAPBKILI(KBKBPMOKDAP PPMLJPGIGAN);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HINDDHMAHAN(CCFJLHHCHGN OAHHBCOOBCN, CHOLLCHAKHK PNMHJHEKBAJ);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MONAJLOJKMD();

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNPGLBCCHGK(KBKBPMOKDAP PFEHAECMBNL);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DILLDLNCDIH(KBKBPMOKDAP MDNLLGNCPCO);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NEDOMIHCLBI();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class JOMPPLOBNDM : KBKBPMOKDAP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HIPNHCAIFOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public MMCGCCKLPLG nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public JOMPPLOBNDM foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HIPNHCAIFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0B00", Offset = "0x6ACF500", VA = "0x186AD0B00")]
		internal bool PHCDPBMOOPH(KBKBPMOKDAP x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private MMCGCCKLPLG NKICAFLOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<JOMPPLOBNDM> EGPJBHPFBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private JOMPPLOBNDM IKMMDEAPPIF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MMCGCCKLPLG COIOGDKOGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D790", Offset = "0x3A9C190", VA = "0x183A9D790", Slot = "6")]
		get
		{
			return default(MMCGCCKLPLG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9270", Offset = "0x6AD7C70", VA = "0x186AD9270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private JOMPPLOBNDM KMAENCDMJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x883D50", Offset = "0x882750", VA = "0x180883D50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8A20", Offset = "0x6AD7420", VA = "0x186AD8A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KBKBPMOKDAP JEBILDNGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x883D50", Offset = "0x882750", VA = "0x180883D50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ANAFCJBEMPM EEJDMJBJDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JNGFEPOILEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD92A0", Offset = "0x6AD7CA0", VA = "0x186AD92A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GJOEPDMEKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8C80", Offset = "0x6AD7680", VA = "0x186AD8C80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected JOMPPLOBNDM BAFHJDFHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD94B0", Offset = "0x6AD7EB0", VA = "0x186AD94B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD94D0", Offset = "0x6AD7ED0", VA = "0x186AD94D0")]
	public JOMPPLOBNDM(MMCGCCKLPLG HAPFDKJAEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E40", Offset = "0x6AD7840", VA = "0x186AD8E40")]
	public JOMPPLOBNDM EBLGBIHLLBM(MMCGCCKLPLG FLMNELPOILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8B00", Offset = "0x6AD7500", VA = "0x186AD8B00")]
	public JOMPPLOBNDM CIHPCNCMPCM(MMCGCCKLPLG IJOBJNDOICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9090", Offset = "0x6AD7A90", VA = "0x186AD9090")]
	public JOMPPLOBNDM GDFNAHCIADO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9360", Offset = "0x6AD7D60", VA = "0x186AD9360")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AD92B0", Offset = "0x6AD7CB0", VA = "0x186AD92B0")]
	public JOMPPLOBNDM MCNIANJMFLJ(MMCGCCKLPLG AAJANANFHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8CD0", Offset = "0x6AD76D0", VA = "0x186AD8CD0")]
	private static void DOGCKPHBIDF(JOMPPLOBNDM CAJBDEENKJA, AMLJECGKMMD OBCNEKMKFFE, bool FDIHFEBPOFC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E30", Offset = "0x6AD7830", VA = "0x186AD8E30", Slot = "9")]
	public void DOGCKPHBIDF(AMLJECGKMMD AGMLFHLAIFJ, bool EJOPFPJDLAK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8F90", Offset = "0x6AD7990", VA = "0x186AD8F90")]
	public static JOMPPLOBNDM FEEPKDALONF(JOMPPLOBNDM CAJBDEENKJA, MMCGCCKLPLG OAHGONEEBBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface DEAIKONHNFD
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool BPLAFNEIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool PDOKLFBKPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<HACHNCKJHJE> LINGLPCFJHI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<HACHNCKJHJE> JCIMDLCBPHB;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(ICFHBHJLFJM PEDEFMGDCEP);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(ANAFCJBEMPM NIAOJIPBPMM, ANAFCJBEMPM BGGAGFMAKHF, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(ANAFCJBEMPM NENLJCMOBML, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(GCODPBGGDIB FKLJIMOILPI, [Optional] HACHNCKJHJE EKMEAMOGKDK);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, DEAIKONHNFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private ICFHBHJLFJM PEDEFMGDCEP;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool BPLAFNEIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB560", Offset = "0x6AD9F60", VA = "0x186ADB560", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool PDOKLFBKPDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB5C0", Offset = "0x6AD9FC0", VA = "0x186ADB5C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<HACHNCKJHJE> LINGLPCFJHI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB4C0", Offset = "0x6AD9EC0", VA = "0x186ADB4C0", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB6A0", Offset = "0x6ADA0A0", VA = "0x186ADB6A0", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<HACHNCKJHJE> JCIMDLCBPHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB420", Offset = "0x6AD9E20", VA = "0x186ADB420", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB600", Offset = "0x6ADA000", VA = "0x186ADB600", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x88B260", Offset = "0x889C60", VA = "0x18088B260", Slot = "19")]
		public void SetManager(ICFHBHJLFJM PEDEFMGDCEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB3F0", Offset = "0x6AD9DF0", VA = "0x186ADB3F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA170", Offset = "0x6AD8B70", VA = "0x186ADA170", Slot = "23")]
		public void RequestMasterConnectNodes(ANAFCJBEMPM PDBDGACJCFH, int KBHNACJJNMC, ANAFCJBEMPM OKKEKMOBHON, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA2A0", Offset = "0x6AD8CA0", VA = "0x186ADA2A0", Slot = "24")]
		public void RequestMasterDisconnectNode(ANAFCJBEMPM LDOBHCCHIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA360", Offset = "0x6AD8D60", VA = "0x186ADA360", Slot = "20")]
		public void RequestMasterModifyNode(ANAFCJBEMPM NIAOJIPBPMM, ANAFCJBEMPM BGGAGFMAKHF, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA490", Offset = "0x6AD8E90", VA = "0x186ADA490", Slot = "21")]
		public void RequestMasterReparentNodes(ANAFCJBEMPM NENLJCMOBML, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA5C0", Offset = "0x6AD8FC0", VA = "0x186ADA5C0", Slot = "25")]
		public void RequestMasterReparentToRoot(ANAFCJBEMPM NENLJCMOBML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA040", Offset = "0x6AD8A40", VA = "0x186ADA040", Slot = "22")]
		public void RequestDeserializeConnectableGraph(GCODPBGGDIB FKLJIMOILPI, [Optional] HACHNCKJHJE EKMEAMOGKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA9A0", Offset = "0x6AD93A0", VA = "0x186ADA9A0")]
		[GDKPGHEHMNH]
		private void RpcMasterConnectNodes(ANAFCJBEMPM PDBDGACJCFH, int KBHNACJJNMC, ANAFCJBEMPM OKKEKMOBHON, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAC60", Offset = "0x6AD9660", VA = "0x186ADAC60")]
		[GDKPGHEHMNH]
		private void RpcMasterDisconnectNode(ANAFCJBEMPM LDOBHCCHIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6ADAFA0", Offset = "0x6AD99A0", VA = "0x186ADAFA0")]
		[GDKPGHEHMNH]
		private void RpcMasterReparentNodes(ANAFCJBEMPM NENLJCMOBML, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6ADADA0", Offset = "0x6AD97A0", VA = "0x186ADADA0")]
		[GDKPGHEHMNH]
		private void RpcMasterModifyNode(ANAFCJBEMPM NIAOJIPBPMM, ANAFCJBEMPM BGGAGFMAKHF, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA790", Offset = "0x6AD9190", VA = "0x186ADA790")]
		[GDKPGHEHMNH]
		private void RpcConnectNodes(ANAFCJBEMPM PDBDGACJCFH, int KBHNACJJNMC, ANAFCJBEMPM OKKEKMOBHON, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD, NPIDBLENNEJ JGMHFFNPLAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA910", Offset = "0x6AD9310", VA = "0x186ADA910")]
		[GDKPGHEHMNH]
		private void RpcDisconnectNode(ANAFCJBEMPM LDOBHCCHIAH, NPIDBLENNEJ JGMHFFNPLAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB2F0", Offset = "0x6AD9CF0", VA = "0x186ADB2F0")]
		[GDKPGHEHMNH]
		private void RpcReparentNodes(ANAFCJBEMPM NENLJCMOBML, int KEMPLHDKGCK, ANAFCJBEMPM AAJANANFHLN, int DNMAPPDEILI, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD, NPIDBLENNEJ JGMHFFNPLAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6ADB230", Offset = "0x6AD9C30", VA = "0x186ADB230")]
		[GDKPGHEHMNH]
		private void RpcModifyNode(ANAFCJBEMPM NIAOJIPBPMM, int KBHNACJJNMC, int PGMALMJALAM, Vector3 MMEJLKDLJGC, Quaternion DPHBADBHKCD, NPIDBLENNEJ JGMHFFNPLAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6ADA8D0", Offset = "0x6AD92D0", VA = "0x186ADA8D0")]
		[GDKPGHEHMNH]
		private void RpcDeserializeConnectableGraph(GCODPBGGDIB OAHHBCOOBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A0AF0", Offset = "0x89F4F0", VA = "0x1808A0AF0")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, HCINOOHAIPF, JLMLKHOKJDL.MMJAGBJACKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9DF0", Offset = "0x6AD87F0", VA = "0x186AD9DF0", Slot = "4")]
		private void KMDIOPLHNGA(ANAFCJBEMPM OKKEKMOBHON, MMCGCCKLPLG PPFEFKBKBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9870", Offset = "0x6AD8270", VA = "0x186AD9870", Slot = "5")]
		private void BOODICOPIOI(ANAFCJBEMPM OKKEKMOBHON, MMCGCCKLPLG PPFEFKBKBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9CD0", Offset = "0x6AD86D0", VA = "0x186AD9CD0", Slot = "6")]
		private void INADLNPOPCI(ANAFCJBEMPM OKKEKMOBHON, MMCGCCKLPLG PPFEFKBKBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9AE0", Offset = "0x6AD84E0", VA = "0x186AD9AE0", Slot = "7")]
		private void DPOBMJOCCHF(ANAFCJBEMPM OKKEKMOBHON, MMCGCCKLPLG PPFEFKBKBLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9F70", Offset = "0x6AD8970", VA = "0x186AD9F70", Slot = "8")]
		private HCINOOHAIPF LLKOCAKBJNM(Transform ICGEMCDDICC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9FE0", Offset = "0x6AD89E0", VA = "0x186AD9FE0", Slot = "9")]
		private void NOOCCKPIHBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BHAILEJNCFH
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF860", Offset = "0x2AEE260", VA = "0x182AEF860")]
	public static MMINIEHKMAC<T> KDJIGEACHJM<T>(this FNNNJBMCDDC NKDOKEFKKDI)
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
