using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Core.Studio;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AccountRestrictedVisibilityObject : VisibilityRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[Flags]
		public enum OCAFFLHGKOD
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Junior = 1,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			NonJunior = 2,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			UGC_Allowed = 4,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			UGC_Blocked = 8,
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			Chat_Allowed = 0x10,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			Chat_Blocked = 0x20
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum DHAKPOCMDKP
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private OCAFFLHGKOD visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private DHAKPOCMDKP evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool JKJNCOFBOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool HKAKBAAEAKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool PBFAAHAJKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool BEEDKDCNHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private DHPDGIEFJHF EPNLIMHHPNP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5C90EC0", Offset = "0x5C902C0", VA = "0x185C90EC0", Slot = "5")]
		protected override void BEFOHHGHGBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C912B0", Offset = "0x5C906B0", VA = "0x185C912B0", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5C91170", Offset = "0x5C90570", VA = "0x185C91170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5C91160", Offset = "0x5C90560", VA = "0x185C91160")]
		private void LLHKGMGNDON(bool JKJNCOFBOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5C910D0", Offset = "0x5C904D0", VA = "0x185C910D0")]
		private void GLCALONJOHA(bool JKJNCOFBOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C91000", Offset = "0x5C90400", VA = "0x185C91000", Slot = "6")]
		protected override void BOPLMPHFPEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public AccountRestrictedVisibilityObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class AltRenderedObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static List<AltRenderedObject> All;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[EALAPBKJACJ("Alters the behavior of this object when rendered in photos taken by junior players", order = 0)]
		[EALAPBKJACJ("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", EALAPBKJACJ.LMMLEKHCJPE.Warning, order = 1)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private HAMCJNIMIPK GIHPOJLDBEH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PHBPBEPKNOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA457E0", Offset = "0xA44BE0", VA = "0x180A457E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C91360", Offset = "0x5C90760", VA = "0x185C91360", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C91430", Offset = "0x5C90830", VA = "0x185C91430", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C91550", Offset = "0x5C90950", VA = "0x185C91550")]
		public void SetPaused(bool JLDINMBJPKG, UnityEngine.Object KJAGMGIFCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C91500", Offset = "0x5C90900", VA = "0x185C91500")]
		public void PreRender(Camera CHBPBGPILJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void OPJPCLHFFCP(Camera CHBPBGPILJL);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C914B0", Offset = "0x5C908B0", VA = "0x185C914B0")]
		public void PostRender(Camera CHBPBGPILJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void EPOGBKAPKJI(Camera CHBPBGPILJL);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C91620", Offset = "0x5C90A20", VA = "0x185C91620")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject, PLLKEELCFEM<RecRoomStudioDisableRenderInShareCamPhoto>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct IKPEADDFAME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] GHLACFJILNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] PGEJPEHEBOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] EBOKDDLGFCP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IKPEADDFAME LBBAHBHDNFN;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C91F70", Offset = "0x5C91370", VA = "0x185C91F70")]
		public static IKPEADDFAME PreRender(GameObject IPAGFDLNMDK)
		{
			return default(IKPEADDFAME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5C91DB0", Offset = "0x5C911B0", VA = "0x185C91DB0")]
		public static void PostRender(IKPEADDFAME PFPIKMEJALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C91C00", Offset = "0x5C91000", VA = "0x185C91C00", Slot = "6")]
		protected override void OPJPCLHFFCP(Camera CHBPBGPILJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5C919A0", Offset = "0x5C90DA0", VA = "0x185C919A0", Slot = "7")]
		protected override void EPOGBKAPKJI(Camera CHBPBGPILJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5C91BD0", Offset = "0x5C90FD0", VA = "0x185C91BD0", Slot = "8")]
		private void LEOLHDJINIA(RecRoomStudioDisableRenderInShareCamPhoto CAAHLJCBGCE, int IIMNBNHJEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5C92100", Offset = "0x5C91500", VA = "0x185C92100")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5C916A0", Offset = "0x5C90AA0", VA = "0x185C916A0")]
		[CompilerGenerated]
		internal static (Component, bool)[] DKFLDJAFBPK(IEnumerable<Component> MGFLEBFIMPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5C91B60", Offset = "0x5C90F60", VA = "0x185C91B60")]
		[CompilerGenerated]
		internal static void JNCHJDIBODK((Component, bool) PMJCKJHKMHA)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class GameObjectSwapAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private GameObject primaryObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private GameObject alternateObject;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5C92190", Offset = "0x5C91590", VA = "0x185C92190", Slot = "6")]
		protected override void OPJPCLHFFCP(Camera CHBPBGPILJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5C92150", Offset = "0x5C91550", VA = "0x185C92150", Slot = "7")]
		protected override void EPOGBKAPKJI(Camera CHBPBGPILJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5C921D0", Offset = "0x5C915D0", VA = "0x185C921D0")]
		public GameObjectSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MaterialSwapAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private Renderer swappedRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private Material[] swappedMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Material[] ONHPKHGHELK;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5C92250", Offset = "0x5C91650", VA = "0x185C92250", Slot = "6")]
		protected override void OPJPCLHFFCP(Camera CHBPBGPILJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5C92220", Offset = "0x5C91620", VA = "0x185C92220", Slot = "7")]
		protected override void EPOGBKAPKJI(Camera CHBPBGPILJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5C922A0", Offset = "0x5C916A0", VA = "0x185C922A0")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool KBLKGMPKPGA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LKGDLFIICDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7D0020", Offset = "0x7CF420", VA = "0x1807D0020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5C92570", Offset = "0x5C91970", VA = "0x185C92570", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5C92570", Offset = "0x5C91970", VA = "0x185C92570")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		protected virtual void BEFOHHGHGBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void BOPLMPHFPEC();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		protected VisibilityRestriction()
		{
		}
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
