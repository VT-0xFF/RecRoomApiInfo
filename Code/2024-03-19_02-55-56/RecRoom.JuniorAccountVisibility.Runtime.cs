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
		public enum KIIKLLMIEPH
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
		public enum GOANAEOLBPC
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private KIIKLLMIEPH visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private GOANAEOLBPC evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool MODIFIPGLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool LPCAILOOHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool ADDHNMMAFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool OBHNHJLIMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private EBLOJBEEHOK ABDKEKCIIDD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x61B28B0", Offset = "0x61B18B0", VA = "0x1861B28B0", Slot = "5")]
		protected override void EGGDHFJIJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61B2B40", Offset = "0x61B1B40", VA = "0x1861B2B40", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61B29F0", Offset = "0x61B19F0", VA = "0x1861B29F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61B2B30", Offset = "0x61B1B30", VA = "0x1861B2B30")]
		private void PLJCPGEKBDO(bool MODIFIPGLCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61B2820", Offset = "0x61B1820", VA = "0x1861B2820")]
		private void DJPHKPCMMJO(bool MODIFIPGLCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61B2750", Offset = "0x61B1750", VA = "0x1861B2750", Slot = "6")]
		protected override void ADENPCOGNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
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
		[GGLABPOOABG("Alters the behavior of this object when rendered in photos taken by junior players", order = 0)]
		[GGLABPOOABG("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", GGLABPOOABG.IHEAPLCHBAM.Warning, order = 1)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FCANMKLMDOK IDLJHHIAIAO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MJOKKAKLNBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBA86F0", Offset = "0xBA76F0", VA = "0x180BA86F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61B2BF0", Offset = "0x61B1BF0", VA = "0x1861B2BF0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61B2CC0", Offset = "0x61B1CC0", VA = "0x1861B2CC0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61B2DE0", Offset = "0x61B1DE0", VA = "0x1861B2DE0")]
		public void SetPaused(bool FGFFDENLGJJ, UnityEngine.Object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61B2D90", Offset = "0x61B1D90", VA = "0x1861B2D90")]
		public void PreRender(Camera NOKKDLLPIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void FBBIBAKDLPK(Camera NOKKDLLPIMH);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61B2D40", Offset = "0x61B1D40", VA = "0x1861B2D40")]
		public void PostRender(Camera NOKKDLLPIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void DJEABACOCHB(Camera NOKKDLLPIMH);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61B2EB0", Offset = "0x61B1EB0", VA = "0x1861B2EB0")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject, MGIPHAFOKEL<RecRoomStudioDisableRenderInShareCamPhoto>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct IEDPLLJCJMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] MDMEELOEMGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] JCFMCFBCEPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] DPJMFOCGEME;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IEDPLLJCJMB IDNPBHAMJNO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61B3800", Offset = "0x61B2800", VA = "0x1861B3800")]
		public static IEDPLLJCJMB PreRender(GameObject LNIPGKDIFCK)
		{
			return default(IEDPLLJCJMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x61B3640", Offset = "0x61B2640", VA = "0x1861B3640")]
		public static void PostRender(IEDPLLJCJMB FKCIEMMMFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61B3160", Offset = "0x61B2160", VA = "0x1861B3160", Slot = "6")]
		protected override void FBBIBAKDLPK(Camera NOKKDLLPIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x61B2FA0", Offset = "0x61B1FA0", VA = "0x1861B2FA0", Slot = "7")]
		protected override void DJEABACOCHB(Camera NOKKDLLPIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61B3310", Offset = "0x61B2310", VA = "0x1861B3310", Slot = "8")]
		private void JOCIGFGLNBN(RecRoomStudioDisableRenderInShareCamPhoto JPHMEFBNANO, int LGOCLLDLLFF, bool CBKFIBOHALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61B3990", Offset = "0x61B2990", VA = "0x1861B3990")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x61B3340", Offset = "0x61B2340", VA = "0x1861B3340")]
		[CompilerGenerated]
		internal static (Component, bool)[] MPENEMLNLNG(IEnumerable<Component> NENADCBECPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x61B2F30", Offset = "0x61B1F30", VA = "0x1861B2F30")]
		[CompilerGenerated]
		internal static void AINCMOBIBOJ((Component, bool) MCHOLKDNLJJ)
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
		[Cpp2IlInjected.Address(RVA = "0x61B3A20", Offset = "0x61B2A20", VA = "0x1861B3A20", Slot = "6")]
		protected override void FBBIBAKDLPK(Camera NOKKDLLPIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61B39E0", Offset = "0x61B29E0", VA = "0x1861B39E0", Slot = "7")]
		protected override void DJEABACOCHB(Camera NOKKDLLPIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61B3A60", Offset = "0x61B2A60", VA = "0x1861B3A60")]
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
		private Material[] AGIIFLCJDKO;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61B3AE0", Offset = "0x61B2AE0", VA = "0x1861B3AE0", Slot = "6")]
		protected override void FBBIBAKDLPK(Camera NOKKDLLPIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x61B3AB0", Offset = "0x61B2AB0", VA = "0x1861B3AB0", Slot = "7")]
		protected override void DJEABACOCHB(Camera NOKKDLLPIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x61B3B30", Offset = "0x61B2B30", VA = "0x1861B3B30")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool FBIMFANKLLN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ONBKJFOBGAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x835210", Offset = "0x834210", VA = "0x180835210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61B3E00", Offset = "0x61B2E00", VA = "0x1861B3E00", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x61B3E00", Offset = "0x61B2E00", VA = "0x1861B3E00")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		protected virtual void EGGDHFJIJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void ADENPCOGNEG();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
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
