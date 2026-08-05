using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AccountRestrictedVisibilityObject : VisibilityRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[Flags]
		public enum KLGMBJECHEM
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
		public enum JFDFECJCGNO
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private KLGMBJECHEM visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private JFDFECJCGNO evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool HOMGOJAOCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool KEFPBDCOJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool LLGOCKJABAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool FJKLOJMFDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private BBDNFHGFMBE NELMIKFANIM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1651660", Offset = "0x164FE60", VA = "0x181651660", Slot = "5")]
		protected override void EGEEJKJFMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1651930", Offset = "0x1650130", VA = "0x181651930", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1651800", Offset = "0x1650000", VA = "0x181651800")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x16514B0", Offset = "0x164FCB0", VA = "0x1816514B0")]
		private void AMJPFFIIHHG(bool HOMGOJAOCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1651760", Offset = "0x164FF60", VA = "0x181651760")]
		private void HLOHJKKNFKF(bool HOMGOJAOCEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x16514C0", Offset = "0x164FCC0", VA = "0x1816514C0", Slot = "6")]
		protected override void DFLFHKHCFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x16519E0", Offset = "0x16501E0", VA = "0x1816519E0")]
		public AccountRestrictedVisibilityObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MaterialSwapAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private Renderer swappedRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Material[] swappedMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Material[] NHILLDKKBEK;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x16527F0", Offset = "0x1650FF0", VA = "0x1816527F0", Slot = "6")]
		protected override void JPNDKPGBBDH(Camera KNIEKLDJEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x16527C0", Offset = "0x1650FC0", VA = "0x1816527C0", Slot = "7")]
		protected override void CFPIKJLMMMJ(Camera KNIEKLDJEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1652840", Offset = "0x1651040", VA = "0x181652840")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GameObjectSwapAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private GameObject primaryObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private GameObject alternateObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x16526D0", Offset = "0x1650ED0", VA = "0x1816526D0", Slot = "6")]
		protected override void JPNDKPGBBDH(Camera KNIEKLDJEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1652690", Offset = "0x1650E90", VA = "0x181652690", Slot = "7")]
		protected override void CFPIKJLMMMJ(Camera KNIEKLDJEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1652710", Offset = "0x1650F10", VA = "0x181652710")]
		public GameObjectSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool NHOHANJCEON;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NFCNEEDMPDK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC6F0D0", Offset = "0xC6D8D0", VA = "0x180C6F0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1652AD0", Offset = "0x16512D0", VA = "0x181652AD0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1652AD0", Offset = "0x16512D0", VA = "0x181652AD0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		protected virtual void EGEEJKJFMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void DFLFHKHCFBH();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		protected VisibilityRestriction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class DisabledAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct LLBFGKGIJCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public (Component, bool)[] IHACADHIAJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public (Component, bool)[] NJBDLNNGMEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public (Component, bool)[] AGPFGLIAHPD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private LLBFGKGIJCE BKFONMPAJBJ;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x16523F0", Offset = "0x1650BF0", VA = "0x1816523F0")]
		public static LLBFGKGIJCE PreRender(GameObject ALBKEDBKENG)
		{
			return default(LLBFGKGIJCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1652230", Offset = "0x1650A30", VA = "0x181652230")]
		public static void PostRender(LLBFGKGIJCE LMOBEOIMFAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1651ED0", Offset = "0x16506D0", VA = "0x181651ED0", Slot = "6")]
		protected override void JPNDKPGBBDH(Camera KNIEKLDJEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1651D00", Offset = "0x1650500", VA = "0x181651D00", Slot = "7")]
		protected override void CFPIKJLMMMJ(Camera KNIEKLDJEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x16525E0", Offset = "0x1650DE0", VA = "0x1816525E0")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1651F10", Offset = "0x1650710", VA = "0x181651F10")]
		[CompilerGenerated]
		internal static (Component, bool)[] KAAJMLPLBKB(IEnumerable<Component> DJAGNGNIHCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1651EB0", Offset = "0x16506B0", VA = "0x181651EB0")]
		[CompilerGenerated]
		internal static void GHFFAAFOKIP((Component, bool) LMOPDHDJNLJ)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class AltRenderedObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static List<AltRenderedObject> All;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[NKGMJEDPLML("Alters the behavior of this object when rendered in photos taken by junior players")]
		[NKGMJEDPLML("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", NKGMJEDPLML.CAOPHPLEDIB.Warning)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private FMDOKKBAPOM OCFJHALDLGG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LEFGJADGCCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1651CE0", Offset = "0x16504E0", VA = "0x181651CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x16519F0", Offset = "0x16501F0", VA = "0x1816519F0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1651A80", Offset = "0x1650280", VA = "0x181651A80", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1651BB0", Offset = "0x16503B0", VA = "0x181651BB0")]
		public void SetPaused(bool ALPKOFENEIP, UnityEngine.Object FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1651B60", Offset = "0x1650360", VA = "0x181651B60")]
		public void PreRender(Camera KNIEKLDJEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void JPNDKPGBBDH(Camera KNIEKLDJEMB);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1651B10", Offset = "0x1650310", VA = "0x181651B10")]
		public void PostRender(Camera KNIEKLDJEMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void CFPIKJLMMMJ(Camera KNIEKLDJEMB);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1651C70", Offset = "0x1650470", VA = "0x181651C70")]
		protected AltRenderedObject()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
