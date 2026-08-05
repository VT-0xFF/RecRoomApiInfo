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
		public enum MJNJPOCFFKJ
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
		public enum JKPFOOFHADI
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private MJNJPOCFFKJ visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private JKPFOOFHADI evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool JNGNMNOJDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool ODKNKKHDCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool JGJNLIKAHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool LEHECEEJCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ABLBCPBEONM JGEOGMFPMNL;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67A7840", Offset = "0x67A6A40", VA = "0x1867A7840", Slot = "5")]
		protected override void ADEDEAJHKFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67A7D50", Offset = "0x67A6F50", VA = "0x1867A7D50", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67A7C20", Offset = "0x67A6E20", VA = "0x1867A7C20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67A7B70", Offset = "0x67A6D70", VA = "0x1867A7B70")]
		private void HOBKBIIDJGH(bool JNGNMNOJDLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67A7B80", Offset = "0x67A6D80", VA = "0x1867A7B80")]
		private void JFJLDILJMAC(bool JNGNMNOJDLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67A79D0", Offset = "0x67A6BD0", VA = "0x1867A79D0", Slot = "6")]
		protected override void BGAOMEFNMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
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
		[BCLPDJMEMPD("Alters the behavior of this object when rendered in photos taken by junior players")]
		[BCLPDJMEMPD("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", BCLPDJMEMPD.MFHDAGMCCFL.Warning)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private FIHGBEHGLGB FNENCDCNMOO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NIMPLFJIHAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x112E5A0", Offset = "0x112D7A0", VA = "0x18112E5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67A7E00", Offset = "0x67A7000", VA = "0x1867A7E00", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67A7E90", Offset = "0x67A7090", VA = "0x1867A7E90", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67A7FC0", Offset = "0x67A71C0", VA = "0x1867A7FC0")]
		public void SetPaused(bool AEINBIKHGME, UnityEngine.Object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67A7F70", Offset = "0x67A7170", VA = "0x1867A7F70")]
		public void PreRender(Camera GAPPCJHIBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void OFMBNJDMFLN(Camera GAPPCJHIBEK);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67A7F20", Offset = "0x67A7120", VA = "0x1867A7F20")]
		public void PostRender(Camera GAPPCJHIBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void IMHJNADPAKL(Camera GAPPCJHIBEK);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x67A8080", Offset = "0x67A7280", VA = "0x1867A8080")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct PEJNIGGGFOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] OJEJOANMCEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] HCEPBEKDIMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] BDBLJPDGGLI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private PEJNIGGGFOE MIONENNEMEJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x67A87E0", Offset = "0x67A79E0", VA = "0x1867A87E0")]
		public static PEJNIGGGFOE PreRender(GameObject BMNLOPDIJGF)
		{
			return default(PEJNIGGGFOE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x67A8620", Offset = "0x67A7820", VA = "0x1867A8620")]
		public static void PostRender(PEJNIGGGFOE MMOBMFGIJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67A85E0", Offset = "0x67A77E0", VA = "0x1867A85E0", Slot = "6")]
		protected override void OFMBNJDMFLN(Camera GAPPCJHIBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67A8110", Offset = "0x67A7310", VA = "0x1867A8110", Slot = "7")]
		protected override void IMHJNADPAKL(Camera GAPPCJHIBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67A89B0", Offset = "0x67A7BB0", VA = "0x1867A89B0")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67A82C0", Offset = "0x67A74C0", VA = "0x1867A82C0")]
		[CompilerGenerated]
		internal static (Component, bool)[] NLCBBOMOLAI(IEnumerable<Component> LGJGAACOOON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x67A80F0", Offset = "0x67A72F0", VA = "0x1867A80F0")]
		[CompilerGenerated]
		internal static void EFPKBAABCAE((Component, bool) CGJOPPCMNEK)
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
		[Cpp2IlInjected.Address(RVA = "0x67A8A90", Offset = "0x67A7C90", VA = "0x1867A8A90", Slot = "6")]
		protected override void OFMBNJDMFLN(Camera GAPPCJHIBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67A8A50", Offset = "0x67A7C50", VA = "0x1867A8A50", Slot = "7")]
		protected override void IMHJNADPAKL(Camera GAPPCJHIBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67A8AD0", Offset = "0x67A7CD0", VA = "0x1867A8AD0")]
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
		private Material[] EELLBKPJNBB;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67A8BA0", Offset = "0x67A7DA0", VA = "0x1867A8BA0", Slot = "6")]
		protected override void OFMBNJDMFLN(Camera GAPPCJHIBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67A8B70", Offset = "0x67A7D70", VA = "0x1867A8B70", Slot = "7")]
		protected override void IMHJNADPAKL(Camera GAPPCJHIBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67A8BF0", Offset = "0x67A7DF0", VA = "0x1867A8BF0")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool HOCFFNMCCJJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JLBICJLGLBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67A9490", Offset = "0x67A8690", VA = "0x1867A9490", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67A9490", Offset = "0x67A8690", VA = "0x1867A9490")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		protected virtual void ADEDEAJHKFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void BGAOMEFNMME();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		protected VisibilityRestriction()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67A8C90", Offset = "0x67A7E90", VA = "0x1867A8C90")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67A8DA0", Offset = "0x67A7FA0", VA = "0x1867A8DA0")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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
