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
	public class LogRegistrationIndex : KGHKLAJDNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x616C030", Offset = "0x616AE30", VA = "0x18616C030", Slot = "4")]
		public override void GEBEKKCKBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
	public class _AssemblyIndex : FIMMIOHCHJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private HLCBOADGLMF bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private HLCBOADGLMF bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6172730", Offset = "0x6171530", VA = "0x186172730", Slot = "5")]
		public override void JMDPNECFGBJ(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61725C0", Offset = "0x61713C0", VA = "0x1861725C0")]
		private void ALEDFJENALM(GHFIOEGMBOH registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6172770", Offset = "0x6171570", VA = "0x186172770")]
		private void LKBHJBHIBHK(GHFIOEGMBOH registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6172290", Offset = "0x6171090", VA = "0x186172290", Slot = "6")]
		public override void ADBCMJOMFPM(GHFIOEGMBOH registry, [In] FJBHLFEMEAA filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "8")]
		public override void PMLABOBIDNF(KLINEBNHAFG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61728E0", Offset = "0x61716E0", VA = "0x1861728E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class DFEMHMCCJJE : IKEOOLGKIAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class PONFBCINGIA : IEnumerable<DELBFJHOJJB>, IEnumerable, IEnumerator<DELBFJHOJJB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private DELBFJHOJJB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private FHFOHBBENOG localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FHFOHBBENOG <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DFEMHMCCJJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IJAILEKGBDM <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GBACJLHJCCJ.KCMAAGBOPOK <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DELBFJHOJJB System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801910", VA = "0x180802B10")]
		[DebuggerHidden]
		public PONFBCINGIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x61721A0", Offset = "0x6170FA0", VA = "0x1861721A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6171CE0", Offset = "0x6170AE0", VA = "0x186171CE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6171CC0", Offset = "0x6170AC0", VA = "0x186171CC0")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6172150", Offset = "0x6170F50", VA = "0x186172150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x61720A0", Offset = "0x6170EA0", VA = "0x1861720A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DELBFJHOJJB> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61720A0", Offset = "0x6170EA0", VA = "0x1861720A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly JNOMMELLEMA MMDEJINABBO;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly JNOMMELLEMA LABFALODOGD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly JNOMMELLEMA EIKKJJGBCBK;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly JNOMMELLEMA JDOPFGJAMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private KDIBOGJLGOE FJNINNFKFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ILBBHPFHOEM HIGIEDDKDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private OKLKBDPNBKA EJONAFFFCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MJNAGLCCMGI EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private IGPNBFNOFLL AKGKLNLFINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IJALPBALGJA KIBPNKGEGJI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BOHPGLCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C1540", Offset = "0x7C0340", VA = "0x1807C1540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FA0", Offset = "0x7BFDA0", VA = "0x1807C0FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IOINHHKHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<DELBFJHOJJB, DELBFJHOJJB> IMBNFAEBJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6161410", Offset = "0x6160210", VA = "0x186161410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6161DF0", Offset = "0x6160BF0", VA = "0x186161DF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<DELBFJHOJJB, DELBFJHOJJB> NADPMCGCFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61614C0", Offset = "0x61602C0", VA = "0x1861614C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61616C0", Offset = "0x61604C0", VA = "0x1861616C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<DELBFJHOJJB, DELBFJHOJJB, DELBFJHOJJB> LKFHNDJGDDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6163070", Offset = "0x6161E70", VA = "0x186163070", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6161CD0", Offset = "0x6160AD0", VA = "0x186161CD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61658B0", Offset = "0x61646B0", VA = "0x1861658B0")]
	public DFEMHMCCJJE(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6163120", Offset = "0x6161F20", VA = "0x186163120", Slot = "12")]
	public void HBPIHILNAPB(GameObject EBIGFKEAJMH, IGEDHNEHMBB PBJIGEHKEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6161AE0", Offset = "0x61608E0", VA = "0x186161AE0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x615D840", Offset = "0x615C640", VA = "0x18615D840", Slot = "22")]
	public bool CGLCBGHNEMP(JMACJEMCHHE OKABCGPFCBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6165140", Offset = "0x6163F40", VA = "0x186165140")]
	private void PHPJNPDLIDM(FHFOHBBENOG HAKBLMAKELC, FHFOHBBENOG PNNEHHPPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6164B30", Offset = "0x6163930", VA = "0x186164B30")]
	private void ODLDPBNBMML(FHFOHBBENOG HAKBLMAKELC, FHFOHBBENOG MJDBPLLJJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6164D50", Offset = "0x6163B50", VA = "0x186164D50")]
	private void OFDONINJMFA(FHFOHBBENOG HAKBLMAKELC, FHFOHBBENOG MJDBPLLJJFK, FHFOHBBENOG PNNEHHPPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6164200", Offset = "0x6163000", VA = "0x186164200")]
	private void NFJJBPMIPKK(FHFOHBBENOG HAKBLMAKELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "13")]
	public void PHAFDIODDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61629E0", Offset = "0x61617E0", VA = "0x1861629E0", Slot = "14")]
	public void GEBEKKCKBFI(DELBFJHOJJB IEBAGHJDDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "15")]
	public void CMPPHHJCDAF(DELBFJHOJJB IEBAGHJDDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61618B0", Offset = "0x61606B0", VA = "0x1861618B0", Slot = "17")]
	public void DFEHKFHCNNP(DELBFJHOJJB IEBAGHJDDMO, DELBFJHOJJB EEOCHNLFFKP, Vector3 ONAIBAMIBJL, Quaternion LCPHIJKNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6161770", Offset = "0x6160570", VA = "0x186161770")]
	public void DFEHKFHCNNP(FHFOHBBENOG APEMCPNHEOP, FHFOHBBENOG EEOCHNLFFKP, Vector3 ONAIBAMIBJL, Quaternion LCPHIJKNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6163390", Offset = "0x6162190", VA = "0x186163390")]
	public void HDKPFBLEFMD(DELBFJHOJJB IEBAGHJDDMO, float NDBJANJICJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6162CE0", Offset = "0x6161AE0", VA = "0x186162CE0", Slot = "18")]
	public void GENHBIHHIAD(DELBFJHOJJB OLEHPFDHMDP, int HONLFPACPNF, DELBFJHOJJB JBOOGDNKKAI, int GKFFIIPLGJM, Vector3 ONAIBAMIBJL, Quaternion LCPHIJKNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6162FC0", Offset = "0x6161DC0", VA = "0x186162FC0")]
	private float GEPAJAAEAKH(FHFOHBBENOG APEMCPNHEOP, FHFOHBBENOG OGCHMLDLLMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6162E30", Offset = "0x6161C30", VA = "0x186162E30")]
	public void GENHBIHHIAD(FHFOHBBENOG APEMCPNHEOP, FHFOHBBENOG OGCHMLDLLMJ, Vector3 ONAIBAMIBJL, Quaternion LCPHIJKNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6162F60", Offset = "0x6161D60", VA = "0x186162F60")]
	public void GENHBIHHIAD(FHFOHBBENOG APEMCPNHEOP, FHFOHBBENOG OGCHMLDLLMJ, Vector3 ONAIBAMIBJL, Quaternion LCPHIJKNEAJ, float NDBJANJICJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6163720", Offset = "0x6162520", VA = "0x186163720", Slot = "19")]
	public void IKGHILPFJCF(DELBFJHOJJB IEBAGHJDDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6161EA0", Offset = "0x6160CA0", VA = "0x186161EA0")]
	public bool FEKJLGMOJBA(FHFOHBBENOG BLCHDPHIDBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61638B0", Offset = "0x61626B0", VA = "0x1861638B0", Slot = "16")]
	public void JONGJDNKMPN(DELBFJHOJJB IEBAGHJDDMO, HashSet<DELBFJHOJJB> DGNKMJPAFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "20")]
	public NBCBBHAHPNB LMLNAAGEPMO(bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "21")]
	public NBCBBHAHPNB OEMPPEADJFK(HashSet<Guid> BJGDCGIEEIA, bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6161210", Offset = "0x6160010", VA = "0x186161210", Slot = "23")]
	public void BCMIALKICKL(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6161D80", Offset = "0x6160B80", VA = "0x186161D80", Slot = "24")]
	public void EHALLGEOMKI(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6163890", Offset = "0x6162690", VA = "0x186163890", Slot = "25")]
	public void IKMNBNIEJOD(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6163C20", Offset = "0x6162A20", VA = "0x186163C20")]
	private void LKMDAJLLCGI(FHFOHBBENOG APEMCPNHEOP, FHFOHBBENOG OGCHMLDLLMJ, Vector3 ONAIBAMIBJL, Quaternion LCPHIJKNEAJ, float NDBJANJICJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6165350", Offset = "0x6164150", VA = "0x186165350")]
	private void PIEOKIAKBJH(FHFOHBBENOG APEMCPNHEOP, FHFOHBBENOG OIJEBDLJMMH, Vector3 ONAIBAMIBJL, Quaternion LCPHIJKNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6164000", Offset = "0x6162E00", VA = "0x186164000")]
	private void MNLJMOKPLMC(FHFOHBBENOG APEMCPNHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6163F70", Offset = "0x6162D70", VA = "0x186163F70")]
	[IteratorStateMachine(typeof(PONFBCINGIA))]
	public IEnumerable<DELBFJHOJJB> LNNMNOLONJD(FHFOHBBENOG BLCHDPHIDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61649C0", Offset = "0x61637C0", VA = "0x1861649C0")]
	internal DELBFJHOJJB NKFOIGCPBDL(FHFOHBBENOG BLCHDPHIDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6161A10", Offset = "0x6160810", VA = "0x186161A10")]
	internal FHFOHBBENOG DKOCBIPDHCN(DELBFJHOJJB IEBAGHJDDMO)
	{
		return default(FHFOHBBENOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6162130", Offset = "0x6160F30", VA = "0x186162130")]
	private bool GBGAFLDOLGI(JMACJEMCHHE OKABCGPFCBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6163AB0", Offset = "0x61628B0", VA = "0x186163AB0")]
	private bool KAIHGHKDKOE(JMACJEMCHHE OKABCGPFCBI, [Out] DELBFJHOJJB OGCHMLDLLMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6164680", Offset = "0x6163480", VA = "0x186164680")]
	private DELBFJHOJJB NKFOIGCPBDL(JMACJEMCHHE OKABCGPFCBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6163420", Offset = "0x6162220", VA = "0x186163420")]
	private DELBFJHOJJB HFHLHENDLNH(JMACJEMCHHE OKABCGPFCBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61635A0", Offset = "0x61623A0", VA = "0x1861635A0")]
	private DELBFJHOJJB HJDMDFLAGEP(JMACJEMCHHE OKABCGPFCBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6164AF0", Offset = "0x61638F0", VA = "0x186164AF0")]
	private static Guid NMLIFKLOFNH(JMACJEMCHHE OKABCGPFCBI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61615D0", Offset = "0x61603D0", VA = "0x1861615D0")]
	private string CKEHOCOCOIL(JMACJEMCHHE OKABCGPFCBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6164070", Offset = "0x6162E70", VA = "0x186164070")]
	private void MOPEOLFFBEC(DELBFJHOJJB APEMCPNHEOP, DELBFJHOJJB OIJEBDLJMMH, RigidTransform IPDNDKBJMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6161280", Offset = "0x6160080", VA = "0x186161280")]
	private void BIDDFGJIDOL(DELBFJHOJJB OIJEBDLJMMH, DELBFJHOJJB APEMCPNHEOP, RigidTransform IPDNDKBJMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6161570", Offset = "0x6160370", VA = "0x186161570")]
	private void CIOCJGLGPDK(DELBFJHOJJB EBMEJPEOJDM, DELBFJHOJJB APEMCPNHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6164FB0", Offset = "0x6163DB0", VA = "0x186164FB0")]
	private void OGALOGJCFFN(DELBFJHOJJB APEMCPNHEOP, DELBFJHOJJB OGCHMLDLLMJ, RigidTransform IPDNDKBJMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6163B10", Offset = "0x6162910", VA = "0x186163B10")]
	private void KLJNNMBPDEE(FHFOHBBENOG BLCHDPHIDBL, DELBFJHOJJB IEBAGHJDDMO, FHFOHBBENOG MJDBPLLJJFK, FHFOHBBENOG PNNEHHPPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6162710", Offset = "0x6161510", VA = "0x186162710")]
	private void GDIONJGFJEN(FHFOHBBENOG BLCHDPHIDBL, DELBFJHOJJB IEBAGHJDDMO, DELBFJHOJJB ENCPGPBNBAI, DELBFJHOJJB MLCHFHHFNBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DIDGMAMNCPF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CBEOGGGNAMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NAINNGGFMLM container;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CBEOGGGNAMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x615FEE0", Offset = "0x615ECE0", VA = "0x18615FEE0")]
		internal DFEMHMCCJJE PCJIMBCOEOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6165970", Offset = "0x6164770", VA = "0x186165970")]
	public static void PLGHMNAIHII(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6165920", Offset = "0x6164720", VA = "0x186165920")]
	public static void AOKDCIMHMOB(NAINNGGFMLM COEPBABOGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AAEABOIOJAL : CDMAAIFIAND, HFACOBBIGNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx LELBNINIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly DFEMHMCCJJE KFNCKDHGGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly DGLMPOADHGN AGPCABFLNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly BKLKDLHMCOB EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ADPHGALIJCM[] KFFAFIPEBLD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(FHFOHBBENOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DELBFJHOJJB GGPFBCDAFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x615D4D0", Offset = "0x615C2D0", VA = "0x18615D4D0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DELBFJHOJJB ODMBIAPCAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x615BDB0", Offset = "0x615ABB0", VA = "0x18615BDB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 HPDGMIACLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x615BF30", Offset = "0x615AD30", VA = "0x18615BF30", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion DHOLADKEHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x615BA50", Offset = "0x615A850", VA = "0x18615BA50", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GLCOHLEHKPM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x615D280", Offset = "0x615C080", VA = "0x18615D280", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<DELBFJHOJJB> NNOEDHJLHPI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x615C3D0", Offset = "0x615B1D0", VA = "0x18615C3D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool ILICALCHJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x879BE0", Offset = "0x8789E0", VA = "0x180879BE0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x879D00", Offset = "0x878B00", VA = "0x180879D00", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x615D6D0", Offset = "0x615C4D0", VA = "0x18615D6D0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject DBBMAMINFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x23710C0", Offset = "0x236FEC0", VA = "0x1823710C0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x615D410", Offset = "0x615C210", VA = "0x18615D410", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid DLLOLELJLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x615D530", Offset = "0x615C330", VA = "0x18615D530", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EMEMAFOMJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x615D610", Offset = "0x615C410", VA = "0x18615D610", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FBLBFOGPAHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool NMNNANFJJLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x615C400", Offset = "0x615B200", VA = "0x18615C400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event LEJAGPOLNCF HAFLKOOJKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x615C450", Offset = "0x615B250", VA = "0x18615C450", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x615BAB0", Offset = "0x615A8B0", VA = "0x18615BAB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LEJAGPOLNCF EMIDIKPHFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x615BED0", Offset = "0x615ACD0", VA = "0x18615BED0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x615B9F0", Offset = "0x615A7F0", VA = "0x18615B9F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LEJAGPOLNCF MEGHDIDNHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x615BE20", Offset = "0x615AC20", VA = "0x18615BE20", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x615BB10", Offset = "0x615A910", VA = "0x18615BB10", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event MANADMPINNI GDHFMOPOGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x615C910", Offset = "0x615B710", VA = "0x18615C910", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x615BD10", Offset = "0x615AB10", VA = "0x18615BD10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x615D310", Offset = "0x615C110", VA = "0x18615D310")]
	public AAEABOIOJAL(FHFOHBBENOG ACOAKBIHAJJ, RigidbodyEx LELBNINIFLI, DGLMPOADHGN AGPCABFLNCA, ADPHGALIJCM[] KFFAFIPEBLD, BKLKDLHMCOB EEEILKJFPBG, IKEOOLGKIAJ KFNCKDHGGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x615BCE0", Offset = "0x615AAE0", VA = "0x18615BCE0", Slot = "19")]
	public void DOFCKMODMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "21")]
	public void PNICEJOHIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5FDC430", Offset = "0x5FDB230", VA = "0x185FDC430", Slot = "22")]
	public void FEOMAKPODFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x615BE80", Offset = "0x615AC80", VA = "0x18615BE80", Slot = "20")]
	public void FIAKOELMJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x615C9B0", Offset = "0x615B7B0", VA = "0x18615C9B0", Slot = "25")]
	public void MPDOJMKCEDK(int DLGPHLDHJHI, DELBFJHOJJB JBOOGDNKKAI, int HEOKGAEOFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x615CEA0", Offset = "0x615BCA0", VA = "0x18615CEA0", Slot = "26")]
	public void NMEMAEBDEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x615CBC0", Offset = "0x615B9C0", VA = "0x18615CBC0", Slot = "27")]
	public void NIGOEOHDGIP(int DLGPHLDHJHI, DELBFJHOJJB OLEHPFDHMDP, int ALCAFGCLEFG, [Optional] Vector3? NBPJAFLLKIM, [Optional] Quaternion? PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x615BC60", Offset = "0x615AA60", VA = "0x18615BC60", Slot = "28")]
	public void DGCFCIHMNHE(DELBFJHOJJB OLEHPFDHMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x615C4B0", Offset = "0x615B2B0", VA = "0x18615C4B0", Slot = "31")]
	public void JOAIGHILOCJ(Vector3 NJKGJKNGMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x615CF70", Offset = "0x615BD70", VA = "0x18615CF70", Slot = "29")]
	public void PFLONJDEGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x615C1E0", Offset = "0x615AFE0", VA = "0x18615C1E0", Slot = "30")]
	public void ICKPNDDDPOP(int AELAKOMEEDP, Vector3 KNKOADKCJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x615C110", Offset = "0x615AF10", VA = "0x18615C110", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int DLGPHLDHJHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x615BFE0", Offset = "0x615ADE0", VA = "0x18615BFE0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int DLGPHLDHJHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x837FE0", Offset = "0x836DE0", VA = "0x180837FE0", Slot = "42")]
	public Color GetConnectionSlotColor(int DLGPHLDHJHI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x615BBC0", Offset = "0x615A9C0", VA = "0x18615BBC0", Slot = "43")]
	public bool CanConnectTo(int DLGPHLDHJHI, DELBFJHOJJB LEBKIMCODEP, int DEEDILOHBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "44")]
	public void ParentChanged(int DLGPHLDHJHI, DELBFJHOJJB FMMJIKNKMGP, int LLJBHKOOAPK, Vector3 MPBBFPMJMFP, Quaternion MHJDOOOFCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "45")]
	public void ChildAdded(int DLGPHLDHJHI, DELBFJHOJJB ICEMKAGNMKB, int ODCKJPFGLGO, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "46")]
	public void ChildRemoved(int DLGPHLDHJHI, DELBFJHOJJB IFNBDGHEDIK, int FALBMDKDENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "47")]
	public void ConnectionModified(int DLGPHLDHJHI, DELBFJHOJJB JBOOGDNKKAI, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x615D2F0", Offset = "0x615C0F0", VA = "0x18615D2F0", Slot = "48")]
	public void RootChanged(DELBFJHOJJB MDJIEMMMACP, DELBFJHOJJB KPGCPMGHCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x615BB70", Offset = "0x615A970", VA = "0x18615BB70", Slot = "23")]
	public void CPNEMJOGNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x615BF90", Offset = "0x615AD90", VA = "0x18615BF90", Slot = "24")]
	public void GHHEFHHPKLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x615C8C0", Offset = "0x615B6C0", VA = "0x18615C8C0")]
	private void LEBIBKCNDNA(bool MLJDKANODCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[PDIJHEJCBNI(typeof(ACKGLFMOCPM), new string[] { })]
public class APMOMNLMDBN : ACKGLFMOCPM, IAJFKKACDGA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JOKCOHMHADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public APMOMNLMDBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public GBACJLHJCCJ localIds;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JOKCOHMHADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6169360", Offset = "0x6168160", VA = "0x186169360")]
		internal void MKIDJFNNBDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[HPEIMHAPHIP]
	private EABGOGJDIGO LIIJCGABFAI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object CPCLGFGOGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x615F620", Offset = "0x615E420", VA = "0x18615F620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x615F820", Offset = "0x615E620", VA = "0x18615F820", Slot = "6")]
	public void InitReferences(JMJKBBCBMJB KIBPNKGEGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x615F6B0", Offset = "0x615E4B0", VA = "0x18615F6B0", Slot = "5")]
	public void ICMIEAPBCFF(GBACJLHJCCJ FOHMKIEPADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public APMOMNLMDBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PDIJHEJCBNI(typeof(IKEOOLGKIAJ), new string[] { "Ignore", "Mock" })]
public class GPLCHBHMKFJ : IKEOOLGKIAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BOHPGLCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IOINHHKHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<DELBFJHOJJB, DELBFJHOJJB> IMBNFAEBJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6168F40", Offset = "0x6167D40", VA = "0x186168F40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6169200", Offset = "0x6168000", VA = "0x186169200", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<DELBFJHOJJB, DELBFJHOJJB> NADPMCGCFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6168FF0", Offset = "0x6167DF0", VA = "0x186168FF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61690A0", Offset = "0x6167EA0", VA = "0x1861690A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<DELBFJHOJJB, DELBFJHOJJB, DELBFJHOJJB> LKFHNDJGDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x61692B0", Offset = "0x61680B0", VA = "0x1861692B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6169150", Offset = "0x6167F50", VA = "0x186169150", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "12")]
	public void HBPIHILNAPB(GameObject EBIGFKEAJMH, IGEDHNEHMBB PBJIGEHKEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "13")]
	public void PHAFDIODDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "14")]
	public void GEBEKKCKBFI(DELBFJHOJJB IEBAGHJDDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "15")]
	public void CMPPHHJCDAF(DELBFJHOJJB IEBAGHJDDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "16")]
	public void JONGJDNKMPN(DELBFJHOJJB IEBAGHJDDMO, HashSet<DELBFJHOJJB> DGNKMJPAFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "17")]
	public void DFEHKFHCNNP(DELBFJHOJJB IEBAGHJDDMO, DELBFJHOJJB EEOCHNLFFKP, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "18")]
	public void GENHBIHHIAD(DELBFJHOJJB IEBAGHJDDMO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "19")]
	public void IKGHILPFJCF(DELBFJHOJJB IEBAGHJDDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "20")]
	public NBCBBHAHPNB LMLNAAGEPMO(bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "21")]
	public NBCBBHAHPNB OEMPPEADJFK(HashSet<Guid> BJGDCGIEEIA, bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "22")]
	public bool CGLCBGHNEMP(JMACJEMCHHE OKABCGPFCBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "23")]
	public void BCMIALKICKL(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "24")]
	public void EHALLGEOMKI(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "25")]
	public void IKMNBNIEJOD(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GPLCHBHMKFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DELBFJHOJJB : HFACOBBIGNL, IEquatable<DELBFJHOJJB>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HFACOBBIGNL
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DELBFJHOJJB GGPFBCDAFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject DBBMAMINFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid DLLOLELJLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int EMEMAFOMJJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FHFOHBBENOG AINIEIDJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FBLBFOGPAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int DLGPHLDHJHI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int DLGPHLDHJHI);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int DLGPHLDHJHI);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int DLGPHLDHJHI, DELBFJHOJJB LEBKIMCODEP, int MIPHBIMNJCI);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int DLGPHLDHJHI, DELBFJHOJJB FMMJIKNKMGP, int LLJBHKOOAPK, Vector3 MPBBFPMJMFP, Quaternion MHJDOOOFCIA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int DLGPHLDHJHI, DELBFJHOJJB ICEMKAGNMKB, int ODCKJPFGLGO, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int DLGPHLDHJHI, DELBFJHOJJB IFNBDGHEDIK, int FALBMDKDENC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int DLGPHLDHJHI, DELBFJHOJJB JBOOGDNKKAI, int NNOCEANAFHO, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(DELBFJHOJJB MDJIEMMMACP, DELBFJHOJJB KPGCPMGHCML);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[NHEMKOLBJOI(MCNCDDPANDH.OMRoom)]
public interface IKEOOLGKIAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BOHPGLCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IOINHHKHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<DELBFJHOJJB, DELBFJHOJJB> IMBNFAEBJNP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<DELBFJHOJJB, DELBFJHOJJB> NADPMCGCFOA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<DELBFJHOJJB, DELBFJHOJJB, DELBFJHOJJB> LKFHNDJGDDN;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBPIHILNAPB(GameObject EBIGFKEAJMH, IGEDHNEHMBB PBJIGEHKEIG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PHAFDIODDDG();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GEBEKKCKBFI(DELBFJHOJJB IEBAGHJDDMO);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CMPPHHJCDAF(DELBFJHOJJB IEBAGHJDDMO);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JONGJDNKMPN(DELBFJHOJJB IEBAGHJDDMO, HashSet<DELBFJHOJJB> DGNKMJPAFKP);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DFEHKFHCNNP(DELBFJHOJJB IEBAGHJDDMO, DELBFJHOJJB EEOCHNLFFKP, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GENHBIHHIAD(DELBFJHOJJB IEBAGHJDDMO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IKGHILPFJCF(DELBFJHOJJB IEBAGHJDDMO);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NBCBBHAHPNB LMLNAAGEPMO(bool DEODBPFIEBD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NBCBBHAHPNB OEMPPEADJFK(HashSet<Guid> BJGDCGIEEIA, bool DEODBPFIEBD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CGLCBGHNEMP(JMACJEMCHHE OKABCGPFCBI);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BCMIALKICKL(NBCBBHAHPNB ICEEKEMAGHB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EHALLGEOMKI(NBCBBHAHPNB ICEEKEMAGHB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IKMNBNIEJOD(NBCBBHAHPNB ICEEKEMAGHB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MJNAGLCCMGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool KIIMIIMONHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DELBFJHOJJB HJDMDFLAGEP(int LJNCFHKPJLF);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DELBFJHOJJB HFHLHENDLNH(Guid JFIAILAFBMC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ODFIJFJKAJF(DELBFJHOJJB IEBAGHJDDMO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ADNNLGMHJAJ();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBFPELKLODP(DELBFJHOJJB AGPCABFLNCA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[NHEMKOLBJOI(MCNCDDPANDH.Application)]
public interface BKLKDLHMCOB
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMNNANFJJLA(DGLMPOADHGN AGPCABFLNCA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMKCDGMGOPL(DGLMPOADHGN AGPCABFLNCA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MJGAKLOHIIC(DGLMPOADHGN AGPCABFLNCA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PDNBDBNEPPB(DGLMPOADHGN AGPCABFLNCA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BAECHDKHNOO(DGLMPOADHGN AGPCABFLNCA);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADMCLNKABEN(DGLMPOADHGN AGPCABFLNCA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void LEJAGPOLNCF(DELBFJHOJJB OLEHPFDHMDP, int HHJDPKINPEL, DELBFJHOJJB JBOOGDNKKAI, int IJADIOBLHOE, [Optional] Vector3? NBPJAFLLKIM, [Optional] Quaternion? PMDNDEHHBFI);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void MANADMPINNI(DELBFJHOJJB MDJIEMMMACP, DELBFJHOJJB KPGCPMGHCML);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DGLMPOADHGN : DELBFJHOJJB, HFACOBBIGNL, IEquatable<DELBFJHOJJB>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CDMAAIFIAND : HFACOBBIGNL
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DELBFJHOJJB ODMBIAPCAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<DELBFJHOJJB> NNOEDHJLHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 HPDGMIACLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion DHOLADKEHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool GLCOHLEHKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool ILICALCHJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event LEJAGPOLNCF HAFLKOOJKAP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event LEJAGPOLNCF EMIDIKPHFCG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event LEJAGPOLNCF MEGHDIDNHCB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event MANADMPINNI GDHFMOPOGHH;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DOFCKMODMNI();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FIAKOELMJPA();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PNICEJOHIIJ();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FEOMAKPODFB();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CPNEMJOGNCH();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GHHEFHHPKLC();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MPDOJMKCEDK(int DLGPHLDHJHI, DELBFJHOJJB JBOOGDNKKAI, int HEOKGAEOFJM);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NMEMAEBDEGG();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NIGOEOHDGIP(int DLGPHLDHJHI, DELBFJHOJJB OLEHPFDHMDP, int ALCAFGCLEFG, [Optional] Vector3? NBPJAFLLKIM, [Optional] Quaternion? PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DGCFCIHMNHE(DELBFJHOJJB OLEHPFDHMDP);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void PFLONJDEGFA();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ICKPNDDDPOP(int AELAKOMEEDP, Vector3 KNKOADKCJLL);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JOAIGHILOCJ(Vector3 NJKGJKNGMLM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ADPHGALIJCM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 NIFOKOLAEAI
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
public interface IGEDHNEHMBB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KEBBDLMMILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	GDCHAOCEHAJ OEBKAEAOPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, IGEDHNEHMBB
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
			[Cpp2IlInjected.Address(RVA = "0x81E8A0", Offset = "0x81D6A0", VA = "0x18081E8A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public GDCHAOCEHAJ LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x61601E0", Offset = "0x615EFE0", VA = "0x1861601E0")]
		public static ConnectableConfigData MNMFNGNLIDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6160290", Offset = "0x615F090", VA = "0x186160290")]
		public ConnectableConfigData(LegacyConnectableLinkVisual JDCEHDKGBHJ, bool OOBBNLLEGEM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BJCHCLMIKFE : IEquatable<BJCHCLMIKFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public DELBFJHOJJB IEBAGHJDDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int GCKLCCFNEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int NNOCEANAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 NBPJAFLLKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion PMDNDEHHBFI;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x615FDE0", Offset = "0x615EBE0", VA = "0x18615FDE0")]
	public BJCHCLMIKFE(DELBFJHOJJB IEBAGHJDDMO, int GCKLCCFNEOF, int NNOCEANAFHO, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x615FE40", Offset = "0x615EC40", VA = "0x18615FE40")]
	public BJCHCLMIKFE(DELBFJHOJJB IEBAGHJDDMO, int GCKLCCFNEOF, int NNOCEANAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x615FD60", Offset = "0x615EB60", VA = "0x18615FD60")]
	public BJCHCLMIKFE(DELBFJHOJJB IEBAGHJDDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x615F8E0", Offset = "0x615E6E0", VA = "0x18615F8E0", Slot = "4")]
	public bool Equals(BJCHCLMIKFE GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x615F990", Offset = "0x615E790", VA = "0x18615F990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class CPIILHLPLAL : KMDLDJDENHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform AFOLJDADEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private GDCHAOCEHAJ ILNODCHCEGN;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5C839F0", Offset = "0x5C827F0", VA = "0x185C839F0", Slot = "4")]
	public void HBPIHILNAPB(Transform AFOLJDADEON, GDCHAOCEHAJ ILNODCHCEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x61600D0", Offset = "0x615EED0", VA = "0x1861600D0", Slot = "5")]
	public GDCHAOCEHAJ ABGMNGDFDBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6160190", Offset = "0x615EF90", VA = "0x186160190", Slot = "6")]
	public void NHJHFLCFLPM(GDCHAOCEHAJ JPOAPHADIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public CPIILHLPLAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class NPLNFOGIKJF : IDisposable, PKOMKIGMBGE
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LNJCCHDHBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public DELBFJHOJJB oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DELBFJHOJJB newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public LNJCCHDHBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6169EE0", Offset = "0x6168CE0", VA = "0x186169EE0")]
		internal bool IJJGLEELDDL(NLGIMBEHOPN node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly DEFJMFDPHAF ADHECCHBCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private DFCCMAMMHHO JEOCLDJBGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private FKAELFABDEF NADMMCKECPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool OOBBNLLEGEM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public NLGIMBEHOPN OLBMHECMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x616CFE0", Offset = "0x616BDE0", VA = "0x18616CFE0")]
	public bool BFIBFPOHPCD([In] CDNHEDFPEKM LHODDAGAJKC, bool AIGLJEENEBG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x616EA60", Offset = "0x616D860", VA = "0x18616EA60")]
	private bool LGPHMKHGBPI([In] CDNHEDFPEKM LHODDAGAJKC, bool AIGLJEENEBG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6170D40", Offset = "0x616FB40", VA = "0x186170D40")]
	public NPLNFOGIKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x616DD20", Offset = "0x616CB20", VA = "0x18616DD20", Slot = "5")]
	public void HBPIHILNAPB(IKEOOLGKIAJ JOMBJDFNECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x616E690", Offset = "0x616D490", VA = "0x18616E690", Slot = "17")]
	public void IJPKENCMKCC(EPGMEMAKCFA KPIAINDMMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x616F020", Offset = "0x616DE20", VA = "0x18616F020", Slot = "12")]
	public void LHKOMKNBEBE(Func<DELBFJHOJJB, bool> EKIPPBJBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x616F030", Offset = "0x616DE30", VA = "0x18616F030")]
	private void LHKOMKNBEBE(DEFJMFDPHAF FMEAKEGGFNK, Func<DELBFJHOJJB, bool> EKIPPBJBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x616DA60", Offset = "0x616C860", VA = "0x18616DA60", Slot = "11")]
	public void FIMLALJPPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x616FF80", Offset = "0x616ED80", VA = "0x18616FF80", Slot = "8")]
	public bool PAMOLGBLPCI(DELBFJHOJJB JNGGDCINHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6170780", Offset = "0x616F580", VA = "0x186170780")]
	private bool PIBBIIFCAKD(DELBFJHOJJB POIAIIDFAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x616DDB0", Offset = "0x616CBB0", VA = "0x18616DDB0")]
	private static bool HCNMCJPELJN(DELBFJHOJJB POIAIIDFAIJ, DEFJMFDPHAF CADIIAIFNMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x616D5E0", Offset = "0x616C3E0", VA = "0x18616D5E0")]
	private void DKIALOCHPLH(Transform OPEEIKBIBNH, DEFJMFDPHAF CGHPIKFBCLA, DEFJMFDPHAF[] DPEOFHBALNB, DELBFJHOJJB JCAFBOLOCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x616F4F0", Offset = "0x616E2F0", VA = "0x18616F4F0")]
	private BJCHCLMIKFE MHFGECOCEOG(Transform DJPHPDBAJEA, BJCHCLMIKFE OLKBMKDIPPF)
	{
		return default(BJCHCLMIKFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x616C1D0", Offset = "0x616AFD0", VA = "0x18616C1D0")]
	private static bool APIFAIKGABN(DEFJMFDPHAF CADIIAIFNMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x616F640", Offset = "0x616E440", VA = "0x18616F640")]
	private string MJGAKLOHIIC(DELBFJHOJJB IEBAGHJDDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x616C990", Offset = "0x616B790", VA = "0x18616C990")]
	private string BAECHDKHNOO(DELBFJHOJJB IEBAGHJDDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6170150", Offset = "0x616EF50", VA = "0x186170150")]
	private void PEIHGJAFCFF([In] CDNHEDFPEKM LHODDAGAJKC, bool KINLMAENCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x616F320", Offset = "0x616E120", VA = "0x18616F320")]
	private void LJHOJNPBDPA(DELBFJHOJJB APEMCPNHEOP, bool KINLMAENCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x616CA00", Offset = "0x616B800", VA = "0x18616CA00")]
	private void BCFLMDBKBCH(DELBFJHOJJB PJJECIBOANO, int ALCAFGCLEFG, DELBFJHOJJB OIJEBDLJMMH, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI, bool KINLMAENCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x616C390", Offset = "0x616B190", VA = "0x18616C390")]
	private void APLECMKBFAO(DELBFJHOJJB HFNFACCMAOK, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI, bool NOBJHKKCHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x616FEA0", Offset = "0x616ECA0", VA = "0x18616FEA0", Slot = "9")]
	public bool OKNJENJPIGF(DELBFJHOJJB HFNFACCMAOK, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x616D360", Offset = "0x616C160", VA = "0x18616D360")]
	private bool CMHCCJHHCPK(DELBFJHOJJB HFNFACCMAOK, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x616E3D0", Offset = "0x616D1D0", VA = "0x18616E3D0")]
	private static void HLNNEBAIHLI(DELBFJHOJJB HFNFACCMAOK, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI, DEFJMFDPHAF BEGNHJECGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x616F8D0", Offset = "0x616E6D0", VA = "0x18616F8D0")]
	private void MOPEOLFFBEC(DELBFJHOJJB PJJECIBOANO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x616E5B0", Offset = "0x616D3B0", VA = "0x18616E5B0")]
	private void IANJHDMDBKP(DEFJMFDPHAF FMEAKEGGFNK, DELBFJHOJJB ENCPGPBNBAI, DELBFJHOJJB MLCHFHHFNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x616E620", Offset = "0x616D420", VA = "0x18616E620")]
	private void IANJHDMDBKP(DELBFJHOJJB IEBAGHJDDMO, DELBFJHOJJB ENCPGPBNBAI, DELBFJHOJJB MLCHFHHFNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x616DA80", Offset = "0x616C880", VA = "0x18616DA80")]
	private void GDIONJGFJEN(DELBFJHOJJB IEBAGHJDDMO, DELBFJHOJJB ENCPGPBNBAI, DELBFJHOJJB MLCHFHHFNBC, bool BINAFMMBIOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x616DAF0", Offset = "0x616C8F0", VA = "0x18616DAF0")]
	private void GDIONJGFJEN(DEFJMFDPHAF GDOPFEEANMP, DELBFJHOJJB JCAFBOLOCLL, DELBFJHOJJB KPGCPMGHCML, bool BINAFMMBIOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x616D030", Offset = "0x616BE30", VA = "0x18616D030")]
	private void BIDDFGJIDOL(DELBFJHOJJB APEMCPNHEOP, int ALCAFGCLEFG, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x616D190", Offset = "0x616BF90", VA = "0x18616D190")]
	private void CIOCJGLGPDK(NLGIMBEHOPN OGCHMLDLLMJ, NLGIMBEHOPN MEICNMKBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x616FD40", Offset = "0x616EB40", VA = "0x18616FD40", Slot = "18")]
	public DELBFJHOJJB NPIEHPCKICB(DELBFJHOJJB IEBAGHJDDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x616E6C0", Offset = "0x616D4C0", VA = "0x18616E6C0", Slot = "13")]
	public void JONGJDNKMPN(DELBFJHOJJB IEBAGHJDDMO, HashSet<DELBFJHOJJB> DMCJFIELEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x616FB00", Offset = "0x616E900", VA = "0x18616FB00", Slot = "14")]
	public List<DELBFJHOJJB> NJBFDNJDGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x616F800", Offset = "0x616E600", VA = "0x18616F800")]
	protected NLGIMBEHOPN MNJLLFLCBHM(NLGIMBEHOPN FMEAKEGGFNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x616D9C0", Offset = "0x616C7C0", VA = "0x18616D9C0")]
	protected DEFJMFDPHAF[] DOLOENMPMID(DEFJMFDPHAF CADIIAIFNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x616F9F0", Offset = "0x616E7F0", VA = "0x18616F9F0")]
	protected bool NGNGGJADKJE(DELBFJHOJJB IEBAGHJDDMO, [Out] DEFJMFDPHAF FMEAKEGGFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x616DBF0", Offset = "0x616C9F0", VA = "0x18616DBF0", Slot = "15")]
	public bool GNOMBKMAGNB(DELBFJHOJJB IEBAGHJDDMO, [Out] BJCHCLMIKFE OFJLBNJLEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x616D150", Offset = "0x616BF50", VA = "0x18616D150")]
	protected DEFJMFDPHAF CGHCLMKIAJJ(BJCHCLMIKFE DMDNBKPAKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x616F710", Offset = "0x616E510", VA = "0x18616F710", Slot = "10")]
	public bool MLELIFKEDPP(DELBFJHOJJB PJJECIBOANO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x616DE60", Offset = "0x616CC60", VA = "0x18616DE60")]
	private bool HLICGCDKKFA(DELBFJHOJJB PJJECIBOANO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x616C100", Offset = "0x616AF00", VA = "0x18616C100")]
	private static bool AKJEIIJHHMI(DEFJMFDPHAF BGLIKJCCDLH, BJCHCLMIKFE LKFGHALEKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x616CFE0", Offset = "0x616BDE0", VA = "0x18616CFE0", Slot = "7")]
	private bool FKMMCPABDCG([In] CDNHEDFPEKM LHODDAGAJKC, bool AIGLJEENEBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class ACPHPLMGKAO : IKEOOLGKIAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly NAINNGGFMLM COEPBABOGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly FKAELFABDEF NADMMCKECPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly GGHMKLAHKKL AKFBNKAEPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly ELOGPMFMMCO DOFEJDODLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly PKOMKIGMBGE ICEEKEMAGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal MNLEIODKHIA EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal BILOMPBJLAE JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal DFCCMAMMHHO CJCDNMODHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool OOBBNLLEGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool MENNGKIJNBL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DIOOIFLCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x1766FB0", VA = "0x1817681B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1768170", Offset = "0x1766F70", VA = "0x181768170")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BOHPGLCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x17681C0", Offset = "0x1766FC0", VA = "0x1817681C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x17681A0", Offset = "0x1766FA0", VA = "0x1817681A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IOINHHKHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<DELBFJHOJJB, DELBFJHOJJB> IMBNFAEBJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x615D780", Offset = "0x615C580", VA = "0x18615D780", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x615DF10", Offset = "0x615CD10", VA = "0x18615DF10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<DELBFJHOJJB, DELBFJHOJJB> NADPMCGCFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x615D7E0", Offset = "0x615C5E0", VA = "0x18615D7E0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x615D8B0", Offset = "0x615C6B0", VA = "0x18615D8B0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<DELBFJHOJJB, DELBFJHOJJB, DELBFJHOJJB> LKFHNDJGDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x615E0D0", Offset = "0x615CED0", VA = "0x18615E0D0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x615DC20", Offset = "0x615CA20", VA = "0x18615DC20", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x615F1C0", Offset = "0x615DFC0", VA = "0x18615F1C0")]
	public ACPHPLMGKAO(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x615E130", Offset = "0x615CF30", VA = "0x18615E130", Slot = "12")]
	public void HBPIHILNAPB(GameObject EBIGFKEAJMH, IGEDHNEHMBB PBJIGEHKEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x615DB80", Offset = "0x615C980", VA = "0x18615DB80", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x615EF40", Offset = "0x615DD40", VA = "0x18615EF40", Slot = "13")]
	public void PHAFDIODDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x615DF70", Offset = "0x615CD70", VA = "0x18615DF70", Slot = "14")]
	public void GEBEKKCKBFI(DELBFJHOJJB IEBAGHJDDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x615D850", Offset = "0x615C650", VA = "0x18615D850", Slot = "15")]
	public void CMPPHHJCDAF(DELBFJHOJJB IEBAGHJDDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x615D840", Offset = "0x615C640", VA = "0x18615D840", Slot = "22")]
	public bool CGLCBGHNEMP(JMACJEMCHHE OKABCGPFCBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x615EA70", Offset = "0x615D870", VA = "0x18615EA70")]
	internal bool LGPHMKHGBPI([In] CDNHEDFPEKM LHODDAGAJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x615E6F0", Offset = "0x615D4F0", VA = "0x18615E6F0")]
	internal bool HLICGCDKKFA([In] CDNHEDFPEKM LHODDAGAJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x615DB20", Offset = "0x615C920", VA = "0x18615DB20")]
	internal bool DKCMOLPFGCI([In] CDNHEDFPEKM LHODDAGAJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x615EDD0", Offset = "0x615DBD0", VA = "0x18615EDD0")]
	internal bool NOEKCOLOOEF([In] CDNHEDFPEKM LHODDAGAJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x615DC80", Offset = "0x615CA80", VA = "0x18615DC80")]
	internal void EDGINCIICAA(DELBFJHOJJB IEBAGHJDDMO, int HDFGPHGOCNG, bool AIGLJEENEBG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x615D850", Offset = "0x615C650", VA = "0x18615D850")]
	internal bool JOIHKDKLPMD(DELBFJHOJJB FNMCEEBOJEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x615ECA0", Offset = "0x615DAA0", VA = "0x18615ECA0")]
	internal bool MCJIBGBDMHI(DELBFJHOJJB HFNFACCMAOK, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x615E980", Offset = "0x615D780", VA = "0x18615E980", Slot = "16")]
	public void JONGJDNKMPN(DELBFJHOJJB IEBAGHJDDMO, HashSet<DELBFJHOJJB> DGNKMJPAFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x615D910", Offset = "0x615C710", VA = "0x18615D910", Slot = "17")]
	public void DFEHKFHCNNP(DELBFJHOJJB HFNFACCMAOK, DELBFJHOJJB EEOCHNLFFKP, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x615DF90", Offset = "0x615CD90", VA = "0x18615DF90", Slot = "18")]
	public void GENHBIHHIAD(DELBFJHOJJB PJJECIBOANO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x615E780", Offset = "0x615D580", VA = "0x18615E780", Slot = "19")]
	public void IKGHILPFJCF(DELBFJHOJJB PJJECIBOANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x615EF90", Offset = "0x615DD90", VA = "0x18615EF90")]
	public void POOONNBJJKP([Optional] GPMIEGMKNGH OBBALALLKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x615D6F0", Offset = "0x615C4F0", VA = "0x18615D6F0", Slot = "23")]
	public void BCMIALKICKL(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x615EB30", Offset = "0x615D930", VA = "0x18615EB30", Slot = "20")]
	public NBCBBHAHPNB LMLNAAGEPMO(bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x615EF20", Offset = "0x615DD20", VA = "0x18615EF20", Slot = "21")]
	public NBCBBHAHPNB OEMPPEADJFK(HashSet<Guid> BJGDCGIEEIA, bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x615E940", Offset = "0x615D740", VA = "0x18615E940", Slot = "25")]
	public void IKMNBNIEJOD(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x615DE60", Offset = "0x615CC60", VA = "0x18615DE60", Slot = "24")]
	public void EHALLGEOMKI(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class FKAELFABDEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly OCLIPKLKFLJ<DELBFJHOJJB, DELBFJHOJJB> IMBNFAEBJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly OCLIPKLKFLJ<DELBFJHOJJB, DELBFJHOJJB> NADPMCGCFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly CINFAOKHFKB<DELBFJHOJJB, DELBFJHOJJB, DELBFJHOJJB> LKFHNDJGDDN;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x61687D0", Offset = "0x61675D0", VA = "0x1861687D0")]
	public FKAELFABDEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	public void HBPIHILNAPB(ACPHPLMGKAO JOMBJDFNECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x61686F0", Offset = "0x61674F0", VA = "0x1861686F0")]
	public void FGDHHIDHPEO(DELBFJHOJJB OGCHMLDLLMJ, DELBFJHOJJB APEMCPNHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6168690", Offset = "0x6167490", VA = "0x186168690")]
	public void DGEIEKFEJLE(DELBFJHOJJB OGCHMLDLLMJ, DELBFJHOJJB APEMCPNHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6168750", Offset = "0x6167550", VA = "0x186168750")]
	public void GMABKEHCMCN(DELBFJHOJJB EBMEJPEOJDM, DELBFJHOJJB OIJEBDLJMMH, DELBFJHOJJB APEMCPNHEOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class GGHMKLAHKKL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private ACPHPLMGKAO JOMBJDFNECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private BILOMPBJLAE JLJLCJEJIMH;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GGHMKLAHKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6168C80", Offset = "0x6167A80", VA = "0x186168C80")]
	public void HBPIHILNAPB(ACPHPLMGKAO JOMBJDFNECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6168C70", Offset = "0x6167A70", VA = "0x186168C70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6168EB0", Offset = "0x6167CB0", VA = "0x186168EB0")]
	private void LEKKKALJBNP(GPMIEGMKNGH HKNKALEJLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6168ED0", Offset = "0x6167CD0", VA = "0x186168ED0")]
	private void POIFACACDPB(GPMIEGMKNGH OCPLPDBPGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6168B70", Offset = "0x6167970", VA = "0x186168B70")]
	public void DLKDMGMLOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6168DB0", Offset = "0x6167BB0", VA = "0x186168DB0")]
	public void KFPEOFMJCHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class FNKADAALJEC
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AEOJPAJBKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NAINNGGFMLM container;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AEOJPAJBKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x615F5B0", Offset = "0x615E3B0", VA = "0x18615F5B0")]
		internal ACPHPLMGKAO PCJIMBCOEOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6168970", Offset = "0x6167770", VA = "0x186168970")]
	public static void PLGHMNAIHII(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x61688F0", Offset = "0x61676F0", VA = "0x1861688F0")]
	public static void AOKDCIMHMOB(NAINNGGFMLM COEPBABOGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class OGOCJFEIHBJ : IDisposable, DFCCMAMMHHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, GDCHAOCEHAJ> MKCJBANKCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly EPGMEMAKCFA NEHJDGAOMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private KMDLDJDENHG IHKLCNJINDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private PKOMKIGMBGE ICEEKEMAGHB;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6171BE0", Offset = "0x61709E0", VA = "0x186171BE0")]
	public OGOCJFEIHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6170F10", Offset = "0x616FD10", VA = "0x186170F10", Slot = "7")]
	public void HBPIHILNAPB(PKOMKIGMBGE ICEEKEMAGHB, KMDLDJDENHG IHKLCNJINDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6171250", Offset = "0x6170050", VA = "0x186171250", Slot = "5")]
	public void KKLAHBGHGJI(NLGIMBEHOPN NPOKHIGPOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6171010", Offset = "0x616FE10", VA = "0x186171010", Slot = "9")]
	public void KCKJFDLGNDB(NLGIMBEHOPN PDFIPILAOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6171A20", Offset = "0x6170820", VA = "0x186171A20", Slot = "8")]
	public void OFJGHIJOADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6171620", Offset = "0x6170420", VA = "0x186171620", Slot = "10")]
	public void LPBKELLAOKO(NLGIMBEHOPN IFELBDJNOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6170F50", Offset = "0x616FD50", VA = "0x186170F50", Slot = "11")]
	public void JKDEBLPKKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6171870", Offset = "0x6170670", VA = "0x186171870")]
	private bool OBPNEDJHNHJ(NLGIMBEHOPN INMKDHNNFDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class ELOGPMFMMCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct KEFHIJJHCMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly DEFJMFDPHAF BDHBNLDGICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> BJGDCGIEEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly JMACJEMCHHE EKOPNLMKAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly JMACJEMCHHE EFHFKOLJKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool DEODBPFIEBD;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool KCIPPLMHCLO
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6169450", Offset = "0x6168250", VA = "0x186169450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6169CB0", Offset = "0x6168AB0", VA = "0x186169CB0")]
		public KEFHIJJHCMH(DEFJMFDPHAF BDHBNLDGICO, HashSet<Guid> BJGDCGIEEIA, bool DEODBPFIEBD, [Optional] JMACJEMCHHE EKOPNLMKAAL, [Optional] JMACJEMCHHE EFHFKOLJKPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6169950", Offset = "0x6168750", VA = "0x186169950")]
		public JMACJEMCHHE JPFDICAGNEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x61696D0", Offset = "0x61684D0", VA = "0x1861696D0")]
		private JMACJEMCHHE IPDCAMNBNFA([Out] JMACJEMCHHE EELGPMMKPCG, [Out] JMACJEMCHHE DGJHOJNFNIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6169AC0", Offset = "0x61688C0", VA = "0x186169AC0")]
		private JMACJEMCHHE KDPOLGFPIPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6169560", Offset = "0x6168360", VA = "0x186169560")]
		private void FAEJAAACMPM(JMACJEMCHHE NJAFIJCKIDH, JMACJEMCHHE CMBMPJAFLIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6169790", Offset = "0x6168590", VA = "0x186169790")]
		private void JDCDBCAPEBB(JMACJEMCHHE EELGPMMKPCG, JMACJEMCHHE DGJHOJNFNIK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private ACPHPLMGKAO JOMBJDFNECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PKOMKIGMBGE ICEEKEMAGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private DFCCMAMMHHO JEOCLDJBGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private BILOMPBJLAE JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool DBIHDFLKJBA;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool BLBIMHGPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6167FA0", Offset = "0x6166DA0", VA = "0x186167FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool DIOOIFLCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6167880", Offset = "0x6166680", VA = "0x186167880")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6167A30", Offset = "0x6166830", VA = "0x186167A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6166CB0", Offset = "0x6165AB0", VA = "0x186166CB0")]
	public void HBPIHILNAPB(ACPHPLMGKAO JOMBJDFNECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x61678D0", Offset = "0x61666D0", VA = "0x1861678D0")]
	public NBCBBHAHPNB LMLNAAGEPMO(bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6167FF0", Offset = "0x6166DF0", VA = "0x186167FF0")]
	public NBCBBHAHPNB OEMPPEADJFK(HashSet<Guid> BJGDCGIEEIA, bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6165C20", Offset = "0x6164A20", VA = "0x186165C20")]
	public void BCMIALKICKL(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6165FE0", Offset = "0x6164DE0", VA = "0x186165FE0")]
	public void EHALLGEOMKI(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x61678A0", Offset = "0x61666A0", VA = "0x1861678A0")]
	public void LINBCKJEJNK(NBCBBHAHPNB ICEEKEMAGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6166AD0", Offset = "0x61658D0", VA = "0x186166AD0")]
	private void GOKBFOMLAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6167370", Offset = "0x6166170", VA = "0x186167370")]
	private JMACJEMCHHE JOLLNMPLDKA(DEFJMFDPHAF FMEAKEGGFNK, bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6166D20", Offset = "0x6165B20", VA = "0x186166D20")]
	private static void HHMCIEGLNLA(DEFJMFDPHAF FMEAKEGGFNK, bool DEODBPFIEBD, JMACJEMCHHE OKABCGPFCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6167150", Offset = "0x6165F50", VA = "0x186167150")]
	private void IAJNMFFDLCH(DEFJMFDPHAF FMEAKEGGFNK, bool DEODBPFIEBD, JMACJEMCHHE OKABCGPFCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6167F10", Offset = "0x6166D10", VA = "0x186167F10")]
	private JMACJEMCHHE NPFNAIIPPCF(DEFJMFDPHAF BDHBNLDGICO, HashSet<Guid> BJGDCGIEEIA, bool DEODBPFIEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6167440", Offset = "0x6166240", VA = "0x186167440")]
	private bool KANCLJEKHFL(NBCBBHAHPNB EOKMIBFOOBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6166460", Offset = "0x6165260", VA = "0x186166460")]
	private bool GBGAFLDOLGI(JMACJEMCHHE OKABCGPFCBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6167A50", Offset = "0x6166850", VA = "0x186167A50")]
	private bool MJCBBHCJALG(NBCBBHAHPNB ICEEKEMAGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6166350", Offset = "0x6165150", VA = "0x186166350")]
	private static bool FIJGAIHIJGA(JMACJEMCHHE OKABCGPFCBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6165CB0", Offset = "0x6164AB0", VA = "0x186165CB0")]
	public static bool CGLCBGHNEMP(JMACJEMCHHE OKABCGPFCBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6167BE0", Offset = "0x61669E0", VA = "0x186167BE0")]
	private DELBFJHOJJB NKFOIGCPBDL(JMACJEMCHHE OKABCGPFCBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6166FD0", Offset = "0x6165DD0", VA = "0x186166FD0")]
	private DELBFJHOJJB HJDMDFLAGEP(JMACJEMCHHE OKABCGPFCBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6167A70", Offset = "0x6166870", VA = "0x186167A70")]
	private DELBFJHOJJB NFACIPGHGDA(JMACJEMCHHE OKABCGPFCBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6164AF0", Offset = "0x61638F0", VA = "0x186164AF0")]
	private static Guid NMLIFKLOFNH(JMACJEMCHHE OKABCGPFCBI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6165EF0", Offset = "0x6164CF0", VA = "0x186165EF0")]
	private string CKEHOCOCOIL(JMACJEMCHHE OKABCGPFCBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x61676C0", Offset = "0x61664C0", VA = "0x1861676C0")]
	private bool KGDNDLFKAKF(DEFJMFDPHAF FMEAKEGGFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6166080", Offset = "0x6164E80", VA = "0x186166080")]
	private static void EONKODIGDFA(DEFJMFDPHAF BDHBNLDGICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public ELOGPMFMMCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct CDNHEDFPEKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public DELBFJHOJJB APEMCPNHEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public DELBFJHOJJB OGCHMLDLLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int ALCAFGCLEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int HEOKGAEOFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 NBPJAFLLKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion PMDNDEHHBFI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BJCHCLMIKFE LLNJDBJPNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x615FFC0", Offset = "0x615EDC0", VA = "0x18615FFC0")]
		get
		{
			return default(BJCHCLMIKFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BJCHCLMIKFE LKBONHPELPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x615FF90", Offset = "0x615ED90", VA = "0x18615FF90")]
		get
		{
			return default(BJCHCLMIKFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6160060", Offset = "0x615EE60", VA = "0x186160060")]
	public CDNHEDFPEKM(DELBFJHOJJB APEMCPNHEOP, DELBFJHOJJB OGCHMLDLLMJ, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface PKOMKIGMBGE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NLGIMBEHOPN OLBMHECMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBPIHILNAPB(IKEOOLGKIAJ JOMBJDFNECI);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BFIBFPOHPCD([In] CDNHEDFPEKM LHODDAGAJKC, bool AIGLJEENEBG = true);

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PAMOLGBLPCI(DELBFJHOJJB JNGGDCINHLD);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OKNJENJPIGF(DELBFJHOJJB HFNFACCMAOK, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MLELIFKEDPP(DELBFJHOJJB PJJECIBOANO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FIMLALJPPAO();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LHKOMKNBEBE(Func<DELBFJHOJJB, bool> EKIPPBJBLKN);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JONGJDNKMPN(DELBFJHOJJB IEBAGHJDDMO, HashSet<DELBFJHOJJB> DMCJFIELEAG);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<DELBFJHOJJB> NJBFDNJDGNE();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GNOMBKMAGNB(DELBFJHOJJB IEBAGHJDDMO, [Out] BJCHCLMIKFE OFJLBNJLEBC);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IJPKENCMKCC(EPGMEMAKCFA KPIAINDMMOB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool EPGMEMAKCFA(NLGIMBEHOPN FMEAKEGGFNK);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface NLGIMBEHOPN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DELBFJHOJJB HLBNLAJIMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	NLGIMBEHOPN DBLFEIKNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BJCHCLMIKFE IILNIBHFECK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool IBOKCAPIMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GDCHAOCEHAJ
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMFMKFLHHJJ(DELBFJHOJJB JBOOGDNKKAI, BJCHCLMIKFE APEMCPNHEOP);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJAKHLKKBMA(DELBFJHOJJB JBOOGDNKKAI, BJCHCLMIKFE APEMCPNHEOP);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGKEOKEEIME(DELBFJHOJJB JBOOGDNKKAI, BJCHCLMIKFE APEMCPNHEOP);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGCCGGHNEMN(DELBFJHOJJB JBOOGDNKKAI, BJCHCLMIKFE APEMCPNHEOP);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GDCHAOCEHAJ Instantiate(Transform AFOLJDADEON);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFGJMFOHKEH();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KMDLDJDENHG
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBPIHILNAPB(Transform AFOLJDADEON, GDCHAOCEHAJ ILNODCHCEGN);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GDCHAOCEHAJ ABGMNGDFDBB();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHJHFLCFLPM(GDCHAOCEHAJ JPOAPHADIFA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MNLEIODKHIA : MJNAGLCCMGI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INIDDHDEAOJ(Guid LCFOGOGANIB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface DFCCMAMMHHO
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKLAHBGHGJI(NLGIMBEHOPN NPOKHIGPOOK);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBPIHILNAPB(PKOMKIGMBGE ICEEKEMAGHB, KMDLDJDENHG OJAAAHOPHJG);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OFJGHIJOADH();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KCKJFDLGNDB(NLGIMBEHOPN PDFIPILAOKK);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPBKELLAOKO(NLGIMBEHOPN IFELBDJNOFD);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JKDEBLPKKEJ();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class DEFJMFDPHAF : NLGIMBEHOPN
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DNKIBJDJPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public BJCHCLMIKFE nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public DEFJMFDPHAF foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public DNKIBJDJPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6165AF0", Offset = "0x61648F0", VA = "0x186165AF0")]
		internal bool GCJBPELABPP(NLGIMBEHOPN x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private BJCHCLMIKFE OFJLBNJLEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<DEFJMFDPHAF> PJOPMMGNAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private DEFJMFDPHAF GMHCBGLANKE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BJCHCLMIKFE IILNIBHFECK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x351A450", Offset = "0x3519250", VA = "0x18351A450", Slot = "6")]
		get
		{
			return default(BJCHCLMIKFE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6160920", Offset = "0x615F720", VA = "0x186160920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private DEFJMFDPHAF OGCHMLDLLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7AE540", Offset = "0x7AD340", VA = "0x1807AE540")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x61602E0", Offset = "0x615F0E0", VA = "0x1861602E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NLGIMBEHOPN DBLFEIKNGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7AE540", Offset = "0x7AD340", VA = "0x1807AE540", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DELBFJHOJJB HLBNLAJIMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IBOKCAPIMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6160C10", Offset = "0x615FA10", VA = "0x186160C10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ADJKNBNENNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6160820", Offset = "0x615F620", VA = "0x186160820", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected DEFJMFDPHAF GDOPFEEANMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6160C20", Offset = "0x615FA20", VA = "0x186160C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6161160", Offset = "0x615FF60", VA = "0x186161160")]
	public DEFJMFDPHAF(BJCHCLMIKFE MPCHFNMIJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6160C40", Offset = "0x615FA40", VA = "0x186160C40")]
	public DEFJMFDPHAF LMOKIJJFMPI(BJCHCLMIKFE IDHDGKAKAHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x61603C0", Offset = "0x615F1C0", VA = "0x1861603C0")]
	public DEFJMFDPHAF BIGMOKHNCML(BJCHCLMIKFE JPPNKMALGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6160540", Offset = "0x615F340", VA = "0x186160540")]
	public DEFJMFDPHAF BOIJHFOIOPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6160950", Offset = "0x615F750", VA = "0x186160950")]
	public void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6160870", Offset = "0x615F670", VA = "0x186160870")]
	public DEFJMFDPHAF FBFAENGFEDH(BJCHCLMIKFE OIJEBDLJMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6160AA0", Offset = "0x615F8A0", VA = "0x186160AA0")]
	private static void IJPKENCMKCC(DEFJMFDPHAF PONCNPLKEJB, EPGMEMAKCFA OLONHMONGPM, bool AGIDCKLNCPJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6160C00", Offset = "0x615FA00", VA = "0x186160C00", Slot = "9")]
	public void IJPKENCMKCC(EPGMEMAKCFA KPIAINDMMOB, bool BINAFMMBIOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6160D90", Offset = "0x615FB90", VA = "0x186160D90")]
	public static string MNMOLENCOGN(DEFJMFDPHAF PONCNPLKEJB, int ECOGAHLMAAL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6160720", Offset = "0x615F520", VA = "0x186160720")]
	public static DEFJMFDPHAF CGHCLMKIAJJ(DEFJMFDPHAF PONCNPLKEJB, BJCHCLMIKFE FPGONKAMECB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface BILOMPBJLAE
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool BLBIMHGPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool KIIMIIMONHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<GPMIEGMKNGH> LEKKKALJBNP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<GPMIEGMKNGH> POIFACACDPB;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(ACPHPLMGKAO JOMBJDFNECI);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(DELBFJHOJJB HFNFACCMAOK, DELBFJHOJJB EEOCHNLFFKP, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(DELBFJHOJJB PJJECIBOANO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(NBCBBHAHPNB MJEILDLOGKM, [Optional] GPMIEGMKNGH OBBALALLKLO);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, BILOMPBJLAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private ACPHPLMGKAO JOMBJDFNECI;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool BLBIMHGPBIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x616BE50", Offset = "0x616AC50", VA = "0x18616BE50", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool KIIMIIMONHH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x616BEB0", Offset = "0x616ACB0", VA = "0x18616BEB0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<GPMIEGMKNGH> LEKKKALJBNP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x616BDB0", Offset = "0x616ABB0", VA = "0x18616BDB0", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x616BF90", Offset = "0x616AD90", VA = "0x18616BF90", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<GPMIEGMKNGH> POIFACACDPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x616BD10", Offset = "0x616AB10", VA = "0x18616BD10", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x616BEF0", Offset = "0x616ACF0", VA = "0x18616BEF0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8A0", Offset = "0x7B96A0", VA = "0x1807BA8A0", Slot = "19")]
		public void SetManager(ACPHPLMGKAO JOMBJDFNECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x616BCE0", Offset = "0x616AAE0", VA = "0x18616BCE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x616AA60", Offset = "0x6169860", VA = "0x18616AA60", Slot = "23")]
		public void RequestMasterConnectNodes(DELBFJHOJJB OLEHPFDHMDP, int ALCAFGCLEFG, DELBFJHOJJB JBOOGDNKKAI, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x616AB90", Offset = "0x6169990", VA = "0x18616AB90", Slot = "24")]
		public void RequestMasterDisconnectNode(DELBFJHOJJB JNGGDCINHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x616AC50", Offset = "0x6169A50", VA = "0x18616AC50", Slot = "20")]
		public void RequestMasterModifyNode(DELBFJHOJJB HFNFACCMAOK, DELBFJHOJJB EEOCHNLFFKP, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x616AD80", Offset = "0x6169B80", VA = "0x18616AD80", Slot = "21")]
		public void RequestMasterReparentNodes(DELBFJHOJJB PJJECIBOANO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x616AEB0", Offset = "0x6169CB0", VA = "0x18616AEB0", Slot = "25")]
		public void RequestMasterReparentToRoot(DELBFJHOJJB PJJECIBOANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x616A930", Offset = "0x6169730", VA = "0x18616A930", Slot = "22")]
		public void RequestDeserializeConnectableGraph(NBCBBHAHPNB MJEILDLOGKM, [Optional] GPMIEGMKNGH OBBALALLKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x616B290", Offset = "0x616A090", VA = "0x18616B290")]
		[HPPIGNMPGLH]
		private void RpcMasterConnectNodes(DELBFJHOJJB OLEHPFDHMDP, int ALCAFGCLEFG, DELBFJHOJJB JBOOGDNKKAI, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x616B550", Offset = "0x616A350", VA = "0x18616B550")]
		[HPPIGNMPGLH]
		private void RpcMasterDisconnectNode(DELBFJHOJJB JNGGDCINHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x616B890", Offset = "0x616A690", VA = "0x18616B890")]
		[HPPIGNMPGLH]
		private void RpcMasterReparentNodes(DELBFJHOJJB PJJECIBOANO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x616B690", Offset = "0x616A490", VA = "0x18616B690")]
		[HPPIGNMPGLH]
		private void RpcMasterModifyNode(DELBFJHOJJB HFNFACCMAOK, DELBFJHOJJB EEOCHNLFFKP, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x616B080", Offset = "0x6169E80", VA = "0x18616B080")]
		[HPPIGNMPGLH]
		private void RpcConnectNodes(DELBFJHOJJB OLEHPFDHMDP, int ALCAFGCLEFG, DELBFJHOJJB JBOOGDNKKAI, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI, EMNOBOLMHMM LKNCHOBKAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x616B200", Offset = "0x616A000", VA = "0x18616B200")]
		[HPPIGNMPGLH]
		private void RpcDisconnectNode(DELBFJHOJJB JNGGDCINHLD, EMNOBOLMHMM LKNCHOBKAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x616BBE0", Offset = "0x616A9E0", VA = "0x18616BBE0")]
		[HPPIGNMPGLH]
		private void RpcReparentNodes(DELBFJHOJJB PJJECIBOANO, int GCGDEMADOGJ, DELBFJHOJJB OIJEBDLJMMH, int LLJBHKOOAPK, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI, EMNOBOLMHMM LKNCHOBKAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x616BB20", Offset = "0x616A920", VA = "0x18616BB20")]
		[HPPIGNMPGLH]
		private void RpcModifyNode(DELBFJHOJJB HFNFACCMAOK, int ALCAFGCLEFG, int HEOKGAEOFJM, Vector3 NBPJAFLLKIM, Quaternion PMDNDEHHBFI, EMNOBOLMHMM LKNCHOBKAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x616B1C0", Offset = "0x6169FC0", VA = "0x18616B1C0")]
		[HPPIGNMPGLH]
		private void RpcDeserializeConnectableGraph(NBCBBHAHPNB ICEEKEMAGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0C0", Offset = "0x7CAEC0", VA = "0x1807CC0C0")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, GDCHAOCEHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x616A2D0", Offset = "0x61690D0", VA = "0x18616A2D0", Slot = "4")]
		private void FHGPBCAFIKP(DELBFJHOJJB JBOOGDNKKAI, BJCHCLMIKFE APEMCPNHEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x616A6B0", Offset = "0x61694B0", VA = "0x18616A6B0", Slot = "5")]
		private void POGDFGPBKJJ(DELBFJHOJJB JBOOGDNKKAI, BJCHCLMIKFE APEMCPNHEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x616A070", Offset = "0x6168E70", VA = "0x18616A070", Slot = "6")]
		private void AEEPMEKEBGO(DELBFJHOJJB JBOOGDNKKAI, BJCHCLMIKFE APEMCPNHEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x616A450", Offset = "0x6169250", VA = "0x18616A450", Slot = "7")]
		private void HJMCIGPJDAI(DELBFJHOJJB JBOOGDNKKAI, BJCHCLMIKFE APEMCPNHEOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x616A640", Offset = "0x6169440", VA = "0x18616A640", Slot = "8")]
		private GDCHAOCEHAJ MOIELMKODAM(Transform AFOLJDADEON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x616A270", Offset = "0x6169070", VA = "0x18616A270", Slot = "9")]
		private void BKGINDFNDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NPFOHPHIIHH
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A0B070", Offset = "0x2A09E70", VA = "0x182A0B070")]
	public static ENLHAJGHEOF<T> ABKHEJNGKME<T>(this NAINNGGFMLM COEPBABOGAM)
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
