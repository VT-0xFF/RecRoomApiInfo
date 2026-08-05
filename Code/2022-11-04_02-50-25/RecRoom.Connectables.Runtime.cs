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
public class OKBCBGPKDDP : OGAOCEOMAJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Transform ENMFIMJMMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OCFAONBDMGG GLPEMPMNOOI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x38582D0", Offset = "0x38576D0", VA = "0x1838582D0", Slot = "4")]
	public void PAICICMJOCE(Transform ENMFIMJMMCO, OCFAONBDMGG GLPEMPMNOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x513C720", Offset = "0x513BB20", VA = "0x18513C720", Slot = "5")]
	public OCFAONBDMGG DLAKCDEKCLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public OKBCBGPKDDP()
	{
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AFAPMPFKDID(JCDEPCAPNFC.Connectables, new string[] { "Notifications", "AuthoredParentAndLocalPose", "Requests", "SetRbexParent" })]
	public sealed class OMConnectableManager : MLJCENAGGMH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class HBCBKFOLGPH : IEnumerable<ADNIFANBLMG>, IEnumerable, IEnumerator<ADNIFANBLMG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private ADNIFANBLMG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private HOGBEFGIKOI localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HOGBEFGIKOI <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OMConnectableManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private IANFCDGCLMD <objects>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private KEIDHOKKPCI.EGPKFFCJIDA <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private ADNIFANBLMG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8DF410", Offset = "0x8DE810", VA = "0x1808DF410")]
			[DebuggerHidden]
			public HBCBKFOLGPH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x512A7B0", Offset = "0x5129BB0", VA = "0x18512A7B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x512A390", Offset = "0x5129790", VA = "0x18512A390", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x512A810", Offset = "0x5129C10", VA = "0x18512A810")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x512A770", Offset = "0x5129B70", VA = "0x18512A770", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x512A6C0", Offset = "0x5129AC0", VA = "0x18512A6C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ADNIFANBLMG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x512A6C0", Offset = "0x5129AC0", VA = "0x18512A6C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const string OPPIHIKOJGP = "Notifications";

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string OEHOICIGLAI = "AuthoredParentAndLocalPose";

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const string IDHCNANGLAB = "Requests";

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const string CBDFHDBALGN = "SetRbexParent";

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly EHNHFGEGKKP ILMBAOEGHMC;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly EHNHFGEGKKP DGJGNAHIBOH;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly EHNHFGEGKKP EAGGIONLCHA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly EHNHFGEGKKP BNCNLFKDKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JGEBPOEEGMC KJFOJHNOMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private AKIKBDADLPE NDBEPEANOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private IKBLODFNMGN OENDHJEKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private GCIJLHJDMDE MPGGBHGCIIP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const int DMBAMPJKKHH = 0;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const int GPJPBBAHPOC = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly MNCBLPIJNJN KMGLINHGLGG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EMADIPGMFIL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9EDB40", Offset = "0x9ECF40", VA = "0x1809EDB40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9EDCE0", Offset = "0x9ED0E0", VA = "0x1809EDCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<ADNIFANBLMG, ADNIFANBLMG> GIBKPEBKICM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x513FCB0", Offset = "0x513F0B0", VA = "0x18513FCB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x513C9D0", Offset = "0x513BDD0", VA = "0x18513C9D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ADNIFANBLMG, ADNIFANBLMG> LFHAKPEJMMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x513D700", Offset = "0x513CB00", VA = "0x18513D700", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x513E630", Offset = "0x513DA30", VA = "0x18513E630", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<ADNIFANBLMG, ADNIFANBLMG, ADNIFANBLMG> DJMLAPGHOEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x513FC10", Offset = "0x513F010", VA = "0x18513FC10", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x513D660", Offset = "0x513CA60", VA = "0x18513D660", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5141AD0", Offset = "0x5140ED0", VA = "0x185141AD0")]
		public OMConnectableManager(KADOJAOKIOP PKBPIIAEHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5140DA0", Offset = "0x51401A0", VA = "0x185140DA0", Slot = "11")]
		public void PAICICMJOCE(GameObject MGDBDEJKIMA, ICINCCNJKOB IAJJLMEFDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x513E430", Offset = "0x513D830", VA = "0x18513E430", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x513E420", Offset = "0x513D820", VA = "0x18513E420", Slot = "22")]
		public bool DLBLPPJADLG(JNJBEPHOMLC DOHEFJFBJHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5141690", Offset = "0x5140A90", VA = "0x185141690")]
		private void PKDLMHMNLGP(HOGBEFGIKOI FGKBDHHNKGG, HOGBEFGIKOI ILMJDMECFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5141380", Offset = "0x5140780", VA = "0x185141380")]
		private void PKBKCNOCMMB(HOGBEFGIKOI FGKBDHHNKGG, HOGBEFGIKOI NFONDMKGKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x513E060", Offset = "0x513D460", VA = "0x18513E060")]
		private void DGGPEKNKHKH(HOGBEFGIKOI FGKBDHHNKGG, HOGBEFGIKOI NFONDMKGKFB, HOGBEFGIKOI ILMJDMECFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x513EE70", Offset = "0x513E270", VA = "0x18513EE70")]
		private void IGBEEHLLKDO(HOGBEFGIKOI FGKBDHHNKGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "12")]
		public void ADDBGNGPEPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x513FE50", Offset = "0x513F250", VA = "0x18513FE50", Slot = "13")]
		public void MGGHGLFMIKB(ADNIFANBLMG JDCLMDIOIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x513F430", Offset = "0x513E830", VA = "0x18513F430", Slot = "14")]
		public void IMEDOJDENFA(ADNIFANBLMG JDCLMDIOIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x513D230", Offset = "0x513C630", VA = "0x18513D230", Slot = "16")]
		public void BCECDMDGEEA(ADNIFANBLMG JDCLMDIOIDO, ADNIFANBLMG MODCHHNILJE, Vector3 CFOIIIPLIFA, Quaternion HKBDKOEBLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x513D480", Offset = "0x513C880", VA = "0x18513D480")]
		public void BCECDMDGEEA(HOGBEFGIKOI MIJGFFHMOFJ, HOGBEFGIKOI MODCHHNILJE, Vector3 CFOIIIPLIFA, Quaternion HKBDKOEBLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5140570", Offset = "0x513F970", VA = "0x185140570", Slot = "17")]
		public void MPKPCNJJMPL(ADNIFANBLMG AAEFACKANCI, int MLNNHIJFDKO, ADNIFANBLMG ABPOMMNNEIE, int DKPGEMLLBMP, Vector3 CFOIIIPLIFA, Quaternion HKBDKOEBLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51407A0", Offset = "0x513FBA0", VA = "0x1851407A0")]
		public void MPKPCNJJMPL(HOGBEFGIKOI MIJGFFHMOFJ, HOGBEFGIKOI BLENCGKHIJI, Vector3 CFOIIIPLIFA, Quaternion HKBDKOEBLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5140810", Offset = "0x513FC10", VA = "0x185140810", Slot = "18")]
		public void NNPEMMNCAHG(ADNIFANBLMG JDCLMDIOIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5140A60", Offset = "0x513FE60", VA = "0x185140A60", Slot = "19")]
		public bool ONIPFENLGCO(ADNIFANBLMG JDCLMDIOIDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5140B50", Offset = "0x513FF50", VA = "0x185140B50")]
		public bool ONIPFENLGCO(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x513F510", Offset = "0x513E910", VA = "0x18513F510", Slot = "15")]
		public void JLAEBDHFMFK(ADNIFANBLMG JDCLMDIOIDO, HashSet<ADNIFANBLMG> OKNKKPJGONH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "20")]
		public FAOLKGCCFCO GJFOKBBGKNE(bool DLAIAOLOEEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "21")]
		public FAOLKGCCFCO LFGDNCBEOCN(HashSet<Guid> KMIMGBHFDNI, bool DLAIAOLOEEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x513F7E0", Offset = "0x513EBE0", VA = "0x18513F7E0", Slot = "23")]
		public void KIAFELJMDHD(FAOLKGCCFCO NFPCELBFMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x513FDE0", Offset = "0x513F1E0", VA = "0x18513FDE0", Slot = "24")]
		public void MBLONGEDPNP(FAOLKGCCFCO NFPCELBFMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x513F410", Offset = "0x513E810", VA = "0x18513F410", Slot = "25")]
		public void ILEBLJDJIDL(FAOLKGCCFCO NFPCELBFMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x513DCD0", Offset = "0x513D0D0", VA = "0x18513DCD0")]
		private void COBFHCKNGED(HOGBEFGIKOI MIJGFFHMOFJ, HOGBEFGIKOI BLENCGKHIJI, Vector3 CFOIIIPLIFA, Quaternion HKBDKOEBLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x513D7A0", Offset = "0x513CBA0", VA = "0x18513D7A0")]
		private void CIDGMOKDIHB(HOGBEFGIKOI MIJGFFHMOFJ, HOGBEFGIKOI GIJFJALMMOL, Vector3 CFOIIIPLIFA, Quaternion HKBDKOEBLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x513C900", Offset = "0x513BD00", VA = "0x18513C900")]
		private void ACIFIBCPDKN(HOGBEFGIKOI MIJGFFHMOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x513FD50", Offset = "0x513F150", VA = "0x18513FD50")]
		[IteratorStateMachine(typeof(HBCBKFOLGPH))]
		public IEnumerable<ADNIFANBLMG> MBHGNFPLJBA(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5140190", Offset = "0x513F590", VA = "0x185140190")]
		internal ADNIFANBLMG MOFOGADHCMG(HOGBEFGIKOI DCJOMJHHEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x513EB80", Offset = "0x513DF80", VA = "0x18513EB80")]
		internal HOGBEFGIKOI HAOPAHLBONF(ADNIFANBLMG JDCLMDIOIDO)
		{
			return default(HOGBEFGIKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x513CC00", Offset = "0x513C000", VA = "0x18513CC00")]
		private bool AOBMAMHAMOC(JNJBEPHOMLC DOHEFJFBJHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5140A00", Offset = "0x513FE00", VA = "0x185140A00")]
		private bool OMNMAFDEGEK(JNJBEPHOMLC DOHEFJFBJHP, out ADNIFANBLMG BLENCGKHIJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5140210", Offset = "0x513F610", VA = "0x185140210")]
		private ADNIFANBLMG MOFOGADHCMG(JNJBEPHOMLC DOHEFJFBJHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x513ECD0", Offset = "0x513E0D0", VA = "0x18513ECD0")]
		private ADNIFANBLMG IBCIBGCEEJN(JNJBEPHOMLC DOHEFJFBJHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x513CA70", Offset = "0x513BE70", VA = "0x18513CA70")]
		private ADNIFANBLMG AMIOHJMLFMA(JNJBEPHOMLC DOHEFJFBJHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x51313A0", Offset = "0x51307A0", VA = "0x1851313A0")]
		private static Guid HGFMBFDCJCH(JNJBEPHOMLC DOHEFJFBJHP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x513FB30", Offset = "0x513EF30", VA = "0x18513FB30")]
		private string LCAKDNOLJDL(JNJBEPHOMLC DOHEFJFBJHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x51411F0", Offset = "0x51405F0", VA = "0x1851411F0")]
		private void PBGAKAGIOHP(ADNIFANBLMG MIJGFFHMOFJ, ADNIFANBLMG GIJFJALMMOL, RigidTransform NCCEOCJPPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x513E6D0", Offset = "0x513DAD0", VA = "0x18513E6D0")]
		private void FHBLNEMEDML(ADNIFANBLMG GIJFJALMMOL, ADNIFANBLMG MIJGFFHMOFJ, RigidTransform NCCEOCJPPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x513EC70", Offset = "0x513E070", VA = "0x18513EC70")]
		private void HOHGLBNDMHD(ADNIFANBLMG JMCOICNPJLH, ADNIFANBLMG MIJGFFHMOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x513C770", Offset = "0x513BB70", VA = "0x18513C770")]
		private void AAEMBJEFAKH(ADNIFANBLMG MIJGFFHMOFJ, ADNIFANBLMG BLENCGKHIJI, RigidTransform NCCEOCJPPCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x513F850", Offset = "0x513EC50", VA = "0x18513F850")]
		private void KPFBIOCPNEG(HOGBEFGIKOI DCJOMJHHEFE, ADNIFANBLMG JDCLMDIOIDO, HOGBEFGIKOI NFONDMKGKFB, HOGBEFGIKOI ILMJDMECFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x513E860", Offset = "0x513DC60", VA = "0x18513E860")]
		private void FNHMOJPGNMC(HOGBEFGIKOI DCJOMJHHEFE, ADNIFANBLMG JDCLMDIOIDO, ADNIFANBLMG PFCOAFNMKBO, ADNIFANBLMG DCMIHJECFPJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BMPALKDNJEH
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ALCJDNLJGNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KADOJAOKIOP container;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public ALCJDNLJGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5127C20", Offset = "0x5127020", VA = "0x185127C20")]
		internal OMConnectableManager <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5127D30", Offset = "0x5127130", VA = "0x185127D30")]
	public static void PHNPGLAIJMM(KADOJAOKIOP PKBPIIAEHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5127CC0", Offset = "0x51270C0", VA = "0x185127CC0")]
	public static void OMDAEOAIIDA(KADOJAOKIOP PKBPIIAEHNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OGOPEHOAPNE : AAHPJLIOLPO, JLGBCOPPDCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly RigidbodyEx EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly OMConnectableManager LBDCOBNCHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HFPHPAFGLIH HIBKGPKPEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HKEGPKPGBAL OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly POGGCGJDBIE[] GAEAJFCFFHJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HOGBEFGIKOI EPIGHCONBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x12092F0", Offset = "0x12086F0", VA = "0x1812092F0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(HOGBEFGIKOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ADNIFANBLMG LOIBLGOMFDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ADNIFANBLMG HNACJFAFIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x513C4E0", Offset = "0x513B8E0", VA = "0x18513C4E0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ADNIFANBLMG GNOAIAPLMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x513C190", Offset = "0x513B590", VA = "0x18513C190", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 ALCCGKNBJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x513A850", Offset = "0x5139C50", VA = "0x18513A850", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion OJLAABHFBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x513A920", Offset = "0x5139D20", VA = "0x18513A920", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FCPDFBKBCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x513AB20", Offset = "0x5139F20", VA = "0x18513AB20", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<ADNIFANBLMG> LFLEBNEAELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x513B2A0", Offset = "0x513A6A0", VA = "0x18513B2A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool GHLNEGIHMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9EDB40", Offset = "0x9ECF40", VA = "0x1809EDB40", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9EDCE0", Offset = "0x9ED0E0", VA = "0x1809EDCE0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x513C700", Offset = "0x513BB00", VA = "0x18513C700", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject PNKCHCINMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x513C470", Offset = "0x513B870", VA = "0x18513C470", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string AKILJOLADBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x513C490", Offset = "0x513B890", VA = "0x18513C490", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid GMPDHDCLBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x513C5D0", Offset = "0x513B9D0", VA = "0x18513C5D0", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DOGCAAIBKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x513C6B0", Offset = "0x513BAB0", VA = "0x18513C6B0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool INFIONGAKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool AMJOOKPHJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x513AB40", Offset = "0x5139F40", VA = "0x18513AB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event AFPOCEEJEGD GOFEFOJNIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x513C280", Offset = "0x513B680", VA = "0x18513C280", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x513AAD0", Offset = "0x5139ED0", VA = "0x18513AAD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event AFPOCEEJEGD DPELFNFHDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x513A990", Offset = "0x5139D90", VA = "0x18513A990", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x513AA80", Offset = "0x5139E80", VA = "0x18513AA80", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event AFPOCEEJEGD DDNPICOHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x513B340", Offset = "0x513A740", VA = "0x18513B340", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x513BFE0", Offset = "0x513B3E0", VA = "0x18513BFE0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event PHOCHPKFKNM LPNJCHKCCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x513BF40", Offset = "0x513B340", VA = "0x18513BF40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x513C2D0", Offset = "0x513B6D0", VA = "0x18513C2D0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x513C390", Offset = "0x513B790", VA = "0x18513C390")]
	public OGOPEHOAPNE(HOGBEFGIKOI ODKPHBBMMPO, RigidbodyEx EIOOACKMMIN, HFPHPAFGLIH HIBKGPKPEBN, POGGCGJDBIE[] GAEAJFCFFHJ, HKEGPKPGBAL OENDHJEKNMI, MLJCENAGGMH LBDCOBNCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "20")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "22")]
	public void HHLFJFIAFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x513B3F0", Offset = "0x513A7F0", VA = "0x18513B3F0", Slot = "23")]
	public void GGJOJFCKHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x513BE20", Offset = "0x513B220", VA = "0x18513BE20", Slot = "21")]
	public void KIFBCELFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x513AB90", Offset = "0x5139F90", VA = "0x18513AB90", Slot = "26")]
	public void EGGAJMEIDHB(int FEKPNEPEMJP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x513C090", Offset = "0x513B490", VA = "0x18513C090", Slot = "27")]
	public void NOCDHICFOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x513ADE0", Offset = "0x513A1E0", VA = "0x18513ADE0", Slot = "28")]
	public void ENGMHBGKPAC(int FEKPNEPEMJP, ADNIFANBLMG AAEFACKANCI, int ANKFJJGOFPP, [Optional] Vector3? CHCAAFBNLDC, [Optional] Quaternion? JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x513C110", Offset = "0x513B510", VA = "0x18513C110", Slot = "29")]
	public void OBDPJMBJFNA(ADNIFANBLMG AAEFACKANCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x513BA20", Offset = "0x513AE20", VA = "0x18513BA20", Slot = "32")]
	public void KCOLBCFMPPL(Vector3 GPAPPICBGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x513B760", Offset = "0x513AB60", VA = "0x18513B760", Slot = "30")]
	public void KAMMLMPJMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x513B100", Offset = "0x513A500", VA = "0x18513B100", Slot = "31")]
	public void EPKEGIEFOJK(int PGFOAHEHPOH, Vector3 DDPAJGCOAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x513B630", Offset = "0x513AA30", VA = "0x18513B630", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int FEKPNEPEMJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x513B4F0", Offset = "0x513A8F0", VA = "0x18513B4F0", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int FEKPNEPEMJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x174E850", Offset = "0x174DC50", VA = "0x18174E850", Slot = "43")]
	public Color GetConnectionSlotColor(int FEKPNEPEMJP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x513A9E0", Offset = "0x5139DE0", VA = "0x18513A9E0", Slot = "44")]
	public bool CanConnectTo(int FEKPNEPEMJP, ADNIFANBLMG MJCOACCOOBK, int MDBEPNEBBDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "45")]
	public void ParentChanged(int FEKPNEPEMJP, ADNIFANBLMG EBOEEGHEGEP, int LBFEJPMOINI, Vector3 FIJIACOBAFI, Quaternion IGGBIIMPLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "46")]
	public void ChildAdded(int FEKPNEPEMJP, ADNIFANBLMG KPPKBPJNEBI, int OOIMGDDPNNA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "47")]
	public void ChildRemoved(int FEKPNEPEMJP, ADNIFANBLMG GLLNIFEHPEE, int NFMEOJHLNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "48")]
	public void ConnectionModified(int FEKPNEPEMJP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x513C370", Offset = "0x513B770", VA = "0x18513C370", Slot = "49")]
	public void RootChanged(ADNIFANBLMG CBKMGHIHBCM, ADNIFANBLMG HLDBDJPOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x513BE90", Offset = "0x513B290", VA = "0x18513BE90")]
	public bool KPLPCHPLAID(ADNIFANBLMG BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x513B390", Offset = "0x513A790", VA = "0x18513B390", Slot = "24")]
	public void FOBJIHIDKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x513C030", Offset = "0x513B430", VA = "0x18513C030", Slot = "25")]
	public void NIOMDFBGMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x513B700", Offset = "0x513AB00", VA = "0x18513B700")]
	private void IMGMHBAGOAD(bool LEIINKJOMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x513A8C0", Offset = "0x5139CC0", VA = "0x18513A8C0")]
	private RigidbodyEx AOFPPAGKBEO(ADNIFANBLMG HIBKGPKPEBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[BGGFAGPLFND(typeof(OMFDKPDAEMN), new string[] { })]
public class FCOBMFDAFDA : OMFDKPDAEMN, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[GPKJCAPOIDC]
	private EFLFKJPCKHG OENDHJEKNMI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object AABBMPBJHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5128FB0", Offset = "0x51283B0", VA = "0x185128FB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5129050", Offset = "0x5128450", VA = "0x185129050", Slot = "6")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5128ED0", Offset = "0x51282D0", VA = "0x185128ED0", Slot = "5")]
	public void AMDBGJGAFNB(KEIDHOKKPCI EMDHJBJJOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public FCOBMFDAFDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BGGFAGPLFND(typeof(MLJCENAGGMH), new string[] { "Ignore", "Mock" })]
public class GLKOPIGDFPN : MLJCENAGGMH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EMADIPGMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<ADNIFANBLMG, ADNIFANBLMG> GIBKPEBKICM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x51293C0", Offset = "0x51287C0", VA = "0x1851293C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x51290A0", Offset = "0x51284A0", VA = "0x1851290A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<ADNIFANBLMG, ADNIFANBLMG> LFHAKPEJMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x51291E0", Offset = "0x51285E0", VA = "0x1851291E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5129280", Offset = "0x5128680", VA = "0x185129280", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<ADNIFANBLMG, ADNIFANBLMG, ADNIFANBLMG> DJMLAPGHOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5129320", Offset = "0x5128720", VA = "0x185129320", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5129140", Offset = "0x5128540", VA = "0x185129140", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "11")]
	public void PAICICMJOCE(GameObject MGDBDEJKIMA, ICINCCNJKOB IAJJLMEFDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "12")]
	public void ADDBGNGPEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "13")]
	public void MGGHGLFMIKB(ADNIFANBLMG JDCLMDIOIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "14")]
	public void IMEDOJDENFA(ADNIFANBLMG JDCLMDIOIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "15")]
	public void JLAEBDHFMFK(ADNIFANBLMG JDCLMDIOIDO, HashSet<ADNIFANBLMG> OKNKKPJGONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "16")]
	public void BCECDMDGEEA(ADNIFANBLMG JDCLMDIOIDO, ADNIFANBLMG MODCHHNILJE, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "17")]
	public void MPKPCNJJMPL(ADNIFANBLMG JDCLMDIOIDO, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "18")]
	public void NNPEMMNCAHG(ADNIFANBLMG JDCLMDIOIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "19")]
	public bool ONIPFENLGCO(ADNIFANBLMG JDCLMDIOIDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "20")]
	public FAOLKGCCFCO GJFOKBBGKNE(bool DLAIAOLOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "21")]
	public FAOLKGCCFCO LFGDNCBEOCN(HashSet<Guid> KMIMGBHFDNI, bool DLAIAOLOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "22")]
	public bool DLBLPPJADLG(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "23")]
	public void KIAFELJMDHD(FAOLKGCCFCO NFPCELBFMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "24")]
	public void MBLONGEDPNP(FAOLKGCCFCO NFPCELBFMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "25")]
	public void ILEBLJDJIDL(FAOLKGCCFCO NFPCELBFMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public GLKOPIGDFPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NMNKLLFDJNC : JEBFHFMFMAD, OCFAONBDMGG, IDisposable
{
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConnectableLinkVisual : MonoBehaviour, NMNKLLFDJNC, JEBFHFMFMAD, OCFAONBDMGG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Entity NMHBGKPCHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Entity FLBPEPNFBOA;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity FKLNGPMBIOB
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "20")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x15E0860", Offset = "0x15DFC60", VA = "0x1815E0860", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Entity GDBKGABBGGD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0", Slot = "11")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x14C5510", Offset = "0x14C4910", VA = "0x1814C5510", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5128050", Offset = "0x5127450", VA = "0x185128050", Slot = "4")]
		private void DLFAJGFGFFJ(ADNIFANBLMG ABPOMMNNEIE, OCOPOCAAGLH MIJGFFHMOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5128250", Offset = "0x5127650", VA = "0x185128250", Slot = "5")]
		private void HPFADDAMGIP(ADNIFANBLMG ABPOMMNNEIE, OCOPOCAAGLH MIJGFFHMOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5128890", Offset = "0x5127C90", VA = "0x185128890", Slot = "6")]
		private void JOPBPJJIOBK(ADNIFANBLMG ABPOMMNNEIE, OCOPOCAAGLH MIJGFFHMOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x51286B0", Offset = "0x5127AB0", VA = "0x1851286B0", Slot = "7")]
		private void JHLEJCBNHMJ(ADNIFANBLMG ABPOMMNNEIE, OCOPOCAAGLH MIJGFFHMOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5128630", Offset = "0x5127A30", VA = "0x185128630", Slot = "8")]
		private JEBFHFMFMAD IOLBJCPFHFC(Transform ENMFIMJMMCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5127FF0", Offset = "0x51273F0", VA = "0x185127FF0", Slot = "9")]
		private void CAFAHNPKFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5128880", Offset = "0x5127C80", VA = "0x185128880")]
		private void JKDFMHKJMMK(ref Entity KCGBIDJFHLF, Entity PKODKJLGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x51281E0", Offset = "0x51275E0", VA = "0x1851281E0", Slot = "14")]
		private void HOFBGFIMPHI(float3 DDPAJGCOAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5128B00", Offset = "0x5127F00", VA = "0x185128B00", Slot = "13")]
		private void OLPDNLDEGOM(float3 DDPAJGCOAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5128500", Offset = "0x5127900", VA = "0x185128500", Slot = "15")]
		private void IDKGFDPPENA(out float3 BOIMPMGFDJM, out float3 NBODAMBMIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5128110", Offset = "0x5127510", VA = "0x185128110", Slot = "16")]
		private void EKHLJIMAOCJ(float3 BOIMPMGFDJM, float3 NBODAMBMIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x51285D0", Offset = "0x51279D0", VA = "0x1851285D0", Slot = "17")]
		private void IDPEAOBGDMD(Color BOIMPMGFDJM, Color NBODAMBMIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5128A80", Offset = "0x5127E80", VA = "0x185128A80", Slot = "18")]
		private OCFAONBDMGG OJALNLADBDG(Transform ENMFIMJMMCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5128B70", Offset = "0x5127F70", VA = "0x185128B70", Slot = "19")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public ConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ADNIFANBLMG : JLGBCOPPDCE, IEquatable<ADNIFANBLMG>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JLGBCOPPDCE
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	ADNIFANBLMG HNACJFAFIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject PNKCHCINMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string AKILJOLADBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid GMPDHDCLBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int DOGCAAIBKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	HOGBEFGIKOI EPIGHCONBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool INFIONGAKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int FEKPNEPEMJP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int FEKPNEPEMJP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int FEKPNEPEMJP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int FEKPNEPEMJP, ADNIFANBLMG MJCOACCOOBK, int KGKDIFMLJLC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int FEKPNEPEMJP, ADNIFANBLMG EBOEEGHEGEP, int LBFEJPMOINI, Vector3 FIJIACOBAFI, Quaternion IGGBIIMPLCN);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int FEKPNEPEMJP, ADNIFANBLMG KPPKBPJNEBI, int OOIMGDDPNNA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int FEKPNEPEMJP, ADNIFANBLMG GLLNIFEHPEE, int NFMEOJHLNFL);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int FEKPNEPEMJP, ADNIFANBLMG ABPOMMNNEIE, int NBFPPKKLIPK, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(ADNIFANBLMG CBKMGHIHBCM, ADNIFANBLMG HLDBDJPOOBM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[CIKFNDBCLGD(BADKLKEFGCO.OMRoom)]
public interface MLJCENAGGMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EMADIPGMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<ADNIFANBLMG, ADNIFANBLMG> GIBKPEBKICM;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<ADNIFANBLMG, ADNIFANBLMG> LFHAKPEJMMM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<ADNIFANBLMG, ADNIFANBLMG, ADNIFANBLMG> DJMLAPGHOEL;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PAICICMJOCE(GameObject MGDBDEJKIMA, ICINCCNJKOB IAJJLMEFDCJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ADDBGNGPEPF();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MGGHGLFMIKB(ADNIFANBLMG JDCLMDIOIDO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IMEDOJDENFA(ADNIFANBLMG JDCLMDIOIDO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JLAEBDHFMFK(ADNIFANBLMG JDCLMDIOIDO, HashSet<ADNIFANBLMG> OKNKKPJGONH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BCECDMDGEEA(ADNIFANBLMG JDCLMDIOIDO, ADNIFANBLMG MODCHHNILJE, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MPKPCNJJMPL(ADNIFANBLMG JDCLMDIOIDO, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NNPEMMNCAHG(ADNIFANBLMG JDCLMDIOIDO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool ONIPFENLGCO(ADNIFANBLMG JDCLMDIOIDO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FAOLKGCCFCO GJFOKBBGKNE(bool DLAIAOLOEEC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FAOLKGCCFCO LFGDNCBEOCN(HashSet<Guid> KMIMGBHFDNI, bool DLAIAOLOEEC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DLBLPPJADLG(JNJBEPHOMLC DOHEFJFBJHP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KIAFELJMDHD(FAOLKGCCFCO NFPCELBFMGI);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MBLONGEDPNP(FAOLKGCCFCO NFPCELBFMGI);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ILEBLJDJIDL(FAOLKGCCFCO NFPCELBFMGI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IKBLODFNMGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GNOADLCEJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ADNIFANBLMG AMIOHJMLFMA(int ALDBNNFPJFM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ADNIFANBLMG IBCIBGCEEJN(Guid IEMNNBLJPAA);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IFOJJDJCMGD(ADNIFANBLMG JDCLMDIOIDO, out Guid KIDLKIGCBDG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HNBHDIAEFDL(ADNIFANBLMG JDCLMDIOIDO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MEHAOFOBKBP();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHDIDEGIEBA(ADNIFANBLMG HIBKGPKPEBN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CIKFNDBCLGD(BADKLKEFGCO.Application)]
public interface HKEGPKPGBAL
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AMJOOKPHJMA(HFPHPAFGLIH HIBKGPKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KLPOIPNHAIG(HFPHPAFGLIH HIBKGPKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LLEHCHBNIDH(HFPHPAFGLIH HIBKGPKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid FEBEFPCCLNC(HFPHPAFGLIH HIBKGPKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KICCNDKBIPG(HFPHPAFGLIH HIBKGPKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGELOHIOACK(ADNIFANBLMG HIBKGPKPEBN, Action<HPJGDOMBDDL> PNFBJDFDHKF);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BKDGHNJMGJL(ADNIFANBLMG HIBKGPKPEBN, Action<HPJGDOMBDDL> PNFBJDFDHKF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONBJNABDDGJ(HFPHPAFGLIH HIBKGPKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MJJJNIGACGA(HFPHPAFGLIH HIBKGPKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LHDIDEGIEBA(HFPHPAFGLIH HIBKGPKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BIFPDPDDGDL(HFPHPAFGLIH HIBKGPKPEBN, object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NANINNNICOB(HFPHPAFGLIH HIBKGPKPEBN, object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	RigidbodyEx AOFPPAGKBEO(ADNIFANBLMG HIBKGPKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ONAMKHHALIL FBAOBCHPMJH(HFPHPAFGLIH IDEIPFIOJKJ, string MPIADBGKNBD, bool NANCDEAMBKG, LJJHICHHAIE GGOBOPOBKJN, Action EGLKIOCIBPB);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PMCALAEGIPJ(AAHPJLIOLPO PKOBLBEJEGN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void AFPOCEEJEGD(ADNIFANBLMG AAEFACKANCI, int OFKGAIGKLNG, ADNIFANBLMG ABPOMMNNEIE, int EOAAEEFMALK, [Optional] Vector3? CHCAAFBNLDC, [Optional] Quaternion? JADFKALFMOP);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void PHOCHPKFKNM(ADNIFANBLMG CBKMGHIHBCM, ADNIFANBLMG HLDBDJPOOBM);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool NHKEAOEBEJP(int FEKPNEPEMJP, ADNIFANBLMG MJCOACCOOBK, int MDBEPNEBBDB);
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HFPHPAFGLIH : ADNIFANBLMG, JLGBCOPPDCE, IEquatable<ADNIFANBLMG>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	AAHPJLIOLPO FMPGMEEKJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AAHPJLIOLPO : JLGBCOPPDCE
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	ADNIFANBLMG LOIBLGOMFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	ADNIFANBLMG GNOAIAPLMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IEnumerable<ADNIFANBLMG> LFLEBNEAELO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 ALCCGKNBJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Quaternion OJLAABHFBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FCPDFBKBCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool GHLNEGIHMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event AFPOCEEJEGD GOFEFOJNIOJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event AFPOCEEJEGD DPELFNFHDNC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event AFPOCEEJEGD DDNPICOHJBJ;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event PHOCHPKFKNM LPNJCHKCCBN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FHCJDMLKKLF();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KIFBCELFNGG();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HHLFJFIAFEB();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GGJOJFCKHIE();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FOBJIHIDKOA();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NIOMDFBGMED();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EGGAJMEIDHB(int FEKPNEPEMJP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NOCDHICFOFI();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ENGMHBGKPAC(int FEKPNEPEMJP, ADNIFANBLMG AAEFACKANCI, int ANKFJJGOFPP, [Optional] Vector3? CHCAAFBNLDC, [Optional] Quaternion? JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void OBDPJMBJFNA(ADNIFANBLMG AAEFACKANCI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KAMMLMPJMNG();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EPKEGIEFOJK(int PGFOAHEHPOH, Vector3 DDPAJGCOAKM);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KCOLBCFMPPL(Vector3 GPAPPICBGDP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface POGGCGJDBIE
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Vector3 KLKKPNEDIOL
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
public interface ICINCCNJKOB
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FHDBMLOLDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NMNKLLFDJNC DDJGMNCLGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NMNKLLFDJNC JFBNOCPGJIN
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
	public class ConnectableConfigData : ScriptableObject, ICINCCNJKOB
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private ConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private ConnectableLinkVisual objectModelLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x6878D0", Offset = "0x686CD0", VA = "0x1806878D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public NMNKLLFDJNC LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public NMNKLLFDJNC ObjectModelLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5127F00", Offset = "0x5127300", VA = "0x185127F00")]
		public static ConnectableConfigData OHHGONMLELI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5127FA0", Offset = "0x51273A0", VA = "0x185127FA0")]
		public ConnectableConfigData(ConnectableLinkVisual HDOIBNBNBIB, bool PEGDFPMPKBA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OCOPOCAAGLH : IEquatable<OCOPOCAAGLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public ADNIFANBLMG JDCLMDIOIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int HFONCJCNPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int NBFPPKKLIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Vector3 CHCAAFBNLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Quaternion JADFKALFMOP;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x513A7A0", Offset = "0x5139BA0", VA = "0x18513A7A0")]
	public OCOPOCAAGLH(ADNIFANBLMG JDCLMDIOIDO, int HFONCJCNPJH, int NBFPPKKLIPK, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x513A730", Offset = "0x5139B30", VA = "0x18513A730")]
	public OCOPOCAAGLH(ADNIFANBLMG JDCLMDIOIDO, int HFONCJCNPJH, int NBFPPKKLIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x513A800", Offset = "0x5139C00", VA = "0x18513A800")]
	public OCOPOCAAGLH(ADNIFANBLMG JDCLMDIOIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x513A280", Offset = "0x5139680", VA = "0x18513A280", Slot = "4")]
	public bool Equals(OCOPOCAAGLH BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x513A320", Offset = "0x5139720", VA = "0x18513A320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class DDDBHABOFEK : KDKDHJCNFJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Transform ENMFIMJMMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private JEBFHFMFMAD GLPEMPMNOOI;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x38582D0", Offset = "0x38576D0", VA = "0x1838582D0", Slot = "4")]
	public void PAICICMJOCE(Transform ENMFIMJMMCO, JEBFHFMFMAD GLPEMPMNOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5128C20", Offset = "0x5128020", VA = "0x185128C20", Slot = "5")]
	public JEBFHFMFMAD DLAKCDEKCLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5128BD0", Offset = "0x5127FD0", VA = "0x185128BD0", Slot = "6")]
	public void AODPKBMDDNP(JEBFHFMFMAD NPJDFKBNEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public DDDBHABOFEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal class MEDKCBLKJKH : IDisposable, AAAINLNAHIE
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class DPBOIEIBJCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ADNIFANBLMG oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ADNIFANBLMG newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public DPBOIEIBJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5128E10", Offset = "0x5128210", VA = "0x185128E10")]
		internal bool <NotifyRootChangedRecurse>b__0(FEIDPEJCPGD node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly GLLFAMAFOBP NBNFPOLMLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JCIHKEIOKFC JGKDGHHKONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private AJBFFFDLCFA KJICPDPGIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool PEGDFPMPKBA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public FEIDPEJCPGD HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5134E70", Offset = "0x5134270", VA = "0x185134E70")]
	public bool IOFHMOGHCLO(in KNJNHGMNHIO HANEMGLFJMM, bool OKABAHLMEAN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5139020", Offset = "0x5138420", VA = "0x185139020")]
	private bool PAHLHNGLCJF(in KNJNHGMNHIO HANEMGLFJMM, bool OKABAHLMEAN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5135B40", Offset = "0x5134F40", VA = "0x185135B40", Slot = "8")]
	public bool DFJJPFMMLAK(ADNIFANBLMG DLIDKCKPEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5136BE0", Offset = "0x5135FE0", VA = "0x185136BE0")]
	private bool GEDELIEPIKE(ADNIFANBLMG KLFEAHGEHGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5138050", Offset = "0x5137450", VA = "0x185138050")]
	private static bool KHLFOADEHGJ(ADNIFANBLMG KLFEAHGEHGK, GLLFAMAFOBP NPKEINCIJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5134EC0", Offset = "0x51342C0", VA = "0x185134EC0")]
	private void BLFFJHHKIOL(Transform MGLENNFNNLF, GLLFAMAFOBP JDBHAPCAJGJ, GLLFAMAFOBP[] POPHCIKOPAI, ADNIFANBLMG HBLGEPDHNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5139870", Offset = "0x5138C70", VA = "0x185139870")]
	private OCOPOCAAGLH PMEHGGHINKL(Transform AAGGCLNKKIF, OCOPOCAAGLH OHGKAMHGABN)
	{
		return default(OCOPOCAAGLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5138880", Offset = "0x5137C80", VA = "0x185138880")]
	private static bool LLKCPMABCFM(GLLFAMAFOBP NPKEINCIJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x51386E0", Offset = "0x5137AE0", VA = "0x1851386E0")]
	private string LLEHCHBNIDH(ADNIFANBLMG JDCLMDIOIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5138100", Offset = "0x5137500", VA = "0x185138100")]
	private string KICCNDKBIPG(ADNIFANBLMG JDCLMDIOIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5136090", Offset = "0x5135490", VA = "0x185136090")]
	private void EGLFBJNDMDL(in KNJNHGMNHIO HANEMGLFJMM, bool OLELCLABONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5137E80", Offset = "0x5137280", VA = "0x185137E80")]
	private void KCJCDFEFNLC(ADNIFANBLMG MIJGFFHMOFJ, bool OLELCLABONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5138A30", Offset = "0x5137E30", VA = "0x185138A30")]
	private void NPKKIEAFHNC(ADNIFANBLMG GNJCKCGDGAA, int ANKFJJGOFPP, ADNIFANBLMG GIJFJALMMOL, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP, bool OLELCLABONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x51354C0", Offset = "0x51348C0", VA = "0x1851354C0")]
	private void BOFIDJFLDAN(ADNIFANBLMG KHNHLLMFMLA, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP, bool KCBMBMKENBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x51352F0", Offset = "0x51346F0", VA = "0x1851352F0", Slot = "9")]
	public bool BMGEAIANBDC(ADNIFANBLMG KHNHLLMFMLA, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5137780", Offset = "0x5136B80", VA = "0x185137780")]
	private bool JFAAHKHCDOM(ADNIFANBLMG KHNHLLMFMLA, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5137600", Offset = "0x5136A00", VA = "0x185137600")]
	private static void IECOLGIBAOJ(ADNIFANBLMG KHNHLLMFMLA, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP, GLLFAMAFOBP GCPBLCGIHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5139750", Offset = "0x5138B50", VA = "0x185139750")]
	private void PBGAKAGIOHP(ADNIFANBLMG GNJCKCGDGAA, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5138950", Offset = "0x5137D50", VA = "0x185138950")]
	private void MNPPPFLEPNN(GLLFAMAFOBP GIGDHNFIFBE, ADNIFANBLMG PFCOAFNMKBO, ADNIFANBLMG DCMIHJECFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x51389C0", Offset = "0x5137DC0", VA = "0x1851389C0")]
	private void MNPPPFLEPNN(ADNIFANBLMG JDCLMDIOIDO, ADNIFANBLMG PFCOAFNMKBO, ADNIFANBLMG DCMIHJECFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x51369B0", Offset = "0x5135DB0", VA = "0x1851369B0")]
	private void FNHMOJPGNMC(ADNIFANBLMG JDCLMDIOIDO, ADNIFANBLMG PFCOAFNMKBO, ADNIFANBLMG DCMIHJECFPJ, bool FOKIDIOGDBM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5136AD0", Offset = "0x5135ED0", VA = "0x185136AD0")]
	private void FNHMOJPGNMC(GLLFAMAFOBP JAFNHFEOMPI, ADNIFANBLMG HBLGEPDHNBE, ADNIFANBLMG HLDBDJPOOBM, bool FOKIDIOGDBM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x51368A0", Offset = "0x5135CA0", VA = "0x1851368A0")]
	private void FHBLNEMEDML(ADNIFANBLMG MIJGFFHMOFJ, int ANKFJJGOFPP, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x51374A0", Offset = "0x51368A0", VA = "0x1851374A0")]
	private void HOHGLBNDMHD(FEIDPEJCPGD BLENCGKHIJI, FEIDPEJCPGD JAHJJDBGGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5137D50", Offset = "0x5137150", VA = "0x185137D50", Slot = "13")]
	public void KBJPCBJFMPG(ADNIFANBLMG JDCLMDIOIDO, out Vector3 CHCAAFBNLDC, out Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5139620", Offset = "0x5138A20", VA = "0x185139620", Slot = "14")]
	public ADNIFANBLMG PAKCIEJKGDI(ADNIFANBLMG JDCLMDIOIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5137A10", Offset = "0x5136E10", VA = "0x185137A10", Slot = "15")]
	public void JLAEBDHFMFK(ADNIFANBLMG JDCLMDIOIDO, HashSet<ADNIFANBLMG> OBOPDBPMIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x51371C0", Offset = "0x51365C0", VA = "0x1851371C0", Slot = "16")]
	public List<ADNIFANBLMG> HBNEJGFAMHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x51387B0", Offset = "0x5137BB0", VA = "0x1851387B0")]
	protected FEIDPEJCPGD LLKCFGHCGLK(FEIDPEJCPGD GIGDHNFIFBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x51388B0", Offset = "0x5137CB0", VA = "0x1851388B0")]
	protected GLLFAMAFOBP[] MAELCFCJGDG(GLLFAMAFOBP NPKEINCIJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x51367D0", Offset = "0x5135BD0", VA = "0x1851367D0")]
	protected bool EMJBFJAEJCM(ADNIFANBLMG JDCLMDIOIDO, out GLLFAMAFOBP GIGDHNFIFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x51366D0", Offset = "0x5135AD0", VA = "0x1851366D0", Slot = "17")]
	public bool EKLEMHBHFBK(ADNIFANBLMG JDCLMDIOIDO, out OCOPOCAAGLH KPODIGPEMPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5135B00", Offset = "0x5134F00", VA = "0x185135B00")]
	protected GLLFAMAFOBP CODCJPMKNLL(OCOPOCAAGLH CJLBDNNNHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x51353D0", Offset = "0x51347D0", VA = "0x1851353D0", Slot = "10")]
	public bool BOEDFCGLJCD(ADNIFANBLMG GNJCKCGDGAA, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5138190", Offset = "0x5137590", VA = "0x185138190")]
	private bool LIOJOAOGELN(ADNIFANBLMG GNJCKCGDGAA, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x51373D0", Offset = "0x51367D0", VA = "0x1851373D0")]
	private static bool HMDJJNMHILI(GLLFAMAFOBP MIMLJLJOJHJ, OCOPOCAAGLH IAPHKHOBBMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5139A00", Offset = "0x5138E00", VA = "0x185139A00")]
	public MEDKCBLKJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5139590", Offset = "0x5138990", VA = "0x185139590", Slot = "5")]
	public void PAICICMJOCE(MLJCENAGGMH INFFNKABNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5135D20", Offset = "0x5135120", VA = "0x185135D20", Slot = "19")]
	public void DGDJJEEDOCJ(GGIKACLHMOG EGLKIOCIBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5135D50", Offset = "0x5135150", VA = "0x185135D50", Slot = "12")]
	public void DOBGELOEIDI(Func<ADNIFANBLMG, bool> FNBAFALAPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5135D60", Offset = "0x5135160", VA = "0x185135D60")]
	private void DOBGELOEIDI(GLLFAMAFOBP GIGDHNFIFBE, Func<ADNIFANBLMG, bool> FNBAFALAPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5138170", Offset = "0x5137570", VA = "0x185138170", Slot = "11")]
	public void KNNLEFPPEPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5134E70", Offset = "0x5134270", VA = "0x185134E70", Slot = "7")]
	private bool BFMGGHCMABB(in KNJNHGMNHIO HANEMGLFJMM, bool OKABAHLMEAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Preserve]
internal class PJNBIKGIMDF : MLJCENAGGMH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly KADOJAOKIOP PKBPIIAEHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly AJBFFFDLCFA KJICPDPGIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal readonly MLCILIAMFPH DAAKKGINELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal readonly JJJIKNFIMPP NLNFAPHGJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal readonly AAAINLNAHIE NFPCELBFMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal DDKHFJNNIJJ OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal PECDGHOBMIG MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal JCIHKEIOKFC FBCMBBPMKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal bool PEGDFPMPKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool CBOIEGPICLM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JEKEDBKCBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA2EC90", Offset = "0xA2E090", VA = "0x180A2EC90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xF13D60", Offset = "0xF13160", VA = "0x180F13D60")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool EMADIPGMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xC28580", Offset = "0xC27980", VA = "0x180C28580", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1556B00", Offset = "0x1555F00", VA = "0x181556B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<ADNIFANBLMG, ADNIFANBLMG> GIBKPEBKICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5142810", Offset = "0x5141C10", VA = "0x185142810", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5141B90", Offset = "0x5140F90", VA = "0x185141B90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<ADNIFANBLMG, ADNIFANBLMG> LFHAKPEJMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x51420C0", Offset = "0x51414C0", VA = "0x1851420C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x51421C0", Offset = "0x51415C0", VA = "0x1851421C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ADNIFANBLMG, ADNIFANBLMG, ADNIFANBLMG> DJMLAPGHOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5142790", Offset = "0x5141B90", VA = "0x185142790", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5142060", Offset = "0x5141460", VA = "0x185142060", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5143690", Offset = "0x5142A90", VA = "0x185143690")]
	public PJNBIKGIMDF(KADOJAOKIOP PKBPIIAEHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5142F20", Offset = "0x5142320", VA = "0x185142F20", Slot = "11")]
	public void PAICICMJOCE(GameObject MGDBDEJKIMA, ICINCCNJKOB IAJJLMEFDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5142120", Offset = "0x5141520", VA = "0x185142120", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5141B40", Offset = "0x5140F40", VA = "0x185141B40", Slot = "12")]
	public void ADDBGNGPEPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5142AF0", Offset = "0x5141EF0", VA = "0x185142AF0", Slot = "13")]
	public void MGGHGLFMIKB(ADNIFANBLMG JDCLMDIOIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5142220", Offset = "0x5141620", VA = "0x185142220", Slot = "14")]
	public void IMEDOJDENFA(ADNIFANBLMG JDCLMDIOIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x513E420", Offset = "0x513D820", VA = "0x18513E420", Slot = "22")]
	public bool DLBLPPJADLG(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5142E60", Offset = "0x5142260", VA = "0x185142E60")]
	internal bool PAHLHNGLCJF(in KNJNHGMNHIO HANEMGLFJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5142870", Offset = "0x5141C70", VA = "0x185142870")]
	internal bool LIOJOAOGELN(in KNJNHGMNHIO HANEMGLFJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x51434A0", Offset = "0x51428A0", VA = "0x1851434A0")]
	internal bool PFEDDBOJFJE(in KNJNHGMNHIO HANEMGLFJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5142900", Offset = "0x5141D00", VA = "0x185142900")]
	internal bool MAIPCKNIDHO(in KNJNHGMNHIO HANEMGLFJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5142420", Offset = "0x5141820", VA = "0x185142420")]
	internal void IOAKLEMDPNJ(ADNIFANBLMG JDCLMDIOIDO, int HPFCBHFHBAA, bool OKABAHLMEAN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5142220", Offset = "0x5141620", VA = "0x185142220")]
	internal bool GCCHFAGNBHG(ADNIFANBLMG MBMKPMKIOKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5143500", Offset = "0x5142900", VA = "0x185143500")]
	internal bool PPNEEJLMLPF(ADNIFANBLMG KHNHLLMFMLA, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5142600", Offset = "0x5141A00", VA = "0x185142600", Slot = "15")]
	public void JLAEBDHFMFK(ADNIFANBLMG JDCLMDIOIDO, HashSet<ADNIFANBLMG> OKNKKPJGONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5141E50", Offset = "0x5141250", VA = "0x185141E50", Slot = "16")]
	public void BCECDMDGEEA(ADNIFANBLMG KHNHLLMFMLA, ADNIFANBLMG MODCHHNILJE, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x51422A0", Offset = "0x51416A0", VA = "0x1851422A0")]
	public void HAFNFHCEJIL(ADNIFANBLMG AAEFACKANCI, int ANKFJJGOFPP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5143630", Offset = "0x5142A30", VA = "0x185143630")]
	public void PPOOCADJHBA(ADNIFANBLMG DLIDKCKPEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5141D10", Offset = "0x5141110", VA = "0x185141D10")]
	public void BCECDMDGEEA(ADNIFANBLMG KHNHLLMFMLA, ADNIFANBLMG MODCHHNILJE, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5142B10", Offset = "0x5141F10", VA = "0x185142B10", Slot = "17")]
	public void MPKPCNJJMPL(ADNIFANBLMG GNJCKCGDGAA, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5142C50", Offset = "0x5142050", VA = "0x185142C50", Slot = "18")]
	public void NNPEMMNCAHG(ADNIFANBLMG GNJCKCGDGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5142E10", Offset = "0x5142210", VA = "0x185142E10", Slot = "19")]
	public bool ONIPFENLGCO(ADNIFANBLMG JDCLMDIOIDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5141BF0", Offset = "0x5140FF0", VA = "0x185141BF0")]
	public void AJNPGFIPIHF([Optional] HPJGDOMBDDL GIJALBOACPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5142700", Offset = "0x5141B00", VA = "0x185142700", Slot = "23")]
	public void KIAFELJMDHD(FAOLKGCCFCO NFPCELBFMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5142280", Offset = "0x5141680", VA = "0x185142280", Slot = "20")]
	public FAOLKGCCFCO GJFOKBBGKNE(bool DLAIAOLOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x51427F0", Offset = "0x5141BF0", VA = "0x1851427F0", Slot = "21")]
	public FAOLKGCCFCO LFGDNCBEOCN(HashSet<Guid> KMIMGBHFDNI, bool DLAIAOLOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x51423E0", Offset = "0x51417E0", VA = "0x1851423E0", Slot = "25")]
	public void ILEBLJDJIDL(FAOLKGCCFCO NFPCELBFMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5142A40", Offset = "0x5141E40", VA = "0x185142A40", Slot = "24")]
	public void MBLONGEDPNP(FAOLKGCCFCO NFPCELBFMGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class AJBFFFDLCFA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly global::EOJOLPHLMNN<ADNIFANBLMG, ADNIFANBLMG> GIBKPEBKICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly global::EOJOLPHLMNN<ADNIFANBLMG, ADNIFANBLMG> LFHAKPEJMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly global::NBPCEGEPNGN<ADNIFANBLMG, ADNIFANBLMG, ADNIFANBLMG> DJMLAPGHOEL;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x51279F0", Offset = "0x5126DF0", VA = "0x1851279F0")]
	public AJBFFFDLCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
	public void PAICICMJOCE(PJNBIKGIMDF INFFNKABNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5127990", Offset = "0x5126D90", VA = "0x185127990")]
	public void NFOJFLMJAPP(ADNIFANBLMG BLENCGKHIJI, ADNIFANBLMG MIJGFFHMOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5127930", Offset = "0x5126D30", VA = "0x185127930")]
	public void IHJJKCFKFBE(ADNIFANBLMG BLENCGKHIJI, ADNIFANBLMG MIJGFFHMOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x51278B0", Offset = "0x5126CB0", VA = "0x1851278B0")]
	public void GODBLCIIBPO(ADNIFANBLMG JMCOICNPJLH, ADNIFANBLMG GIJFJALMMOL, ADNIFANBLMG MIJGFFHMOFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class MLCILIAMFPH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private PJNBIKGIMDF INFFNKABNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PECDGHOBMIG MBEKPBENMJL;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public MLCILIAMFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5139D10", Offset = "0x5139110", VA = "0x185139D10")]
	public void PAICICMJOCE(PJNBIKGIMDF INFFNKABNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5139C90", Offset = "0x5139090", VA = "0x185139C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5139B70", Offset = "0x5138F70", VA = "0x185139B70")]
	private void BLDGKHCMAGP(HPJGDOMBDDL DNBOIJPFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5139CA0", Offset = "0x51390A0", VA = "0x185139CA0")]
	private void NHOCBCDNBIM(HPJGDOMBDDL KPJIHAEBGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5139B90", Offset = "0x5138F90", VA = "0x185139B90")]
	public void CLMLMGIMHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5139E50", Offset = "0x5139250", VA = "0x185139E50")]
	public void PEADJALGKLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class KPDFECENEPH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KFJIAHKHEJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public KADOJAOKIOP container;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public KFJIAHKHEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x51329C0", Offset = "0x5131DC0", VA = "0x1851329C0")]
		internal PJNBIKGIMDF <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x51334E0", Offset = "0x51328E0", VA = "0x1851334E0")]
	public static void PHNPGLAIJMM(KADOJAOKIOP PKBPIIAEHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5133460", Offset = "0x5132860", VA = "0x185133460")]
	public static void OMDAEOAIIDA(KADOJAOKIOP PKBPIIAEHNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
internal class ICEEMCDDODH : IDisposable, JCIHKEIOKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Dictionary<int, JEBFHFMFMAD> BHIDIAOCIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly GGIKACLHMOG NPOGNDEGEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private KDKDHJCNFJK MKBENKHNADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private AAAINLNAHIE NFPCELBFMGI;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x512F0D0", Offset = "0x512E4D0", VA = "0x18512F0D0")]
	public ICEEMCDDODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x512F090", Offset = "0x512E490", VA = "0x18512F090", Slot = "7")]
	public void PAICICMJOCE(AAAINLNAHIE NFPCELBFMGI, KDKDHJCNFJK MKBENKHNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x512EE50", Offset = "0x512E250", VA = "0x18512EE50", Slot = "5")]
	public void NODIDBPONGE(FEIDPEJCPGD EEBJOAAHKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x512E5B0", Offset = "0x512D9B0", VA = "0x18512E5B0", Slot = "9")]
	public void ANLHADPOEBG(FEIDPEJCPGD ILPHKFKNLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x512EBE0", Offset = "0x512DFE0", VA = "0x18512EBE0", Slot = "8")]
	public void HKPBPJAMNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x512E8C0", Offset = "0x512DCC0", VA = "0x18512E8C0", Slot = "10")]
	public void GFEDPLOOBCO(FEIDPEJCPGD KBOJEBJNKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x512ED90", Offset = "0x512E190", VA = "0x18512ED90", Slot = "11")]
	public void MNGNANINKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x512E720", Offset = "0x512DB20", VA = "0x18512E720")]
	private bool FADIDBONHFI(FEIDPEJCPGD PIJNGNJGCHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class JJJIKNFIMPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal struct KJGFAJCHIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly GLLFAMAFOBP ECICJKIGFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly HashSet<Guid> KMIMGBHFDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly JNJBEPHOMLC FJKFFOLIPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly JNJBEPHOMLC OHAIIGEODKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly bool DLAIAOLOEEC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool HIFCGBDDLOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5132D80", Offset = "0x5132180", VA = "0x185132D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5133270", Offset = "0x5132670", VA = "0x185133270")]
		public KJGFAJCHIED(GLLFAMAFOBP ECICJKIGFNI, HashSet<Guid> KMIMGBHFDNI, bool DLAIAOLOEEC, [Optional] JNJBEPHOMLC FJKFFOLIPGI, [Optional] JNJBEPHOMLC OHAIIGEODKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5132A20", Offset = "0x5131E20", VA = "0x185132A20")]
		public JNJBEPHOMLC CAOILNKOGOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x51331B0", Offset = "0x51325B0", VA = "0x1851331B0")]
		private JNJBEPHOMLC OFGEOECIIMP(out JNJBEPHOMLC KJNIHNGFBFJ, out JNJBEPHOMLC EFPNBHLJEDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5132B80", Offset = "0x5131F80", VA = "0x185132B80")]
		private JNJBEPHOMLC CJELFLPAKKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5133030", Offset = "0x5132430", VA = "0x185133030")]
		private void JLDDHCNLPHG(JNJBEPHOMLC MFLFMAIBBFG, JNJBEPHOMLC FINEIGFKJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5132E90", Offset = "0x5132290", VA = "0x185132E90")]
		private void HOBOJDKAEKC(JNJBEPHOMLC KJNIHNGFBFJ, JNJBEPHOMLC EFPNBHLJEDC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private PJNBIKGIMDF INFFNKABNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private AAAINLNAHIE NFPCELBFMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private JCIHKEIOKFC JGKDGHHKONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private PECDGHOBMIG MBEKPBENMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool ALGFPIMBNHJ;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool HGNCENECKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5131670", Offset = "0x5130A70", VA = "0x185131670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool JEKEDBKCBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5130110", Offset = "0x512F510", VA = "0x185130110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x51303B0", Offset = "0x512F7B0", VA = "0x1851303B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5132950", Offset = "0x5131D50", VA = "0x185132950")]
	public void PAICICMJOCE(PJNBIKGIMDF INFFNKABNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5130CE0", Offset = "0x51300E0", VA = "0x185130CE0")]
	public FAOLKGCCFCO GJFOKBBGKNE(bool DLAIAOLOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x51317A0", Offset = "0x5130BA0", VA = "0x1851317A0")]
	public FAOLKGCCFCO LFGDNCBEOCN(HashSet<Guid> KMIMGBHFDNI, bool DLAIAOLOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x51315E0", Offset = "0x51309E0", VA = "0x1851315E0")]
	public void KIAFELJMDHD(FAOLKGCCFCO NFPCELBFMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5132200", Offset = "0x5131600", VA = "0x185132200")]
	public void MBLONGEDPNP(FAOLKGCCFCO NFPCELBFMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x51303D0", Offset = "0x512F7D0", VA = "0x1851303D0")]
	public void CPIHFGIJFGH(FAOLKGCCFCO NFPCELBFMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5130680", Offset = "0x512FA80", VA = "0x185130680")]
	private void DIMCCMDPGGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x51322A0", Offset = "0x51316A0", VA = "0x1851322A0")]
	private JNJBEPHOMLC MOCEDNGGKNH(GLLFAMAFOBP GIGDHNFIFBE, bool DLAIAOLOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5130130", Offset = "0x512F530", VA = "0x185130130")]
	private static void BPPJAKCCHIH(GLLFAMAFOBP GIGDHNFIFBE, bool DLAIAOLOEEC, JNJBEPHOMLC DOHEFJFBJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x51313E0", Offset = "0x51307E0", VA = "0x1851313E0")]
	private void IBGCNFIKKKC(GLLFAMAFOBP GIGDHNFIFBE, bool DLAIAOLOEEC, JNJBEPHOMLC DOHEFJFBJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5130AD0", Offset = "0x512FED0", VA = "0x185130AD0")]
	private JNJBEPHOMLC EDBAFEHONDL(GLLFAMAFOBP ECICJKIGFNI, HashSet<Guid> KMIMGBHFDNI, bool DLAIAOLOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5130400", Offset = "0x512F800", VA = "0x185130400")]
	private bool DDEHKIIPMID(FAOLKGCCFCO KMBFGFFMMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x512FAD0", Offset = "0x512EED0", VA = "0x18512FAD0")]
	private bool AOBMAMHAMOC(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x51327D0", Offset = "0x5131BD0", VA = "0x1851327D0")]
	private bool NAPHENFBICK(FAOLKGCCFCO NFPCELBFMGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x512F7D0", Offset = "0x512EBD0", VA = "0x18512F7D0")]
	private static bool AKDGEIHFBHL(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5130810", Offset = "0x512FC10", VA = "0x185130810")]
	public static bool DLBLPPJADLG(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5132480", Offset = "0x5131880", VA = "0x185132480")]
	private ADNIFANBLMG MOFOGADHCMG(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x512F940", Offset = "0x512ED40", VA = "0x18512F940")]
	private ADNIFANBLMG AMIOHJMLFMA(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5130B60", Offset = "0x512FF60", VA = "0x185130B60")]
	private ADNIFANBLMG EMAIBPJMGLO(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x51313A0", Offset = "0x51307A0", VA = "0x1851313A0")]
	private static Guid HGFMBFDCJCH(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x51316C0", Offset = "0x5130AC0", VA = "0x1851316C0")]
	private string LCAKDNOLJDL(JNJBEPHOMLC DOHEFJFBJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x51327F0", Offset = "0x5131BF0", VA = "0x1851327F0")]
	private bool OEJIBGCAAAB(GLLFAMAFOBP GIGDHNFIFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5131F60", Offset = "0x5131360", VA = "0x185131F60")]
	private static void LPICNOGMKOP(GLLFAMAFOBP ECICJKIGFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public JJJIKNFIMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class HIPGAKPEAEO : AAHPJLIOLPO, JLGBCOPPDCE
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private const string AGFADCLADEH = "Parented";

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const string FMPIAGNDKLG = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GameObject MGDBDEJKIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly MLJCENAGGMH LBDCOBNCHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly HFPHPAFGLIH HIBKGPKPEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly POGGCGJDBIE[] GAEAJFCFFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly HKEGPKPGBAL OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private List<ADNIFANBLMG> PACBNNKCMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private ONAMKHHALIL MGOLKLMCDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private Vector3 FIKFHFBADGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private Quaternion MHLNMAEDBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool MAJCCECCGCH;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ADNIFANBLMG LOIBLGOMFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public ADNIFANBLMG HNACJFAFIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x673D80", Offset = "0x673180", VA = "0x180673D80", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x90A880", Offset = "0x909C80", VA = "0x18090A880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Vector3 ALCCGKNBJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x512A830", Offset = "0x5129C30", VA = "0x18512A830", Slot = "15")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x12CB5E0", Offset = "0x12CA9E0", VA = "0x1812CB5E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Quaternion OJLAABHFBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x512A900", Offset = "0x5129D00", VA = "0x18512A900", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D257B0", Offset = "0x1D24BB0", VA = "0x181D257B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IBODIGDDPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xC5E9A0", Offset = "0xC5DDA0", VA = "0x180C5E9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xC5EF40", Offset = "0xC5E340", VA = "0x180C5EF40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FCPDFBKBCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x512B1D0", Offset = "0x512A5D0", VA = "0x18512B1D0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public ADNIFANBLMG GNOAIAPLMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A96A0", Offset = "0x6A8AA0", VA = "0x1806A96A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x909EA0", Offset = "0x9092A0", VA = "0x180909EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool AMJOOKPHJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x512B1E0", Offset = "0x512A5E0", VA = "0x18512B1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private RigidbodyEx IOKBDCFPANN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x512ABC0", Offset = "0x5129FC0", VA = "0x18512ABC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<ADNIFANBLMG> LFLEBNEAELO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GHLNEGIHMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x512D060", Offset = "0x512C460", VA = "0x18512D060", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x512CE60", Offset = "0x512C260", VA = "0x18512CE60", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Transform CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x512E590", Offset = "0x512D990", VA = "0x18512E590", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GameObject PNKCHCINMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string AKILJOLADBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x512E300", Offset = "0x512D700", VA = "0x18512E300", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Guid GMPDHDCLBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x512E460", Offset = "0x512D860", VA = "0x18512E460", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int DOGCAAIBKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x512E540", Offset = "0x512D940", VA = "0x18512E540", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public HOGBEFGIKOI EPIGHCONBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x512E350", Offset = "0x512D750", VA = "0x18512E350", Slot = "39")]
		get
		{
			return default(HOGBEFGIKOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool INFIONGAKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event AFPOCEEJEGD GOFEFOJNIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x512D4A0", Offset = "0x512C8A0", VA = "0x18512D4A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x512B130", Offset = "0x512A530", VA = "0x18512B130", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event AFPOCEEJEGD DPELFNFHDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x512A970", Offset = "0x5129D70", VA = "0x18512A970", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x512B090", Offset = "0x512A490", VA = "0x18512B090", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event AFPOCEEJEGD DDNPICOHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x512BB40", Offset = "0x512AF40", VA = "0x18512BB40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x512CDA0", Offset = "0x512C1A0", VA = "0x18512CDA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PHOCHPKFKNM LPNJCHKCCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x512CC90", Offset = "0x512C090", VA = "0x18512CC90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x512D540", Offset = "0x512C940", VA = "0x18512D540", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x512A8A0", Offset = "0x5129CA0", VA = "0x18512A8A0")]
	private RigidbodyEx AOFPPAGKBEO(ADNIFANBLMG HIBKGPKPEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x512E210", Offset = "0x512D610", VA = "0x18512E210")]
	public HIPGAKPEAEO(GameObject MGDBDEJKIMA, HFPHPAFGLIH HIBKGPKPEBN, POGGCGJDBIE[] GAEAJFCFFHJ, HKEGPKPGBAL OENDHJEKNMI, MLJCENAGGMH LBDCOBNCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x512BBE0", Offset = "0x512AFE0", VA = "0x18512BBE0", Slot = "20")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x512BFE0", Offset = "0x512B3E0", VA = "0x18512BFE0", Slot = "22")]
	public void HHLFJFIAFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x512BD50", Offset = "0x512B150", VA = "0x18512BD50", Slot = "23")]
	public void GGJOJFCKHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x512CB60", Offset = "0x512BF60", VA = "0x18512CB60", Slot = "21")]
	public void KIFBCELFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x512AA10", Offset = "0x5129E10", VA = "0x18512AA10")]
	private void CNIEDAMJJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x512B990", Offset = "0x512AD90", VA = "0x18512B990")]
	private void FBDADKKIHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x512BD30", Offset = "0x512B130", VA = "0x18512BD30", Slot = "24")]
	public void FOBJIHIDKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x512CE40", Offset = "0x512C240", VA = "0x18512CE40", Slot = "25")]
	public void NIOMDFBGMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x512B230", Offset = "0x512A630", VA = "0x18512B230", Slot = "26")]
	public void EGGAJMEIDHB(int FEKPNEPEMJP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x512CF20", Offset = "0x512C320", VA = "0x18512CF20", Slot = "27")]
	public void NOCDHICFOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x512B4A0", Offset = "0x512A8A0", VA = "0x18512B4A0", Slot = "28")]
	public void ENGMHBGKPAC(int FEKPNEPEMJP, ADNIFANBLMG AAEFACKANCI, int ANKFJJGOFPP, [Optional] Vector3? CHCAAFBNLDC, [Optional] Quaternion? JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x512CFC0", Offset = "0x512C3C0", VA = "0x18512CFC0", Slot = "29")]
	public void OBDPJMBJFNA(ADNIFANBLMG AAEFACKANCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x512D0B0", Offset = "0x512C4B0", VA = "0x18512D0B0")]
	private void OLKBPMCNMMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x512B7F0", Offset = "0x512ABF0", VA = "0x18512B7F0", Slot = "31")]
	public void EPKEGIEFOJK(int PGFOAHEHPOH, Vector3 DDPAJGCOAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x512C720", Offset = "0x512BB20", VA = "0x18512C720", Slot = "32")]
	public void KCOLBCFMPPL(Vector3 GPAPPICBGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x512C040", Offset = "0x512B440", VA = "0x18512C040", Slot = "30")]
	public void KAMMLMPJMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x512BF10", Offset = "0x512B310", VA = "0x18512BF10", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int FEKPNEPEMJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x512BDD0", Offset = "0x512B1D0", VA = "0x18512BDD0", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int FEKPNEPEMJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x174E850", Offset = "0x174DC50", VA = "0x18174E850", Slot = "43")]
	public Color GetConnectionSlotColor(int FEKPNEPEMJP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x512AC20", Offset = "0x512A020", VA = "0x18512AC20", Slot = "44")]
	public bool CanConnectTo(int FEKPNEPEMJP, ADNIFANBLMG MJCOACCOOBK, int MDBEPNEBBDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x512CBF0", Offset = "0x512BFF0", VA = "0x18512CBF0")]
	public bool KPLPCHPLAID(ADNIFANBLMG BKBGGIICJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x512D5E0", Offset = "0x512C9E0", VA = "0x18512D5E0", Slot = "45")]
	public void ParentChanged(int FEKPNEPEMJP, ADNIFANBLMG EBOEEGHEGEP, int LBFEJPMOINI, Vector3 FIJIACOBAFI, Quaternion IGGBIIMPLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x512ACC0", Offset = "0x512A0C0", VA = "0x18512ACC0", Slot = "46")]
	public void ChildAdded(int FEKPNEPEMJP, ADNIFANBLMG KPPKBPJNEBI, int OOIMGDDPNNA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x512AE70", Offset = "0x512A270", VA = "0x18512AE70", Slot = "47")]
	public void ChildRemoved(int FEKPNEPEMJP, ADNIFANBLMG GLLNIFEHPEE, int NFMEOJHLNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x512AF30", Offset = "0x512A330", VA = "0x18512AF30", Slot = "48")]
	public void ConnectionModified(int FEKPNEPEMJP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x512E1B0", Offset = "0x512D5B0", VA = "0x18512E1B0", Slot = "49")]
	public void RootChanged(ADNIFANBLMG CBKMGHIHBCM, ADNIFANBLMG HLDBDJPOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x512CD30", Offset = "0x512C130", VA = "0x18512CD30")]
	private void MDOAOGJMFJM(HPJGDOMBDDL PNFBJDFDHKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct KNJNHGMNHIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public ADNIFANBLMG MIJGFFHMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public ADNIFANBLMG BLENCGKHIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int ANKFJJGOFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int GGLFFAEBGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Vector3 CHCAAFBNLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Quaternion JADFKALFMOP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public OCOPOCAAGLH JBMEJPBNJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5133350", Offset = "0x5132750", VA = "0x185133350")]
		get
		{
			return default(OCOPOCAAGLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public OCOPOCAAGLH EGPNMAHHFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x51332E0", Offset = "0x51326E0", VA = "0x1851332E0")]
		get
		{
			return default(OCOPOCAAGLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x51333F0", Offset = "0x51327F0", VA = "0x1851333F0")]
	public KNJNHGMNHIO(ADNIFANBLMG MIJGFFHMOFJ, ADNIFANBLMG BLENCGKHIJI, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface AAAINLNAHIE
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	FEIDPEJCPGD HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAICICMJOCE(MLJCENAGGMH INFFNKABNHB);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IOFHMOGHCLO(in KNJNHGMNHIO HANEMGLFJMM, bool OKABAHLMEAN = true);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DFJJPFMMLAK(ADNIFANBLMG DLIDKCKPEBN);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BMGEAIANBDC(ADNIFANBLMG KHNHLLMFMLA, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BOEDFCGLJCD(ADNIFANBLMG GNJCKCGDGAA, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNNLEFPPEPD();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DOBGELOEIDI(Func<ADNIFANBLMG, bool> FNBAFALAPFO);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KBJPCBJFMPG(ADNIFANBLMG JDCLMDIOIDO, out Vector3 CHCAAFBNLDC, out Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ADNIFANBLMG PAKCIEJKGDI(ADNIFANBLMG JDCLMDIOIDO);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JLAEBDHFMFK(ADNIFANBLMG JDCLMDIOIDO, HashSet<ADNIFANBLMG> OBOPDBPMIBK);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "11")]
	List<ADNIFANBLMG> HBNEJGFAMHK();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EKLEMHBHFBK(ADNIFANBLMG JDCLMDIOIDO, out OCOPOCAAGLH KPODIGPEMPA);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DGDJJEEDOCJ(GGIKACLHMOG EGLKIOCIBPB);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal delegate bool GGIKACLHMOG(FEIDPEJCPGD GIGDHNFIFBE);
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface FEIDPEJCPGD
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	ADNIFANBLMG LOIBLGOMFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int ENAEOADKKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int FHFHHKGBDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Vector3 CMKMNPCPPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Quaternion MAAOFLEPPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	FEIDPEJCPGD MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	FEIDPEJCPGD HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	OCOPOCAAGLH DFKJMJHIHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool HNEOAALGMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool GJELAGCMLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DGDJJEEDOCJ(GGIKACLHMOG EGLKIOCIBPB, bool FOKIDIOGDBM = true);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FEIDPEJCPGD CODCJPMKNLL(OCOPOCAAGLH JEBJPIMHOIF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JEBFHFMFMAD
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGKBIODLKGD(ADNIFANBLMG ABPOMMNNEIE, OCOPOCAAGLH MIJGFFHMOFJ);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHAKBKGPACE(ADNIFANBLMG ABPOMMNNEIE, OCOPOCAAGLH MIJGFFHMOFJ);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFDAJOGKJKI(ADNIFANBLMG ABPOMMNNEIE, OCOPOCAAGLH MIJGFFHMOFJ);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHGJLCNIBIH(ADNIFANBLMG ABPOMMNNEIE, OCOPOCAAGLH MIJGFFHMOFJ);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JEBFHFMFMAD Instantiate(Transform ENMFIMJMMCO);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFFPDBIGLLL();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface KDKDHJCNFJK
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAICICMJOCE(Transform ENMFIMJMMCO, JEBFHFMFMAD GLPEMPMNOOI);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JEBFHFMFMAD DLAKCDEKCLE();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AODPKBMDDNP(JEBFHFMFMAD NPJDFKBNEGC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface DDKHFJNNIJJ : IKBLODFNMGN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBHFBCMCGIA(Guid BKAHKJDNMOD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface JCIHKEIOKFC
{
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NODIDBPONGE(FEIDPEJCPGD EEBJOAAHKLI);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PAICICMJOCE(AAAINLNAHIE NFPCELBFMGI, KDKDHJCNFJK EJDKBDDECFM);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HKPBPJAMNII();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ANLHADPOEBG(FEIDPEJCPGD ILPHKFKNLBB);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GFEDPLOOBCO(FEIDPEJCPGD KBOJEBJNKOD);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MNGNANINKFN();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal class GLLFAMAFOBP : FEIDPEJCPGD
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AKMMFKGCCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public OCOPOCAAGLH nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GLLFAMAFOBP foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public AKMMFKGCCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5127AF0", Offset = "0x5126EF0", VA = "0x185127AF0")]
		internal bool <FindNode>b__0(FEIDPEJCPGD x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private OCOPOCAAGLH KPODIGPEMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public LinkedList<GLLFAMAFOBP> MMKJCMJHBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private GLLFAMAFOBP IMMLDLMDMOE;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public OCOPOCAAGLH DFKJMJHIHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC720", Offset = "0x2DDBB20", VA = "0x182DDC720", Slot = "16")]
		get
		{
			return default(OCOPOCAAGLH);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5129B10", Offset = "0x5128F10", VA = "0x185129B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private GLLFAMAFOBP BLENCGKHIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x66D0D0", Offset = "0x66C4D0", VA = "0x18066D0D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5129D60", Offset = "0x5129160", VA = "0x185129D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public FEIDPEJCPGD MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x66D0D0", Offset = "0x66C4D0", VA = "0x18066D0D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ADNIFANBLMG LOIBLGOMFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x68D130", Offset = "0x68C530", VA = "0x18068D130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int ENAEOADKKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0", Slot = "6")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x711410", Offset = "0x710810", VA = "0x180711410", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int FHFHHKGBDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x688C90", Offset = "0x688090", VA = "0x180688C90", Slot = "8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x711320", Offset = "0x710720", VA = "0x180711320", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 CMKMNPCPPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x14DB120", Offset = "0x14DA520", VA = "0x1814DB120", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x14DB140", Offset = "0x14DA540", VA = "0x1814DB140", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Quaternion MAAOFLEPPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4B66B50", Offset = "0x4B65F50", VA = "0x184B66B50", Slot = "12")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4B66B60", Offset = "0x4B65F60", VA = "0x184B66B60", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool HNEOAALGMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool GJELAGCMLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5129B40", Offset = "0x5128F40", VA = "0x185129B40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	protected GLLFAMAFOBP JAFNHFEOMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5129AF0", Offset = "0x5128EF0", VA = "0x185129AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public FEIDPEJCPGD HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5129AF0", Offset = "0x5128EF0", VA = "0x185129AF0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x512A2F0", Offset = "0x51296F0", VA = "0x18512A2F0")]
	public GLLFAMAFOBP(OCOPOCAAGLH NGJMCFBFCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x5129F80", Offset = "0x5129380", VA = "0x185129F80")]
	public GLLFAMAFOBP MNJLDMDAPLM(OCOPOCAAGLH BBFIEGFIFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x512A170", Offset = "0x5129570", VA = "0x18512A170")]
	public GLLFAMAFOBP NMOJAGLJAPI(OCOPOCAAGLH NEBDFDOMHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x5129B90", Offset = "0x5128F90", VA = "0x185129B90")]
	public GLLFAMAFOBP GMLJNDAKNDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5129E40", Offset = "0x5129240", VA = "0x185129E40")]
	public void HLOEIBCGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x512A0C0", Offset = "0x51294C0", VA = "0x18512A0C0")]
	public GLLFAMAFOBP MOBIHLDJELM(OCOPOCAAGLH GIJFJALMMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5129990", Offset = "0x5128D90", VA = "0x185129990")]
	private static void DGDJJEEDOCJ(GLLFAMAFOBP KCOLKMCLPNM, GGIKACLHMOG JEBGPNEHLJO, bool HPCLHIGIPDG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5129AE0", Offset = "0x5128EE0", VA = "0x185129AE0", Slot = "19")]
	public void DGDJJEEDOCJ(GGIKACLHMOG EGLKIOCIBPB, bool FOKIDIOGDBM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x5129460", Offset = "0x5128860", VA = "0x185129460")]
	public static string CFGCCFPHEJG(GLLFAMAFOBP KCOLKMCLPNM, int KJKHPEKCAGF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x5129850", Offset = "0x5128C50", VA = "0x185129850", Slot = "20")]
	public FEIDPEJCPGD CODCJPMKNLL(OCOPOCAAGLH JEBJPIMHOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5129880", Offset = "0x5128C80", VA = "0x185129880")]
	public static GLLFAMAFOBP CODCJPMKNLL(GLLFAMAFOBP KCOLKMCLPNM, OCOPOCAAGLH JEBJPIMHOIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface PECDGHOBMIG
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool HGNCENECKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool GNOADLCEJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event Action<HPJGDOMBDDL> BLDGKHCMAGP;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event Action<HPJGDOMBDDL> NHOCBCDNBIM;

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(PJNBIKGIMDF INFFNKABNHB);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterConnectNodes(ADNIFANBLMG AAEFACKANCI, int ANKFJJGOFPP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterDisconnectNode(ADNIFANBLMG DLIDKCKPEBN);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestMasterModifyNode(ADNIFANBLMG KHNHLLMFMLA, ADNIFANBLMG MODCHHNILJE, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void RequestMasterReparentNodes(ADNIFANBLMG GNJCKCGDGAA, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void RequestMasterReparentToRoot(ADNIFANBLMG GNJCKCGDGAA);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void RequestDeserializeConnectableGraph(FAOLKGCCFCO OMHHNIIADGE, [Optional] HPJGDOMBDDL GIJALBOACPA);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, PECDGHOBMIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private PJNBIKGIMDF INFFNKABNHB;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool HGNCENECKKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x5134C80", Offset = "0x5134080", VA = "0x185134C80", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool GNOADLCEJMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x5134CE0", Offset = "0x51340E0", VA = "0x185134CE0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<HPJGDOMBDDL> BLDGKHCMAGP
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x5134BE0", Offset = "0x5133FE0", VA = "0x185134BE0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x5134DD0", Offset = "0x51341D0", VA = "0x185134DD0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<HPJGDOMBDDL> NHOCBCDNBIM
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x5134B40", Offset = "0x5133F40", VA = "0x185134B40", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x5134D30", Offset = "0x5134130", VA = "0x185134D30", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6745A0", Offset = "0x6739A0", VA = "0x1806745A0", Slot = "22")]
		public void SetManager(PJNBIKGIMDF INFFNKABNHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5134B10", Offset = "0x5133F10", VA = "0x185134B10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5133810", Offset = "0x5132C10", VA = "0x185133810", Slot = "23")]
		public void RequestMasterConnectNodes(ADNIFANBLMG AAEFACKANCI, int ANKFJJGOFPP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5133940", Offset = "0x5132D40", VA = "0x185133940", Slot = "24")]
		public void RequestMasterDisconnectNode(ADNIFANBLMG DLIDKCKPEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5133A10", Offset = "0x5132E10", VA = "0x185133A10", Slot = "25")]
		public void RequestMasterModifyNode(ADNIFANBLMG KHNHLLMFMLA, ADNIFANBLMG MODCHHNILJE, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x5133B40", Offset = "0x5132F40", VA = "0x185133B40", Slot = "26")]
		public void RequestMasterReparentNodes(ADNIFANBLMG GNJCKCGDGAA, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5133C70", Offset = "0x5133070", VA = "0x185133C70", Slot = "27")]
		public void RequestMasterReparentToRoot(ADNIFANBLMG GNJCKCGDGAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x51336E0", Offset = "0x5132AE0", VA = "0x1851336E0", Slot = "28")]
		public void RequestDeserializeConnectableGraph(FAOLKGCCFCO OMHHNIIADGE, [Optional] HPJGDOMBDDL GIJALBOACPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5134060", Offset = "0x5133460", VA = "0x185134060")]
		[KFNKMGOBADP]
		private void RpcMasterConnectNodes(ADNIFANBLMG AAEFACKANCI, int ANKFJJGOFPP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5134330", Offset = "0x5133730", VA = "0x185134330")]
		[KFNKMGOBADP]
		private void RpcMasterDisconnectNode(ADNIFANBLMG DLIDKCKPEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5134690", Offset = "0x5133A90", VA = "0x185134690")]
		[KFNKMGOBADP]
		private void RpcMasterReparentNodes(ADNIFANBLMG GNJCKCGDGAA, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5134480", Offset = "0x5133880", VA = "0x185134480")]
		[KFNKMGOBADP]
		private void RpcMasterModifyNode(ADNIFANBLMG KHNHLLMFMLA, ADNIFANBLMG MODCHHNILJE, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5133E40", Offset = "0x5133240", VA = "0x185133E40")]
		[KFNKMGOBADP]
		private void RpcConnectNodes(ADNIFANBLMG AAEFACKANCI, int ANKFJJGOFPP, ADNIFANBLMG ABPOMMNNEIE, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP, DKCJKFAANNE AGKNFGCKNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5133FD0", Offset = "0x51333D0", VA = "0x185133FD0")]
		[KFNKMGOBADP]
		private void RpcDisconnectNode(ADNIFANBLMG DLIDKCKPEBN, DKCJKFAANNE AGKNFGCKNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5134A00", Offset = "0x5133E00", VA = "0x185134A00")]
		[KFNKMGOBADP]
		private void RpcReparentNodes(ADNIFANBLMG GNJCKCGDGAA, int NONNNGEJOOH, ADNIFANBLMG GIJFJALMMOL, int LBFEJPMOINI, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP, DKCJKFAANNE AGKNFGCKNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5134930", Offset = "0x5133D30", VA = "0x185134930")]
		[KFNKMGOBADP]
		private void RpcModifyNode(ADNIFANBLMG KHNHLLMFMLA, int ANKFJJGOFPP, int GGLFFAEBGJA, Vector3 CHCAAFBNLDC, Quaternion JADFKALFMOP, DKCJKFAANNE AGKNFGCKNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5133F90", Offset = "0x5133390", VA = "0x185133F90")]
		[KFNKMGOBADP]
		private void RpcDeserializeConnectableGraph(FAOLKGCCFCO NFPCELBFMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xFD3780", Offset = "0xFD2B80", VA = "0x180FD3780")]
		public LegacyConnectableNetworking()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AIJDGAOIHLF
{
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2828840", Offset = "0x2827C40", VA = "0x182828840")]
	public static global::ADKLCKJFMKP<T> FLOLMCKOPGB<T>(this KADOJAOKIOP PKBPIIAEHNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ONAMKHHALIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPALGOGEJPD();

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKDFMHKJMMK(bool PKODKJLGOIN);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DDJPADBDIID : ONAMKHHALIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly global::ANHEDMGJEDB<bool> NLIGLMCBGKJ;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5128D40", Offset = "0x5128140", VA = "0x185128D40")]
	public DDJPADBDIID(IOAKEOACFCM IDEIPFIOJKJ, string MPIADBGKNBD, bool NANCDEAMBKG, LJJHICHHAIE GJPJALKPPHN, [Optional] Action EGLKIOCIBPB, [Optional] NEFALIGDJPK MMFGAEFBKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x5128C70", Offset = "0x5128070", VA = "0x185128C70", Slot = "4")]
	public bool DPALGOGEJPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5128CE0", Offset = "0x51280E0", VA = "0x185128CE0", Slot = "5")]
	public void JKDFMHKJMMK(bool PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5128CC0", Offset = "0x51280C0", VA = "0x185128CC0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class MAKAIICIJBN
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public const string KHFIMBCIOMM = "The connectable subgraph being deserialized is corrupt.";

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public const string DIHDKGIMFKL = "The connectable subgraph failed to deserialize, even though it passed the corruption check.";
}
namespace RRAssemblyIndex.RecRoom.Connectables.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	internal class _RRAssemblyIndex : EFIPBPLGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5143AB0", Offset = "0x5142EB0", VA = "0x185143AB0", Slot = "6")]
		public sealed override void HGCIEPNFBCH(LDNEHEGKOKK EGLKIOCIBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5143A50", Offset = "0x5142E50", VA = "0x185143A50", Slot = "4")]
		public sealed override void AMKPAJEBOOH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x512F4F0", Offset = "0x512E8F0", VA = "0x18512F4F0")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x512F1A0", Offset = "0x512E5A0", VA = "0x18512F1A0")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
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

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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
