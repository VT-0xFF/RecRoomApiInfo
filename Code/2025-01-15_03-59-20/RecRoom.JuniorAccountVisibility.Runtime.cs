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
		public enum PCBOGAKNIKK
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
		public enum JKGFNBHODMG
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private PCBOGAKNIKK visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private JKGFNBHODMG evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool DABJFOGOFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool JNGMPEJOKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool COBLKHJOAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool JKJIEDEADAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ELDCPMFDOPF FOOKADLJLBI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70288F0", Offset = "0x7027CF0", VA = "0x1870288F0", Slot = "5")]
		protected override void ACAOKDFIMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7028CF0", Offset = "0x70280F0", VA = "0x187028CF0", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7028BC0", Offset = "0x7027FC0", VA = "0x187028BC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7028BB0", Offset = "0x7027FB0", VA = "0x187028BB0")]
		private void IHKBGNAHFOF(bool DABJFOGOFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7028B20", Offset = "0x7027F20", VA = "0x187028B20")]
		private void APDEGJBEEED(bool DABJFOGOFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7028A50", Offset = "0x7027E50", VA = "0x187028A50", Slot = "6")]
		protected override void AEPEKHMCODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
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
		[JFDMFEEFIJN("Alters the behavior of this object when rendered in photos taken by junior players", order = 0)]
		[JFDMFEEFIJN("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", JFDMFEEFIJN.EHMBJEOHAPB.Warning, order = 1)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MFGPGCPLCOD GKFJBGNDECJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EHMGCEHJAJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x1109100", Offset = "0x1108500", VA = "0x181109100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7028DA0", Offset = "0x70281A0", VA = "0x187028DA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7028EA0", Offset = "0x70282A0", VA = "0x187028EA0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7028FC0", Offset = "0x70283C0", VA = "0x187028FC0")]
		public void SetPaused(bool DGOLCPKLMFP, UnityEngine.Object CMNJCPJBHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7028F70", Offset = "0x7028370", VA = "0x187028F70")]
		public void PreRender(Camera HNKNJAPAGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HPBHGKPDMLK(Camera HNKNJAPAGLP);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7028F20", Offset = "0x7028320", VA = "0x187028F20")]
		public void PostRender(Camera HNKNJAPAGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void DKPAOIIHBLI(Camera HNKNJAPAGLP);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7029090", Offset = "0x7028490", VA = "0x187029090")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject, NIEPDFDGPLN<RecRoomStudioDisableRenderInShareCamPhoto>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct COJMIJPOMKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] FKKNNHMECCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] JJEEBPMHJNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] JLGBDHFMEPO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private COJMIJPOMKM EPAKOLPLBJB;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70299A0", Offset = "0x7028DA0", VA = "0x1870299A0")]
		public static COJMIJPOMKM PreRender(GameObject MCCIFMIMANN)
		{
			return default(COJMIJPOMKM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x70297F0", Offset = "0x7028BF0", VA = "0x1870297F0")]
		public static void PostRender(COJMIJPOMKM NKBGBKKJJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x70295A0", Offset = "0x70289A0", VA = "0x1870295A0", Slot = "6")]
		protected override void HPBHGKPDMLK(Camera HNKNJAPAGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7029110", Offset = "0x7028510", VA = "0x187029110", Slot = "7")]
		protected override void DKPAOIIHBLI(Camera HNKNJAPAGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7029750", Offset = "0x7028B50", VA = "0x187029750", Slot = "8")]
		private void LAHMGKNFCMI(RecRoomStudioDisableRenderInShareCamPhoto KAFIHFEFNFL, int OKJPHDPFLIE, bool IDPDBKMKFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7029B30", Offset = "0x7028F30", VA = "0x187029B30")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x70292C0", Offset = "0x70286C0", VA = "0x1870292C0")]
		[CompilerGenerated]
		internal static (Component, bool)[] DMNFCEOIOMN(IEnumerable<Component> IAOEMKOLKLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7029780", Offset = "0x7028B80", VA = "0x187029780")]
		[CompilerGenerated]
		internal static void OBJAFMIGAPP((Component, bool) PJBKLAOLPHM)
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
		[Cpp2IlInjected.Address(RVA = "0x7029BC0", Offset = "0x7028FC0", VA = "0x187029BC0", Slot = "6")]
		protected override void HPBHGKPDMLK(Camera HNKNJAPAGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7029B80", Offset = "0x7028F80", VA = "0x187029B80", Slot = "7")]
		protected override void DKPAOIIHBLI(Camera HNKNJAPAGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7029C00", Offset = "0x7029000", VA = "0x187029C00")]
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
		private Material[] FFPMOJFMPPJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7029C80", Offset = "0x7029080", VA = "0x187029C80", Slot = "6")]
		protected override void HPBHGKPDMLK(Camera HNKNJAPAGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7029C50", Offset = "0x7029050", VA = "0x187029C50", Slot = "7")]
		protected override void DKPAOIIHBLI(Camera HNKNJAPAGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7029CD0", Offset = "0x70290D0", VA = "0x187029CD0")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool EPMGGCENIHB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NPGPKDCLMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x96F330", Offset = "0x96E730", VA = "0x18096F330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7029F90", Offset = "0x7029390", VA = "0x187029F90", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7029F90", Offset = "0x7029390", VA = "0x187029F90")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		protected virtual void ACAOKDFIMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void AEPEKHMCODD();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
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
