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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B977E0", Offset = "0x6B961E0", VA = "0x186B977E0", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private DFMCGIMCFGD bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private DFMCGIMCFGD bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B9CE40", Offset = "0x6B9B840", VA = "0x186B9CE40", Slot = "5")]
		public override void NPEPAFCACGO(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B9CE80", Offset = "0x6B9B880", VA = "0x186B9CE80")]
		private void PPMCIGPJJHC(OKABLMMJMFE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B9C990", Offset = "0x6B9B390", VA = "0x186B9C990")]
		private void BJMOLFMPHAJ(OKABLMMJMFE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B9CB00", Offset = "0x6B9B500", VA = "0x186B9CB00", Slot = "6")]
		public override void BLGFFGICMBK(OKABLMMJMFE registry, [In] EFAAIAEHAHM filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B9CFF0", Offset = "0x6B9B9F0", VA = "0x186B9CFF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class JEINCLLFPMP : FHIOCBHJNHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JKEONLPOODB : IEnumerable<JKGBAPEDMGJ>, IEnumerable, IEnumerator<JKGBAPEDMGJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private JKGBAPEDMGJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private GJJPJLAFENF localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GJJPJLAFENF <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JEINCLLFPMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NCCKDCPPFNC <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private PLFGOKCIKHG.LJANIOCAPMG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JKGBAPEDMGJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public JKEONLPOODB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6B91CB0", Offset = "0x6B906B0", VA = "0x186B91CB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6B917F0", Offset = "0x6B901F0", VA = "0x186B917F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B917D0", Offset = "0x6B901D0", VA = "0x186B917D0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C60", Offset = "0x6B90660", VA = "0x186B91C60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6B91BB0", Offset = "0x6B905B0", VA = "0x186B91BB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JKGBAPEDMGJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B91BB0", Offset = "0x6B905B0", VA = "0x186B91BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CMDFDDGNPEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JEINCLLFPMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BHLNHBCANEC nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CMDFDDGNPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B89510", Offset = "0x6B87F10", VA = "0x186B89510")]
		internal object LPGKDDDGABN(BHLNHBCANEC x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DFMJDMNEOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public BHLNHBCANEC child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CMDFDDGNPEB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public DFMJDMNEOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A080", Offset = "0x6B88A80", VA = "0x186B8A080")]
		internal object LEFCKNOMDBP((BHLNHBCANEC child, BHLNHBCANEC nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly CMICIECANPG NHMIOEMGOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly CMICIECANPG AMMINDEOHLL;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly CMICIECANPG AHCNMJHGJNJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly CMICIECANPG PHOGMMGFGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private BPONAJLONCI OOKEOGNIGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KHHOGBPENGN CHMJBKDFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private EGMIGEMPNPA NFIBDOHOIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private KINGIDJGNNN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private KNOEEDIBAID ECLICOGMAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BNPCGNGBNKJ KKAHGNKMLJM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9530", Offset = "0x8A7F30", VA = "0x1808A9530", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A92C0", Offset = "0x8A7CC0", VA = "0x1808A92C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IPGOGDBCELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B8F930", Offset = "0x6B8E330", VA = "0x186B8F930", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B8F560", Offset = "0x6B8DF60", VA = "0x186B8F560", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B8F610", Offset = "0x6B8E010", VA = "0x186B8F610", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B91560", Offset = "0x6B8FF60", VA = "0x186B91560", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6B8F2E0", Offset = "0x6B8DCE0", VA = "0x186B8F2E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D010", Offset = "0x6B8BA10", VA = "0x186B8D010", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B91760", Offset = "0x6B90160", VA = "0x186B91760")]
	public JEINCLLFPMP(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D670", Offset = "0x6B8C070", VA = "0x186B8D670", Slot = "12")]
	public void AIFHKOLJDOL(GameObject MNKAGJEGJCF, HHDPMFKBGKA GHLGDEIDHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EBB0", Offset = "0x6B8D5B0", VA = "0x186B8EBB0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FFA0", Offset = "0x6B8E9A0", VA = "0x186B8FFA0", Slot = "22")]
	public bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E700", Offset = "0x6B8D100", VA = "0x186B8E700")]
	private void DFLFBMMDKHF(GJJPJLAFENF ODOBLMCCBPI, GJJPJLAFENF FIMGMAIGKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F9E0", Offset = "0x6B8E3E0", VA = "0x186B8F9E0")]
	private void IJEBNMDGKEJ(GJJPJLAFENF ODOBLMCCBPI, GJJPJLAFENF IPEPHOJIFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F6C0", Offset = "0x6B8E0C0", VA = "0x186B8F6C0")]
	private void HPLGJCBCEGJ(GJJPJLAFENF ODOBLMCCBPI, GJJPJLAFENF IPEPHOJIFNP, GJJPJLAFENF FIMGMAIGKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B90750", Offset = "0x6B8F150", VA = "0x186B90750")]
	private void LDEPAENEEDM(GJJPJLAFENF ODOBLMCCBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "13")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FC90", Offset = "0x6B8E690", VA = "0x186B8FC90", Slot = "14")]
	public void JJJMHPMEAIK(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "15")]
	public void KEAJIFAKOEB(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EA50", Offset = "0x6B8D450", VA = "0x186B8EA50", Slot = "17")]
	public void DOIDPFJPGHL(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ NNJPJBJGPIA, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E910", Offset = "0x6B8D310", VA = "0x186B8E910")]
	public void DOIDPFJPGHL(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF NNJPJBJGPIA, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E310", Offset = "0x6B8CD10", VA = "0x186B8E310")]
	public void CIOCFAHGKED(JKGBAPEDMGJ GMLGNLBKHFJ, float LDFEJLDJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B90D00", Offset = "0x6B8F700", VA = "0x186B90D00", Slot = "18")]
	public void LJKIHEEOAEA(JKGBAPEDMGJ LJILLNPANEE, int ODCNDKNIIKA, JKGBAPEDMGJ PALJEDCNNHB, int AMJEONDEHHF, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B91440", Offset = "0x6B8FE40", VA = "0x186B91440")]
	private float OCPGGJLKEOC(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LDJCBIBELIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B90BD0", Offset = "0x6B8F5D0", VA = "0x186B90BD0")]
	public void LJKIHEEOAEA(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LDJCBIBELIM, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B90E50", Offset = "0x6B8F850", VA = "0x186B90E50")]
	public void LJKIHEEOAEA(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LDJCBIBELIM, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB, float LDFEJLDJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DAD0", Offset = "0x6B8C4D0", VA = "0x186B8DAD0", Slot = "19")]
	public void BKEPMFGDDNJ(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B904C0", Offset = "0x6B8EEC0", VA = "0x186B904C0")]
	public bool LDCLODIOACA(GJJPJLAFENF IDOMJKBDODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E3A0", Offset = "0x6B8CDA0", VA = "0x186B8E3A0", Slot = "16")]
	public void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGGMGCFCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "20")]
	public PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "21")]
	public PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FC20", Offset = "0x6B8E620", VA = "0x186B8FC20", Slot = "23")]
	public void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B914F0", Offset = "0x6B8FEF0", VA = "0x186B914F0", Slot = "24")]
	public void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FC00", Offset = "0x6B8E600", VA = "0x186B8FC00", Slot = "25")]
	public void IMEFKEPJNOP(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DFB0", Offset = "0x6B8C9B0", VA = "0x186B8DFB0")]
	private void CDGBMAELNNM(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LDJCBIBELIM, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB, float LDFEJLDJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D250", Offset = "0x6B8BC50", VA = "0x186B8D250")]
	private void AIAPGCPEBON(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LEEMAEKICLM, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B90B60", Offset = "0x6B8F560", VA = "0x186B90B60")]
	private void LFNCOGEDFIH(GJJPJLAFENF JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DF20", Offset = "0x6B8C920", VA = "0x186B8DF20")]
	[IteratorStateMachine(typeof(JKEONLPOODB))]
	public IEnumerable<JKGBAPEDMGJ> CCKPINKEOLJ(GJJPJLAFENF IDOMJKBDODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B90380", Offset = "0x6B8ED80", VA = "0x186B90380")]
	internal JKGBAPEDMGJ KOENKONHBKO(GJJPJLAFENF IDOMJKBDODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EF70", Offset = "0x6B8D970", VA = "0x186B8EF70")]
	internal GJJPJLAFENF FAOKHAEHJJG(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
		return default(GJJPJLAFENF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B90EB0", Offset = "0x6B8F8B0", VA = "0x186B90EB0")]
	private bool LMAFBIFMOJA(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D8E0", Offset = "0x6B8C2E0", VA = "0x186B8D8E0")]
	private bool APINMDGBJAB(BHLNHBCANEC GANDHMGOAJC, [Out] JKGBAPEDMGJ LDJCBIBELIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FFF0", Offset = "0x6B8E9F0", VA = "0x186B8FFF0")]
	private JKGBAPEDMGJ KOENKONHBKO(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D940", Offset = "0x6B8C340", VA = "0x186B8D940")]
	private JKGBAPEDMGJ BIJCGIMPKOC(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F390", Offset = "0x6B8DD90", VA = "0x186B8F390")]
	private JKGBAPEDMGJ GJMJHICGPEH(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EDA0", Offset = "0x6B8D7A0", VA = "0x186B8EDA0")]
	private static Guid EJNIJLINDPP(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E5B0", Offset = "0x6B8CFB0", VA = "0x186B8E5B0")]
	private string CPDJIHPFIKP(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F150", Offset = "0x6B8DB50", VA = "0x186B8F150")]
	private void FEFENLFBMED(JKGBAPEDMGJ JGEMMJEFOMN, JKGBAPEDMGJ LEEMAEKICLM, RigidTransform LENANFGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D0C0", Offset = "0x6B8BAC0", VA = "0x186B8D0C0")]
	private void ADKEMFADIAA(JKGBAPEDMGJ LEEMAEKICLM, JKGBAPEDMGJ JGEMMJEFOMN, RigidTransform LENANFGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E6A0", Offset = "0x6B8D0A0", VA = "0x186B8E6A0")]
	private void CPPIPLFLDFD(JKGBAPEDMGJ DNBOOMFENIJ, JKGBAPEDMGJ JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EDE0", Offset = "0x6B8D7E0", VA = "0x186B8EDE0")]
	private void ELIIAFKOOBA(JKGBAPEDMGJ JGEMMJEFOMN, JKGBAPEDMGJ LDJCBIBELIM, RigidTransform LENANFGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F040", Offset = "0x6B8DA40", VA = "0x186B8F040")]
	private void FBPMIAFALBA(GJJPJLAFENF IDOMJKBDODC, JKGBAPEDMGJ GMLGNLBKHFJ, GJJPJLAFENF IPEPHOJIFNP, GJJPJLAFENF FIMGMAIGKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DC40", Offset = "0x6B8C640", VA = "0x186B8DC40")]
	private void CBPABIPLPHF(GJJPJLAFENF IDOMJKBDODC, JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ HKDOFPMCHOC, JKGBAPEDMGJ MKEMFFOAONA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OFMGFDMHAML
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DCBFLNFAPCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JEFLJDHAGDI container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public DCBFLNFAPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6B89FD0", Offset = "0x6B889D0", VA = "0x186B89FD0")]
		internal JEINCLLFPMP IKLPOLNHFIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B99400", Offset = "0x6B97E00", VA = "0x186B99400")]
	public static void EAPLAPAFJKI(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6B99580", Offset = "0x6B97F80", VA = "0x186B99580")]
	public static void GGCHANDPBKN(JEFLJDHAGDI EOPOOELIKIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class EGDABLAKIMG : OFIPACJDOMA, GNPNNILMOKC
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly JEINCLLFPMP AKOIMNMLALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly EGPPLLIHJFC BNPDFEHMEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FOCEFOJIINF GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly BOPEIAPFBDN[] OHKDDJEHKPC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GJJPJLAFENF BKJDJDPGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(GJJPJLAFENF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JKGBAPEDMGJ JPADHLKOAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BE50", Offset = "0x6B8A850", VA = "0x186B8BE50", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JKGBAPEDMGJ DACAMIEIMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A680", Offset = "0x6B89080", VA = "0x186B8A680", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 LOHKPOHDCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B380", Offset = "0x6B89D80", VA = "0x186B8B380", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion BLEJECJIKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A370", Offset = "0x6B88D70", VA = "0x186B8A370", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NHHPDLIBFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B550", Offset = "0x6B89F50", VA = "0x186B8B550", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<JKGBAPEDMGJ> CONBKKDKINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A460", Offset = "0x6B88E60", VA = "0x186B8A460", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool HJLNKMDBIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAC0340", Offset = "0xABED40", VA = "0x180AC0340", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC6A3C0", Offset = "0xC68DC0", VA = "0x180C6A3C0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform MJIIFCFMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C060", Offset = "0x6B8AA60", VA = "0x186B8C060", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject MNAAHCNCEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2710B00", Offset = "0x270F500", VA = "0x182710B00", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BD80", Offset = "0x6B8A780", VA = "0x186B8BD80", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid JBNKBFFELBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BEB0", Offset = "0x6B8A8B0", VA = "0x186B8BEB0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OJMIGIPMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BF90", Offset = "0x6B8A990", VA = "0x186B8BF90", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DGGOHFNNKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool BMDLPLLHIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6B8ABB0", Offset = "0x6B895B0", VA = "0x186B8ABB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event BDCGJCECBFG GMDDJFGICFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A5D0", Offset = "0x6B88FD0", VA = "0x186B8A5D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B8A0", Offset = "0x6B8A2A0", VA = "0x186B8B8A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event BDCGJCECBFG JFAKCDCIKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AB50", Offset = "0x6B89550", VA = "0x186B8AB50", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B900", Offset = "0x6B8A300", VA = "0x186B8B900", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BDCGJCECBFG DJBOFBPJEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AC00", Offset = "0x6B89600", VA = "0x186B8AC00", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A3D0", Offset = "0x6B88DD0", VA = "0x186B8A3D0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event BGNCBNDOMLJ BDHFAPMGKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A490", Offset = "0x6B88E90", VA = "0x186B8A490", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A2D0", Offset = "0x6B88CD0", VA = "0x186B8A2D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BC80", Offset = "0x6B8A680", VA = "0x186B8BC80")]
	public EGDABLAKIMG(GJJPJLAFENF CFIHBJLNKJE, RigidbodyEx IOHJIPHILJI, EGPPLLIHJFC BNPDFEHMEBG, BOPEIAPFBDN[] OHKDDJEHKPC, FOCEFOJIINF GDGJPCNEJIO, FHIOCBHJNHK AKOIMNMLALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A430", Offset = "0x6B88E30", VA = "0x186B8A430", Slot = "19")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "21")]
	public void EAEIGHAMGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69E7980", Offset = "0x69E6380", VA = "0x1869E7980", Slot = "22")]
	public void EADKCDFFBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B500", Offset = "0x6B89F00", VA = "0x186B8B500", Slot = "20")]
	public void LHKIFFPBGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B170", Offset = "0x6B89B70", VA = "0x186B8B170", Slot = "25")]
	public void IHOABJMDLCB(int EDGBEJEFBGH, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B3E0", Offset = "0x6B89DE0", VA = "0x186B8B3E0", Slot = "26")]
	public void KAIGONABNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B5C0", Offset = "0x6B89FC0", VA = "0x186B8B5C0", Slot = "27")]
	public void MPNBIPBGGIF(int EDGBEJEFBGH, JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, [Optional] Vector3? GGECHGICAME, [Optional] Quaternion? OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B960", Offset = "0x6B8A360", VA = "0x186B8B960", Slot = "28")]
	public void OPIPHALAIAA(JKGBAPEDMGJ LJILLNPANEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A740", Offset = "0x6B89140", VA = "0x186B8A740", Slot = "31")]
	public void FMEBJOPCKPJ(Vector3 IANHBKPCOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AE60", Offset = "0x6B89860", VA = "0x186B8AE60", Slot = "29")]
	public void IHBFBOHFMNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B9E0", Offset = "0x6B8A3E0", VA = "0x186B8B9E0", Slot = "30")]
	public void PMLHFFEDBLB(int HGFDMIDEFHN, Vector3 NJELOECLOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AD90", Offset = "0x6B89790", VA = "0x186B8AD90", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int EDGBEJEFBGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AC60", Offset = "0x6B89660", VA = "0x186B8AC60", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int EDGBEJEFBGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x922DF0", Offset = "0x9217F0", VA = "0x180922DF0", Slot = "42")]
	public Color GetConnectionSlotColor(int EDGBEJEFBGH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A530", Offset = "0x6B88F30", VA = "0x186B8A530", Slot = "43")]
	public bool CanConnectTo(int EDGBEJEFBGH, JKGBAPEDMGJ MNHIMAMNOGH, int HGIANKMFMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "44")]
	public void ParentChanged(int EDGBEJEFBGH, JKGBAPEDMGJ BFFHMJOANDP, int CLLLKNBHIOD, Vector3 AKIGBGKKGPC, Quaternion GFEAIBJDDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "45")]
	public void ChildAdded(int EDGBEJEFBGH, JKGBAPEDMGJ OGIFFMPCHPO, int BKFNHEIKLGC, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "46")]
	public void ChildRemoved(int EDGBEJEFBGH, JKGBAPEDMGJ HJDDBIIOGKG, int DHNPBBBBBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "47")]
	public void ConnectionModified(int EDGBEJEFBGH, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BBE0", Offset = "0x6B8A5E0", VA = "0x186B8BBE0", Slot = "48")]
	public void RootChanged(JKGBAPEDMGJ ICMPCEMAEJP, JKGBAPEDMGJ ELIKAFIKJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A630", Offset = "0x6B89030", VA = "0x186B8A630", Slot = "23")]
	public void EEAOAODDHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A6F0", Offset = "0x6B890F0", VA = "0x186B8A6F0", Slot = "24")]
	public void FELAMAHGMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B4B0", Offset = "0x6B89EB0", VA = "0x186B8B4B0")]
	private void LDKAICGMJDA(bool BLGOCELJPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AODOHJCIOJB(typeof(BHCONKAFAIG), new string[] { })]
public class OEBALIHMHFF : BHCONKAFAIG, KINLAMFGOOC
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FOPDGHLLJHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public OEBALIHMHFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PLFGOKCIKHG localIds;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FOPDGHLLJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C580", Offset = "0x6B8AF80", VA = "0x186B8C580")]
		internal void LGBBIHFGOCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[GGBOHIFGDPB]
	private OJKEJOIGBJA JANHEKCDHCN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object COFINOAJIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6B99140", Offset = "0x6B97B40", VA = "0x186B99140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B99340", Offset = "0x6B97D40", VA = "0x186B99340", Slot = "6")]
	public void InitReferences(GOMDDPLFKLJ KKAHGNKMLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B991D0", Offset = "0x6B97BD0", VA = "0x186B991D0", Slot = "5")]
	public void IPDGDAAEALJ(PLFGOKCIKHG DKJJBNFOMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public OEBALIHMHFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AODOHJCIOJB(typeof(FHIOCBHJNHK), new string[] { "Ignore", "Mock" })]
public class JLNKIBPJMLH : FHIOCBHJNHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IPGOGDBCELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6B91FD0", Offset = "0x6B909D0", VA = "0x186B91FD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6B91E70", Offset = "0x6B90870", VA = "0x186B91E70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6B91F20", Offset = "0x6B90920", VA = "0x186B91F20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6B92080", Offset = "0x6B90A80", VA = "0x186B92080", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6B91DC0", Offset = "0x6B907C0", VA = "0x186B91DC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6B91D10", Offset = "0x6B90710", VA = "0x186B91D10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "12")]
	public void AIFHKOLJDOL(GameObject MNKAGJEGJCF, HHDPMFKBGKA GHLGDEIDHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "13")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "14")]
	public void JJJMHPMEAIK(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "15")]
	public void KEAJIFAKOEB(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "16")]
	public void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGGMGCFCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "17")]
	public void DOIDPFJPGHL(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ NNJPJBJGPIA, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "18")]
	public void LJKIHEEOAEA(JKGBAPEDMGJ GMLGNLBKHFJ, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "19")]
	public void BKEPMFGDDNJ(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "20")]
	public PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "21")]
	public PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "22")]
	public bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "23")]
	public void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "24")]
	public void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "25")]
	public void IMEFKEPJNOP(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public JLNKIBPJMLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JKGBAPEDMGJ : GNPNNILMOKC, IEquatable<JKGBAPEDMGJ>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GNPNNILMOKC
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JKGBAPEDMGJ JPADHLKOAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform MJIIFCFMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject MNAAHCNCEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid JBNKBFFELBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int OJMIGIPMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	GJJPJLAFENF BKJDJDPGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DGGOHFNNKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int EDGBEJEFBGH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int EDGBEJEFBGH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int EDGBEJEFBGH);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int EDGBEJEFBGH, JKGBAPEDMGJ MNHIMAMNOGH, int FKKMLOBPIJC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int EDGBEJEFBGH, JKGBAPEDMGJ BFFHMJOANDP, int CLLLKNBHIOD, Vector3 AKIGBGKKGPC, Quaternion GFEAIBJDDAE);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int EDGBEJEFBGH, JKGBAPEDMGJ OGIFFMPCHPO, int BKFNHEIKLGC, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int EDGBEJEFBGH, JKGBAPEDMGJ HJDDBIIOGKG, int DHNPBBBBBFK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int EDGBEJEFBGH, JKGBAPEDMGJ PALJEDCNNHB, int PMLPEPHIDPM, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(JKGBAPEDMGJ ICMPCEMAEJP, JKGBAPEDMGJ ELIKAFIKJIO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[FMCCJGKNHAK(IIIIPAKMKHE.OMRoom)]
public interface FHIOCBHJNHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IPGOGDBCELH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AIFHKOLJDOL(GameObject MNKAGJEGJCF, HHDPMFKBGKA GHLGDEIDHDM);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KOLHFLEMELG();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JJJMHPMEAIK(JKGBAPEDMGJ GMLGNLBKHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KEAJIFAKOEB(JKGBAPEDMGJ GMLGNLBKHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGGMGCFCNKM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DOIDPFJPGHL(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ NNJPJBJGPIA, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LJKIHEEOAEA(JKGBAPEDMGJ GMLGNLBKHFJ, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BKEPMFGDDNJ(JKGBAPEDMGJ GMLGNLBKHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IMEFKEPJNOP(PHAOBOBOLNJ BDFEFAPJDHE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KINGIDJGNNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DMIFGEPFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKGBAPEDMGJ GJMJHICGPEH(int AIJLAMCPGBD);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKGBAPEDMGJ BIJCGIMPKOC(Guid HHFBLGLBAFM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IIGONIELMFB(JKGBAPEDMGJ GMLGNLBKHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MLAFPFCADFM();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKJJPFGKECL(JKGBAPEDMGJ BNPDFEHMEBG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FMCCJGKNHAK(IIIIPAKMKHE.Application)]
public interface FOCEFOJIINF
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMDLPLLHIGM(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJJMIBEEKAE(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MMNNMIFPMID(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PCEIOMLDDPC(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NCGKLJEDPIM(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JMEGINAFJJF(EGPPLLIHJFC BNPDFEHMEBG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void BDCGJCECBFG(JKGBAPEDMGJ LJILLNPANEE, int DKGAKFIOBAB, JKGBAPEDMGJ PALJEDCNNHB, int JHALJPEJOEN, [Optional] Vector3? GGECHGICAME, [Optional] Quaternion? OKBBDAFCHNJ);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void BGNCBNDOMLJ(JKGBAPEDMGJ ICMPCEMAEJP, JKGBAPEDMGJ ELIKAFIKJIO);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EGPPLLIHJFC : JKGBAPEDMGJ, GNPNNILMOKC, IEquatable<JKGBAPEDMGJ>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OFIPACJDOMA : GNPNNILMOKC
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JKGBAPEDMGJ DACAMIEIMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<JKGBAPEDMGJ> CONBKKDKINP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 LOHKPOHDCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion BLEJECJIKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NHHPDLIBFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool HJLNKMDBIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event BDCGJCECBFG GMDDJFGICFB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event BDCGJCECBFG JFAKCDCIKGC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event BDCGJCECBFG DJBOFBPJEJF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event BGNCBNDOMLJ BDHFAPMGKLH;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BPMACNMHMCK();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LHKIFFPBGID();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EAEIGHAMGMI();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EADKCDFFBEM();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EEAOAODDHPD();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FELAMAHGMPL();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IHOABJMDLCB(int EDGBEJEFBGH, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KAIGONABNNN();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MPNBIPBGGIF(int EDGBEJEFBGH, JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, [Optional] Vector3? GGECHGICAME, [Optional] Quaternion? OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OPIPHALAIAA(JKGBAPEDMGJ LJILLNPANEE);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IHBFBOHFMNM();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PMLHFFEDBLB(int HGFDMIDEFHN, Vector3 NJELOECLOIL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FMEBJOPCKPJ(Vector3 IANHBKPCOAF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BOPEIAPFBDN
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 FHFHKGKODEL
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
public interface HHDPMFKBGKA
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OIBAJCLPOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FNMMPAFJNAP IFAKPMDKKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, HHDPMFKBGKA
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
			[Cpp2IlInjected.Address(RVA = "0xAC0390", Offset = "0xABED90", VA = "0x180AC0390", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FNMMPAFJNAP LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6B89580", Offset = "0x6B87F80", VA = "0x186B89580")]
		public static ConnectableConfigData MAHEJLCNCLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6B89640", Offset = "0x6B88040", VA = "0x186B89640")]
		public ConnectableConfigData(LegacyConnectableLinkVisual ANHAOHHOLPJ, bool HCPJKJGIHMN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HDHAHFKGGAI : IEquatable<HDHAHFKGGAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JKGBAPEDMGJ GMLGNLBKHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int IFGAAGJBJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int PMLPEPHIDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 GGECHGICAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion OKBBDAFCHNJ;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B8CD40", Offset = "0x6B8B740", VA = "0x186B8CD40")]
	public HDHAHFKGGAI(JKGBAPEDMGJ GMLGNLBKHFJ, int IFGAAGJBJJB, int PMLPEPHIDPM, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6B8CC20", Offset = "0x6B8B620", VA = "0x186B8CC20")]
	public HDHAHFKGGAI(JKGBAPEDMGJ GMLGNLBKHFJ, int IFGAAGJBJJB, int PMLPEPHIDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6B8CCC0", Offset = "0x6B8B6C0", VA = "0x186B8CCC0")]
	public HDHAHFKGGAI(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C7B0", Offset = "0x6B8B1B0", VA = "0x186B8C7B0", Slot = "4")]
	public bool Equals(HDHAHFKGGAI PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C860", Offset = "0x6B8B260", VA = "0x186B8C860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class IKNDKGEGBPA : LCEKIFGAPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform FLDLBOHKNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private FNMMPAFJNAP NLNNAEIEIMP;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6690760", Offset = "0x668F160", VA = "0x186690760", Slot = "4")]
	public void AIFHKOLJDOL(Transform FLDLBOHKNDN, FNMMPAFJNAP NLNNAEIEIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6B8CED0", Offset = "0x6B8B8D0", VA = "0x186B8CED0", Slot = "5")]
	public FNMMPAFJNAP IPINNKBKDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6B8CE60", Offset = "0x6B8B860", VA = "0x186B8CE60", Slot = "6")]
	public void ABGMIDFNOAD(FNMMPAFJNAP EGLPALGNHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public IKNDKGEGBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KLPICNFJMCM : IDisposable, ACAGJKBHNFN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HIFJPGLGEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JKGBAPEDMGJ oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JKGBAPEDMGJ newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HIFJPGLGEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6B8CDA0", Offset = "0x6B8B7A0", VA = "0x186B8CDA0")]
		internal bool JEAKKBDFPKF(KPEPDKLILEK node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly OBLEHAGJMML CCMBPPAOJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private KBOPNBNCEJG DCLKOGBCAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PAFAJCKFCAE NMPHPKABOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool HCPJKJGIHMN;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly CMICIECANPG AGBJIKKEMAD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KPEPDKLILEK GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6B93F30", Offset = "0x6B92930", VA = "0x186B93F30")]
	public bool OILDKDGNOMB([In] GILOHHMHLLN JGCMECODHDI, bool BCNPKHABFBL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6B94090", Offset = "0x6B92A90", VA = "0x186B94090")]
	private bool FHMKDCBGJNC([In] GILOHHMHLLN JGCMECODHDI, bool BCNPKHABFBL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6B954D0", Offset = "0x6B93ED0", VA = "0x186B954D0")]
	public KLPICNFJMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6B92320", Offset = "0x6B90D20", VA = "0x186B92320", Slot = "5")]
	public void AIFHKOLJDOL(FHIOCBHJNHK EHABNPPLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6B92DA0", Offset = "0x6B917A0", VA = "0x186B92DA0", Slot = "17")]
	public void CCGECIHNNFJ(BODHOPONGMF JMKAJHCEDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6B94860", Offset = "0x6B93260", VA = "0x186B94860", Slot = "12")]
	public void HCPJLGBFCBP(Func<JKGBAPEDMGJ, bool> KHEBOEENKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6B94730", Offset = "0x6B93130", VA = "0x186B94730")]
	private void HCPJLGBFCBP(OBLEHAGJMML KOHLOCENPAH, Func<JKGBAPEDMGJ, bool> KHEBOEENKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6B93F40", Offset = "0x6B92940", VA = "0x186B93F40", Slot = "11")]
	public void ENOKKHKKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6B93F60", Offset = "0x6B92960", VA = "0x186B93F60", Slot = "8")]
	public bool FABGBKCDGJF(JKGBAPEDMGJ MHEJCKDLEJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6B923B0", Offset = "0x6B90DB0", VA = "0x186B923B0")]
	private bool AOHKJKBHJJC(JKGBAPEDMGJ NDCGGBMNCJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6B948D0", Offset = "0x6B932D0", VA = "0x186B948D0")]
	private static bool KFPLCLGHBNB(JKGBAPEDMGJ NDCGGBMNCJO, OBLEHAGJMML OFPOMHJBMCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6B939E0", Offset = "0x6B923E0", VA = "0x186B939E0")]
	private void DHCDMMKANMA(Transform CHOOGBCBHHH, OBLEHAGJMML PAFGKIFMBJM, OBLEHAGJMML[] GFOAHFPJBDL, JKGBAPEDMGJ DKNHKFJKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6B92E30", Offset = "0x6B91830", VA = "0x186B92E30")]
	private HDHAHFKGGAI CGNJKIJDDPF(Transform PPHMGNDPCFN, HDHAHFKGGAI PFBLDLHKFBJ)
	{
		return default(HDHAHFKGGAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6B95140", Offset = "0x6B93B40", VA = "0x186B95140")]
	private static bool NPMFGIKGKJM(OBLEHAGJMML OFPOMHJBMCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6B92DD0", Offset = "0x6B917D0", VA = "0x186B92DD0", Slot = "9")]
	public bool CEJEPBILKOJ(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6B931C0", Offset = "0x6B91BC0", VA = "0x186B931C0")]
	private bool CIHJDKLDNML(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6B92AB0", Offset = "0x6B914B0", VA = "0x186B92AB0")]
	private static void BDOIGGFHCDE(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ, OBLEHAGJMML BFMLFHGNNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6B93F70", Offset = "0x6B92970", VA = "0x186B93F70")]
	private void FEFENLFBMED(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6B94FA0", Offset = "0x6B939A0", VA = "0x186B94FA0")]
	private void LHINCDJBDHI(OBLEHAGJMML KOHLOCENPAH, JKGBAPEDMGJ HKDOFPMCHOC, JKGBAPEDMGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6B94F30", Offset = "0x6B93930", VA = "0x186B94F30")]
	private void LHINCDJBDHI(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ HKDOFPMCHOC, JKGBAPEDMGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6B92C30", Offset = "0x6B91630", VA = "0x186B92C30")]
	private void CBPABIPLPHF(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ HKDOFPMCHOC, JKGBAPEDMGJ MKEMFFOAONA, bool IMCDJBIPJDI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6B92CA0", Offset = "0x6B916A0", VA = "0x186B92CA0")]
	private void CBPABIPLPHF(OBLEHAGJMML JPBBEMPIGCM, JKGBAPEDMGJ DKNHKFJKLGH, JKGBAPEDMGJ ELIKAFIKJIO, bool IMCDJBIPJDI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6B92130", Offset = "0x6B90B30", VA = "0x186B92130")]
	private void ADKEMFADIAA(JKGBAPEDMGJ JGEMMJEFOMN, int OCAKALCKIMO, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6B937B0", Offset = "0x6B921B0", VA = "0x186B937B0")]
	private void CPPIPLFLDFD(KPEPDKLILEK LDJCBIBELIM, KPEPDKLILEK PIAKJOABJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6B93DD0", Offset = "0x6B927D0", VA = "0x186B93DD0", Slot = "18")]
	public JKGBAPEDMGJ DHHFLPBDCJB(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6B93410", Offset = "0x6B91E10", VA = "0x186B93410", Slot = "13")]
	public void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGBFBJAMNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6B92F80", Offset = "0x6B91980", VA = "0x186B92F80", Slot = "14")]
	public List<JKGBAPEDMGJ> CHGBHBABLKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6B92250", Offset = "0x6B90C50", VA = "0x186B92250")]
	protected KPEPDKLILEK AFKMNCHAENA(KPEPDKLILEK KOHLOCENPAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B94650", Offset = "0x6B93050", VA = "0x186B94650")]
	protected OBLEHAGJMML[] FLHPCELAGKL(OBLEHAGJMML OFPOMHJBMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6B95300", Offset = "0x6B93D00", VA = "0x186B95300")]
	protected bool OFGMLIEIGEG(JKGBAPEDMGJ GMLGNLBKHFJ, [Out] OBLEHAGJMML KOHLOCENPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6B95010", Offset = "0x6B93A10", VA = "0x186B95010", Slot = "15")]
	public bool LJLMHGFHAFD(JKGBAPEDMGJ GMLGNLBKHFJ, [Out] HDHAHFKGGAI PHKLAKHNMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6B946F0", Offset = "0x6B930F0", VA = "0x186B946F0")]
	protected OBLEHAGJMML GPCOEFNOHPP(HDHAHFKGGAI AKOGPFLNHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6B94870", Offset = "0x6B93270", VA = "0x186B94870", Slot = "10")]
	public bool IAFBMCBELLL(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6B94980", Offset = "0x6B93380", VA = "0x186B94980")]
	private bool KGFFNKLACEE(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6B93910", Offset = "0x6B92310", VA = "0x186B93910")]
	private static bool DCDNGKIOMBD(OBLEHAGJMML KOPFLCFHELE, HDHAHFKGGAI HNJPAPDIGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6B93F30", Offset = "0x6B92930", VA = "0x186B93F30", Slot = "7")]
	private bool EEDHBEGNDMM([In] GILOHHMHLLN JGCMECODHDI, bool BCNPKHABFBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class ABKIOLMPIAK : FHIOCBHJNHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly JEFLJDHAGDI EOPOOELIKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly PAFAJCKFCAE NMPHPKABOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly FOGILIDAFJL ODDLIEAOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly PKAMOJILALE CPHOOKBAPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly ACAGJKBHNFN BDFEFAPJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal FFAFDAGJCFB GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal MEBBLNOINLC BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal KBOPNBNCEJG PKNAKFGJENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool HCPJKJGIHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool GMEFPBOPBHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GJDFIKPHMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB7D040", Offset = "0xB7BA40", VA = "0x180B7D040")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1CB80D0", Offset = "0x1CB6AD0", VA = "0x181CB80D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xB7D030", Offset = "0xB7BA30", VA = "0x180B7D030", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1CB80C0", Offset = "0x1CB6AC0", VA = "0x181CB80C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IPGOGDBCELH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6B88850", Offset = "0x6B87250", VA = "0x186B88850", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6B88530", Offset = "0x6B86F30", VA = "0x186B88530", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6B886A0", Offset = "0x6B870A0", VA = "0x186B886A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6B88F00", Offset = "0x6B87900", VA = "0x186B88F00", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6B884D0", Offset = "0x6B86ED0", VA = "0x186B884D0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6B876A0", Offset = "0x6B860A0", VA = "0x186B876A0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6B88F60", Offset = "0x6B87960", VA = "0x186B88F60")]
	public ABKIOLMPIAK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6B87700", Offset = "0x6B86100", VA = "0x186B87700", Slot = "12")]
	public void AIFHKOLJDOL(GameObject MNKAGJEGJCF, HHDPMFKBGKA GHLGDEIDHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6B881B0", Offset = "0x6B86BB0", VA = "0x186B881B0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6B88AE0", Offset = "0x6B874E0", VA = "0x186B88AE0", Slot = "13")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6B88980", Offset = "0x6B87380", VA = "0x186B88980", Slot = "14")]
	public void JJJMHPMEAIK(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6B88250", Offset = "0x6B86C50", VA = "0x186B88250", Slot = "15")]
	public void KEAJIFAKOEB(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6B88A00", Offset = "0x6B87400", VA = "0x186B88A00", Slot = "22")]
	public bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6B883F0", Offset = "0x6B86DF0", VA = "0x186B883F0")]
	internal bool FHMKDCBGJNC([In] GILOHHMHLLN JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6B88A50", Offset = "0x6B87450", VA = "0x186B88A50")]
	internal bool KGFFNKLACEE([In] GILOHHMHLLN JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6B889A0", Offset = "0x6B873A0", VA = "0x186B889A0")]
	internal bool JOMEKGBGBBC([In] GILOHHMHLLN JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6B88700", Offset = "0x6B87100", VA = "0x186B88700")]
	internal bool HLNBOEGFJBN([In] GILOHHMHLLN JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6B88C70", Offset = "0x6B87670", VA = "0x186B88C70")]
	internal void MNBNFKCHBPI(JKGBAPEDMGJ GMLGNLBKHFJ, int DIHDLGJMOHO, bool BCNPKHABFBL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6B88250", Offset = "0x6B86C50", VA = "0x186B88250")]
	internal bool EAIMCMPINGC(JKGBAPEDMGJ HPFINHLPMLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6B882B0", Offset = "0x6B86CB0", VA = "0x186B882B0")]
	internal bool FEGEECKDOKF(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6B87EA0", Offset = "0x6B868A0", VA = "0x186B87EA0", Slot = "16")]
	public void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGGMGCFCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6B87FA0", Offset = "0x6B869A0", VA = "0x186B87FA0", Slot = "17")]
	public void DOIDPFJPGHL(JKGBAPEDMGJ BNNBHPJIPAL, JKGBAPEDMGJ NNJPJBJGPIA, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6B88B30", Offset = "0x6B87530", VA = "0x186B88B30", Slot = "18")]
	public void LJKIHEEOAEA(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6B87CD0", Offset = "0x6B866D0", VA = "0x186B87CD0", Slot = "19")]
	public void BKEPMFGDDNJ(JKGBAPEDMGJ LDDIOHEAPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6B88590", Offset = "0x6B86F90", VA = "0x186B88590")]
	public void HALOCGIBBLH([Optional] FKHHMLJBCHF MANOCABBPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6B888F0", Offset = "0x6B872F0", VA = "0x186B888F0", Slot = "23")]
	public void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6B884B0", Offset = "0x6B86EB0", VA = "0x186B884B0", Slot = "20")]
	public PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6B87680", Offset = "0x6B86080", VA = "0x186B87680", Slot = "21")]
	public PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6B888B0", Offset = "0x6B872B0", VA = "0x186B888B0", Slot = "25")]
	public void IMEFKEPJNOP(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6B88E50", Offset = "0x6B87850", VA = "0x186B88E50", Slot = "24")]
	public void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class PAFAJCKFCAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly LLEJOEJOMJB<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly LLEJOEJOMJB<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly MFOJMBEOKED<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6B99710", Offset = "0x6B98110", VA = "0x186B99710")]
	public PAFAJCKFCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	public void AIFHKOLJDOL(ABKIOLMPIAK EHABNPPLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6B996B0", Offset = "0x6B980B0", VA = "0x186B996B0")]
	public void PNIGHCHOHAD(JKGBAPEDMGJ LDJCBIBELIM, JKGBAPEDMGJ JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6B995D0", Offset = "0x6B97FD0", VA = "0x186B995D0")]
	public void IPLEKPDNJIJ(JKGBAPEDMGJ LDJCBIBELIM, JKGBAPEDMGJ JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6B99630", Offset = "0x6B98030", VA = "0x186B99630")]
	public void MEEKBPIMKPN(JKGBAPEDMGJ DNBOOMFENIJ, JKGBAPEDMGJ LEEMAEKICLM, JKGBAPEDMGJ JGEMMJEFOMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FOGILIDAFJL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private ABKIOLMPIAK EHABNPPLNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private MEBBLNOINLC BPCHJLBHPKH;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public FOGILIDAFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C1B0", Offset = "0x6B8ABB0", VA = "0x186B8C1B0")]
	public void AIFHKOLJDOL(ABKIOLMPIAK EHABNPPLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C3E0", Offset = "0x6B8ADE0", VA = "0x186B8C3E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C560", Offset = "0x6B8AF60", VA = "0x186B8C560")]
	private void LMIGIHMKGBE(FKHHMLJBCHF JDDNDMPDAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C3F0", Offset = "0x6B8ADF0", VA = "0x186B8C3F0")]
	private void KJEDPAEBLIJ(FKHHMLJBCHF ECDFEGAFAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C460", Offset = "0x6B8AE60", VA = "0x186B8C460")]
	public void LFBHDFGIJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C2E0", Offset = "0x6B8ACE0", VA = "0x186B8C2E0")]
	public void CBKGFFDIPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KPHAPFIENCP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ILIPALECFKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JEFLJDHAGDI container;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ILIPALECFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6B8CFA0", Offset = "0x6B8B9A0", VA = "0x186B8CFA0")]
		internal ABKIOLMPIAK IKLPOLNHFIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6B956A0", Offset = "0x6B940A0", VA = "0x186B956A0")]
	public static void EAPLAPAFJKI(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6B958A0", Offset = "0x6B942A0", VA = "0x186B958A0")]
	public static void GGCHANDPBKN(JEFLJDHAGDI EOPOOELIKIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class MAJOMBJGPEJ : IDisposable, KBOPNBNCEJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, FNMMPAFJNAP> PCPNGGGLOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BODHOPONGMF IMNKDOHDGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private LCEKIFGAPCG BNJJIPLFCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private ACAGJKBHNFN BDFEFAPJDHE;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6B98500", Offset = "0x6B96F00", VA = "0x186B98500")]
	public MAJOMBJGPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6B97980", Offset = "0x6B96380", VA = "0x186B97980", Slot = "7")]
	public void AIFHKOLJDOL(ACAGJKBHNFN BDFEFAPJDHE, LCEKIFGAPCG BNJJIPLFCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6B97A90", Offset = "0x6B96490", VA = "0x186B97A90", Slot = "5")]
	public void CMHJMDKDLFB(KPEPDKLILEK ECKPCDCMHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6B97CD0", Offset = "0x6B966D0", VA = "0x186B97CD0", Slot = "9")]
	public void CPLFJDDMMCC(KPEPDKLILEK KBNFBKEMDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6B97FF0", Offset = "0x6B969F0", VA = "0x186B97FF0", Slot = "8")]
	public void FNOOEHMLIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6B981B0", Offset = "0x6B96BB0", VA = "0x186B981B0", Slot = "10")]
	public void OEFGAAAGCKO(KPEPDKLILEK JECMHPEPOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6B979C0", Offset = "0x6B963C0", VA = "0x186B979C0", Slot = "11")]
	public void CLCNNEEFBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6B97E40", Offset = "0x6B96840", VA = "0x186B97E40")]
	private bool FMBEAOBHICE(KPEPDKLILEK ODPGHJEEHCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class PKAMOJILALE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct DALCJLFELKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly OBLEHAGJMML PMDAEJKCPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> MCDFALIBDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly BHLNHBCANEC MFFAFHAKJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly BHLNHBCANEC PMLBOLPFHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool ILAOOODHNBG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool LJLOADEMIKH
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6B89690", Offset = "0x6B88090", VA = "0x186B89690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6B89F60", Offset = "0x6B88960", VA = "0x186B89F60")]
		public DALCJLFELKD(OBLEHAGJMML PMDAEJKCPDF, HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG, [Optional] BHLNHBCANEC MFFAFHAKJIE, [Optional] BHLNHBCANEC PMLBOLPFHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6B897B0", Offset = "0x6B881B0", VA = "0x186B897B0")]
		public BHLNHBCANEC AMCHBAGBIFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6B89CE0", Offset = "0x6B886E0", VA = "0x186B89CE0")]
		private BHLNHBCANEC INEIOCHLIDA([Out] BHLNHBCANEC ICMBCFIFFLO, [Out] BHLNHBCANEC BIKBCFNNHOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6B89950", Offset = "0x6B88350", VA = "0x186B89950")]
		private BHLNHBCANEC DDMCPIHMGEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6B89B70", Offset = "0x6B88570", VA = "0x186B89B70")]
		private void GNJIHMKMMJD(BHLNHBCANEC NDPILDBMCLH, BHLNHBCANEC FDHCBBKCJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6B89DA0", Offset = "0x6B887A0", VA = "0x186B89DA0")]
		private void LLMGOMNENGC(BHLNHBCANEC ICMBCFIFFLO, BHLNHBCANEC BIKBCFNNHOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private ABKIOLMPIAK EHABNPPLNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private ACAGJKBHNFN BDFEFAPJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private KBOPNBNCEJG DCLKOGBCAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private MEBBLNOINLC BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool ODIKBJFCDNB;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool IBLJOFBLDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6B9C680", Offset = "0x6B9B080", VA = "0x186B9C680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool GJDFIKPHMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6B9B400", Offset = "0x6B99E00", VA = "0x186B9B400")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6B9B3E0", Offset = "0x6B99DE0", VA = "0x186B9B3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6B99EC0", Offset = "0x6B988C0", VA = "0x186B99EC0")]
	public void AIFHKOLJDOL(ABKIOLMPIAK EHABNPPLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6B9AB50", Offset = "0x6B99550", VA = "0x186B9AB50")]
	public PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6B99830", Offset = "0x6B98230", VA = "0x186B99830")]
	public PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B420", Offset = "0x6B99E20", VA = "0x186B9B420")]
	public void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C6D0", Offset = "0x6B9B0D0", VA = "0x186B9C6D0")]
	public void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C770", Offset = "0x6B9B170", VA = "0x186B9C770")]
	public void PIFHNAJLACM(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6B9BCB0", Offset = "0x6B9A6B0", VA = "0x186B9BCB0")]
	private void KPOHEOFAHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6B9A330", Offset = "0x6B98D30", VA = "0x186B9A330")]
	private BHLNHBCANEC CCFLNMOJIAB(OBLEHAGJMML KOHLOCENPAH, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6B9A8E0", Offset = "0x6B992E0", VA = "0x186B9A8E0")]
	private static void FABFPBCIDGL(OBLEHAGJMML KOHLOCENPAH, bool ILAOOODHNBG, BHLNHBCANEC GANDHMGOAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B4B0", Offset = "0x6B99EB0", VA = "0x186B9B4B0")]
	private void KANKIDAMIKB(OBLEHAGJMML KOHLOCENPAH, bool ILAOOODHNBG, BHLNHBCANEC GANDHMGOAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6B9A2A0", Offset = "0x6B98CA0", VA = "0x186B9A2A0")]
	private BHLNHBCANEC BOPEDIABKKD(OBLEHAGJMML PMDAEJKCPDF, HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6B9A650", Offset = "0x6B99050", VA = "0x186B9A650")]
	private bool DAFJJEBJMPB(PHAOBOBOLNJ IPEEJDIIKEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6B9BEA0", Offset = "0x6B9A8A0", VA = "0x186B9BEA0")]
	private bool LMAFBIFMOJA(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6B9AB30", Offset = "0x6B99530", VA = "0x186B9AB30")]
	private bool FGKLLOGMGGM(PHAOBOBOLNJ BDFEFAPJDHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6B99F30", Offset = "0x6B98930", VA = "0x186B99F30")]
	private static bool AOOHGDGJDCJ(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B6D0", Offset = "0x6B9A0D0", VA = "0x186B9B6D0")]
	public static bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B960", Offset = "0x6B9A360", VA = "0x186B9B960")]
	private JKGBAPEDMGJ KOENKONHBKO(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B0D0", Offset = "0x6B99AD0", VA = "0x186B9B0D0")]
	private JKGBAPEDMGJ GJMJHICGPEH(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6B9B250", Offset = "0x6B99C50", VA = "0x186B9B250")]
	private JKGBAPEDMGJ IFGBDFIJLMC(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EDA0", Offset = "0x6B8D7A0", VA = "0x186B8EDA0")]
	private static Guid EJNIJLINDPP(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6B9A560", Offset = "0x6B98F60", VA = "0x186B9A560")]
	private string CPDJIHPFIKP(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6B9C500", Offset = "0x6B9AF00", VA = "0x186B9C500")]
	private bool NPKFIHJAPGB(OBLEHAGJMML KOHLOCENPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6B9A040", Offset = "0x6B98A40", VA = "0x186B9A040")]
	private static void BHLEFLNBNBH(OBLEHAGJMML PMDAEJKCPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public PKAMOJILALE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct GILOHHMHLLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public JKGBAPEDMGJ JGEMMJEFOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public JKGBAPEDMGJ LDJCBIBELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int OCAKALCKIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int PPGHOBGEOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 GGECHGICAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion OKBBDAFCHNJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HDHAHFKGGAI KIDJIBFMGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C670", Offset = "0x6B8B070", VA = "0x186B8C670")]
		get
		{
			return default(HDHAHFKGGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HDHAHFKGGAI HOPABIEBMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C710", Offset = "0x6B8B110", VA = "0x186B8C710")]
		get
		{
			return default(HDHAHFKGGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C740", Offset = "0x6B8B140", VA = "0x186B8C740")]
	public GILOHHMHLLN(JKGBAPEDMGJ JGEMMJEFOMN, JKGBAPEDMGJ LDJCBIBELIM, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface ACAGJKBHNFN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KPEPDKLILEK GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIFHKOLJDOL(FHIOCBHJNHK EHABNPPLNPG);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OILDKDGNOMB([In] GILOHHMHLLN JGCMECODHDI, bool BCNPKHABFBL = true);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FABGBKCDGJF(JKGBAPEDMGJ MHEJCKDLEJM);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CEJEPBILKOJ(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IAFBMCBELLL(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ENOKKHKKMCA();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HCPJLGBFCBP(Func<JKGBAPEDMGJ, bool> KHEBOEENKHI);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGBFBJAMNHE);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<JKGBAPEDMGJ> CHGBHBABLKL();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LJLMHGFHAFD(JKGBAPEDMGJ GMLGNLBKHFJ, [Out] HDHAHFKGGAI PHKLAKHNMNL);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CCGECIHNNFJ(BODHOPONGMF JMKAJHCEDCI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool BODHOPONGMF(KPEPDKLILEK KOHLOCENPAH);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KPEPDKLILEK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JKGBAPEDMGJ KEPFPNKIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KPEPDKLILEK NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HDHAHFKGGAI OHEPLKGPIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NBPJNOCMAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FNMMPAFJNAP : MIGGNMFODMK.KHDFJDKCGNC
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLGEKNOMHA(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCCINAJCPJF(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMNCLKHLEIM(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABGOPMFAOBD(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FNMMPAFJNAP Instantiate(Transform FLDLBOHKNDN);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGDCKPANMGG();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LCEKIFGAPCG
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIFHKOLJDOL(Transform FLDLBOHKNDN, FNMMPAFJNAP NLNNAEIEIMP);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNMMPAFJNAP IPINNKBKDNN();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABGMIDFNOAD(FNMMPAFJNAP EGLPALGNHHA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FFAFDAGJCFB : KINGIDJGNNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OGPIBIKOHCA(Guid HDMMLBENEIG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface KBOPNBNCEJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMHJMDKDLFB(KPEPDKLILEK ECKPCDCMHGF);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIFHKOLJDOL(ACAGJKBHNFN BDFEFAPJDHE, LCEKIFGAPCG FLJOHEIPLLG);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNOOEHMLIKM();

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPLFJDDMMCC(KPEPDKLILEK KBNFBKEMDBM);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEFGAAAGCKO(KPEPDKLILEK JECMHPEPOMP);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CLCNNEEFBAO();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class OBLEHAGJMML : KPEPDKLILEK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FMMMFMEBCEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public HDHAHFKGGAI nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OBLEHAGJMML foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FMMMFMEBCEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C080", Offset = "0x6B8AA80", VA = "0x186B8C080")]
		internal bool NOFFKDGGCCN(KPEPDKLILEK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private HDHAHFKGGAI PHKLAKHNMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<OBLEHAGJMML> FGHOHFEKFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private OBLEHAGJMML APDDILPGCOD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public HDHAHFKGGAI OHEPLKGPIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3AB7540", Offset = "0x3AB5F40", VA = "0x183AB7540", Slot = "6")]
		get
		{
			return default(HDHAHFKGGAI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6B988A0", Offset = "0x6B972A0", VA = "0x186B988A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private OBLEHAGJMML LDJCBIBELIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B988F0", Offset = "0x6B972F0", VA = "0x186B988F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KPEPDKLILEK NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JKGBAPEDMGJ KEPFPNKIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NBPJNOCMAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6B989D0", Offset = "0x6B973D0", VA = "0x186B989D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IBCNPGKMFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6B989E0", Offset = "0x6B973E0", VA = "0x186B989E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected OBLEHAGJMML JPBBEMPIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6B988D0", Offset = "0x6B972D0", VA = "0x186B988D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6B99090", Offset = "0x6B97A90", VA = "0x186B99090")]
	public OBLEHAGJMML(HDHAHFKGGAI OIICFAFOFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B985E0", Offset = "0x6B96FE0", VA = "0x186B985E0")]
	public OBLEHAGJMML BHLBCINICIP(HDHAHFKGGAI KPOKPKMMFBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B98B30", Offset = "0x6B97530", VA = "0x186B98B30")]
	public OBLEHAGJMML GPMKONEBJLL(HDHAHFKGGAI DNBPBHCKJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6B98CB0", Offset = "0x6B976B0", VA = "0x186B98CB0")]
	public OBLEHAGJMML MBEEDABKNGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6B98E90", Offset = "0x6B97890", VA = "0x186B98E90")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B98FE0", Offset = "0x6B979E0", VA = "0x186B98FE0")]
	public OBLEHAGJMML PCODOFGDAIF(HDHAHFKGGAI LEEMAEKICLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B98740", Offset = "0x6B97140", VA = "0x186B98740")]
	private static void CCGECIHNNFJ(OBLEHAGJMML GKPPEDCAFOG, BODHOPONGMF OPLFDLOEKLI, bool PMGGOLDJHKI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B98730", Offset = "0x6B97130", VA = "0x186B98730", Slot = "9")]
	public void CCGECIHNNFJ(BODHOPONGMF JMKAJHCEDCI, bool IMCDJBIPJDI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B98A30", Offset = "0x6B97430", VA = "0x186B98A30")]
	public static OBLEHAGJMML GPCOEFNOHPP(OBLEHAGJMML GKPPEDCAFOG, HDHAHFKGGAI KMBGLJBDLMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface MEBBLNOINLC
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IBLJOFBLDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DMIFGEPFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<FKHHMLJBCHF> LMIGIHMKGBE;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<FKHHMLJBCHF> KJEDPAEBLIJ;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(ABKIOLMPIAK EHABNPPLNPG);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(JKGBAPEDMGJ BNNBHPJIPAL, JKGBAPEDMGJ NNJPJBJGPIA, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(PHAOBOBOLNJ NDPAKEFCAAD, [Optional] FKHHMLJBCHF MANOCABBPEE);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, MEBBLNOINLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private ABKIOLMPIAK EHABNPPLNPG;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool IBLJOFBLDGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x6B97600", Offset = "0x6B96000", VA = "0x186B97600", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool DMIFGEPFKNN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6B97660", Offset = "0x6B96060", VA = "0x186B97660", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<FKHHMLJBCHF> LMIGIHMKGBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6B97560", Offset = "0x6B95F60", VA = "0x186B97560", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6B97740", Offset = "0x6B96140", VA = "0x186B97740", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<FKHHMLJBCHF> KJEDPAEBLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6B974C0", Offset = "0x6B95EC0", VA = "0x186B974C0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6B976A0", Offset = "0x6B960A0", VA = "0x186B976A0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x899AB0", Offset = "0x8984B0", VA = "0x180899AB0", Slot = "19")]
		public void SetManager(ABKIOLMPIAK EHABNPPLNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B97490", Offset = "0x6B95E90", VA = "0x186B97490")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B96210", Offset = "0x6B94C10", VA = "0x186B96210", Slot = "23")]
		public void RequestMasterConnectNodes(JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B96340", Offset = "0x6B94D40", VA = "0x186B96340", Slot = "24")]
		public void RequestMasterDisconnectNode(JKGBAPEDMGJ MHEJCKDLEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B96400", Offset = "0x6B94E00", VA = "0x186B96400", Slot = "20")]
		public void RequestMasterModifyNode(JKGBAPEDMGJ BNNBHPJIPAL, JKGBAPEDMGJ NNJPJBJGPIA, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B96530", Offset = "0x6B94F30", VA = "0x186B96530", Slot = "21")]
		public void RequestMasterReparentNodes(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B96660", Offset = "0x6B95060", VA = "0x186B96660", Slot = "25")]
		public void RequestMasterReparentToRoot(JKGBAPEDMGJ LDDIOHEAPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6B960E0", Offset = "0x6B94AE0", VA = "0x186B960E0", Slot = "22")]
		public void RequestDeserializeConnectableGraph(PHAOBOBOLNJ NDPAKEFCAAD, [Optional] FKHHMLJBCHF MANOCABBPEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6B96A40", Offset = "0x6B95440", VA = "0x186B96A40")]
		[CALMNHBOCBN]
		private void RpcMasterConnectNodes(JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6B96D00", Offset = "0x6B95700", VA = "0x186B96D00")]
		[CALMNHBOCBN]
		private void RpcMasterDisconnectNode(JKGBAPEDMGJ MHEJCKDLEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6B97040", Offset = "0x6B95A40", VA = "0x186B97040")]
		[CALMNHBOCBN]
		private void RpcMasterReparentNodes(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B96E40", Offset = "0x6B95840", VA = "0x186B96E40")]
		[CALMNHBOCBN]
		private void RpcMasterModifyNode(JKGBAPEDMGJ BNNBHPJIPAL, JKGBAPEDMGJ NNJPJBJGPIA, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6B96830", Offset = "0x6B95230", VA = "0x186B96830")]
		[CALMNHBOCBN]
		private void RpcConnectNodes(JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ, ANNBFJKOLHL CPHDIHMBDPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6B969B0", Offset = "0x6B953B0", VA = "0x186B969B0")]
		[CALMNHBOCBN]
		private void RpcDisconnectNode(JKGBAPEDMGJ MHEJCKDLEJM, ANNBFJKOLHL CPHDIHMBDPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6B97390", Offset = "0x6B95D90", VA = "0x186B97390")]
		[CALMNHBOCBN]
		private void RpcReparentNodes(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ, ANNBFJKOLHL CPHDIHMBDPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6B972D0", Offset = "0x6B95CD0", VA = "0x186B972D0")]
		[CALMNHBOCBN]
		private void RpcModifyNode(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ, ANNBFJKOLHL CPHDIHMBDPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6B96970", Offset = "0x6B95370", VA = "0x186B96970")]
		[CALMNHBOCBN]
		private void RpcDeserializeConnectableGraph(PHAOBOBOLNJ BDFEFAPJDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4270", Offset = "0x8B2C70", VA = "0x1808B4270")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, FNMMPAFJNAP, MIGGNMFODMK.KHDFJDKCGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6B95C80", Offset = "0x6B94680", VA = "0x186B95C80", Slot = "4")]
		private void JMCFJKOJONG(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B95E70", Offset = "0x6B94870", VA = "0x186B95E70", Slot = "5")]
		private void PHDNLHNMKFG(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6B95920", Offset = "0x6B94320", VA = "0x186B95920", Slot = "6")]
		private void BGPBOPDPCOF(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B95A30", Offset = "0x6B94430", VA = "0x186B95A30", Slot = "7")]
		private void CKAOIJHAIBL(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6B95E00", Offset = "0x6B94800", VA = "0x186B95E00", Slot = "8")]
		private FNMMPAFJNAP KKHFECLIPKC(Transform FLDLBOHKNDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6B95C20", Offset = "0x6B94620", VA = "0x186B95C20", Slot = "9")]
		private void GDNLIDPLGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NNKBLPFCFIO
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2EFCEE0", Offset = "0x2EFB8E0", VA = "0x182EFCEE0")]
	public static NANBFBCLJBB<T> IMOIHLJDLKI<T>(this JEFLJDHAGDI EOPOOELIKIH)
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
