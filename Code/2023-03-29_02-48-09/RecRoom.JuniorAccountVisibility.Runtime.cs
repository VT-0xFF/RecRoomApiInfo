using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AccountRestrictedVisibilityObject : VisibilityRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[Flags]
		public enum ILGGGEIKJFG
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
		public enum FCCFENPIFDN
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private ILGGGEIKJFG visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private FCCFENPIFDN evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool AJIGLIPKLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool HAAKCNEPJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool AICFAGOHHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool AFBMGCAJPCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private APGMNMFNHOD HIGIPCJPGDO;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6607A70", Offset = "0x6606870", VA = "0x186607A70", Slot = "5")]
		protected override void OBGIBCOLCJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6607D30", Offset = "0x6606B30", VA = "0x186607D30", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6607C00", Offset = "0x6606A00", VA = "0x186607C00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6607820", Offset = "0x6606620", VA = "0x186607820")]
		private void FDFDEEJABAH(bool AJIGLIPKLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6607830", Offset = "0x6606630", VA = "0x186607830")]
		private void GBCJKHAFFHB(bool AJIGLIPKLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66078D0", Offset = "0x66066D0", VA = "0x1866078D0", Slot = "6")]
		protected override void LIPKCOHNHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
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
		[OBIMBAFOJJM("Alters the behavior of this object when rendered in photos taken by junior players")]
		[OBIMBAFOJJM("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", OBIMBAFOJJM.IGGLPBELNHG.Warning)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private JGIJICGALKO FEPDKPPPGEJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CGPDGKAMKNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x1C770E0", Offset = "0x1C75EE0", VA = "0x181C770E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6607DE0", Offset = "0x6606BE0", VA = "0x186607DE0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6607E70", Offset = "0x6606C70", VA = "0x186607E70", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6607FA0", Offset = "0x6606DA0", VA = "0x186607FA0")]
		public void SetPaused(bool KJPLGDJNFFI, UnityEngine.Object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6607F50", Offset = "0x6606D50", VA = "0x186607F50")]
		public void PreRender(Camera LNALJOCEHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void LHDKIPLMDJC(Camera LNALJOCEHJD);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6607F00", Offset = "0x6606D00", VA = "0x186607F00")]
		public void PostRender(Camera LNALJOCEHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void BMAJAPEBNGH(Camera LNALJOCEHJD);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6608060", Offset = "0x6606E60", VA = "0x186608060")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct EMHNHBAOKBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] OBLBJGDDNIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] OMMFEHKAKEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] NLJFCJJNILE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private EMHNHBAOKBN FFBIOLJBKDO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x66087C0", Offset = "0x66075C0", VA = "0x1866087C0")]
		public static EMHNHBAOKBN PreRender(GameObject AAMBGNNHMBI)
		{
			return default(EMHNHBAOKBN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6608600", Offset = "0x6607400", VA = "0x186608600")]
		public static void PostRender(EMHNHBAOKBN PHPGCLAFCNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x66085C0", Offset = "0x66073C0", VA = "0x1866085C0", Slot = "6")]
		protected override void LHDKIPLMDJC(Camera LNALJOCEHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66080D0", Offset = "0x6606ED0", VA = "0x1866080D0", Slot = "7")]
		protected override void BMAJAPEBNGH(Camera LNALJOCEHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6608990", Offset = "0x6607790", VA = "0x186608990")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66082A0", Offset = "0x66070A0", VA = "0x1866082A0")]
		[CompilerGenerated]
		internal static (Component, bool)[] KLJHFPGAEBG(IEnumerable<Component> ELCPBBOBCBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6608280", Offset = "0x6607080", VA = "0x186608280")]
		[CompilerGenerated]
		internal static void EMIMNBMHCEI((Component, bool) ACPPJIMCPKA)
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

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6608A70", Offset = "0x6607870", VA = "0x186608A70", Slot = "6")]
		protected override void LHDKIPLMDJC(Camera LNALJOCEHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6608A30", Offset = "0x6607830", VA = "0x186608A30", Slot = "7")]
		protected override void BMAJAPEBNGH(Camera LNALJOCEHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6608AB0", Offset = "0x66078B0", VA = "0x186608AB0")]
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
		private Material[] LCDMCBOGBKI;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x66091B0", Offset = "0x6607FB0", VA = "0x1866091B0", Slot = "6")]
		protected override void LHDKIPLMDJC(Camera LNALJOCEHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6609180", Offset = "0x6607F80", VA = "0x186609180", Slot = "7")]
		protected override void BMAJAPEBNGH(Camera LNALJOCEHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6609200", Offset = "0x6608000", VA = "0x186609200")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool JDLNAGJIGCB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool OABCEOIABFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6609470", Offset = "0x6608270", VA = "0x186609470", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6609470", Offset = "0x6608270", VA = "0x186609470")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		protected virtual void OBGIBCOLCJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void LIPKCOHNHFI();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		protected VisibilityRestriction()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6608B50", Offset = "0x6607950", VA = "0x186608B50")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6608C60", Offset = "0x6607A60", VA = "0x186608C60")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
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
